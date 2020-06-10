using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MT_Practice
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            label3.Text = "";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int x = textBox1.Text.Length;
            int y = textBox2.Text.Length;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
