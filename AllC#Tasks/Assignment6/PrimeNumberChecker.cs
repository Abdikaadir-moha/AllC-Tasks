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
    public partial class PrimeNumberChecker : Form
    {
        public PrimeNumberChecker()
        {
            InitializeComponent();
        }

        private void PrimeNumberChecker_Load(object sender, EventArgs e)
        {
            BackColor = AppTheme.BackgroundColor;

            // Header
            headerPanel.FillColor = AppTheme.HeaderColor;
            titleLabel.ForeColor = AppTheme.HeaderTextColor;
            titleLabel.Font = AppTheme.HeaderFont;

            // Labels (fix: use correct type for Guna2HtmlLabel)
            foreach (Guna.UI2.WinForms.Guna2HtmlLabel lbl in new Guna.UI2.WinForms.Guna2HtmlLabel[] { numberLabel, resultLabel, messageLabel })
            {
                lbl.ForeColor = AppTheme.TextColor;
                lbl.Font = AppTheme.BodyFont;
            }

            // TextBox
            numberTextBox.FillColor = AppTheme.TextBoxBackColor;
            numberTextBox.BorderColor = AppTheme.TextBoxBorderColor;
            numberTextBox.ForeColor = AppTheme.TextColor;
            numberTextBox.Font = AppTheme.BodyFont;

            // Buttons
            CheckButton.FillColor = AppTheme.PrimaryButtonColor;
            CheckButton.Font = AppTheme.ButtonFont;
            CheckButton.ForeColor = AppTheme.HeaderTextColor;

            ClearButton.FillColor = AppTheme.SecondaryButtonColor;
            ClearButton.Font = AppTheme.ButtonFont;
            ClearButton.ForeColor = AppTheme.HeaderTextColor;

            // Message Label initial
            messageLabel.Text = "";
            messageLabel.ForeColor = AppTheme.InfoColor;
        }

        // Boolean function to check if a number is prime
        private bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(numberTextBox.Text);

                bool prime = IsPrime(num);

                if (prime)
                {
                    resultLabel.Text = $"Result: {num} is a Prime Number";
                    messageLabel.ForeColor = AppTheme.SuccessColor;
                    messageLabel.Text = "Calculation complete!";
                }
                else
                {
                    resultLabel.Text = $"Result: {num} is NOT a Prime Number";
                    messageLabel.ForeColor = AppTheme.WarningColor;
                    messageLabel.Text = "Not a prime number.";
                }

                numberTextBox.Clear();
                numberTextBox.Select();
            }
            catch (FormatException)
            {
                messageLabel.ForeColor = AppTheme.WarningColor;
                messageLabel.Text = "Please enter a valid integer number.";
            }
            catch (Exception ex)
            {
                messageLabel.ForeColor = AppTheme.DangerButtonColor;
                messageLabel.Text = $"Error: {ex.Message}";
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            numberTextBox.Clear();
            resultLabel.Text = "Result: -";
            messageLabel.Text = "";
            messageLabel.ForeColor = AppTheme.InfoColor;

            numberTextBox.Select();
        }
    }
}
