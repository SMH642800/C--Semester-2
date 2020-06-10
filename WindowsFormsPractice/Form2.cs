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
<<<<<<< HEAD
        private int coorx = 50;
        private bool flag = true;
        private bool sizeflag = true;

=======
>>>>>>> 72395cbeb261ee093d2f0c01ae0b25b9d6b63ce3
        public Form2()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
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

=======
        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            double a, b, c;
         
            a = random.Next(1, 6);
            b = random.Next(1, 6);
            c = random.Next(1, 6);

            label1.Text = a.ToString();
            label2.Text = b.ToString();
            label3.Text = c.ToString();

            string filePath = @"dice\" + a.ToString() + ".jpg"; /*file path: @"dice\1.jpg"*/
            Bitmap bitmap = new Bitmap(filePath);
            pictureBox1.Image = bitmap;

            filePath = @"dice\" + b.ToString() + ".jpg";
            bitmap = new Bitmap(filePath);
            pictureBox2.Image = bitmap;

            filePath = @"dice\" + c.ToString() + ".jpg";
            bitmap = new Bitmap(filePath);
            pictureBox3.Image = bitmap;
>>>>>>> 72395cbeb261ee093d2f0c01ae0b25b9d6b63ce3
        }
    }
}
