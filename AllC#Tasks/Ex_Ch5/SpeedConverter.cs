using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AllC_Tasks;

namespace Wholeproject
{
    public partial class SpeedConverter : Form
    {
        public SpeedConverter()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Constants
                const int START_SPEED = 60;
                const int END_SPEED = 130;
                const int INTERVAL = 10;
                const double CONVERSION_FACTOR = 0.6214;

                // Variables  
                int kph;        // Kilometers per hour  
                double mph;     // Miles per hour  

                // Clear previous output (optional but recommended)
                outputListBox.Items.Clear();

                // Display the table of speeds.  
                for (kph = START_SPEED; kph <= END_SPEED; kph += INTERVAL)
                {
                    // Calculate miles per hour.  
                    mph = kph * CONVERSION_FACTOR;

                    // Display the conversion.  
                    outputListBox.Items.Add(kph + " KPH is the same as " +
                        mph.ToString("F1") + " MPH");
                }
            }
            catch (Exception ex)
            {
                // Handle any unexpected runtime errors
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            outputListBox.Items.Clear();
        }

        private void SpeedConverter_Load(object sender, EventArgs e)
        {
            BackColor = AppTheme.BackgroundColor;
            headerPanel.FillColor = AppTheme.HeaderColor;
            titleLabel.ForeColor = AppTheme.HeaderTextColor;

            CalculateButton.FillColor = AppTheme.PrimaryButtonColor;
            CalculateButton.ForeColor = Color.White;

            ClearButton.FillColor = AppTheme.SecondaryButtonColor;
            ClearButton.ForeColor = Color.White;
        }
    }
}
