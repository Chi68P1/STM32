namespace SerialCommunicationSTM32
{
    partial class Form1
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
            this.comboBox_portName = new System.Windows.Forms.ComboBox();
            this.comboBox_baudRate = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_send = new System.Windows.Forms.Button();
            this.textBox_send = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_read = new System.Windows.Forms.Button();
            this.textBox_receive = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_sw8 = new System.Windows.Forms.Button();
            this.button_sw7 = new System.Windows.Forms.Button();
            this.button_sw6 = new System.Windows.Forms.Button();
            this.button_sw5 = new System.Windows.Forms.Button();
            this.button_sw4 = new System.Windows.Forms.Button();
            this.button_sw3 = new System.Windows.Forms.Button();
            this.button_sw2 = new System.Windows.Forms.Button();
            this.button_sw1 = new System.Windows.Forms.Button();
            this.button_off8 = new System.Windows.Forms.Button();
            this.button_off7 = new System.Windows.Forms.Button();
            this.button_off6 = new System.Windows.Forms.Button();
            this.button_off5 = new System.Windows.Forms.Button();
            this.button_off4 = new System.Windows.Forms.Button();
            this.button_off3 = new System.Windows.Forms.Button();
            this.button_off2 = new System.Windows.Forms.Button();
            this.button_off1 = new System.Windows.Forms.Button();
            this.button_on8 = new System.Windows.Forms.Button();
            this.button_on7 = new System.Windows.Forms.Button();
            this.button_on6 = new System.Windows.Forms.Button();
            this.button_on5 = new System.Windows.Forms.Button();
            this.button_on4 = new System.Windows.Forms.Button();
            this.button_on3 = new System.Windows.Forms.Button();
            this.button_on2 = new System.Windows.Forms.Button();
            this.button_on1 = new System.Windows.Forms.Button();
            this.progressBar_status = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_openPort = new System.Windows.Forms.Button();
            this.button_closePort = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_portName
            // 
            this.comboBox_portName.FormattingEnabled = true;
            this.comboBox_portName.Location = new System.Drawing.Point(76, 33);
            this.comboBox_portName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_portName.Name = "comboBox_portName";
            this.comboBox_portName.Size = new System.Drawing.Size(114, 21);
            this.comboBox_portName.TabIndex = 0;
            // 
            // comboBox_baudRate
            // 
            this.comboBox_baudRate.FormattingEnabled = true;
            this.comboBox_baudRate.Location = new System.Drawing.Point(335, 33);
            this.comboBox_baudRate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_baudRate.Name = "comboBox_baudRate";
            this.comboBox_baudRate.Size = new System.Drawing.Size(118, 21);
            this.comboBox_baudRate.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_send);
            this.groupBox1.Controls.Add(this.textBox_send);
            this.groupBox1.Location = new System.Drawing.Point(76, 93);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(238, 204);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send here";
            // 
            // button_send
            // 
            this.button_send.Enabled = false;
            this.button_send.Location = new System.Drawing.Point(168, 174);
            this.button_send.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(51, 25);
            this.button_send.TabIndex = 27;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // textBox_send
            // 
            this.textBox_send.Enabled = false;
            this.textBox_send.Location = new System.Drawing.Point(4, 17);
            this.textBox_send.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_send.Multiline = true;
            this.textBox_send.Name = "textBox_send";
            this.textBox_send.Size = new System.Drawing.Size(216, 146);
            this.textBox_send.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_read);
            this.groupBox2.Controls.Add(this.textBox_receive);
            this.groupBox2.Location = new System.Drawing.Point(335, 93);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(231, 204);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Received here";
            // 
            // button_read
            // 
            this.button_read.Enabled = false;
            this.button_read.Location = new System.Drawing.Point(167, 174);
            this.button_read.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_read.Name = "button_read";
            this.button_read.Size = new System.Drawing.Size(51, 25);
            this.button_read.TabIndex = 28;
            this.button_read.Text = "Read";
            this.button_read.UseVisualStyleBackColor = true;
            this.button_read.Click += new System.EventHandler(this.button_read_Click);
            // 
            // textBox_receive
            // 
            this.textBox_receive.Enabled = false;
            this.textBox_receive.Location = new System.Drawing.Point(4, 17);
            this.textBox_receive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_receive.Multiline = true;
            this.textBox_receive.Name = "textBox_receive";
            this.textBox_receive.ReadOnly = true;
            this.textBox_receive.Size = new System.Drawing.Size(216, 146);
            this.textBox_receive.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_sw8);
            this.groupBox3.Controls.Add(this.button_sw7);
            this.groupBox3.Controls.Add(this.button_sw6);
            this.groupBox3.Controls.Add(this.button_sw5);
            this.groupBox3.Controls.Add(this.button_sw4);
            this.groupBox3.Controls.Add(this.button_sw3);
            this.groupBox3.Controls.Add(this.button_sw2);
            this.groupBox3.Controls.Add(this.button_sw1);
            this.groupBox3.Controls.Add(this.button_off8);
            this.groupBox3.Controls.Add(this.button_off7);
            this.groupBox3.Controls.Add(this.button_off6);
            this.groupBox3.Controls.Add(this.button_off5);
            this.groupBox3.Controls.Add(this.button_off4);
            this.groupBox3.Controls.Add(this.button_off3);
            this.groupBox3.Controls.Add(this.button_off2);
            this.groupBox3.Controls.Add(this.button_off1);
            this.groupBox3.Controls.Add(this.button_on8);
            this.groupBox3.Controls.Add(this.button_on7);
            this.groupBox3.Controls.Add(this.button_on6);
            this.groupBox3.Controls.Add(this.button_on5);
            this.groupBox3.Controls.Add(this.button_on4);
            this.groupBox3.Controls.Add(this.button_on3);
            this.groupBox3.Controls.Add(this.button_on2);
            this.groupBox3.Controls.Add(this.button_on1);
            this.groupBox3.Location = new System.Drawing.Point(76, 302);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(490, 210);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mode";
            // 
            // button_sw8
            // 
            this.button_sw8.Enabled = false;
            this.button_sw8.Location = new System.Drawing.Point(421, 146);
            this.button_sw8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_sw8.Name = "button_sw8";
            this.button_sw8.Size = new System.Drawing.Size(52, 41);
            this.button_sw8.TabIndex = 34;
            this.button_sw8.Text = "SW8";
            this.button_sw8.UseVisualStyleBackColor = true;
            this.button_sw8.Click += new System.EventHandler(this.button_sw8_Click);
            // 
            // button_sw7
            // 
            this.button_sw7.Enabled = false;
            this.button_sw7.Location = new System.Drawing.Point(363, 146);
            this.button_sw7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_sw7.Name = "button_sw7";
            this.button_sw7.Size = new System.Drawing.Size(52, 41);
            this.button_sw7.TabIndex = 33;
            this.button_sw7.Text = "SW7";
            this.button_sw7.UseVisualStyleBackColor = true;
            this.button_sw7.Click += new System.EventHandler(this.button_sw7_Click);
            // 
            // button_sw6
            // 
            this.button_sw6.Enabled = false;
            this.button_sw6.Location = new System.Drawing.Point(307, 146);
            this.button_sw6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_sw6.Name = "button_sw6";
            this.button_sw6.Size = new System.Drawing.Size(52, 41);
            this.button_sw6.TabIndex = 32;
            this.button_sw6.Text = "SW6";
            this.button_sw6.UseVisualStyleBackColor = true;
            this.button_sw6.Click += new System.EventHandler(this.button_sw6_Click);
            // 
            // button_sw5
            // 
            this.button_sw5.Enabled = false;
            this.button_sw5.Location = new System.Drawing.Point(250, 146);
            this.button_sw5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_sw5.Name = "button_sw5";
            this.button_sw5.Size = new System.Drawing.Size(52, 41);
            this.button_sw5.TabIndex = 31;
            this.button_sw5.Text = "SW5";
            this.button_sw5.UseVisualStyleBackColor = true;
            this.button_sw5.Click += new System.EventHandler(this.button_sw5_Click);
            // 
            // button_sw4
            // 
            this.button_sw4.Enabled = false;
            this.button_sw4.Location = new System.Drawing.Point(193, 146);
            this.button_sw4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_sw4.Name = "button_sw4";
            this.button_sw4.Size = new System.Drawing.Size(52, 41);
            this.button_sw4.TabIndex = 30;
            this.button_sw4.Text = "SW4";
            this.button_sw4.UseVisualStyleBackColor = true;
            this.button_sw4.Click += new System.EventHandler(this.button_sw4_Click);
            // 
            // button_sw3
            // 
            this.button_sw3.Enabled = false;
            this.button_sw3.Location = new System.Drawing.Point(136, 146);
            this.button_sw3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_sw3.Name = "button_sw3";
            this.button_sw3.Size = new System.Drawing.Size(52, 41);
            this.button_sw3.TabIndex = 29;
            this.button_sw3.Text = "SW3";
            this.button_sw3.UseVisualStyleBackColor = true;
            this.button_sw3.Click += new System.EventHandler(this.button_sw3_Click);
            // 
            // button_sw2
            // 
            this.button_sw2.Enabled = false;
            this.button_sw2.Location = new System.Drawing.Point(79, 146);
            this.button_sw2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_sw2.Name = "button_sw2";
            this.button_sw2.Size = new System.Drawing.Size(52, 41);
            this.button_sw2.TabIndex = 28;
            this.button_sw2.Text = "SW2";
            this.button_sw2.UseVisualStyleBackColor = true;
            this.button_sw2.Click += new System.EventHandler(this.button_sw2_Click);
            // 
            // button_sw1
            // 
            this.button_sw1.Enabled = false;
            this.button_sw1.Location = new System.Drawing.Point(22, 146);
            this.button_sw1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_sw1.Name = "button_sw1";
            this.button_sw1.Size = new System.Drawing.Size(52, 41);
            this.button_sw1.TabIndex = 27;
            this.button_sw1.Text = "SW1";
            this.button_sw1.UseVisualStyleBackColor = true;
            this.button_sw1.Click += new System.EventHandler(this.button_sw1_Click);
            // 
            // button_off8
            // 
            this.button_off8.Enabled = false;
            this.button_off8.Location = new System.Drawing.Point(421, 89);
            this.button_off8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_off8.Name = "button_off8";
            this.button_off8.Size = new System.Drawing.Size(52, 41);
            this.button_off8.TabIndex = 26;
            this.button_off8.Text = "OFF8";
            this.button_off8.UseVisualStyleBackColor = true;
            this.button_off8.Click += new System.EventHandler(this.button_off8_Click);
            // 
            // button_off7
            // 
            this.button_off7.Enabled = false;
            this.button_off7.Location = new System.Drawing.Point(363, 89);
            this.button_off7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_off7.Name = "button_off7";
            this.button_off7.Size = new System.Drawing.Size(52, 41);
            this.button_off7.TabIndex = 25;
            this.button_off7.Text = "OFF7";
            this.button_off7.UseVisualStyleBackColor = true;
            this.button_off7.Click += new System.EventHandler(this.button_off7_Click);
            // 
            // button_off6
            // 
            this.button_off6.Enabled = false;
            this.button_off6.Location = new System.Drawing.Point(307, 89);
            this.button_off6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_off6.Name = "button_off6";
            this.button_off6.Size = new System.Drawing.Size(52, 41);
            this.button_off6.TabIndex = 24;
            this.button_off6.Text = "OFF6";
            this.button_off6.UseVisualStyleBackColor = true;
            this.button_off6.Click += new System.EventHandler(this.button_off6_Click);
            // 
            // button_off5
            // 
            this.button_off5.Enabled = false;
            this.button_off5.Location = new System.Drawing.Point(250, 89);
            this.button_off5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_off5.Name = "button_off5";
            this.button_off5.Size = new System.Drawing.Size(52, 41);
            this.button_off5.TabIndex = 23;
            this.button_off5.Text = "OFF5";
            this.button_off5.UseVisualStyleBackColor = true;
            this.button_off5.Click += new System.EventHandler(this.button_off5_Click);
            // 
            // button_off4
            // 
            this.button_off4.Enabled = false;
            this.button_off4.Location = new System.Drawing.Point(193, 89);
            this.button_off4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_off4.Name = "button_off4";
            this.button_off4.Size = new System.Drawing.Size(52, 41);
            this.button_off4.TabIndex = 22;
            this.button_off4.Text = "OFF4";
            this.button_off4.UseVisualStyleBackColor = true;
            this.button_off4.Click += new System.EventHandler(this.button_off4_Click);
            // 
            // button_off3
            // 
            this.button_off3.Enabled = false;
            this.button_off3.Location = new System.Drawing.Point(136, 89);
            this.button_off3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_off3.Name = "button_off3";
            this.button_off3.Size = new System.Drawing.Size(52, 41);
            this.button_off3.TabIndex = 21;
            this.button_off3.Text = "OFF3";
            this.button_off3.UseVisualStyleBackColor = true;
            this.button_off3.Click += new System.EventHandler(this.button_off3_Click);
            // 
            // button_off2
            // 
            this.button_off2.Enabled = false;
            this.button_off2.Location = new System.Drawing.Point(79, 89);
            this.button_off2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_off2.Name = "button_off2";
            this.button_off2.Size = new System.Drawing.Size(52, 41);
            this.button_off2.TabIndex = 20;
            this.button_off2.Text = "OFF2";
            this.button_off2.UseVisualStyleBackColor = true;
            this.button_off2.Click += new System.EventHandler(this.button_off2_Click);
            // 
            // button_off1
            // 
            this.button_off1.Enabled = false;
            this.button_off1.Location = new System.Drawing.Point(22, 89);
            this.button_off1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_off1.Name = "button_off1";
            this.button_off1.Size = new System.Drawing.Size(52, 41);
            this.button_off1.TabIndex = 19;
            this.button_off1.Text = "OFF1";
            this.button_off1.UseVisualStyleBackColor = true;
            this.button_off1.Click += new System.EventHandler(this.button_off1_Click);
            // 
            // button_on8
            // 
            this.button_on8.Enabled = false;
            this.button_on8.Location = new System.Drawing.Point(421, 33);
            this.button_on8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_on8.Name = "button_on8";
            this.button_on8.Size = new System.Drawing.Size(52, 41);
            this.button_on8.TabIndex = 18;
            this.button_on8.Text = "ON8";
            this.button_on8.UseVisualStyleBackColor = true;
            this.button_on8.Click += new System.EventHandler(this.button_on8_Click);
            // 
            // button_on7
            // 
            this.button_on7.Enabled = false;
            this.button_on7.Location = new System.Drawing.Point(364, 33);
            this.button_on7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_on7.Name = "button_on7";
            this.button_on7.Size = new System.Drawing.Size(52, 41);
            this.button_on7.TabIndex = 17;
            this.button_on7.Text = "ON7";
            this.button_on7.UseVisualStyleBackColor = true;
            this.button_on7.Click += new System.EventHandler(this.button_on7_Click);
            // 
            // button_on6
            // 
            this.button_on6.Enabled = false;
            this.button_on6.Location = new System.Drawing.Point(307, 33);
            this.button_on6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_on6.Name = "button_on6";
            this.button_on6.Size = new System.Drawing.Size(52, 41);
            this.button_on6.TabIndex = 16;
            this.button_on6.Text = "ON6";
            this.button_on6.UseVisualStyleBackColor = true;
            this.button_on6.Click += new System.EventHandler(this.button_on6_Click);
            // 
            // button_on5
            // 
            this.button_on5.Enabled = false;
            this.button_on5.Location = new System.Drawing.Point(250, 33);
            this.button_on5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_on5.Name = "button_on5";
            this.button_on5.Size = new System.Drawing.Size(52, 41);
            this.button_on5.TabIndex = 15;
            this.button_on5.Text = "ON5";
            this.button_on5.UseVisualStyleBackColor = true;
            this.button_on5.Click += new System.EventHandler(this.button_on5_Click);
            // 
            // button_on4
            // 
            this.button_on4.Enabled = false;
            this.button_on4.Location = new System.Drawing.Point(193, 33);
            this.button_on4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_on4.Name = "button_on4";
            this.button_on4.Size = new System.Drawing.Size(52, 41);
            this.button_on4.TabIndex = 14;
            this.button_on4.Text = "ON4";
            this.button_on4.UseVisualStyleBackColor = true;
            this.button_on4.Click += new System.EventHandler(this.button_on4_Click);
            // 
            // button_on3
            // 
            this.button_on3.Enabled = false;
            this.button_on3.Location = new System.Drawing.Point(136, 33);
            this.button_on3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_on3.Name = "button_on3";
            this.button_on3.Size = new System.Drawing.Size(52, 41);
            this.button_on3.TabIndex = 13;
            this.button_on3.Text = "ON3";
            this.button_on3.UseVisualStyleBackColor = true;
            this.button_on3.Click += new System.EventHandler(this.button_on3_Click);
            // 
            // button_on2
            // 
            this.button_on2.Enabled = false;
            this.button_on2.Location = new System.Drawing.Point(79, 33);
            this.button_on2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_on2.Name = "button_on2";
            this.button_on2.Size = new System.Drawing.Size(52, 41);
            this.button_on2.TabIndex = 12;
            this.button_on2.Text = "ON2";
            this.button_on2.UseVisualStyleBackColor = true;
            this.button_on2.Click += new System.EventHandler(this.button_on2_Click);
            // 
            // button_on1
            // 
            this.button_on1.Enabled = false;
            this.button_on1.Location = new System.Drawing.Point(22, 33);
            this.button_on1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_on1.Name = "button_on1";
            this.button_on1.Size = new System.Drawing.Size(52, 41);
            this.button_on1.TabIndex = 11;
            this.button_on1.Text = "ON1";
            this.button_on1.UseVisualStyleBackColor = true;
            this.button_on1.Click += new System.EventHandler(this.button_on1_Click);
            // 
            // progressBar_status
            // 
            this.progressBar_status.Location = new System.Drawing.Point(615, 33);
            this.progressBar_status.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar_status.Name = "progressBar_status";
            this.progressBar_status.Size = new System.Drawing.Size(113, 20);
            this.progressBar_status.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Port Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Baud Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(613, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Status";
            // 
            // button_openPort
            // 
            this.button_openPort.Location = new System.Drawing.Point(615, 93);
            this.button_openPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_openPort.Name = "button_openPort";
            this.button_openPort.Size = new System.Drawing.Size(113, 115);
            this.button_openPort.TabIndex = 9;
            this.button_openPort.Text = "Open Port";
            this.button_openPort.UseVisualStyleBackColor = true;
            this.button_openPort.Click += new System.EventHandler(this.button_openPort_Click);
            // 
            // button_closePort
            // 
            this.button_closePort.Enabled = false;
            this.button_closePort.Location = new System.Drawing.Point(615, 239);
            this.button_closePort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_closePort.Name = "button_closePort";
            this.button_closePort.Size = new System.Drawing.Size(113, 115);
            this.button_closePort.TabIndex = 10;
            this.button_closePort.Text = "Close Port";
            this.button_closePort.UseVisualStyleBackColor = true;
            this.button_closePort.Click += new System.EventHandler(this.button_closePort_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(615, 377);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 112);
            this.button1.TabIndex = 11;
            this.button1.Text = "None";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 522);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_closePort);
            this.Controls.Add(this.button_openPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar_status);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox_baudRate);
            this.Controls.Add(this.comboBox_portName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_portName;
        private System.Windows.Forms.ComboBox comboBox_baudRate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.TextBox textBox_send;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_read;
        private System.Windows.Forms.TextBox textBox_receive;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_off8;
        private System.Windows.Forms.Button button_off7;
        private System.Windows.Forms.Button button_off6;
        private System.Windows.Forms.Button button_off5;
        private System.Windows.Forms.Button button_off4;
        private System.Windows.Forms.Button button_off3;
        private System.Windows.Forms.Button button_off2;
        private System.Windows.Forms.Button button_off1;
        private System.Windows.Forms.Button button_on8;
        private System.Windows.Forms.Button button_on7;
        private System.Windows.Forms.Button button_on6;
        private System.Windows.Forms.Button button_on5;
        private System.Windows.Forms.Button button_on4;
        private System.Windows.Forms.Button button_on3;
        private System.Windows.Forms.Button button_on2;
        private System.Windows.Forms.Button button_on1;
        private System.Windows.Forms.ProgressBar progressBar_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_openPort;
        private System.Windows.Forms.Button button_closePort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_sw8;
        private System.Windows.Forms.Button button_sw7;
        private System.Windows.Forms.Button button_sw6;
        private System.Windows.Forms.Button button_sw5;
        private System.Windows.Forms.Button button_sw4;
        private System.Windows.Forms.Button button_sw3;
        private System.Windows.Forms.Button button_sw2;
        private System.Windows.Forms.Button button_sw1;
    }
}

