using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "RED")
            {
                label1.Text = "GREEN";
                label1.ForeColor = Color.Green;
                label2.Text = "BLUE";
                label2.ForeColor = Color.Blue;
                label3.Text = "RED";
                label3.ForeColor = Color.Red;
            }
            else if (label1.Text == "GREEN")
            {
                label1.Text = "BLUE";
                label1.ForeColor = Color.Blue;
                label2.Text = "RED";
                label2.ForeColor = Color.Red;
                label3.Text = "GREEN";
                label3.ForeColor = Color.Green;
            }
            else
            {
                label1.Text = "RED";
                label1.ForeColor = Color.Red;
                label2.Text = "GREEN";
                label2.ForeColor = Color.Green;
                label3.Text = "BLUE";
                label3.ForeColor = Color.Blue;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "RED")
            {
                label1.Text = "BLUE";
                label1.ForeColor = Color.Blue;
                label2.Text = "RED";
                label2.ForeColor = Color.Red;
                label3.Text = "GREEN";
                label3.ForeColor = Color.Green;
            }
            else if (label1.Text == "GREEN")
            {
                label1.Text = "RED";
                label1.ForeColor = Color.Red;
                label2.Text = "GREEN";
                label2.ForeColor = Color.Green;
                label3.Text = "BLUE";
                label3.ForeColor = Color.Blue;
            }
            else
            {
                label1.Text = "GREEN";
                label1.ForeColor = Color.Green;
                label2.Text = "BLUE";
                label2.ForeColor = Color.Blue;
                label3.Text = "RED";
                label3.ForeColor = Color.Red;
            }
        }
    }
}
