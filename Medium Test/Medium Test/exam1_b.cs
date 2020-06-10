using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medium_Test
{
    public partial class exam1_b : Form
    {
        private Form1 form1;

        public exam1_b(Form1 formTemp)
        {
            InitializeComponent();
            form1 = formTemp;
        }

        private void exam1_b_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ans;

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("The number box can't be empty!");
                return;
            }

            double x, a, b;
            bool result1 = double.TryParse(textBox1.Text, out x);
            bool result2 = double.TryParse(textBox2.Text, out a);
            bool result3 = double.TryParse(textBox3.Text, out b);

            if (!result1 || !result2 || !result3)
            {
                MessageBox.Show("Please enter the numbers!");
                return;
            }
            ans = a * Math.Pow(x, 4) + b * Math.Pow(x, 2) - Math.Pow(x, 1);
            label8.Text = ans.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ans;

            if (textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("The number box can't be empty!");
                return;
            }

            double x, a, b;
            bool result5 = double.TryParse(textBox8.Text, out x);
            bool result6 = double.TryParse(textBox7.Text, out a);
            bool result7 = double.TryParse(textBox6.Text, out b);

            if (!result5 || !result6 || !result7)
            {
                MessageBox.Show("Please enter the numbers!");
                return;
            }
            ans = Math.Abs(a * Math.Pow(x, 3) + b * Math.Pow(x, 2)) + Math.Pow(x, 0.5);
            label9.Text = ans.ToString();
        }
    }
}
