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
    public partial class exam1_c : Form
    {
        private Form1 form1;

        public exam1_c(Form1 formtemp)
        {
            InitializeComponent();
            form1 = formtemp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = textBox1.Text.ToString();
            int[] state = new int[] { 0, 0, 0 };

            if (password.Length < 5) MessageBox.Show("Error!");
            else
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if (password[i] >= 65 && password[i] <= 90)
                    {
                        //大寫
                        state[0] = 1;
                    }
                    else if (password[i] >= 97 && password[i] <= 122)
                    {
                        //小寫
                        state[1] = 1;
                    }
                    else if (password[i] >= 48 && password[i] <= 57)
                    {
                        //數字
                        state[2] = 1;
                    }
                }
                if (state[0] == 1 && state[1] == 1 && state[2] == 1) MessageBox.Show("Pass!");
                else if (state[0] == 0) MessageBox.Show("請輸入大寫!");
                else if (state[1] == 0) MessageBox.Show("請輸入小寫!");
                else if (state[2] == 0) MessageBox.Show("請輸入數字!");
            }
        }

        private void exam1_c_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }
    }
}
