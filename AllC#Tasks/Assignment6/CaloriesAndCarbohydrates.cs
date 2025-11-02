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
    public partial class CaloriesAndCarbohydrates : Form
    {
        public CaloriesAndCarbohydrates()
        {
            InitializeComponent();
        }

        private void CaloriesAndCarbohydrates_Load(object sender, EventArgs e)
        {
            BackColor = AppTheme.BackgroundColor;
            headerPanel.FillColor = AppTheme.HeaderColor;
            titleLabel.ForeColor = AppTheme.HeaderTextColor;

            descriptionLabel.ForeColor = AppTheme.TextColor;
            fatLabel.ForeColor = AppTheme.TextColor;
            carbLabel.ForeColor = AppTheme.TextColor;
            resultFatLabel.ForeColor = AppTheme.TextColor;
            resultCarbLabel.ForeColor = AppTheme.TextColor;
            displayFatLabel.ForeColor = AppTheme.InfoColor;
            displayCarbLabel.ForeColor = AppTheme.InfoColor;

            fatTextBox.FillColor = AppTheme.TextBoxBackColor;
            carbTextBox.FillColor = AppTheme.TextBoxBackColor;

            CalculateButton.FillColor = AppTheme.PrimaryButtonColor;
            CalculateButton.ForeColor = Color.White;

            ClearButton.FillColor = AppTheme.SecondaryButtonColor;
            ClearButton.ForeColor = Color.White;

            messageLabel.ForeColor = AppTheme.TextColor;

            fatTextBox.Select();
        }
        // === Calculation Methods ===
        private double FatCalories(double fatGrams)
        {
            return fatGrams * 9;
        }
        private double CarbCalories(double carbGrams)
        {
            return carbGrams * 4;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double fat = double.Parse(fatTextBox.Text);
                double carbs = double.Parse(carbTextBox.Text);

                if (fat < 0 || carbs < 0)
                {
                    messageLabel.Text = "Values must be positive.";
                    messageLabel.ForeColor = AppTheme.WarningColor;
                    return;
                }

                double fatCalories = FatCalories(fat);
                double carbCalories = CarbCalories(carbs);

                displayFatLabel.Text = $"{fatCalories:F2} cal";
                displayCarbLabel.Text = $"{carbCalories:F2} cal";

                messageLabel.Text = "Calories calculated successfully.";
                messageLabel.ForeColor = AppTheme.SuccessColor;

                fatTextBox.Clear();
                fatTextBox.Select();

                messageLabel.Text = "";
            }
            catch
            {
                messageLabel.Text = "Please enter valid numeric values.";
                messageLabel.ForeColor = AppTheme.DangerButtonColor;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            fatTextBox.Clear();
            carbTextBox.Clear();
            displayFatLabel.Text = "0.00 cal";
            displayCarbLabel.Text = "0.00 cal";
            messageLabel.Text = "";

            fatTextBox.Select();
        }
    }
}
