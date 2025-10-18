using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllC_Tasks
{
    public partial class How_Much_Insurance : Form
    {
        public How_Much_Insurance()
        {
            InitializeComponent();
        }

        private void How_Much_Insurance_Load(object sender, EventArgs e)
        {

        }
        private void Calculatebutton_Click_1(object sender, EventArgs e)
        {
            try
            {
                double replacement = double.Parse(RepCostTextBox.Text);
                double insurance = replacement * 0.8;
                Resultlabel.Text = insurance.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

        
}
