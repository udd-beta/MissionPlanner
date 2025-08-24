using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Security.Claims;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static MAVLink;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace SimpleExample
{
    public partial class simpleexample : Form
    {
        MAVLink.MavlinkParse mavlink = new MAVLink.MavlinkParse();
        bool armed = false;
        // locking to prevent multiple reads on serial port
        object readlock = new object();
        // our target sysid
        byte sysid;
        // our target compid
        byte compid;
        double prevAngle = 0;
        double prevTime = 0;
        double diffTime = 0;
        double imuTime = 0;
        (double, double, double) positionViaGPS;
        (double, double, double) positionViaHUD;
        KalmanFilter[] filtered = new KalmanFilter[12];
        double wayLength = 0;
        double initAccX = 0;
        double initAccY = 0;
        double initAccZ = 0;
        double gyroWay = 0;
        double accWay = 0;
        double maxAcc = 0;
        double maxGyro = 0;
        double sumAcc = 0;
        double vacc = 0;
        const int rowsCount = 16;
        const int colsCount = 16;
        const int avgsCount = 10;
        int[,] tendency = new int[rowsCount, colsCount];
        List<double>[,] lastValues = new List<double>[rowsCount, colsCount];
        const string title = "Дані з польотного контролера";
        string[] themes = {"Користувацький набір", "Повний набір", "Прямий хід + зворотній хід", "Прямо + розворот + назад", "Показати всі суми", "Приховати всі суми"};
        string[] IMUnames = {"xAcc", "yAcc", "zAcc", "xGyro", "yGyro", "zGyro", "xMag", "yMag", "zMag", "dir", "velo"};
        string[] mathNames = {"originalCheckBox", "originalSumCheckBox", "originalSum10CheckBox", "originalAvgCheckBox", "originalAvg10CheckBox",
            "absoluteCheckBox", "absoluteSumCheckBox", "absoluteSum10CheckBox", "absoluteAvgCheckBox", "absoluteAvg10CheckBox"};
        const int baseSeriesCount = 9;
        (double, int)[] sums;
        (double, int)[] sumsAbs;
        (double, List<double>)[] sums10;
        (double, List<double>)[] sumsAbs10;
        double[] prevValues;
        double[] prevConst;
        const int lastObserved = 10;
        double lastConstAcc = 0;
        double prevAcc = 0;
        const double msToS = 0.001;
        const double mmToM = 0.001;
        const double cmToM = 0.01;
        const double mgToMs = 0.001 / 9.80665;
        double[] vibration = {0, 0, 0};
        double commonVibration = 0;

        public simpleexample()
        {
            InitializeComponent();
            initializeMainPanel();
            initializeGrid();
            initializeChart();
        }

        private void initializeMainPanel()
        {
            Text = title;
            CMB_comport.DataSource = SerialPort.GetPortNames();
            if (CMB_comport.Items.Count > 0)
                CMB_comport.Text = CMB_comport.Items[0].ToString();
            if (cmb_baudrate.Items.Count > 0)
                cmb_baudrate.Text = cmb_baudrate.Items[0].ToString();
            tabControl.SelectedIndex = 2;
            hideStateNotification();
        }

        private void hideStateNotification()
        {
            vibrationLabel.Visible = false;
            backwardLabel.Visible = false;
            forwardLabel.Visible = false;
            rightLabel.Visible = false;
            leftLabel.Visible = false;
        }

        private void initializeGrid()
        {
            IMUdataGridView.ColumnCount = colsCount;
            IMUdataGridView.RowCount = rowsCount;
            foreach (DataGridViewColumn column in IMUdataGridView.Columns)
                column.Width = 50;
            IMUdataGridView.RowHeadersWidth = 150;
            for (int i = 0; i < IMUdataGridView.Rows.Count; i += 2)
                IMUdataGridView.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
            IMUdataGridView.Rows[0].HeaderCell.Value = "ATTITUDE";
            IMUdataGridView.Rows[0].SetValues("time_boot_ms", "roll", "pitch", "yaw", "rollspeed", "pitchspeed", "yawspeed");
            IMUdataGridView.Rows[2].HeaderCell.Value = "GLOBAL_POSITION_INT";
            IMUdataGridView.Rows[2].SetValues("time_boot_ms", "lat", "lon", "alt", "relative_alt", "vx", "vy", "vz", "hdg");
            IMUdataGridView.Rows[4].HeaderCell.Value = "VFR_HUD";
            IMUdataGridView.Rows[4].SetValues("airspeed", "groundspeed", "heading", "throttle", "alt", "climb");
            IMUdataGridView.Rows[6].HeaderCell.Value = "RAW_IMU";
            IMUdataGridView.Rows[6].SetValues("time_usec", "xacc", "yacc", "zacc", "xgyro", "ygyro", "zgyro", "xmag", "ymag", "zmag");
            IMUdataGridView.Rows[8].HeaderCell.Value = "SCALED_IMU2";
            IMUdataGridView.Rows[8].SetValues("time_boot_ms", "xacc", "yacc", "zacc", "xgyro", "ygyro", "zgyro", "xmag", "ymag", "zmag");
            IMUdataGridView.Rows[10].HeaderCell.Value = "SCALED_IMU3";
            IMUdataGridView.Rows[10].SetValues("time_boot_ms", "xacc", "yacc", "zacc", "xgyro", "ygyro", "zgyro", "xmag", "ymag", "zmag");
            IMUdataGridView.Rows[12].HeaderCell.Value = "GPS_RAW_INT";
            //IMUdataGridView.Rows[12].SetValues("time_usec", "fix_type", "lat", "lon", "alt", "eph", "epv", "vel", "cog", "satellites_visible", "alt_ellipsoid", "h_acc", "v_acc", "vel_acc", "hdg_acc", "yaw");
            IMUdataGridView.Rows[14].HeaderCell.Value = "VIBRATION";
            IMUdataGridView.Rows[14].SetValues("time_usec", "vibration_x", "vibration_y", "vibration_z", "clipping_0", "clipping_1", "clipping_2");
            for (int i = 0; i < rowsCount; ++i)
                for (int j = 0; j < colsCount; ++j)
                {
                    tendency[i, j] = 0;
                    lastValues[i, j] = new List<double>();
                }
        }

        private void initializeChart()
        {
            IMUchart.Series.Clear();
            int n = 0;
            sums = new (double, int)[baseSeriesCount];
            sumsAbs = new (double, int)[baseSeriesCount];
            sums10 = new (double, List<double>)[baseSeriesCount];
            sumsAbs10 = new (double, List<double>)[baseSeriesCount];
            prevValues = new double[baseSeriesCount];
            prevConst = new double[baseSeriesCount];
            foreach (string name in IMUnames)
            {
                if (n < 3)
                    addPackOfSeries(name, Color.FromArgb(255, 100 * n + 55, 0, 0));
                else if (n < 6)
                    addPackOfSeries(name, Color.FromArgb(255, 0, 100 * n - 245, 0));
                else if (n < 9)
                    addPackOfSeries(name, Color.FromArgb(255, 0, 0, 100 * n - 545));
                else
                    break;
                ++n;
            }
            addSingleSeries();
            IMUchart.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            IMUchart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            IMUchart.ChartAreas[0].AxisY.Maximum = (double)maxYNumericUpDown.Value;
            IMUchart.ChartAreas[0].AxisY.Minimum = (double)minYNumericUpDown.Value;
            IMUchart.ChartAreas[0].AxisY.Interval = (IMUchart.ChartAreas[0].AxisY.Maximum - IMUchart.ChartAreas[0].AxisY.Minimum) / (int)divisionsNumericUpDown.Value;
            themesComboBox.Items.Clear();
            foreach (string item in themes)
                themesComboBox.Items.Add(item);
            themesComboBox.SelectedIndex = 0;
            IMUchart.ChartAreas[0].CursorX.AutoScroll = true;
            IMUchart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            IMUchart.ChartAreas[0].AxisX.ScaleView.SizeType = DateTimeIntervalType.Number;
            IMUchart.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
        }

        private void addPackOfSeries(string name, Color color)
        {
            addNewSeries(name, ChartDashStyle.Solid, 2, color);
            addNewSeries(name + "Sum", ChartDashStyle.Dash, 2, color);
            addNewSeries(name + "Sum10", ChartDashStyle.DashDot, 2, color);
            addNewSeries(name + "Avg", ChartDashStyle.DashDotDot, 2,color);
            addNewSeries(name + "Avg10", ChartDashStyle.Dot, 2, color);
            addNewSeries(name + "Abs", ChartDashStyle.Solid, 3, color);
            addNewSeries(name + "AbsSum", ChartDashStyle.Dash, 3, color);
            addNewSeries(name + "AbsSum10", ChartDashStyle.DashDot, 3, color);
            addNewSeries(name + "AbsAvg", ChartDashStyle.DashDotDot, 3, color);
            addNewSeries(name + "AbsAvg10", ChartDashStyle.Dot, 3, color);
        }

        private void addSingleSeries()
        {
            int nameId = baseSeriesCount;
            int seriesId = nameId * mathNames.Count();
            addNewSeries(IMUnames[nameId++], ChartDashStyle.Solid, 2, Color.FromArgb(255, 155, 0, 155));
            IMUchart.Series[seriesId++].Enabled = dirCheckBox.Checked;
            addNewSeries(IMUnames[nameId++], ChartDashStyle.Solid, 2, Color.FromArgb(255, 155, 155, 0)); ;
            IMUchart.Series[seriesId++].Enabled = veloCheckBox.Checked;
            //addNewSeries(IMUnames[nameId], ChartDashStyle.Solid, 2, Color.FromArgb(255, 0, 155, 155));
        }

        private void addNewSeries(string name, ChartDashStyle style, int width, Color color)
        {
            Series series = new Series(name);
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = width;
            series.BorderDashStyle = style;
            series.Color = color;
            series.Enabled = false;
            IMUchart.Series.Add(series);
        }

        private void but_connect_Click(object sender, EventArgs e)
        {
            // if the port is open close it
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                hideStateNotification();
                return;
            }

            if (!Text.StartsWith("*"))
                Text = "*" + Text;

            // set the comport options
            serialPort1.PortName = CMB_comport.Text;
            serialPort1.BaudRate = int.Parse(cmb_baudrate.Text);

            // open the comport
            serialPort1.Open();

            // set timeout to 2 seconds
            serialPort1.ReadTimeout = 2000;

            BackgroundWorker bgw = new BackgroundWorker();
            bgw.WorkerReportsProgress = true;
            bgw.DoWork += bgw_DoWork;
            bgw.ProgressChanged += bgw_ProgressChanged;
            bgw.RunWorkerAsync();
        }

        void processMessageType<T>(object sender, MAVLink.MAVLinkMessage packet)
        {
            if (packet.data.GetType() != typeof(T))
                return;
            var data = (T)packet.data;
            BackgroundWorker worker = sender as BackgroundWorker;
            worker.ReportProgress(0, data);
        }

        void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            while (serialPort1.IsOpen)
            {
                try
                {
                    MAVLink.MAVLinkMessage packet;
                    lock (readlock)
                    {
                        // read any valid packet from the port
                        packet = mavlink.ReadPacket(serialPort1.BaseStream);
                        
                        // check its valid
                        if (packet == null || packet.data == null)
                            continue;
                    }

                    processMessageType<mavlink_attitude_t>(sender, packet);
                    processMessageType<mavlink_global_position_int_t>(sender, packet);
                    processMessageType<mavlink_vfr_hud_t>(sender, packet);
                    processMessageType<mavlink_raw_imu_t>(sender, packet);
                    processMessageType<mavlink_scaled_imu2_t>(sender, packet);
                    processMessageType<mavlink_scaled_imu3_t>(sender, packet);
                    processMessageType<mavlink_gps_raw_int_t>(sender, packet);
                    processMessageType<mavlink_vibration_t>(sender, packet);

                    // check to see if its a hb packet from the comport
                    if (packet.data.GetType() == typeof(MAVLink.mavlink_heartbeat_t))
                    {
                        var hb = (MAVLink.mavlink_heartbeat_t)packet.data;

                        // save the sysid and compid of the seen MAV
                        sysid = packet.sysid;
                        compid = packet.compid;

                        // request streams at 2 hz
                        var buffer = mavlink.GenerateMAVLinkPacket10(MAVLink.MAVLINK_MSG_ID.REQUEST_DATA_STREAM,
                            new MAVLink.mavlink_request_data_stream_t()
                            {
                                req_message_rate = 2,
                                req_stream_id = (byte)MAVLink.MAV_DATA_STREAM.ALL,
                                start_stop = 1,
                                target_component = compid,
                                target_system = sysid
                            });

                        serialPort1.Write(buffer, 0, buffer.Length);

                        buffer = mavlink.GenerateMAVLinkPacket10(MAVLink.MAVLINK_MSG_ID.HEARTBEAT, hb);

                        serialPort1.Write(buffer, 0, buffer.Length);
                    }

                    // from here we should check the the message is addressed to us
                    if (sysid != packet.sysid || compid != packet.compid)
                        continue;

                    Console.WriteLine(packet.msgtypename);
                    
                    if (packet.msgid == (byte)MAVLink.MAVLINK_MSG_ID.ATTITUDE)
                    //or
                    //if (packet.data.GetType() == typeof(MAVLink.mavlink_attitude_t))
                    {
                        var att = (MAVLink.mavlink_attitude_t)packet.data;

                        Console.WriteLine(att.pitch*57.2958 + " " + att.roll*57.2958);
                    }
                }
                catch
                {
                }

                System.Threading.Thread.Sleep(1);
            }
        }
        private void updateCell(int row, int col, double inValue)
        {
            var list = lastValues[row, col];
            double value = inValue;
            if (list.Count > 0)
            {
                if (list.Count == avgsCount)
                    list.RemoveAt(0);
                foreach (double v in list)
                    value += v;
                list.Add(inValue);
                value /= list.Count;
            }
            var cell = IMUdataGridView.Rows[row].Cells[col];
            if (cell.Value != null)
            {
                if (value < Convert.ToDouble(cell.Value))
                {
                    if (tendency[row, col] >= 0)
                        tendency[row, col] = -1;
                    else
                        --tendency[row, col];
                    if (tendency[row, col] < -4)
                        cell.Style.BackColor = Color.Red;
                    else
                        cell.Style.BackColor = Color.LightCoral;
                }
                else if (value > Convert.ToDouble(cell.Value))
                {
                    if (tendency[row, col] <= 0)
                        tendency[row, col] = 1;
                    else
                        ++tendency[row, col];
                    if (tendency[row, col] > 4)
                        cell.Style.BackColor = Color.Green;
                    else
                        cell.Style.BackColor = Color.LightGreen;
                }
                else
                {
                    tendency[row, col] = 0;
                    cell.Style.BackColor = Color.White;
                }
            }
            cell.Value = value;
        }

        private void fillTable(ProgressChangedEventArgs e)
        {
            var userData = e.UserState;
            if (userData.GetType() == typeof(mavlink_attitude_t))
            {
                var data = (mavlink_attitude_t)userData;
                updateCell(1, 0, data.time_boot_ms); updateCell(1, 1, data.roll); updateCell(1, 2, data.pitch); updateCell(1, 3, data.yaw); updateCell(1, 4, data.rollspeed); updateCell(1, 5, data.pitchspeed); updateCell(1, 6, data.yawspeed);
            }
            else if (userData.GetType() == typeof(mavlink_global_position_int_t))
            {
                var data = (mavlink_global_position_int_t)userData;
                updateCell(3, 0, data.time_boot_ms); updateCell(3, 1, data.lat); updateCell(3, 2, data.lon); updateCell(3, 3, data.alt); updateCell(3, 4, data.relative_alt); updateCell(3, 5, data.vx); updateCell(3, 6, data.vy); updateCell(3, 7, data.vz); updateCell(3, 8, data.hdg);
            }
            else if (userData.GetType() == typeof(mavlink_vfr_hud_t))
            {
                var data = (mavlink_vfr_hud_t)userData;
                updateCell(5, 0, data.airspeed); updateCell(5, 1, data.groundspeed); updateCell(5, 2, data.heading); updateCell(5, 3, data.throttle); updateCell(5, 4, data.alt); updateCell(5, 5, data.climb);
            }
            else if (userData.GetType() == typeof(mavlink_raw_imu_t))
            {
                var data = (mavlink_raw_imu_t)userData;
                updateCell(7, 0, data.time_usec); updateCell(7, 1, data.xacc); updateCell(7, 2, data.yacc); updateCell(7, 3, data.zacc); updateCell(7, 4, data.xgyro); updateCell(7, 5, data.ygyro); updateCell(7, 6, data.zgyro); updateCell(7, 7, data.xmag); updateCell(7, 8, data.ymag); updateCell(7, 9, data.zmag);
            }
            else if (userData.GetType() == typeof(mavlink_scaled_imu2_t))
            {
                var data = (mavlink_scaled_imu2_t)userData;
                updateCell(9, 0, data.time_boot_ms); updateCell(9, 1, data.xacc); updateCell(9, 2, data.yacc); updateCell(9, 3, data.zacc); updateCell(9, 4, data.xgyro); updateCell(9, 5, data.ygyro); updateCell(9, 6, data.zgyro); updateCell(9, 7, data.xmag); updateCell(9, 8, data.ymag); updateCell(9, 9, data.zmag);
            }
            else if (userData.GetType() == typeof(mavlink_scaled_imu3_t))
            {
                var data = (mavlink_scaled_imu3_t)userData;
                updateCell(11, 0, data.time_boot_ms); updateCell(11, 1, data.xacc); updateCell(11, 2, data.yacc); updateCell(11, 3, data.zacc); updateCell(11, 4, data.xgyro); updateCell(11, 5, data.ygyro); updateCell(11, 6, data.zgyro); updateCell(11, 7, data.xmag); updateCell(11, 8, data.ymag); updateCell(11, 9, data.zmag);
            }
            else if (userData.GetType() == typeof(mavlink_gps_raw_int_t))
            {
                //    var data = (mavlink_gps_raw_int_t)userData;
                //    IMUdataGridView.Rows[13].SetValues(data.time_usec, data.fix_type, data.lat, data.lon, data.alt, data.eph, data.epv, data.vel, data.cog, data.satellites_visible, data.alt_ellipsoid, data.h_acc, data.v_acc, data.vel_acc, data.hdg_acc, data.yaw);
            }
            else if (userData.GetType() == typeof(mavlink_vibration_t))
            {
                var data = (mavlink_vibration_t)userData;
                updateCell(15, 0, data.time_usec); updateCell(15, 1, data.vibration_x); updateCell(15, 2, data.vibration_y); updateCell(15, 3, data.vibration_z); updateCell(15, 4, data.clipping_0); updateCell(15, 5, data.clipping_1); updateCell(15, 6, data.clipping_2);
            }
        }

        private bool areEqual(double value1, double value2)
        {
            return Math.Abs(value1 - value2) < Math.Max(10, Math.Max(Math.Abs(value1), Math.Abs(value2)) * 0.2);
        }

        private void updatePackOfSeries(int id, double time, double value)
        {
            if (id >= baseSeriesCount)
            {
                var baseCount = baseSeriesCount * mathNames.Length;
                updateChart(id - baseSeriesCount + baseCount, time, value);
                return;
            }
            if (noiseCheckBox.Checked)
            {
                const double noiseLimit = 0.5;
                var noiseLevel = commonVibration;// vibration[id % 3];
                if (noiseLevel > noiseLimit)
                    value /= (noiseLevel - noiseLimit) * 1000;
            }
            var currentId = id * mathNames.Length;
            var correctedValue = value - prevConst[id];
            if (zeroCheckBox.Checked && areEqual(prevValues[id], value))
            {
                correctedValue = 0;
                prevConst[id] = value;
            }
            updateHalfPackOfSeries(id, ref currentId, time, correctedValue, ref sums, ref sums10);
            updateHalfPackOfSeries(id, ref currentId, time, Math.Abs(correctedValue), ref sumsAbs, ref sumsAbs10);
            prevValues[id] = value;
        }

        private double progressionSum(int n)
        {
            return 0.5 * (n + 1) * n;
        }

        private void updateHalfPackOfSeries(int id, ref int currentId, double time, double value, ref (double, int)[] s, ref (double, List<double>)[] s10)
        {
            if (IMUchart.Series[currentId].Points.Count == 0 || areEqual(prevValues[id] - prevConst[id], value))
            {
                s10[id] = (value, new List<double> { value });
                s[id] = (value, 1);
            }
            else
            {
                s10[id].Item1 = value;
                s10[id].Item2.Add(value);
                s[id].Item1 += value;
                s[id].Item2++;
                if (s10[id].Item2.Count > lastObserved)
                    s10[id].Item2.RemoveAt(0);
                int n = s10[id].Item2.Count;
                for (int i = 1; i < n; ++i)
                    s10[id].Item1 += s10[id].Item2[i - 1] * i / n;
            }
            updateChart(currentId++, time, value);
            updateChart(currentId++, time, s[id].Item1);
            updateChart(currentId++, time, s10[id].Item1);
            updateChart(currentId++, time, s[id].Item1 / s[id].Item2);
            updateChart(currentId++, time, s10[id].Item1 * 2 / (s10[id].Item2.Count + 1));
        }

        private void updateChart(int id, double time, double value)
        {
            const double msToS = 0.001;
            var series = IMUchart.Series[id];
            series.Points.AddXY(Math.Round(time * msToS * msToS, 1), value);
        }

        private void rescaleChart()
        {
            var series = IMUchart.Series[0];
            if (series.Points.Count == 0)
                return;
            var begin = series.Points[Math.Max(0, series.Points.Count - (int)diapasonNumericUpDown.Value)].XValue;
            var end = series.Points[series.Points.Count - 1].XValue;
            IMUchart.ChartAreas[0].AxisX.ScaleView.Zoom(begin, end);
            IMUchart.ChartAreas[0].AxisX.Minimum = series.Points[0].XValue;
            IMUchart.ChartAreas[0].AxisX.Maximum = series.Points[series.Points.Count - 1].XValue;
        }

        private void fillChart(ProgressChangedEventArgs e)
        {
            var userData = e.UserState;
            if (userData.GetType() == typeof(mavlink_raw_imu_t))
            {
                var data = (mavlink_raw_imu_t)userData;
                updatePackOfSeries(0, data.time_usec, data.xacc);
                updatePackOfSeries(1, data.time_usec, data.yacc);
                updatePackOfSeries(2, data.time_usec, data.zacc);
                updatePackOfSeries(3, data.time_usec, data.xgyro);
                updatePackOfSeries(4, data.time_usec, data.ygyro);
                updatePackOfSeries(5, data.time_usec, data.zgyro);
                updatePackOfSeries(6, data.time_usec, data.xmag);
                updatePackOfSeries(7, data.time_usec, data.ymag);
                updatePackOfSeries(8, data.time_usec, data.zmag);
                //updatePairOfSeries(9, data.time_usec, Math.Abs(data.zgyro));
                var count = IMUchart.Series[0].Points.Count;
                if (count > 0 && Math.Abs(prevAcc - data.xacc) > 4)
                    vacc -= (data.xacc + data.yacc * Math.Sign(data.zgyro) + Math.Abs(lastConstAcc)) / 2;
                else
                {
                    vacc = 0;
                    lastConstAcc = data.xacc;
                }
                prevAcc = data.xacc;
                updatePackOfSeries(10, data.time_usec, vacc);
                rescaleChart();
            }
            else if (userData.GetType() == typeof(mavlink_global_position_int_t))
            {
                var data = (mavlink_global_position_int_t)userData;
                updatePackOfSeries(9, data.time_boot_ms / msToS, data.hdg * cmToM);
            }
            else if (userData.GetType() == typeof(mavlink_vibration_t))
            {
                var data = (mavlink_vibration_t)userData;
                vibration[0] = data.vibration_x;
                vibration[1] = data.vibration_y;
                vibration[2] = data.vibration_z;
                commonVibration = vibration[0] * vibration[0] + vibration[1] * vibration[1] + vibration[2] * vibration[2];
            }
        }

        private void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var userData = e.UserState;
            if (userData.GetType() == typeof(mavlink_global_position_int_t))
            {
                var data = (mavlink_global_position_int_t)userData;
                vxTextBox.Text = (data.vx * cmToM).ToString();
                vyTextBox.Text = (data.vy * cmToM).ToString();
                vzTextBox.Text = (data.vz * cmToM).ToString();
                var currTime = data.time_boot_ms * msToS;
                diffTime = (currTime - prevTime);
                if (z0TextBox.Text.Length == 0)
                {
                    positionViaGPS = (data.lon * mmToM, data.lat * mmToM, data.alt * mmToM);
                    x0TextBox.Text = x1TextBox.Text = positionViaGPS.Item1.ToString();
                    y0TextBox.Text = y1TextBox.Text = positionViaGPS.Item2.ToString();
                    z0TextBox.Text = z1TextBox.Text = positionViaGPS.Item3.ToString();
                }
                else
                {
                    var dt = diffTime * cmToM;
                    positionViaGPS.Item1 += data.vx * dt;
                    positionViaGPS.Item2 += data.vy * dt;
                    positionViaGPS.Item3 += data.vz * dt;
                    x1TextBox.Text = Math.Round(positionViaGPS.Item1, 2).ToString();
                    y1TextBox.Text = Math.Round(positionViaGPS.Item2, 2).ToString();
                    z1TextBox.Text = Math.Round(positionViaGPS.Item3, 2).ToString();
                }
                prevTime = currTime;
                timeTextBox.Text = prevTime.ToString();
                orientTextBox.Text = (data.hdg * cmToM).ToString();
            }
            else if (userData.GetType() == typeof(mavlink_vfr_hud_t))
            {
                var data = (mavlink_vfr_hud_t)userData;
                headingTextBox.Text = data.heading.ToString();
                vAirSpeedTextBox.Text = data.airspeed.ToString();
                vGroundSpeedTextBox.Text = Math.Round(data.groundspeed, 1).ToString();
                altTextBox.Text = data.alt.ToString();
                climbTextBox.Text = Math.Round(data.climb, 2).ToString();
                throttleTextBox.Text = data.throttle.ToString();
                double angle = data.heading * Math.PI / 180;
                if (dxTextBox.Text.Length == 0)
                {
                    positionViaHUD = (0, 0, 0);
                    dxTextBox.Text = positionViaGPS.Item1.ToString();
                    dyTextBox.Text = positionViaGPS.Item2.ToString();
                    dzTextBox.Text = positionViaGPS.Item3.ToString();
                }
                else if (Math.Abs(data.groundspeed) > 0.2)
                {
                    double averageAngle = (prevAngle + angle) * 0.5;
                    var delta = diffTime * data.groundspeed;
                    positionViaHUD.Item1 += delta * Math.Sin(averageAngle);
                    positionViaHUD.Item2 += delta * Math.Cos(averageAngle);
                    positionViaHUD.Item3 += delta * data.climb;
                    dxTextBox.Text = Math.Round(positionViaHUD.Item1, 2).ToString();
                    dyTextBox.Text = Math.Round(positionViaHUD.Item2, 2).ToString();
                    dzTextBox.Text = Math.Round(positionViaHUD.Item3, 2).ToString();
                }
                prevAngle = angle;
            }
            else if (userData.GetType() == typeof(mavlink_raw_imu_t))
            {
                var data = (mavlink_raw_imu_t)userData;
                time_usecTextBox.Text = (data.time_usec * msToS * msToS).ToString();
                idTextBox.Text = data.id.ToString();
                temperatureTextBox.Text = data.temperature.ToString();
                double xacc = mgToMs * (data.xacc - initAccX);
                double yacc = mgToMs * (data.yacc - initAccY);
                double zacc = mgToMs * (data.zacc - initAccZ);
                xaccTextBox.Text = Math.Round(xacc, 3).ToString();
                yaccTextBox.Text = Math.Round(yacc, 3).ToString();
                zaccTextBox.Text = Math.Round(zacc, 3).ToString();
                xgyroTextBox.Text = Math.Round(mmToM * data.xgyro, 1).ToString();
                ygyroTextBox.Text = Math.Round(mmToM * data.ygyro, 1).ToString();
                zgyroTextBox.Text = Math.Round(mmToM * data.zgyro, 1).ToString();
                xmagTextBox.Text = Math.Round(mmToM * data.xmag, 1).ToString();
                ymagTextBox.Text = Math.Round(mmToM * data.ymag, 1).ToString();
                zmagTextBox.Text = Math.Round(mmToM * data.zmag, 1).ToString();

                //fxaccTextBox.Text = Math.Round(mgToMs * filter.process(data.xacc), 3).ToString();
                //fyaccTextBox.Text = Math.Round(mgToMs * filter.process(data.yacc), 3).ToString();
                //fzaccTextBox.Text = Math.Round(mgToMs * filter.process(data.zacc), 3).ToString();
                //fxgyroTextBox.Text = Math.Round(mmToM * filter.process(data.xgyro), 1).ToString();
                //fygyroTextBox.Text = Math.Round(mmToM * filter.process(data.ygyro), 1).ToString();
                //fzgyroTextBox.Text = Math.Round(mmToM * filter.process(data.zgyro), 1).ToString();
                //fxmagTextBox.Text = Math.Round(mmToM * filter.process(data.xmag), 1).ToString();
                //fymagTextBox.Text = Math.Round(mmToM * filter.process(data.ymag), 1).ToString();
                //fzmagTextBox.Text = Math.Round(mmToM * filter.process(data.zmag), 1).ToString();

                if (imuTime == 0)
                {
                    imuTime = data.time_usec;
                    initAccX = data.xacc;
                    initAccY = data.yacc;
                    initAccZ = data.zacc;
                    sumAcc = 0;
                    return;
                }
                var dt = 0.5;// (data.time_usec - imuTime) * msToS;
                imuTime = data.time_usec;
                const double accSencitivity = 0.002;// 8192.0 / mmToM;
                const double gyroSensitivity = 10.0;// 65.536 / mmToM;
                const double accMultiplier = 6;
                const double gyroMutliplier = 0.7;
                sumAcc += xacc;
                var acc = xacc;// Math.Sqrt(xacc * xacc + yacc + yacc);
                if (Math.Abs(acc) > maxAcc)
                    maxAcc = Math.Abs(acc);
                if (Math.Abs(data.zgyro) > maxGyro)
                    maxGyro = Math.Abs(data.zgyro);
                if (Math.Abs(acc) > accSencitivity)
                {
                    var way = Math.Round(Math.Sqrt(Math.Abs(acc)) * accMultiplier * dt * dt, 3);
                    if (sumAcc > 0)
                        accWay += way;
                    else
                        accWay -= way;
                }
                if (Math.Abs(data.zgyro) > gyroSensitivity)
                {
                    var way = Math.Round(Math.Abs(data.zgyro) * gyroMutliplier * mmToM * dt, 3);
                    if (sumAcc > 0)
                        gyroWay += way;
                    else
                        gyroWay -= way;
                }
                accTextBox.Text = accWay.ToString();
                gyroTextBox.Text = gyroWay.ToString();
                wayTextBox.Text = (accWay + gyroWay).ToString();
                maxAccTextBox.Text = Math.Round(maxAcc, 3).ToString();
                maxGyroTextBox.Text = Math.Round(maxGyro, 3).ToString();
                sumAccTextBox.Text = Math.Round(sumAcc, 3).ToString();
            }
            else if (userData.GetType() == typeof(mavlink_gps_raw_int_t))
            {
                var data = (mavlink_gps_raw_int_t)userData;
                rawLatTextBox.Text = data.lat.ToString();
                rawLonTextBox.Text = data.lon.ToString();
                rawAltTextBox.Text = data.alt.ToString();
            }

            fillTable(e);
            fillChart(e);
            updateVibration();
            updateTranslation();
            updateRotation();
        }

        private void updateVibration()
        {
            vibrationLabel.Visible = false;
            if (IMUdataGridView.Rows[15].Cells[3].Value == null)
                return;
            double vibrationLimit = 0.2;
            if (Convert.ToDouble(IMUdataGridView.Rows[15].Cells[1].Value) > vibrationLimit &&
                Convert.ToDouble(IMUdataGridView.Rows[15].Cells[2].Value) > vibrationLimit &&
                Convert.ToDouble(IMUdataGridView.Rows[15].Cells[3].Value) > vibrationLimit)
                vibrationLabel.Visible = true;
        }

        private void updateTranslation()
        {
            forwardLabel.Visible = backwardLabel.Visible = false;
            var value = IMUdataGridView.Rows[7].Cells[1].Value;
            if (value == null)
                return;
            double translationLimit = 5;
            if (vibrationLabel.Visible)
                translationLimit *= Convert.ToDouble(IMUdataGridView.Rows[15].Cells[1].Value) * 100;
            forwardLabel.Visible = vacc > translationLimit;
            backwardLabel.Visible = vacc < -translationLimit;
        }

        private void updateRotation()
        {
            rightLabel.Visible = leftLabel.Visible = false;
            var value = IMUdataGridView.Rows[7].Cells[6].Value;
            double rotationLimit = 500;
            if (value == null || Math.Abs(Convert.ToDouble(value)) < rotationLimit)
                return;
            rightLabel.Visible = Convert.ToDouble(value) > rotationLimit == forwardLabel.Visible;
            leftLabel.Visible = !rightLabel.Visible;
        }

        T readsomedata<T>(byte sysid,byte compid,int timeout = 2000)
        {
            DateTime deadline = DateTime.Now.AddMilliseconds(timeout);

            lock (readlock)
            {
                // read the current buffered bytes
                while (DateTime.Now < deadline)
                {
                    var packet = mavlink.ReadPacket(serialPort1.BaseStream);

                    // check its not null, and its addressed to us
                    if (packet == null || sysid != packet.sysid || compid != packet.compid)
                        continue;

                    Console.WriteLine(packet);

                    if (packet.data.GetType() == typeof (T))
                    {
                        return (T) packet.data;
                    }
                }
            }

            throw new Exception("No packet match found");
        }

        private void but_armdisarm_Click(object sender, EventArgs e)
        {
            MAVLink.mavlink_command_long_t req = new MAVLink.mavlink_command_long_t();

            req.target_system = 1;
            req.target_component = 1;

            req.command = (ushort)MAVLink.MAV_CMD.COMPONENT_ARM_DISARM;

            req.param1 = armed ? 0 : 1;
            armed = !armed;
            /*
            req.param2 = p2;
            req.param3 = p3;
            req.param4 = p4;
            req.param5 = p5;
            req.param6 = p6;
            req.param7 = p7;
            */

            byte[] packet = mavlink.GenerateMAVLinkPacket10(MAVLink.MAVLINK_MSG_ID.COMMAND_LONG, req);

            serialPort1.Write(packet, 0, packet.Length);

            try
            {
                var ack = readsomedata<MAVLink.mavlink_command_ack_t>(sysid, compid);
                if (ack.result == (byte)MAVLink.MAV_RESULT.ACCEPTED) 
                {

                }
            }
            catch 
            { 
            }
        }

        private void CMB_comport_Click(object sender, EventArgs e)
        {
            CMB_comport.DataSource = SerialPort.GetPortNames();
        }

        private void but_mission_Click(object sender, EventArgs e)
        {
            MAVLink.mavlink_mission_count_t req = new MAVLink.mavlink_mission_count_t();

            req.target_system = 1;
            req.target_component = 1;

            // set wp count
            req.count = 1;

            byte[] packet = mavlink.GenerateMAVLinkPacket10(MAVLink.MAVLINK_MSG_ID.MISSION_COUNT, req);
            Console.WriteLine("MISSION_COUNT send");
            serialPort1.Write(packet, 0, packet.Length);

            var ack = readsomedata<MAVLink.mavlink_mission_request_t>(sysid, compid);
            if (ack.seq == 0)
            {
                MAVLink.mavlink_mission_item_int_t req2 = new MAVLink.mavlink_mission_item_int_t();

                req2.target_system = sysid;
                req2.target_component = compid;

                req2.command = (byte)MAVLink.MAV_CMD.WAYPOINT;

                req2.current = 1;
                req2.autocontinue = 0;

                req2.frame = (byte)MAVLink.MAV_FRAME.GLOBAL_RELATIVE_ALT;

                req2.y = (int) (115 * 1.0e7);
                req2.x = (int) (-35 * 1.0e7);

                req2.z = (float) (2.34);

                req2.param1 = 0;
                req2.param2 = 0;
                req2.param3 = 0;
                req2.param4 = 0;

                req2.seq = 0;

                packet = mavlink.GenerateMAVLinkPacket10(MAVLink.MAVLINK_MSG_ID.MISSION_ITEM_INT, req2);
                Console.WriteLine("MISSION_ITEM_INT send");
                lock (readlock)
                {
                    serialPort1.Write(packet, 0, packet.Length);

                    var ack2 = readsomedata<MAVLink.mavlink_mission_ack_t>(sysid, compid);
                    if ((MAVLink.MAV_MISSION_RESULT) ack2.type != MAVLink.MAV_MISSION_RESULT.MAV_MISSION_ACCEPTED)
                    {

                    }
                }


                MAVLink.mavlink_mission_ack_t req3 = new MAVLink.mavlink_mission_ack_t();
                req3.target_system = 1;
                req3.target_component = 1;
                req3.type = 0;

                packet = mavlink.GenerateMAVLinkPacket10(MAVLink.MAVLINK_MSG_ID.MISSION_ACK, req3);
                Console.WriteLine("MISSION_ACK send");
                serialPort1.Write(packet, 0, packet.Length);
            }
        }

        private void themesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (themesComboBox.SelectedIndex == 1)
            {
                xAccCheckBox.Checked = yAccCheckBox.Checked = zAccCheckBox.Checked =
                xGyroCheckBox.Checked = yGyroCheckBox.Checked = zGyroCheckBox.Checked =
                xMagCheckBox.Checked = yMagCheckBox.Checked = zMagCheckBox.Checked =
                dirCheckBox.Checked = veloCheckBox.Checked = true;
                themesComboBox.SelectedIndex = 1;
            }
            else if (themesComboBox.SelectedIndex == 2)
            {
                xAccCheckBox.Checked = true; yAccCheckBox.Checked = zAccCheckBox.Checked = false;
                xGyroCheckBox.Checked = yGyroCheckBox.Checked = false; zGyroCheckBox.Checked = true;
                xMagCheckBox.Checked = yMagCheckBox.Checked = zMagCheckBox.Checked = false;
                dirCheckBox.Checked = veloCheckBox.Checked = true;
                themesComboBox.SelectedIndex = 2;
            }
            else if (themesComboBox.SelectedIndex == 3)
            {
                xAccCheckBox.Checked = true; yAccCheckBox.Checked = zAccCheckBox.Checked = false;
                xGyroCheckBox.Checked = yGyroCheckBox.Checked = false; zGyroCheckBox.Checked = true;
                xMagCheckBox.Checked = yMagCheckBox.Checked = true; zMagCheckBox.Checked = false;
                dirCheckBox.Checked = veloCheckBox.Checked = true;
                themesComboBox.SelectedIndex = 3;
            }
            else if (themesComboBox.SelectedIndex == 4)
            {
                originalCheckBox.Checked = originalSumCheckBox.Checked = originalSum10CheckBox.Checked =
                originalAvgCheckBox.Checked = originalAvg10CheckBox.Checked =
                absoluteCheckBox.Checked = absoluteSumCheckBox.Checked = absoluteSum10CheckBox.Checked =
                absoluteAvgCheckBox.Checked = absoluteAvg10CheckBox.Checked = true;
            }
            else if (themesComboBox.SelectedIndex == 5)
            {
                originalCheckBox.Checked = true; originalSumCheckBox.Checked = originalSum10CheckBox.Checked =
                originalAvgCheckBox.Checked = originalAvg10CheckBox.Checked =
                absoluteCheckBox.Checked = absoluteSumCheckBox.Checked = absoluteSum10CheckBox.Checked =
                absoluteAvgCheckBox.Checked = absoluteAvg10CheckBox.Checked = false;
            }
        }

        private void minYNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            IMUchart.ChartAreas[0].AxisY.Minimum = (double)minYNumericUpDown.Value;
        }

        private void maxYNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            IMUchart.ChartAreas[0].AxisY.Maximum = (double)maxYNumericUpDown.Value;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            themesComboBox.SelectedIndex = 0;
            if (sender is CheckBox)
            {
                var checkBox = sender as CheckBox;
                bool showSeries = checkBox.Checked;
                int id = 0;
                foreach (string name in IMUnames)
                {
                    if (!checkBox.Name.StartsWith(name))
                    {
                        if (id < baseSeriesCount * mathNames.Count())
                            id += mathNames.Count();
                        else
                            ++id;
                        continue;
                    }
                    if (id < baseSeriesCount * mathNames.Count())
                        foreach (string mathName in mathNames)
                        {
                            var mathCheckBox = this.Controls.Find(mathName, true)[0] as CheckBox;
                            if (mathCheckBox.Checked)
                                IMUchart.Series[id].Enabled = showSeries;
                            ++id;

                        }
                    else
                        IMUchart.Series[id].Enabled = showSeries;
                    break;
                }
            }
        }

        private void additionalCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox)
            {
                var checkBox = sender as CheckBox;
                bool showSeries = checkBox.Checked;
                int shiftId = 0;
                foreach (string name in mathNames)
                {
                    if (checkBox.Name == name)
                        break;
                    ++shiftId;
                }
                int id = 0;
                foreach (string name in IMUnames)
                {
                    if (id >= baseSeriesCount * mathNames.Count())
                        break;
                    var mainCheckBox = this.Controls.Find(name + "CheckBox", true)[0] as CheckBox;
                    if (mainCheckBox.Checked)
                        IMUchart.Series[id + shiftId].Enabled = showSeries;
                    id += mathNames.Count();
                }
            }
        }

        private void divisionsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            IMUchart.ChartAreas[0].AxisY.Interval = (IMUchart.ChartAreas[0].AxisY.Maximum - IMUchart.ChartAreas[0].AxisY.Minimum) / (int)divisionsNumericUpDown.Value;
        }

        private void diapasonNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            rescaleChart();
        }

        private void zeroCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!zeroCheckBox.Checked)
                for (int i = 0; i < prevConst.Length; ++i)
                    prevConst[i] = 0;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            BinaryReader In;
            try
            {
                In = new BinaryReader(new FileStream(openFileDialog.FileName, FileMode.Open));
            }
            catch (FileNotFoundException exc)
            {
                MessageBox.Show(exc.Message, "Файл не знайдено");
                return;
            }
            if (serialPort1.IsOpen)
                serialPort1.Close();
            try
            {
                double version = In.ReadDouble();
                if (version != 1.0)
                    throw new IOException("Непідтримувана версія");
                int seriesCount = In.ReadInt32();
                for (int i = 0; i < seriesCount; ++i)
                {
                    string name = In.ReadString();
                    if (IMUchart.Series.Count > i)
                        IMUchart.Series[i].Points.Clear();
                    else
                        IMUchart.Series.Add(name);
                    int pointsCount = In.ReadInt32();
                    for (int j = 0; j < pointsCount; ++j)
                    {
                        double x = In.ReadDouble();
                        double y = In.ReadDouble();
                        IMUchart.Series[i].Points.AddXY(x, y);
                    }
                }
                while (seriesCount < IMUchart.Series.Count)
                    IMUchart.Series.RemoveAt(seriesCount);
                rescaleChart();
            }
            catch (IOException exc)
            {
                MessageBox.Show(exc.Message, "Помилка читання файлу");
            }
            finally
            {
                In.Close();
            }
            Text = title + " - " + openFileDialog.FileName;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;
            BinaryWriter Out;
            try
            {
                Out = new BinaryWriter(new FileStream(saveFileDialog.FileName, FileMode.Create));
            }
            catch (IOException exc)
            {
                MessageBox.Show(exc.Message, "Помилка підготовки до запису");
                return;
            }
            if (serialPort1.IsOpen)
                serialPort1.Close();
            try
            {
                const double version = 1.0;
                Out.Write(version);
                Out.Write(IMUchart.Series.Count);
                foreach (var series in IMUchart.Series)
                {
                    Out.Write(series.Name);
                    Out.Write(series.Points.Count);
                    foreach (var point in series.Points)
                    {
                        Out.Write(point.XValue);
                        Out.Write(point.YValues[0]);
                    }
                }
            }
            catch (IOException exc)
            {
                MessageBox.Show(exc.Message, "Помилка запису даних");
            }
            finally
            {
                Out.Close();
            }
            Text = title + " - " + saveFileDialog.FileName;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text = title;
            if (serialPort1.IsOpen)
                serialPort1.Close();
            int baseCount = baseSeriesCount * mathNames.Count();
            for (int id = 0; id < baseCount; ++id)
                IMUchart.Series[id].Points.Clear();
            while (baseCount < IMUchart.Series.Count)
                IMUchart.Series.RemoveAt(baseCount);
            addSingleSeries();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleexample_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Text.StartsWith("*"))
            {
                serialPort1.Close();
                if (MessageBox.Show("Бажаєте зберегти дані?", "Пропозиція збереження", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    saveToolStripMenuItem_Click(sender, e);
            }
        }
    }
}
