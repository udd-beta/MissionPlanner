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
            this.x0TextBox.Location = new System.Drawing.Point(635, 62);
            this.x0TextBox.Name = "x0TextBox";
            this.x0TextBox.Size = new System.Drawing.Size(54, 22);
            this.x0TextBox.TabIndex = 11;
            // 
            // x1TextBox
            // 
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
            this.vGroundLabel.Location = new System.Drawing.Point(345, 213);
            this.vGroundLabel.Name = "vGroundLabel";
            this.vGroundLabel.Size = new System.Drawing.Size(112, 16);
            this.vGroundLabel.TabIndex = 32;
            this.vGroundLabel.Text = "Швидкість землі";
            // 
            // vAirLabel
            // 
            this.vAirLabel.AutoSize = true;
            this.vAirLabel.Location = new System.Drawing.Point(332, 253);
            this.vAirLabel.Name = "vAirLabel";
            this.vAirLabel.Size = new System.Drawing.Size(125, 16);
            this.vAirLabel.TabIndex = 31;
            this.vAirLabel.Text = "Швидкість повітря";
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
            // simpleexample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 307);
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
    }
}

