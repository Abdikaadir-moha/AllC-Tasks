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
    public partial class CheckBoxProg : Form
    {
        public CheckBoxProg()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (pepperoniCheckBox.Checked)
            {
                MessageBox.Show("You selected Pepperoni.");
            }

            if (cheeseCheckBox.Checked)
            {
                MessageBox.Show("You selected Cheese.");
            }

            if (anchoviesCheckBox.Checked)
            {
                MessageBox.Show("You selected Anchovies.");
            }
        }
    }
}
