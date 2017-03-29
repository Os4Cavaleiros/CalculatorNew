using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_New
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        bool enter_value;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            if (enter_value)
            {
                textBoxDisplay.Text = "";
            }

            if (num.Text == ",")
            {
                if (!textBoxDisplay.Text.Contains(","))
                    textBoxDisplay.Text = textBoxDisplay.Text + num.Text;
            }
            else
            {
                if ((textBoxDisplay.Text == "0"))
                {
                    textBoxDisplay.Text = "";
                }
                textBoxDisplay.Text = textBoxDisplay.Text + num.Text;
            }
            enter_value = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {

        }

        private void buttonSum_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
