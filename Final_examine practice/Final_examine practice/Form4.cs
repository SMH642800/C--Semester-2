using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_examine_practice
{
    public partial class Form4 : Form
    {
        private int count = 0;
        private int score = 0;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(@"pic\5.png");
            pictureBox1.Image = bitmap;
            bitmap = new Bitmap(@"pic\5.png");
            pictureBox2.Image = bitmap;
            bitmap = new Bitmap(@"pic\5.png");
            pictureBox3.Image = bitmap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count = 500;
            score = 0;
            timer1.Interval = 10;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int a, b, c;
            Random random = new Random();
            a = random.Next(1, 6);
            b = random.Next(1, 6);
            c = random.Next(1, 6);

            if (count > 0)
            {
                count -= 5;
                if (count == 250)
                {
                    timer1.Interval = 100;
                }
                else if (count == 100)
                {
                    timer1.Interval = 300;
                }
                else if (count == 50)
                {
                    timer1.Interval = 500;
                }
            }
            else
            {
                if (a == 1) score += 10;
                else if (a == 2) score += 20;
                else if (a == 3) score += 30;
                else if (a == 4) score += 40;
                else if (a == 5) score += 50;

                if (b == 1) score += 10;
                else if (b == 2) score += 20;
                else if (b == 3) score += 30;
                else if (b == 4) score += 40;
                else if (b == 5) score += 50;

                if (c == 1) score += 10;
                else if (c == 2) score += 20;
                else if (c == 3) score += 30;
                else if (c == 4) score += 40;
                else if (c == 5) score += 50;

                label1.Text = "得分 : " + score.ToString() + "分";
                timer1.Enabled = false;
            }
            Bitmap bitmap = new Bitmap(@"pic\" + a.ToString() + ".png");
            pictureBox1.Image = bitmap;
            bitmap = new Bitmap(@"pic\" + b.ToString() + ".png");
            pictureBox2.Image = bitmap;
            bitmap = new Bitmap(@"pic\" + c.ToString() + ".png");
            pictureBox3.Image = bitmap;
        }
    }
}
