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
    public partial class Automobile_Costs : Form
    {
        public Automobile_Costs()
        {
            InitializeComponent();
        }

        private void calculateButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Read values from textboxes
                double loan = double.Parse(loanTextBox.Text);
                double insurance = double.Parse(insuranceTextBox.Text);
                double gas = double.Parse(gasTextBox.Text);
                double oil = double.Parse(oilTextBox.Text);
                double tires = double.Parse(tiresTextBox.Text);
                double maintenance = double.Parse(maintenanceTextBox.Text);

                // Calculate total monthly cost
                double totalMonthly = loan + insurance + gas + oil + tires + maintenance;

                // Calculate total annual cost
                double totalAnnual = totalMonthly * 12;

                // Display results
                monthlyResultLabel.Text = totalMonthly.ToString("C");
                annualResultLabel.Text = totalAnnual.ToString("C");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for all fields.",
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearButton_Click_1(object sender, EventArgs e)
        {
            // Clear all textboxes
            loanTextBox.Clear();
            insuranceTextBox.Clear();
            gasTextBox.Clear();
            oilTextBox.Clear();
            tiresTextBox.Clear();
            maintenanceTextBox.Clear();

            // Clear results
            monthlyResultLabel.Text = "—";
            annualResultLabel.Text = "—";

            // Set focus back to first textbox
            loanTextBox.Focus();
        }
    }
}
