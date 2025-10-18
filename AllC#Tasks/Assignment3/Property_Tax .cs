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
    public partial class Property_Tax : Form
    {
        public Property_Tax()
        {
            InitializeComponent();
        }

        private void Property_Tax_Load(object sender, EventArgs e)
        {
            valueTextBox.Focus();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Read property value
                double propertyValue = double.Parse(valueTextBox.Text);

                // Tax rate: 64 cents per $100
                const double TAX_RATE = 0.64;

                // Calculate property tax
                double tax = (propertyValue / 100) * TAX_RATE;

                // Display the result as currency
                taxResultLabel.Text = tax.ToString("C");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric value for the property.",
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clear inputs and outputs
            valueTextBox.Clear();
            taxResultLabel.Text = "—";

            // Return focus
            valueTextBox.Focus();
        }
    }
}
