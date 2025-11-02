using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllC_Tasks.Assignment6
{
    public partial class FallingDistanceCalculator : Form
    {
        public FallingDistanceCalculator()
        {
            InitializeComponent();
        }

        private void FallingDistanceCalculator_Load(object sender, EventArgs e)
        {
            BackColor = AppTheme.BackgroundColor;
            headerPanel.FillColor = AppTheme.HeaderColor;
            titleLabel.ForeColor = AppTheme.HeaderTextColor;

            descriptionLabel.ForeColor = AppTheme.TextColor;
            timeLabel.ForeColor = AppTheme.TextColor;
            resultLabel.ForeColor = AppTheme.TextColor;
            displayLabel.ForeColor = AppTheme.InfoColor;

            timeTextBox.BackColor = AppTheme.TextBoxBackColor;

            CalculateButton.FillColor = AppTheme.PrimaryButtonColor;
            CalculateButton.ForeColor = Color.White;

            ClearButton.FillColor = AppTheme.SecondaryButtonColor;
            ClearButton.ForeColor = Color.White;

            messageLabel.ForeColor = AppTheme.TextColor;

            timeTextBox.Select();
        }
        // ⚙️ Method: FallingDistance
        private double FallingDistance(double time)
        {
            const double g = 9.8; // gravity constant
            return 0.5 * g * Math.Pow(time, 2);
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double time = double.Parse(timeTextBox.Text);

                if (time < 0)
                {
                    messageLabel.Text = "Please enter a positive time value.";
                    messageLabel.ForeColor = AppTheme.WarningColor;

                    timeTextBox.Clear();
                    timeTextBox.Select();
                    return;
                }

                double distance = FallingDistance(time);
                displayLabel.Text = $"{distance:F2} meters";
                displayLabel.ForeColor = AppTheme.SuccessColor;

                messageLabel.Text = "Calculation successful!";
                messageLabel.ForeColor = AppTheme.SuccessColor;

                timeTextBox.Clear();
                timeTextBox.Select();

                messageLabel.Text = "";
            }
            catch
            {
                messageLabel.Text = "Please enter a valid numeric value for time.";
                messageLabel.ForeColor = AppTheme.DangerButtonColor;
                timeTextBox.Select();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            timeTextBox.Clear();
            displayLabel.Text = "0.00 meters";
            messageLabel.Text = "";
        }
    }
}
