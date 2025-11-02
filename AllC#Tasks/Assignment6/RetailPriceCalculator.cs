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
    public partial class RetailPriceCalculator : Form
    {
        public RetailPriceCalculator()
        {
            InitializeComponent();
        }

        private void RetailPriceCalculator_Load(object sender, EventArgs e)
        {
            BackColor = AppTheme.BackgroundColor;
            headerPanel.FillColor = AppTheme.HeaderColor;
            titleLabel.ForeColor = AppTheme.HeaderTextColor;


            wholesaleLabel.ForeColor = AppTheme.TextColor;
            markupLabel.ForeColor = AppTheme.TextColor;
            resultLabel.ForeColor = AppTheme.TextColor;
            displayLabel.ForeColor = AppTheme.InfoColor;

            wholesaleTextBox.BackColor = AppTheme.TextBoxBackColor;
            markupTextBox.BackColor = AppTheme.TextBoxBackColor;

            CalculateButton.FillColor = AppTheme.PrimaryButtonColor;
            CalculateButton.ForeColor = Color.White;

            ClearBtn.FillColor = AppTheme.SecondaryButtonColor;
            ClearBtn.ForeColor = Color.White;

            messageLabel.ForeColor = AppTheme.TextColor;

            wholesaleTextBox.Select();
        }

        // 📘 Method: Calculate Retail
        private double CalculateRetail(double wholesale, double markupPercent)
        {
            return wholesale + (wholesale * (markupPercent / 100));
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double wholesale = double.Parse(wholesaleTextBox.Text);
                double markup = double.Parse(markupTextBox.Text);

                if (wholesale < 0 || markup < 0)
                {
                    messageLabel.Text = "Please enter positive values.";
                    messageLabel.ForeColor = AppTheme.WarningColor;
                    return;
                }

                double retailPrice = CalculateRetail(wholesale, markup);
                displayLabel.Text = $"Retail Price: {retailPrice:C2}";
                displayLabel.ForeColor = AppTheme.SuccessColor;

                messageLabel.Text = "Calculation successful!";
                messageLabel.ForeColor = AppTheme.SuccessColor;

                wholesaleTextBox.Select();
                wholesaleTextBox.Clear();
                markupTextBox.Clear();

                messageLabel.Text = "";
            }
            catch
            {
                messageLabel.Text = "Please enter valid numeric values.";
                messageLabel.ForeColor = AppTheme.DangerButtonColor;
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            wholesaleTextBox.Clear();
            markupTextBox.Clear();
            displayLabel.Text = "—";
            messageLabel.Text = "";

            wholesaleTextBox.Select();
        }
    }
}
