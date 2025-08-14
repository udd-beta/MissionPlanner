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
            this.SuspendLayout();
            // 
            // CMB_comport
            // 
            this.CMB_comport.FormattingEnabled = true;
            this.CMB_comport.Location = new System.Drawing.Point(17, 16);
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
            this.cmb_baudrate.Location = new System.Drawing.Point(187, 15);
            this.cmb_baudrate.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_baudrate.Name = "cmb_baudrate";
            this.cmb_baudrate.Size = new System.Drawing.Size(160, 24);
            this.cmb_baudrate.TabIndex = 1;
            // 
            // but_connect
            // 
            this.but_connect.Location = new System.Drawing.Point(357, 15);
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
            this.but_armdisarm.Location = new System.Drawing.Point(603, 15);
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
            this.but_mission.Location = new System.Drawing.Point(465, 15);
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
            this.z0Label.Location = new System.Drawing.Point(184, 65);
            this.z0Label.Name = "z0Label";
            this.z0Label.Size = new System.Drawing.Size(72, 16);
            this.z0Label.TabIndex = 5;
            this.z0Label.Text = "Висота, м.";
            // 
            // y0Label
            // 
            this.y0Label.AutoSize = true;
            this.y0Label.Location = new System.Drawing.Point(354, 65);
            this.y0Label.Name = "y0Label";
            this.y0Label.Size = new System.Drawing.Size(75, 16);
            this.y0Label.TabIndex = 7;
            this.y0Label.Text = "Широта, м.";
            // 
            // x0Label
            // 
            this.x0Label.AutoSize = true;
            this.x0Label.Location = new System.Drawing.Point(555, 65);
            this.x0Label.Name = "x0Label";
            this.x0Label.Size = new System.Drawing.Size(79, 16);
            this.x0Label.TabIndex = 9;
            this.x0Label.Text = "Довгота, м.";
            // 
            // y0TextBox
            // 
            this.y0TextBox.Location = new System.Drawing.Point(463, 62);
            this.y0TextBox.Name = "y0TextBox";
            this.y0TextBox.Size = new System.Drawing.Size(54, 22);
            this.y0TextBox.TabIndex = 10;
            // 
            // x0TextBox
            // 
            this.x0TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.x0TextBox.Location = new System.Drawing.Point(635, 62);
            this.x0TextBox.Name = "x0TextBox";
            this.x0TextBox.Size = new System.Drawing.Size(54, 22);
            this.x0TextBox.TabIndex = 11;
            // 
            // x1TextBox
            // 
            this.x1TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.x1TextBox.Location = new System.Drawing.Point(635, 90);
            this.x1TextBox.Name = "x1TextBox";
            this.x1TextBox.Size = new System.Drawing.Size(54, 22);
            this.x1TextBox.TabIndex = 17;
            // 
            // y1TextBox
            // 
            this.y1TextBox.Location = new System.Drawing.Point(463, 90);
            this.y1TextBox.Name = "y1TextBox";
            this.y1TextBox.Size = new System.Drawing.Size(54, 22);
            this.y1TextBox.TabIndex = 16;
            // 
            // x1Label
            // 
            this.x1Label.AutoSize = true;
            this.x1Label.Location = new System.Drawing.Point(555, 93);
            this.x1Label.Name = "x1Label";
            this.x1Label.Size = new System.Drawing.Size(79, 16);
            this.x1Label.TabIndex = 15;
            this.x1Label.Text = "Довгота, м.";
            // 
            // y2Label
            // 
            this.y2Label.AutoSize = true;
            this.y2Label.Location = new System.Drawing.Point(354, 93);
            this.y2Label.Name = "y2Label";
            this.y2Label.Size = new System.Drawing.Size(75, 16);
            this.y2Label.TabIndex = 14;
            this.y2Label.Text = "Широта, м.";
            // 
            // z1TextBox
            // 
            this.z1TextBox.Location = new System.Drawing.Point(262, 90);
            this.z1TextBox.Name = "z1TextBox";
            this.z1TextBox.Size = new System.Drawing.Size(54, 22);
            this.z1TextBox.TabIndex = 13;
            // 
            // z1Label
            // 
            this.z1Label.AutoSize = true;
            this.z1Label.Location = new System.Drawing.Point(184, 93);
            this.z1Label.Name = "z1Label";
            this.z1Label.Size = new System.Drawing.Size(72, 16);
            this.z1Label.TabIndex = 12;
            this.z1Label.Text = "Висота, м.";
            // 
            // vxTextBox
            // 
            this.vxTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.vxTextBox.Location = new System.Drawing.Point(635, 126);
            this.vxTextBox.Name = "vxTextBox";
            this.vxTextBox.Size = new System.Drawing.Size(54, 22);
            this.vxTextBox.TabIndex = 23;
            // 
            // vyTextBox
            // 
            this.vyTextBox.Location = new System.Drawing.Point(463, 126);
            this.vyTextBox.Name = "vyTextBox";
            this.vyTextBox.Size = new System.Drawing.Size(54, 22);
            this.vyTextBox.TabIndex = 22;
            // 
            // vxLabel
            // 
            this.vxLabel.AutoSize = true;
            this.vxLabel.Location = new System.Drawing.Point(555, 129);
            this.vxLabel.Name = "vxLabel";
            this.vxLabel.Size = new System.Drawing.Size(76, 16);
            this.vxLabel.TabIndex = 21;
            this.vxLabel.Text = "По довготі";
            // 
            // vyLabel
            // 
            this.vyLabel.AutoSize = true;
            this.vyLabel.Location = new System.Drawing.Point(354, 129);
            this.vyLabel.Name = "vyLabel";
            this.vyLabel.Size = new System.Drawing.Size(71, 16);
            this.vyLabel.TabIndex = 20;
            this.vyLabel.Text = "По широті";
            // 
            // vzTextBox
            // 
            this.vzTextBox.Location = new System.Drawing.Point(262, 126);
            this.vzTextBox.Name = "vzTextBox";
            this.vzTextBox.Size = new System.Drawing.Size(54, 22);
            this.vzTextBox.TabIndex = 19;
            // 
            // vzLabel
            // 
            this.vzLabel.AutoSize = true;
            this.vzLabel.Location = new System.Drawing.Point(184, 129);
            this.vzLabel.Name = "vzLabel";
            this.vzLabel.Size = new System.Drawing.Size(65, 16);
            this.vzLabel.TabIndex = 18;
            this.vzLabel.Text = "У висоту";
            // 
            // velocityLabel
            // 
            this.velocityLabel.AutoSize = true;
            this.velocityLabel.Location = new System.Drawing.Point(28, 126);
            this.velocityLabel.Name = "velocityLabel";
            this.velocityLabel.Size = new System.Drawing.Size(76, 16);
            this.velocityLabel.TabIndex = 26;
            this.velocityLabel.Text = "Швидкість:";
            // 
            // position1Label
            // 
            this.position1Label.AutoSize = true;
            this.position1Label.Location = new System.Drawing.Point(28, 90);
            this.position1Label.Name = "position1Label";
            this.position1Label.Size = new System.Drawing.Size(120, 16);
            this.position1Label.TabIndex = 25;
            this.position1Label.Text = "Поточна позиція:";
            // 
            // position0Label
            // 
            this.position0Label.AutoSize = true;
            this.position0Label.Location = new System.Drawing.Point(28, 62);
            this.position0Label.Name = "position0Label";
            this.position0Label.Size = new System.Drawing.Size(135, 16);
            this.position0Label.TabIndex = 24;
            this.position0Label.Text = "Початкова позиція:";
            // 
            // z0TextBox
            // 
            this.z0TextBox.Location = new System.Drawing.Point(262, 62);
            this.z0TextBox.Name = "z0TextBox";
            this.z0TextBox.Size = new System.Drawing.Size(54, 22);
            this.z0TextBox.TabIndex = 6;
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(592, 168);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(97, 22);
            this.timeTextBox.TabIndex = 28;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(555, 168);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(31, 16);
            this.timeLabel.TabIndex = 27;
            this.timeLabel.Text = "Час";
            // 
            // vGroundSpeedTextBox
            // 
            this.vGroundSpeedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.vGroundSpeedTextBox.Location = new System.Drawing.Point(463, 210);
            this.vGroundSpeedTextBox.Name = "vGroundSpeedTextBox";
            this.vGroundSpeedTextBox.Size = new System.Drawing.Size(54, 22);
            this.vGroundSpeedTextBox.TabIndex = 34;
            // 
            // vAirSpeedTextBox
            // 
            this.vAirSpeedTextBox.Location = new System.Drawing.Point(463, 250);
            this.vAirSpeedTextBox.Name = "vAirSpeedTextBox";
            this.vAirSpeedTextBox.Size = new System.Drawing.Size(54, 22);
            this.vAirSpeedTextBox.TabIndex = 33;
            // 
            // vGroundLabel
            // 
            this.vGroundLabel.AutoSize = true;
            this.vGroundLabel.Location = new System.Drawing.Point(333, 213);
            this.vGroundLabel.Name = "vGroundLabel";
            this.vGroundLabel.Size = new System.Drawing.Size(130, 16);
            this.vGroundLabel.TabIndex = 32;
            this.vGroundLabel.Text = "Шляхова швидкість";
            // 
            // vAirLabel
            // 
            this.vAirLabel.AutoSize = true;
            this.vAirLabel.Location = new System.Drawing.Point(322, 253);
            this.vAirLabel.Name = "vAirLabel";
            this.vAirLabel.Size = new System.Drawing.Size(141, 16);
            this.vAirLabel.TabIndex = 31;
            this.vAirLabel.Text = "Повітряна швидкість";
            // 
            // headingTextBox
            // 
            this.headingTextBox.Location = new System.Drawing.Point(262, 210);
            this.headingTextBox.Name = "headingTextBox";
            this.headingTextBox.Size = new System.Drawing.Size(54, 22);
            this.headingTextBox.TabIndex = 30;
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Location = new System.Drawing.Point(170, 213);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(87, 16);
            this.headingLabel.TabIndex = 29;
            this.headingLabel.Text = "Орієнтація, °";
            // 
            // altTextBox
            // 
            this.altTextBox.Location = new System.Drawing.Point(262, 250);
            this.altTextBox.Name = "altTextBox";
            this.altTextBox.Size = new System.Drawing.Size(54, 22);
            this.altTextBox.TabIndex = 36;
            // 
            // altLabel
            // 
            this.altLabel.AutoSize = true;
            this.altLabel.Location = new System.Drawing.Point(182, 253);
            this.altLabel.Name = "altLabel";
            this.altLabel.Size = new System.Drawing.Size(54, 16);
            this.altLabel.TabIndex = 35;
            this.altLabel.Text = "Висота";
            // 
            // hudLabel
            // 
            this.hudLabel.AutoSize = true;
            this.hudLabel.Location = new System.Drawing.Point(28, 216);
            this.hudLabel.Name = "hudLabel";
            this.hudLabel.Size = new System.Drawing.Size(96, 16);
            this.hudLabel.TabIndex = 37;
            this.hudLabel.Text = "Дані компаса:";
            // 
            // throttleTextBox
            // 
            this.throttleTextBox.Location = new System.Drawing.Point(644, 210);
            this.throttleTextBox.Name = "throttleTextBox";
            this.throttleTextBox.Size = new System.Drawing.Size(54, 22);
            this.throttleTextBox.TabIndex = 41;
            // 
            // climbTextBox
            // 
            this.climbTextBox.Location = new System.Drawing.Point(644, 250);
            this.climbTextBox.Name = "climbTextBox";
            this.climbTextBox.Size = new System.Drawing.Size(54, 22);
            this.climbTextBox.TabIndex = 40;
            // 
            // throttleLabel
            // 
            this.throttleLabel.AutoSize = true;
            this.throttleLabel.Location = new System.Drawing.Point(572, 216);
            this.throttleLabel.Name = "throttleLabel";
            this.throttleLabel.Size = new System.Drawing.Size(62, 16);
            this.throttleLabel.TabIndex = 39;
            this.throttleLabel.Text = "Дросель";
            // 
            // climbLabel
            // 
            this.climbLabel.AutoSize = true;
            this.climbLabel.Location = new System.Drawing.Point(578, 253);
            this.climbLabel.Name = "climbLabel";
            this.climbLabel.Size = new System.Drawing.Size(53, 16);
            this.climbLabel.TabIndex = 38;
            this.climbLabel.Text = "Підйом";
            // 
            // dxTextBox
            // 
            this.dxTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dxTextBox.Location = new System.Drawing.Point(644, 290);
            this.dxTextBox.Name = "dxTextBox";
            this.dxTextBox.Size = new System.Drawing.Size(54, 22);
            this.dxTextBox.TabIndex = 47;
            // 
            // dyTextBox
            // 
            this.dyTextBox.Location = new System.Drawing.Point(464, 290);
            this.dyTextBox.Name = "dyTextBox";
            this.dyTextBox.Size = new System.Drawing.Size(54, 22);
            this.dyTextBox.TabIndex = 46;
            // 
            // dxLabel
            // 
            this.dxLabel.AutoSize = true;
            this.dxLabel.Location = new System.Drawing.Point(556, 293);
            this.dxLabel.Name = "dxLabel";
            this.dxLabel.Size = new System.Drawing.Size(79, 16);
            this.dxLabel.TabIndex = 45;
            this.dxLabel.Text = "Довгота, м.";
            // 
            // dyLabel
            // 
            this.dyLabel.AutoSize = true;
            this.dyLabel.Location = new System.Drawing.Point(355, 293);
            this.dyLabel.Name = "dyLabel";
            this.dyLabel.Size = new System.Drawing.Size(75, 16);
            this.dyLabel.TabIndex = 44;
            this.dyLabel.Text = "Широта, м.";
            // 
            // dzTextBox
            // 
            this.dzTextBox.Location = new System.Drawing.Point(263, 290);
            this.dzTextBox.Name = "dzTextBox";
            this.dzTextBox.Size = new System.Drawing.Size(54, 22);
            this.dzTextBox.TabIndex = 43;
            // 
            // dzLabel
            // 
            this.dzLabel.AutoSize = true;
            this.dzLabel.Location = new System.Drawing.Point(185, 293);
            this.dzLabel.Name = "dzLabel";
            this.dzLabel.Size = new System.Drawing.Size(72, 16);
            this.dzLabel.TabIndex = 42;
            this.dzLabel.Text = "Висота, м.";
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Location = new System.Drawing.Point(14, 293);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(160, 16);
            this.dLabel.TabIndex = 48;
            this.dLabel.Text = "Розраховане зміщення:";
            // 
            // orientTextBox
            // 
            this.orientTextBox.Location = new System.Drawing.Point(262, 162);
            this.orientTextBox.Name = "orientTextBox";
            this.orientTextBox.Size = new System.Drawing.Size(54, 22);
            this.orientTextBox.TabIndex = 50;
            // 
            // orientLabel
            // 
            this.orientLabel.AutoSize = true;
            this.orientLabel.Location = new System.Drawing.Point(170, 165);
            this.orientLabel.Name = "orientLabel";
            this.orientLabel.Size = new System.Drawing.Size(87, 16);
            this.orientLabel.TabIndex = 49;
            this.orientLabel.Text = "Орієнтація, °";
            // 
            // ymagTextBox
            // 
            this.ymagTextBox.Location = new System.Drawing.Point(561, 453);
            this.ymagTextBox.Name = "ymagTextBox";
            this.ymagTextBox.Size = new System.Drawing.Size(54, 22);
            this.ymagTextBox.TabIndex = 67;
            // 
            // ymagLabel
            // 
            this.ymagLabel.AutoSize = true;
            this.ymagLabel.Location = new System.Drawing.Point(541, 453);
            this.ymagLabel.Name = "ymagLabel";
            this.ymagLabel.Size = new System.Drawing.Size(14, 16);
            this.ymagLabel.TabIndex = 65;
            this.ymagLabel.Text = "y";
            // 
            // xmagTextBox
            // 
            this.xmagTextBox.Location = new System.Drawing.Point(481, 450);
            this.xmagTextBox.Name = "xmagTextBox";
            this.xmagTextBox.Size = new System.Drawing.Size(54, 22);
            this.xmagTextBox.TabIndex = 64;
            // 
            // xmagLabel
            // 
            this.xmagLabel.AutoSize = true;
            this.xmagLabel.Location = new System.Drawing.Point(233, 456);
            this.xmagLabel.Name = "xmagLabel";
            this.xmagLabel.Size = new System.Drawing.Size(230, 16);
            this.xmagLabel.TabIndex = 63;
            this.xmagLabel.Text = "Магнітне поле вздовж осі, гаус:    х";
            // 
            // xgyroTextBox
            // 
            this.xgyroTextBox.Location = new System.Drawing.Point(481, 391);
            this.xgyroTextBox.Name = "xgyroTextBox";
            this.xgyroTextBox.Size = new System.Drawing.Size(54, 22);
            this.xgyroTextBox.TabIndex = 58;
            // 
            // xgyroLabel
            // 
            this.xgyroLabel.AutoSize = true;
            this.xgyroLabel.Location = new System.Drawing.Point(201, 397);
            this.xgyroLabel.Name = "xgyroLabel";
            this.xgyroLabel.Size = new System.Drawing.Size(262, 16);
            this.xgyroLabel.TabIndex = 57;
            this.xgyroLabel.Text = "Кутова швидкість довкола осі, рад/с:    х";
            // 
            // yaccTextBox
            // 
            this.yaccTextBox.Location = new System.Drawing.Point(561, 339);
            this.yaccTextBox.Name = "yaccTextBox";
            this.yaccTextBox.Size = new System.Drawing.Size(54, 22);
            this.yaccTextBox.TabIndex = 56;
            // 
            // ygyroTextBox
            // 
            this.ygyroTextBox.Location = new System.Drawing.Point(561, 394);
            this.ygyroTextBox.Name = "ygyroTextBox";
            this.ygyroTextBox.Size = new System.Drawing.Size(54, 22);
            this.ygyroTextBox.TabIndex = 55;
            // 
            // yaccLabel
            // 
            this.yaccLabel.AutoSize = true;
            this.yaccLabel.Location = new System.Drawing.Point(541, 342);
            this.yaccLabel.Name = "yaccLabel";
            this.yaccLabel.Size = new System.Drawing.Size(14, 16);
            this.yaccLabel.TabIndex = 54;
            this.yaccLabel.Text = "y";
            // 
            // ygyroLabel
            // 
            this.ygyroLabel.AutoSize = true;
            this.ygyroLabel.Location = new System.Drawing.Point(541, 394);
            this.ygyroLabel.Name = "ygyroLabel";
            this.ygyroLabel.Size = new System.Drawing.Size(14, 16);
            this.ygyroLabel.TabIndex = 53;
            this.ygyroLabel.Text = "y";
            // 
            // xaccTextBox
            // 
            this.xaccTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.xaccTextBox.Location = new System.Drawing.Point(481, 336);
            this.xaccTextBox.Name = "xaccTextBox";
            this.xaccTextBox.Size = new System.Drawing.Size(54, 22);
            this.xaccTextBox.TabIndex = 52;
            // 
            // xaccLabel
            // 
            this.xaccLabel.AutoSize = true;
            this.xaccLabel.Location = new System.Drawing.Point(259, 345);
            this.xaccLabel.Name = "xaccLabel";
            this.xaccLabel.Size = new System.Drawing.Size(204, 16);
            this.xaccLabel.TabIndex = 51;
            this.xaccLabel.Text = "Прискорення вздовж осі, G:    х";
            // 
            // temperatureTextBox
            // 
            this.temperatureTextBox.Location = new System.Drawing.Point(139, 397);
            this.temperatureTextBox.Name = "temperatureTextBox";
            this.temperatureTextBox.Size = new System.Drawing.Size(54, 22);
            this.temperatureTextBox.TabIndex = 74;
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Location = new System.Drawing.Point(18, 400);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(96, 16);
            this.temperatureLabel.TabIndex = 73;
            this.temperatureLabel.Text = "Температура";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(139, 367);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(54, 22);
            this.idTextBox.TabIndex = 72;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(96, 370);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 16);
            this.idLabel.TabIndex = 71;
            this.idLabel.Text = "id";
            // 
            // time_usecTextBox
            // 
            this.time_usecTextBox.Location = new System.Drawing.Point(139, 336);
            this.time_usecTextBox.Name = "time_usecTextBox";
            this.time_usecTextBox.Size = new System.Drawing.Size(97, 22);
            this.time_usecTextBox.TabIndex = 70;
            // 
            // time_usecLabel
            // 
            this.time_usecLabel.AutoSize = true;
            this.time_usecLabel.Location = new System.Drawing.Point(12, 339);
            this.time_usecLabel.Name = "time_usecLabel";
            this.time_usecLabel.Size = new System.Drawing.Size(110, 16);
            this.time_usecLabel.TabIndex = 69;
            this.time_usecLabel.Text = "Час від запуску";
            // 
            // zmagTextBox
            // 
            this.zmagTextBox.Location = new System.Drawing.Point(641, 453);
            this.zmagTextBox.Name = "zmagTextBox";
            this.zmagTextBox.Size = new System.Drawing.Size(54, 22);
            this.zmagTextBox.TabIndex = 80;
            // 
            // zmagLabel
            // 
            this.zmagLabel.AutoSize = true;
            this.zmagLabel.Location = new System.Drawing.Point(621, 453);
            this.zmagLabel.Name = "zmagLabel";
            this.zmagLabel.Size = new System.Drawing.Size(13, 16);
            this.zmagLabel.TabIndex = 79;
            this.zmagLabel.Text = "z";
            // 
            // zaccTextBox
            // 
            this.zaccTextBox.Location = new System.Drawing.Point(641, 339);
            this.zaccTextBox.Name = "zaccTextBox";
            this.zaccTextBox.Size = new System.Drawing.Size(54, 22);
            this.zaccTextBox.TabIndex = 78;
            // 
            // zgyroTextBox
            // 
            this.zgyroTextBox.Location = new System.Drawing.Point(641, 394);
            this.zgyroTextBox.Name = "zgyroTextBox";
            this.zgyroTextBox.Size = new System.Drawing.Size(54, 22);
            this.zgyroTextBox.TabIndex = 77;
            // 
            // zaccLabel
            // 
            this.zaccLabel.AutoSize = true;
            this.zaccLabel.Location = new System.Drawing.Point(621, 342);
            this.zaccLabel.Name = "zaccLabel";
            this.zaccLabel.Size = new System.Drawing.Size(13, 16);
            this.zaccLabel.TabIndex = 76;
            this.zaccLabel.Text = "z";
            // 
            // zgyroLabel
            // 
            this.zgyroLabel.AutoSize = true;
            this.zgyroLabel.Location = new System.Drawing.Point(621, 394);
            this.zgyroLabel.Name = "zgyroLabel";
            this.zgyroLabel.Size = new System.Drawing.Size(13, 16);
            this.zgyroLabel.TabIndex = 75;
            this.zgyroLabel.Text = "z";
            // 
            // fzmagTextBox
            // 
            this.fzmagTextBox.Location = new System.Drawing.Point(641, 481);
            this.fzmagTextBox.Name = "fzmagTextBox";
            this.fzmagTextBox.Size = new System.Drawing.Size(54, 22);
            this.fzmagTextBox.TabIndex = 95;
            // 
            // fzaccTextBox
            // 
            this.fzaccTextBox.Location = new System.Drawing.Point(641, 367);
            this.fzaccTextBox.Name = "fzaccTextBox";
            this.fzaccTextBox.Size = new System.Drawing.Size(54, 22);
            this.fzaccTextBox.TabIndex = 93;
            // 
            // fzgyroTextBox
            // 
            this.fzgyroTextBox.Location = new System.Drawing.Point(641, 422);
            this.fzgyroTextBox.Name = "fzgyroTextBox";
            this.fzgyroTextBox.Size = new System.Drawing.Size(54, 22);
            this.fzgyroTextBox.TabIndex = 92;
            // 
            // fymagTextBox
            // 
            this.fymagTextBox.Location = new System.Drawing.Point(561, 481);
            this.fymagTextBox.Name = "fymagTextBox";
            this.fymagTextBox.Size = new System.Drawing.Size(54, 22);
            this.fymagTextBox.TabIndex = 89;
            // 
            // fxmagTextBox
            // 
            this.fxmagTextBox.Location = new System.Drawing.Point(481, 478);
            this.fxmagTextBox.Name = "fxmagTextBox";
            this.fxmagTextBox.Size = new System.Drawing.Size(54, 22);
            this.fxmagTextBox.TabIndex = 87;
            // 
            // fxgyroTextBox
            // 
            this.fxgyroTextBox.Location = new System.Drawing.Point(481, 419);
            this.fxgyroTextBox.Name = "fxgyroTextBox";
            this.fxgyroTextBox.Size = new System.Drawing.Size(54, 22);
            this.fxgyroTextBox.TabIndex = 86;
            // 
            // fyaccTextBox
            // 
            this.fyaccTextBox.Location = new System.Drawing.Point(561, 367);
            this.fyaccTextBox.Name = "fyaccTextBox";
            this.fyaccTextBox.Size = new System.Drawing.Size(54, 22);
            this.fyaccTextBox.TabIndex = 85;
            // 
            // fygyroTextBox
            // 
            this.fygyroTextBox.Location = new System.Drawing.Point(561, 422);
            this.fygyroTextBox.Name = "fygyroTextBox";
            this.fygyroTextBox.Size = new System.Drawing.Size(54, 22);
            this.fygyroTextBox.TabIndex = 84;
            // 
            // fxaccTextBox
            // 
            this.fxaccTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.fxaccTextBox.Location = new System.Drawing.Point(481, 364);
            this.fxaccTextBox.Name = "fxaccTextBox";
            this.fxaccTextBox.Size = new System.Drawing.Size(54, 22);
            this.fxaccTextBox.TabIndex = 81;
            // 
            // rawAltTextBox
            // 
            this.rawAltTextBox.Location = new System.Drawing.Point(641, 528);
            this.rawAltTextBox.Name = "rawAltTextBox";
            this.rawAltTextBox.Size = new System.Drawing.Size(54, 22);
            this.rawAltTextBox.TabIndex = 101;
            // 
            // rawAltLabel
            // 
            this.rawAltLabel.AutoSize = true;
            this.rawAltLabel.Location = new System.Drawing.Point(558, 534);
            this.rawAltLabel.Name = "rawAltLabel";
            this.rawAltLabel.Size = new System.Drawing.Size(53, 16);
            this.rawAltLabel.TabIndex = 100;
            this.rawAltLabel.Text = "висота";
            // 
            // rawLonTextBox
            // 
            this.rawLonTextBox.Location = new System.Drawing.Point(481, 528);
            this.rawLonTextBox.Name = "rawLonTextBox";
            this.rawLonTextBox.Size = new System.Drawing.Size(54, 22);
            this.rawLonTextBox.TabIndex = 99;
            // 
            // rawLonLabel
            // 
            this.rawLonLabel.AutoSize = true;
            this.rawLonLabel.Location = new System.Drawing.Point(397, 534);
            this.rawLonLabel.Name = "rawLonLabel";
            this.rawLonLabel.Size = new System.Drawing.Size(60, 16);
            this.rawLonLabel.TabIndex = 98;
            this.rawLonLabel.Text = "довгота";
            // 
            // rawLatTextBox
            // 
            this.rawLatTextBox.Location = new System.Drawing.Point(325, 528);
            this.rawLatTextBox.Name = "rawLatTextBox";
            this.rawLatTextBox.Size = new System.Drawing.Size(54, 22);
            this.rawLatTextBox.TabIndex = 97;
            // 
            // rawLatLabel
            // 
            this.rawLatLabel.AutoSize = true;
            this.rawLatLabel.Location = new System.Drawing.Point(136, 534);
            this.rawLatLabel.Name = "rawLatLabel";
            this.rawLatLabel.Size = new System.Drawing.Size(159, 16);
            this.rawLatLabel.TabIndex = 96;
            this.rawLatLabel.Text = "Сирі GPS дані:    широта";
            // 
            // wayTextBox
            // 
            this.wayTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.wayTextBox.Location = new System.Drawing.Point(139, 436);
            this.wayTextBox.Name = "wayTextBox";
            this.wayTextBox.Size = new System.Drawing.Size(54, 22);
            this.wayTextBox.TabIndex = 103;
            // 
            // wayLabel
            // 
            this.wayLabel.AutoSize = true;
            this.wayLabel.Location = new System.Drawing.Point(1, 439);
            this.wayLabel.Name = "wayLabel";
            this.wayLabel.Size = new System.Drawing.Size(132, 16);
            this.wayLabel.TabIndex = 102;
            this.wayLabel.Text = "Подоланий шлях, м:";
            // 
            // gyroTextBox
            // 
            this.gyroTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gyroTextBox.Location = new System.Drawing.Point(139, 502);
            this.gyroTextBox.Name = "gyroTextBox";
            this.gyroTextBox.Size = new System.Drawing.Size(54, 22);
            this.gyroTextBox.TabIndex = 105;
            // 
            // gyroLabel
            // 
            this.gyroLabel.AutoSize = true;
            this.gyroLabel.Location = new System.Drawing.Point(31, 505);
            this.gyroLabel.Name = "gyroLabel";
            this.gyroLabel.Size = new System.Drawing.Size(93, 16);
            this.gyroLabel.TabIndex = 104;
            this.gyroLabel.Text = "Від гіроскопа";
            // 
            // accTextBox
            // 
            this.accTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.accTextBox.Location = new System.Drawing.Point(139, 475);
            this.accTextBox.Name = "accTextBox";
            this.accTextBox.Size = new System.Drawing.Size(54, 22);
            this.accTextBox.TabIndex = 107;
            // 
            // accLabel
            // 
            this.accLabel.AutoSize = true;
            this.accLabel.Location = new System.Drawing.Point(8, 478);
            this.accLabel.Name = "accLabel";
            this.accLabel.Size = new System.Drawing.Size(116, 16);
            this.accLabel.TabIndex = 106;
            this.accLabel.Text = "Від акселометра";
            // 
            // maxAccTextBox
            // 
            this.maxAccTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.maxAccTextBox.Location = new System.Drawing.Point(245, 475);
            this.maxAccTextBox.Name = "maxAccTextBox";
            this.maxAccTextBox.Size = new System.Drawing.Size(54, 22);
            this.maxAccTextBox.TabIndex = 111;
            // 
            // maxAccLabel
            // 
            this.maxAccLabel.AutoSize = true;
            this.maxAccLabel.Location = new System.Drawing.Point(199, 478);
            this.maxAccLabel.Name = "maxAccLabel";
            this.maxAccLabel.Size = new System.Drawing.Size(40, 16);
            this.maxAccLabel.TabIndex = 110;
            this.maxAccLabel.Text = "Макс";
            // 
            // maxGyroTextBox
            // 
            this.maxGyroTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.maxGyroTextBox.Location = new System.Drawing.Point(245, 502);
            this.maxGyroTextBox.Name = "maxGyroTextBox";
            this.maxGyroTextBox.Size = new System.Drawing.Size(54, 22);
            this.maxGyroTextBox.TabIndex = 109;
            // 
            // maxGyroLabel
            // 
            this.maxGyroLabel.AutoSize = true;
            this.maxGyroLabel.Location = new System.Drawing.Point(199, 505);
            this.maxGyroLabel.Name = "maxGyroLabel";
            this.maxGyroLabel.Size = new System.Drawing.Size(40, 16);
            this.maxGyroLabel.TabIndex = 108;
            this.maxGyroLabel.Text = "Макс";
            // 
            // simpleexample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 588);
            this.Controls.Add(this.maxAccTextBox);
            this.Controls.Add(this.maxAccLabel);
            this.Controls.Add(this.maxGyroTextBox);
            this.Controls.Add(this.maxGyroLabel);
            this.Controls.Add(this.accTextBox);
            this.Controls.Add(this.accLabel);
            this.Controls.Add(this.gyroTextBox);
            this.Controls.Add(this.gyroLabel);
            this.Controls.Add(this.wayTextBox);
            this.Controls.Add(this.wayLabel);
            this.Controls.Add(this.rawAltTextBox);
            this.Controls.Add(this.rawAltLabel);
            this.Controls.Add(this.rawLonTextBox);
            this.Controls.Add(this.rawLonLabel);
            this.Controls.Add(this.rawLatTextBox);
            this.Controls.Add(this.rawLatLabel);
            this.Controls.Add(this.fzmagTextBox);
            this.Controls.Add(this.fzaccTextBox);
            this.Controls.Add(this.fzgyroTextBox);
            this.Controls.Add(this.fymagTextBox);
            this.Controls.Add(this.fxmagTextBox);
            this.Controls.Add(this.fxgyroTextBox);
            this.Controls.Add(this.fyaccTextBox);
            this.Controls.Add(this.fygyroTextBox);
            this.Controls.Add(this.fxaccTextBox);
            this.Controls.Add(this.zmagTextBox);
            this.Controls.Add(this.zmagLabel);
            this.Controls.Add(this.zaccTextBox);
            this.Controls.Add(this.zgyroTextBox);
            this.Controls.Add(this.zaccLabel);
            this.Controls.Add(this.zgyroLabel);
            this.Controls.Add(this.temperatureTextBox);
            this.Controls.Add(this.temperatureLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.time_usecTextBox);
            this.Controls.Add(this.time_usecLabel);
            this.Controls.Add(this.ymagTextBox);
            this.Controls.Add(this.ymagLabel);
            this.Controls.Add(this.xmagTextBox);
            this.Controls.Add(this.xmagLabel);
            this.Controls.Add(this.xgyroTextBox);
            this.Controls.Add(this.xgyroLabel);
            this.Controls.Add(this.yaccTextBox);
            this.Controls.Add(this.ygyroTextBox);
            this.Controls.Add(this.yaccLabel);
            this.Controls.Add(this.ygyroLabel);
            this.Controls.Add(this.xaccTextBox);
            this.Controls.Add(this.xaccLabel);
            this.Controls.Add(this.orientTextBox);
            this.Controls.Add(this.orientLabel);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.dxTextBox);
            this.Controls.Add(this.dyTextBox);
            this.Controls.Add(this.dxLabel);
            this.Controls.Add(this.dyLabel);
            this.Controls.Add(this.dzTextBox);
            this.Controls.Add(this.dzLabel);
            this.Controls.Add(this.throttleTextBox);
            this.Controls.Add(this.climbTextBox);
            this.Controls.Add(this.throttleLabel);
            this.Controls.Add(this.climbLabel);
            this.Controls.Add(this.hudLabel);
            this.Controls.Add(this.altTextBox);
            this.Controls.Add(this.altLabel);
            this.Controls.Add(this.vGroundSpeedTextBox);
            this.Controls.Add(this.vAirSpeedTextBox);
            this.Controls.Add(this.vGroundLabel);
            this.Controls.Add(this.vAirLabel);
            this.Controls.Add(this.headingTextBox);
            this.Controls.Add(this.headingLabel);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.velocityLabel);
            this.Controls.Add(this.position1Label);
            this.Controls.Add(this.position0Label);
            this.Controls.Add(this.vxTextBox);
            this.Controls.Add(this.vyTextBox);
            this.Controls.Add(this.vxLabel);
            this.Controls.Add(this.vyLabel);
            this.Controls.Add(this.vzTextBox);
            this.Controls.Add(this.vzLabel);
            this.Controls.Add(this.x1TextBox);
            this.Controls.Add(this.y1TextBox);
            this.Controls.Add(this.x1Label);
            this.Controls.Add(this.y2Label);
            this.Controls.Add(this.z1TextBox);
            this.Controls.Add(this.z1Label);
            this.Controls.Add(this.x0TextBox);
            this.Controls.Add(this.y0TextBox);
            this.Controls.Add(this.x0Label);
            this.Controls.Add(this.y0Label);
            this.Controls.Add(this.z0TextBox);
            this.Controls.Add(this.z0Label);
            this.Controls.Add(this.but_mission);
            this.Controls.Add(this.but_armdisarm);
            this.Controls.Add(this.but_connect);
            this.Controls.Add(this.cmb_baudrate);
            this.Controls.Add(this.CMB_comport);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "simpleexample";
            this.Text = "Дані з польотного контролера";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

