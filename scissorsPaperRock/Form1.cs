using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scissorsPaperRock
{
    public partial class Form1 : Form
    {
        int compChoice = 0;
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


        private void button1_Click(object sender, EventArgs e)
        {
            //this is quit
            this.Close();
        }

        private void computerChoice_TextChanged(object sender, EventArgs e)
        {
            //this is comp choice
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //this is my choice
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this is paper
            int num = 1;
            compChoice = GenerateRandom();
            textBox1.Text = ChoiceOutput(num);
            computerChoice.Text = ChoiceOutput(compChoice);
            textBox2.Text = Game(compChoice, num);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this is scissors
            int num = 2;
            compChoice = GenerateRandom();
            textBox1.Text = ChoiceOutput(num);
            computerChoice.Text = ChoiceOutput(compChoice);
            textBox2.Text = Game(compChoice, num);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this is rock
            int num = 0;
            compChoice = GenerateRandom();
            textBox1.Text = ChoiceOutput(num);
            computerChoice.Text = ChoiceOutput(compChoice);
            textBox2.Text = Game(compChoice, num);
        }
        int GenerateRandom()
        {
            var random = new Random();
            int num = random.Next(0, 3);
            return num;
        }
        string ChoiceOutput(int num)
        {
            switch (num)
            {
                case 0:
                    return "rock";
                case 1:
                    return "paper";
                case 2:
                    return "scissors";
                default:
                    return "wrong value, try again";
            }
        }

        static string Game(int computerValue, int userValue)
        {
            if ((computerValue + 1) % 3 == userValue)
            {
                return "You won!";
            }
            else if (computerValue == userValue)
            {
                return "no winner!";
            }
            else
            {
                return "computer won!";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
