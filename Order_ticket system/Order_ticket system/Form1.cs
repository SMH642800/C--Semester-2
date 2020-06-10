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

                if (str == "動物方程式,一般票1張") price += 250;
                else if (str == "動物方程式,兒童票1張") price += 150;
                else if (str == "動物方程式,學生票1張") price += 200;
                else if (str == "動物方程式,老人票1張") price += 175;

                else if (str == "冰雪奇緣2,一般票1張") price += 250;
                else if (str == "冰雪奇緣2,兒童票1張") price += 150;
                else if (str == "冰雪奇緣2,學生票1張") price += 200;
                else if (str == "冰雪奇緣2,老人票1張") price += 175;

                else if (str == "黑魔女,一般票1張") price += 250;
                else if (str == "黑魔女,兒童票1張") price += 150;
                else if (str == "黑魔女,學生票1張") price += 200;
                else if (str == "黑魔女,老人票1張") price += 175;

                else if (str == "星際大戰8,一般票1張") price += 250;
                else if (str == "星際大戰8,兒童票1張") price += 150;
                else if (str == "星際大戰8,學生票1張") price += 200;
                else if (str == "星際大戰8,老人票1張") price += 175;

                else if (str == "天氣之子,一般票1張") price += 250;
                else if (str == "天氣之子,兒童票1張") price += 150;
                else if (str == "天氣之子,學生票1張") price += 200;
                else if (str == "天氣之子,老人票1張") price += 175;
            }
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                string str = listBox2.Items[i].ToString();

                if (str == "爆米花(大)") price += 80;
                else if (str == "爆米花(中)") price += 50;
                else if (str == "爆米花(小)") price += 30;

                else if (str == "可樂") price += 40;
                else if (str == "雪碧") price += 40;
            }

            label4.Text = price.ToString() + "元";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked && radioButton9.Checked) listBox1.Items.Add("動物方程式,一般票1張");
            else if (radioButton1.Checked && radioButton10.Checked) listBox1.Items.Add("動物方程式,兒童票1張");
            else if (radioButton1.Checked && radioButton11.Checked) listBox1.Items.Add("動物方程式,學生票1張");
            else if (radioButton1.Checked && radioButton12.Checked) listBox1.Items.Add("動物方程式,老人票1張");

            else if (radioButton2.Checked && radioButton9.Checked) listBox1.Items.Add("冰雪奇緣2,一般票1張");
            else if (radioButton2.Checked && radioButton10.Checked) listBox1.Items.Add("冰雪奇緣2,兒童票1張");
            else if (radioButton2.Checked && radioButton11.Checked) listBox1.Items.Add("冰雪奇緣2,學生票1張");
            else if (radioButton2.Checked && radioButton12.Checked) listBox1.Items.Add("冰雪奇緣2,老人票1張");

            else if (radioButton3.Checked && radioButton9.Checked) listBox1.Items.Add("黑魔女,一般票1張");
            else if (radioButton3.Checked && radioButton10.Checked) listBox1.Items.Add("黑魔女,兒童票1張");
            else if (radioButton3.Checked && radioButton11.Checked) listBox1.Items.Add("黑魔女,學生票1張");
            else if (radioButton3.Checked && radioButton12.Checked) listBox1.Items.Add("黑魔女,老人票1張");

            else if (radioButton4.Checked && radioButton9.Checked) listBox1.Items.Add("星際大戰8,一般票1張");
            else if (radioButton4.Checked && radioButton10.Checked) listBox1.Items.Add("星際大戰8,兒童票1張");
            else if (radioButton4.Checked && radioButton11.Checked) listBox1.Items.Add("星際大戰8,學生票1張");
            else if (radioButton4.Checked && radioButton12.Checked) listBox1.Items.Add("星際大戰8,老人票1張");

            else if (radioButton5.Checked && radioButton9.Checked) listBox1.Items.Add("天氣之子,一般票1張");
            else if (radioButton5.Checked && radioButton10.Checked) listBox1.Items.Add("天氣之子,兒童票1張");
            else if (radioButton5.Checked && radioButton11.Checked) listBox1.Items.Add("天氣之子,學生票1張");
            else if (radioButton5.Checked && radioButton12.Checked) listBox1.Items.Add("天氣之子,老人票1張");

            TotalPrice();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) listBox2.Items.Add("爆米花(大)");
            if (checkBox2.Checked == true) listBox2.Items.Add("爆米花(中)");
            if (checkBox3.Checked == true) listBox2.Items.Add("爆米花(小)");
            if (checkBox4.Checked == true) listBox2.Items.Add("可樂");
            if (checkBox5.Checked == true) listBox2.Items.Add("雪碧");

            TotalPrice();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index1 = listBox1.SelectedIndex;
            if (index1 != -1) //if (index1 >= 0)
            {
                listBox1.Items.RemoveAt(index1);
            }
            int index2 = listBox2.SelectedIndex;
            if (index2 != -1) //if (index2 >= 0)
            {
                listBox2.Items.RemoveAt(index2);
            }

            TotalPrice();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

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
    }
}
