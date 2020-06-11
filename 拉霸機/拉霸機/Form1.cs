using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 拉霸機
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
            pictureBox1.Image = new Bitmap(@"picture\up.jpg");
            pictureBox2.Image = new Bitmap(@"picture\5.jpg"); ;
            pictureBox3.Image = new Bitmap(@"picture\5.jpg"); ;
            pictureBox4.Image = new Bitmap(@"picture\5.jpg"); ;
            MessageBox.Show("計算分數方式 : 當其中任兩項重複時，那兩項的分數皆會*2，當三項皆重複時，那分數皆會*3");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int a, b, c;
            Random r = new Random();
            a = r.Next(1, 6);
            b = r.Next(1, 6);
            c = r.Next(1, 6);

            if (count > 0)
            {
                count -= 5;
                if (count == 100)
                {
                    timer1.Interval = 100;
                }
                if (count == 50)
                {
                    timer1.Interval = 300;
                }
                if (count == 10)
                {
                    timer1.Interval = 500;
                }
            }
            else
            {
                if (a != 5 || b != 5 || c != 5)
                {
                    if (a != b && b != c && a != c)
                    {
                        if (a == 1) score += 100;
                        else if (a == 2) score += 140;
                        else if (a == 3) score += 180;
                        else if (a == 4) score += 250;
                        else if (a == 5) score += 300;

                        if (b == 1) score += 100;
                        else if (b == 2) score += 140;
                        else if (b == 3) score += 180;
                        else if (b == 4) score += 250;
                        else if (b == 5) score += 300;

                        if (c == 1) score += 100;
                        else if (c == 2) score += 140;
                        else if (c == 3) score += 180;
                        else if (c == 4) score += 250;
                        else if (c == 5) score += 300;

                        label1.Text = "得分 : " + score.ToString();
                        timer1.Enabled = false;
                    }
                    else if (a == b)
                    {
                        if (a == 1) score += 100*2*2;
                        else if (a == 2) score += 140*2*2;
                        else if (a == 3) score += 180*2*2;
                        else if (a == 4) score += 250*2*2;
                        else if (a == 5) score += 300*2*2;

                        if (c == 1) score += 100;
                        else if (c == 2) score += 140;
                        else if (c == 3) score += 180;
                        else if (c == 4) score += 250;
                        else if (c == 5) score += 300;

                        label1.Text = "得分 : " + score.ToString();
                        timer1.Enabled = false;
                    }
                    else if (a == c)
                    {
                        if (a == 1) score += 100 * 2*2;
                        else if (a == 2) score += 140 * 2*2;
                        else if (a == 3) score += 180 * 2*2;
                        else if (a == 4) score += 250 * 2*2;
                        else if (a == 5) score += 300 * 2*2;

                        if (b == 1) score += 100;
                        else if (b == 2) score += 140;
                        else if (b == 3) score += 180;
                        else if (b == 4) score += 250;
                        else if (b == 5) score += 300;

                        label1.Text = "得分 : " + score.ToString();
                        timer1.Enabled = false;
                    }
                    else if (b == c)
                    {
                        if (b == 1) score += 100 * 2*2;
                        else if (b == 2) score += 140 * 2*2;
                        else if (b == 3) score += 180 * 2*2;
                        else if (b == 4) score += 250 * 2*2;
                        else if (b == 5) score += 300 * 2*2;

                        if (a == 1) score += 100;
                        else if (a == 2) score += 140;
                        else if (a == 3) score += 180;
                        else if (a == 4) score += 250;
                        else if (a == 5) score += 300;

                        label1.Text = "得分 : " + score.ToString();
                        timer1.Enabled = false;
                    }
                    else if (a == b && b == c)
                    {
                        if (a == 1) score += 100 * 3*3;
                        else if (a == 2) score += 140 * 3*3;
                        else if (a == 3) score += 180 * 3*3;
                        else if (a == 4) score += 250 * 3*3;

                        label1.Text = "得分 : " + score.ToString();
                        timer1.Enabled = false;
                    }
                }
                else
                {
                    label1.Text = "得分 : 恭喜你中大獎!!!";
                    timer1.Enabled = false;
                }
                label1.Text = "得分 : " + score.ToString();
                timer1.Enabled = false;
            }

            Bitmap bitmap = new Bitmap(@"picture\" + a.ToString() + ".jpg");
            pictureBox2.Image = bitmap;

            bitmap = new Bitmap(@"picture\" + b.ToString() + ".jpg");
            pictureBox3.Image = bitmap;

            bitmap = new Bitmap(@"picture\" + c.ToString() + ".jpg");
            pictureBox4.Image = bitmap;

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = new Bitmap(@"picture\down.jpg");
            count = 500;
            score = 0;
            label1.Text = "得分 : " + score.ToString();
            timer1.Interval = 30;
            timer1.Enabled = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = new Bitmap(@"picture\up.jpg");
        }
    }
}
