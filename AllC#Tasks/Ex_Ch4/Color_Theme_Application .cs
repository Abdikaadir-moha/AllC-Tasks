using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllC_Tasks.Ex_Ch4
{
    public partial class Color_Theme_Application : Form
    {
        public Color_Theme_Application()
        {
            InitializeComponent();
        }

        private void YellowRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (YellowRadioButton.Checked)
            {
                BackColor = Color.Yellow;
                ForeColor = Color.Black;
            }
        }

        private void RedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (RedRadioButton.Checked)
            {
                BackColor = Color.Red;
                ForeColor = Color.White;
            }
        }

        private void WhiteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (WhiteRadioButton.Checked)
            {
                BackColor = Color.White;
                ForeColor = Color.Black;
            }
        }

        private void NormalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (NormalRadioButton.Checked) { 
                BackColor = Color.SteelBlue;
                ForeColor = Color.White;
            }
        }
    }
}
