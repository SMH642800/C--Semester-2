using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 跑馬燈
{
    public partial class Form1 : Form
    {
        private int intDir=1;
        private bool size1 = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Start")
            {
                button1.Text = "Stop";
                timer1.Enabled = true;
                timer2.Enabled = true;
            }
            else
            {
                button1.Text = "Start";
                timer2.Enabled = false;
                timer3.Enabled = false;
            }
        }

        public Random r = new Random();
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 80;
            if (radioButton1.Checked == true)
            {
                switch (intDir)
                {
                    case 1:
                        this.label1.Left -= 2;
                        if (label1.Left <= 5) intDir = 2;
                        break;
                    case 2:
                        this.label1.Left += 2;
                        if (label1.Left >= 220) intDir = 1;
                        break;
                }
            }
            else if (radioButton2.Checked == true)
            {
                switch (intDir)
                {
                    case 1:
                        this.label1.Top -= 2;
                        if (label1.Top <= 100) intDir = 2;
                        break;
                    case 2:
                        this.label1.Top += 2;
                        if (label1.Top >= 330) intDir = 1;
                        break;
                }
            }
            else if (radioButton3.Checked == true)
            {
                switch (intDir)
                {
                    case 1:
                        this.label1.Left -= 2;
                        if (label1.Left <= 5) intDir = 2;
                        break;
                    case 2:
                        this.label1.Top += 2;
                        if (label1.Top >= 330) intDir = 3;
                        break;
                    case 3:
                        this.label1.Left += 2;
                        if (label1.Left >= 220) intDir = 4;
                        break;
                    case 4:
                        this.label1.Top -= 2;
                        if (label1.Top <= 100) intDir = 1;
                        break;
                }
            }
            else if (radioButton4.Checked == true)
            {
                int x = r.Next(5, 220);
                int y = r.Next(100, 330);
                label1.Top = y;
                label1.Left = x;
                timer2.Interval = 50;
            }
            else if (radioButton8.Checked == true)
            {
                switch (intDir)
                {
                    case 1: //右下
                        this.label1.Left += 2;
                        this.label1.Top += 2;
                        if (label1.Top >= 330) intDir = 2; //右上
                        else if (label1.Left >= 220) intDir = 3; //左下
                        break;
                    case 2: //右上
                        this.label1.Left += 2;
                        this.label1.Top -= 2;
                        if (label1.Left >= 220) intDir = 4; //左上
                        else if (label1.Top <= 100) intDir = 1; //右下
                        break;
                    case 3://左下
                        this.label1.Left -= 2;
                        this.label1.Top += 2;
                        if (label1.Top >= 330) intDir = 4; //左上
                        else if (label1.Left <= 5) intDir = 1; //右下
                        break;
                    case 4: //左上
                        this.label1.Top -= 2;
                        this.label1.Left -= 2;
                        if (label1.Top <= 100) intDir = 3;
                        else if (label1.Left <= 5) intDir = 2;
                        break;
                }
            }
            if (radioButton6.Checked == true)
            {
                timer2.Interval = 20;
                float size = label1.Font.Size;
                if (size1) size++;
                else size--;

                if (size > 64) size1 = false;
                if (size < 12) size1 = true;

                label1.Font = new Font(label1.Font.FontFamily, size);
            }
            if (radioButton7.Checked == true)
            {
                timer3.Enabled = true;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton5.Checked = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (label1.ForeColor == Color.Black)
            {
                label1.ForeColor = Color.Red;
            }
            else if (label1.ForeColor == Color.Red)
            {
                label1.ForeColor = Color.Orange;
            }
            else if (label1.ForeColor == Color.Orange)
            {
                label1.ForeColor = Color.Yellow;
            }
            else if (label1.ForeColor == Color.Yellow)
            {
                label1.ForeColor = Color.Green;
            }
            else if (label1.ForeColor == Color.Green)
            {
                label1.ForeColor = Color.Blue;
            }
            else if (label1.ForeColor == Color.Blue)
            {
                label1.ForeColor = Color.Purple;
            }
            else
            {
                label1.ForeColor = Color.Black;
            }
        }
        
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            timer3.Enabled = false;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            timer3.Enabled = false;
        }
    }
}
