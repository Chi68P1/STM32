namespace SerialPortCOM_IOT
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_LedOff = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblStatusCOM = new System.Windows.Forms.Label();
            this.btn_LedOn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBox_Paritybits = new System.Windows.Forms.ComboBox();
            this.cBox_Stopbits = new System.Windows.Forms.ComboBox();
            this.cBox_Databits = new System.Windows.Forms.ComboBox();
            this.cBox_Baudrate = new System.Windows.Forms.ComboBox();
            this.cBoxCOMPORT = new System.Windows.Forms.ComboBox();
            this.led_on_1 = new System.Windows.Forms.Button();
            this.btn_senddata = new System.Windows.Forms.Button();
            this.tB_Datasend = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblDataOutLength = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chBoxWrite = new System.Windows.Forms.CheckBox();
            this.chBoxWriteLine = new System.Windows.Forms.CheckBox();
            this.btn_ClearDataOut = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chBox_usingEnter = new System.Windows.Forms.CheckBox();
            this.chBox_usingButton = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lblDataInLength = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_ClearDataIn = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.chBox_AddToOldData = new System.Windows.Forms.CheckBox();
            this.chBox_AlwaysUpdate = new System.Windows.Forms.CheckBox();
            this.tBox_Data_receive = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tB_numberofpoints = new System.Windows.Forms.TextBox();
            this.tB_start_address = new System.Windows.Forms.TextBox();
            this.tB_func_code = new System.Windows.Forms.TextBox();
            this.tB_Slave_address = new System.Windows.Forms.TextBox();
            this.tB_CRC_Send = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tB_Send_Msg = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.tB_CRC_Receive = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tB_Receive_Msg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.tB_Data_Write = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tB_Start_Address_Write = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tB_Slave_Address_Write = new System.Windows.Forms.TextBox();
            this.btn_Calculate_Write = new System.Windows.Forms.Button();
            this.tB_Receive_Write = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tB_Send_Write = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.BlueViolet;
            this.groupBox1.Controls.Add(this.btn_LedOff);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.btn_LedOn);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBox_Paritybits);
            this.groupBox1.Controls.Add(this.cBox_Stopbits);
            this.groupBox1.Controls.Add(this.cBox_Databits);
            this.groupBox1.Controls.Add(this.cBox_Baudrate);
            this.groupBox1.Controls.Add(this.cBoxCOMPORT);
            this.groupBox1.Controls.Add(this.led_on_1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 553);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM Port Control";
            // 
            // btn_LedOff
            // 
            this.btn_LedOff.BackColor = System.Drawing.Color.Red;
            this.btn_LedOff.Location = new System.Drawing.Point(49, 465);
            this.btn_LedOff.Name = "btn_LedOff";
            this.btn_LedOff.Size = new System.Drawing.Size(97, 52);
            this.btn_LedOff.TabIndex = 5;
            this.btn_LedOff.Text = "ALL LED OFF";
            this.btn_LedOff.UseVisualStyleBackColor = false;
            this.btn_LedOff.Click += new System.EventHandler(this.btn_LedOff_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Cyan;
            this.groupBox7.Controls.Add(this.lblStatusCOM);
            this.groupBox7.Location = new System.Drawing.Point(278, 395);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(145, 125);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "COM Port Status";
            // 
            // lblStatusCOM
            // 
            this.lblStatusCOM.AutoSize = true;
            this.lblStatusCOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusCOM.Location = new System.Drawing.Point(45, 45);
            this.lblStatusCOM.Name = "lblStatusCOM";
            this.lblStatusCOM.Size = new System.Drawing.Size(74, 33);
            this.lblStatusCOM.TabIndex = 12;
            this.lblStatusCOM.Text = "OFF";
            // 
            // btn_LedOn
            // 
            this.btn_LedOn.BackColor = System.Drawing.Color.Lime;
            this.btn_LedOn.Location = new System.Drawing.Point(43, 387);
            this.btn_LedOn.Name = "btn_LedOn";
            this.btn_LedOn.Size = new System.Drawing.Size(95, 52);
            this.btn_LedOn.TabIndex = 4;
            this.btn_LedOn.Text = "ALL LED ON";
            this.btn_LedOn.UseVisualStyleBackColor = false;
            this.btn_LedOn.Click += new System.EventHandler(this.btn_LedOn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.btn_close);
            this.groupBox2.Controls.Add(this.btn_open);
            this.groupBox2.Location = new System.Drawing.Point(106, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 125);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 79);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(213, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Red;
            this.btn_close.Location = new System.Drawing.Point(154, 21);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 38);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_open
            // 
            this.btn_open.BackColor = System.Drawing.Color.Lime;
            this.btn_open.Location = new System.Drawing.Point(16, 21);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 38);
            this.btn_open.TabIndex = 0;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Parity Bits :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stop Bits :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data Bits :";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Red;
            this.button9.Location = new System.Drawing.Point(178, 467);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(83, 52);
            this.button9.TabIndex = 29;
            this.button9.Text = "LED OFF 1";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Baud Rate : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM Port :";
            // 
            // cBox_Paritybits
            // 
            this.cBox_Paritybits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_Paritybits.FormattingEnabled = true;
            this.cBox_Paritybits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBox_Paritybits.Location = new System.Drawing.Point(164, 202);
            this.cBox_Paritybits.Name = "cBox_Paritybits";
            this.cBox_Paritybits.Size = new System.Drawing.Size(165, 24);
            this.cBox_Paritybits.TabIndex = 5;
            this.cBox_Paritybits.Text = "None";
            // 
            // cBox_Stopbits
            // 
            this.cBox_Stopbits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_Stopbits.FormattingEnabled = true;
            this.cBox_Stopbits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBox_Stopbits.Location = new System.Drawing.Point(164, 160);
            this.cBox_Stopbits.Name = "cBox_Stopbits";
            this.cBox_Stopbits.Size = new System.Drawing.Size(165, 24);
            this.cBox_Stopbits.TabIndex = 4;
            this.cBox_Stopbits.Text = "One";
            // 
            // cBox_Databits
            // 
            this.cBox_Databits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_Databits.FormattingEnabled = true;
            this.cBox_Databits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cBox_Databits.Location = new System.Drawing.Point(164, 118);
            this.cBox_Databits.Name = "cBox_Databits";
            this.cBox_Databits.Size = new System.Drawing.Size(165, 24);
            this.cBox_Databits.TabIndex = 3;
            this.cBox_Databits.Text = "8";
            // 
            // cBox_Baudrate
            // 
            this.cBox_Baudrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_Baudrate.FormattingEnabled = true;
            this.cBox_Baudrate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600"});
            this.cBox_Baudrate.Location = new System.Drawing.Point(164, 75);
            this.cBox_Baudrate.Name = "cBox_Baudrate";
            this.cBox_Baudrate.Size = new System.Drawing.Size(165, 24);
            this.cBox_Baudrate.TabIndex = 2;
            this.cBox_Baudrate.Text = "9600";
            // 
            // cBoxCOMPORT
            // 
            this.cBoxCOMPORT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxCOMPORT.FormattingEnabled = true;
            this.cBoxCOMPORT.Location = new System.Drawing.Point(164, 35);
            this.cBoxCOMPORT.Name = "cBoxCOMPORT";
            this.cBoxCOMPORT.Size = new System.Drawing.Size(165, 24);
            this.cBoxCOMPORT.TabIndex = 1;
            // 
            // led_on_1
            // 
            this.led_on_1.BackColor = System.Drawing.Color.Lime;
            this.led_on_1.Location = new System.Drawing.Point(178, 387);
            this.led_on_1.Name = "led_on_1";
            this.led_on_1.Size = new System.Drawing.Size(83, 52);
            this.led_on_1.TabIndex = 21;
            this.led_on_1.Text = "LED ON 1";
            this.led_on_1.UseVisualStyleBackColor = false;
            this.led_on_1.Click += new System.EventHandler(this.led_on_1_Click);
            // 
            // btn_senddata
            // 
            this.btn_senddata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_senddata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_senddata.Location = new System.Drawing.Point(16, 134);
            this.btn_senddata.Name = "btn_senddata";
            this.btn_senddata.Size = new System.Drawing.Size(152, 51);
            this.btn_senddata.TabIndex = 2;
            this.btn_senddata.Text = "Send Data";
            this.btn_senddata.UseVisualStyleBackColor = false;
            this.btn_senddata.Click += new System.EventHandler(this.btn_senddata_Click);
            // 
            // tB_Datasend
            // 
            this.tB_Datasend.Location = new System.Drawing.Point(6, 19);
            this.tB_Datasend.Multiline = true;
            this.tB_Datasend.Name = "tB_Datasend";
            this.tB_Datasend.Size = new System.Drawing.Size(421, 107);
            this.tB_Datasend.TabIndex = 1;
            this.tB_Datasend.TextChanged += new System.EventHandler(this.tB_Datasend_TextChanged);
            this.tB_Datasend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tB_Datasend_KeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Yellow;
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.btn_senddata);
            this.groupBox3.Controls.Add(this.btn_ClearDataOut);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.tB_Datasend);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(449, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(438, 305);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transmitter Control";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblDataOutLength);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Location = new System.Drawing.Point(16, 240);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(403, 57);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            // 
            // lblDataOutLength
            // 
            this.lblDataOutLength.AutoSize = true;
            this.lblDataOutLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataOutLength.Location = new System.Drawing.Point(279, 19);
            this.lblDataOutLength.Name = "lblDataOutLength";
            this.lblDataOutLength.Size = new System.Drawing.Size(32, 24);
            this.lblDataOutLength.TabIndex = 12;
            this.lblDataOutLength.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(101, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data Out Length :\r\n";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox5.Controls.Add(this.chBoxWrite);
            this.groupBox5.Controls.Add(this.chBoxWriteLine);
            this.groupBox5.Location = new System.Drawing.Point(306, 134);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(113, 100);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            // 
            // chBoxWrite
            // 
            this.chBoxWrite.AutoSize = true;
            this.chBoxWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxWrite.Location = new System.Drawing.Point(19, 60);
            this.chBoxWrite.Name = "chBoxWrite";
            this.chBoxWrite.Size = new System.Drawing.Size(54, 19);
            this.chBoxWrite.TabIndex = 1;
            this.chBoxWrite.Text = "Write";
            this.chBoxWrite.UseVisualStyleBackColor = true;
            this.chBoxWrite.CheckedChanged += new System.EventHandler(this.chBoxWrite_CheckedChanged);
            // 
            // chBoxWriteLine
            // 
            this.chBoxWriteLine.AutoSize = true;
            this.chBoxWriteLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxWriteLine.Location = new System.Drawing.Point(19, 27);
            this.chBoxWriteLine.Name = "chBoxWriteLine";
            this.chBoxWriteLine.Size = new System.Drawing.Size(78, 19);
            this.chBoxWriteLine.TabIndex = 0;
            this.chBoxWriteLine.Text = "WriteLine";
            this.chBoxWriteLine.UseVisualStyleBackColor = true;
            this.chBoxWriteLine.CheckedChanged += new System.EventHandler(this.chBoxWriteLine_CheckedChanged);
            // 
            // btn_ClearDataOut
            // 
            this.btn_ClearDataOut.BackColor = System.Drawing.Color.Lime;
            this.btn_ClearDataOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClearDataOut.Location = new System.Drawing.Point(16, 187);
            this.btn_ClearDataOut.Name = "btn_ClearDataOut";
            this.btn_ClearDataOut.Size = new System.Drawing.Size(152, 47);
            this.btn_ClearDataOut.TabIndex = 4;
            this.btn_ClearDataOut.Text = "Clear Data Out";
            this.btn_ClearDataOut.UseVisualStyleBackColor = false;
            this.btn_ClearDataOut.Click += new System.EventHandler(this.btn_ClearDataOut_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox4.Controls.Add(this.chBox_usingEnter);
            this.groupBox4.Controls.Add(this.chBox_usingButton);
            this.groupBox4.Location = new System.Drawing.Point(174, 134);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(113, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // chBox_usingEnter
            // 
            this.chBox_usingEnter.AutoSize = true;
            this.chBox_usingEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBox_usingEnter.Location = new System.Drawing.Point(13, 60);
            this.chBox_usingEnter.Name = "chBox_usingEnter";
            this.chBox_usingEnter.Size = new System.Drawing.Size(88, 19);
            this.chBox_usingEnter.TabIndex = 1;
            this.chBox_usingEnter.Text = "using Enter";
            this.chBox_usingEnter.UseVisualStyleBackColor = true;
            // 
            // chBox_usingButton
            // 
            this.chBox_usingButton.AutoSize = true;
            this.chBox_usingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBox_usingButton.Location = new System.Drawing.Point(13, 27);
            this.chBox_usingButton.Name = "chBox_usingButton";
            this.chBox_usingButton.Size = new System.Drawing.Size(94, 19);
            this.chBox_usingButton.TabIndex = 0;
            this.chBox_usingButton.Text = "using Button";
            this.chBox_usingButton.UseVisualStyleBackColor = true;
            this.chBox_usingButton.CheckedChanged += new System.EventHandler(this.chBox_usingButton_CheckedChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.Yellow;
            this.groupBox8.Controls.Add(this.groupBox9);
            this.groupBox8.Controls.Add(this.btn_ClearDataIn);
            this.groupBox8.Controls.Add(this.groupBox11);
            this.groupBox8.Controls.Add(this.tBox_Data_receive);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(893, 23);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(438, 305);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Receiver Control";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lblDataInLength);
            this.groupBox9.Controls.Add(this.label8);
            this.groupBox9.Location = new System.Drawing.Point(18, 240);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(403, 57);
            this.groupBox9.TabIndex = 6;
            this.groupBox9.TabStop = false;
            // 
            // lblDataInLength
            // 
            this.lblDataInLength.AutoSize = true;
            this.lblDataInLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInLength.Location = new System.Drawing.Point(270, 19);
            this.lblDataInLength.Name = "lblDataInLength";
            this.lblDataInLength.Size = new System.Drawing.Size(32, 24);
            this.lblDataInLength.TabIndex = 12;
            this.lblDataInLength.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(101, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "Data In Length :\r\n";
            // 
            // btn_ClearDataIn
            // 
            this.btn_ClearDataIn.BackColor = System.Drawing.Color.Lime;
            this.btn_ClearDataIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClearDataIn.Location = new System.Drawing.Point(22, 134);
            this.btn_ClearDataIn.Name = "btn_ClearDataIn";
            this.btn_ClearDataIn.Size = new System.Drawing.Size(195, 100);
            this.btn_ClearDataIn.TabIndex = 4;
            this.btn_ClearDataIn.Text = "Clear Data In";
            this.btn_ClearDataIn.UseVisualStyleBackColor = false;
            this.btn_ClearDataIn.Click += new System.EventHandler(this.btn_ClearDataIn_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox11.Controls.Add(this.chBox_AddToOldData);
            this.groupBox11.Controls.Add(this.chBox_AlwaysUpdate);
            this.groupBox11.Location = new System.Drawing.Point(250, 134);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(156, 100);
            this.groupBox11.TabIndex = 3;
            this.groupBox11.TabStop = false;
            // 
            // chBox_AddToOldData
            // 
            this.chBox_AddToOldData.AutoSize = true;
            this.chBox_AddToOldData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBox_AddToOldData.Location = new System.Drawing.Point(13, 60);
            this.chBox_AddToOldData.Name = "chBox_AddToOldData";
            this.chBox_AddToOldData.Size = new System.Drawing.Size(115, 19);
            this.chBox_AddToOldData.TabIndex = 1;
            this.chBox_AddToOldData.Text = "Add To Old Data";
            this.chBox_AddToOldData.UseVisualStyleBackColor = true;
            this.chBox_AddToOldData.CheckedChanged += new System.EventHandler(this.chBox_AddToOldData_CheckedChanged);
            // 
            // chBox_AlwaysUpdate
            // 
            this.chBox_AlwaysUpdate.AutoSize = true;
            this.chBox_AlwaysUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBox_AlwaysUpdate.Location = new System.Drawing.Point(13, 27);
            this.chBox_AlwaysUpdate.Name = "chBox_AlwaysUpdate";
            this.chBox_AlwaysUpdate.Size = new System.Drawing.Size(106, 19);
            this.chBox_AlwaysUpdate.TabIndex = 0;
            this.chBox_AlwaysUpdate.Text = "Always Update";
            this.chBox_AlwaysUpdate.UseVisualStyleBackColor = true;
            this.chBox_AlwaysUpdate.CheckedChanged += new System.EventHandler(this.chBox_AlwaysUpdate_CheckedChanged);
            // 
            // tBox_Data_receive
            // 
            this.tBox_Data_receive.Location = new System.Drawing.Point(6, 19);
            this.tBox_Data_receive.Multiline = true;
            this.tBox_Data_receive.Name = "tBox_Data_receive";
            this.tBox_Data_receive.ReadOnly = true;
            this.tBox_Data_receive.Size = new System.Drawing.Size(421, 107);
            this.tBox_Data_receive.TabIndex = 1;
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.Color.Lime;
            this.groupBox10.Controls.Add(this.label15);
            this.groupBox10.Controls.Add(this.label14);
            this.groupBox10.Controls.Add(this.label13);
            this.groupBox10.Controls.Add(this.label12);
            this.groupBox10.Controls.Add(this.tB_numberofpoints);
            this.groupBox10.Controls.Add(this.tB_start_address);
            this.groupBox10.Controls.Add(this.tB_func_code);
            this.groupBox10.Controls.Add(this.tB_Slave_address);
            this.groupBox10.Controls.Add(this.tB_CRC_Send);
            this.groupBox10.Controls.Add(this.label11);
            this.groupBox10.Controls.Add(this.tB_Send_Msg);
            this.groupBox10.Controls.Add(this.label9);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(15, 582);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(602, 155);
            this.groupBox10.TabIndex = 6;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Send_Msg";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(443, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 18);
            this.label15.TabIndex = 13;
            this.label15.Text = "NumberOP : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(301, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 18);
            this.label14.TabIndex = 12;
            this.label14.Text = "Start Adr : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(144, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 18);
            this.label13.TabIndex = 11;
            this.label13.Text = "Func Code : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 18);
            this.label12.TabIndex = 10;
            this.label12.Text = "Slave Adr : ";
            // 
            // tB_numberofpoints
            // 
            this.tB_numberofpoints.Location = new System.Drawing.Point(554, 105);
            this.tB_numberofpoints.Name = "tB_numberofpoints";
            this.tB_numberofpoints.Size = new System.Drawing.Size(41, 24);
            this.tB_numberofpoints.TabIndex = 9;
            // 
            // tB_start_address
            // 
            this.tB_start_address.Location = new System.Drawing.Point(397, 105);
            this.tB_start_address.Name = "tB_start_address";
            this.tB_start_address.Size = new System.Drawing.Size(37, 24);
            this.tB_start_address.TabIndex = 8;
            // 
            // tB_func_code
            // 
            this.tB_func_code.Location = new System.Drawing.Point(249, 105);
            this.tB_func_code.Name = "tB_func_code";
            this.tB_func_code.Size = new System.Drawing.Size(38, 24);
            this.tB_func_code.TabIndex = 7;
            // 
            // tB_Slave_address
            // 
            this.tB_Slave_address.Location = new System.Drawing.Point(106, 105);
            this.tB_Slave_address.Name = "tB_Slave_address";
            this.tB_Slave_address.Size = new System.Drawing.Size(32, 24);
            this.tB_Slave_address.TabIndex = 6;
            // 
            // tB_CRC_Send
            // 
            this.tB_CRC_Send.Location = new System.Drawing.Point(106, 64);
            this.tB_CRC_Send.Name = "tB_CRC_Send";
            this.tB_CRC_Send.ReadOnly = true;
            this.tB_CRC_Send.Size = new System.Drawing.Size(183, 24);
            this.tB_CRC_Send.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 18);
            this.label11.TabIndex = 4;
            this.label11.Text = "CRC Send : ";
            // 
            // tB_Send_Msg
            // 
            this.tB_Send_Msg.Location = new System.Drawing.Point(106, 30);
            this.tB_Send_Msg.Name = "tB_Send_Msg";
            this.tB_Send_Msg.ReadOnly = true;
            this.tB_Send_Msg.Size = new System.Drawing.Size(476, 24);
            this.tB_Send_Msg.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Send_Msg : ";
            // 
            // groupBox13
            // 
            this.groupBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox13.Controls.Add(this.btn_Calculate);
            this.groupBox13.Controls.Add(this.tB_CRC_Receive);
            this.groupBox13.Controls.Add(this.label10);
            this.groupBox13.Controls.Add(this.tB_Receive_Msg);
            this.groupBox13.Controls.Add(this.label7);
            this.groupBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox13.Location = new System.Drawing.Point(636, 582);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(695, 155);
            this.groupBox13.TabIndex = 7;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Receive_Msg";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(138, 108);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(113, 40);
            this.btn_Calculate.TabIndex = 6;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // tB_CRC_Receive
            // 
            this.tB_CRC_Receive.Location = new System.Drawing.Point(138, 66);
            this.tB_CRC_Receive.Name = "tB_CRC_Receive";
            this.tB_CRC_Receive.ReadOnly = true;
            this.tB_CRC_Receive.Size = new System.Drawing.Size(183, 24);
            this.tB_CRC_Receive.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "CRC Receive : ";
            // 
            // tB_Receive_Msg
            // 
            this.tB_Receive_Msg.Location = new System.Drawing.Point(138, 30);
            this.tB_Receive_Msg.Name = "tB_Receive_Msg";
            this.tB_Receive_Msg.ReadOnly = true;
            this.tB_Receive_Msg.Size = new System.Drawing.Size(546, 24);
            this.tB_Receive_Msg.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Receive_Msg : ";
            // 
            // groupBox12
            // 
            this.groupBox12.BackColor = System.Drawing.Color.Orange;
            this.groupBox12.Controls.Add(this.tB_Data_Write);
            this.groupBox12.Controls.Add(this.label20);
            this.groupBox12.Controls.Add(this.label19);
            this.groupBox12.Controls.Add(this.tB_Start_Address_Write);
            this.groupBox12.Controls.Add(this.label18);
            this.groupBox12.Controls.Add(this.tB_Slave_Address_Write);
            this.groupBox12.Controls.Add(this.btn_Calculate_Write);
            this.groupBox12.Controls.Add(this.tB_Receive_Write);
            this.groupBox12.Controls.Add(this.label17);
            this.groupBox12.Controls.Add(this.tB_Send_Write);
            this.groupBox12.Controls.Add(this.label16);
            this.groupBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox12.Location = new System.Drawing.Point(449, 333);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(882, 243);
            this.groupBox12.TabIndex = 8;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Write Multiple Register";
            // 
            // tB_Data_Write
            // 
            this.tB_Data_Write.Location = new System.Drawing.Point(111, 105);
            this.tB_Data_Write.Name = "tB_Data_Write";
            this.tB_Data_Write.Size = new System.Drawing.Size(760, 24);
            this.tB_Data_Write.TabIndex = 19;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 108);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(103, 18);
            this.label20.TabIndex = 18;
            this.label20.Text = "Data Write : ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 188);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 18);
            this.label19.TabIndex = 17;
            this.label19.Text = "Start Adr : ";
            // 
            // tB_Start_Address_Write
            // 
            this.tB_Start_Address_Write.Location = new System.Drawing.Point(111, 185);
            this.tB_Start_Address_Write.Name = "tB_Start_Address_Write";
            this.tB_Start_Address_Write.Size = new System.Drawing.Size(95, 24);
            this.tB_Start_Address_Write.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 150);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(94, 18);
            this.label18.TabIndex = 15;
            this.label18.Text = "Slave Adr : ";
            // 
            // tB_Slave_Address_Write
            // 
            this.tB_Slave_Address_Write.Location = new System.Drawing.Point(111, 147);
            this.tB_Slave_Address_Write.Name = "tB_Slave_Address_Write";
            this.tB_Slave_Address_Write.Size = new System.Drawing.Size(95, 24);
            this.tB_Slave_Address_Write.TabIndex = 14;
            // 
            // btn_Calculate_Write
            // 
            this.btn_Calculate_Write.Location = new System.Drawing.Point(306, 162);
            this.btn_Calculate_Write.Name = "btn_Calculate_Write";
            this.btn_Calculate_Write.Size = new System.Drawing.Size(169, 40);
            this.btn_Calculate_Write.TabIndex = 7;
            this.btn_Calculate_Write.Text = "Calculate_Write";
            this.btn_Calculate_Write.UseVisualStyleBackColor = true;
            this.btn_Calculate_Write.Click += new System.EventHandler(this.btn_Calculate_Write_Click);
            // 
            // tB_Receive_Write
            // 
            this.tB_Receive_Write.Location = new System.Drawing.Point(121, 66);
            this.tB_Receive_Write.Name = "tB_Receive_Write";
            this.tB_Receive_Write.ReadOnly = true;
            this.tB_Receive_Write.Size = new System.Drawing.Size(248, 24);
            this.tB_Receive_Write.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(0, 66);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 18);
            this.label17.TabIndex = 5;
            this.label17.Text = "Receive_Msg : ";
            // 
            // tB_Send_Write
            // 
            this.tB_Send_Write.Location = new System.Drawing.Point(111, 27);
            this.tB_Send_Write.Name = "tB_Send_Write";
            this.tB_Send_Write.ReadOnly = true;
            this.tB_Send_Write.Size = new System.Drawing.Size(633, 24);
            this.tB_Send_Write.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 18);
            this.label16.TabIndex = 3;
            this.label16.Text = "Send_Msg : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1385, 770);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Serial COM Port IOT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBox_Paritybits;
        private System.Windows.Forms.ComboBox cBox_Stopbits;
        private System.Windows.Forms.ComboBox cBox_Databits;
        private System.Windows.Forms.ComboBox cBox_Baudrate;
        private System.Windows.Forms.ComboBox cBoxCOMPORT;
        private System.Windows.Forms.Button btn_senddata;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_Datasend;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblStatusCOM;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblDataOutLength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chBoxWrite;
        private System.Windows.Forms.CheckBox chBoxWriteLine;
        private System.Windows.Forms.Button btn_ClearDataOut;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chBox_usingEnter;
        private System.Windows.Forms.CheckBox chBox_usingButton;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label lblDataInLength;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_ClearDataIn;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.CheckBox chBox_AddToOldData;
        private System.Windows.Forms.CheckBox chBox_AlwaysUpdate;
        private System.Windows.Forms.TextBox tBox_Data_receive;
        private System.Windows.Forms.Button btn_LedOff;
        private System.Windows.Forms.Button btn_LedOn;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button led_on_1;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tB_CRC_Send;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tB_Send_Msg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.TextBox tB_CRC_Receive;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tB_Receive_Msg;
        private System.Windows.Forms.TextBox tB_Slave_address;
        private System.Windows.Forms.TextBox tB_func_code;
        private System.Windows.Forms.TextBox tB_numberofpoints;
        private System.Windows.Forms.TextBox tB_start_address;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button btn_Calculate_Write;
        private System.Windows.Forms.TextBox tB_Receive_Write;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tB_Send_Write;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tB_Slave_Address_Write;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tB_Start_Address_Write;
        private System.Windows.Forms.TextBox tB_Data_Write;
        private System.Windows.Forms.Label label20;
    }
}

