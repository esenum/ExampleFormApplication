using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleFormApplication_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPressHere_Click(object sender, EventArgs e)
        {
            labelPressHere.Text = "Welcome to My Inner Darkness";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] game =
            {
                "Rock",
                "Paper",
                "Scissor"
            };

            Random random = new Random();
            int index =random.Next(game.Length);
            labelRPS.Text = game[index];
            labelDYW.Text = "Did You Win ?";
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (checkBox1.Checked = true)
            //{
            //    button3.Text = "That's how we do it";
            //}
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
            button3.Text = "Try again";
            button2.Enabled=false;
            btnPressHere.Focus();

        }
    }
}
