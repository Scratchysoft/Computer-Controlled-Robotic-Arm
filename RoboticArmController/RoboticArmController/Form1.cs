using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboticArmController
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialPort1.Open();
        }

        public void write(string command)
        {
            serialPort1.WriteLine(command);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            write("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            write("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            write("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            write("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            write("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            write("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            write("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            write("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort1.PortName = textBox1.Text;
            serialPort1.Open();
        }
    }
}
