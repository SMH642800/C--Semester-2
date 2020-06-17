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
    public partial class Form1 : Form
    {
        private int count = 0;
        private int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(@"picture/5.jpg");
            pictureBox1.Image = bitmap;

            bitmap = new Bitmap(@"picture/5.jpg");
            pictureBox2.Image = bitmap;

            bitmap = new Bitmap(@"picture/5.jpg");
            pictureBox3.Image = bitmap;

            bitmap = new Bitmap(@"picture/up.jpg");
            pictureBox4.Image = bitmap;
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap bitmap = new Bitmap(@"picture/down.jpg");
            pictureBox4.Image = bitmap;

            count = 200;
            score = 0;
            timer1.Enabled = true;
            timer1.Interval = 10;
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            Bitmap bitmap = new Bitmap(@"picture/up.jpg");
            pictureBox4.Image = bitmap;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int a = 0, b = 0, c = 0;

            Random random = new Random();
            a = random.Next(0, 6);
            b = random.Next(0, 6);
            c = random.Next(0, 6);

            Bitmap bitmap = new Bitmap(@"picture/" + a.ToString() + ".jpg");
            pictureBox1.Image = bitmap;
            bitmap = new Bitmap(@"picture/" + b.ToString() + ".jpg");
            pictureBox2.Image = bitmap;
            bitmap = new Bitmap(@"picture/" + c.ToString() + ".jpg");
            pictureBox3.Image = bitmap;

            if (count > 0)
            {
                count -= 5;
                if (count == 100)
                { 
                    timer1.Interval = 100;
                }
                else if (count == 50)
                {
                    
                    timer1.Interval = 300;
                }
                else if (count == 10)
                {
                    timer1.Interval = 500;
                }
            }
            else
            {
                timer1.Enabled = false;
                if (a == 0) score += 100;
                else if (a == 1) score += 200;
                else if (a == 2) score += 300;
                else if (a == 3) score += 400;
                else if (a == 4) score += 500;
                else if (a == 5) score += 1000;

                if (b == 0) score += 100;
                else if (b == 1) score += 200;
                else if (b == 2) score += 300;
                else if (b == 3) score += 400;
                else if (b == 4) score += 500;
                else if (b == 5) score += 1000;

                if (c == 0) score += 100;
                else if (c == 1) score += 200;
                else if (c == 2) score += 300;
                else if (c == 3) score += 400;
                else if (c == 4) score += 500;
                else if (c == 5) score += 1000;
            }
            label1.Text = "得分 : " + score.ToString();
        }
    }
}
