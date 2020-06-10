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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(@"food\排骨飯.jpg");
            pictureBox1.Image = bitmap;
        }

        private void TotalPrice()
        {
            int price = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string str = listBox1.Items[i].ToString();
                if (str == "排骨飯") price += 75;
                else if (str == "雞腿飯") price += 80;
                else if (str == "魚排飯") price += 70;
                else if (str == "滷肉飯") price += 50;
            }
            label2.Text = "總價: " + price.ToString()+"元";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price = 0;

            if (radioButton1.Checked == true) price = 75;
            else if (radioButton2.Checked == true) price = 80;
            else if (radioButton3.Checked == true) price = 70;
            else if (radioButton4.Checked == true) price = 50;
            if (checkBox1.Checked==true) price += 15;
            if (checkBox2.Checked == true) price += 20;
            if (checkBox3.Checked == true) price += 10;
  
            label1.Text = "價格: " + price.ToString() + "元";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            /*if (radioButton1.Checked == true)
            {
                Bitmap bitmap = new Bitmap(@"food\1.jpg");
                pictureBox1.Image = bitmap;
            }
            if (radioButton2.Checked == true)
            {
                Bitmap bitmap = new Bitmap(@"food\2.jpg");
                pictureBox1.Image = bitmap;
            }
            if (radioButton3.Checked == true)
            {
                Bitmap bitmap = new Bitmap(@"food\3.jpg");
                pictureBox1.Image = bitmap;
            }
            if (radioButton4.Checked == true)
            {
                Bitmap bitmap = new Bitmap(@"food\4.jpg");
                pictureBox1.Image = bitmap;
            }*/

            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked)
            {
                string fileName = radioButton.Text.Substring(0, 3);
                Bitmap bitmap = new Bitmap(@"food\" + fileName + ".jpg");
                pictureBox1.Image = bitmap;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) listBox1.Items.Add("雞腿飯");
            else if (radioButton2.Checked) listBox1.Items.Add("排骨飯");
            else if (radioButton3.Checked) listBox1.Items.Add("魚排飯");
            else if (radioButton4.Checked) listBox1.Items.Add("滷肉飯");
            TotalPrice();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index == -1) return;
            listBox1.Items.RemoveAt(index);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
