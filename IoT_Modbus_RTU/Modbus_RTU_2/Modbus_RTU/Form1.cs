using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading; // Thread.Sleep(100);

namespace Modbus_RTU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getAvailiablePorts();
            String[] baudRate = { "1200", "2400", "4800", "9600", "11520", "19200", "28800","38400"};
            comboBox_baudRate.Items.AddRange(baudRate);
        }

        // Phát hiện cổng trên thiết bị
        void getAvailiablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            comboBox_portName.Items.AddRange(ports);
        }

        // Open ports
        private void button_openPort_Click_1(object sender, EventArgs e)
        {
            try
            {
                textBox_messageSend.Text = "";
                textBox_crcSend.Text = "";
                textBox_messageReceive.Text = "";
                textBox_crcReceive.Text = "";

                textBox_slaveAddress.Text = "";
                textBox_functionCode.Text = "";
                textBox_startAddress.Text = "";
                textBox_numberOfPoints.Text = "";

                textBox_slaveAddress2.Text = "";
                textBox_messageReceive2.Text = "";
                textBox_startAddress2.Text = "";
                textBox_messageSend2.Text = "";
                textBox_dataWrite.Text = "";

                serialPort1.PortName = comboBox_portName.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox_baudRate.Text);
                serialPort1.Open();
                progressBar_status.Value = 100;
                button_calculate.Enabled = true;
                button_calculate2.Enabled = true;
                button_openPort.Enabled = false;
                button_closePort.Enabled = true;

                textBox_slaveAddress.Enabled = true;
                textBox_functionCode.Enabled = true;
                textBox_startAddress.Enabled = true;
                textBox_numberOfPoints.Enabled = true;

                textBox_slaveAddress2.Enabled = true;
                textBox_dataWrite.Enabled = true;
                textBox_startAddress2.Enabled = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Close ports
        private void button_closePort_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            progressBar_status.Value = 0;
            button_calculate.Enabled = false;
            button_calculate2.Enabled = false;
            button_openPort.Enabled = true;
            button_closePort.Enabled = false;

            textBox_slaveAddress.Enabled = false;
            textBox_functionCode.Enabled = false;
            textBox_startAddress.Enabled = false;
            textBox_numberOfPoints.Enabled = false;

            textBox_slaveAddress2.Enabled = false;
            textBox_dataWrite.Enabled = false;
            textBox_startAddress2.Enabled = false;
        }

        // Check CRC
        private byte[] CRC16(byte[] data)
        {
            byte[] checkSum = new byte[2];
            ushort reg_crc = 0xFFFF;
            for (int i = 0; i < data.Length - 2; i++)
            {
                reg_crc ^= data[i];
                for (int j = 0; j < 8; j++)
                {
                    if ((reg_crc & 0x01) == 1)
                    {
                        reg_crc = (ushort)((reg_crc >> 1) ^ 0xA001);
                    }
                    else
                    {
                        reg_crc = (ushort)(reg_crc >> 1);
                    }
                }
            }

            checkSum[1] = (byte)((reg_crc >> 8) & 0xFF);
            checkSum[0] = (byte)(reg_crc & 0xFF);
            return checkSum;
        }

        // Function: Read Holding Register (3H)
        private byte[] ReadHoldingRegister(byte slaveAddress, byte functionCode, ushort startAddress, ushort numberOfPoints)
        {
            byte[] frame = new byte[8]; // total 8 Bytes
            frame[0] = slaveAddress; // Slave Address
            frame[1] = functionCode; // Function
            frame[2] = (byte)(startAddress >> 8); // Starting Address Hi
            frame[3] = (byte)startAddress; //  Starting Address Lo
            frame[4] = (byte)(numberOfPoints >> 8); // Quantity of Register Hi
            frame[5] = (byte)numberOfPoints; // Quantity of Register Lo
            byte[] checkSum = this.CRC16(frame);
            frame[6] = checkSum[0]; // Error Check Lo
            frame[7] = checkSum[1]; // Error Check Hi
            return frame;
        }
    
        // Display Frame:
        private string Display(byte[] frame)
        {
            string result = string.Empty;
            foreach (byte item in frame)
            {
                result += string.Format("{0:X2}  ", item);
            }
            return result;
        }

        /// Write Multiple Register (10H)
        private byte[] WriteMultipleRegister(byte slaveAddress, byte functionCode, ushort startAddress, byte[] values)
        {
            ushort numberOfPoints_write = (ushort)((values.Length) / 2);
            byte[] frame = new byte[9 + values.Length]; // total 8 Bytes
            frame[0] = slaveAddress; // Slave Address
            frame[1] = functionCode; // Function
            frame[2] = (byte)(startAddress >> 8); // Starting Address Hi
            frame[3] = (byte)startAddress; //  Starting Address Lo
            frame[4] = (byte)(numberOfPoints_write >> 8); // Quantity of Register Hi
            frame[5] = (byte)numberOfPoints_write; // Quantity of Register Lo
            frame[6] = (byte)(values.Length); // Byte Count
            Array.Copy(values, 0, frame, 7, values.Length); // Data
            byte[] checkSum = this.CRC16(frame); // Call CRC Calculate
            frame[frame.Length - 2] = checkSum[0]; // Error Check Lo
            frame[frame.Length - 1] = checkSum[1]; // Error Check Hi
            return frame;
        }

        // Calculate
        private void button_calculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    byte slaveAddress = byte.Parse(textBox_slaveAddress.Text);
                    byte functionCode = byte.Parse(textBox_functionCode.Text);
                    ushort startAddress = ushort.Parse(textBox_startAddress.Text);
                    ushort numberOfPoints = ushort.Parse(textBox_numberOfPoints.Text);

                    byte[] frame = this.ReadHoldingRegister(slaveAddress, functionCode, startAddress, numberOfPoints);
                    textBox_messageSend.Text = this.Display(frame);
                    textBox_crcSend.Text = string.Format("{0:X2}  {1:X2}", frame[frame.Length - 2], frame[frame.Length - 1]); //Display CRC Send
                    serialPort1.Write(frame, 0, frame.Length);
                    Thread.Sleep(100);
                    if (serialPort1.BytesToRead >= 5)
                    {
                        frame = new byte[serialPort1.BytesToRead];
                        int rs = serialPort1.Read(frame, 0, frame.Length);
                        textBox_messageReceive.Text = this.Display(frame);
                        textBox_crcReceive.Text = string.Format("{0:X2}  {1:X2}", frame[frame.Length - 2], frame[frame.Length - 1]); //Display CRC Receive
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_calculate2_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    int index = 0;
                    byte slaveAddress = byte.Parse(textBox_slaveAddress2.Text);
                    byte functionCode = 16;
                    ushort startAddress = ushort.Parse(textBox_startAddress2.Text);
                    // Create String Array to get Data in TextBox
                    string[] str_array_data_write = textBox_dataWrite.Text.Split(',');
                    // Create Ushort Array get Length of string array
                    ushort[] new_inputs = new ushort[str_array_data_write.Length];
                    // Replace value ushort array from string array
                    for (int i = 0; i < str_array_data_write.Length; i++)
                    {
                        new_inputs[i] = ushort.Parse(str_array_data_write[i]);
                    }
                    // Ushort handled 
                    ushort[] handle_inputs = new ushort[(new_inputs.Length * 2)];
                    for (int i = 0; i < new_inputs.Length; i++)
                    {
                        byte data_high = (byte)(new_inputs[i] >> 8);
                        byte data_low = (byte)new_inputs[i];
                        handle_inputs[index] = (ushort)data_high;
                        handle_inputs[index + 1] = (ushort)data_low;
                        index = index + 2;
                    }
                    // Add ushort handled array to byte array
                    byte[] values = handle_inputs.Select(x => (byte)x).ToArray();

                    byte[] frame = this.WriteMultipleRegister(slaveAddress, functionCode, startAddress, values);
                    textBox_messageSend2.Text = this.Display(frame);
                    //tB_CRC_Send.Text = string.Format("{0:X2} {1:X2}", frame[frame.Length - 2], frame[frame.Length - 1]); //Display CRC Send
                    serialPort1.Write(frame, 0, frame.Length);
                    Thread.Sleep(100);
                    if (serialPort1.BytesToRead >= 5)
                    {
                        frame = new byte[serialPort1.BytesToRead];
                        int rs = serialPort1.Read(frame, 0, frame.Length);
                        textBox_messageReceive2.Text = this.Display(frame);
                        //tB_CRC_Receive.Text = string.Format("{0:X2} {1:X2}", frame[frame.Length - 2], frame[frame.Length - 1]); //Display CRC Receive
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
