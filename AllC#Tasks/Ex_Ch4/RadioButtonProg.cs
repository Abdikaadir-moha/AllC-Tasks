using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllC_Tasks.Ex_Ch3
{
    public partial class RadioButtonProg : Form
    {
        public RadioButtonProg()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (footballRadioButton.Checked)
            {
                MessageBox.Show("You selected Football.");
            }
            else if (basketballRadioButton.Checked)
            {
                MessageBox.Show("You selected Basketball.");
            }
            else if (baseballRadioButton.Checked)
            {
                MessageBox.Show("You selected Baseball.");
            }
        }

        private void RadioButtonProg_Load(object sender, EventArgs e)
        {

        }
    }
}
