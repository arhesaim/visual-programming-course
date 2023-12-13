using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bodyMassIndex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int weight = int.Parse(textBox1.Text);
            int height = int.Parse(textBox2.Text);
            double bmi = 703.00 * weight / (height * height);
            if (bmi < 18.5)
            {
                textBox3.Text = "your BMI: " + String.Format("{0:0.00}",bmi) + "\r\nstatus: underweight";
            }
            else
            {
                if (bmi > 25)
                {
                    textBox3.Text = "your BMI: " + String.Format("{0:0.00}", bmi) + "\r\nstatus: overweight";
                }
                else
                {
                    textBox3.Text = "your BMI: " + String.Format("{0:0.00}", bmi) + "\r\nstatus: good weight";
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
