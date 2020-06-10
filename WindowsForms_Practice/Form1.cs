using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            label3.Text = "Result: ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string input1 = textBox1.Text;
           string input2 = textBox2.Text;
           int value1 = int.Parse(input1);
           int value2 = int.Parse(input2);
           int value3 = value1 + value2;
           label3.Text = "Result: " + value3.ToString();
        }
    }
}
