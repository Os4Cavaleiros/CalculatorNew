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

        private void buttonRed_Click(object sender, EventArgs e)
        {
            fr1Local.BackColor = Color.Red;
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            fr1Local.BackColor = Color.Green;
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            fr1Local.BackColor = Color.Blue;
        }
    }
}
