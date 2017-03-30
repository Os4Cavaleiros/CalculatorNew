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
        string opera;

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////// FORM LOAD ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 269;
            textBoxDisplay.Width = 233;
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 269;
            textBoxDisplay.Width = 233;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 421;
            textBoxDisplay.Width = 383;
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
            if (textBoxDisplay.Text != "")
            {
                Button num = (Button)sender;
                opera = num.Text;
                result = Double.Parse(textBoxDisplay.Text);
                textBoxDisplay.Text = "";
            }
            else
            {
                MessageBox.Show("Introduza os valores necessários à operação.");
            }
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
            enter_value = true;

            if (textBoxDisplay.Text == "")
            {
                MessageBox.Show("Introduza os valores necessários à operação.");
            }
            else
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
                        if (textBoxDisplay.Text != "0")
                        {
                            textBoxDisplay.Text = (result / Double.Parse(textBoxDisplay.Text)).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Uma divisão não pode ser feita por 0, visto que dá uma indeterminação. \n (+ ou - Infinito)");
                        }
                        break;

                    case "Mod":
                        double mod = (result % Double.Parse(textBoxDisplay.Text));
                        textBoxDisplay.Text = mod.ToString();
                        break;

                    case "Exp":
                        double exp = Math.Pow(result, Double.Parse(textBoxDisplay.Text));
                        textBoxDisplay.Text = exp.ToString();
                        break;

                    case "%":
                        Double percentage = ((result / 100) * Convert.ToDouble(textBoxDisplay.Text));
                        textBoxDisplay.Text = percentage.ToString();
                        break;

                    default:
                        MessageBox.Show("Something went wrong. Please retry, if the problem presists, please contact VisualStudio from the tool above 'About'.");
                        break;
                }

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
            textBoxDisplay.Text = "0";
            opera = "";
        }


        /// <summary>
        /// SINAL NEGATIVO
        /// Apenas poe sinal negativo se display tiver limpa, e nao repete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMinusState_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text.Contains("-"))
            {
                textBoxDisplay.Text = textBoxDisplay.Text;
            }
            else
            {
                if (textBoxDisplay.Text == "0")
                {
                    textBoxDisplay.Text = "-";
                }
                else
                {
                    textBoxDisplay.Text = textBoxDisplay.Text;
                }
            }
        }

        /// <summary>
        /// Aplica raíz quadrada ao valor que tiver no display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSquareRoot_Click(object sender, EventArgs e)
        {
            double isqrt = Double.Parse(textBoxDisplay.Text);
            isqrt = Math.Sqrt(isqrt);
            textBoxDisplay.Text = isqrt.ToString();
        }

        private void buttonClearEntry_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = "0";
        }

        private void textBoxDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBoxDisplay.Text);
            ilog = Math.Log10(ilog);
            textBoxDisplay.Text = ilog.ToString();
        }

        private void buttonInverse_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(textBoxDisplay.Text));
            textBoxDisplay.Text = a.ToString();
        }

        private void buttonFactorial_Click(object sender, EventArgs e)
        {
            try
            {
                int factorial = Convert.ToInt32(textBoxDisplay.Text);
                int result = 1;

                if (factorial >= 0)
                {
                    if (factorial != 0)
                    {
                        for (int i = factorial; i >= 1; i--)
                        {
                            result = result * i;
                        }
                    }
                    else
                    {
                        textBoxDisplay.Text = "1";
                    }
                }
                else
                {
                    MessageBox.Show("Introduza valores possíveis a fatorializar.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Introduza valores inteiros.");
            }

            textBoxDisplay.Text = result.ToString();
            }

        private void buttonPotentia2_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(textBoxDisplay.Text) * Convert.ToDouble(textBoxDisplay.Text);
            textBoxDisplay.Text = a.ToString();
        }
    }
    }

