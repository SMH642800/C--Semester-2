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

namespace Final_examine_practice
{
    public partial class Form5 : Form
    {
        private int count = 0;
        private int score = 0;
        private Bitmap[] bitmap = new Bitmap[6];
        public Form5()
        {
            InitializeComponent();
            bitmap[1] = new Bitmap(@"pic\1.png");
            bitmap[2] = new Bitmap(@"pic\2.png");
            bitmap[3] = new Bitmap(@"pic\3.png");
            bitmap[4] = new Bitmap(@"pic\4.png");
            bitmap[5] = new Bitmap(@"pic\5.png");
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = bitmap[5];
            pictureBox2.Image = bitmap[5];
            pictureBox3.Image = bitmap[5];
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
            pictureBox1.Image = bitmap[a];
            pictureBox2.Image = bitmap[b];
            pictureBox3.Image = bitmap[c];

            if (count > 0)
            {
                count -= 5;
                if (count == 250) timer1.Interval = 100;
                else if (count == 100) timer1.Interval = 250;
                else if (count == 50) timer1.Interval = 500;
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

                timer1.Enabled = false;
            }
            label1.Text = "分數 : " + score.ToString();
        }
    }
}
