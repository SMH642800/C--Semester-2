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
    public partial class exam1_e : Form
    {
        private Form1 form1;

        private Bitmap[] bitmap = new Bitmap[4];

        public exam1_e(Form1 formtemp)
        {
            InitializeComponent();
            form1 = formtemp;

            bitmap[0] = new Bitmap(@"Pic\1.png");
            bitmap[1] = new Bitmap(@"Pic\剪刀.png");
            bitmap[2] = new Bitmap(@"Pic\石頭.png");
            bitmap[3] = new Bitmap(@"Pic\布.png");     
        }

        private void exam1_e_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Random rand = new Random();

            if (button.Name == "button1") //剪刀
            {
                int a = rand.Next(1, 3);
                pictureBox1.Image = bitmap[a];
                pictureBox2.Image = bitmap[1];

                if (a == 1) label3.Text = "平手";
                else if (a == 2) label3.Text = "You lose";
                else if (a == 3) label3.Text = "You win";
            }
            if (button.Name == "button2") //石頭
            {
                int a = rand.Next(1, 3);
                pictureBox1.Image = bitmap[a];
                pictureBox2.Image = bitmap[2];

                if (a == 1) label3.Text = "You lose";
                else if (a == 2) label3.Text = "平手";
                else if (a == 3) label3.Text = "You win";
            }
            if (button.Name == "button3") //布
            {
                int a = rand.Next(1, 3);
                pictureBox1.Image = bitmap[a];
                pictureBox2.Image = bitmap[3];

                if (a == 1) label3.Text = "You lose";
                else if (a == 2) label3.Text = "You win";
                else if (a == 3) label3.Text = "平手";
            }
            if (button.Name == "button4") //重新開始
            {
                pictureBox1.Image = bitmap[0];
                pictureBox2.Image = bitmap[0];
            }
        }
    }
}
