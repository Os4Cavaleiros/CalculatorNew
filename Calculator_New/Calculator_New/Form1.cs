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
        ////// Attributes Declaration ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        Boolean enter_value;
        double result;
        string opera = "";
        private double tempNum;
        private double tempResult;
        private bool sumTrigger = true;
        private bool subTrigger = true;
        private bool prevOpera = true;

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////// FORM LOAD ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 308;
            textBoxDisplay.Width = 271;
            this.Text = "Calculator (Standard)";
            this.Height = 338;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////// NUMERICAL BUTTONS ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

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
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

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
            //labelDisplay.Text = textBoxDisplay.Text;

            switch (opera)
            {
                case "+":

                        if (sumTrigger)
                        {
                            tempResult = Convert.ToDouble(textBoxDisplay.Text);
                            textBoxDisplay.Text = tempResult.ToString();
                            labelDisplay.Text = labelDisplay.Text + opera;
                            sumTrigger = false;
                        }
                        else
                        {
                            tempNum = Convert.ToDouble(textBoxDisplay.Text);
                            tempResult = tempResult + tempNum;
                            textBoxDisplay.Text = tempResult.ToString();
                            labelDisplay.Text = tempResult.ToString() + opera;
                        }
                    break;

                case "-":
                        if (subTrigger)
                        {
                            tempResult = Convert.ToDouble(textBoxDisplay.Text);
                            textBoxDisplay.Text = tempResult.ToString();
                            labelDisplay.Text = labelDisplay.Text + opera;
                            subTrigger = false;

                        }
                        else
                        {
                            tempNum = Convert.ToDouble(textBoxDisplay.Text);
                            tempResult = tempResult - tempNum;
                            textBoxDisplay.Text = tempResult.ToString();
                            labelDisplay.Text = tempResult.ToString() + opera;
                        }
                    break;
            }

            result = Double.Parse(textBoxDisplay.Text);
            textBoxDisplay.Text = "";
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////// EQUALS BUTTON ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

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
                    labelDisplay.Text = "sum = " + textBoxDisplay.Text;
                    sumTrigger = true;
                    break;

                case "-":
                    textBoxDisplay.Text = (result - Double.Parse(textBoxDisplay.Text)).ToString();
                    labelDisplay.Text = "sum (-) =" + textBoxDisplay.Text;
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
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

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
            textBoxDisplay.Text = "0";
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////// MENUS /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // Não apagar!
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Demonstra um dialog (FormColors)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormColors myFormColors = new FormColors(this);
            myFormColors.ShowDialog();
        }

        /// <summary>
        /// Tamanhos standard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 308;
            textBoxDisplay.Width = 271;
            this.Text = "Calculator (Standard)";
            this.Height = 338;
        }

        /// <summary>
        /// Botão backspace, se poder retirar 1 retira senão mantém o 0.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text.Length - 1 > 0)
            {
                textBoxDisplay.Text = textBoxDisplay.Text.Remove(textBoxDisplay.Text.Length - 1, 1);
            }
            else 
            {
                textBoxDisplay.Text = "0";
            }
        }

        /// <summary>
        /// Botão de sinal negativo, apenas põe se possível (se não houver outro)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            if (!textBoxDisplay.Text.Contains("-"))
            {
                if (textBoxDisplay.Text == "0")
                {
                    textBoxDisplay.Text = "-";
                }
                else
                {
                    textBoxDisplay.Text = "-" + textBoxDisplay.Text;
                }
            }
        }
    }
}
