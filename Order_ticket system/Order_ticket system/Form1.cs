using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order_ticket_system
{
    public partial class Form1 : Form
    {
        private int count = 1;

        private string movie1 = "動物方程式";
        private string movie2 = "冰雪奇緣2";
        private string movie3 = "黑魔女";
        private string movie4 = "星際大戰8";
        private string movie5 = "天氣之子";

        private string ticket_type1 = "一般票";
        private string ticket_type2 = "兒童票";
        private string ticket_type3 = "學生票";
        private string ticket_type4 = "老人票";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(@"pic\zootopia.jpg");
            pictureBox1.Image = bitmap;
        }

        private void TotalPrice()
        {
            int price = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string str = listBox1.Items[i].ToString();
                string ticket_type = str.Substring(0, str.Length - 1);
                string ticket_number = str.Substring(str.Length-1,1);
                int n = int.Parse(ticket_number);

                if (ticket_type == movie1+","+ticket_type1+ " X ") price += 250 * n;
                else if (ticket_type == movie1 + "," + ticket_type2 + " X ") price += 150 * n;
                else if (ticket_type == movie1 + "," + ticket_type3 + " X ") price += 200 * n;
                else if (ticket_type == movie1 + "," + ticket_type4 + " X ") price += 175 * n;

                else if (ticket_type == movie2 + "," + ticket_type1 + " X ") price += 250 * n;
                else if (ticket_type == movie2 + "," + ticket_type2 + " X ") price += 150 * n;
                else if (ticket_type == movie2 + "," + ticket_type3 + " X ") price += 200 * n;
                else if (ticket_type == movie2 + "," + ticket_type4 + " X ") price += 175 * n;

                else if (ticket_type == movie3 + "," + ticket_type1 + " X ") price += 250 * n;
                else if (ticket_type == movie3 + "," + ticket_type2 + " X ") price += 150 * n;
                else if (ticket_type == movie3 + "," + ticket_type3 + " X ") price += 200 * n;
                else if (ticket_type == movie3 + "," + ticket_type4 + " X ") price += 175 * n;

                else if (ticket_type == movie4 + "," + ticket_type1 + " X ") price += 250 * n;
                else if (ticket_type == movie4 + "," + ticket_type2 + " X ") price += 150 * n;
                else if (ticket_type == movie4 + "," + ticket_type3 + " X ") price += 200 * n;
                else if (ticket_type == movie4 + "," + ticket_type4 + " X ") price += 175 * n;

                else if (ticket_type == movie5 + "," + ticket_type1 + " X ") price += 250 * n;
                else if (ticket_type == movie5 + "," + ticket_type2 + " X ") price += 150 * n;
                else if (ticket_type == movie5 + "," + ticket_type3 + " X ") price += 200 * n;
                else if (ticket_type == movie5 + "," + ticket_type4 + " X ") price += 175 * n;
            }

            label4.Text = price.ToString() + "元";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (radioButton9.Checked) listBox1.Items.Add(movie1+","+ticket_type1+" X " + count.ToString());
                else if (radioButton10.Checked) listBox1.Items.Add(movie1 + "," + ticket_type2 + " X " + count.ToString());
                else if (radioButton11.Checked) listBox1.Items.Add(movie1 + "," + ticket_type3 + " X " + count.ToString());
                else if (radioButton12.Checked) listBox1.Items.Add(movie1 + "," + ticket_type4 + " X " + count.ToString() );

            }
            if (radioButton2.Checked)
            {
                if (radioButton9.Checked) listBox1.Items.Add(movie2 + "," + ticket_type1 + " X " + count.ToString());
                else if (radioButton10.Checked) listBox1.Items.Add(movie2 + "," + ticket_type2 + " X " + count.ToString());
                else if (radioButton11.Checked) listBox1.Items.Add(movie2 + "," + ticket_type3 + " X " + count.ToString());
                else if (radioButton12.Checked) listBox1.Items.Add(movie2 + "," + ticket_type4 + " X " + count.ToString());

            }
            if (radioButton3.Checked)
            {
                if (radioButton9.Checked) listBox1.Items.Add(movie3 + "," + ticket_type1 + " X " + count.ToString());
                else if (radioButton10.Checked) listBox1.Items.Add(movie3 + "," + ticket_type2 + " X " + count.ToString());
                else if (radioButton11.Checked) listBox1.Items.Add(movie3 + "," + ticket_type3 + " X " + count.ToString());
                else if (radioButton12.Checked) listBox1.Items.Add(movie3 + "," + ticket_type4 + " X " + count.ToString());

            }
            if (radioButton4.Checked)
            {
                if (radioButton9.Checked) listBox1.Items.Add(movie4 + "," + ticket_type1 + " X " + count.ToString());
                else if (radioButton10.Checked) listBox1.Items.Add(movie4 + "," + ticket_type2 + " X " + count.ToString());
                else if (radioButton11.Checked) listBox1.Items.Add(movie4 + "," + ticket_type3 + " X " + count.ToString());
                else if (radioButton12.Checked) listBox1.Items.Add(movie4 + "," + ticket_type4 + " X " + count.ToString());

            }
            if (radioButton5.Checked)
            {
                if (radioButton9.Checked) listBox1.Items.Add(movie5 + "," + ticket_type1 + " X " + count.ToString());
                else if (radioButton10.Checked) listBox1.Items.Add(movie5 + "," + ticket_type2 + " X " + count.ToString());
                else if (radioButton11.Checked) listBox1.Items.Add(movie5 + "," + ticket_type3 + " X " + count.ToString());
                else if (radioButton12.Checked) listBox1.Items.Add(movie5 + "," + ticket_type4 + " X " + count.ToString());

            }

            TotalPrice();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index1 = listBox1.SelectedIndex;
            if (index1 != -1) //if (index1 >= 0)
            {
                listBox1.Items.RemoveAt(index1);
            }

            TotalPrice();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            TotalPrice();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Bitmap bitmap = new Bitmap(@"pic\zootopia.jpg");
                pictureBox1.Image = bitmap;
            }
            else if (radioButton2.Checked)
            {
                Bitmap bitmap = new Bitmap(@"pic\frozen.jpg");
                pictureBox1.Image = bitmap;
            }
            else if (radioButton3.Checked)
            {
                Bitmap bitmap = new Bitmap(@"pic\maleficrnt.jpg");
                pictureBox1.Image = bitmap;
            }
            else if (radioButton4.Checked)
            {
                Bitmap bitmap = new Bitmap(@"pic\StarWars.jpg");
                pictureBox1.Image = bitmap;
            }
            else if (radioButton5.Checked)
            {
                Bitmap bitmap = new Bitmap(@"pic\WeatheringWithYou.jpg");
                pictureBox1.Image = bitmap;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            count += 1;
            label1.Text=count.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (count > 1)
            {
                count -= 1;
                label1.Text = count.ToString();
            }
            else MessageBox.Show("票數不能小於1");
        }
    }
}
