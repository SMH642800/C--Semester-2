using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Game
{
    public partial class Form1 : Form
    {
        private List<Bitmap> BitmapsList = new List<Bitmap>();
        private List<PictureBox> PictureBoxList = new List<PictureBox>();

        private int[] answer = new int[6] { 1, 1, 2, 2, 3, 3 };
        private int perIndex = 0;
        private int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void CardReset()
        {
            for (int i = 0; i < PictureBoxList.Count; i++)
            {
                PictureBoxList[i].Image = BitmapsList[0];
            }
        }

        private void Shuffle()
        {
            Random random = new Random();
            for (int n = 0; n < 6; n++)
            {
                int k = random.Next(n);
                int value = answer[n];
                answer[n] = answer[k];
                answer[k] = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CardReset();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Shuffle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PictureBoxList.Add(pictureBox1);
            PictureBoxList.Add(pictureBox2);
            PictureBoxList.Add(pictureBox3);
            PictureBoxList.Add(pictureBox4);
            PictureBoxList.Add(pictureBox5);
            PictureBoxList.Add(pictureBox6);

            BitmapsList.Add(new Bitmap(@"image\face.jpg"));
            BitmapsList.Add(new Bitmap(@"image\1.jpg"));
            BitmapsList.Add(new Bitmap(@"image\2.jpg"));
            BitmapsList.Add(new Bitmap(@"image\3.jpg"));

            Shuffle();
            CardReset();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            string number = pictureBox.Name.Substring(10, pictureBox.Name.Length - 10);
            int index = int.Parse(number);
            int ans = answer[index - 1];
            pictureBox.Image = BitmapsList[ans];

            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            if (count == 1)
            {
                if (answer[index - 1] != answer[perIndex - 1])
                {
                    //CardReset();
                    PictureBoxList[index - 1].Image = BitmapsList[0];
                    PictureBoxList[perIndex - 1].Image = BitmapsList[0];
                }
                count = 0;
            }
            else count++;

            perIndex = index;
        }
    }
}
