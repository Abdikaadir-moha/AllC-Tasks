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
    public partial class Calculating_Fuel_Economy : Form
    {
        public Calculating_Fuel_Economy()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double miles;   // To hold miles driven  
                double gallons; // To hold gallons used  
                double mpg;     // To hold miles per gallon  

                // Validate the milesTextBox control  
                if (double.TryParse(milesTextBox.Text, out miles))
                {
                    // Validate the gallonsTextBox control  
                    if (double.TryParse(gallonsTextBox.Text, out gallons))
                    {
                        if (gallons > 0)
                        {
                            // Calculate MPG  
                            mpg = miles / gallons;

                            // Display the MPG in the mpgLabel control  
                            mpgLabel.Text = mpg.ToString("n1");
                        }
                        else
                        {
                            MessageBox.Show("Gallons must be greater than zero.");
                        }
                    }
                    else
                    {
                        // Display an error message for gallonsTextBox  
                        MessageBox.Show("Invalid input for gallons.");
                    }
                }
                else
                {
                    // Display an error message for milesTextBox  
                    MessageBox.Show("Invalid input for miles.");
                }
            }
            catch (Exception ex)
            {
                // Display an error message for any unexpected exception  
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            // Clear all input and output fields
            milesTextBox.Clear();
            gallonsTextBox.Clear();
            mpgLabel.Text = string.Empty;

            // Set focus to the milesTextBox
            milesTextBox.Focus();

        }
    }
}
