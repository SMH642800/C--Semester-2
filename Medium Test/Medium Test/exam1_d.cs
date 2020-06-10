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
    public partial class exam1_d : Form
    {
        private Form1 form1;

        public exam1_d(Form1 formTemp)
        {
            InitializeComponent();
            form1 = formTemp;
        }

        private void exam1_d_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int a = rand.Next(1, 6);
            int b = rand.Next(1, 6);
            int c = rand.Next(1, 6);

            label1.Text = a.ToString();
            label2.Text = b.ToString();
            label3.Text = c.ToString();

            int ans;
            ans = a + b + c;
            label4.Text = ans.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "0";

            int[] tmp = new int[] { 0, 0, 0, 0, 0, 0 };
            Random rand = new Random();
            int a = rand.Next(1, 6);
            int b = rand.Next(1, 6);
            int c = rand.Next(1, 6);

            label1.Text = a.ToString();
            label2.Text = b.ToString();
            label3.Text = c.ToString();
            int ans = a + b + c;

            for (int i = 1; i < 7; i++)
            {
                if (a == i) tmp[i - 1] += 1;
                if (b == i) tmp[i - 1] += 1;
                if (c == i) tmp[i - 1] += 1;
            }
            for (int i = 1; i < 7; i++)
            {
                if (tmp[i - 1] == 2)
                {
                    ans = ans - i * 2;
                    label5.Text = ans.ToString();
                    break;
                }
                if (tmp[0] == 1 && tmp[1] == 1 && tmp[2] == 1) label5.Text = "逼機";
                else label5.Text = "0";
            }
            if (a == b && b == c) label5.Text = "一色或豹子";
            //if (a != b && b != c && c != a) label5.Text = "0";
        }
    }
}
