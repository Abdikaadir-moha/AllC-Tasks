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
    public partial class Paint_Job_Estimator : Form
    {
        public Paint_Job_Estimator()
        {
            InitializeComponent();
        }
        private void Paint_Job_Estimator_Load(object sender, EventArgs e)
        {
            squareFeetTextBox.Focus();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Constants
                const double SQUARE_FEET_PER_GALLON = 115.0;
                const double HOURS_PER_GALLON = 8.0;
                const double LABOR_RATE = 20.0;

                // Get input values
                double wallSpace = double.Parse(squareFeetTextBox.Text);
                double pricePerGallon = double.Parse(priceTextBox.Text);

                // Calculate required paint and labor
                double gallonsRequired = Math.Ceiling(wallSpace / SQUARE_FEET_PER_GALLON);
                double hoursRequired = (wallSpace / SQUARE_FEET_PER_GALLON) * HOURS_PER_GALLON;

                // Calculate costs
                double paintCost = gallonsRequired * pricePerGallon;
                double laborCost = hoursRequired * LABOR_RATE;
                double totalCost = paintCost + laborCost;

                // Display results
                gallonsResultLabel.Text = gallonsRequired.ToString("F0");
                hoursResultLabel.Text = hoursRequired.ToString("F1");
                paintCostResultLabel.Text = paintCost.ToString("C");
                laborCostResultLabel.Text = laborCost.ToString("C");
                totalCostResultLabel.Text = totalCost.ToString("C");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for both fields.",
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearButton_Click_1(object sender, EventArgs e)
        {
            // Clear inputs and outputs
            squareFeetTextBox.Clear();
            priceTextBox.Clear();
            gallonsResultLabel.Text = "—";
            hoursResultLabel.Text = "—";
            paintCostResultLabel.Text = "—";
            laborCostResultLabel.Text = "—";
            totalCostResultLabel.Text = "—";

            // Return focus
            squareFeetTextBox.Focus();
        }

    }
}
