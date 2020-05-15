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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b, c;
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                c = double.Parse(textBox3.Text);

                double D, an1, an2;
                D = (b * b) - 4 * a * c;
                if (D > 0)
                {
                    an1 = (-b + Math.Sqrt(D)) / (2 * a);
                    an2 = (-b - Math.Sqrt(D)) / (2 * a);
                    textBox4.Text = "x1= "+an1.ToString()+"\r\n"+"x2= "+an2.ToString() ;
                }
                else if (D == 0.0)
                {
                    an1 = (-b) / (2 * a);
                    an2 = an1;
                    textBox4.Text = "x1= " + an1.ToString() + "\r\n" + "x2= " + an2.ToString();
                }
                else
                {
                    textBox4.Text = "無解";
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            /*double a, b, c;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = double.Parse(textBox3.Text);*/
        }
    }
}
