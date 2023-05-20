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
using System.Threading;

namespace SerialPortCOM_IOT
{
    public partial class Form1 : Form
    {
        string dataSend;
        string dataReceive;
        string sendWith;
        string led_on;
        string led_state;
        string led_state_total;
        byte slaveAddress;
        byte functionCode;
        ushort startAddress;
        ushort numberOfPoints;
        byte slaveAddress_write;
        byte functionCode_write;
        ushort startAddress_write;
        ushort numberOfPoints_write;
        byte[] values;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxCOMPORT.Items.AddRange(ports);

            btn_open.Enabled = true;
            btn_close.Enabled = false;

            btn_senddata.Enabled = false;
            chBoxWrite.Checked = true;
            chBoxWriteLine.Checked = false;
            sendWith = "Write";

            chBox_AlwaysUpdate.Checked = false;
            chBox_AddToOldData.Checked = true;
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBox_Baudrate.Text);
                //serialPort1.BaudRate = int.Parse(cBox_Baudrate.Text);
                serialPort1.DataBits = Convert.ToInt32(cBox_Databits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBox_Stopbits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBox_Paritybits.Text);

                serialPort1.Open();
                progressBar1.Value = 100;

                btn_open.Enabled = false;
                btn_close.Enabled = true;
                lblStatusCOM.Text = "ON";
            }
            
            catch (Exception err)
            {
                MessageBox.Show(err.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_open.Enabled = true;
                btn_close.Enabled = false;
                lblStatusCOM.Text = "OFF";
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
                btn_open.Enabled = true;
                btn_close.Enabled = false;
                lblStatusCOM.Text = "OFF";
            }
        }

        private void btn_senddata_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataSend = tB_Datasend.Text;
                if (sendWith == "Write")
                {
                    serialPort1.Write(dataSend);
                    //tB_Datasend.Text = "";
                }
                if (sendWith == "WriteLine")
                {
                    serialPort1.WriteLine(dataSend);
                    //tB_Datasend.Text = "";
                }

                led_state_total = "~" + led_state + "LF" + "CR";
                if (led_state_total.Length <= 13)
                {
                    serialPort1.Write(led_state_total);
                    led_state_total = "";
                    led_state = "";
                }
                else
                {
                    led_state_total = "";
                    led_state = "";
                }     
            }
        }

        private void btn_ClearDataOut_Click(object sender, EventArgs e)
        {
            if (tB_Datasend.Text != "")
            {
                tB_Datasend.Text = "";
            }
        }

        private void tB_Datasend_TextChanged(object sender, EventArgs e)
        {
            int dataOutLength = tB_Datasend.TextLength;
            lblDataOutLength.Text = string.Format("{0:00}", dataOutLength);
            if (chBox_usingEnter.Checked)
            {
                tB_Datasend.Text = tB_Datasend.Text.Replace(Environment.NewLine, "");
            }
        }

        private void chBox_usingButton_CheckedChanged(object sender, EventArgs e)
        {
            if (chBox_usingButton.Checked)
            {
                btn_senddata.Enabled = true;
            }
            else { btn_senddata.Enabled = false; }
        }

        private void tB_Datasend_KeyDown(object sender, KeyEventArgs e)
        {
            if (chBox_usingEnter.Checked)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (serialPort1.IsOpen)
                    {
                        dataSend = tB_Datasend.Text;
                        if (sendWith == "Write")
                        {
                            serialPort1.Write(dataSend);
                            //tB_Datasend.Text = "";
                        }
                        if (sendWith == "WriteLine")
                        {
                            serialPort1.WriteLine(dataSend);
                            //tB_Datasend.Text = "";
                        }
                    }
                }
            }
        }

        private void chBoxWriteLine_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxWriteLine.Checked)
            {
                sendWith = "WriteLine";
                chBoxWrite.Checked = false;
                chBoxWriteLine.Checked = true;
            }
        }

        private void chBoxWrite_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxWrite.Checked)
            {
                sendWith = "Write";
                chBoxWrite.Checked = true;
                chBoxWriteLine.Checked = false;
            }
        }

        /// <summary>
        /// Serial Port 1 Receive Data TextBox Receive (Not ModBus) 
        /// --> Change all in Form1.Designer.cs (Uncomment Line 364)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /*
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataReceive = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }


        private void ShowData(object sender, EventArgs e)
        {
            int dataReceiveLength = dataReceive.Length;
            lblDataInLength.Text = string.Format("{0:00}", dataReceiveLength);

            if (dataReceiveLength > 4)
            {
                if (tBox_Data_receive.Text != "")
                {
                    tBox_Data_receive.Text = "";
                }
            }

            if (chBox_AlwaysUpdate.Checked)
            {
                tBox_Data_receive.Text = dataReceive;
            }
            else if (chBox_AddToOldData.Checked)
            {
                tBox_Data_receive.Text += dataReceive;
                if ((tBox_Data_receive.TextLength % 10)/8 == 1 )
                {
                    tBox_Data_receive.Text += "\r\n";
                }

            }
        }
        */

        private void chBox_AlwaysUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (chBox_AlwaysUpdate.Checked)
            {
                chBox_AlwaysUpdate.Checked = true;
                chBox_AddToOldData.Checked = false;
            }
            else { chBox_AddToOldData.Checked = true; }
        }

        private void chBox_AddToOldData_CheckedChanged(object sender, EventArgs e)
        {
            if (chBox_AddToOldData.Checked)
            {
                chBox_AlwaysUpdate.Checked = false;
                chBox_AddToOldData.Checked = true;
            }
            else { chBox_AlwaysUpdate.Checked = true; }
        }

        private void btn_ClearDataIn_Click(object sender, EventArgs e)
        {
            if (tBox_Data_receive.Text != "")
            {
                tBox_Data_receive.Text = "";
            }
        }

        /// <summary>
        /// ModBus RTU (Master to Slave) Read Holding Register (3H)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    byte slaveAddress = byte.Parse(tB_Slave_address.Text);
                    byte functionCode = byte.Parse(tB_func_code.Text);
                    ushort startAddress = ushort.Parse(tB_start_address.Text);
                    ushort numberOfPoints = ushort.Parse(tB_numberofpoints.Text);

                    byte[] frame = this.ReadHoldingRegister(slaveAddress, functionCode, startAddress, numberOfPoints);
                    tB_Send_Msg.Text = this.Display(frame);
                    tB_CRC_Send.Text = string.Format("{0:X2} {1:X2}", frame[frame.Length - 2], frame[frame.Length - 1]); //Display CRC Send
                    serialPort1.Write(frame, 0, frame.Length);
                    Thread.Sleep(100);
                    if (serialPort1.BytesToRead >= 5)
                    {
                        frame = new byte[serialPort1.BytesToRead];
                        int rs = serialPort1.Read(frame, 0, frame.Length);
                        tB_Receive_Msg.Text = this.Display(frame);
                        tB_CRC_Receive.Text = string.Format("{0:X2} {1:X2}", frame[frame.Length - 2], frame[frame.Length - 1]); //Display CRC Receive
                    }
                }              
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Button Calculate_Write Click (10H)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Calculate_Write_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    int index = 0;
                    byte slaveAddress = byte.Parse(tB_Slave_Address_Write.Text);
                    byte functionCode = 16;
                    ushort startAddress = ushort.Parse(tB_Start_Address_Write.Text);
                    // Create String Array to get Data in TextBox
                    string[] str_array_data_write = tB_Data_Write.Text.Split(',');
                    // Create Ushort Array get Length of string array
                    ushort[] new_inputs = new ushort[str_array_data_write.Length] ;
                    // Replace value ushort array from string array
                    for (int i = 0; i < str_array_data_write.Length; i++)
                    {
                        new_inputs[i] = ushort.Parse(str_array_data_write[i]);
                    }              
                    // Ushort handled 
                    ushort[] handle_inputs = new ushort[(new_inputs.Length*2)];
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
                    tB_Send_Write.Text = this.Display(frame);
                    //tB_CRC_Send.Text = string.Format("{0:X2} {1:X2}", frame[frame.Length - 2], frame[frame.Length - 1]); //Display CRC Send
                    serialPort1.Write(frame, 0, frame.Length);
                    Thread.Sleep(100);
                    if (serialPort1.BytesToRead >= 5)
                    {
                        frame = new byte[serialPort1.BytesToRead];
                        int rs = serialPort1.Read(frame, 0, frame.Length);
                        tB_Receive_Write.Text = this.Display(frame);
                        //tB_CRC_Receive.Text = string.Format("{0:X2} {1:X2}", frame[frame.Length - 2], frame[frame.Length - 1]); //Display CRC Receive
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Function: Read Holding Register (3H)
        /// </summary>
        /// <param name="slaveAddress">Slave Address</param>
        /// <param name="functionCode">Function</param>
        /// <param name="startAddress">Starting Address</param>
        /// <param name="numberOfPoints">Quantity of Register</param>
        /// <returns></returns>
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

        /// <summary>
        /// Write Multiple Register (10H)
        /// </summary>
        /// <param name="slaveAddress"></param>
        /// <param name="functionCode"></param>
        /// <param name="startAddress"></param>
        /// <param name="values"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Check CRC
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Display Frame: 
        /// </summary>
        /// <param name="frame">frame: byte[]</param>
        /// <returns>result: string</returns>
        private string Display(byte[] frame)
        {
            string result = string.Empty;
            foreach (byte item in frame)
            {
                result += string.Format("{0:X2} ", item);
            }
            return result;
        }

        /// <summary>
        /// Serial Port Uart On Off Led (8Led) 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_LedOn_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                led_state = "11111111";
            }
        }

        private void btn_LedOff_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                led_state = "00000000";
            }
        }

        private void led_on_1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write((string)"a");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write((string)"1");
            }
        }
    }
}
 
