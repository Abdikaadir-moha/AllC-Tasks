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
    public partial class HospitalChargesCalculator : Form
    {
        private const decimal DAILY_RATE = 350m;
        public HospitalChargesCalculator()
        {
            InitializeComponent();
        }

        private void HospitalChargesCalculator_Load(object sender, EventArgs e)
        {
            BackColor = AppTheme.BackgroundColor;
            headerPanel.BackColor = AppTheme.HeaderColor;
            titleLabel.ForeColor = AppTheme.HeaderTextColor;

            // === Textboxes ===
            daysTextBox.FillColor = AppTheme.TextBoxBackColor;
            daysTextBox.BorderColor = AppTheme.TextBoxBorderColor;

            medicationTextBox.FillColor = AppTheme.TextBoxBackColor;
            medicationTextBox.BorderColor = AppTheme.TextBoxBorderColor;

            surgicalTextBox.FillColor = AppTheme.TextBoxBackColor;
            surgicalTextBox.BorderColor = AppTheme.TextBoxBorderColor;

            labTextBox.FillColor = AppTheme.TextBoxBackColor;
            labTextBox.BorderColor = AppTheme.TextBoxBorderColor;

            rehabTextBox.FillColor = AppTheme.TextBoxBackColor;
            rehabTextBox.BorderColor = AppTheme.TextBoxBorderColor;

            // === Buttons ===
            CalculateButton.FillColor = AppTheme.PrimaryButtonColor;
            ClearButton.FillColor = AppTheme.SecondaryButtonColor;

            // === Labels ===
            TotalLabel.ForeColor = AppTheme.TextColor;
            messageLabel.ForeColor = AppTheme.InfoColor;

            daysTextBox.Select();
        }
        // Value-returning methods
        private decimal CalcStayCharges(int days)
        {
            return days * DAILY_RATE;
        }

        private decimal CalcMiscCharges(decimal medication, decimal surgical, decimal lab, decimal rehab)
        {
            return medication + surgical + lab + rehab;
        }

        private decimal CalcTotalCharges(decimal stayCharges, decimal miscCharges)
        {
            return stayCharges + miscCharges;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                messageLabel.ForeColor = AppTheme.InfoColor;
                messageLabel.Text = "";

                if (string.IsNullOrWhiteSpace(daysTextBox.Text) ||
                    string.IsNullOrWhiteSpace(medicationTextBox.Text) ||
                    string.IsNullOrWhiteSpace(surgicalTextBox.Text) ||
                    string.IsNullOrWhiteSpace(labTextBox.Text) ||
                    string.IsNullOrWhiteSpace(rehabTextBox.Text))
                {
                    messageLabel.ForeColor = AppTheme.WarningColor;
                    messageLabel.Text = "Please fill in all fields.";
                    return;
                }

                if (!int.TryParse(daysTextBox.Text.Trim(), out int days) || days < 0)
                {
                    messageLabel.ForeColor = AppTheme.WarningColor;
                    messageLabel.Text = "Days must be a valid non-negative number.";
                    return;
                }

                if (!decimal.TryParse(medicationTextBox.Text.Trim(), out decimal med) || med < 0 ||
                    !decimal.TryParse(surgicalTextBox.Text.Trim(), out decimal surg) || surg < 0 ||
                    !decimal.TryParse(labTextBox.Text.Trim(), out decimal lab) || lab < 0 ||
                    !decimal.TryParse(rehabTextBox.Text.Trim(), out decimal rehab) || rehab < 0)
                {
                    messageLabel.ForeColor = AppTheme.WarningColor;
                    messageLabel.Text = "All charge fields must be non-negative numbers.";
                    return;
                }

                decimal stayCharges = CalcStayCharges(days);
                decimal miscCharges = CalcMiscCharges(med, surg, lab, rehab);
                decimal total = CalcTotalCharges(stayCharges, miscCharges);

                TotalLabel.Text = $"Total Hospital Charges: {total:C}";
                messageLabel.ForeColor = AppTheme.SuccessColor;
                messageLabel.Text = "Calculation completed successfully.";
            }
            catch (Exception ex)
            {
                messageLabel.ForeColor = AppTheme.DangerButtonColor;
                messageLabel.Text = $"Error: {ex.Message}";
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            daysTextBox.Text = "";
            medicationTextBox.Text = "";
            surgicalTextBox.Text = "";
            labTextBox.Text = "";
            rehabTextBox.Text = "";
            TotalLabel.Text = "Total Hospital Charges: -";
            messageLabel.Text = "";
        }
    }
}
