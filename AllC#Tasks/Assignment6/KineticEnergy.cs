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
    public partial class KineticEnergy : Form
    {
        public KineticEnergy()
        {
            InitializeComponent();
        }

        private void KineticEnergy_Load(object sender, EventArgs e)
        {
            BackColor = AppTheme.BackgroundColor;
            headerPanel.FillColor = AppTheme.HeaderColor;
            titleLabel.ForeColor = AppTheme.HeaderTextColor;

            descriptionLabel.ForeColor = AppTheme.TextColor;
            massLabel.ForeColor = AppTheme.TextColor;
            velocityLabel.ForeColor = AppTheme.TextColor;
            resultLabel.ForeColor = AppTheme.TextColor;
            displayLabel.ForeColor = AppTheme.InfoColor;

            massTextBox.FillColor = AppTheme.TextBoxBackColor;
            velocityTextBox.FillColor = AppTheme.TextBoxBackColor;

            CalculateButton.FillColor = AppTheme.PrimaryButtonColor;
            CalculateButton.ForeColor = Color.White;

            ClearButton.FillColor = AppTheme.SecondaryButtonColor;
            ClearButton.ForeColor = Color.White;

            messageLabel.ForeColor = AppTheme.TextColor;

            massTextBox.Select();
        }
        // Method: KineticEnergy
        private double KineticEnergyCalculation(double mass, double velocity)
        {
            return 0.5 * mass * Math.Pow(velocity, 2);
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double mass = double.Parse(massTextBox.Text);
                double velocity = double.Parse(velocityTextBox.Text);

                if (mass < 0 || velocity < 0)
                {
                    messageLabel.Text = "Mass and velocity must be positive values.";
                    messageLabel.ForeColor = AppTheme.WarningColor;
                    return;
                }

                double energy = KineticEnergyCalculation(mass, velocity);
                displayLabel.Text = $"{energy:F2} Joules";
                displayLabel.ForeColor = AppTheme.SuccessColor;

                messageLabel.Text = "Calculation successful.";
                messageLabel.ForeColor = AppTheme.SuccessColor;

                messageLabel.Text = " ";
            }
            catch
            {
                messageLabel.Text = "Please enter valid numeric values for mass and velocity.";
                messageLabel.ForeColor = AppTheme.DangerButtonColor;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            massTextBox.Clear();
            velocityTextBox.Clear();
            displayLabel.Text = "0.00 Joules";
            messageLabel.Text = "";

            massTextBox.Select();
        }
    }
}
