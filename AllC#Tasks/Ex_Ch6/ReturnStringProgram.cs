using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllC_Tasks.Ex_Ch6
{
    public partial class ReturnStringProgram : Form
    {
        public ReturnStringProgram()
        {
            InitializeComponent();
        }

        private void ReturnStringProgram_Load(object sender, EventArgs e)
        {
            BackColor = AppTheme.BackgroundColor;

            // Header
            headerPanel.BackColor = AppTheme.HeaderColor;
            titleLabel.ForeColor = AppTheme.HeaderTextColor;

            // Labels
            firstNameLabel.ForeColor = AppTheme.TextColor;
            middleNameLabel.ForeColor = AppTheme.TextColor;
            lastNameLabel.ForeColor = AppTheme.TextColor;
            yourFullNameLabel.ForeColor = AppTheme.TextColor;
            fullNameLabel.ForeColor = AppTheme.TextColor;
            messageLabel.ForeColor = AppTheme.InfoColor;

            // TextBoxes
            firstNameTextBox.FillColor = AppTheme.TextBoxBackColor;
            firstNameTextBox.BorderColor = AppTheme.TextBoxBorderColor;
            firstNameTextBox.ForeColor = AppTheme.TextColor;

            middleNameTextBox.FillColor = AppTheme.TextBoxBackColor;
            middleNameTextBox.BorderColor = AppTheme.TextBoxBorderColor;
            middleNameTextBox.ForeColor = AppTheme.TextColor;

            lastNameTextBox.FillColor = AppTheme.TextBoxBackColor;
            lastNameTextBox.BorderColor = AppTheme.TextBoxBorderColor;
            lastNameTextBox.ForeColor = AppTheme.TextColor;

            // Buttons
            ShowFullNameButton.FillColor = AppTheme.PrimaryButtonColor;
            ShowFullNameButton.ForeColor = Color.White;

            ClearBtn.FillColor = AppTheme.SecondaryButtonColor;
            ClearBtn.ForeColor = Color.White;

            firstNameTextBox.Select();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Clear();
            middleNameTextBox.Clear();
            lastNameTextBox.Clear();
            fullNameLabel.Text = string.Empty;
            messageLabel.Text = string.Empty;

            firstNameTextBox.Select();
        }

        private void ShowFullNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                messageLabel.Text = "";
                fullNameLabel.Text = "";

                // Get user input
                string first = firstNameTextBox.Text.Trim();
                string middle = middleNameTextBox.Text.Trim();
                string last = lastNameTextBox.Text.Trim();

                // Validation
                if (string.IsNullOrWhiteSpace(first))
                {
                    messageLabel.ForeColor = AppTheme.DangerButtonColor;
                    messageLabel.Text = "Please enter your first name.";
                    return;
                }

                if (string.IsNullOrWhiteSpace(last))
                {
                    messageLabel.ForeColor = AppTheme.DangerButtonColor;
                    messageLabel.Text = "Please enter your last name.";
                    return;
                }

                // Build full name
                string fullName = $"{first} {middle} {last}".Replace("  ", " ").Trim();

                // Display full name
                fullNameLabel.Text = fullName;
                messageLabel.ForeColor = AppTheme.SuccessColor;
                messageLabel.Text = "Full name displayed successfully.";
            }
            catch (Exception ex)
            {
                messageLabel.ForeColor = AppTheme.DangerButtonColor;
                messageLabel.Text = $"Error: {ex.Message}";
            }
        }
    }
}
