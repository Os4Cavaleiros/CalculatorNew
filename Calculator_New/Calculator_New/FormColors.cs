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
    public partial class FormColors : Form
    {
        Form1 fr1Local;

        public FormColors(Form1 fr1)
        {
            InitializeComponent();
            fr1Local = fr1;
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////// DEFAULT COLOURS ///////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Altera todas as cores para default
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTransparent_Click(object sender, EventArgs e)
        {
            fr1Local.MainMenuStrip.BackColor = DefaultBackColor;
            fr1Local.MainMenuStrip.ForeColor = DefaultForeColor;
            fr1Local.BackColor = DefaultBackColor;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////// ALTERA AS CORES PARA A COR DO BOTAO /////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////// E O MENU STRIP PARA UMA COR MAIS DARK ///////////////////////////////////////////////////////////////////

        /// <summary>
        /// Altera no main form a cor background
        /// Do menu strip
        /// E a cor da font do menu strip para branco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRed_Click(object sender, EventArgs e)
        {
            fr1Local.BackColor = Color.Red;
            fr1Local.MainMenuStrip.BackColor = Color.DarkRed;
            fr1Local.MainMenuStrip.ForeColor = Color.White;
        }

        /// <summary>
        /// Altera no main form a cor background e do menu strip para a do botão
        /// Do menu strip
        /// E a cor da font do menu strip para branco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGreen_Click(object sender, EventArgs e)
        {
            fr1Local.BackColor = Color.Green;
            fr1Local.MainMenuStrip.BackColor = Color.DarkGreen;
            fr1Local.MainMenuStrip.ForeColor = Color.White;
        }

        /// <summary>
        /// Altera no main form a cor background e do menu strip para a do botão
        /// Do menu strip
        /// E a cor da font do menu strip para branco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBlue_Click(object sender, EventArgs e)
        {
            fr1Local.BackColor = Color.Blue;
            fr1Local.MainMenuStrip.BackColor = Color.DarkBlue;
            fr1Local.MainMenuStrip.ForeColor = Color.White;
        }

        /// <summary>
        /// Altera no main form a cor background e do menu strip para a do botão
        /// Do menu strip
        /// E a cor da font do menu strip para branco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOrange_Click(object sender, EventArgs e)
        {
            fr1Local.BackColor = Color.Orange;
            fr1Local.MainMenuStrip.BackColor = Color.DarkOrange;
            fr1Local.MainMenuStrip.ForeColor = Color.White;
        }

        /// <summary>
        /// Altera no main form a cor background e do menu strip para a do botão
        /// Do menu strip
        /// E a cor da font do menu strip para branco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonYellow_Click(object sender, EventArgs e)
        {
            fr1Local.BackColor = Color.Yellow;
            fr1Local.MainMenuStrip.BackColor = Color.Orange;
            fr1Local.MainMenuStrip.ForeColor = Color.White;
        }

        /// <summary>
        /// Altera no main form a cor background e do menu strip para a do botão
        /// Do menu strip
        /// E a cor da font do menu strip para branco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPink_Click(object sender, EventArgs e)
        {
            fr1Local.BackColor = Color.Fuchsia;
            fr1Local.MainMenuStrip.BackColor = Color.DarkMagenta;
            fr1Local.MainMenuStrip.ForeColor = Color.White;
        }
    }
}
