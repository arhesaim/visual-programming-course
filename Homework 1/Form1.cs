using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Text = "Pride and Prejudice";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label1.Text = "Twilight";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label1.Text = "The young Pope";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox4.Visible = false;
            pictureBox3.Visible = true;
        }
    }
}
