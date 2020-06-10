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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            exam1_e exam = new exam1_e(this);
            exam.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exam1_a exam = new exam1_a(this);
            exam.Show();
            this.Hide();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            exam1_b exam = new exam1_b(this);
            exam.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            exam1_c exam = new exam1_c(this);
            exam.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            exam1_d exam = new exam1_d(this);
            exam.Show();
            this.Hide();
        }
    }
}
