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
    public partial class Form1 : Form
    {
<<<<<<< HEAD
        int[] answer = new int[6] { 1, 1, 2, 2, 3, 3};
        int perState = 0;
=======
>>>>>>> 72395cbeb261ee093d2f0c01ae0b25b9d6b63ce3
        public Form1()
        {
            InitializeComponent();
        }
<<<<<<< HEAD

        private void shuffle()
        {
            Random random = new Random();
            for(int n=0; n<6; n++)
            {
                int k = random.Next(n);
                int value = answer[n];
                answer[n] = answer[k];
                answer[k] = value;
            }
        }
        private void cardreset()
        {
            Bitmap bitmap = new Bitmap(@"image\face.jpg");
            pictureBox1.Image = bitmap;
            pictureBox2.Image = bitmap;
            pictureBox3.Image = bitmap;
            pictureBox4.Image = bitmap;
            pictureBox5.Image = bitmap;
            pictureBox6.Image = bitmap;
        }

        private void ShowAnswer()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            shuffle();
            cardreset();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /* Bitmap bitmap = null;
             if(answer[0]==1) bitmap = new Bitmap(@"images\1.jpg");
             else if (answer[0] == 2) bitmap = new Bitmap(@"images\2.jpg");
             else if (answer[0] == 3) bitmap = new Bitmap(@"images\3.jpg");*/

            Bitmap bitmap = null;
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox.Name == "pictureBox1") bitmap = new Bitmap(@"image\" + answer[0] + ".jpg");
            else if (pictureBox.Name == "pictureBox2") bitmap = new Bitmap(@"image\" + answer[1] + ".jpg");
            else if (pictureBox.Name == "pictureBox3") bitmap = new Bitmap(@"image\" + answer[2] + ".jpg");           
            else if (pictureBox.Name == "pictureBox4") bitmap = new Bitmap(@"image\" + answer[3] + ".jpg");          
            else if (pictureBox.Name == "pictureBox5") bitmap = new Bitmap(@"image\" + answer[4] + ".jpg"); 
            else if (pictureBox.Name == "pictureBox6") bitmap = new Bitmap(@"image\" + answer[5] + ".jpg");
            pictureBox.Image = bitmap;

            /*perState = answer[];*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cardreset();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shuffle();
        }
=======
>>>>>>> 72395cbeb261ee093d2f0c01ae0b25b9d6b63ce3
    }
}
