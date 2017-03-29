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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ////// Variables Declaration ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        Boolean enter_value;
        double result;
        string opera;

        ////// FORM LOAD ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        ////// NUMERICAL BUTTONS ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Se boolean é true, dá clear ao display.
        /// Se já contei vírgula, não mete outra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            switch (opera)
            {
                case "+":
                    textBoxDisplay.Text = (result + Double.Parse(textBoxDisplay.Text)).ToString();
                    break;

                case "-":
                    textBoxDisplay.Text = (result - Double.Parse(textBoxDisplay.Text)).ToString();
                    break;

                case "*":
                    textBoxDisplay.Text = (result * Double.Parse(textBoxDisplay.Text)).ToString();
                    break;

                case "/":
                    textBoxDisplay.Text = (result / Double.Parse(textBoxDisplay.Text)).ToString();
                    break;
            }
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void aritmetic_Operator(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            opera = num.Text;
            result = Double.Parse(textBoxDisplay.Text);
            textBoxDisplay.Text = "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = "";
            opera = "";
        }
    }
}
