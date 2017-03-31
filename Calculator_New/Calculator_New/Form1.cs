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

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////// Variables Declaration ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        Boolean enter_value;
        double result;
        string opera = "";
        private double tempNum;
        private double tempResult;
        private bool sumTrigger = true;
        private bool subTrigger = true;

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////// FORM LOAD ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////// NUMERICAL BUTTONS ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Ao clicar no botão, escreve o que o botão contém.
        /// Se boolean é true, dá clear ao display.
        /// Se já contem vírgula, não mete outra.
        /// Se só contem o 0, limpa antes de substituir por outro número.
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
                {
                    textBoxDisplay.Text = textBoxDisplay.Text + num.Text;
                    labelDisplay.Text = labelDisplay.Text + num.Text;

                }
            }
            else
            {
                if ((textBoxDisplay.Text == "0"))
                {
                    textBoxDisplay.Text = "";
                }
                textBoxDisplay.Text = textBoxDisplay.Text + num.Text;
                labelDisplay.Text = labelDisplay.Text + num.Text;
            }
            enter_value = false;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////// OPERATOR BUTTONS /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Ao clicar no botão, envia o que está no seu texto.
        /// Dá para o switch case em string a operação correspondente ao botão.
        /// Limpa o display.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aritmetic_Operator(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            opera = num.Text;

            
            switch (opera)
            {
                case "+":

                        if (sumTrigger)
                        {
                            tempNum = Convert.ToDouble(textBoxDisplay.Text);
                            tempResult = tempNum;
                            textBoxDisplay.Text = tempResult.ToString();
                            labelDisplay.Text = labelDisplay.Text + opera;
                            sumTrigger = false;
                            prevOpera = true;
                        }
                        else
                        {
                            tempNum = Convert.ToDouble(textBoxDisplay.Text);
                            tempResult = tempResult + tempNum;
                            textBoxDisplay.Text = tempResult.ToString();
                            labelDisplay.Text = labelDisplay.Text + opera;
                        }

                    break;

                case "-":
                        if (subTrigger)
                        {
                            tempNum = Convert.ToDouble(textBoxDisplay.Text);
                            tempResult = tempNum;
                            textBoxDisplay.Text = tempResult.ToString();
                            labelDisplay.Text = labelDisplay.Text + opera;
                            subTrigger = false;

                        }
                        else
                        {
                            tempNum = Convert.ToDouble(textBoxDisplay.Text);
                            tempResult = tempResult - tempNum;
                            textBoxDisplay.Text = tempResult.ToString();
                            labelDisplay.Text = labelDisplay.Text + opera;
                        }
                    break;
            }







            
            result = Double.Parse(textBoxDisplay.Text);
            textBoxDisplay.Text = "";
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////// EQUALS BUTTON ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Switch case para as operações que precisarem de 2 valores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            switch (opera)
            {
                case "+":
                    textBoxDisplay.Text = (result + Double.Parse(textBoxDisplay.Text)).ToString();
                    labelDisplay.Text = textBoxDisplay.Text;
                    sumTrigger = true;
                    break;

                case "-":
                    textBoxDisplay.Text = (result - Double.Parse(textBoxDisplay.Text)).ToString();
                    labelDisplay.Text = textBoxDisplay.Text;
                    subTrigger = true;
                    break;

                case "*":
                    textBoxDisplay.Text = (result * Double.Parse(textBoxDisplay.Text)).ToString();
                    break;

                case "/":
                    textBoxDisplay.Text = (result / Double.Parse(textBoxDisplay.Text)).ToString();
                    break;

            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////// CLEAR BUTTON /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Limpa a display e a variável do switch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearDisplay();
            opera = "";
            tempNum = 0;
            tempResult = 0;
            num1 = 0;
            sumTrigger = true;
            subTrigger = true;
            prevOpera = false;
            labelDisplay.Text = "";

        }

        private void textBoxDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDisplay_Click(object sender, EventArgs e)
        {

        }

        private void clearDisplay()
        {
            textBoxDisplay.Text = "";
        }
    }
}
