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

namespace SerialCommunicationSTM32
{
    public partial class Form1 : Form
    {
        byte signal = 0x00;
        public Form1()
        {
            InitializeComponent();
            getAvailiablePorts();
            String[] baudRate = { "1200", "2400", "4800", "9600", "11520", "19200" };
            comboBox_baudRate.Items.AddRange(baudRate);
        }
        // Phát hiện cổng trên thiết bị
        void getAvailiablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            comboBox_portName.Items.AddRange(ports);
        }
        
        // open ports
        private void button_openPort_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_portName.Text == "" || comboBox_baudRate.Text == "")
                {
                    textBox_send.Text = "Please select port settings";
                }
                else
                {
                    serialPort1.PortName = comboBox_portName.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboBox_baudRate.Text);
                    serialPort1.Open();
                    progressBar_status.Value = 100;
                    button_send.Enabled = true;
                    button_read.Enabled = true;
                    textBox_send.Enabled = true;
                    button_openPort.Enabled = false;
                    button_closePort.Enabled = true;

                    button_on1.Enabled = true;
                    button_on2.Enabled = true;
                    button_on3.Enabled = true;
                    button_on4.Enabled = true;
                    button_on5.Enabled = true;
                    button_on6.Enabled = true;
                    button_on7.Enabled = true;
                    button_on8.Enabled = true;

                    button_off1.Enabled = true;
                    button_off2.Enabled = true;
                    button_off3.Enabled = true;
                    button_off4.Enabled = true;
                    button_off5.Enabled = true;
                    button_off6.Enabled = true;
                    button_off7.Enabled = true;
                    button_off8.Enabled = true;

                    button_sw1.Enabled = true;
                    button_sw2.Enabled = true;
                    button_sw3.Enabled = true;
                    button_sw4.Enabled = true;
                    button_sw5.Enabled = true;
                    button_sw6.Enabled = true;
                    button_sw7.Enabled = true;
                    button_sw8.Enabled = true;
                }
            }
            catch (UnauthorizedAccessException)
            {
                textBox_receive.Text = "Unauthorize access";
            }
        }

        // close ports
        private void button_closePort_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            progressBar_status.Value = 0;
            button_send.Enabled = false;
            button_read.Enabled = false;
            textBox_send.Enabled = false;
            button_openPort.Enabled = true;
            button_closePort.Enabled = false;

            button_on1.Enabled = false;
            button_on2.Enabled = false;
            button_on3.Enabled = false;
            button_on4.Enabled = false;
            button_on5.Enabled = false;
            button_on6.Enabled = false;
            button_on7.Enabled = false;
            button_on8.Enabled = false;
            button_off1.Enabled = false;
            button_off2.Enabled = false;
            button_off3.Enabled = false;
            button_off4.Enabled = false;
            button_off5.Enabled = false;
            button_off6.Enabled = false;
            button_off7.Enabled = false;
            button_off8.Enabled = false;
        }

        // send string
        private void button_send_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(textBox_send.Text);
            textBox_send.Text = "";
        }


        // receive string
        private void button_read_Click(object sender, EventArgs e)
        {
            try
            {
                textBox_receive.Text = serialPort1.ReadExisting();
            }
            catch (TimeoutException)
            {
                textBox_receive.Text = "Timeout Exception";
            }
        }
        //========================================================================================
        private void button_on1_Click(object sender, EventArgs e)
        {           
            signal |= (byte) 1;
            string myString = signal.ToString();
            serialPort1.WriteLine("1");
            textBox_send.Text = "";
        }

        private void button_on2_Click(object sender, EventArgs e)
        {
            signal |= (byte)(1 << 1);
            string myString = signal.ToString();
            serialPort1.WriteLine("2");
            textBox_send.Text = "";
        }

        private void button_on3_Click(object sender, EventArgs e)
        {
            signal |= (byte)(1 << 2);
            string myString = signal.ToString();
            serialPort1.WriteLine("3");
            textBox_send.Text = "";
        }

        private void button_on4_Click(object sender, EventArgs e)
        {
            signal |= (byte)(1 << 3);
            string myString = signal.ToString();
            serialPort1.WriteLine("4");
            textBox_send.Text = "";
        }

        private void button_on5_Click(object sender, EventArgs e)
        {
            signal |= (byte)(1 << 4);
            string myString = signal.ToString();
            serialPort1.WriteLine("5");
            textBox_send.Text = "";
        }

        private void button_on6_Click(object sender, EventArgs e)
        {
            signal |= (byte)(1 << 5);
            string myString = signal.ToString();
            serialPort1.WriteLine("6");
            textBox_send.Text = "";
        }

        private void button_on7_Click(object sender, EventArgs e)
        {
            signal |= (byte)(1 << 6);
            string myString = signal.ToString();
            serialPort1.WriteLine("7");
            textBox_send.Text = "";
        }

        private void button_on8_Click(object sender, EventArgs e)
        {
            signal |= (byte)(1 << 7);
            string myString = signal.ToString();
            serialPort1.WriteLine("8");
            textBox_send.Text = "";
        }
        //========================================================================================
        private void button_off1_Click(object sender, EventArgs e)
        {
            signal &= unchecked((byte)(~(1 << 0)));
            string myString = signal.ToString();
            serialPort1.WriteLine("a");
            textBox_send.Text = "";
        }

        private void button_off2_Click(object sender, EventArgs e)
        {
            signal &= unchecked((byte)(~(1 << 1)));
            //signal &= ~(1 << 1); // 
            string myString = signal.ToString(); 
            serialPort1.WriteLine("b"); 
            textBox_send.Text = ""; 
        }

        private void button_off3_Click(object sender, EventArgs e)
        {
            signal &= unchecked((byte)(~(1 << 2)));
            string myString = signal.ToString(); 
            serialPort1.WriteLine("c"); 
            textBox_send.Text = "";
        }

        private void button_off4_Click(object sender, EventArgs e)
        {
            signal &= unchecked((byte)(~(1 << 3)));
            string myString = signal.ToString();
            serialPort1.WriteLine("d");
            textBox_send.Text = "";
        }

        private void button_off5_Click(object sender, EventArgs e)
        {
            signal &= unchecked((byte)(~(1 << 4)));
            string myString = signal.ToString();
            serialPort1.WriteLine("e");
            textBox_send.Text = "";
        }

        private void button_off6_Click(object sender, EventArgs e)
        {
            signal &= unchecked((byte)(~(1 << 5)));
            string myString = signal.ToString();
            serialPort1.WriteLine("f");
            textBox_send.Text = "";
        }

        private void button_off7_Click(object sender, EventArgs e)
        {
            signal &= unchecked((byte)(~(1 << 6)));
            string myString = signal.ToString();
            serialPort1.WriteLine("g");
            textBox_send.Text = "";
        }

        private void button_off8_Click(object sender, EventArgs e)
        {
            signal &= unchecked((byte)(~(1 << 7)));
            string myString = signal.ToString();
            serialPort1.WriteLine("h");
            textBox_send.Text = "";
        }
        //========================================================================================
        private void button_sw1_Click(object sender, EventArgs e)
        {
            byte mask = (byte) 1;// tạo mặt nạ với bit thứ n được đặt về 1
            signal = (byte)(signal ^ mask); // đảo giá trị của bit thứ n trong signal  --Cổng XOR--
            string myString = signal.ToString();
            serialPort1.WriteLine(myString);
            textBox_send.Text = "";
        }

        private void button_sw2_Click(object sender, EventArgs e)
        {
            byte mask = (byte)(1 << 1); // tạo mặt nạ với bit thứ n được đặt về 1
            signal = (byte)(signal ^ mask); // đảo giá trị của bit thứ n trong signal
            string myString = signal.ToString();
            serialPort1.WriteLine(myString);
            textBox_send.Text = "";
        }

        private void button_sw3_Click(object sender, EventArgs e)
        {
            byte mask = (byte)(1 << 2); // tạo mặt nạ với bit thứ n được đặt về 1
            signal = (byte)(signal ^ mask); // đảo giá trị của bit thứ n trong signal
            string myString = signal.ToString();
            serialPort1.WriteLine(myString);
            textBox_send.Text = "";
        }

        private void button_sw4_Click(object sender, EventArgs e)
        {
            byte mask = (byte)(1 << 3); // tạo mặt nạ với bit thứ n được đặt về 1
            signal = (byte)(signal ^ mask); // đảo giá trị của bit thứ n trong signal
            string myString = signal.ToString();
            serialPort1.WriteLine(myString);
            textBox_send.Text = "";
        }

        private void button_sw5_Click(object sender, EventArgs e)
        {
            byte mask = (byte)(1 << 4); // tạo mặt nạ với bit thứ n được đặt về 1
            signal = (byte)(signal ^ mask); // đảo giá trị của bit thứ n trong signal
            string myString = signal.ToString();
            serialPort1.WriteLine(myString);
            textBox_send.Text = "";
        }

        private void button_sw6_Click(object sender, EventArgs e)
        {
            byte mask = (byte)(1 << 5); // tạo mặt nạ với bit thứ n được đặt về 1
            signal = (byte)(signal ^ mask); // đảo giá trị của bit thứ n trong signal
            string myString = signal.ToString();
            serialPort1.WriteLine(myString);
            textBox_send.Text = "";
        }

        private void button_sw7_Click(object sender, EventArgs e)
        {
            byte mask = (byte)(1 << 6); // tạo mặt nạ với bit thứ n được đặt về 1
            signal = (byte)(signal ^ mask); // đảo giá trị của bit thứ n trong signal
            string myString = signal.ToString();
            serialPort1.WriteLine(myString);
            textBox_send.Text = "";
        }

        private void button_sw8_Click(object sender, EventArgs e)
        {
            byte mask = (byte)(1 << 7); // tạo mặt nạ với bit thứ n được đặt về 1
            signal = (byte)(signal ^ mask); // đảo giá trị của bit thứ n trong signal
            string myString = signal.ToString();
            serialPort1.WriteLine(myString);
            textBox_send.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
