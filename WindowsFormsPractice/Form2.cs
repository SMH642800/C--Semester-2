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
        public Form2()
        {
            InitializeComponent();
        }

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
        }
    }
}
