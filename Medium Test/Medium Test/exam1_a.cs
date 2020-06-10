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
    public partial class exam1_a : Form
    {
        private Form1 form1;

        public exam1_a(Form1 formTemmp)
        {
            InitializeComponent();
            form1 = formTemmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Red")
            {
                label1.Text = "Green";
                label1.ForeColor = Color.Green;
                label2.Text = "Blue";
                label2.ForeColor = Color.Blue;
                label3.Text = "Red";
                label3.ForeColor = Color.Red;
            }
            else if (label1.Text == "Green")
            {
                label1.Text = "Blue";
                label1.ForeColor = Color.Blue;
                label2.Text = "Red";
                label2.ForeColor = Color.Red;
                label3.Text = "Green";
                label3.ForeColor = Color.Green;
            }
            else if (label1.Text == "Blue")
            {
                label1.Text = "Red";
                label1.ForeColor = Color.Red;
                label2.Text = "Green";
                label2.ForeColor = Color.Green;
                label3.Text = "Blue";
                label3.ForeColor = Color.Blue;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Red")
            {
                label1.Text = "Blue";
                label1.ForeColor = Color.Blue;
                label2.Text = "Red";
                label2.ForeColor = Color.Red;
                label3.Text = "Green";
                label3.ForeColor = Color.Green;
            }
            else if (label1.Text == "Green")
            {
                label1.Text = "Red";
                label1.ForeColor = Color.Red;
                label2.Text = "Green";
                label2.ForeColor = Color.Green;
                label3.Text = "Blue";
                label3.ForeColor = Color.Blue;
            }
            else if (label1.Text == "Blue")
            {
                label1.Text = "Green";
                label1.ForeColor = Color.Green;
                label2.Text = "Blue";
                label2.ForeColor = Color.Blue;
                label3.Text = "Red";
                label3.ForeColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] l = new int[] { 0, 1, 2 }; //值
            Random rand = new Random(); //位置

            Label[] L = { label1, label2, label3 };
            for (int i = 0; i < 3; i++)
            {
                int tmp, location;
                location = rand.Next(0, 2);
                tmp = l[location];
                l[location] = l[i];
                l[i] = tmp;
            }
            for (int j = 0; j < 3; j++)
            {

                if (l[j] == 0)
                {
                    L[j].Text = "Red";
                    L[j].ForeColor = Color.Red;
                }
                if (l[j] == 1)
                {
                    L[j].Text = "Green";
                    L[j].ForeColor = Color.Green;
                }
                if (l[j] == 2)
                {
                    L[j].Text = "Blue";
                    L[j].ForeColor = Color.Blue;
                }
            }
        }

        private void exam1_a_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }
    }
}
