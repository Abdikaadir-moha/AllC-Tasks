using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllC_Tasks.Assignment4
{
    public partial class Mass_and_Weight : Form
    {
        public Mass_and_Weight()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse the mass input
                double mass = double.Parse(MassTextBox.Text);

                if (mass < 0)
                {
                    MessageBox.Show("Mass cannot be negative!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double weight = mass * 9.8;

                LblResult.Text = $"Weight = {weight:F2} Newtons";

                // Check for special messages
                if (weight > 1000)
                    MessageBox.Show("The object is too heavy.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (weight < 10)
                    MessageBox.Show("The object is too light.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input! Please enter a numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
