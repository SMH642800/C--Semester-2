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
    public partial class Form3 : Form
    {
        private int count = 1;
        private Bitmap[] bitmap = new Bitmap[6];

        private string movie1 = "冰雪奇緣";
        private string movie2 = "黑魔女";
        private string movie3 = "星際大戰8";
        private string movie4 = "天氣之子";
        private string movie5 = "動物方程式";

        private string movie_type1 = "2D";
        private string movie_type2 = "3D";

        private string ticket_type1 = "一般票";
        private string ticket_type2 = "學生票";
        private string ticket_type3 = "兒童票";
        
        public Form3()
        {
            InitializeComponent();
            bitmap[1] = new Bitmap(@"movie\1.jpg");
            bitmap[2] = new Bitmap(@"movie\2.jpg");
            bitmap[3] = new Bitmap(@"movie\3.jpg");
            bitmap[4] = new Bitmap(@"movie\4.jpg");
            bitmap[5] = new Bitmap(@"movie\5.jpg");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = bitmap[1];
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pictureBox1.Image = bitmap[1];
            }
            else if (radioButton2.Checked)
            {
                pictureBox1.Image = bitmap[2];
            }
            else if (radioButton3.Checked)
            {
                pictureBox1.Image = bitmap[3];
            }
            else if (radioButton4.Checked)
            {
                pictureBox1.Image = bitmap[4];
            }
            else if (radioButton5.Checked)
            {
                pictureBox1.Image = bitmap[5];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
                count += 1;
                label2.Text = count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (count > 1)
            {
                count -= 1;
                label2.Text = count.ToString();
            }
            else
            {
                MessageBox.Show ("票數必須大於1");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index >= 0)
            {
                listBox1.Items.RemoveAt(index);
            }
            total_price();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            total_price();
        }

        private void total_price()
        {
            int price = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string str = listBox1.Items[i].ToString();
                string movie_type = str.Substring(str.Length - 8, 2);
                string ticket_type = str.Substring(str.Length - 5, 3);
                string number = str.Substring(str.Length - 1, 1);
                int n = int.Parse(number);

                if (movie_type == movie_type1)
                {
                    if (ticket_type == ticket_type1) price += 250 * n;
                    else if (ticket_type == ticket_type2) price += 200 * n;
                    else if (ticket_type == ticket_type3) price += 150 * n;
                }
                else if (movie_type == movie_type2)
                {
                    if (ticket_type == ticket_type1) price += 400 * n;
                    else if (ticket_type == ticket_type2) price += 320 * n;
                    else if (ticket_type == ticket_type3) price += 240 * n;
                }
            }
            label4.Text = price.ToString();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (radioButton6.Checked)
                {
                    if (radioButton13.Checked) listBox1.Items.Add(movie1+","+movie_type1+","+ticket_type1+"X"+count.ToString());
                    else if (radioButton12.Checked) listBox1.Items.Add(movie1 + "," + movie_type1 + "," + ticket_type2 + "X" + count.ToString());
                    else if (radioButton11.Checked) listBox1.Items.Add(movie1 + "," + movie_type1 + "," + ticket_type3 + "X" + count.ToString());
                }
                else if (radioButton9.Checked)
                {
                    if (radioButton13.Checked) listBox1.Items.Add(movie1 + "," + movie_type2 + "," + ticket_type1 + "X" + count.ToString());
                    else if (radioButton12.Checked) listBox1.Items.Add(movie1 + "," + movie_type2 + "," + ticket_type2 + "X" + count.ToString());
                    else if (radioButton11.Checked) listBox1.Items.Add(movie1 + "," + movie_type2 + "," + ticket_type3 + "X" + count.ToString());
                }
            }
            else if (radioButton2.Checked)
            {
                if (radioButton6.Checked)
                {
                    if (radioButton13.Checked) listBox1.Items.Add(movie2 + "," + movie_type1 + "," + ticket_type1 + "X" + count.ToString());
                    else if (radioButton12.Checked) listBox1.Items.Add(movie2 + "," + movie_type1 + "," + ticket_type2 + "X" + count.ToString());
                    else if (radioButton11.Checked) listBox1.Items.Add(movie2 + "," + movie_type1 + "," + ticket_type3 + "X" + count.ToString());
                }
                else if (radioButton9.Checked)
                {
                    if (radioButton13.Checked) listBox1.Items.Add(movie2 + "," + movie_type2 + "," + ticket_type1 + "X" + count.ToString());
                    else if (radioButton12.Checked) listBox1.Items.Add(movie2 + "," + movie_type2 + "," + ticket_type2 + "X" + count.ToString());
                    else if (radioButton11.Checked) listBox1.Items.Add(movie2 + "," + movie_type2 + "," + ticket_type3 + "X" + count.ToString());
                }
            }
            else if (radioButton3.Checked)
            {
                if (radioButton6.Checked)
                {
                    if (radioButton13.Checked) listBox1.Items.Add(movie3 + "," + movie_type1 + "," + ticket_type1 + "X" + count.ToString());
                    else if (radioButton12.Checked) listBox1.Items.Add(movie3 + "," + movie_type1 + "," + ticket_type2 + "X" + count.ToString());
                    else if (radioButton11.Checked) listBox1.Items.Add(movie3 + "," + movie_type1 + "," + ticket_type3 + "X" + count.ToString());
                }
                else if (radioButton9.Checked)
                {
                    if (radioButton13.Checked) listBox1.Items.Add(movie3 + "," + movie_type2 + "," + ticket_type1 + "X" + count.ToString());
                    else if (radioButton12.Checked) listBox1.Items.Add(movie3 + "," + movie_type2 + "," + ticket_type2 + "X" + count.ToString());
                    else if (radioButton11.Checked) listBox1.Items.Add(movie3 + "," + movie_type2 + "," + ticket_type3 + "X" + count.ToString());
                }
            }
            else if (radioButton4.Checked)
            {
                if (radioButton6.Checked)
                {
                    if (radioButton13.Checked) listBox1.Items.Add(movie4+ "," + movie_type1 + "," + ticket_type1 + "X" + count.ToString());
                    else if (radioButton12.Checked) listBox1.Items.Add(movie4 + "," + movie_type1 + "," + ticket_type2 + "X" + count.ToString());
                    else if (radioButton11.Checked) listBox1.Items.Add(movie4 + "," + movie_type1 + "," + ticket_type3 + "X" + count.ToString());
                }
                else if (radioButton9.Checked)
                {
                    if (radioButton13.Checked) listBox1.Items.Add(movie4 + "," + movie_type2 + "," + ticket_type1 + "X" + count.ToString());
                    else if (radioButton12.Checked) listBox1.Items.Add(movie4 + "," + movie_type2 + "," + ticket_type2 + "X" + count.ToString());
                    else if (radioButton11.Checked) listBox1.Items.Add(movie4 + "," + movie_type2 + "," + ticket_type3 + "X" + count.ToString());
                }
            }
            else if (radioButton5.Checked)
            {
                if (radioButton6.Checked)
                {
                    if (radioButton13.Checked) listBox1.Items.Add(movie5 + "," + movie_type1 + "," + ticket_type1 + "X" + count.ToString());
                    else if (radioButton12.Checked) listBox1.Items.Add(movie5 + "," + movie_type1 + "," + ticket_type2 + "X" + count.ToString());
                    else if (radioButton11.Checked) listBox1.Items.Add(movie5 + "," + movie_type1 + "," + ticket_type3 + "X" + count.ToString());
                }
                else if (radioButton9.Checked)
                {
                    if (radioButton13.Checked) listBox1.Items.Add(movie5 + "," + movie_type2 + "," + ticket_type1 + "X" + count.ToString());
                    else if (radioButton12.Checked) listBox1.Items.Add(movie5 + "," + movie_type2 + "," + ticket_type2 + "X" + count.ToString());
                    else if (radioButton11.Checked) listBox1.Items.Add(movie5 + "," + movie_type2 + "," + ticket_type3 + "X" + count.ToString());
                }
            }
            total_price();
        }
    }
}
