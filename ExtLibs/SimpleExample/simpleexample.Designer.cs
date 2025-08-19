namespace SimpleExample
{
    partial class simpleexample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.CMB_comport = new System.Windows.Forms.ComboBox();
            this.cmb_baudrate = new System.Windows.Forms.ComboBox();
            this.but_connect = new System.Windows.Forms.Button();
            this.but_armdisarm = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.but_mission = new System.Windows.Forms.Button();
            this.z0Label = new System.Windows.Forms.Label();
            this.y0Label = new System.Windows.Forms.Label();
            this.x0Label = new System.Windows.Forms.Label();
            this.y0TextBox = new System.Windows.Forms.TextBox();
            this.x0TextBox = new System.Windows.Forms.TextBox();
            this.x1TextBox = new System.Windows.Forms.TextBox();
            this.y1TextBox = new System.Windows.Forms.TextBox();
            this.x1Label = new System.Windows.Forms.Label();
            this.y2Label = new System.Windows.Forms.Label();
            this.z1TextBox = new System.Windows.Forms.TextBox();
            this.z1Label = new System.Windows.Forms.Label();
            this.vxTextBox = new System.Windows.Forms.TextBox();
            this.vyTextBox = new System.Windows.Forms.TextBox();
            this.vxLabel = new System.Windows.Forms.Label();
            this.vyLabel = new System.Windows.Forms.Label();
            this.vzTextBox = new System.Windows.Forms.TextBox();
            this.vzLabel = new System.Windows.Forms.Label();
            this.velocityLabel = new System.Windows.Forms.Label();
            this.position1Label = new System.Windows.Forms.Label();
            this.position0Label = new System.Windows.Forms.Label();
            this.z0TextBox = new System.Windows.Forms.TextBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.vGroundSpeedTextBox = new System.Windows.Forms.TextBox();
            this.vAirSpeedTextBox = new System.Windows.Forms.TextBox();
            this.vGroundLabel = new System.Windows.Forms.Label();
            this.vAirLabel = new System.Windows.Forms.Label();
            this.headingTextBox = new System.Windows.Forms.TextBox();
            this.headingLabel = new System.Windows.Forms.Label();
            this.altTextBox = new System.Windows.Forms.TextBox();
            this.altLabel = new System.Windows.Forms.Label();
            this.hudLabel = new System.Windows.Forms.Label();
            this.throttleTextBox = new System.Windows.Forms.TextBox();
            this.climbTextBox = new System.Windows.Forms.TextBox();
            this.throttleLabel = new System.Windows.Forms.Label();
            this.climbLabel = new System.Windows.Forms.Label();
            this.dxTextBox = new System.Windows.Forms.TextBox();
            this.dyTextBox = new System.Windows.Forms.TextBox();
            this.dxLabel = new System.Windows.Forms.Label();
            this.dyLabel = new System.Windows.Forms.Label();
            this.dzTextBox = new System.Windows.Forms.TextBox();
            this.dzLabel = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.orientTextBox = new System.Windows.Forms.TextBox();
            this.orientLabel = new System.Windows.Forms.Label();
            this.ymagTextBox = new System.Windows.Forms.TextBox();
            this.ymagLabel = new System.Windows.Forms.Label();
            this.xmagTextBox = new System.Windows.Forms.TextBox();
            this.xmagLabel = new System.Windows.Forms.Label();
            this.xgyroTextBox = new System.Windows.Forms.TextBox();
            this.xgyroLabel = new System.Windows.Forms.Label();
            this.yaccTextBox = new System.Windows.Forms.TextBox();
            this.ygyroTextBox = new System.Windows.Forms.TextBox();
            this.yaccLabel = new System.Windows.Forms.Label();
            this.ygyroLabel = new System.Windows.Forms.Label();
            this.xaccTextBox = new System.Windows.Forms.TextBox();
            this.xaccLabel = new System.Windows.Forms.Label();
            this.temperatureTextBox = new System.Windows.Forms.TextBox();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.time_usecTextBox = new System.Windows.Forms.TextBox();
            this.time_usecLabel = new System.Windows.Forms.Label();
            this.zmagTextBox = new System.Windows.Forms.TextBox();
            this.zmagLabel = new System.Windows.Forms.Label();
            this.zaccTextBox = new System.Windows.Forms.TextBox();
            this.zgyroTextBox = new System.Windows.Forms.TextBox();
            this.zaccLabel = new System.Windows.Forms.Label();
            this.zgyroLabel = new System.Windows.Forms.Label();
            this.fzmagTextBox = new System.Windows.Forms.TextBox();
            this.fzaccTextBox = new System.Windows.Forms.TextBox();
            this.fzgyroTextBox = new System.Windows.Forms.TextBox();
            this.fymagTextBox = new System.Windows.Forms.TextBox();
            this.fxmagTextBox = new System.Windows.Forms.TextBox();
            this.fxgyroTextBox = new System.Windows.Forms.TextBox();
            this.fyaccTextBox = new System.Windows.Forms.TextBox();
            this.fygyroTextBox = new System.Windows.Forms.TextBox();
            this.fxaccTextBox = new System.Windows.Forms.TextBox();
            this.rawAltTextBox = new System.Windows.Forms.TextBox();
            this.rawAltLabel = new System.Windows.Forms.Label();
            this.rawLonTextBox = new System.Windows.Forms.TextBox();
            this.rawLonLabel = new System.Windows.Forms.Label();
            this.rawLatTextBox = new System.Windows.Forms.TextBox();
            this.rawLatLabel = new System.Windows.Forms.Label();
            this.wayTextBox = new System.Windows.Forms.TextBox();
            this.wayLabel = new System.Windows.Forms.Label();
            this.gyroTextBox = new System.Windows.Forms.TextBox();
            this.gyroLabel = new System.Windows.Forms.Label();
            this.accTextBox = new System.Windows.Forms.TextBox();
            this.accLabel = new System.Windows.Forms.Label();
            this.maxAccTextBox = new System.Windows.Forms.TextBox();
            this.maxAccLabel = new System.Windows.Forms.Label();
            this.maxGyroTextBox = new System.Windows.Forms.TextBox();
            this.maxGyroLabel = new System.Windows.Forms.Label();
            this.sumAccTextBox = new System.Windows.Forms.TextBox();
            this.sumAccLabel = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.IMUdataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.IMUchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dirCheckBox = new System.Windows.Forms.CheckBox();
            this.divisionsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.divisionsLabel = new System.Windows.Forms.Label();
            this.vaccCheckBox = new System.Windows.Forms.CheckBox();
            this.vabsCheckBox = new System.Windows.Forms.CheckBox();
            this.themesComboBox = new System.Windows.Forms.ComboBox();
            this.maxYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxYLabel = new System.Windows.Forms.Label();
            this.minYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minYLabel = new System.Windows.Forms.Label();
            this.zMagCheckBox = new System.Windows.Forms.CheckBox();
            this.yMagCheckBox = new System.Windows.Forms.CheckBox();
            this.xMagCheckBox = new System.Windows.Forms.CheckBox();
            this.zGyroCheckBox = new System.Windows.Forms.CheckBox();
            this.yGyroCheckBox = new System.Windows.Forms.CheckBox();
            this.xGyroCheckBox = new System.Windows.Forms.CheckBox();
            this.zAccCheckBox = new System.Windows.Forms.CheckBox();
            this.yAccCheckBox = new System.Windows.Forms.CheckBox();
            this.xAccCheckBox = new System.Windows.Forms.CheckBox();
            this.diapasonNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.stepLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.forwardLabel = new System.Windows.Forms.Label();
            this.leftLabel = new System.Windows.Forms.Label();
            this.vibrationLabel = new System.Windows.Forms.Label();
            this.rightLabel = new System.Windows.Forms.Label();
            this.backwardLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMUdataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMUchart)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.divisionsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diapasonNumericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CMB_comport
            // 
            this.CMB_comport.FormattingEnabled = true;
            this.CMB_comport.Location = new System.Drawing.Point(16, 24);
            this.CMB_comport.Margin = new System.Windows.Forms.Padding(4);
            this.CMB_comport.Name = "CMB_comport";
            this.CMB_comport.Size = new System.Drawing.Size(160, 24);
            this.CMB_comport.TabIndex = 0;
            this.CMB_comport.Click += new System.EventHandler(this.CMB_comport_Click);
            // 
            // cmb_baudrate
            // 
            this.cmb_baudrate.FormattingEnabled = true;
            this.cmb_baudrate.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.cmb_baudrate.Location = new System.Drawing.Point(186, 23);
            this.cmb_baudrate.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_baudrate.Name = "cmb_baudrate";
            this.cmb_baudrate.Size = new System.Drawing.Size(160, 24);
            this.cmb_baudrate.TabIndex = 1;
            // 
            // but_connect
            // 
            this.but_connect.Location = new System.Drawing.Point(356, 23);
            this.but_connect.Margin = new System.Windows.Forms.Padding(4);
            this.but_connect.Name = "but_connect";
            this.but_connect.Size = new System.Drawing.Size(100, 28);
            this.but_connect.TabIndex = 2;
            this.but_connect.Text = "Connect";
            this.but_connect.UseVisualStyleBackColor = true;
            this.but_connect.Click += new System.EventHandler(this.but_connect_Click);
            // 
            // but_armdisarm
            // 
            this.but_armdisarm.Location = new System.Drawing.Point(602, 23);
            this.but_armdisarm.Margin = new System.Windows.Forms.Padding(4);
            this.but_armdisarm.Name = "but_armdisarm";
            this.but_armdisarm.Size = new System.Drawing.Size(100, 28);
            this.but_armdisarm.TabIndex = 3;
            this.but_armdisarm.Text = "Arm/Disarm";
            this.but_armdisarm.UseVisualStyleBackColor = true;
            this.but_armdisarm.Click += new System.EventHandler(this.but_armdisarm_Click);
            // 
            // but_mission
            // 
            this.but_mission.Location = new System.Drawing.Point(464, 23);
            this.but_mission.Margin = new System.Windows.Forms.Padding(4);
            this.but_mission.Name = "but_mission";
            this.but_mission.Size = new System.Drawing.Size(129, 28);
            this.but_mission.TabIndex = 4;
            this.but_mission.Text = "Send Mission";
            this.but_mission.UseVisualStyleBackColor = true;
            this.but_mission.Click += new System.EventHandler(this.but_mission_Click);
            // 
            // z0Label
            // 
            this.z0Label.AutoSize = true;
            this.z0Label.Location = new System.Drawing.Point(203, 9);
            this.z0Label.Name = "z0Label";
            this.z0Label.Size = new System.Drawing.Size(72, 16);
            this.z0Label.TabIndex = 5;
            this.z0Label.Text = "Висота, м.";
            // 
            // y0Label
            // 
            this.y0Label.AutoSize = true;
            this.y0Label.Location = new System.Drawing.Point(373, 9);
            this.y0Label.Name = "y0Label";
            this.y0Label.Size = new System.Drawing.Size(75, 16);
            this.y0Label.TabIndex = 7;
            this.y0Label.Text = "Широта, м.";
            // 
            // x0Label
            // 
            this.x0Label.AutoSize = true;
            this.x0Label.Location = new System.Drawing.Point(574, 9);
            this.x0Label.Name = "x0Label";
            this.x0Label.Size = new System.Drawing.Size(79, 16);
            this.x0Label.TabIndex = 9;
            this.x0Label.Text = "Довгота, м.";
            // 
            // y0TextBox
            // 
            this.y0TextBox.Location = new System.Drawing.Point(482, 6);
            this.y0TextBox.Name = "y0TextBox";
            this.y0TextBox.Size = new System.Drawing.Size(54, 22);
            this.y0TextBox.TabIndex = 10;
            // 
            // x0TextBox
            // 
            this.x0TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.x0TextBox.Location = new System.Drawing.Point(654, 6);
            this.x0TextBox.Name = "x0TextBox";
            this.x0TextBox.Size = new System.Drawing.Size(54, 22);
            this.x0TextBox.TabIndex = 11;
            // 
            // x1TextBox
            // 
            this.x1TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.x1TextBox.Location = new System.Drawing.Point(654, 34);
            this.x1TextBox.Name = "x1TextBox";
            this.x1TextBox.Size = new System.Drawing.Size(54, 22);
            this.x1TextBox.TabIndex = 17;
            // 
            // y1TextBox
            // 
            this.y1TextBox.Location = new System.Drawing.Point(482, 34);
            this.y1TextBox.Name = "y1TextBox";
            this.y1TextBox.Size = new System.Drawing.Size(54, 22);
            this.y1TextBox.TabIndex = 16;
            // 
            // x1Label
            // 
            this.x1Label.AutoSize = true;
            this.x1Label.Location = new System.Drawing.Point(574, 37);
            this.x1Label.Name = "x1Label";
            this.x1Label.Size = new System.Drawing.Size(79, 16);
            this.x1Label.TabIndex = 15;
            this.x1Label.Text = "Довгота, м.";
            // 
            // y2Label
            // 
            this.y2Label.AutoSize = true;
            this.y2Label.Location = new System.Drawing.Point(373, 37);
            this.y2Label.Name = "y2Label";
            this.y2Label.Size = new System.Drawing.Size(75, 16);
            this.y2Label.TabIndex = 14;
            this.y2Label.Text = "Широта, м.";
            // 
            // z1TextBox
            // 
            this.z1TextBox.Location = new System.Drawing.Point(281, 34);
            this.z1TextBox.Name = "z1TextBox";
            this.z1TextBox.Size = new System.Drawing.Size(54, 22);
            this.z1TextBox.TabIndex = 13;
            // 
            // z1Label
            // 
            this.z1Label.AutoSize = true;
            this.z1Label.Location = new System.Drawing.Point(203, 37);
            this.z1Label.Name = "z1Label";
            this.z1Label.Size = new System.Drawing.Size(72, 16);
            this.z1Label.TabIndex = 12;
            this.z1Label.Text = "Висота, м.";
            // 
            // vxTextBox
            // 
            this.vxTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.vxTextBox.Location = new System.Drawing.Point(654, 70);
            this.vxTextBox.Name = "vxTextBox";
            this.vxTextBox.Size = new System.Drawing.Size(54, 22);
            this.vxTextBox.TabIndex = 23;
            // 
            // vyTextBox
            // 
            this.vyTextBox.Location = new System.Drawing.Point(482, 70);
            this.vyTextBox.Name = "vyTextBox";
            this.vyTextBox.Size = new System.Drawing.Size(54, 22);
            this.vyTextBox.TabIndex = 22;
            // 
            // vxLabel
            // 
            this.vxLabel.AutoSize = true;
            this.vxLabel.Location = new System.Drawing.Point(574, 70);
            this.vxLabel.Name = "vxLabel";
            this.vxLabel.Size = new System.Drawing.Size(66, 16);
            this.vxLabel.TabIndex = 21;
            this.vxLabel.Text = "По курсу";
            // 
            // vyLabel
            // 
            this.vyLabel.AutoSize = true;
            this.vyLabel.Location = new System.Drawing.Point(374, 73);
            this.vyLabel.Name = "vyLabel";
            this.vyLabel.Size = new System.Drawing.Size(34, 16);
            this.vyLabel.TabIndex = 20;
            this.vyLabel.Text = "Убік";
            // 
            // vzTextBox
            // 
            this.vzTextBox.Location = new System.Drawing.Point(281, 70);
            this.vzTextBox.Name = "vzTextBox";
            this.vzTextBox.Size = new System.Drawing.Size(54, 22);
            this.vzTextBox.TabIndex = 19;
            // 
            // vzLabel
            // 
            this.vzLabel.AutoSize = true;
            this.vzLabel.Location = new System.Drawing.Point(203, 73);
            this.vzLabel.Name = "vzLabel";
            this.vzLabel.Size = new System.Drawing.Size(65, 16);
            this.vzLabel.TabIndex = 18;
            this.vzLabel.Text = "У висоту";
            // 
            // velocityLabel
            // 
            this.velocityLabel.AutoSize = true;
            this.velocityLabel.Location = new System.Drawing.Point(47, 70);
            this.velocityLabel.Name = "velocityLabel";
            this.velocityLabel.Size = new System.Drawing.Size(76, 16);
            this.velocityLabel.TabIndex = 26;
            this.velocityLabel.Text = "Швидкість:";
            // 
            // position1Label
            // 
            this.position1Label.AutoSize = true;
            this.position1Label.Location = new System.Drawing.Point(47, 34);
            this.position1Label.Name = "position1Label";
            this.position1Label.Size = new System.Drawing.Size(120, 16);
            this.position1Label.TabIndex = 25;
            this.position1Label.Text = "Поточна позиція:";
            // 
            // position0Label
            // 
            this.position0Label.AutoSize = true;
            this.position0Label.Location = new System.Drawing.Point(47, 6);
            this.position0Label.Name = "position0Label";
            this.position0Label.Size = new System.Drawing.Size(135, 16);
            this.position0Label.TabIndex = 24;
            this.position0Label.Text = "Початкова позиція:";
            // 
            // z0TextBox
            // 
            this.z0TextBox.Location = new System.Drawing.Point(281, 6);
            this.z0TextBox.Name = "z0TextBox";
            this.z0TextBox.Size = new System.Drawing.Size(54, 22);
            this.z0TextBox.TabIndex = 6;
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(611, 112);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(97, 22);
            this.timeTextBox.TabIndex = 28;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(574, 112);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(31, 16);
            this.timeLabel.TabIndex = 27;
            this.timeLabel.Text = "Час";
            // 
            // vGroundSpeedTextBox
            // 
            this.vGroundSpeedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.vGroundSpeedTextBox.Location = new System.Drawing.Point(482, 154);
            this.vGroundSpeedTextBox.Name = "vGroundSpeedTextBox";
            this.vGroundSpeedTextBox.Size = new System.Drawing.Size(54, 22);
            this.vGroundSpeedTextBox.TabIndex = 34;
            this.vGroundSpeedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vAirSpeedTextBox
            // 
            this.vAirSpeedTextBox.Location = new System.Drawing.Point(482, 194);
            this.vAirSpeedTextBox.Name = "vAirSpeedTextBox";
            this.vAirSpeedTextBox.Size = new System.Drawing.Size(54, 22);
            this.vAirSpeedTextBox.TabIndex = 33;
            this.vAirSpeedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vGroundLabel
            // 
            this.vGroundLabel.AutoSize = true;
            this.vGroundLabel.Location = new System.Drawing.Point(352, 157);
            this.vGroundLabel.Name = "vGroundLabel";
            this.vGroundLabel.Size = new System.Drawing.Size(130, 16);
            this.vGroundLabel.TabIndex = 32;
            this.vGroundLabel.Text = "Шляхова швидкість";
            // 
            // vAirLabel
            // 
            this.vAirLabel.AutoSize = true;
            this.vAirLabel.Location = new System.Drawing.Point(341, 197);
            this.vAirLabel.Name = "vAirLabel";
            this.vAirLabel.Size = new System.Drawing.Size(141, 16);
            this.vAirLabel.TabIndex = 31;
            this.vAirLabel.Text = "Повітряна швидкість";
            // 
            // headingTextBox
            // 
            this.headingTextBox.Location = new System.Drawing.Point(281, 154);
            this.headingTextBox.Name = "headingTextBox";
            this.headingTextBox.Size = new System.Drawing.Size(54, 22);
            this.headingTextBox.TabIndex = 30;
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Location = new System.Drawing.Point(189, 157);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(87, 16);
            this.headingLabel.TabIndex = 29;
            this.headingLabel.Text = "Орієнтація, °";
            // 
            // altTextBox
            // 
            this.altTextBox.Location = new System.Drawing.Point(281, 194);
            this.altTextBox.Name = "altTextBox";
            this.altTextBox.Size = new System.Drawing.Size(54, 22);
            this.altTextBox.TabIndex = 36;
            // 
            // altLabel
            // 
            this.altLabel.AutoSize = true;
            this.altLabel.Location = new System.Drawing.Point(201, 197);
            this.altLabel.Name = "altLabel";
            this.altLabel.Size = new System.Drawing.Size(54, 16);
            this.altLabel.TabIndex = 35;
            this.altLabel.Text = "Висота";
            // 
            // hudLabel
            // 
            this.hudLabel.AutoSize = true;
            this.hudLabel.Location = new System.Drawing.Point(47, 160);
            this.hudLabel.Name = "hudLabel";
            this.hudLabel.Size = new System.Drawing.Size(96, 16);
            this.hudLabel.TabIndex = 37;
            this.hudLabel.Text = "Дані компаса:";
            // 
            // throttleTextBox
            // 
            this.throttleTextBox.Location = new System.Drawing.Point(663, 154);
            this.throttleTextBox.Name = "throttleTextBox";
            this.throttleTextBox.Size = new System.Drawing.Size(54, 22);
            this.throttleTextBox.TabIndex = 41;
            // 
            // climbTextBox
            // 
            this.climbTextBox.Location = new System.Drawing.Point(663, 194);
            this.climbTextBox.Name = "climbTextBox";
            this.climbTextBox.Size = new System.Drawing.Size(54, 22);
            this.climbTextBox.TabIndex = 40;
            // 
            // throttleLabel
            // 
            this.throttleLabel.AutoSize = true;
            this.throttleLabel.Location = new System.Drawing.Point(591, 160);
            this.throttleLabel.Name = "throttleLabel";
            this.throttleLabel.Size = new System.Drawing.Size(62, 16);
            this.throttleLabel.TabIndex = 39;
            this.throttleLabel.Text = "Дросель";
            // 
            // climbLabel
            // 
            this.climbLabel.AutoSize = true;
            this.climbLabel.Location = new System.Drawing.Point(597, 197);
            this.climbLabel.Name = "climbLabel";
            this.climbLabel.Size = new System.Drawing.Size(53, 16);
            this.climbLabel.TabIndex = 38;
            this.climbLabel.Text = "Підйом";
            // 
            // dxTextBox
            // 
            this.dxTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dxTextBox.Location = new System.Drawing.Point(663, 234);
            this.dxTextBox.Name = "dxTextBox";
            this.dxTextBox.Size = new System.Drawing.Size(54, 22);
            this.dxTextBox.TabIndex = 47;
            // 
            // dyTextBox
            // 
            this.dyTextBox.Location = new System.Drawing.Point(483, 234);
            this.dyTextBox.Name = "dyTextBox";
            this.dyTextBox.Size = new System.Drawing.Size(54, 22);
            this.dyTextBox.TabIndex = 46;
            // 
            // dxLabel
            // 
            this.dxLabel.AutoSize = true;
            this.dxLabel.Location = new System.Drawing.Point(575, 237);
            this.dxLabel.Name = "dxLabel";
            this.dxLabel.Size = new System.Drawing.Size(79, 16);
            this.dxLabel.TabIndex = 45;
            this.dxLabel.Text = "Довгота, м.";
            // 
            // dyLabel
            // 
            this.dyLabel.AutoSize = true;
            this.dyLabel.Location = new System.Drawing.Point(374, 237);
            this.dyLabel.Name = "dyLabel";
            this.dyLabel.Size = new System.Drawing.Size(75, 16);
            this.dyLabel.TabIndex = 44;
            this.dyLabel.Text = "Широта, м.";
            // 
            // dzTextBox
            // 
            this.dzTextBox.Location = new System.Drawing.Point(282, 234);
            this.dzTextBox.Name = "dzTextBox";
            this.dzTextBox.Size = new System.Drawing.Size(54, 22);
            this.dzTextBox.TabIndex = 43;
            // 
            // dzLabel
            // 
            this.dzLabel.AutoSize = true;
            this.dzLabel.Location = new System.Drawing.Point(204, 237);
            this.dzLabel.Name = "dzLabel";
            this.dzLabel.Size = new System.Drawing.Size(72, 16);
            this.dzLabel.TabIndex = 42;
            this.dzLabel.Text = "Висота, м.";
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Location = new System.Drawing.Point(33, 237);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(160, 16);
            this.dLabel.TabIndex = 48;
            this.dLabel.Text = "Розраховане зміщення:";
            // 
            // orientTextBox
            // 
            this.orientTextBox.Location = new System.Drawing.Point(281, 106);
            this.orientTextBox.Name = "orientTextBox";
            this.orientTextBox.Size = new System.Drawing.Size(54, 22);
            this.orientTextBox.TabIndex = 50;
            // 
            // orientLabel
            // 
            this.orientLabel.AutoSize = true;
            this.orientLabel.Location = new System.Drawing.Point(189, 109);
            this.orientLabel.Name = "orientLabel";
            this.orientLabel.Size = new System.Drawing.Size(87, 16);
            this.orientLabel.TabIndex = 49;
            this.orientLabel.Text = "Орієнтація, °";
            // 
            // ymagTextBox
            // 
            this.ymagTextBox.Location = new System.Drawing.Point(580, 397);
            this.ymagTextBox.Name = "ymagTextBox";
            this.ymagTextBox.Size = new System.Drawing.Size(54, 22);
            this.ymagTextBox.TabIndex = 67;
            // 
            // ymagLabel
            // 
            this.ymagLabel.AutoSize = true;
            this.ymagLabel.Location = new System.Drawing.Point(560, 397);
            this.ymagLabel.Name = "ymagLabel";
            this.ymagLabel.Size = new System.Drawing.Size(14, 16);
            this.ymagLabel.TabIndex = 65;
            this.ymagLabel.Text = "y";
            // 
            // xmagTextBox
            // 
            this.xmagTextBox.Location = new System.Drawing.Point(500, 394);
            this.xmagTextBox.Name = "xmagTextBox";
            this.xmagTextBox.Size = new System.Drawing.Size(54, 22);
            this.xmagTextBox.TabIndex = 64;
            // 
            // xmagLabel
            // 
            this.xmagLabel.AutoSize = true;
            this.xmagLabel.Location = new System.Drawing.Point(252, 419);
            this.xmagLabel.Name = "xmagLabel";
            this.xmagLabel.Size = new System.Drawing.Size(230, 16);
            this.xmagLabel.TabIndex = 63;
            this.xmagLabel.Text = "Магнітне поле вздовж осі, гаус:    х";
            // 
            // xgyroTextBox
            // 
            this.xgyroTextBox.Location = new System.Drawing.Point(500, 335);
            this.xgyroTextBox.Name = "xgyroTextBox";
            this.xgyroTextBox.Size = new System.Drawing.Size(54, 22);
            this.xgyroTextBox.TabIndex = 58;
            // 
            // xgyroLabel
            // 
            this.xgyroLabel.AutoSize = true;
            this.xgyroLabel.Location = new System.Drawing.Point(220, 341);
            this.xgyroLabel.Name = "xgyroLabel";
            this.xgyroLabel.Size = new System.Drawing.Size(262, 16);
            this.xgyroLabel.TabIndex = 57;
            this.xgyroLabel.Text = "Кутова швидкість довкола осі, рад/с:    х";
            // 
            // yaccTextBox
            // 
            this.yaccTextBox.Location = new System.Drawing.Point(580, 283);
            this.yaccTextBox.Name = "yaccTextBox";
            this.yaccTextBox.Size = new System.Drawing.Size(54, 22);
            this.yaccTextBox.TabIndex = 56;
            // 
            // ygyroTextBox
            // 
            this.ygyroTextBox.Location = new System.Drawing.Point(580, 338);
            this.ygyroTextBox.Name = "ygyroTextBox";
            this.ygyroTextBox.Size = new System.Drawing.Size(54, 22);
            this.ygyroTextBox.TabIndex = 55;
            // 
            // yaccLabel
            // 
            this.yaccLabel.AutoSize = true;
            this.yaccLabel.Location = new System.Drawing.Point(560, 286);
            this.yaccLabel.Name = "yaccLabel";
            this.yaccLabel.Size = new System.Drawing.Size(14, 16);
            this.yaccLabel.TabIndex = 54;
            this.yaccLabel.Text = "y";
            // 
            // ygyroLabel
            // 
            this.ygyroLabel.AutoSize = true;
            this.ygyroLabel.Location = new System.Drawing.Point(560, 338);
            this.ygyroLabel.Name = "ygyroLabel";
            this.ygyroLabel.Size = new System.Drawing.Size(14, 16);
            this.ygyroLabel.TabIndex = 53;
            this.ygyroLabel.Text = "y";
            // 
            // xaccTextBox
            // 
            this.xaccTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.xaccTextBox.Location = new System.Drawing.Point(500, 280);
            this.xaccTextBox.Name = "xaccTextBox";
            this.xaccTextBox.Size = new System.Drawing.Size(54, 22);
            this.xaccTextBox.TabIndex = 52;
            // 
            // xaccLabel
            // 
            this.xaccLabel.AutoSize = true;
            this.xaccLabel.Location = new System.Drawing.Point(278, 289);
            this.xaccLabel.Name = "xaccLabel";
            this.xaccLabel.Size = new System.Drawing.Size(204, 16);
            this.xaccLabel.TabIndex = 51;
            this.xaccLabel.Text = "Прискорення вздовж осі, G:    х";
            // 
            // temperatureTextBox
            // 
            this.temperatureTextBox.Location = new System.Drawing.Point(158, 341);
            this.temperatureTextBox.Name = "temperatureTextBox";
            this.temperatureTextBox.Size = new System.Drawing.Size(54, 22);
            this.temperatureTextBox.TabIndex = 74;
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Location = new System.Drawing.Point(37, 344);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(96, 16);
            this.temperatureLabel.TabIndex = 73;
            this.temperatureLabel.Text = "Температура";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(158, 311);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(54, 22);
            this.idTextBox.TabIndex = 72;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(115, 314);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 16);
            this.idLabel.TabIndex = 71;
            this.idLabel.Text = "id";
            // 
            // time_usecTextBox
            // 
            this.time_usecTextBox.Location = new System.Drawing.Point(158, 280);
            this.time_usecTextBox.Name = "time_usecTextBox";
            this.time_usecTextBox.Size = new System.Drawing.Size(97, 22);
            this.time_usecTextBox.TabIndex = 70;
            // 
            // time_usecLabel
            // 
            this.time_usecLabel.AutoSize = true;
            this.time_usecLabel.Location = new System.Drawing.Point(31, 283);
            this.time_usecLabel.Name = "time_usecLabel";
            this.time_usecLabel.Size = new System.Drawing.Size(110, 16);
            this.time_usecLabel.TabIndex = 69;
            this.time_usecLabel.Text = "Час від запуску";
            // 
            // zmagTextBox
            // 
            this.zmagTextBox.Location = new System.Drawing.Point(660, 397);
            this.zmagTextBox.Name = "zmagTextBox";
            this.zmagTextBox.Size = new System.Drawing.Size(54, 22);
            this.zmagTextBox.TabIndex = 80;
            // 
            // zmagLabel
            // 
            this.zmagLabel.AutoSize = true;
            this.zmagLabel.Location = new System.Drawing.Point(640, 397);
            this.zmagLabel.Name = "zmagLabel";
            this.zmagLabel.Size = new System.Drawing.Size(13, 16);
            this.zmagLabel.TabIndex = 79;
            this.zmagLabel.Text = "z";
            // 
            // zaccTextBox
            // 
            this.zaccTextBox.Location = new System.Drawing.Point(660, 283);
            this.zaccTextBox.Name = "zaccTextBox";
            this.zaccTextBox.Size = new System.Drawing.Size(54, 22);
            this.zaccTextBox.TabIndex = 78;
            // 
            // zgyroTextBox
            // 
            this.zgyroTextBox.Location = new System.Drawing.Point(660, 338);
            this.zgyroTextBox.Name = "zgyroTextBox";
            this.zgyroTextBox.Size = new System.Drawing.Size(54, 22);
            this.zgyroTextBox.TabIndex = 77;
            // 
            // zaccLabel
            // 
            this.zaccLabel.AutoSize = true;
            this.zaccLabel.Location = new System.Drawing.Point(640, 286);
            this.zaccLabel.Name = "zaccLabel";
            this.zaccLabel.Size = new System.Drawing.Size(13, 16);
            this.zaccLabel.TabIndex = 76;
            this.zaccLabel.Text = "z";
            // 
            // zgyroLabel
            // 
            this.zgyroLabel.AutoSize = true;
            this.zgyroLabel.Location = new System.Drawing.Point(640, 338);
            this.zgyroLabel.Name = "zgyroLabel";
            this.zgyroLabel.Size = new System.Drawing.Size(13, 16);
            this.zgyroLabel.TabIndex = 75;
            this.zgyroLabel.Text = "z";
            // 
            // fzmagTextBox
            // 
            this.fzmagTextBox.Location = new System.Drawing.Point(660, 444);
            this.fzmagTextBox.Name = "fzmagTextBox";
            this.fzmagTextBox.Size = new System.Drawing.Size(54, 22);
            this.fzmagTextBox.TabIndex = 95;
            // 
            // fzaccTextBox
            // 
            this.fzaccTextBox.Location = new System.Drawing.Point(660, 311);
            this.fzaccTextBox.Name = "fzaccTextBox";
            this.fzaccTextBox.Size = new System.Drawing.Size(54, 22);
            this.fzaccTextBox.TabIndex = 93;
            // 
            // fzgyroTextBox
            // 
            this.fzgyroTextBox.Location = new System.Drawing.Point(660, 366);
            this.fzgyroTextBox.Name = "fzgyroTextBox";
            this.fzgyroTextBox.Size = new System.Drawing.Size(54, 22);
            this.fzgyroTextBox.TabIndex = 92;
            // 
            // fymagTextBox
            // 
            this.fymagTextBox.Location = new System.Drawing.Point(580, 444);
            this.fymagTextBox.Name = "fymagTextBox";
            this.fymagTextBox.Size = new System.Drawing.Size(54, 22);
            this.fymagTextBox.TabIndex = 89;
            // 
            // fxmagTextBox
            // 
            this.fxmagTextBox.Location = new System.Drawing.Point(500, 441);
            this.fxmagTextBox.Name = "fxmagTextBox";
            this.fxmagTextBox.Size = new System.Drawing.Size(54, 22);
            this.fxmagTextBox.TabIndex = 87;
            // 
            // fxgyroTextBox
            // 
            this.fxgyroTextBox.Location = new System.Drawing.Point(500, 363);
            this.fxgyroTextBox.Name = "fxgyroTextBox";
            this.fxgyroTextBox.Size = new System.Drawing.Size(54, 22);
            this.fxgyroTextBox.TabIndex = 86;
            // 
            // fyaccTextBox
            // 
            this.fyaccTextBox.Location = new System.Drawing.Point(580, 311);
            this.fyaccTextBox.Name = "fyaccTextBox";
            this.fyaccTextBox.Size = new System.Drawing.Size(54, 22);
            this.fyaccTextBox.TabIndex = 85;
            // 
            // fygyroTextBox
            // 
            this.fygyroTextBox.Location = new System.Drawing.Point(580, 366);
            this.fygyroTextBox.Name = "fygyroTextBox";
            this.fygyroTextBox.Size = new System.Drawing.Size(54, 22);
            this.fygyroTextBox.TabIndex = 84;
            // 
            // fxaccTextBox
            // 
            this.fxaccTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.fxaccTextBox.Location = new System.Drawing.Point(500, 308);
            this.fxaccTextBox.Name = "fxaccTextBox";
            this.fxaccTextBox.Size = new System.Drawing.Size(54, 22);
            this.fxaccTextBox.TabIndex = 81;
            // 
            // rawAltTextBox
            // 
            this.rawAltTextBox.Location = new System.Drawing.Point(660, 491);
            this.rawAltTextBox.Name = "rawAltTextBox";
            this.rawAltTextBox.Size = new System.Drawing.Size(54, 22);
            this.rawAltTextBox.TabIndex = 101;
            // 
            // rawAltLabel
            // 
            this.rawAltLabel.AutoSize = true;
            this.rawAltLabel.Location = new System.Drawing.Point(577, 497);
            this.rawAltLabel.Name = "rawAltLabel";
            this.rawAltLabel.Size = new System.Drawing.Size(53, 16);
            this.rawAltLabel.TabIndex = 100;
            this.rawAltLabel.Text = "висота";
            // 
            // rawLonTextBox
            // 
            this.rawLonTextBox.Location = new System.Drawing.Point(500, 491);
            this.rawLonTextBox.Name = "rawLonTextBox";
            this.rawLonTextBox.Size = new System.Drawing.Size(54, 22);
            this.rawLonTextBox.TabIndex = 99;
            // 
            // rawLonLabel
            // 
            this.rawLonLabel.AutoSize = true;
            this.rawLonLabel.Location = new System.Drawing.Point(416, 497);
            this.rawLonLabel.Name = "rawLonLabel";
            this.rawLonLabel.Size = new System.Drawing.Size(60, 16);
            this.rawLonLabel.TabIndex = 98;
            this.rawLonLabel.Text = "довгота";
            // 
            // rawLatTextBox
            // 
            this.rawLatTextBox.Location = new System.Drawing.Point(344, 491);
            this.rawLatTextBox.Name = "rawLatTextBox";
            this.rawLatTextBox.Size = new System.Drawing.Size(54, 22);
            this.rawLatTextBox.TabIndex = 97;
            // 
            // rawLatLabel
            // 
            this.rawLatLabel.AutoSize = true;
            this.rawLatLabel.Location = new System.Drawing.Point(155, 497);
            this.rawLatLabel.Name = "rawLatLabel";
            this.rawLatLabel.Size = new System.Drawing.Size(159, 16);
            this.rawLatLabel.TabIndex = 96;
            this.rawLatLabel.Text = "Сирі GPS дані:    широта";
            // 
            // wayTextBox
            // 
            this.wayTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.wayTextBox.Location = new System.Drawing.Point(158, 380);
            this.wayTextBox.Name = "wayTextBox";
            this.wayTextBox.Size = new System.Drawing.Size(54, 22);
            this.wayTextBox.TabIndex = 103;
            // 
            // wayLabel
            // 
            this.wayLabel.AutoSize = true;
            this.wayLabel.Location = new System.Drawing.Point(20, 383);
            this.wayLabel.Name = "wayLabel";
            this.wayLabel.Size = new System.Drawing.Size(132, 16);
            this.wayLabel.TabIndex = 102;
            this.wayLabel.Text = "Подоланий шлях, м:";
            // 
            // gyroTextBox
            // 
            this.gyroTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gyroTextBox.Location = new System.Drawing.Point(158, 465);
            this.gyroTextBox.Name = "gyroTextBox";
            this.gyroTextBox.Size = new System.Drawing.Size(54, 22);
            this.gyroTextBox.TabIndex = 105;
            // 
            // gyroLabel
            // 
            this.gyroLabel.AutoSize = true;
            this.gyroLabel.Location = new System.Drawing.Point(50, 468);
            this.gyroLabel.Name = "gyroLabel";
            this.gyroLabel.Size = new System.Drawing.Size(93, 16);
            this.gyroLabel.TabIndex = 104;
            this.gyroLabel.Text = "Від гіроскопа";
            // 
            // accTextBox
            // 
            this.accTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.accTextBox.Location = new System.Drawing.Point(158, 438);
            this.accTextBox.Name = "accTextBox";
            this.accTextBox.Size = new System.Drawing.Size(54, 22);
            this.accTextBox.TabIndex = 107;
            // 
            // accLabel
            // 
            this.accLabel.AutoSize = true;
            this.accLabel.Location = new System.Drawing.Point(27, 441);
            this.accLabel.Name = "accLabel";
            this.accLabel.Size = new System.Drawing.Size(116, 16);
            this.accLabel.TabIndex = 106;
            this.accLabel.Text = "Від акселометра";
            // 
            // maxAccTextBox
            // 
            this.maxAccTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.maxAccTextBox.Location = new System.Drawing.Point(264, 438);
            this.maxAccTextBox.Name = "maxAccTextBox";
            this.maxAccTextBox.Size = new System.Drawing.Size(54, 22);
            this.maxAccTextBox.TabIndex = 111;
            // 
            // maxAccLabel
            // 
            this.maxAccLabel.AutoSize = true;
            this.maxAccLabel.Location = new System.Drawing.Point(218, 441);
            this.maxAccLabel.Name = "maxAccLabel";
            this.maxAccLabel.Size = new System.Drawing.Size(40, 16);
            this.maxAccLabel.TabIndex = 110;
            this.maxAccLabel.Text = "Макс";
            // 
            // maxGyroTextBox
            // 
            this.maxGyroTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.maxGyroTextBox.Location = new System.Drawing.Point(264, 465);
            this.maxGyroTextBox.Name = "maxGyroTextBox";
            this.maxGyroTextBox.Size = new System.Drawing.Size(54, 22);
            this.maxGyroTextBox.TabIndex = 109;
            // 
            // maxGyroLabel
            // 
            this.maxGyroLabel.AutoSize = true;
            this.maxGyroLabel.Location = new System.Drawing.Point(218, 468);
            this.maxGyroLabel.Name = "maxGyroLabel";
            this.maxGyroLabel.Size = new System.Drawing.Size(40, 16);
            this.maxGyroLabel.TabIndex = 108;
            this.maxGyroLabel.Text = "Макс";
            // 
            // sumAccTextBox
            // 
            this.sumAccTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.sumAccTextBox.Location = new System.Drawing.Point(400, 441);
            this.sumAccTextBox.Name = "sumAccTextBox";
            this.sumAccTextBox.Size = new System.Drawing.Size(54, 22);
            this.sumAccTextBox.TabIndex = 113;
            // 
            // sumAccLabel
            // 
            this.sumAccLabel.AutoSize = true;
            this.sumAccLabel.Location = new System.Drawing.Point(331, 444);
            this.sumAccLabel.Name = "sumAccLabel";
            this.sumAccLabel.Size = new System.Drawing.Size(63, 16);
            this.sumAccLabel.TabIndex = 112;
            this.sumAccLabel.Text = "Інтеграл";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 82);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(884, 556);
            this.tabControl.TabIndex = 114;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.x0TextBox);
            this.tabPage1.Controls.Add(this.sumAccTextBox);
            this.tabPage1.Controls.Add(this.z0Label);
            this.tabPage1.Controls.Add(this.sumAccLabel);
            this.tabPage1.Controls.Add(this.z0TextBox);
            this.tabPage1.Controls.Add(this.maxAccTextBox);
            this.tabPage1.Controls.Add(this.y0Label);
            this.tabPage1.Controls.Add(this.maxAccLabel);
            this.tabPage1.Controls.Add(this.x0Label);
            this.tabPage1.Controls.Add(this.maxGyroTextBox);
            this.tabPage1.Controls.Add(this.y0TextBox);
            this.tabPage1.Controls.Add(this.maxGyroLabel);
            this.tabPage1.Controls.Add(this.z1Label);
            this.tabPage1.Controls.Add(this.accTextBox);
            this.tabPage1.Controls.Add(this.z1TextBox);
            this.tabPage1.Controls.Add(this.accLabel);
            this.tabPage1.Controls.Add(this.y2Label);
            this.tabPage1.Controls.Add(this.gyroTextBox);
            this.tabPage1.Controls.Add(this.x1Label);
            this.tabPage1.Controls.Add(this.gyroLabel);
            this.tabPage1.Controls.Add(this.y1TextBox);
            this.tabPage1.Controls.Add(this.rawAltTextBox);
            this.tabPage1.Controls.Add(this.wayTextBox);
            this.tabPage1.Controls.Add(this.rawAltLabel);
            this.tabPage1.Controls.Add(this.x1TextBox);
            this.tabPage1.Controls.Add(this.rawLonTextBox);
            this.tabPage1.Controls.Add(this.wayLabel);
            this.tabPage1.Controls.Add(this.rawLonLabel);
            this.tabPage1.Controls.Add(this.vzLabel);
            this.tabPage1.Controls.Add(this.rawLatTextBox);
            this.tabPage1.Controls.Add(this.vzTextBox);
            this.tabPage1.Controls.Add(this.rawLatLabel);
            this.tabPage1.Controls.Add(this.vyLabel);
            this.tabPage1.Controls.Add(this.fzmagTextBox);
            this.tabPage1.Controls.Add(this.vxLabel);
            this.tabPage1.Controls.Add(this.fymagTextBox);
            this.tabPage1.Controls.Add(this.vyTextBox);
            this.tabPage1.Controls.Add(this.fxmagTextBox);
            this.tabPage1.Controls.Add(this.vxTextBox);
            this.tabPage1.Controls.Add(this.xmagLabel);
            this.tabPage1.Controls.Add(this.position0Label);
            this.tabPage1.Controls.Add(this.position1Label);
            this.tabPage1.Controls.Add(this.fzaccTextBox);
            this.tabPage1.Controls.Add(this.velocityLabel);
            this.tabPage1.Controls.Add(this.fzgyroTextBox);
            this.tabPage1.Controls.Add(this.timeLabel);
            this.tabPage1.Controls.Add(this.timeTextBox);
            this.tabPage1.Controls.Add(this.headingLabel);
            this.tabPage1.Controls.Add(this.fxgyroTextBox);
            this.tabPage1.Controls.Add(this.headingTextBox);
            this.tabPage1.Controls.Add(this.fyaccTextBox);
            this.tabPage1.Controls.Add(this.vAirLabel);
            this.tabPage1.Controls.Add(this.fygyroTextBox);
            this.tabPage1.Controls.Add(this.vGroundLabel);
            this.tabPage1.Controls.Add(this.fxaccTextBox);
            this.tabPage1.Controls.Add(this.vAirSpeedTextBox);
            this.tabPage1.Controls.Add(this.zmagTextBox);
            this.tabPage1.Controls.Add(this.vGroundSpeedTextBox);
            this.tabPage1.Controls.Add(this.zmagLabel);
            this.tabPage1.Controls.Add(this.altLabel);
            this.tabPage1.Controls.Add(this.zaccTextBox);
            this.tabPage1.Controls.Add(this.altTextBox);
            this.tabPage1.Controls.Add(this.zgyroTextBox);
            this.tabPage1.Controls.Add(this.hudLabel);
            this.tabPage1.Controls.Add(this.zaccLabel);
            this.tabPage1.Controls.Add(this.climbLabel);
            this.tabPage1.Controls.Add(this.zgyroLabel);
            this.tabPage1.Controls.Add(this.throttleLabel);
            this.tabPage1.Controls.Add(this.temperatureTextBox);
            this.tabPage1.Controls.Add(this.climbTextBox);
            this.tabPage1.Controls.Add(this.temperatureLabel);
            this.tabPage1.Controls.Add(this.throttleTextBox);
            this.tabPage1.Controls.Add(this.idTextBox);
            this.tabPage1.Controls.Add(this.dzLabel);
            this.tabPage1.Controls.Add(this.idLabel);
            this.tabPage1.Controls.Add(this.dzTextBox);
            this.tabPage1.Controls.Add(this.time_usecTextBox);
            this.tabPage1.Controls.Add(this.dyLabel);
            this.tabPage1.Controls.Add(this.time_usecLabel);
            this.tabPage1.Controls.Add(this.dxLabel);
            this.tabPage1.Controls.Add(this.ymagTextBox);
            this.tabPage1.Controls.Add(this.dyTextBox);
            this.tabPage1.Controls.Add(this.ymagLabel);
            this.tabPage1.Controls.Add(this.dxTextBox);
            this.tabPage1.Controls.Add(this.xmagTextBox);
            this.tabPage1.Controls.Add(this.dLabel);
            this.tabPage1.Controls.Add(this.orientLabel);
            this.tabPage1.Controls.Add(this.xgyroTextBox);
            this.tabPage1.Controls.Add(this.orientTextBox);
            this.tabPage1.Controls.Add(this.xgyroLabel);
            this.tabPage1.Controls.Add(this.xaccLabel);
            this.tabPage1.Controls.Add(this.yaccTextBox);
            this.tabPage1.Controls.Add(this.xaccTextBox);
            this.tabPage1.Controls.Add(this.ygyroTextBox);
            this.tabPage1.Controls.Add(this.ygyroLabel);
            this.tabPage1.Controls.Add(this.yaccLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(876, 527);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Перше наближення";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.IMUdataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(876, 527);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Друге наближення";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // IMUdataGridView
            // 
            this.IMUdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IMUdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IMUdataGridView.Location = new System.Drawing.Point(3, 3);
            this.IMUdataGridView.Name = "IMUdataGridView";
            this.IMUdataGridView.RowHeadersWidth = 51;
            this.IMUdataGridView.RowTemplate.Height = 24;
            this.IMUdataGridView.Size = new System.Drawing.Size(870, 521);
            this.IMUdataGridView.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.IMUchart);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(876, 527);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Графіки IMU";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // IMUchart
            // 
            chartArea4.Name = "ChartArea1";
            this.IMUchart.ChartAreas.Add(chartArea4);
            this.IMUchart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.IMUchart.Legends.Add(legend4);
            this.IMUchart.Location = new System.Drawing.Point(0, 71);
            this.IMUchart.Name = "IMUchart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.IMUchart.Series.Add(series4);
            this.IMUchart.Size = new System.Drawing.Size(876, 456);
            this.IMUchart.TabIndex = 0;
            this.IMUchart.Text = " ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dirCheckBox);
            this.panel2.Controls.Add(this.divisionsNumericUpDown);
            this.panel2.Controls.Add(this.divisionsLabel);
            this.panel2.Controls.Add(this.vaccCheckBox);
            this.panel2.Controls.Add(this.vabsCheckBox);
            this.panel2.Controls.Add(this.themesComboBox);
            this.panel2.Controls.Add(this.maxYNumericUpDown);
            this.panel2.Controls.Add(this.maxYLabel);
            this.panel2.Controls.Add(this.minYNumericUpDown);
            this.panel2.Controls.Add(this.minYLabel);
            this.panel2.Controls.Add(this.zMagCheckBox);
            this.panel2.Controls.Add(this.yMagCheckBox);
            this.panel2.Controls.Add(this.xMagCheckBox);
            this.panel2.Controls.Add(this.zGyroCheckBox);
            this.panel2.Controls.Add(this.yGyroCheckBox);
            this.panel2.Controls.Add(this.xGyroCheckBox);
            this.panel2.Controls.Add(this.zAccCheckBox);
            this.panel2.Controls.Add(this.yAccCheckBox);
            this.panel2.Controls.Add(this.xAccCheckBox);
            this.panel2.Controls.Add(this.diapasonNumericUpDown);
            this.panel2.Controls.Add(this.stepLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(876, 71);
            this.panel2.TabIndex = 1;
            // 
            // dirCheckBox
            // 
            this.dirCheckBox.AutoSize = true;
            this.dirCheckBox.Location = new System.Drawing.Point(689, 34);
            this.dirCheckBox.Name = "dirCheckBox";
            this.dirCheckBox.Size = new System.Drawing.Size(44, 20);
            this.dirCheckBox.TabIndex = 22;
            this.dirCheckBox.Text = "dir";
            this.dirCheckBox.UseVisualStyleBackColor = true;
            this.dirCheckBox.CheckStateChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // divisionsNumericUpDown
            // 
            this.divisionsNumericUpDown.Location = new System.Drawing.Point(589, 4);
            this.divisionsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.divisionsNumericUpDown.Name = "divisionsNumericUpDown";
            this.divisionsNumericUpDown.Size = new System.Drawing.Size(62, 22);
            this.divisionsNumericUpDown.TabIndex = 21;
            this.divisionsNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.divisionsNumericUpDown.ValueChanged += new System.EventHandler(this.divisionsNumericUpDown_ValueChanged);
            // 
            // divisionsLabel
            // 
            this.divisionsLabel.AutoSize = true;
            this.divisionsLabel.Location = new System.Drawing.Point(523, 4);
            this.divisionsLabel.Name = "divisionsLabel";
            this.divisionsLabel.Size = new System.Drawing.Size(59, 16);
            this.divisionsLabel.TabIndex = 20;
            this.divisionsLabel.Text = "Поділок";
            // 
            // vaccCheckBox
            // 
            this.vaccCheckBox.AutoSize = true;
            this.vaccCheckBox.Location = new System.Drawing.Point(806, 34);
            this.vaccCheckBox.Name = "vaccCheckBox";
            this.vaccCheckBox.Size = new System.Drawing.Size(58, 20);
            this.vaccCheckBox.TabIndex = 19;
            this.vaccCheckBox.Text = "vacc";
            this.vaccCheckBox.UseVisualStyleBackColor = true;
            this.vaccCheckBox.CheckStateChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // vabsCheckBox
            // 
            this.vabsCheckBox.AutoSize = true;
            this.vabsCheckBox.Location = new System.Drawing.Point(743, 34);
            this.vabsCheckBox.Name = "vabsCheckBox";
            this.vabsCheckBox.Size = new System.Drawing.Size(59, 20);
            this.vabsCheckBox.TabIndex = 18;
            this.vabsCheckBox.Text = "vabs";
            this.vabsCheckBox.UseVisualStyleBackColor = true;
            this.vabsCheckBox.CheckStateChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // themesComboBox
            // 
            this.themesComboBox.FormattingEnabled = true;
            this.themesComboBox.Location = new System.Drawing.Point(661, 4);
            this.themesComboBox.Name = "themesComboBox";
            this.themesComboBox.Size = new System.Drawing.Size(207, 24);
            this.themesComboBox.TabIndex = 17;
            this.themesComboBox.SelectedIndexChanged += new System.EventHandler(this.themesComboBox_SelectedIndexChanged);
            // 
            // maxYNumericUpDown
            // 
            this.maxYNumericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.maxYNumericUpDown.Location = new System.Drawing.Point(455, 4);
            this.maxYNumericUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.maxYNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.maxYNumericUpDown.Name = "maxYNumericUpDown";
            this.maxYNumericUpDown.Size = new System.Drawing.Size(62, 22);
            this.maxYNumericUpDown.TabIndex = 15;
            this.maxYNumericUpDown.Value = new decimal(new int[] {
            1100,
            0,
            0,
            0});
            this.maxYNumericUpDown.ValueChanged += new System.EventHandler(this.maxYNumericUpDown_ValueChanged);
            // 
            // maxYLabel
            // 
            this.maxYLabel.AutoSize = true;
            this.maxYLabel.Location = new System.Drawing.Point(375, 4);
            this.maxYLabel.Name = "maxYLabel";
            this.maxYLabel.Size = new System.Drawing.Size(74, 16);
            this.maxYLabel.TabIndex = 14;
            this.maxYLabel.Text = "Максимум";
            // 
            // minYNumericUpDown
            // 
            this.minYNumericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.minYNumericUpDown.Location = new System.Drawing.Point(304, 4);
            this.minYNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.minYNumericUpDown.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.minYNumericUpDown.Name = "minYNumericUpDown";
            this.minYNumericUpDown.Size = new System.Drawing.Size(63, 22);
            this.minYNumericUpDown.TabIndex = 13;
            this.minYNumericUpDown.Value = new decimal(new int[] {
            1100,
            0,
            0,
            -2147483648});
            this.minYNumericUpDown.ValueChanged += new System.EventHandler(this.minYNumericUpDown_ValueChanged);
            // 
            // minYLabel
            // 
            this.minYLabel.AutoSize = true;
            this.minYLabel.Location = new System.Drawing.Point(239, 4);
            this.minYLabel.Name = "minYLabel";
            this.minYLabel.Size = new System.Drawing.Size(58, 16);
            this.minYLabel.TabIndex = 12;
            this.minYLabel.Text = "Мінімум";
            // 
            // zMagCheckBox
            // 
            this.zMagCheckBox.AutoSize = true;
            this.zMagCheckBox.Location = new System.Drawing.Point(512, 33);
            this.zMagCheckBox.Name = "zMagCheckBox";
            this.zMagCheckBox.Size = new System.Drawing.Size(62, 20);
            this.zMagCheckBox.TabIndex = 11;
            this.zMagCheckBox.Text = "zmag";
            this.zMagCheckBox.UseVisualStyleBackColor = true;
            this.zMagCheckBox.CheckStateChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // yMagCheckBox
            // 
            this.yMagCheckBox.AutoSize = true;
            this.yMagCheckBox.Location = new System.Drawing.Point(449, 33);
            this.yMagCheckBox.Name = "yMagCheckBox";
            this.yMagCheckBox.Size = new System.Drawing.Size(63, 20);
            this.yMagCheckBox.TabIndex = 10;
            this.yMagCheckBox.Text = "ymag";
            this.yMagCheckBox.UseVisualStyleBackColor = true;
            this.yMagCheckBox.CheckStateChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // xMagCheckBox
            // 
            this.xMagCheckBox.AutoSize = true;
            this.xMagCheckBox.Location = new System.Drawing.Point(386, 33);
            this.xMagCheckBox.Name = "xMagCheckBox";
            this.xMagCheckBox.Size = new System.Drawing.Size(62, 20);
            this.xMagCheckBox.TabIndex = 9;
            this.xMagCheckBox.Text = "xmag";
            this.xMagCheckBox.UseVisualStyleBackColor = true;
            this.xMagCheckBox.CheckStateChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // zGyroCheckBox
            // 
            this.zGyroCheckBox.AutoSize = true;
            this.zGyroCheckBox.Location = new System.Drawing.Point(323, 33);
            this.zGyroCheckBox.Name = "zGyroCheckBox";
            this.zGyroCheckBox.Size = new System.Drawing.Size(62, 20);
            this.zGyroCheckBox.TabIndex = 8;
            this.zGyroCheckBox.Text = "zgyro";
            this.zGyroCheckBox.UseVisualStyleBackColor = true;
            this.zGyroCheckBox.CheckStateChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // yGyroCheckBox
            // 
            this.yGyroCheckBox.AutoSize = true;
            this.yGyroCheckBox.Location = new System.Drawing.Point(260, 33);
            this.yGyroCheckBox.Name = "yGyroCheckBox";
            this.yGyroCheckBox.Size = new System.Drawing.Size(63, 20);
            this.yGyroCheckBox.TabIndex = 7;
            this.yGyroCheckBox.Text = "ygyro";
            this.yGyroCheckBox.UseVisualStyleBackColor = true;
            this.yGyroCheckBox.CheckStateChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // xGyroCheckBox
            // 
            this.xGyroCheckBox.AutoSize = true;
            this.xGyroCheckBox.Location = new System.Drawing.Point(197, 33);
            this.xGyroCheckBox.Name = "xGyroCheckBox";
            this.xGyroCheckBox.Size = new System.Drawing.Size(62, 20);
            this.xGyroCheckBox.TabIndex = 6;
            this.xGyroCheckBox.Text = "xgyro";
            this.xGyroCheckBox.UseVisualStyleBackColor = true;
            this.xGyroCheckBox.CheckStateChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // zAccCheckBox
            // 
            this.zAccCheckBox.AutoSize = true;
            this.zAccCheckBox.Location = new System.Drawing.Point(134, 33);
            this.zAccCheckBox.Name = "zAccCheckBox";
            this.zAccCheckBox.Size = new System.Drawing.Size(57, 20);
            this.zAccCheckBox.TabIndex = 5;
            this.zAccCheckBox.Text = "zacc";
            this.zAccCheckBox.UseVisualStyleBackColor = true;
            this.zAccCheckBox.CheckStateChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // yAccCheckBox
            // 
            this.yAccCheckBox.AutoSize = true;
            this.yAccCheckBox.Location = new System.Drawing.Point(71, 33);
            this.yAccCheckBox.Name = "yAccCheckBox";
            this.yAccCheckBox.Size = new System.Drawing.Size(58, 20);
            this.yAccCheckBox.TabIndex = 4;
            this.yAccCheckBox.Text = "yacc";
            this.yAccCheckBox.UseVisualStyleBackColor = true;
            this.yAccCheckBox.CheckStateChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // xAccCheckBox
            // 
            this.xAccCheckBox.AutoSize = true;
            this.xAccCheckBox.Location = new System.Drawing.Point(8, 33);
            this.xAccCheckBox.Name = "xAccCheckBox";
            this.xAccCheckBox.Size = new System.Drawing.Size(57, 20);
            this.xAccCheckBox.TabIndex = 3;
            this.xAccCheckBox.Text = "xacc";
            this.xAccCheckBox.UseVisualStyleBackColor = true;
            this.xAccCheckBox.CheckStateChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // diapasonNumericUpDown
            // 
            this.diapasonNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.diapasonNumericUpDown.Location = new System.Drawing.Point(178, 4);
            this.diapasonNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.diapasonNumericUpDown.Name = "diapasonNumericUpDown";
            this.diapasonNumericUpDown.Size = new System.Drawing.Size(55, 22);
            this.diapasonNumericUpDown.TabIndex = 2;
            this.diapasonNumericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // stepLabel
            // 
            this.stepLabel.AutoSize = true;
            this.stepLabel.Location = new System.Drawing.Point(9, 4);
            this.stepLabel.Name = "stepLabel";
            this.stepLabel.Size = new System.Drawing.Size(163, 16);
            this.stepLabel.TabIndex = 1;
            this.stepLabel.Text = "Діапазон спостережень";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.backwardLabel);
            this.panel1.Controls.Add(this.rightLabel);
            this.panel1.Controls.Add(this.forwardLabel);
            this.panel1.Controls.Add(this.leftLabel);
            this.panel1.Controls.Add(this.vibrationLabel);
            this.panel1.Controls.Add(this.cmb_baudrate);
            this.panel1.Controls.Add(this.CMB_comport);
            this.panel1.Controls.Add(this.but_mission);
            this.panel1.Controls.Add(this.but_connect);
            this.panel1.Controls.Add(this.but_armdisarm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 82);
            this.panel1.TabIndex = 115;
            // 
            // forwardLabel
            // 
            this.forwardLabel.AutoSize = true;
            this.forwardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forwardLabel.Location = new System.Drawing.Point(709, 31);
            this.forwardLabel.Name = "forwardLabel";
            this.forwardLabel.Size = new System.Drawing.Size(113, 20);
            this.forwardLabel.TabIndex = 7;
            this.forwardLabel.Text = "Прямий хід";
            // 
            // leftLabel
            // 
            this.leftLabel.AutoSize = true;
            this.leftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftLabel.Location = new System.Drawing.Point(709, 53);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(143, 20);
            this.leftLabel.TabIndex = 6;
            this.leftLabel.Text = "Лівий поворот";
            // 
            // vibrationLabel
            // 
            this.vibrationLabel.AutoSize = true;
            this.vibrationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vibrationLabel.Location = new System.Drawing.Point(709, 9);
            this.vibrationLabel.Name = "vibrationLabel";
            this.vibrationLabel.Size = new System.Drawing.Size(87, 20);
            this.vibrationLabel.TabIndex = 5;
            this.vibrationLabel.Text = "Вібрація";
            // 
            // rightLabel
            // 
            this.rightLabel.AutoSize = true;
            this.rightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightLabel.Location = new System.Drawing.Point(709, 51);
            this.rightLabel.Name = "rightLabel";
            this.rightLabel.Size = new System.Drawing.Size(161, 20);
            this.rightLabel.TabIndex = 8;
            this.rightLabel.Text = "Правий поворот";
            // 
            // backwardLabel
            // 
            this.backwardLabel.AutoSize = true;
            this.backwardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backwardLabel.Location = new System.Drawing.Point(709, 31);
            this.backwardLabel.Name = "backwardLabel";
            this.backwardLabel.Size = new System.Drawing.Size(106, 20);
            this.backwardLabel.TabIndex = 9;
            this.backwardLabel.Text = "Задній хід";
            // 
            // simpleexample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 638);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "simpleexample";
            this.Text = "Дані з польотного контролера";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IMUdataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IMUchart)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.divisionsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diapasonNumericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CMB_comport;
        private System.Windows.Forms.ComboBox cmb_baudrate;
        private System.Windows.Forms.Button but_connect;
        private System.Windows.Forms.Button but_armdisarm;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button but_mission;
        private System.Windows.Forms.Label z0Label;
        private System.Windows.Forms.Label y0Label;
        private System.Windows.Forms.Label x0Label;
        private System.Windows.Forms.TextBox y0TextBox;
        private System.Windows.Forms.TextBox x0TextBox;
        private System.Windows.Forms.TextBox x1TextBox;
        private System.Windows.Forms.TextBox y1TextBox;
        private System.Windows.Forms.Label x1Label;
        private System.Windows.Forms.Label y2Label;
        private System.Windows.Forms.TextBox z1TextBox;
        private System.Windows.Forms.Label z1Label;
        private System.Windows.Forms.TextBox vxTextBox;
        private System.Windows.Forms.TextBox vyTextBox;
        private System.Windows.Forms.Label vxLabel;
        private System.Windows.Forms.Label vyLabel;
        private System.Windows.Forms.TextBox vzTextBox;
        private System.Windows.Forms.Label vzLabel;
        private System.Windows.Forms.Label velocityLabel;
        private System.Windows.Forms.Label position1Label;
        private System.Windows.Forms.Label position0Label;
        private System.Windows.Forms.TextBox z0TextBox;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TextBox vGroundSpeedTextBox;
        private System.Windows.Forms.TextBox vAirSpeedTextBox;
        private System.Windows.Forms.Label vGroundLabel;
        private System.Windows.Forms.Label vAirLabel;
        private System.Windows.Forms.TextBox headingTextBox;
        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.TextBox altTextBox;
        private System.Windows.Forms.Label altLabel;
        private System.Windows.Forms.Label hudLabel;
        private System.Windows.Forms.TextBox throttleTextBox;
        private System.Windows.Forms.TextBox climbTextBox;
        private System.Windows.Forms.Label throttleLabel;
        private System.Windows.Forms.Label climbLabel;
        private System.Windows.Forms.TextBox dxTextBox;
        private System.Windows.Forms.TextBox dyTextBox;
        private System.Windows.Forms.Label dxLabel;
        private System.Windows.Forms.Label dyLabel;
        private System.Windows.Forms.TextBox dzTextBox;
        private System.Windows.Forms.Label dzLabel;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.TextBox orientTextBox;
        private System.Windows.Forms.Label orientLabel;
        private System.Windows.Forms.TextBox ymagTextBox;
        private System.Windows.Forms.Label ymagLabel;
        private System.Windows.Forms.TextBox xmagTextBox;
        private System.Windows.Forms.Label xmagLabel;
        private System.Windows.Forms.TextBox xgyroTextBox;
        private System.Windows.Forms.Label xgyroLabel;
        private System.Windows.Forms.TextBox yaccTextBox;
        private System.Windows.Forms.TextBox ygyroTextBox;
        private System.Windows.Forms.Label yaccLabel;
        private System.Windows.Forms.Label ygyroLabel;
        private System.Windows.Forms.TextBox xaccTextBox;
        private System.Windows.Forms.Label xaccLabel;
        private System.Windows.Forms.TextBox temperatureTextBox;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox time_usecTextBox;
        private System.Windows.Forms.Label time_usecLabel;
        private System.Windows.Forms.TextBox zmagTextBox;
        private System.Windows.Forms.Label zmagLabel;
        private System.Windows.Forms.TextBox zaccTextBox;
        private System.Windows.Forms.TextBox zgyroTextBox;
        private System.Windows.Forms.Label zaccLabel;
        private System.Windows.Forms.Label zgyroLabel;
        private System.Windows.Forms.TextBox fzmagTextBox;
        private System.Windows.Forms.TextBox fzaccTextBox;
        private System.Windows.Forms.TextBox fzgyroTextBox;
        private System.Windows.Forms.TextBox fymagTextBox;
        private System.Windows.Forms.TextBox fxmagTextBox;
        private System.Windows.Forms.TextBox fxgyroTextBox;
        private System.Windows.Forms.TextBox fyaccTextBox;
        private System.Windows.Forms.TextBox fygyroTextBox;
        private System.Windows.Forms.TextBox fxaccTextBox;
        private System.Windows.Forms.TextBox rawAltTextBox;
        private System.Windows.Forms.Label rawAltLabel;
        private System.Windows.Forms.TextBox rawLonTextBox;
        private System.Windows.Forms.Label rawLonLabel;
        private System.Windows.Forms.TextBox rawLatTextBox;
        private System.Windows.Forms.Label rawLatLabel;
        private System.Windows.Forms.TextBox wayTextBox;
        private System.Windows.Forms.Label wayLabel;
        private System.Windows.Forms.TextBox gyroTextBox;
        private System.Windows.Forms.Label gyroLabel;
        private System.Windows.Forms.TextBox accTextBox;
        private System.Windows.Forms.Label accLabel;
        private System.Windows.Forms.TextBox maxAccTextBox;
        private System.Windows.Forms.Label maxAccLabel;
        private System.Windows.Forms.TextBox maxGyroTextBox;
        private System.Windows.Forms.Label maxGyroLabel;
        private System.Windows.Forms.TextBox sumAccTextBox;
        private System.Windows.Forms.Label sumAccLabel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView IMUdataGridView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart IMUchart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown diapasonNumericUpDown;
        private System.Windows.Forms.Label stepLabel;
        private System.Windows.Forms.CheckBox xAccCheckBox;
        private System.Windows.Forms.NumericUpDown maxYNumericUpDown;
        private System.Windows.Forms.Label maxYLabel;
        private System.Windows.Forms.NumericUpDown minYNumericUpDown;
        private System.Windows.Forms.Label minYLabel;
        private System.Windows.Forms.CheckBox zMagCheckBox;
        private System.Windows.Forms.CheckBox yMagCheckBox;
        private System.Windows.Forms.CheckBox xMagCheckBox;
        private System.Windows.Forms.CheckBox zGyroCheckBox;
        private System.Windows.Forms.CheckBox yGyroCheckBox;
        private System.Windows.Forms.CheckBox xGyroCheckBox;
        private System.Windows.Forms.CheckBox zAccCheckBox;
        private System.Windows.Forms.CheckBox yAccCheckBox;
        private System.Windows.Forms.ComboBox themesComboBox;
        private System.Windows.Forms.CheckBox vaccCheckBox;
        private System.Windows.Forms.CheckBox vabsCheckBox;
        private System.Windows.Forms.NumericUpDown divisionsNumericUpDown;
        private System.Windows.Forms.Label divisionsLabel;
        private System.Windows.Forms.CheckBox dirCheckBox;
        private System.Windows.Forms.Label vibrationLabel;
        private System.Windows.Forms.Label forwardLabel;
        private System.Windows.Forms.Label leftLabel;
        private System.Windows.Forms.Label rightLabel;
        private System.Windows.Forms.Label backwardLabel;
    }
}

