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
    public partial class ModularizingBoolean_Tutorial_6_5 : Form
    {
        private const decimal CONTRIB_RATE = 0.05m; // 5% contribution rate
        public ModularizingBoolean_Tutorial_6_5()
        {
            InitializeComponent();
        }

        private void ModularizingBoolean_Tutorial_6_5_Load(object sender, EventArgs e)
        {
            BackColor = AppTheme.BackgroundColor;

            // Header
            headerPanel.BackColor = AppTheme.HeaderColor;
            titleLabel.ForeColor = AppTheme.HeaderTextColor;

            // Labels
            grossPayLabel.ForeColor = AppTheme.TextColor;
            bonusLabel.ForeColor = AppTheme.TextColor;
            contributionTitleLabel.ForeColor = AppTheme.TextColor;
            contributionLabel.ForeColor = AppTheme.TextColor;
            messageLabel.ForeColor = AppTheme.InfoColor;

            // TextBoxes
            grossPayTextBox.FillColor = AppTheme.TextBoxBackColor;
            grossPayTextBox.BorderColor = AppTheme.TextBoxBorderColor;
            grossPayTextBox.ForeColor = AppTheme.TextColor;

            bonusTextBox.FillColor = AppTheme.TextBoxBackColor;
            bonusTextBox.BorderColor = AppTheme.TextBoxBorderColor;
            bonusTextBox.ForeColor = AppTheme.TextColor;

            // Buttons
            CalculateButton.FillColor = AppTheme.PrimaryButtonColor;
            CalculateButton.ForeColor = Color.White;


            ClearBtn.FillColor = AppTheme.SecondaryButtonColor;
            ClearBtn.ForeColor = Color.White;

            grossPayTextBox.Select();

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                messageLabel.Text = "";
                contributionLabel.Text = "";

                // Variables
                decimal grossPay = 0m, bonus = 0m, contribution = 0m;

                // Input validation
                bool isValid = true;

                if (!decimal.TryParse(grossPayTextBox.Text.Trim(), out grossPay))
                {
                    messageLabel.ForeColor = AppTheme.DangerButtonColor;
                    messageLabel.Text = "Gross pay is invalid.";
                    isValid = false;
                }
                else if (!decimal.TryParse(bonusTextBox.Text.Trim(), out bonus))
                {
                    messageLabel.ForeColor = AppTheme.DangerButtonColor;
                    messageLabel.Text = "Bonus amount is invalid.";
                    isValid = false;
                }

                if (!isValid)
                    return;

                // Calculate contribution
                contribution = (grossPay + bonus) * CONTRIB_RATE;
                contributionLabel.Text = contribution.ToString("C");

                messageLabel.ForeColor = AppTheme.SuccessColor;
                messageLabel.Text = "Retirement contribution calculated successfully.";


                grossPayTextBox.Clear();
                grossPayTextBox.Select();
                bonusTextBox.Clear();
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
            contributionLabel.Text = "";
            grossPayTextBox.Clear();
            bonusTextBox.Clear();
            grossPayTextBox.Select();
        }
    }
}
