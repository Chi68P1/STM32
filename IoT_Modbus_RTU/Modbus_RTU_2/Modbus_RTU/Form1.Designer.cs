namespace Modbus_RTU
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
            this.progressBar_status = new System.Windows.Forms.ProgressBar();
            this.button_openPort = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_numberOfPoints = new System.Windows.Forms.TextBox();
            this.textBox_startAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_functionCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_slaveAddress = new System.Windows.Forms.TextBox();
            this.textBox_crcSend = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_messageSend = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_messageReceive = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_crcReceive = new System.Windows.Forms.TextBox();
            this.button_closePort = new System.Windows.Forms.Button();
            this.button_calculate = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_startAddress2 = new System.Windows.Forms.TextBox();
            this.textBox_slaveAddress2 = new System.Windows.Forms.TextBox();
            this.textBox_messageSend2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_messageReceive2 = new System.Windows.Forms.TextBox();
            this.textBox_dataWrite = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button_calculate2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_portName
            // 
            this.comboBox_portName.FormattingEnabled = true;
            this.comboBox_portName.Location = new System.Drawing.Point(86, 42);
            this.comboBox_portName.Name = "comboBox_portName";
            this.comboBox_portName.Size = new System.Drawing.Size(134, 21);
            this.comboBox_portName.TabIndex = 0;
            // 
            // comboBox_baudRate
            // 
            this.comboBox_baudRate.FormattingEnabled = true;
            this.comboBox_baudRate.Location = new System.Drawing.Point(284, 42);
            this.comboBox_baudRate.Name = "comboBox_baudRate";
            this.comboBox_baudRate.Size = new System.Drawing.Size(134, 21);
            this.comboBox_baudRate.TabIndex = 1;
            this.comboBox_baudRate.Text = "19200";
            // 
            // progressBar_status
            // 
            this.progressBar_status.Location = new System.Drawing.Point(490, 42);
            this.progressBar_status.Name = "progressBar_status";
            this.progressBar_status.Size = new System.Drawing.Size(168, 22);
            this.progressBar_status.TabIndex = 2;
            // 
            // button_openPort
            // 
            this.button_openPort.Location = new System.Drawing.Point(741, 42);
            this.button_openPort.Name = "button_openPort";
            this.button_openPort.Size = new System.Drawing.Size(109, 84);
            this.button_openPort.TabIndex = 3;
            this.button_openPort.Text = "Open Port";
            this.button_openPort.UseVisualStyleBackColor = true;
            this.button_openPort.Click += new System.EventHandler(this.button_openPort_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_numberOfPoints);
            this.groupBox1.Controls.Add(this.textBox_startAddress);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox_functionCode);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_slaveAddress);
            this.groupBox1.Controls.Add(this.textBox_crcSend);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_messageSend);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(86, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 139);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send here";
            // 
            // textBox_numberOfPoints
            // 
            this.textBox_numberOfPoints.Enabled = false;
            this.textBox_numberOfPoints.Location = new System.Drawing.Point(558, 95);
            this.textBox_numberOfPoints.Name = "textBox_numberOfPoints";
            this.textBox_numberOfPoints.Size = new System.Drawing.Size(32, 20);
            this.textBox_numberOfPoints.TabIndex = 19;
            // 
            // textBox_startAddress
            // 
            this.textBox_startAddress.Enabled = false;
            this.textBox_startAddress.Location = new System.Drawing.Point(406, 95);
            this.textBox_startAddress.Name = "textBox_startAddress";
            this.textBox_startAddress.Size = new System.Drawing.Size(32, 20);
            this.textBox_startAddress.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Start Address";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(464, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Number of Points";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_functionCode
            // 
            this.textBox_functionCode.Enabled = false;
            this.textBox_functionCode.Location = new System.Drawing.Point(260, 95);
            this.textBox_functionCode.Name = "textBox_functionCode";
            this.textBox_functionCode.Size = new System.Drawing.Size(32, 20);
            this.textBox_functionCode.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Function Code";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_slaveAddress
            // 
            this.textBox_slaveAddress.Enabled = false;
            this.textBox_slaveAddress.Location = new System.Drawing.Point(118, 95);
            this.textBox_slaveAddress.Name = "textBox_slaveAddress";
            this.textBox_slaveAddress.Size = new System.Drawing.Size(32, 20);
            this.textBox_slaveAddress.TabIndex = 13;
            // 
            // textBox_crcSend
            // 
            this.textBox_crcSend.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_crcSend.Enabled = false;
            this.textBox_crcSend.Location = new System.Drawing.Point(118, 62);
            this.textBox_crcSend.Name = "textBox_crcSend";
            this.textBox_crcSend.ReadOnly = true;
            this.textBox_crcSend.Size = new System.Drawing.Size(174, 20);
            this.textBox_crcSend.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Slave Address";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_messageSend
            // 
            this.textBox_messageSend.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_messageSend.Enabled = false;
            this.textBox_messageSend.Location = new System.Drawing.Point(118, 30);
            this.textBox_messageSend.Name = "textBox_messageSend";
            this.textBox_messageSend.ReadOnly = true;
            this.textBox_messageSend.Size = new System.Drawing.Size(472, 20);
            this.textBox_messageSend.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Message_Send";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "CRC_Send";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Port Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Baud Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Status";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_messageReceive);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBox_crcReceive);
            this.groupBox2.Location = new System.Drawing.Point(86, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(607, 110);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Receive Message";
            // 
            // textBox_messageReceive
            // 
            this.textBox_messageReceive.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_messageReceive.Enabled = false;
            this.textBox_messageReceive.Location = new System.Drawing.Point(118, 26);
            this.textBox_messageReceive.Name = "textBox_messageReceive";
            this.textBox_messageReceive.ReadOnly = true;
            this.textBox_messageReceive.Size = new System.Drawing.Size(472, 20);
            this.textBox_messageReceive.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "CRC_Receive";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Message_Receive";
            // 
            // textBox_crcReceive
            // 
            this.textBox_crcReceive.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_crcReceive.Enabled = false;
            this.textBox_crcReceive.Location = new System.Drawing.Point(118, 58);
            this.textBox_crcReceive.Name = "textBox_crcReceive";
            this.textBox_crcReceive.ReadOnly = true;
            this.textBox_crcReceive.Size = new System.Drawing.Size(174, 20);
            this.textBox_crcReceive.TabIndex = 24;
            // 
            // button_closePort
            // 
            this.button_closePort.Enabled = false;
            this.button_closePort.Location = new System.Drawing.Point(741, 292);
            this.button_closePort.Name = "button_closePort";
            this.button_closePort.Size = new System.Drawing.Size(109, 84);
            this.button_closePort.TabIndex = 8;
            this.button_closePort.Text = "Close Port";
            this.button_closePort.UseVisualStyleBackColor = true;
            this.button_closePort.Click += new System.EventHandler(this.button_closePort_Click);
            // 
            // button_calculate
            // 
            this.button_calculate.Enabled = false;
            this.button_calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_calculate.Location = new System.Drawing.Point(741, 167);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(109, 84);
            this.button_calculate.TabIndex = 9;
            this.button_calculate.Text = "Calculate";
            this.button_calculate.UseVisualStyleBackColor = true;
            this.button_calculate.Click += new System.EventHandler(this.button_calculate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_dataWrite);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.textBox_startAddress2);
            this.groupBox3.Controls.Add(this.textBox_slaveAddress2);
            this.groupBox3.Controls.Add(this.textBox_messageSend2);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBox_messageReceive2);
            this.groupBox3.Location = new System.Drawing.Point(86, 408);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(607, 138);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Write Mutiple Register";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(477, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Start Address";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(325, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Slave Address";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_startAddress2
            // 
            this.textBox_startAddress2.Enabled = false;
            this.textBox_startAddress2.Location = new System.Drawing.Point(558, 57);
            this.textBox_startAddress2.Name = "textBox_startAddress2";
            this.textBox_startAddress2.Size = new System.Drawing.Size(32, 20);
            this.textBox_startAddress2.TabIndex = 25;
            // 
            // textBox_slaveAddress2
            // 
            this.textBox_slaveAddress2.Enabled = false;
            this.textBox_slaveAddress2.Location = new System.Drawing.Point(406, 58);
            this.textBox_slaveAddress2.Name = "textBox_slaveAddress2";
            this.textBox_slaveAddress2.Size = new System.Drawing.Size(32, 20);
            this.textBox_slaveAddress2.TabIndex = 20;
            // 
            // textBox_messageSend2
            // 
            this.textBox_messageSend2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_messageSend2.Enabled = false;
            this.textBox_messageSend2.Location = new System.Drawing.Point(118, 26);
            this.textBox_messageSend2.Name = "textBox_messageSend2";
            this.textBox_messageSend2.ReadOnly = true;
            this.textBox_messageSend2.Size = new System.Drawing.Size(472, 20);
            this.textBox_messageSend2.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Message_Receive";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Message_Send";
            // 
            // textBox_messageReceive2
            // 
            this.textBox_messageReceive2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_messageReceive2.Enabled = false;
            this.textBox_messageReceive2.Location = new System.Drawing.Point(118, 58);
            this.textBox_messageReceive2.Name = "textBox_messageReceive2";
            this.textBox_messageReceive2.ReadOnly = true;
            this.textBox_messageReceive2.Size = new System.Drawing.Size(174, 20);
            this.textBox_messageReceive2.TabIndex = 24;
            // 
            // textBox_dataWrite
            // 
            this.textBox_dataWrite.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_dataWrite.Enabled = false;
            this.textBox_dataWrite.Location = new System.Drawing.Point(118, 96);
            this.textBox_dataWrite.Name = "textBox_dataWrite";
            this.textBox_dataWrite.Size = new System.Drawing.Size(472, 20);
            this.textBox_dataWrite.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 96);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "Data Write";
            // 
            // button_calculate2
            // 
            this.button_calculate2.Enabled = false;
            this.button_calculate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_calculate2.Location = new System.Drawing.Point(741, 431);
            this.button_calculate2.Name = "button_calculate2";
            this.button_calculate2.Size = new System.Drawing.Size(109, 84);
            this.button_calculate2.TabIndex = 26;
            this.button_calculate2.Text = "Calculate2";
            this.button_calculate2.UseVisualStyleBackColor = true;
            this.button_calculate2.Click += new System.EventHandler(this.button_calculate2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 612);
            this.Controls.Add(this.button_calculate2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_calculate);
            this.Controls.Add(this.button_closePort);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_openPort);
            this.Controls.Add(this.progressBar_status);
            this.Controls.Add(this.comboBox_baudRate);
            this.Controls.Add(this.comboBox_portName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_portName;
        private System.Windows.Forms.ComboBox comboBox_baudRate;
        private System.Windows.Forms.ProgressBar progressBar_status;
        private System.Windows.Forms.Button button_openPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_startAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_functionCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_slaveAddress;
        private System.Windows.Forms.TextBox textBox_crcSend;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_messageSend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_numberOfPoints;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_messageReceive;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_crcReceive;
        private System.Windows.Forms.Button button_closePort;
        private System.Windows.Forms.Button button_calculate;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_startAddress2;
        private System.Windows.Forms.TextBox textBox_slaveAddress2;
        private System.Windows.Forms.TextBox textBox_messageSend2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_messageReceive2;
        private System.Windows.Forms.TextBox textBox_dataWrite;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button_calculate2;
    }
}

