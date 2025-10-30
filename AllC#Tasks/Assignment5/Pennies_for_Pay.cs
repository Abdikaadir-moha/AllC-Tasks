using System;
using System.Windows.Forms;

namespace AllC_Tasks.Assignment5
{
    public partial class Pennies_for_Pay : Form
    {
        public Pennies_for_Pay()
        {
            InitializeComponent();
        }

        private void Pennies_for_Pay_Load(object sender, EventArgs e)
        {
            BackColor = AppTheme.BackgroundColor;

            headerPanel.FillColor = AppTheme.HeaderColor;
            titleLabel.ForeColor = AppTheme.HeaderTextColor;

            daysTextBox.FillColor = AppTheme.TextBoxBackColor;
            daysTextBox.BorderColor = AppTheme.TextBoxBorderColor;
            daysTextBox.ForeColor = AppTheme.TextColor;

            CalculateButton.FillColor = AppTheme.PrimaryButtonColor;
            CalculateButton.ForeColor = Color.White;

            ClearBtn.FillColor = AppTheme.SecondaryButtonColor;
            ClearBtn.ForeColor = AppTheme.TextColor;

            payListBox.BackColor = AppTheme.TextBoxBackColor;
            payListBox.ForeColor = AppTheme.TextColor;
            totalLabel.ForeColor = AppTheme.TextColor;
            //totalLabel.BackColor = AppTheme.TextBoxBackColor;

            daysTextBox.Clear();
            daysTextBox.Focus();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(daysTextBox.Text))
                {
                    MessageBox.Show("Please enter the number of days worked.", "Missing Input",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(daysTextBox.Text, out int days) || days <= 0)
                {
                    MessageBox.Show("Please enter a valid positive number of days.", "Invalid Input",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                payListBox.Items.Clear();
                payListBox.Items.Add("Day\tPay (in dollars)");

                double payInPennies = 1;
                double totalPay = 0;

                for (int day = 1; day <= days; day++)
                {
                    double dailyPayDollars = payInPennies / 100.0;
                    payListBox.Items.Add($"{day}\t{dailyPayDollars:C2}");
                    totalPay += dailyPayDollars;
                    payInPennies *= 2; // double each day
                }

                totalLabel.Text = $"Total Pay: {totalPay:C2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating pay: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            payListBox.Items.Clear();

            daysTextBox.Clear();
            daysTextBox.Focus();
            totalLabel.Text = string.Empty;
        }
    }
}
