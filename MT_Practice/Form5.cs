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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            label3.Text = "";
            label4.Text = "";
        }

       /* private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (!char.IsLetter(e.KeyChar))
                {
                    MessageBox.Show("只能袭输入数字知或英文字母", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Handled = true;
                }
            }
        }*/
        private void button1_Click(object sender, EventArgs e)
        {
            int x = textBox1.Text.Length;
            int y = textBox2.Text.Length;
            char[] input1 = new char[x];
            char[] input2 = new char[y];
            input1 = textBox1.Text.ToCharArray(0, textBox1.Text.Length);
            input2 = textBox2.Text.ToCharArray(0, textBox2.Text.Length);

            if (x < 6) 
            {
                MessageBox.Show("Too short");
                label3.Text = "(wrong)";
                label3.ForeColor = Color.Red;
                textBox1.Text = "";
            }
            if (y < 6)
            {
                MessageBox.Show("Too short");
                label4.Text = "(wrong)";
                label4.ForeColor = Color.Red;
                textBox2.Text = "";
            }

            int flag1 = 0, flag2 = 0;
            try
            {
                for (int i = 0; i <= x; ++i)
                {
                    if (input1[i] >= '0' && input1[i] <= '9')
                    {
                        if (x >= 6)
                        {
                            flag1++;
                        }
                        break;
                    }
                }
                for (int i = 0; i <= x; ++i)
                {
                    if (input1[i] >= 'A' && input1[i] <= 'Z')
                    {
                        if (x >= 6)
                        {
                            flag1++;
                        }
                        break;
                    }
                }
                if (flag1 == 2)
                {
                    label3.ForeColor = Color.Green;
                    label3.Text = "(Success)";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Input character is not complying with a standard.(need A-Z,a-z,0-9)");
                if (flag1 < 2)
                {
                    label3.ForeColor = Color.Red;
                    label3.Text = "(Wrong)";
                    textBox1.Text = "";
                }
            }
            try
            {
                for (int i = 0; i <= x; ++i)
                {
                    if (input2[i] >= 'A' && input2[i] <= 'Z')
                    {
                        if (x >= 6)
                        {
                            flag2++;
                        }
                        break;
                    }
                }
                for (int i = 0; i <= x; ++i)
                {
                    if (input2[i] >= 'a' && input2[i] <= 'z')
                    {
                        if (x >= 6)
                        {
                            flag2++;
                        }
                        break;
                    }
                }
                for (int i = 0; i <= x; ++i)
                {
                    if (input2[i] >= '0' && input2[i] <= '9')
                    {
                        if (x >= 6)
                        {
                            flag2++;
                        }
                        break;
                    }
                }
                if (flag2 == 3)
                {
                    label4.ForeColor = Color.Green;
                    label4.Text = "(Success)";
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Input charater is not complying with a standard.(need A-Z, a-z, 0-9");
                if (flag2 < 3)
                {
                    label4.ForeColor = Color.Red;
                    label4.Text = "(Wrong)";
                    textBox2.Text = "";
                }
            }
        }

        private void textBox1_TextChange(object sender, EventArgs e)
        {
            /*if (!char.IsDigit(e.KeyChar))
            {
                if (!char.IsLetter(e.KeyChar))
                {
                    MessageBox.Show("只能袭输入数字知或英文字母", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Handled = true;
                }
            }*/
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (!char.IsLetter(e.KeyChar))
                {
                    if ((int)e.KeyChar != 8)
                    {
                        return;
                    }
                    else 
                    {
                        MessageBox.Show("只能輸入數字或英文", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        e.Handled = true;
                    }
                }
            }
        }
    }
}
