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
    public partial class PresentValue : Form
    {
        public PresentValue()
        {
            InitializeComponent();
        }

        private void PresentValue_Load(object sender, EventArgs e)
        {
            BackColor = AppTheme.BackgroundColor;

            // Header
            headerPanel.FillColor = AppTheme.HeaderColor;
            titleLabel.ForeColor = AppTheme.HeaderTextColor;
            titleLabel.Font = AppTheme.HeaderFont;

            // Labels
            Guna.UI2.WinForms.Guna2HtmlLabel[] array = new Guna.UI2.WinForms.Guna2HtmlLabel[] { futureLabel, rateLabel, yearsLabel, presentLabel, messageLabel };
            for (int i = 0; i < array.Length; i++)
            {
                Guna.UI2.WinForms.Guna2HtmlLabel lbl = array[i];
                lbl.ForeColor = AppTheme.TextColor;
                lbl.Font = AppTheme.BodyFont;
            }

            // TextBoxes
            foreach (Guna.UI2.WinForms.Guna2TextBox tb in new Guna.UI2.WinForms.Guna2TextBox[] { futureTextBox, rateTextBox, yearsTextBox })
            {
                tb.FillColor = AppTheme.TextBoxBackColor;
                tb.BorderColor = AppTheme.TextBoxBorderColor;
                tb.ForeColor = AppTheme.TextColor;
                tb.Font = AppTheme.BodyFont;
            }

            // Buttons
            CalculateButton.FillColor = AppTheme.PrimaryButtonColor;
            CalculateButton.Font = AppTheme.ButtonFont;
            CalculateButton.ForeColor = AppTheme.HeaderTextColor;

            ClearButton.FillColor = AppTheme.SecondaryButtonColor;
            ClearButton.Font = AppTheme.ButtonFont;
            ClearButton.ForeColor = AppTheme.HeaderTextColor;

            // Message Label initial
            messageLabel.Text = "";
            messageLabel.ForeColor = AppTheme.InfoColor;

            futureTextBox.Select();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Read inputs
                double F = double.Parse(futureTextBox.Text);
                double r = double.Parse(rateTextBox.Text) / 100; // convert % to decimal
                int n = int.Parse(yearsTextBox.Text);

                // Calculate
                double P = F / Math.Pow(1 + r, n);

                // Show result
                presentLabel.Text = $"Present Value Needed: ${P:F2}";
                messageLabel.ForeColor = AppTheme.SuccessColor;
                messageLabel.Text = "Calculation successful!";

                futureTextBox.Clear();
                futureTextBox.Select();
            }
            catch (FormatException)
            {
                messageLabel.ForeColor = AppTheme.WarningColor;
                messageLabel.Text = "Please enter valid numeric values in all fields.";
            }
            catch (Exception ex)
            {
                messageLabel.ForeColor = AppTheme.DangerButtonColor;
                messageLabel.Text = $"Error: {ex.Message}";
            }
        }
    }
}
