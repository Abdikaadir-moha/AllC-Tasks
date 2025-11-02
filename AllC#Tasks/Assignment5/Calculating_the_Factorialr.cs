using System;
using System.Numerics;
using System.Windows.Forms;

namespace AllC_Tasks.Assignment5
{
    public partial class Calculating_the_Factorialr : Form
    {
        public Calculating_the_Factorialr()
        {
            InitializeComponent();
        }

        private void Calculating_the_Factorialr_Load(object sender, EventArgs e)
        {
            BackColor = AppTheme.BackgroundColor;
            headerPanel.FillColor = AppTheme.HeaderColor;
            titleLabel.ForeColor = AppTheme.HeaderTextColor;

            descriptionLabel.ForeColor = AppTheme.TextColor;
            descriptionLabel.BackColor = AppTheme.TextBoxBackColor;

            numberTextBox.FillColor = AppTheme.TextBoxBackColor;
            numberTextBox.ForeColor = AppTheme.TextColor;
            numberTextBox.BorderColor = AppTheme.TextBoxBorderColor;

            CalculateButton.FillColor = AppTheme.PrimaryButtonColor;
            CalculateButton.ForeColor = Color.White;

            ClearBtn.FillColor = AppTheme.SecondaryButtonColor;
            ClearBtn.ForeColor = Color.White;

            stepsListBox.BackColor = AppTheme.TextBoxBackColor;
            stepsListBox.ForeColor = AppTheme.TextColor;

            messageLabel.ForeColor = AppTheme.InfoColor;
            messageLabel.BackColor = AppTheme.TextBoxBackColor;

            numberTextBox.Select();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            stepsListBox.Items.Clear();
            messageLabel.Text = "";

            if (!int.TryParse(numberTextBox.Text.Trim(), out int number))
            {
                messageLabel.ForeColor = AppTheme.DangerButtonColor;
                messageLabel.Text = "Please enter a valid integer number.";
                return;
            }

            if (number < 0)
            {
                messageLabel.ForeColor = AppTheme.DangerButtonColor;
                messageLabel.Text = "Number must be nonnegative.";
                return;
            }

            BigInteger factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
                stepsListBox.Items.Add($"Step {i}: {i}! = {factorial}");
            }

            messageLabel.ForeColor = AppTheme.SuccessColor;
            messageLabel.Text = $"{number}! = {factorial:N0}";
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            numberTextBox.Clear();
            stepsListBox.Items.Clear();
            messageLabel.Text = "";

            numberTextBox.Select();
        }
    }
}
