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

namespace SerialCommunication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getAvailiablePorts();
        }
        void getAvailiablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            comboBox_portName.Items.AddRange(ports);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_portName.Text == "" || comboBox2.Text == "")
                {
                    textBox2.Text = "Please select port settings";
                }
                else
                {
                    serialPort1.PortName = comboBox_portName.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
                    serialPort1.Open();
                    progressBar1.Value = 100;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    textBox1.Enabled = true;
                    button3.Enabled = false;
                    button4.Enabled = true;
                }
            }
            catch (UnauthorizedAccessException)
            {
                textBox2.Text = "Unauthorize access";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            progressBar1.Value = 0;
            button1.Enabled = false;
            button2.Enabled = false;
            button4.Enabled = false;
            button3.Enabled = true;
            textBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(textBox1.Text);
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = serialPort1.ReadExisting();
            }
            catch (TimeoutException)
            {
                textBox2.Text = "Timeout Exception";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
