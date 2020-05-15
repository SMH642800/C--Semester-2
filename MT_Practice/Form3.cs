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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b, c;
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);

                if (a > 0 && b > 0)
                {
                    c = b / (a * a);
                    textBox3.Text = c.ToString();
                }
                else
                {
                    string Error = "身高和體重的數值必須大於0";
                    MessageBox.Show(Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
