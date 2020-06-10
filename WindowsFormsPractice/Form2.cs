using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPractice
{
    public partial class Form2 : Form
    {
        private int coorx = 50;
        private bool flag = true;
        private bool sizeflag = true;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            coorx = 100;
            label1.Font = new Font(label1.Font.FontFamily, 15);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Location = new Point(coorx, 150);
            if (flag) coorx += 5;
            else coorx-=5;

            if (coorx > 300) flag = false;
            if (coorx < 10) flag = true;

            if(checkBox1.Checked)
            {
                float size = label1.Font.Size;
                if (sizeflag) size++;
                else size--;

                if (size > 48) sizeflag = false;
                if (size < 24) sizeflag = true;

                label1.Font = new Font(label1.Font.FontFamily, size);
            }
            if (checkBox2.Checked)
            {
                Random random = new Random();
                label1.ForeColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
