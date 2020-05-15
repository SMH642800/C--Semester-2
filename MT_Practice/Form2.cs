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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b, c; //係數

                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                c = double.Parse(textBox3.Text);

                double D, Re1,Re2,Im1,Im2;  //Result 1, Result 2, 負數根
                D = (b * b) - (4 * a * c);  //判別式

                if (D > 0) //判別式>0時
                {
                    Re1 = ((-b + Math.Sqrt(D)) / (2 * a));
                    Re2 = ((-b - Math.Sqrt(D)) / (2 * a));
                    Im1 = 0;
                    Im2 = 0;
                }           
                else if (D == 0.0) //判別式=0時
                {
                    Re1 = -b / (2 * a);
                    Im1 = 0;
                    Re2 = Im2 = 0;
                }
                else //判別式<0時
                {
                    Re1 = -b / (2 * a);
                    Re2 = Re1;
                    Im1 = Math.Sqrt(-D) / (2 * a);
                    Im2 = -Im1;
                }
                if (D == 0)
                {
                    textBox4.Text = "x1 = " + Re1.ToString() + "+" + Im1.ToString() + "i";
                }
                else
                {
                    textBox4.Text = "x1 = " + Re1.ToString() + "+" + Im1.ToString() + "i" + "\r\n" + "x2 = " + Re2.ToString() + "+" + Im2.ToString() + "i";
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
