﻿namespace MouseApp2
{
    partial class FLipMouseGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLipMouseGUI));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectButton = new System.Windows.Forms.Button();
            this.saveSettings = new System.Windows.Forms.Button();
            this.dcButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.portStatus = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.LipmouseTab = new System.Windows.Forms.TabPage();
            this.incSpeedY = new System.Windows.Forms.Button();
            this.decSpeedX = new System.Windows.Forms.Button();
            this.incDeadzoneY = new System.Windows.Forms.Button();
            this.decDeadzoneX = new System.Windows.Forms.Button();
            this.DeadzoneYNameLabel = new System.Windows.Forms.Label();
            this.SpeedYNameLabel = new System.Windows.Forms.Label();
            this.speedYLabel = new System.Windows.Forms.Label();
            this.deadzoneYLabel = new System.Windows.Forms.Label();
            this.deadzoneYBar = new System.Windows.Forms.TrackBar();
            this.speedYBar = new System.Windows.Forms.TrackBar();
            this.splitXYBox = new System.Windows.Forms.CheckBox();
            this.selectAlternative = new System.Windows.Forms.RadioButton();
            this.selectStick = new System.Windows.Forms.RadioButton();
            this.deadzoneXLabel = new System.Windows.Forms.Label();
            this.DeadzoneXNameLabel = new System.Windows.Forms.Label();
            this.deadzoneXBar = new System.Windows.Forms.TrackBar();
            this.calButton = new System.Windows.Forms.Button();
            this.speedXLabel = new System.Windows.Forms.Label();
            this.speedXBar = new System.Windows.Forms.TrackBar();
            this.SpeedXNameLabel = new System.Windows.Forms.Label();
            this.AlternativeTab = new System.Windows.Forms.TabPage();
            this.clearButtonRight = new System.Windows.Forms.Button();
            this.clearButtonLeft = new System.Windows.Forms.Button();
            this.clearButtonDown = new System.Windows.Forms.Button();
            this.clearButtonUp = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.RightComboBox = new System.Windows.Forms.ComboBox();
            this.RightNumericParameter = new System.Windows.Forms.NumericUpDown();
            this.RightLabel = new System.Windows.Forms.Label();
            this.RightParameterText = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.RightFunctionMenu = new System.Windows.Forms.ComboBox();
            this.LeftComboBox = new System.Windows.Forms.ComboBox();
            this.DownComboBox = new System.Windows.Forms.ComboBox();
            this.UpComboBox = new System.Windows.Forms.ComboBox();
            this.LeftNumericParameter = new System.Windows.Forms.NumericUpDown();
            this.DownNumericParameter = new System.Windows.Forms.NumericUpDown();
            this.UpNumericParameter = new System.Windows.Forms.NumericUpDown();
            this.LeftLabel = new System.Windows.Forms.Label();
            this.LeftParameterText = new System.Windows.Forms.TextBox();
            this.DownLabel = new System.Windows.Forms.Label();
            this.DownParameterText = new System.Windows.Forms.TextBox();
            this.UpLabel = new System.Windows.Forms.Label();
            this.UpParameterText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.LeftFunctionMenu = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DownFunctionMenu = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.UpFunctionMenu = new System.Windows.Forms.ComboBox();
            this.SipPuffTab = new System.Windows.Forms.TabPage();
            this.clearButtonSpecialPuff = new System.Windows.Forms.Button();
            this.clearButtonPuff = new System.Windows.Forms.Button();
            this.clearButtonSpecialSip = new System.Windows.Forms.Button();
            this.clearButtonSip = new System.Windows.Forms.Button();
            this.incTimeThreshld = new System.Windows.Forms.Button();
            this.decTimeThreshold = new System.Windows.Forms.Button();
            this.incSipThreshold = new System.Windows.Forms.Button();
            this.decSipThreshold = new System.Windows.Forms.Button();
            this.incPuffThreshold = new System.Windows.Forms.Button();
            this.decPuffThreshold = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.specialThresholdLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.specialThresholdBar = new System.Windows.Forms.TrackBar();
            this.SpecialPuffComboBox = new System.Windows.Forms.ComboBox();
            this.SpecialPuffParameterLabel = new System.Windows.Forms.Label();
            this.SpecialPuffNumericParameter = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.SpecialPuffFunctionMenu = new System.Windows.Forms.ComboBox();
            this.SpecialSipComboBox = new System.Windows.Forms.ComboBox();
            this.SpecialSipParameterLabel = new System.Windows.Forms.Label();
            this.SpecialSipNumericParameter = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.SpecialSipFunctionMenu = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pressureLabel = new System.Windows.Forms.Label();
            this.PuffComboBox = new System.Windows.Forms.ComboBox();
            this.SipComboBox = new System.Windows.Forms.ComboBox();
            this.PuffParameterLabel = new System.Windows.Forms.Label();
            this.SipParameterLabel = new System.Windows.Forms.Label();
            this.PuffNumericParameter = new System.Windows.Forms.NumericUpDown();
            this.SipNumericParameter = new System.Windows.Forms.NumericUpDown();
            this.puffThresholdLabel = new System.Windows.Forms.Label();
            this.puffThresholdBar = new System.Windows.Forms.TrackBar();
            this.thresholdLabelForPuff = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.PuffFunctionMenu = new System.Windows.Forms.ComboBox();
            this.sipThresholdLabel = new System.Windows.Forms.Label();
            this.sipThresholdBar = new System.Windows.Forms.TrackBar();
            this.thresholdLabelForSip = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SipFunctionMenu = new System.Windows.Forms.ComboBox();
            this.SipParameterText = new System.Windows.Forms.TextBox();
            this.SpecialSipParameterText = new System.Windows.Forms.TextBox();
            this.PuffParameterText = new System.Windows.Forms.TextBox();
            this.SpecialPuffParameterText = new System.Windows.Forms.TextBox();
            this.ButtonsTab = new System.Windows.Forms.TabPage();
            this.clearButton3 = new System.Windows.Forms.Button();
            this.clearButton2 = new System.Windows.Forms.Button();
            this.clearButton1 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.Button3ComboBox = new System.Windows.Forms.ComboBox();
            this.Button2ComboBox = new System.Windows.Forms.ComboBox();
            this.Button1ComboBox = new System.Windows.Forms.ComboBox();
            this.Button3NumericParameter = new System.Windows.Forms.NumericUpDown();
            this.Button2NumericParameter = new System.Windows.Forms.NumericUpDown();
            this.Button1NumericParameter = new System.Windows.Forms.NumericUpDown();
            this.Button3Label = new System.Windows.Forms.Label();
            this.Button3ParameterText = new System.Windows.Forms.TextBox();
            this.Button2Label = new System.Windows.Forms.Label();
            this.Button2ParameterText = new System.Windows.Forms.TextBox();
            this.Button1Label = new System.Windows.Forms.Label();
            this.Button1ParameterText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Button3FunctionBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Button2FunctionBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Button1FunctionBox = new System.Windows.Forms.ComboBox();
            this.RawValueTab = new System.Windows.Forms.TabPage();
            this.incRightGain = new System.Windows.Forms.Button();
            this.decRightGain = new System.Windows.Forms.Button();
            this.rightGainLabel = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.rightGainBar = new System.Windows.Forms.TrackBar();
            this.incDownGain = new System.Windows.Forms.Button();
            this.decDownGain = new System.Windows.Forms.Button();
            this.downGainLabel = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.incLeftGain = new System.Windows.Forms.Button();
            this.decLeftGain = new System.Windows.Forms.Button();
            this.leftGainLabel = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.incUpGain = new System.Windows.Forms.Button();
            this.decUpGain = new System.Windows.Forms.Button();
            this.upGainLabel = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.downSensorLabel = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.leftSensorLabel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.rightSensorLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.upSensorLabel = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.downPanel = new System.Windows.Forms.Panel();
            this.upPanel = new System.Windows.Forms.Panel();
            this.leftGainBar = new System.Windows.Forms.TrackBar();
            this.downGainBar = new System.Windows.Forms.TrackBar();
            this.upGainBar = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.activityLogTextbox = new System.Windows.Forms.RichTextBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.slotNames = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.LipmouseTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deadzoneYBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedYBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deadzoneXBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedXBar)).BeginInit();
            this.AlternativeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RightNumericParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftNumericParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownNumericParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpNumericParameter)).BeginInit();
            this.SipPuffTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specialThresholdBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpecialPuffNumericParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpecialSipNumericParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PuffNumericParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SipNumericParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puffThresholdBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sipThresholdBar)).BeginInit();
            this.ButtonsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button3NumericParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button2NumericParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button1NumericParameter)).BeginInit();
            this.RawValueTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightGainBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftGainBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downGainBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upGainBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            // 
            // portComboBox
            // 
            this.portComboBox.Location = new System.Drawing.Point(300, 55);
            this.portComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(133, 28);
            this.portComboBox.TabIndex = 60;
            this.portComboBox.Click += new System.EventHandler(this.portComboBox_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Please connect your FLipMouse:";
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(444, 52);
            this.SelectButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(93, 35);
            this.SelectButton.TabIndex = 8;
            this.SelectButton.Text = "Connect";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.select_Click);
            // 
            // saveSettings
            // 
            this.saveSettings.Enabled = false;
            this.saveSettings.ForeColor = System.Drawing.Color.Black;
            this.saveSettings.Location = new System.Drawing.Point(234, 615);
            this.saveSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveSettings.Name = "saveSettings";
            this.saveSettings.Size = new System.Drawing.Size(168, 48);
            this.saveSettings.TabIndex = 14;
            this.saveSettings.Text = "Store Settings as:";
            this.saveSettings.UseVisualStyleBackColor = true;
            this.saveSettings.Click += new System.EventHandler(this.saveSettings_Click);
            // 
            // dcButton
            // 
            this.dcButton.Enabled = false;
            this.dcButton.ForeColor = System.Drawing.Color.Black;
            this.dcButton.Location = new System.Drawing.Point(544, 52);
            this.dcButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dcButton.Name = "dcButton";
            this.dcButton.Size = new System.Drawing.Size(105, 35);
            this.dcButton.TabIndex = 10;
            this.dcButton.Text = "Disconnect";
            this.dcButton.UseVisualStyleBackColor = true;
            this.dcButton.Click += new System.EventHandler(this.dcButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(734, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Port Status:";
            // 
            // portStatus
            // 
            this.portStatus.AutoSize = true;
            this.portStatus.ForeColor = System.Drawing.Color.SlateGray;
            this.portStatus.Location = new System.Drawing.Point(831, 60);
            this.portStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.portStatus.Name = "portStatus";
            this.portStatus.Size = new System.Drawing.Size(107, 20);
            this.portStatus.TabIndex = 12;
            this.portStatus.Text = "Disconnected";
            // 
            // ClearButton
            // 
            this.ClearButton.Enabled = false;
            this.ClearButton.ForeColor = System.Drawing.Color.Black;
            this.ClearButton.Location = new System.Drawing.Point(778, 618);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(159, 49);
            this.ClearButton.TabIndex = 46;
            this.ClearButton.Text = "Clear all Slots";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Enabled = false;
            this.ApplyButton.ForeColor = System.Drawing.Color.Black;
            this.ApplyButton.Location = new System.Drawing.Point(57, 615);
            this.ApplyButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(168, 48);
            this.ApplyButton.TabIndex = 36;
            this.ApplyButton.Text = "Apply settings";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.LipmouseTab);
            this.tabControl.Controls.Add(this.AlternativeTab);
            this.tabControl.Controls.Add(this.SipPuffTab);
            this.tabControl.Controls.Add(this.ButtonsTab);
            this.tabControl.Controls.Add(this.RawValueTab);
            this.tabControl.Location = new System.Drawing.Point(57, 118);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(886, 488);
            this.tabControl.TabIndex = 61;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // LipmouseTab
            // 
            this.LipmouseTab.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LipmouseTab.Controls.Add(this.incSpeedY);
            this.LipmouseTab.Controls.Add(this.decSpeedX);
            this.LipmouseTab.Controls.Add(this.incDeadzoneY);
            this.LipmouseTab.Controls.Add(this.decDeadzoneX);
            this.LipmouseTab.Controls.Add(this.DeadzoneYNameLabel);
            this.LipmouseTab.Controls.Add(this.SpeedYNameLabel);
            this.LipmouseTab.Controls.Add(this.speedYLabel);
            this.LipmouseTab.Controls.Add(this.deadzoneYLabel);
            this.LipmouseTab.Controls.Add(this.deadzoneYBar);
            this.LipmouseTab.Controls.Add(this.speedYBar);
            this.LipmouseTab.Controls.Add(this.splitXYBox);
            this.LipmouseTab.Controls.Add(this.selectAlternative);
            this.LipmouseTab.Controls.Add(this.selectStick);
            this.LipmouseTab.Controls.Add(this.deadzoneXLabel);
            this.LipmouseTab.Controls.Add(this.DeadzoneXNameLabel);
            this.LipmouseTab.Controls.Add(this.deadzoneXBar);
            this.LipmouseTab.Controls.Add(this.calButton);
            this.LipmouseTab.Controls.Add(this.speedXLabel);
            this.LipmouseTab.Controls.Add(this.speedXBar);
            this.LipmouseTab.Controls.Add(this.SpeedXNameLabel);
            this.LipmouseTab.Location = new System.Drawing.Point(4, 29);
            this.LipmouseTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LipmouseTab.Name = "LipmouseTab";
            this.LipmouseTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LipmouseTab.Size = new System.Drawing.Size(878, 455);
            this.LipmouseTab.TabIndex = 0;
            this.LipmouseTab.Text = "Cursor Movement";
            // 
            // incSpeedY
            // 
            this.incSpeedY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incSpeedY.ForeColor = System.Drawing.Color.Black;
            this.incSpeedY.Location = new System.Drawing.Point(772, 142);
            this.incSpeedY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.incSpeedY.Name = "incSpeedY";
            this.incSpeedY.Size = new System.Drawing.Size(46, 46);
            this.incSpeedY.TabIndex = 34;
            this.incSpeedY.Text = "+";
            this.incSpeedY.UseVisualStyleBackColor = true;
            this.incSpeedY.Click += new System.EventHandler(this.incSpeedY_Click);
            this.incSpeedY.MouseLeave += new System.EventHandler(this.stop_ClickTimer);
            this.incSpeedY.MouseHover += new System.EventHandler(this.incSpeedY_MouseHover);
            // 
            // decSpeedX
            // 
            this.decSpeedX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decSpeedX.ForeColor = System.Drawing.Color.Black;
            this.decSpeedX.Location = new System.Drawing.Point(82, 142);
            this.decSpeedX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.decSpeedX.Name = "decSpeedX";
            this.decSpeedX.Size = new System.Drawing.Size(46, 46);
            this.decSpeedX.TabIndex = 33;
            this.decSpeedX.Text = "-";
            this.decSpeedX.UseVisualStyleBackColor = true;
            this.decSpeedX.Click += new System.EventHandler(this.decSpeedX_Click);
            this.decSpeedX.MouseLeave += new System.EventHandler(this.stop_ClickTimer);
            this.decSpeedX.MouseHover += new System.EventHandler(this.decSpeedX_MouseHover);
            // 
            // incDeadzoneY
            // 
            this.incDeadzoneY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incDeadzoneY.ForeColor = System.Drawing.Color.Black;
            this.incDeadzoneY.Location = new System.Drawing.Point(774, 268);
            this.incDeadzoneY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.incDeadzoneY.Name = "incDeadzoneY";
            this.incDeadzoneY.Size = new System.Drawing.Size(46, 46);
            this.incDeadzoneY.TabIndex = 32;
            this.incDeadzoneY.Text = "+";
            this.incDeadzoneY.UseVisualStyleBackColor = true;
            this.incDeadzoneY.Click += new System.EventHandler(this.incDeadzoneY_Click);
            this.incDeadzoneY.MouseLeave += new System.EventHandler(this.stop_ClickTimer);
            this.incDeadzoneY.MouseHover += new System.EventHandler(this.incDeadzoneY_MouseHover);
            // 
            // decDeadzoneX
            // 
            this.decDeadzoneX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decDeadzoneX.ForeColor = System.Drawing.Color.Black;
            this.decDeadzoneX.Location = new System.Drawing.Point(82, 268);
            this.decDeadzoneX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.decDeadzoneX.Name = "decDeadzoneX";
            this.decDeadzoneX.Size = new System.Drawing.Size(46, 46);
            this.decDeadzoneX.TabIndex = 31;
            this.decDeadzoneX.Text = "-";
            this.decDeadzoneX.UseVisualStyleBackColor = true;
            this.decDeadzoneX.Click += new System.EventHandler(this.decDeadzoneX_Click);
            this.decDeadzoneX.MouseLeave += new System.EventHandler(this.stop_ClickTimer);
            this.decDeadzoneX.MouseHover += new System.EventHandler(this.decDeadzoneX_MouseHover);
            // 
            // DeadzoneYNameLabel
            // 
            this.DeadzoneYNameLabel.AutoSize = true;
            this.DeadzoneYNameLabel.Location = new System.Drawing.Point(456, 249);
            this.DeadzoneYNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeadzoneYNameLabel.Name = "DeadzoneYNameLabel";
            this.DeadzoneYNameLabel.Size = new System.Drawing.Size(99, 20);
            this.DeadzoneYNameLabel.TabIndex = 30;
            this.DeadzoneYNameLabel.Text = "Deadzone-Y";
            this.DeadzoneYNameLabel.Visible = false;
            // 
            // SpeedYNameLabel
            // 
            this.SpeedYNameLabel.AutoSize = true;
            this.SpeedYNameLabel.Location = new System.Drawing.Point(456, 122);
            this.SpeedYNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SpeedYNameLabel.Name = "SpeedYNameLabel";
            this.SpeedYNameLabel.Size = new System.Drawing.Size(72, 20);
            this.SpeedYNameLabel.TabIndex = 29;
            this.SpeedYNameLabel.Text = "Speed-Y";
            this.SpeedYNameLabel.Visible = false;
            // 
            // speedYLabel
            // 
            this.speedYLabel.AutoSize = true;
            this.speedYLabel.Enabled = false;
            this.speedYLabel.Location = new System.Drawing.Point(699, 128);
            this.speedYLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.speedYLabel.Name = "speedYLabel";
            this.speedYLabel.Size = new System.Drawing.Size(27, 20);
            this.speedYLabel.TabIndex = 28;
            this.speedYLabel.Text = "40";
            this.speedYLabel.Visible = false;
            // 
            // deadzoneYLabel
            // 
            this.deadzoneYLabel.AutoSize = true;
            this.deadzoneYLabel.Enabled = false;
            this.deadzoneYLabel.Location = new System.Drawing.Point(699, 239);
            this.deadzoneYLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deadzoneYLabel.Name = "deadzoneYLabel";
            this.deadzoneYLabel.Size = new System.Drawing.Size(36, 20);
            this.deadzoneYLabel.TabIndex = 27;
            this.deadzoneYLabel.Text = "100";
            this.deadzoneYLabel.Visible = false;
            // 
            // deadzoneYBar
            // 
            this.deadzoneYBar.AutoSize = false;
            this.deadzoneYBar.Enabled = false;
            this.deadzoneYBar.LargeChange = 10;
            this.deadzoneYBar.Location = new System.Drawing.Point(444, 277);
            this.deadzoneYBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deadzoneYBar.Maximum = 650;
            this.deadzoneYBar.Minimum = 1;
            this.deadzoneYBar.Name = "deadzoneYBar";
            this.deadzoneYBar.Size = new System.Drawing.Size(320, 71);
            this.deadzoneYBar.TabIndex = 26;
            this.deadzoneYBar.TickFrequency = 25;
            this.deadzoneYBar.Value = 100;
            this.deadzoneYBar.Visible = false;
            this.deadzoneYBar.Scroll += new System.EventHandler(this.deadzoneYBar_Scroll);
            // 
            // speedYBar
            // 
            this.speedYBar.AutoSize = false;
            this.speedYBar.Enabled = false;
            this.speedYBar.LargeChange = 1;
            this.speedYBar.Location = new System.Drawing.Point(444, 151);
            this.speedYBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.speedYBar.Maximum = 100;
            this.speedYBar.Minimum = 1;
            this.speedYBar.Name = "speedYBar";
            this.speedYBar.Size = new System.Drawing.Size(320, 71);
            this.speedYBar.TabIndex = 25;
            this.speedYBar.TickFrequency = 5;
            this.speedYBar.Value = 40;
            this.speedYBar.Visible = false;
            this.speedYBar.Scroll += new System.EventHandler(this.speedYBar_Scroll);
            // 
            // splitXYBox
            // 
            this.splitXYBox.AutoSize = true;
            this.splitXYBox.Location = new System.Drawing.Point(618, 374);
            this.splitXYBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitXYBox.Name = "splitXYBox";
            this.splitXYBox.Size = new System.Drawing.Size(220, 24);
            this.splitXYBox.TabIndex = 24;
            this.splitXYBox.Text = "split horizontal and vertical";
            this.splitXYBox.UseVisualStyleBackColor = true;
            this.splitXYBox.CheckedChanged += new System.EventHandler(this.splitXYBox_CheckedChanged);
            // 
            // selectAlternative
            // 
            this.selectAlternative.AutoSize = true;
            this.selectAlternative.Location = new System.Drawing.Point(482, 58);
            this.selectAlternative.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectAlternative.Name = "selectAlternative";
            this.selectAlternative.Size = new System.Drawing.Size(261, 24);
            this.selectAlternative.TabIndex = 23;
            this.selectAlternative.Text = "Use Stick for Alternative Actions";
            this.selectAlternative.UseVisualStyleBackColor = true;
            this.selectAlternative.CheckedChanged += new System.EventHandler(this.selectAlternative_CheckedChanged);
            // 
            // selectStick
            // 
            this.selectStick.AutoSize = true;
            this.selectStick.Checked = true;
            this.selectStick.Location = new System.Drawing.Point(147, 58);
            this.selectStick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectStick.Name = "selectStick";
            this.selectStick.Size = new System.Drawing.Size(254, 24);
            this.selectStick.TabIndex = 22;
            this.selectStick.TabStop = true;
            this.selectStick.Text = "Use Stick for Cursor Movement";
            this.selectStick.UseVisualStyleBackColor = true;
            this.selectStick.CheckedChanged += new System.EventHandler(this.selectStick_CheckedChanged);
            // 
            // deadzoneXLabel
            // 
            this.deadzoneXLabel.AutoSize = true;
            this.deadzoneXLabel.Location = new System.Drawing.Point(699, 238);
            this.deadzoneXLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deadzoneXLabel.Name = "deadzoneXLabel";
            this.deadzoneXLabel.Size = new System.Drawing.Size(36, 20);
            this.deadzoneXLabel.TabIndex = 21;
            this.deadzoneXLabel.Text = "100";
            // 
            // DeadzoneXNameLabel
            // 
            this.DeadzoneXNameLabel.AutoSize = true;
            this.DeadzoneXNameLabel.Location = new System.Drawing.Point(152, 249);
            this.DeadzoneXNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeadzoneXNameLabel.Name = "DeadzoneXNameLabel";
            this.DeadzoneXNameLabel.Size = new System.Drawing.Size(83, 20);
            this.DeadzoneXNameLabel.TabIndex = 20;
            this.DeadzoneXNameLabel.Text = "Deadzone";
            // 
            // deadzoneXBar
            // 
            this.deadzoneXBar.LargeChange = 10;
            this.deadzoneXBar.Location = new System.Drawing.Point(134, 277);
            this.deadzoneXBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deadzoneXBar.Maximum = 650;
            this.deadzoneXBar.Minimum = 1;
            this.deadzoneXBar.Name = "deadzoneXBar";
            this.deadzoneXBar.Size = new System.Drawing.Size(630, 69);
            this.deadzoneXBar.TabIndex = 17;
            this.deadzoneXBar.TickFrequency = 20;
            this.deadzoneXBar.Value = 100;
            this.deadzoneXBar.Scroll += new System.EventHandler(this.deadzone_Scroll);
            // 
            // calButton
            // 
            this.calButton.Enabled = false;
            this.calButton.ForeColor = System.Drawing.Color.Black;
            this.calButton.Location = new System.Drawing.Point(147, 352);
            this.calButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calButton.Name = "calButton";
            this.calButton.Size = new System.Drawing.Size(327, 74);
            this.calButton.TabIndex = 18;
            this.calButton.Text = "Calibrate Middle Position";
            this.calButton.UseVisualStyleBackColor = true;
            this.calButton.Click += new System.EventHandler(this.calibration_Click);
            // 
            // speedXLabel
            // 
            this.speedXLabel.AutoSize = true;
            this.speedXLabel.Location = new System.Drawing.Point(699, 128);
            this.speedXLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.speedXLabel.Name = "speedXLabel";
            this.speedXLabel.Size = new System.Drawing.Size(27, 20);
            this.speedXLabel.TabIndex = 16;
            this.speedXLabel.Text = "40";
            // 
            // speedXBar
            // 
            this.speedXBar.AutoSize = false;
            this.speedXBar.LargeChange = 1;
            this.speedXBar.Location = new System.Drawing.Point(134, 151);
            this.speedXBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.speedXBar.Maximum = 100;
            this.speedXBar.Minimum = 1;
            this.speedXBar.Name = "speedXBar";
            this.speedXBar.Size = new System.Drawing.Size(630, 71);
            this.speedXBar.TabIndex = 15;
            this.speedXBar.TickFrequency = 5;
            this.speedXBar.Value = 40;
            this.speedXBar.Scroll += new System.EventHandler(this.speedBar_Scroll);
            // 
            // SpeedXNameLabel
            // 
            this.SpeedXNameLabel.AutoSize = true;
            this.SpeedXNameLabel.Location = new System.Drawing.Point(156, 128);
            this.SpeedXNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SpeedXNameLabel.Name = "SpeedXNameLabel";
            this.SpeedXNameLabel.Size = new System.Drawing.Size(56, 20);
            this.SpeedXNameLabel.TabIndex = 14;
            this.SpeedXNameLabel.Text = "Speed";
            // 
            // AlternativeTab
            // 
            this.AlternativeTab.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AlternativeTab.Controls.Add(this.clearButtonRight);
            this.AlternativeTab.Controls.Add(this.clearButtonLeft);
            this.AlternativeTab.Controls.Add(this.clearButtonDown);
            this.AlternativeTab.Controls.Add(this.clearButtonUp);
            this.AlternativeTab.Controls.Add(this.label18);
            this.AlternativeTab.Controls.Add(this.RightComboBox);
            this.AlternativeTab.Controls.Add(this.RightNumericParameter);
            this.AlternativeTab.Controls.Add(this.RightLabel);
            this.AlternativeTab.Controls.Add(this.RightParameterText);
            this.AlternativeTab.Controls.Add(this.label15);
            this.AlternativeTab.Controls.Add(this.RightFunctionMenu);
            this.AlternativeTab.Controls.Add(this.LeftComboBox);
            this.AlternativeTab.Controls.Add(this.DownComboBox);
            this.AlternativeTab.Controls.Add(this.UpComboBox);
            this.AlternativeTab.Controls.Add(this.LeftNumericParameter);
            this.AlternativeTab.Controls.Add(this.DownNumericParameter);
            this.AlternativeTab.Controls.Add(this.UpNumericParameter);
            this.AlternativeTab.Controls.Add(this.LeftLabel);
            this.AlternativeTab.Controls.Add(this.LeftParameterText);
            this.AlternativeTab.Controls.Add(this.DownLabel);
            this.AlternativeTab.Controls.Add(this.DownParameterText);
            this.AlternativeTab.Controls.Add(this.UpLabel);
            this.AlternativeTab.Controls.Add(this.UpParameterText);
            this.AlternativeTab.Controls.Add(this.label11);
            this.AlternativeTab.Controls.Add(this.LeftFunctionMenu);
            this.AlternativeTab.Controls.Add(this.label12);
            this.AlternativeTab.Controls.Add(this.DownFunctionMenu);
            this.AlternativeTab.Controls.Add(this.label13);
            this.AlternativeTab.Controls.Add(this.UpFunctionMenu);
            this.AlternativeTab.Location = new System.Drawing.Point(4, 29);
            this.AlternativeTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AlternativeTab.Name = "AlternativeTab";
            this.AlternativeTab.Size = new System.Drawing.Size(878, 455);
            this.AlternativeTab.TabIndex = 3;
            this.AlternativeTab.Text = "Alternative Actions";
            // 
            // clearButtonRight
            // 
            this.clearButtonRight.Enabled = false;
            this.clearButtonRight.ForeColor = System.Drawing.Color.Black;
            this.clearButtonRight.Location = new System.Drawing.Point(600, 372);
            this.clearButtonRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearButtonRight.Name = "clearButtonRight";
            this.clearButtonRight.Size = new System.Drawing.Size(40, 35);
            this.clearButtonRight.TabIndex = 143;
            this.clearButtonRight.Text = "x";
            this.clearButtonRight.UseVisualStyleBackColor = true;
            this.clearButtonRight.Visible = false;
            this.clearButtonRight.Click += new System.EventHandler(this.clearButtonRight_Click);
            // 
            // clearButtonLeft
            // 
            this.clearButtonLeft.Enabled = false;
            this.clearButtonLeft.ForeColor = System.Drawing.Color.Black;
            this.clearButtonLeft.Location = new System.Drawing.Point(600, 289);
            this.clearButtonLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearButtonLeft.Name = "clearButtonLeft";
            this.clearButtonLeft.Size = new System.Drawing.Size(40, 35);
            this.clearButtonLeft.TabIndex = 142;
            this.clearButtonLeft.Text = "x";
            this.clearButtonLeft.UseVisualStyleBackColor = true;
            this.clearButtonLeft.Visible = false;
            this.clearButtonLeft.Click += new System.EventHandler(this.clearButtonLeft_Click);
            // 
            // clearButtonDown
            // 
            this.clearButtonDown.Enabled = false;
            this.clearButtonDown.ForeColor = System.Drawing.Color.Black;
            this.clearButtonDown.Location = new System.Drawing.Point(600, 202);
            this.clearButtonDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearButtonDown.Name = "clearButtonDown";
            this.clearButtonDown.Size = new System.Drawing.Size(40, 35);
            this.clearButtonDown.TabIndex = 141;
            this.clearButtonDown.Text = "x";
            this.clearButtonDown.UseVisualStyleBackColor = true;
            this.clearButtonDown.Visible = false;
            this.clearButtonDown.Click += new System.EventHandler(this.clearButtonDown_Click);
            // 
            // clearButtonUp
            // 
            this.clearButtonUp.Enabled = false;
            this.clearButtonUp.ForeColor = System.Drawing.Color.Black;
            this.clearButtonUp.Location = new System.Drawing.Point(600, 118);
            this.clearButtonUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearButtonUp.Name = "clearButtonUp";
            this.clearButtonUp.Size = new System.Drawing.Size(40, 35);
            this.clearButtonUp.TabIndex = 140;
            this.clearButtonUp.Text = "x";
            this.clearButtonUp.UseVisualStyleBackColor = true;
            this.clearButtonUp.Visible = false;
            this.clearButtonUp.Click += new System.EventHandler(this.clearButtonUp_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(213, 31);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(439, 20);
            this.label18.TabIndex = 139;
            this.label18.Text = "Select actions for stick-movements in the following directions:";
            // 
            // RightComboBox
            // 
            this.RightComboBox.FormattingEnabled = true;
            this.RightComboBox.Location = new System.Drawing.Point(600, 338);
            this.RightComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RightComboBox.Name = "RightComboBox";
            this.RightComboBox.Size = new System.Drawing.Size(181, 28);
            this.RightComboBox.TabIndex = 138;
            this.RightComboBox.Visible = false;
            this.RightComboBox.SelectedIndexChanged += new System.EventHandler(this.RightComboBox_SelectedIndexChanged);
            // 
            // RightNumericParameter
            // 
            this.RightNumericParameter.Location = new System.Drawing.Point(243, 375);
            this.RightNumericParameter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RightNumericParameter.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.RightNumericParameter.Name = "RightNumericParameter";
            this.RightNumericParameter.Size = new System.Drawing.Size(68, 26);
            this.RightNumericParameter.TabIndex = 137;
            this.RightNumericParameter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RightNumericParameter.Visible = false;
            // 
            // RightLabel
            // 
            this.RightLabel.AutoSize = true;
            this.RightLabel.Location = new System.Drawing.Point(136, 378);
            this.RightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RightLabel.Name = "RightLabel";
            this.RightLabel.Size = new System.Drawing.Size(87, 20);
            this.RightLabel.TabIndex = 136;
            this.RightLabel.Text = "Parameter:";
            // 
            // RightParameterText
            // 
            this.RightParameterText.Location = new System.Drawing.Point(243, 375);
            this.RightParameterText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RightParameterText.Name = "RightParameterText";
            this.RightParameterText.ReadOnly = true;
            this.RightParameterText.Size = new System.Drawing.Size(349, 26);
            this.RightParameterText.TabIndex = 135;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(99, 342);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 20);
            this.label15.TabIndex = 134;
            this.label15.Text = "Action for Right:";
            // 
            // RightFunctionMenu
            // 
            this.RightFunctionMenu.FormattingEnabled = true;
            this.RightFunctionMenu.Location = new System.Drawing.Point(243, 338);
            this.RightFunctionMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RightFunctionMenu.Name = "RightFunctionMenu";
            this.RightFunctionMenu.Size = new System.Drawing.Size(349, 28);
            this.RightFunctionMenu.TabIndex = 133;
            this.RightFunctionMenu.SelectedIndexChanged += new System.EventHandler(this.RightFunctionMenu_SelectedIndexChanged);
            // 
            // LeftComboBox
            // 
            this.LeftComboBox.FormattingEnabled = true;
            this.LeftComboBox.Location = new System.Drawing.Point(600, 255);
            this.LeftComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LeftComboBox.Name = "LeftComboBox";
            this.LeftComboBox.Size = new System.Drawing.Size(181, 28);
            this.LeftComboBox.TabIndex = 132;
            this.LeftComboBox.Visible = false;
            this.LeftComboBox.SelectedIndexChanged += new System.EventHandler(this.LeftComboBox_SelectedIndexChanged);
            // 
            // DownComboBox
            // 
            this.DownComboBox.FormattingEnabled = true;
            this.DownComboBox.Location = new System.Drawing.Point(600, 168);
            this.DownComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DownComboBox.Name = "DownComboBox";
            this.DownComboBox.Size = new System.Drawing.Size(181, 28);
            this.DownComboBox.TabIndex = 131;
            this.DownComboBox.Visible = false;
            this.DownComboBox.SelectedIndexChanged += new System.EventHandler(this.DownComboBox_SelectedIndexChanged);
            // 
            // UpComboBox
            // 
            this.UpComboBox.FormattingEnabled = true;
            this.UpComboBox.Location = new System.Drawing.Point(600, 82);
            this.UpComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpComboBox.Name = "UpComboBox";
            this.UpComboBox.Size = new System.Drawing.Size(181, 28);
            this.UpComboBox.TabIndex = 130;
            this.UpComboBox.Visible = false;
            this.UpComboBox.SelectedIndexChanged += new System.EventHandler(this.UpComboBox_SelectedIndexChanged);
            // 
            // LeftNumericParameter
            // 
            this.LeftNumericParameter.Location = new System.Drawing.Point(243, 292);
            this.LeftNumericParameter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LeftNumericParameter.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.LeftNumericParameter.Name = "LeftNumericParameter";
            this.LeftNumericParameter.Size = new System.Drawing.Size(68, 26);
            this.LeftNumericParameter.TabIndex = 129;
            this.LeftNumericParameter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LeftNumericParameter.Visible = false;
            // 
            // DownNumericParameter
            // 
            this.DownNumericParameter.Location = new System.Drawing.Point(243, 205);
            this.DownNumericParameter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DownNumericParameter.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.DownNumericParameter.Name = "DownNumericParameter";
            this.DownNumericParameter.Size = new System.Drawing.Size(68, 26);
            this.DownNumericParameter.TabIndex = 128;
            this.DownNumericParameter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DownNumericParameter.Visible = false;
            // 
            // UpNumericParameter
            // 
            this.UpNumericParameter.Location = new System.Drawing.Point(243, 118);
            this.UpNumericParameter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpNumericParameter.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.UpNumericParameter.Name = "UpNumericParameter";
            this.UpNumericParameter.Size = new System.Drawing.Size(68, 26);
            this.UpNumericParameter.TabIndex = 127;
            this.UpNumericParameter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpNumericParameter.Visible = false;
            // 
            // LeftLabel
            // 
            this.LeftLabel.AutoSize = true;
            this.LeftLabel.Location = new System.Drawing.Point(136, 294);
            this.LeftLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LeftLabel.Name = "LeftLabel";
            this.LeftLabel.Size = new System.Drawing.Size(87, 20);
            this.LeftLabel.TabIndex = 126;
            this.LeftLabel.Text = "Parameter:";
            // 
            // LeftParameterText
            // 
            this.LeftParameterText.Location = new System.Drawing.Point(243, 292);
            this.LeftParameterText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LeftParameterText.Name = "LeftParameterText";
            this.LeftParameterText.ReadOnly = true;
            this.LeftParameterText.Size = new System.Drawing.Size(349, 26);
            this.LeftParameterText.TabIndex = 125;
            // 
            // DownLabel
            // 
            this.DownLabel.AutoSize = true;
            this.DownLabel.Location = new System.Drawing.Point(136, 206);
            this.DownLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DownLabel.Name = "DownLabel";
            this.DownLabel.Size = new System.Drawing.Size(87, 20);
            this.DownLabel.TabIndex = 124;
            this.DownLabel.Text = "Parameter:";
            // 
            // DownParameterText
            // 
            this.DownParameterText.Location = new System.Drawing.Point(243, 205);
            this.DownParameterText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DownParameterText.Name = "DownParameterText";
            this.DownParameterText.ReadOnly = true;
            this.DownParameterText.Size = new System.Drawing.Size(349, 26);
            this.DownParameterText.TabIndex = 123;
            // 
            // UpLabel
            // 
            this.UpLabel.AutoSize = true;
            this.UpLabel.Location = new System.Drawing.Point(136, 122);
            this.UpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpLabel.Name = "UpLabel";
            this.UpLabel.Size = new System.Drawing.Size(87, 20);
            this.UpLabel.TabIndex = 122;
            this.UpLabel.Text = "Parameter:";
            this.UpLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // UpParameterText
            // 
            this.UpParameterText.Location = new System.Drawing.Point(243, 118);
            this.UpParameterText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpParameterText.Name = "UpParameterText";
            this.UpParameterText.ReadOnly = true;
            this.UpParameterText.Size = new System.Drawing.Size(349, 26);
            this.UpParameterText.TabIndex = 121;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(110, 258);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 20);
            this.label11.TabIndex = 120;
            this.label11.Text = "Action for Left:";
            // 
            // LeftFunctionMenu
            // 
            this.LeftFunctionMenu.FormattingEnabled = true;
            this.LeftFunctionMenu.Location = new System.Drawing.Point(243, 255);
            this.LeftFunctionMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LeftFunctionMenu.Name = "LeftFunctionMenu";
            this.LeftFunctionMenu.Size = new System.Drawing.Size(349, 28);
            this.LeftFunctionMenu.TabIndex = 119;
            this.LeftFunctionMenu.SelectedIndexChanged += new System.EventHandler(this.LeftFunctionMenu_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(96, 171);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 20);
            this.label12.TabIndex = 118;
            this.label12.Text = "Action for Down:";
            // 
            // DownFunctionMenu
            // 
            this.DownFunctionMenu.FormattingEnabled = true;
            this.DownFunctionMenu.Location = new System.Drawing.Point(243, 168);
            this.DownFunctionMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DownFunctionMenu.Name = "DownFunctionMenu";
            this.DownFunctionMenu.Size = new System.Drawing.Size(349, 28);
            this.DownFunctionMenu.TabIndex = 117;
            this.DownFunctionMenu.SelectedIndexChanged += new System.EventHandler(this.DownFunctionMenu_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(117, 86);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 20);
            this.label13.TabIndex = 116;
            this.label13.Text = "Action for Up:";
            // 
            // UpFunctionMenu
            // 
            this.UpFunctionMenu.FormattingEnabled = true;
            this.UpFunctionMenu.Location = new System.Drawing.Point(243, 82);
            this.UpFunctionMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpFunctionMenu.Name = "UpFunctionMenu";
            this.UpFunctionMenu.Size = new System.Drawing.Size(349, 28);
            this.UpFunctionMenu.TabIndex = 115;
            this.UpFunctionMenu.SelectedIndexChanged += new System.EventHandler(this.UpFunctionMenu_SelectedIndexChanged);
            // 
            // SipPuffTab
            // 
            this.SipPuffTab.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SipPuffTab.Controls.Add(this.clearButtonSpecialPuff);
            this.SipPuffTab.Controls.Add(this.clearButtonPuff);
            this.SipPuffTab.Controls.Add(this.clearButtonSpecialSip);
            this.SipPuffTab.Controls.Add(this.clearButtonSip);
            this.SipPuffTab.Controls.Add(this.incTimeThreshld);
            this.SipPuffTab.Controls.Add(this.decTimeThreshold);
            this.SipPuffTab.Controls.Add(this.incSipThreshold);
            this.SipPuffTab.Controls.Add(this.decSipThreshold);
            this.SipPuffTab.Controls.Add(this.incPuffThreshold);
            this.SipPuffTab.Controls.Add(this.decPuffThreshold);
            this.SipPuffTab.Controls.Add(this.label4);
            this.SipPuffTab.Controls.Add(this.specialThresholdLabel);
            this.SipPuffTab.Controls.Add(this.label16);
            this.SipPuffTab.Controls.Add(this.specialThresholdBar);
            this.SipPuffTab.Controls.Add(this.SpecialPuffComboBox);
            this.SipPuffTab.Controls.Add(this.SpecialPuffParameterLabel);
            this.SipPuffTab.Controls.Add(this.SpecialPuffNumericParameter);
            this.SipPuffTab.Controls.Add(this.label14);
            this.SipPuffTab.Controls.Add(this.SpecialPuffFunctionMenu);
            this.SipPuffTab.Controls.Add(this.SpecialSipComboBox);
            this.SipPuffTab.Controls.Add(this.SpecialSipParameterLabel);
            this.SipPuffTab.Controls.Add(this.SpecialSipNumericParameter);
            this.SipPuffTab.Controls.Add(this.label9);
            this.SipPuffTab.Controls.Add(this.SpecialSipFunctionMenu);
            this.SipPuffTab.Controls.Add(this.panel1);
            this.SipPuffTab.Controls.Add(this.pressureLabel);
            this.SipPuffTab.Controls.Add(this.PuffComboBox);
            this.SipPuffTab.Controls.Add(this.SipComboBox);
            this.SipPuffTab.Controls.Add(this.PuffParameterLabel);
            this.SipPuffTab.Controls.Add(this.SipParameterLabel);
            this.SipPuffTab.Controls.Add(this.PuffNumericParameter);
            this.SipPuffTab.Controls.Add(this.SipNumericParameter);
            this.SipPuffTab.Controls.Add(this.puffThresholdLabel);
            this.SipPuffTab.Controls.Add(this.puffThresholdBar);
            this.SipPuffTab.Controls.Add(this.thresholdLabelForPuff);
            this.SipPuffTab.Controls.Add(this.label20);
            this.SipPuffTab.Controls.Add(this.PuffFunctionMenu);
            this.SipPuffTab.Controls.Add(this.sipThresholdLabel);
            this.SipPuffTab.Controls.Add(this.sipThresholdBar);
            this.SipPuffTab.Controls.Add(this.thresholdLabelForSip);
            this.SipPuffTab.Controls.Add(this.label5);
            this.SipPuffTab.Controls.Add(this.SipFunctionMenu);
            this.SipPuffTab.Controls.Add(this.SipParameterText);
            this.SipPuffTab.Controls.Add(this.SpecialSipParameterText);
            this.SipPuffTab.Controls.Add(this.PuffParameterText);
            this.SipPuffTab.Controls.Add(this.SpecialPuffParameterText);
            this.SipPuffTab.Location = new System.Drawing.Point(4, 29);
            this.SipPuffTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SipPuffTab.Name = "SipPuffTab";
            this.SipPuffTab.Size = new System.Drawing.Size(878, 455);
            this.SipPuffTab.TabIndex = 2;
            this.SipPuffTab.Text = "Sip/Puff Actions";
            // 
            // clearButtonSpecialPuff
            // 
            this.clearButtonSpecialPuff.Enabled = false;
            this.clearButtonSpecialPuff.ForeColor = System.Drawing.Color.Black;
            this.clearButtonSpecialPuff.Location = new System.Drawing.Point(496, 372);
            this.clearButtonSpecialPuff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearButtonSpecialPuff.Name = "clearButtonSpecialPuff";
            this.clearButtonSpecialPuff.Size = new System.Drawing.Size(40, 35);
            this.clearButtonSpecialPuff.TabIndex = 116;
            this.clearButtonSpecialPuff.Text = "x";
            this.clearButtonSpecialPuff.UseVisualStyleBackColor = true;
            this.clearButtonSpecialPuff.Visible = false;
            this.clearButtonSpecialPuff.Click += new System.EventHandler(this.clearButtonSpecialPuff_Click);
            // 
            // clearButtonPuff
            // 
            this.clearButtonPuff.Enabled = false;
            this.clearButtonPuff.ForeColor = System.Drawing.Color.Black;
            this.clearButtonPuff.Location = new System.Drawing.Point(495, 289);
            this.clearButtonPuff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearButtonPuff.Name = "clearButtonPuff";
            this.clearButtonPuff.Size = new System.Drawing.Size(40, 35);
            this.clearButtonPuff.TabIndex = 115;
            this.clearButtonPuff.Text = "x";
            this.clearButtonPuff.UseVisualStyleBackColor = true;
            this.clearButtonPuff.Visible = false;
            this.clearButtonPuff.Click += new System.EventHandler(this.clearButtonPuff_Click);
            // 
            // clearButtonSpecialSip
            // 
            this.clearButtonSpecialSip.Enabled = false;
            this.clearButtonSpecialSip.ForeColor = System.Drawing.Color.Black;
            this.clearButtonSpecialSip.Location = new System.Drawing.Point(496, 181);
            this.clearButtonSpecialSip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearButtonSpecialSip.Name = "clearButtonSpecialSip";
            this.clearButtonSpecialSip.Size = new System.Drawing.Size(40, 35);
            this.clearButtonSpecialSip.TabIndex = 114;
            this.clearButtonSpecialSip.Text = "x";
            this.clearButtonSpecialSip.UseVisualStyleBackColor = true;
            this.clearButtonSpecialSip.Visible = false;
            this.clearButtonSpecialSip.Click += new System.EventHandler(this.clearButtonSpecialSip_Click);
            // 
            // clearButtonSip
            // 
            this.clearButtonSip.Enabled = false;
            this.clearButtonSip.ForeColor = System.Drawing.Color.Black;
            this.clearButtonSip.Location = new System.Drawing.Point(495, 96);
            this.clearButtonSip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearButtonSip.Name = "clearButtonSip";
            this.clearButtonSip.Size = new System.Drawing.Size(40, 35);
            this.clearButtonSip.TabIndex = 113;
            this.clearButtonSip.Text = "x";
            this.clearButtonSip.UseVisualStyleBackColor = true;
            this.clearButtonSip.Visible = false;
            this.clearButtonSip.Click += new System.EventHandler(this.clearButtonSip_Click);
            // 
            // incTimeThreshld
            // 
            this.incTimeThreshld.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incTimeThreshld.ForeColor = System.Drawing.Color.Black;
            this.incTimeThreshld.Location = new System.Drawing.Point(814, 365);
            this.incTimeThreshld.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.incTimeThreshld.Name = "incTimeThreshld";
            this.incTimeThreshld.Size = new System.Drawing.Size(46, 46);
            this.incTimeThreshld.TabIndex = 112;
            this.incTimeThreshld.Text = "+";
            this.incTimeThreshld.UseVisualStyleBackColor = true;
            this.incTimeThreshld.Click += new System.EventHandler(this.incSpecialThreshold_Click);
            this.incTimeThreshld.MouseLeave += new System.EventHandler(this.stop_ClickTimer);
            this.incTimeThreshld.MouseHover += new System.EventHandler(this.incSpecialThreshold_MouseHover);
            // 
            // decTimeThreshold
            // 
            this.decTimeThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decTimeThreshold.ForeColor = System.Drawing.Color.Black;
            this.decTimeThreshold.Location = new System.Drawing.Point(582, 365);
            this.decTimeThreshold.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.decTimeThreshold.Name = "decTimeThreshold";
            this.decTimeThreshold.Size = new System.Drawing.Size(46, 46);
            this.decTimeThreshold.TabIndex = 111;
            this.decTimeThreshold.Text = "-";
            this.decTimeThreshold.UseVisualStyleBackColor = true;
            this.decTimeThreshold.Click += new System.EventHandler(this.decSpecialThreshold_Click);
            this.decTimeThreshold.MouseLeave += new System.EventHandler(this.stop_ClickTimer);
            this.decTimeThreshold.MouseHover += new System.EventHandler(this.decSpecialThreshold_MouseHover);
            // 
            // incSipThreshold
            // 
            this.incSipThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incSipThreshold.ForeColor = System.Drawing.Color.Black;
            this.incSipThreshold.Location = new System.Drawing.Point(582, 195);
            this.incSipThreshold.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.incSipThreshold.Name = "incSipThreshold";
            this.incSipThreshold.Size = new System.Drawing.Size(46, 46);
            this.incSipThreshold.TabIndex = 110;
            this.incSipThreshold.Text = "+";
            this.incSipThreshold.UseVisualStyleBackColor = true;
            this.incSipThreshold.Click += new System.EventHandler(this.incSipThreshold_Click);
            this.incSipThreshold.MouseLeave += new System.EventHandler(this.stop_ClickTimer);
            this.incSipThreshold.MouseHover += new System.EventHandler(this.incSipThreshold_MouseHover);
            // 
            // decSipThreshold
            // 
            this.decSipThreshold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decSipThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decSipThreshold.ForeColor = System.Drawing.Color.Black;
            this.decSipThreshold.Location = new System.Drawing.Point(582, 248);
            this.decSipThreshold.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.decSipThreshold.Name = "decSipThreshold";
            this.decSipThreshold.Size = new System.Drawing.Size(46, 46);
            this.decSipThreshold.TabIndex = 109;
            this.decSipThreshold.Text = "-";
            this.decSipThreshold.UseVisualStyleBackColor = true;
            this.decSipThreshold.Click += new System.EventHandler(this.decSipThreshold_Click);
            this.decSipThreshold.MouseLeave += new System.EventHandler(this.stop_ClickTimer);
            this.decSipThreshold.MouseHover += new System.EventHandler(this.decSipThreshold_MouseHover);
            // 
            // incPuffThreshold
            // 
            this.incPuffThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incPuffThreshold.ForeColor = System.Drawing.Color.Black;
            this.incPuffThreshold.Location = new System.Drawing.Point(814, 88);
            this.incPuffThreshold.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.incPuffThreshold.Name = "incPuffThreshold";
            this.incPuffThreshold.Size = new System.Drawing.Size(46, 46);
            this.incPuffThreshold.TabIndex = 108;
            this.incPuffThreshold.Text = "+";
            this.incPuffThreshold.UseVisualStyleBackColor = true;
            this.incPuffThreshold.Click += new System.EventHandler(this.incPuffThreshold_Click);
            this.incPuffThreshold.MouseLeave += new System.EventHandler(this.stop_ClickTimer);
            this.incPuffThreshold.MouseHover += new System.EventHandler(this.incPuffThreshold_MouseHover);
            // 
            // decPuffThreshold
            // 
            this.decPuffThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decPuffThreshold.ForeColor = System.Drawing.Color.Black;
            this.decPuffThreshold.Location = new System.Drawing.Point(814, 138);
            this.decPuffThreshold.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.decPuffThreshold.Name = "decPuffThreshold";
            this.decPuffThreshold.Size = new System.Drawing.Size(46, 46);
            this.decPuffThreshold.TabIndex = 107;
            this.decPuffThreshold.Text = "-";
            this.decPuffThreshold.UseVisualStyleBackColor = true;
            this.decPuffThreshold.Click += new System.EventHandler(this.decPuffThreshold_Click);
            this.decPuffThreshold.MouseLeave += new System.EventHandler(this.stop_ClickTimer);
            this.decPuffThreshold.MouseHover += new System.EventHandler(this.decPuffThreshold_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(680, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 106;
            this.label4.Text = "Pressure";
            // 
            // specialThresholdLabel
            // 
            this.specialThresholdLabel.AutoSize = true;
            this.specialThresholdLabel.Location = new System.Drawing.Point(770, 338);
            this.specialThresholdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.specialThresholdLabel.Name = "specialThresholdLabel";
            this.specialThresholdLabel.Size = new System.Drawing.Size(75, 20);
            this.specialThresholdLabel.TabIndex = 105;
            this.specialThresholdLabel.Text = "600 / 424";
            this.specialThresholdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(583, 337);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(183, 20);
            this.label16.TabIndex = 104;
            this.label16.Text = "Special / Hold Activation:";
            // 
            // specialThresholdBar
            // 
            this.specialThresholdBar.LargeChange = 10;
            this.specialThresholdBar.Location = new System.Drawing.Point(636, 372);
            this.specialThresholdBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.specialThresholdBar.Maximum = 1023;
            this.specialThresholdBar.Minimum = 512;
            this.specialThresholdBar.Name = "specialThresholdBar";
            this.specialThresholdBar.Size = new System.Drawing.Size(170, 69);
            this.specialThresholdBar.TabIndex = 103;
            this.specialThresholdBar.TickFrequency = 40;
            this.specialThresholdBar.Value = 600;
            this.specialThresholdBar.Scroll += new System.EventHandler(this.specialThresholdBar_Scroll);
            // 
            // SpecialPuffComboBox
            // 
            this.SpecialPuffComboBox.FormattingEnabled = true;
            this.SpecialPuffComboBox.Location = new System.Drawing.Point(338, 375);
            this.SpecialPuffComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SpecialPuffComboBox.Name = "SpecialPuffComboBox";
            this.SpecialPuffComboBox.Size = new System.Drawing.Size(152, 28);
            this.SpecialPuffComboBox.TabIndex = 102;
            this.SpecialPuffComboBox.Visible = false;
            this.SpecialPuffComboBox.SelectedIndexChanged += new System.EventHandler(this.SpecialPuffComboBox_SelectedIndexChanged);
            // 
            // SpecialPuffParameterLabel
            // 
            this.SpecialPuffParameterLabel.AutoSize = true;
            this.SpecialPuffParameterLabel.Location = new System.Drawing.Point(39, 378);
            this.SpecialPuffParameterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SpecialPuffParameterLabel.Name = "SpecialPuffParameterLabel";
            this.SpecialPuffParameterLabel.Size = new System.Drawing.Size(83, 20);
            this.SpecialPuffParameterLabel.TabIndex = 100;
            this.SpecialPuffParameterLabel.Text = "Parameter";
            // 
            // SpecialPuffNumericParameter
            // 
            this.SpecialPuffNumericParameter.Location = new System.Drawing.Point(146, 375);
            this.SpecialPuffNumericParameter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SpecialPuffNumericParameter.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.SpecialPuffNumericParameter.Name = "SpecialPuffNumericParameter";
            this.SpecialPuffNumericParameter.Size = new System.Drawing.Size(64, 26);
            this.SpecialPuffNumericParameter.TabIndex = 99;
            this.SpecialPuffNumericParameter.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 340);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 20);
            this.label14.TabIndex = 98;
            this.label14.Text = "Special Puff";
            // 
            // SpecialPuffFunctionMenu
            // 
            this.SpecialPuffFunctionMenu.FormattingEnabled = true;
            this.SpecialPuffFunctionMenu.Location = new System.Drawing.Point(140, 335);
            this.SpecialPuffFunctionMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SpecialPuffFunctionMenu.Name = "SpecialPuffFunctionMenu";
            this.SpecialPuffFunctionMenu.Size = new System.Drawing.Size(350, 28);
            this.SpecialPuffFunctionMenu.TabIndex = 97;
            this.SpecialPuffFunctionMenu.SelectedIndexChanged += new System.EventHandler(this.SpecialPuffFunctionMenu_SelectedIndexChanged);
            // 
            // SpecialSipComboBox
            // 
            this.SpecialSipComboBox.FormattingEnabled = true;
            this.SpecialSipComboBox.Location = new System.Drawing.Point(338, 184);
            this.SpecialSipComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SpecialSipComboBox.Name = "SpecialSipComboBox";
            this.SpecialSipComboBox.Size = new System.Drawing.Size(152, 28);
            this.SpecialSipComboBox.TabIndex = 96;
            this.SpecialSipComboBox.Visible = false;
            this.SpecialSipComboBox.SelectedIndexChanged += new System.EventHandler(this.SpecialSipComboBox_SelectedIndexChanged);
            // 
            // SpecialSipParameterLabel
            // 
            this.SpecialSipParameterLabel.AutoSize = true;
            this.SpecialSipParameterLabel.Location = new System.Drawing.Point(40, 190);
            this.SpecialSipParameterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SpecialSipParameterLabel.Name = "SpecialSipParameterLabel";
            this.SpecialSipParameterLabel.Size = new System.Drawing.Size(83, 20);
            this.SpecialSipParameterLabel.TabIndex = 94;
            this.SpecialSipParameterLabel.Text = "Parameter";
            // 
            // SpecialSipNumericParameter
            // 
            this.SpecialSipNumericParameter.Location = new System.Drawing.Point(146, 187);
            this.SpecialSipNumericParameter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SpecialSipNumericParameter.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.SpecialSipNumericParameter.Name = "SpecialSipNumericParameter";
            this.SpecialSipNumericParameter.Size = new System.Drawing.Size(64, 26);
            this.SpecialSipNumericParameter.TabIndex = 93;
            this.SpecialSipNumericParameter.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 147);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 20);
            this.label9.TabIndex = 92;
            this.label9.Text = "Special Sip";
            // 
            // SpecialSipFunctionMenu
            // 
            this.SpecialSipFunctionMenu.FormattingEnabled = true;
            this.SpecialSipFunctionMenu.Location = new System.Drawing.Point(142, 144);
            this.SpecialSipFunctionMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SpecialSipFunctionMenu.Name = "SpecialSipFunctionMenu";
            this.SpecialSipFunctionMenu.Size = new System.Drawing.Size(348, 28);
            this.SpecialSipFunctionMenu.TabIndex = 91;
            this.SpecialSipFunctionMenu.SelectedIndexChanged += new System.EventHandler(this.SpecialSipFunctionMenu_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(688, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(44, 222);
            this.panel1.TabIndex = 90;
            // 
            // pressureLabel
            // 
            this.pressureLabel.AutoSize = true;
            this.pressureLabel.Location = new System.Drawing.Point(692, 51);
            this.pressureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(18, 20);
            this.pressureLabel.TabIndex = 81;
            this.pressureLabel.Text = "0";
            this.pressureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PuffComboBox
            // 
            this.PuffComboBox.FormattingEnabled = true;
            this.PuffComboBox.Location = new System.Drawing.Point(338, 290);
            this.PuffComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PuffComboBox.Name = "PuffComboBox";
            this.PuffComboBox.Size = new System.Drawing.Size(152, 28);
            this.PuffComboBox.TabIndex = 89;
            this.PuffComboBox.Visible = false;
            this.PuffComboBox.SelectedIndexChanged += new System.EventHandler(this.PuffComboBox_SelectedIndexChanged);
            // 
            // SipComboBox
            // 
            this.SipComboBox.FormattingEnabled = true;
            this.SipComboBox.Location = new System.Drawing.Point(338, 99);
            this.SipComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SipComboBox.Name = "SipComboBox";
            this.SipComboBox.Size = new System.Drawing.Size(152, 28);
            this.SipComboBox.TabIndex = 87;
            this.SipComboBox.Visible = false;
            this.SipComboBox.SelectedIndexChanged += new System.EventHandler(this.SipComboBox_SelectedIndexChanged);
            // 
            // PuffParameterLabel
            // 
            this.PuffParameterLabel.AutoSize = true;
            this.PuffParameterLabel.Location = new System.Drawing.Point(39, 293);
            this.PuffParameterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PuffParameterLabel.Name = "PuffParameterLabel";
            this.PuffParameterLabel.Size = new System.Drawing.Size(83, 20);
            this.PuffParameterLabel.TabIndex = 85;
            this.PuffParameterLabel.Text = "Parameter";
            // 
            // SipParameterLabel
            // 
            this.SipParameterLabel.AutoSize = true;
            this.SipParameterLabel.Location = new System.Drawing.Point(40, 103);
            this.SipParameterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SipParameterLabel.Name = "SipParameterLabel";
            this.SipParameterLabel.Size = new System.Drawing.Size(83, 20);
            this.SipParameterLabel.TabIndex = 84;
            this.SipParameterLabel.Text = "Parameter";
            // 
            // PuffNumericParameter
            // 
            this.PuffNumericParameter.Location = new System.Drawing.Point(146, 290);
            this.PuffNumericParameter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PuffNumericParameter.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.PuffNumericParameter.Name = "PuffNumericParameter";
            this.PuffNumericParameter.Size = new System.Drawing.Size(64, 26);
            this.PuffNumericParameter.TabIndex = 83;
            this.PuffNumericParameter.Visible = false;
            // 
            // SipNumericParameter
            // 
            this.SipNumericParameter.Location = new System.Drawing.Point(147, 101);
            this.SipNumericParameter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SipNumericParameter.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.SipNumericParameter.Name = "SipNumericParameter";
            this.SipNumericParameter.Size = new System.Drawing.Size(64, 26);
            this.SipNumericParameter.TabIndex = 82;
            this.SipNumericParameter.Visible = false;
            // 
            // puffThresholdLabel
            // 
            this.puffThresholdLabel.AutoSize = true;
            this.puffThresholdLabel.Location = new System.Drawing.Point(766, 208);
            this.puffThresholdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.puffThresholdLabel.Name = "puffThresholdLabel";
            this.puffThresholdLabel.Size = new System.Drawing.Size(36, 20);
            this.puffThresholdLabel.TabIndex = 80;
            this.puffThresholdLabel.Text = "525";
            // 
            // puffThresholdBar
            // 
            this.puffThresholdBar.AllowDrop = true;
            this.puffThresholdBar.LargeChange = 20;
            this.puffThresholdBar.Location = new System.Drawing.Point(734, 78);
            this.puffThresholdBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.puffThresholdBar.Maximum = 1023;
            this.puffThresholdBar.Minimum = 512;
            this.puffThresholdBar.Name = "puffThresholdBar";
            this.puffThresholdBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.puffThresholdBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.puffThresholdBar.RightToLeftLayout = true;
            this.puffThresholdBar.Size = new System.Drawing.Size(69, 122);
            this.puffThresholdBar.TabIndex = 79;
            this.puffThresholdBar.TickFrequency = 100;
            this.puffThresholdBar.Value = 525;
            this.puffThresholdBar.Scroll += new System.EventHandler(this.puffThresholdBar_Scroll);
            // 
            // thresholdLabelForPuff
            // 
            this.thresholdLabelForPuff.AutoSize = true;
            this.thresholdLabelForPuff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thresholdLabelForPuff.Location = new System.Drawing.Point(748, 231);
            this.thresholdLabelForPuff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.thresholdLabelForPuff.Name = "thresholdLabelForPuff";
            this.thresholdLabelForPuff.Size = new System.Drawing.Size(79, 20);
            this.thresholdLabelForPuff.TabIndex = 78;
            this.thresholdLabelForPuff.Text = "Puff Level";
            this.thresholdLabelForPuff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(16, 257);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(104, 20);
            this.label20.TabIndex = 77;
            this.label20.Text = "Puff Function";
            // 
            // PuffFunctionMenu
            // 
            this.PuffFunctionMenu.FormattingEnabled = true;
            this.PuffFunctionMenu.Location = new System.Drawing.Point(140, 250);
            this.PuffFunctionMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PuffFunctionMenu.Name = "PuffFunctionMenu";
            this.PuffFunctionMenu.Size = new System.Drawing.Size(350, 28);
            this.PuffFunctionMenu.TabIndex = 76;
            this.PuffFunctionMenu.SelectedIndexChanged += new System.EventHandler(this.PuffFunctionMenu_SelectedIndexChanged);
            // 
            // sipThresholdLabel
            // 
            this.sipThresholdLabel.AutoSize = true;
            this.sipThresholdLabel.Location = new System.Drawing.Point(636, 158);
            this.sipThresholdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sipThresholdLabel.Name = "sipThresholdLabel";
            this.sipThresholdLabel.Size = new System.Drawing.Size(36, 20);
            this.sipThresholdLabel.TabIndex = 75;
            this.sipThresholdLabel.Text = "500";
            // 
            // sipThresholdBar
            // 
            this.sipThresholdBar.LargeChange = 20;
            this.sipThresholdBar.Location = new System.Drawing.Point(636, 178);
            this.sipThresholdBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sipThresholdBar.Maximum = 512;
            this.sipThresholdBar.Name = "sipThresholdBar";
            this.sipThresholdBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.sipThresholdBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sipThresholdBar.Size = new System.Drawing.Size(69, 132);
            this.sipThresholdBar.TabIndex = 74;
            this.sipThresholdBar.TickFrequency = 100;
            this.sipThresholdBar.Value = 500;
            this.sipThresholdBar.Scroll += new System.EventHandler(this.sipThresholdBar_Scroll);
            // 
            // thresholdLabelForSip
            // 
            this.thresholdLabelForSip.AutoSize = true;
            this.thresholdLabelForSip.Location = new System.Drawing.Point(602, 132);
            this.thresholdLabelForSip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.thresholdLabelForSip.Name = "thresholdLabelForSip";
            this.thresholdLabelForSip.Size = new System.Drawing.Size(73, 20);
            this.thresholdLabelForSip.TabIndex = 73;
            this.thresholdLabelForSip.Text = "Sip Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 72;
            this.label5.Text = "Sip Function";
            // 
            // SipFunctionMenu
            // 
            this.SipFunctionMenu.FormattingEnabled = true;
            this.SipFunctionMenu.Location = new System.Drawing.Point(146, 58);
            this.SipFunctionMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SipFunctionMenu.Name = "SipFunctionMenu";
            this.SipFunctionMenu.Size = new System.Drawing.Size(346, 28);
            this.SipFunctionMenu.TabIndex = 71;
            this.SipFunctionMenu.SelectedIndexChanged += new System.EventHandler(this.SipFunctionMenu_SelectedIndexChanged);
            // 
            // SipParameterText
            // 
            this.SipParameterText.Location = new System.Drawing.Point(142, 99);
            this.SipParameterText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SipParameterText.Name = "SipParameterText";
            this.SipParameterText.ReadOnly = true;
            this.SipParameterText.Size = new System.Drawing.Size(193, 26);
            this.SipParameterText.TabIndex = 86;
            this.SipParameterText.Visible = false;
            // 
            // SpecialSipParameterText
            // 
            this.SpecialSipParameterText.Location = new System.Drawing.Point(142, 185);
            this.SpecialSipParameterText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SpecialSipParameterText.Name = "SpecialSipParameterText";
            this.SpecialSipParameterText.ReadOnly = true;
            this.SpecialSipParameterText.Size = new System.Drawing.Size(194, 26);
            this.SpecialSipParameterText.TabIndex = 95;
            this.SpecialSipParameterText.Visible = false;
            // 
            // PuffParameterText
            // 
            this.PuffParameterText.Location = new System.Drawing.Point(140, 290);
            this.PuffParameterText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PuffParameterText.Name = "PuffParameterText";
            this.PuffParameterText.ReadOnly = true;
            this.PuffParameterText.Size = new System.Drawing.Size(196, 26);
            this.PuffParameterText.TabIndex = 88;
            this.PuffParameterText.Visible = false;
            // 
            // SpecialPuffParameterText
            // 
            this.SpecialPuffParameterText.Location = new System.Drawing.Point(140, 375);
            this.SpecialPuffParameterText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SpecialPuffParameterText.Name = "SpecialPuffParameterText";
            this.SpecialPuffParameterText.ReadOnly = true;
            this.SpecialPuffParameterText.Size = new System.Drawing.Size(196, 26);
            this.SpecialPuffParameterText.TabIndex = 101;
            this.SpecialPuffParameterText.Visible = false;
            // 
            // ButtonsTab
            // 
            this.ButtonsTab.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonsTab.Controls.Add(this.clearButton3);
            this.ButtonsTab.Controls.Add(this.clearButton2);
            this.ButtonsTab.Controls.Add(this.clearButton1);
            this.ButtonsTab.Controls.Add(this.label21);
            this.ButtonsTab.Controls.Add(this.Button3ComboBox);
            this.ButtonsTab.Controls.Add(this.Button2ComboBox);
            this.ButtonsTab.Controls.Add(this.Button1ComboBox);
            this.ButtonsTab.Controls.Add(this.Button3NumericParameter);
            this.ButtonsTab.Controls.Add(this.Button2NumericParameter);
            this.ButtonsTab.Controls.Add(this.Button1NumericParameter);
            this.ButtonsTab.Controls.Add(this.Button3Label);
            this.ButtonsTab.Controls.Add(this.Button3ParameterText);
            this.ButtonsTab.Controls.Add(this.Button2Label);
            this.ButtonsTab.Controls.Add(this.Button2ParameterText);
            this.ButtonsTab.Controls.Add(this.Button1Label);
            this.ButtonsTab.Controls.Add(this.Button1ParameterText);
            this.ButtonsTab.Controls.Add(this.label8);
            this.ButtonsTab.Controls.Add(this.Button3FunctionBox);
            this.ButtonsTab.Controls.Add(this.label7);
            this.ButtonsTab.Controls.Add(this.Button2FunctionBox);
            this.ButtonsTab.Controls.Add(this.label6);
            this.ButtonsTab.Controls.Add(this.Button1FunctionBox);
            this.ButtonsTab.Location = new System.Drawing.Point(4, 29);
            this.ButtonsTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonsTab.Name = "ButtonsTab";
            this.ButtonsTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonsTab.Size = new System.Drawing.Size(878, 455);
            this.ButtonsTab.TabIndex = 1;
            this.ButtonsTab.Text = "Button Actions";
            // 
            // clearButton3
            // 
            this.clearButton3.Enabled = false;
            this.clearButton3.ForeColor = System.Drawing.Color.Black;
            this.clearButton3.Location = new System.Drawing.Point(650, 343);
            this.clearButton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearButton3.Name = "clearButton3";
            this.clearButton3.Size = new System.Drawing.Size(40, 35);
            this.clearButton3.TabIndex = 142;
            this.clearButton3.Text = "x";
            this.clearButton3.UseVisualStyleBackColor = true;
            this.clearButton3.Visible = false;
            this.clearButton3.Click += new System.EventHandler(this.clearButton3_Click);
            // 
            // clearButton2
            // 
            this.clearButton2.Enabled = false;
            this.clearButton2.ForeColor = System.Drawing.Color.Black;
            this.clearButton2.Location = new System.Drawing.Point(650, 242);
            this.clearButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearButton2.Name = "clearButton2";
            this.clearButton2.Size = new System.Drawing.Size(40, 35);
            this.clearButton2.TabIndex = 141;
            this.clearButton2.Text = "x";
            this.clearButton2.UseVisualStyleBackColor = true;
            this.clearButton2.Visible = false;
            this.clearButton2.Click += new System.EventHandler(this.clearButton2_Click);
            // 
            // clearButton1
            // 
            this.clearButton1.Enabled = false;
            this.clearButton1.ForeColor = System.Drawing.Color.Black;
            this.clearButton1.Location = new System.Drawing.Point(650, 143);
            this.clearButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearButton1.Name = "clearButton1";
            this.clearButton1.Size = new System.Drawing.Size(40, 35);
            this.clearButton1.TabIndex = 78;
            this.clearButton1.Text = "x";
            this.clearButton1.UseVisualStyleBackColor = true;
            this.clearButton1.Visible = false;
            this.clearButton1.Click += new System.EventHandler(this.clearButton1_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(261, 42);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(332, 20);
            this.label21.TabIndex = 140;
            this.label21.Text = "Select actions for (built-in or external) buttons:";
            // 
            // Button3ComboBox
            // 
            this.Button3ComboBox.FormattingEnabled = true;
            this.Button3ComboBox.Location = new System.Drawing.Point(650, 309);
            this.Button3ComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button3ComboBox.Name = "Button3ComboBox";
            this.Button3ComboBox.Size = new System.Drawing.Size(160, 28);
            this.Button3ComboBox.TabIndex = 114;
            this.Button3ComboBox.Visible = false;
            this.Button3ComboBox.SelectedIndexChanged += new System.EventHandler(this.Button3ComboBox_SelectedIndexChanged);
            // 
            // Button2ComboBox
            // 
            this.Button2ComboBox.FormattingEnabled = true;
            this.Button2ComboBox.Location = new System.Drawing.Point(650, 208);
            this.Button2ComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button2ComboBox.Name = "Button2ComboBox";
            this.Button2ComboBox.Size = new System.Drawing.Size(160, 28);
            this.Button2ComboBox.TabIndex = 113;
            this.Button2ComboBox.Visible = false;
            this.Button2ComboBox.SelectedIndexChanged += new System.EventHandler(this.Button2ComboBox_SelectedIndexChanged);
            // 
            // Button1ComboBox
            // 
            this.Button1ComboBox.FormattingEnabled = true;
            this.Button1ComboBox.Location = new System.Drawing.Point(650, 108);
            this.Button1ComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button1ComboBox.Name = "Button1ComboBox";
            this.Button1ComboBox.Size = new System.Drawing.Size(160, 28);
            this.Button1ComboBox.TabIndex = 112;
            this.Button1ComboBox.Visible = false;
            this.Button1ComboBox.SelectedIndexChanged += new System.EventHandler(this.Button1ComboBox_SelectedIndexChanged);
            // 
            // Button3NumericParameter
            // 
            this.Button3NumericParameter.Location = new System.Drawing.Point(272, 348);
            this.Button3NumericParameter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button3NumericParameter.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Button3NumericParameter.Name = "Button3NumericParameter";
            this.Button3NumericParameter.Size = new System.Drawing.Size(68, 26);
            this.Button3NumericParameter.TabIndex = 109;
            this.Button3NumericParameter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Button3NumericParameter.Visible = false;
            // 
            // Button2NumericParameter
            // 
            this.Button2NumericParameter.Location = new System.Drawing.Point(272, 246);
            this.Button2NumericParameter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button2NumericParameter.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Button2NumericParameter.Name = "Button2NumericParameter";
            this.Button2NumericParameter.Size = new System.Drawing.Size(68, 26);
            this.Button2NumericParameter.TabIndex = 108;
            this.Button2NumericParameter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Button2NumericParameter.Visible = false;
            // 
            // Button1NumericParameter
            // 
            this.Button1NumericParameter.Location = new System.Drawing.Point(272, 148);
            this.Button1NumericParameter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button1NumericParameter.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Button1NumericParameter.Name = "Button1NumericParameter";
            this.Button1NumericParameter.Size = new System.Drawing.Size(68, 26);
            this.Button1NumericParameter.TabIndex = 107;
            this.Button1NumericParameter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Button1NumericParameter.Visible = false;
            // 
            // Button3Label
            // 
            this.Button3Label.AutoSize = true;
            this.Button3Label.Location = new System.Drawing.Point(177, 349);
            this.Button3Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Button3Label.Name = "Button3Label";
            this.Button3Label.Size = new System.Drawing.Size(87, 20);
            this.Button3Label.TabIndex = 102;
            this.Button3Label.Text = "Parameter:";
            // 
            // Button3ParameterText
            // 
            this.Button3ParameterText.Location = new System.Drawing.Point(272, 346);
            this.Button3ParameterText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button3ParameterText.Name = "Button3ParameterText";
            this.Button3ParameterText.ReadOnly = true;
            this.Button3ParameterText.Size = new System.Drawing.Size(370, 26);
            this.Button3ParameterText.TabIndex = 101;
            // 
            // Button2Label
            // 
            this.Button2Label.AutoSize = true;
            this.Button2Label.Location = new System.Drawing.Point(177, 249);
            this.Button2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Button2Label.Name = "Button2Label";
            this.Button2Label.Size = new System.Drawing.Size(87, 20);
            this.Button2Label.TabIndex = 100;
            this.Button2Label.Text = "Parameter:";
            // 
            // Button2ParameterText
            // 
            this.Button2ParameterText.Location = new System.Drawing.Point(272, 246);
            this.Button2ParameterText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button2ParameterText.Name = "Button2ParameterText";
            this.Button2ParameterText.ReadOnly = true;
            this.Button2ParameterText.Size = new System.Drawing.Size(370, 26);
            this.Button2ParameterText.TabIndex = 99;
            // 
            // Button1Label
            // 
            this.Button1Label.AutoSize = true;
            this.Button1Label.Location = new System.Drawing.Point(177, 151);
            this.Button1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Button1Label.Name = "Button1Label";
            this.Button1Label.Size = new System.Drawing.Size(87, 20);
            this.Button1Label.TabIndex = 98;
            this.Button1Label.Text = "Parameter:";
            this.Button1Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Button1ParameterText
            // 
            this.Button1ParameterText.Location = new System.Drawing.Point(272, 148);
            this.Button1ParameterText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button1ParameterText.Name = "Button1ParameterText";
            this.Button1ParameterText.ReadOnly = true;
            this.Button1ParameterText.Size = new System.Drawing.Size(370, 26);
            this.Button1ParameterText.TabIndex = 97;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 313);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 20);
            this.label8.TabIndex = 92;
            this.label8.Text = "Button3 (Special Right):";
            // 
            // Button3FunctionBox
            // 
            this.Button3FunctionBox.FormattingEnabled = true;
            this.Button3FunctionBox.Location = new System.Drawing.Point(272, 309);
            this.Button3FunctionBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button3FunctionBox.Name = "Button3FunctionBox";
            this.Button3FunctionBox.Size = new System.Drawing.Size(370, 28);
            this.Button3FunctionBox.TabIndex = 91;
            this.Button3FunctionBox.SelectedIndexChanged += new System.EventHandler(this.Button3FunctionBox_SelectedIndexChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 212);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 20);
            this.label7.TabIndex = 90;
            this.label7.Text = "Button2 (Special Left):";
            // 
            // Button2FunctionBox
            // 
            this.Button2FunctionBox.FormattingEnabled = true;
            this.Button2FunctionBox.Location = new System.Drawing.Point(272, 208);
            this.Button2FunctionBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button2FunctionBox.Name = "Button2FunctionBox";
            this.Button2FunctionBox.Size = new System.Drawing.Size(370, 28);
            this.Button2FunctionBox.TabIndex = 89;
            this.Button2FunctionBox.SelectedIndexChanged += new System.EventHandler(this.Button2FunctionBox_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 20);
            this.label6.TabIndex = 88;
            this.label6.Text = " Button1 (Special  Up):";
            // 
            // Button1FunctionBox
            // 
            this.Button1FunctionBox.FormattingEnabled = true;
            this.Button1FunctionBox.Location = new System.Drawing.Point(272, 108);
            this.Button1FunctionBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button1FunctionBox.Name = "Button1FunctionBox";
            this.Button1FunctionBox.Size = new System.Drawing.Size(370, 28);
            this.Button1FunctionBox.TabIndex = 87;
            this.Button1FunctionBox.SelectedIndexChanged += new System.EventHandler(this.Button1FunctionBox_SelectedIndexChanged_1);
            // 
            // RawValueTab
            // 
            this.RawValueTab.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RawValueTab.Controls.Add(this.incRightGain);
            this.RawValueTab.Controls.Add(this.decRightGain);
            this.RawValueTab.Controls.Add(this.rightGainLabel);
            this.RawValueTab.Controls.Add(this.label28);
            this.RawValueTab.Controls.Add(this.rightGainBar);
            this.RawValueTab.Controls.Add(this.incDownGain);
            this.RawValueTab.Controls.Add(this.decDownGain);
            this.RawValueTab.Controls.Add(this.downGainLabel);
            this.RawValueTab.Controls.Add(this.label25);
            this.RawValueTab.Controls.Add(this.incLeftGain);
            this.RawValueTab.Controls.Add(this.decLeftGain);
            this.RawValueTab.Controls.Add(this.leftGainLabel);
            this.RawValueTab.Controls.Add(this.label26);
            this.RawValueTab.Controls.Add(this.incUpGain);
            this.RawValueTab.Controls.Add(this.decUpGain);
            this.RawValueTab.Controls.Add(this.upGainLabel);
            this.RawValueTab.Controls.Add(this.label23);
            this.RawValueTab.Controls.Add(this.label22);
            this.RawValueTab.Controls.Add(this.downSensorLabel);
            this.RawValueTab.Controls.Add(this.label19);
            this.RawValueTab.Controls.Add(this.leftSensorLabel);
            this.RawValueTab.Controls.Add(this.label17);
            this.RawValueTab.Controls.Add(this.rightSensorLabel);
            this.RawValueTab.Controls.Add(this.label10);
            this.RawValueTab.Controls.Add(this.upSensorLabel);
            this.RawValueTab.Controls.Add(this.rightPanel);
            this.RawValueTab.Controls.Add(this.leftPanel);
            this.RawValueTab.Controls.Add(this.downPanel);
            this.RawValueTab.Controls.Add(this.upPanel);
            this.RawValueTab.Controls.Add(this.leftGainBar);
            this.RawValueTab.Controls.Add(this.downGainBar);
            this.RawValueTab.Controls.Add(this.upGainBar);
            this.RawValueTab.Location = new System.Drawing.Point(4, 29);
            this.RawValueTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RawValueTab.Name = "RawValueTab";
            this.RawValueTab.Size = new System.Drawing.Size(878, 455);
            this.RawValueTab.TabIndex = 4;
            this.RawValueTab.Text = "Force Sensor Values";
            // 
            // incRightGain
            // 
            this.incRightGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incRightGain.ForeColor = System.Drawing.Color.Black;
            this.incRightGain.Location = new System.Drawing.Point(537, 315);
            this.incRightGain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.incRightGain.Name = "incRightGain";
            this.incRightGain.Size = new System.Drawing.Size(46, 46);
            this.incRightGain.TabIndex = 136;
            this.incRightGain.Text = "+";
            this.incRightGain.UseVisualStyleBackColor = true;
            this.incRightGain.Click += new System.EventHandler(this.incRightGain_Click);
            this.incRightGain.MouseLeave += new System.EventHandler(this.stop_ClickTimer);
            this.incRightGain.MouseHover += new System.EventHandler(this.incRightGain_MouseHover);
            // 
            // decRightGain
            // 
            this.decRightGain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decRightGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decRightGain.ForeColor = System.Drawing.Color.Black;
            this.decRightGain.Location = new System.Drawing.Point(483, 315);
            this.decRightGain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.decRightGain.Name = "decRightGain";
            this.decRightGain.Size = new System.Drawing.Size(46, 46);
            this.decRightGain.TabIndex = 135;
            this.decRightGain.Text = "-";
            this.decRightGain.UseVisualStyleBackColor = true;
            this.decRightGain.Click += new System.EventHandler(this.decRightGain_Click);
            this.decRightGain.MouseLeave += new System.EventHandler(this.stop_ClickTimer);
            this.decRightGain.MouseHover += new System.EventHandler(this.decRightGain_MouseHover);
            // 
            // rightGainLabel
            // 
            this.rightGainLabel.AutoSize = true;
            this.rightGainLabel.Location = new System.Drawing.Point(602, 343);
            this.rightGainLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rightGainLabel.Name = "rightGainLabel";
            this.rightGainLabel.Size = new System.Drawing.Size(27, 20);
            this.rightGainLabel.TabIndex = 134;
            this.rightGainLabel.Text = "50";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(598, 318);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(74, 20);
            this.label28.TabIndex = 132;
            this.label28.Text = "right gain";
            // 
            // rightGainBar
            // 
            this.rightGainBar.LargeChange = 10;
            this.rightGainBar.Location = new System.Drawing.Point(470, 262);
            this.rightGainBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rightGainBar.Maximum = 100;
            this.rightGainBar.Name = "rightGainBar";
            this.rightGainBar.Size = new System.Drawing.Size(132, 69);
            this.rightGainBar.TabIndex = 133;
            this.rightGainBar.TickFrequency = 10;
            this.rightGainBar.Value = 50;
            this.rightGainBar.Scroll += new System.EventHandler(this.rightGainBar_Scroll);
            // 
            // incDownGain
            // 
            this.incDownGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incDownGain.ForeColor = System.Drawing.Color.Black;
            this.incDownGain.Location = new System.Drawing.Point(290, 340);
            this.incDownGain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.incDownGain.Name = "incDownGain";
            this.incDownGain.Size = new System.Drawing.Size(46, 46);
            this.incDownGain.TabIndex = 131;
            this.incDownGain.Text = "+";
            this.incDownGain.UseVisualStyleBackColor = true;
            this.incDownGain.Click += new System.EventHandler(this.incDownGain_Click);
            this.incDownGain.MouseLeave += new System.EventHandler(this.stop_ClickTimer);
            this.incDownGain.MouseHover += new System.EventHandler(this.incDownGain_MouseHover);
            // 
            // decDownGain
            // 
            this.decDownGain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decDownGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decDownGain.ForeColor = System.Drawing.Color.Black;
            this.decDownGain.Location = new System.Drawing.Point(290, 285);
            this.decDownGain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.decDownGain.Name = "decDownGain";
            this.decDownGain.Size = new System.Drawing.Size(46, 46);
            this.decDownGain.TabIndex = 130;
            this.decDownGain.Text = "-";
            this.decDownGain.UseVisualStyleBackColor = true;
            this.decDownGain.Click += new System.EventHandler(this.decDownGain_Click);
            this.decDownGain.MouseLeave += new System.EventHandler(this.stop_ClickTimer);
            this.decDownGain.MouseHover += new System.EventHandler(this.decDownGain_MouseHover);
            // 
            // downGainLabel
            // 
            this.downGainLabel.AutoSize = true;
            this.downGainLabel.Location = new System.Drawing.Point(236, 332);
            this.downGainLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.downGainLabel.Name = "downGainLabel";
            this.downGainLabel.Size = new System.Drawing.Size(27, 20);
            this.downGainLabel.TabIndex = 129;
            this.downGainLabel.Text = "50";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(194, 312);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(81, 20);
            this.label25.TabIndex = 127;
            this.label25.Text = "down gain";
            // 
            // incLeftGain
            // 
            this.incLeftGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLeftGain.ForeColor = System.Drawing.Color.Black;
            this.incLeftGain.Location = new System.Drawing.Point(266, 102);
            this.incLeftGain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.incLeftGain.Name = "incLeftGain";
            this.incLeftGain.Size = new System.Drawing.Size(46, 46);
            this.incLeftGain.TabIndex = 126;
            this.incLeftGain.Text = "+";
            this.incLeftGain.UseVisualStyleBackColor = true;
            this.incLeftGain.Click += new System.EventHandler(this.incLeftGain_Click);
            this.incLeftGain.MouseLeave += new System.EventHandler(this.stop_ClickTimer);
            this.incLeftGain.MouseHover += new System.EventHandler(this.incLeftGain_MouseHover);
            // 
            // decLeftGain
            // 
            this.decLeftGain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decLeftGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decLeftGain.ForeColor = System.Drawing.Color.Black;
            this.decLeftGain.Location = new System.Drawing.Point(324, 102);
            this.decLeftGain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.decLeftGain.Name = "decLeftGain";
            this.decLeftGain.Size = new System.Drawing.Size(46, 46);
            this.decLeftGain.TabIndex = 125;
            this.decLeftGain.Text = "-";
            this.decLeftGain.UseVisualStyleBackColor = true;
            this.decLeftGain.Click += new System.EventHandler(this.decLeftGain_Click);
            this.decLeftGain.MouseLeave += new System.EventHandler(this.stop_ClickTimer);
            this.decLeftGain.MouseHover += new System.EventHandler(this.decLeftGain_MouseHover);
            // 
            // leftGainLabel
            // 
            this.leftGainLabel.AutoSize = true;
            this.leftGainLabel.Location = new System.Drawing.Point(222, 125);
            this.leftGainLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.leftGainLabel.Name = "leftGainLabel";
            this.leftGainLabel.Size = new System.Drawing.Size(27, 20);
            this.leftGainLabel.TabIndex = 124;
            this.leftGainLabel.Text = "50";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(194, 102);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(65, 20);
            this.label26.TabIndex = 122;
            this.label26.Text = "left gain";
            // 
            // incUpGain
            // 
            this.incUpGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incUpGain.ForeColor = System.Drawing.Color.Black;
            this.incUpGain.Location = new System.Drawing.Point(518, 69);
            this.incUpGain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.incUpGain.Name = "incUpGain";
            this.incUpGain.Size = new System.Drawing.Size(46, 46);
            this.incUpGain.TabIndex = 121;
            this.incUpGain.Text = "+";
            this.incUpGain.UseVisualStyleBackColor = true;
            this.incUpGain.Click += new System.EventHandler(this.incUpGain_Click);
            this.incUpGain.MouseLeave += new System.EventHandler(this.stop_ClickTimer);
            this.incUpGain.MouseHover += new System.EventHandler(this.incUpGain_MouseHover);
            // 
            // decUpGain
            // 
            this.decUpGain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decUpGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decUpGain.ForeColor = System.Drawing.Color.Black;
            this.decUpGain.Location = new System.Drawing.Point(518, 125);
            this.decUpGain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.decUpGain.Name = "decUpGain";
            this.decUpGain.Size = new System.Drawing.Size(46, 46);
            this.decUpGain.TabIndex = 120;
            this.decUpGain.Text = "-";
            this.decUpGain.UseVisualStyleBackColor = true;
            this.decUpGain.Click += new System.EventHandler(this.decUpGain_Click);
            this.decUpGain.MouseLeave += new System.EventHandler(this.stop_ClickTimer);
            this.decUpGain.MouseHover += new System.EventHandler(this.decUpGain_MouseHover);
            // 
            // upGainLabel
            // 
            this.upGainLabel.AutoSize = true;
            this.upGainLabel.Location = new System.Drawing.Point(573, 129);
            this.upGainLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.upGainLabel.Name = "upGainLabel";
            this.upGainLabel.Size = new System.Drawing.Size(27, 20);
            this.upGainLabel.TabIndex = 119;
            this.upGainLabel.Text = "50";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(572, 108);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(61, 20);
            this.label23.TabIndex = 117;
            this.label23.Text = "up gain";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(294, 418);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(105, 20);
            this.label22.TabIndex = 114;
            this.label22.Text = "Down Sensor";
            // 
            // downSensorLabel
            // 
            this.downSensorLabel.AutoSize = true;
            this.downSensorLabel.Location = new System.Drawing.Point(404, 418);
            this.downSensorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.downSensorLabel.Name = "downSensorLabel";
            this.downSensorLabel.Size = new System.Drawing.Size(18, 20);
            this.downSensorLabel.TabIndex = 113;
            this.downSensorLabel.Text = "0";
            this.downSensorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(135, 203);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 20);
            this.label19.TabIndex = 112;
            this.label19.Text = "Left Sensor";
            // 
            // leftSensorLabel
            // 
            this.leftSensorLabel.AutoSize = true;
            this.leftSensorLabel.Location = new System.Drawing.Point(182, 229);
            this.leftSensorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.leftSensorLabel.Name = "leftSensorLabel";
            this.leftSensorLabel.Size = new System.Drawing.Size(18, 20);
            this.leftSensorLabel.TabIndex = 111;
            this.leftSensorLabel.Text = "0";
            this.leftSensorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(632, 203);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 20);
            this.label17.TabIndex = 110;
            this.label17.Text = "Right Sensor";
            // 
            // rightSensorLabel
            // 
            this.rightSensorLabel.AutoSize = true;
            this.rightSensorLabel.Location = new System.Drawing.Point(638, 229);
            this.rightSensorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rightSensorLabel.Name = "rightSensorLabel";
            this.rightSensorLabel.Size = new System.Drawing.Size(18, 20);
            this.rightSensorLabel.TabIndex = 109;
            this.rightSensorLabel.Text = "0";
            this.rightSensorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(315, 22);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 108;
            this.label10.Text = "Up Sensor";
            // 
            // upSensorLabel
            // 
            this.upSensorLabel.AutoSize = true;
            this.upSensorLabel.Location = new System.Drawing.Point(404, 22);
            this.upSensorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.upSensorLabel.Name = "upSensorLabel";
            this.upSensorLabel.Size = new System.Drawing.Size(18, 20);
            this.upSensorLabel.TabIndex = 107;
            this.upSensorLabel.Text = "0";
            this.upSensorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightPanel
            // 
            this.rightPanel.Location = new System.Drawing.Point(454, 205);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(160, 49);
            this.rightPanel.TabIndex = 94;
            // 
            // leftPanel
            // 
            this.leftPanel.Location = new System.Drawing.Point(240, 205);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(160, 49);
            this.leftPanel.TabIndex = 93;
            // 
            // downPanel
            // 
            this.downPanel.Location = new System.Drawing.Point(400, 255);
            this.downPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.downPanel.Name = "downPanel";
            this.downPanel.Size = new System.Drawing.Size(50, 160);
            this.downPanel.TabIndex = 92;
            // 
            // upPanel
            // 
            this.upPanel.Location = new System.Drawing.Point(402, 43);
            this.upPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.upPanel.Name = "upPanel";
            this.upPanel.Size = new System.Drawing.Size(50, 160);
            this.upPanel.TabIndex = 91;
            // 
            // leftGainBar
            // 
            this.leftGainBar.LargeChange = 10;
            this.leftGainBar.Location = new System.Drawing.Point(254, 158);
            this.leftGainBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.leftGainBar.Maximum = 100;
            this.leftGainBar.Name = "leftGainBar";
            this.leftGainBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.leftGainBar.Size = new System.Drawing.Size(132, 69);
            this.leftGainBar.TabIndex = 123;
            this.leftGainBar.TickFrequency = 10;
            this.leftGainBar.Value = 50;
            this.leftGainBar.Scroll += new System.EventHandler(this.leftGainBar_Scroll);
            // 
            // downGainBar
            // 
            this.downGainBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.downGainBar.LargeChange = 10;
            this.downGainBar.Location = new System.Drawing.Point(350, 268);
            this.downGainBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.downGainBar.Maximum = 100;
            this.downGainBar.Name = "downGainBar";
            this.downGainBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.downGainBar.Size = new System.Drawing.Size(69, 132);
            this.downGainBar.TabIndex = 128;
            this.downGainBar.TickFrequency = 10;
            this.downGainBar.Value = 50;
            this.downGainBar.Scroll += new System.EventHandler(this.downGainBar_Scroll);
            // 
            // upGainBar
            // 
            this.upGainBar.LargeChange = 10;
            this.upGainBar.Location = new System.Drawing.Point(435, 57);
            this.upGainBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.upGainBar.Maximum = 100;
            this.upGainBar.Name = "upGainBar";
            this.upGainBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.upGainBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.upGainBar.RightToLeftLayout = true;
            this.upGainBar.Size = new System.Drawing.Size(69, 132);
            this.upGainBar.TabIndex = 118;
            this.upGainBar.TickFrequency = 10;
            this.upGainBar.Value = 50;
            this.upGainBar.Scroll += new System.EventHandler(this.upGainBar_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.activityLogTextbox);
            this.groupBox1.Location = new System.Drawing.Point(60, 702);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(880, 194);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Activity-Log";
            // 
            // activityLogTextbox
            // 
            this.activityLogTextbox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.activityLogTextbox.HideSelection = false;
            this.activityLogTextbox.Location = new System.Drawing.Point(32, 31);
            this.activityLogTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.activityLogTextbox.Name = "activityLogTextbox";
            this.activityLogTextbox.ReadOnly = true;
            this.activityLogTextbox.Size = new System.Drawing.Size(816, 135);
            this.activityLogTextbox.TabIndex = 63;
            this.activityLogTextbox.Text = "";
            // 
            // LoadButton
            // 
            this.LoadButton.Enabled = false;
            this.LoadButton.ForeColor = System.Drawing.Color.Black;
            this.LoadButton.Location = new System.Drawing.Point(608, 618);
            this.LoadButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(162, 49);
            this.LoadButton.TabIndex = 75;
            this.LoadButton.Text = "Load Slot";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.load_Click);
            // 
            // slotNames
            // 
            this.slotNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slotNames.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.slotNames.Location = new System.Drawing.Point(414, 622);
            this.slotNames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.slotNames.Name = "slotNames";
            this.slotNames.Size = new System.Drawing.Size(182, 33);
            this.slotNames.TabIndex = 76;
            this.slotNames.Text = "<choose>";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(993, 33);
            this.menuStrip1.TabIndex = 77;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToFileMenuItem,
            this.loadFromFileMenuItem,
            this.exitMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(50, 29);
            this.fileMenu.Text = "File";
            // 
            // saveToFileMenuItem
            // 
            this.saveToFileMenuItem.Name = "saveToFileMenuItem";
            this.saveToFileMenuItem.Size = new System.Drawing.Size(404, 30);
            this.saveToFileMenuItem.Text = "Transfer Settings from FlipMouse to File";
            this.saveToFileMenuItem.Click += new System.EventHandler(this.saveToFileMenuItem_Click);
            // 
            // loadFromFileMenuItem
            // 
            this.loadFromFileMenuItem.Name = "loadFromFileMenuItem";
            this.loadFromFileMenuItem.Size = new System.Drawing.Size(404, 30);
            this.loadFromFileMenuItem.Text = "Transfer Settings from File to FLipMouse";
            this.loadFromFileMenuItem.Click += new System.EventHandler(this.loadFromFileMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(404, 30);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // FLipMouseGUI
            // 
            this.AccessibleDescription = "FlipMouseGUI";
            this.AccessibleName = "FlipMouseGUI";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(993, 934);
            this.Controls.Add(this.slotNames);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portStatus);
            this.Controls.Add(this.saveSettings);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.dcButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.portComboBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FLipMouseGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FLipMouseGUI Settings Manager";
            this.Load += new System.EventHandler(this.LipmouseGUI_Load);
            this.tabControl.ResumeLayout(false);
            this.LipmouseTab.ResumeLayout(false);
            this.LipmouseTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deadzoneYBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedYBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deadzoneXBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedXBar)).EndInit();
            this.AlternativeTab.ResumeLayout(false);
            this.AlternativeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RightNumericParameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftNumericParameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownNumericParameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpNumericParameter)).EndInit();
            this.SipPuffTab.ResumeLayout(false);
            this.SipPuffTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specialThresholdBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpecialPuffNumericParameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpecialSipNumericParameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PuffNumericParameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SipNumericParameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puffThresholdBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sipThresholdBar)).EndInit();
            this.ButtonsTab.ResumeLayout(false);
            this.ButtonsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button3NumericParameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button2NumericParameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button1NumericParameter)).EndInit();
            this.RawValueTab.ResumeLayout(false);
            this.RawValueTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightGainBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftGainBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downGainBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upGainBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Button dcButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label portStatus;
        private System.Windows.Forms.Button saveSettings;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage LipmouseTab;
        private System.Windows.Forms.TabPage ButtonsTab;
        private System.Windows.Forms.Label deadzoneXLabel;
        private System.Windows.Forms.Label DeadzoneXNameLabel;
        private System.Windows.Forms.TrackBar deadzoneXBar;
        private System.Windows.Forms.Button calButton;
        private System.Windows.Forms.Label speedXLabel;
        private System.Windows.Forms.TrackBar speedXBar;
        private System.Windows.Forms.Label SpeedXNameLabel;
        private System.Windows.Forms.TabPage SipPuffTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label pressureLabel;
        private System.Windows.Forms.ComboBox PuffComboBox;
        private System.Windows.Forms.TextBox PuffParameterText;
        private System.Windows.Forms.ComboBox SipComboBox;
        private System.Windows.Forms.TextBox SipParameterText;
        private System.Windows.Forms.Label PuffParameterLabel;
        private System.Windows.Forms.Label SipParameterLabel;
        private System.Windows.Forms.NumericUpDown PuffNumericParameter;
        private System.Windows.Forms.NumericUpDown SipNumericParameter;
        private System.Windows.Forms.Label puffThresholdLabel;
        private System.Windows.Forms.TrackBar puffThresholdBar;
        private System.Windows.Forms.Label thresholdLabelForPuff;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox PuffFunctionMenu;
        private System.Windows.Forms.Label sipThresholdLabel;
        private System.Windows.Forms.TrackBar sipThresholdBar;
        private System.Windows.Forms.Label thresholdLabelForSip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SipFunctionMenu;
        private System.Windows.Forms.ComboBox Button3ComboBox;
        private System.Windows.Forms.ComboBox Button2ComboBox;
        private System.Windows.Forms.ComboBox Button1ComboBox;
        private System.Windows.Forms.NumericUpDown Button3NumericParameter;
        private System.Windows.Forms.NumericUpDown Button2NumericParameter;
        private System.Windows.Forms.NumericUpDown Button1NumericParameter;
        private System.Windows.Forms.Label Button3Label;
        private System.Windows.Forms.TextBox Button3ParameterText;
        private System.Windows.Forms.Label Button2Label;
        private System.Windows.Forms.TextBox Button2ParameterText;
        private System.Windows.Forms.Label Button1Label;
        private System.Windows.Forms.TextBox Button1ParameterText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Button3FunctionBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Button2FunctionBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Button1FunctionBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox activityLogTextbox;
        private System.Windows.Forms.TabPage AlternativeTab;
        private System.Windows.Forms.ComboBox RightComboBox;
        private System.Windows.Forms.NumericUpDown RightNumericParameter;
        private System.Windows.Forms.Label RightLabel;
        private System.Windows.Forms.TextBox RightParameterText;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox RightFunctionMenu;
        private System.Windows.Forms.ComboBox LeftComboBox;
        private System.Windows.Forms.ComboBox DownComboBox;
        private System.Windows.Forms.ComboBox UpComboBox;
        private System.Windows.Forms.NumericUpDown LeftNumericParameter;
        private System.Windows.Forms.NumericUpDown DownNumericParameter;
        private System.Windows.Forms.NumericUpDown UpNumericParameter;
        private System.Windows.Forms.Label LeftLabel;
        private System.Windows.Forms.TextBox LeftParameterText;
        private System.Windows.Forms.Label DownLabel;
        private System.Windows.Forms.TextBox DownParameterText;
        private System.Windows.Forms.Label UpLabel;
        private System.Windows.Forms.TextBox UpParameterText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox LeftFunctionMenu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox DownFunctionMenu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox UpFunctionMenu;
        private System.Windows.Forms.TabPage RawValueTab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label specialThresholdLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TrackBar specialThresholdBar;
        private System.Windows.Forms.ComboBox SpecialPuffComboBox;
        private System.Windows.Forms.TextBox SpecialPuffParameterText;
        private System.Windows.Forms.Label SpecialPuffParameterLabel;
        private System.Windows.Forms.NumericUpDown SpecialPuffNumericParameter;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox SpecialPuffFunctionMenu;
        private System.Windows.Forms.ComboBox SpecialSipComboBox;
        private System.Windows.Forms.TextBox SpecialSipParameterText;
        private System.Windows.Forms.Label SpecialSipParameterLabel;
        private System.Windows.Forms.NumericUpDown SpecialSipNumericParameter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox SpecialSipFunctionMenu;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel downPanel;
        private System.Windows.Forms.Panel upPanel;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label downSensorLabel;
        private System.Windows.Forms.Label leftSensorLabel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label rightSensorLabel;
        private System.Windows.Forms.Label upSensorLabel;
        private System.Windows.Forms.RadioButton selectAlternative;
        private System.Windows.Forms.RadioButton selectStick;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.ComboBox slotNames;
        private System.Windows.Forms.CheckBox splitXYBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TrackBar speedYBar;
        private System.Windows.Forms.TrackBar deadzoneYBar;
        private System.Windows.Forms.Label speedYLabel;
        private System.Windows.Forms.Label deadzoneYLabel;
        private System.Windows.Forms.Label DeadzoneYNameLabel;
        private System.Windows.Forms.Label SpeedYNameLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem saveToFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFromFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.Button incSpeedY;
        private System.Windows.Forms.Button decSpeedX;
        private System.Windows.Forms.Button incDeadzoneY;
        private System.Windows.Forms.Button decDeadzoneX;
        private System.Windows.Forms.Button incSipThreshold;
        private System.Windows.Forms.Button decSipThreshold;
        private System.Windows.Forms.Button incPuffThreshold;
        private System.Windows.Forms.Button decPuffThreshold;
        private System.Windows.Forms.Button incTimeThreshld;
        private System.Windows.Forms.Button decTimeThreshold;
        private System.Windows.Forms.Button incUpGain;
        private System.Windows.Forms.Button decUpGain;
        private System.Windows.Forms.Label upGainLabel;
        private System.Windows.Forms.TrackBar upGainBar;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button incLeftGain;
        private System.Windows.Forms.Button decLeftGain;
        private System.Windows.Forms.Label leftGainLabel;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar leftGainBar;
        private System.Windows.Forms.Button incRightGain;
        private System.Windows.Forms.Button decRightGain;
        private System.Windows.Forms.Label rightGainLabel;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TrackBar rightGainBar;
        private System.Windows.Forms.Button incDownGain;
        private System.Windows.Forms.Button decDownGain;
        private System.Windows.Forms.Label downGainLabel;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TrackBar downGainBar;
        private System.Windows.Forms.Button clearButton1;
        private System.Windows.Forms.Button clearButtonUp;
        private System.Windows.Forms.Button clearButton3;
        private System.Windows.Forms.Button clearButton2;
        private System.Windows.Forms.Button clearButtonRight;
        private System.Windows.Forms.Button clearButtonLeft;
        private System.Windows.Forms.Button clearButtonDown;
        private System.Windows.Forms.Button clearButtonSpecialSip;
        private System.Windows.Forms.Button clearButtonSip;
        private System.Windows.Forms.Button clearButtonSpecialPuff;
        private System.Windows.Forms.Button clearButtonPuff;
    }
}

