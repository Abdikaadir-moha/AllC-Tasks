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
    public partial class ReturnMethod_Tutorial_6_4 : Form
    {
        public ReturnMethod_Tutorial_6_4()
        {
            InitializeComponent();
        }

        private void ReturnMethod_Tutorial_6_4_Load(object sender, EventArgs e)
        {
            BackColor = AppTheme.BackgroundColor;

            // Header
            headerPanel.BackColor = AppTheme.HeaderColor;
            titleLabel.ForeColor = AppTheme.HeaderTextColor;

            // Labels
            cupsLabel.ForeColor = AppTheme.TextColor;
            ouncesTitleLabel.ForeColor = AppTheme.TextColor;
            ouncesLabel.ForeColor = AppTheme.TextColor; // will show the output
            messageLabel.ForeColor = AppTheme.InfoColor; // default message color

            // TextBox for input
            cupsTextBox.FillColor = AppTheme.TextBoxBackColor;
            cupsTextBox.BorderColor = AppTheme.TextBoxBorderColor;
            cupsTextBox.ForeColor = AppTheme.TextColor;

            // Buttons
            ConvertButton.FillColor = AppTheme.PrimaryButtonColor;
            ConvertButton.ForeColor = Color.White;

            cupsTextBox.Select();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            try
            {
                messageLabel.Text = "";
                ouncesLabel.Text = "";

                string input = cupsTextBox.Text.Trim();
                if (string.IsNullOrEmpty(input))
                {
                    messageLabel.ForeColor = AppTheme.WarningColor;
                    messageLabel.Text = "Please enter the number of cups.";
                    return;
                }

                if (!double.TryParse(input, out double cups))
                {
                    messageLabel.ForeColor = AppTheme.DangerButtonColor;
                    messageLabel.Text = "Invalid number. Enter a numeric value.";
                    return;
                }

                double ounces = cups * 8.0;
                ouncesLabel.Text = ounces.ToString("N2");

                messageLabel.ForeColor = AppTheme.SuccessColor;
                messageLabel.Text = $"Converted successfully: {cups} cup(s) = {ounces:N2} fl oz.";
            }
            catch (Exception ex)
            {
                messageLabel.ForeColor = AppTheme.DangerButtonColor;
                messageLabel.Text = $"Error: {ex.Message}";
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "";
            ouncesLabel.Text = "";
            
            cupsTextBox.Clear();

            cupsTextBox.Select();
        }
    }
}
