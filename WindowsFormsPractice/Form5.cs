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
    public partial class Form5 : Form
    {
        private bool flag = false;

        public Form5()
        {
            InitializeComponent();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
        }

        private void Form5_MouseMove(object sender, MouseEventArgs e)
        {
           

            if(flag) button1.Location = new Point(e.X, e.Y);
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag)
            {
                
            }
        }
    }
}
