using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllC_Tasks.Assignment4
{
    public partial class Fat_Percentage_Calculator : Form
    {
        public Fat_Percentage_Calculator()
        {
            InitializeComponent();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Get user input
                double totalCalories = double.Parse(totalCaloriesTextBox.Text);
                double fatGrams = double.Parse(fatGramsTextBox.Text);

                // Validate input
                if (totalCalories <= 0 || fatGrams < 0)
                {
                    MessageBox.Show("Calories and fat grams must be greater than 0.",
                                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Calculate calories from fat
                double caloriesFromFat = fatGrams * 9;

                // Validate calories logic
                if (caloriesFromFat > totalCalories)
                {
                    MessageBox.Show("Calories from fat cannot exceed total calories.",
                                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Calculate percentage
                double fatPercentage = (caloriesFromFat / totalCalories) * 100;

                // Display results
                caloriesFromFatResultLabel.Text = caloriesFromFat.ToString("F0");
                percentageResultLabel.Text = fatPercentage.ToString("F1") + "%";

                // Optional: Check if user wants to see low-fat message
                if (lowFatCheckBox.Checked)
                {
                    if (fatPercentage < 30)
                    {
                        messageLabel.Text = "This is a low-fat food.";
                        messageLabel.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        messageLabel.Text = "This food is not low-fat.";
                        messageLabel.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else
                {
                    messageLabel.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please enter valid numeric values for calories and fat grams.",
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            totalCaloriesTextBox.Clear();
            fatGramsTextBox.Clear();
            caloriesFromFatResultLabel.Text = "";
            percentageResultLabel.Text = "";
            messageLabel.Text = "";

            totalCaloriesTextBox.Focus();
        }
    }
}
