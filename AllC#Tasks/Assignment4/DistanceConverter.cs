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
    public partial class DistanceConverter : Form
    {
        public DistanceConverter()
        {
            InitializeComponent();

            // Populate ListBoxes
            lstFrom.Items.Add("Inches");
            lstFrom.Items.Add("Feet");
            lstFrom.Items.Add("Yards");

            lstTo.Items.Add("Inches");
            lstTo.Items.Add("Feet");
            lstTo.Items.Add("Yards");
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            try
            {
                double value = double.Parse(DistanceTextBox.Text);

                if (value < 0)
                {
                    MessageBox.Show("Distance cannot be negative.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (lstFrom.SelectedItem == null || lstTo.SelectedItem == null)
                {
                    MessageBox.Show("Please select both From and To units.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string fromUnit = lstFrom.SelectedItem?.ToString() ?? string.Empty;
                string toUnit = lstTo.SelectedItem?.ToString() ?? string.Empty;

                // Convert input to inches first
                double inches = fromUnit switch
                {
                    "Feet" => value * 12,
                    "Yards" => value * 36,
                    _ => value
                };

                // Convert inches to target unit
                double result = toUnit switch
                {
                    "Feet" => inches / 12,
                    "Yards" => inches / 36,_ => inches
                };

                LblResult.Text = $"{value} {fromUnit} = {result:F2} {toUnit}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
