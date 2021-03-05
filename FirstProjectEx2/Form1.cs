using System;
using System.Windows.Forms;

namespace FirstProjectEx2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello! My name is Michael Finochio");
        }

        private void colorAnswerButton_Click(object sender, EventArgs e)
        {
            colorAnswer.Text = "BLACK";
        }

        private void ageAnswerButton_Click(object sender, EventArgs e)
        {
            ageAnswer.Text = "26";
        }

        private void colorQuestion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a hidden message, I am a STEELERS fan!");
        }

        private void family_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is my Family!");
        }

        private void byeMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Have a Nice Day!");
        }
    }
}
