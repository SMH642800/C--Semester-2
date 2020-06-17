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
    public partial class Form2 : Form
    {
        private int count = 1;

        private string movie1 = "動物方程式";
        private string movie2 = "冰雪奇緣2";
        private string movie3 = "星際大戰8";
        private string movie4 = "天氣之子";
        private string movie5 = "黑魔女";

        private string ticket_type1 = "一般票";
        private string ticket_type2 = "學生票";
        private string ticket_type3 = "兒童票";
        private string ticket_type4 = "老人票";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(@"movie/5.jpg");
            pictureBox1.Image = bitmap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                count += 1;
            }
            label1.Text = count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(count<1)
            {
                MessageBox.Show("票數必須為1以上");
            }
            else
            {
                count -= 1;
                label1.Text = count.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index >= 0)
            {
                listBox1.Items.RemoveAt(index);
            }
            TotalPrice();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            TotalPrice();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Bitmap bitmap = new Bitmap(@"movie/5.jpg");
                pictureBox1.Image = bitmap;
            }
            else if (radioButton2.Checked)
            {
                Bitmap bitmap = new Bitmap(@"movie/1.jpg");
                pictureBox1.Image = bitmap;
            }
            else if (radioButton3.Checked)
            {
                Bitmap bitmap = new Bitmap(@"movie/3.jpg");
                pictureBox1.Image = bitmap;
            }
            else if (radioButton4.Checked)
            {
                Bitmap bitmap = new Bitmap(@"movie/4.jpg");
                pictureBox1.Image = bitmap;
            }
            else if (radioButton5.Checked)
            {
                Bitmap bitmap = new Bitmap(@"movie/2.jpg");
                pictureBox1.Image = bitmap;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (radioButton6.Checked) listBox1.Items.Add(movie1 + "," + ticket_type1 + " X " + count.ToString());
                else if (radioButton7.Checked) listBox1.Items.Add(movie1 + "," + ticket_type2 + " X " + count.ToString());
                else if (radioButton8.Checked) listBox1.Items.Add(movie1 + "," + ticket_type4 + " X " + count.ToString());
                else if (radioButton9.Checked) listBox1.Items.Add(movie1 + "," + ticket_type3 + " X " + count.ToString());
            }
            if (radioButton2.Checked)
            {
                if (radioButton6.Checked) listBox1.Items.Add(movie2 + "," + ticket_type1 + " X " + count.ToString());
                else if (radioButton7.Checked) listBox1.Items.Add(movie2 + "," + ticket_type2 + " X " + count.ToString());
                else if (radioButton8.Checked) listBox1.Items.Add(movie2 + "," + ticket_type4 + " X " + count.ToString());
                else if (radioButton9.Checked) listBox1.Items.Add(movie2 + "," + ticket_type3 + " X " + count.ToString());
            }
            if (radioButton3.Checked)
            {
                if (radioButton6.Checked) listBox1.Items.Add(movie3 + "," + ticket_type1 + " X " + count.ToString());
                else if (radioButton7.Checked) listBox1.Items.Add(movie3 + "," + ticket_type2 + " X " + count.ToString());
                else if (radioButton8.Checked) listBox1.Items.Add(movie3 + "," + ticket_type4 + " X " + count.ToString());
                else if (radioButton9.Checked) listBox1.Items.Add(movie3 + "," + ticket_type3 + " X " + count.ToString());
            }
            if (radioButton4.Checked)
            {
                if (radioButton6.Checked) listBox1.Items.Add(movie4 + "," + ticket_type1 + " X " + count.ToString());
                else if (radioButton7.Checked) listBox1.Items.Add(movie4 + "," + ticket_type2 + " X " + count.ToString());
                else if (radioButton8.Checked) listBox1.Items.Add(movie4 + "," + ticket_type4 + " X " + count.ToString());
                else if (radioButton9.Checked) listBox1.Items.Add(movie4 + "," + ticket_type3 + " X " + count.ToString());
            }
            if (radioButton5.Checked)
            {
                if (radioButton6.Checked) listBox1.Items.Add(movie5 + "," + ticket_type1 + " X " + count.ToString());
                else if (radioButton7.Checked) listBox1.Items.Add(movie5 + "," + ticket_type2 + " X " + count.ToString());
                else if (radioButton8.Checked) listBox1.Items.Add(movie5 + "," + ticket_type4 + " X " + count.ToString());
                else if (radioButton9.Checked) listBox1.Items.Add(movie5 + "," + ticket_type3 + " X " + count.ToString());
            }

            TotalPrice();
        }

        private void TotalPrice()
        {
            int total_price = 0;
            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                string str = listBox1.Items[i].ToString();
                string ticket_type = str.Substring(str.Length - 7, 3);
                string ticket_number = str.Substring(str.Length - 1, 1);
                int n = int.Parse(ticket_number);
                if (ticket_type == ticket_type1) total_price += 250*n;
                else if (ticket_type == ticket_type2) total_price += 200 * n;
                else if (ticket_type == ticket_type3) total_price += 150 * n;
                else if (ticket_type == ticket_type4) total_price += 125 * n;
            }
            label3.Text = total_price.ToString()+"元";
        }
    }
}
