using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllC_Tasks.Assignment5
{
    public partial class Population : Form
    {
        public Population()
        {
            InitializeComponent();
        }

        private void Population_Load(object sender, EventArgs e)
        {
            BackColor = AppTheme.BackgroundColor;

            // Header Panel
            guna2Panel1.FillColor = AppTheme.HeaderColor;
            titleLabel.ForeColor = AppTheme.HeaderTextColor;

            // TextBoxes
            startTextBox.FillColor = AppTheme.TextBoxBackColor;
            startTextBox.BorderColor = AppTheme.TextBoxBorderColor;
            startTextBox.ForeColor = AppTheme.TextColor;

            increaseTextBox.FillColor = AppTheme.TextBoxBackColor;
            increaseTextBox.BorderColor = AppTheme.TextBoxBorderColor;
            increaseTextBox.ForeColor = AppTheme.TextColor;

            daysTextBox.FillColor = AppTheme.TextBoxBackColor;
            daysTextBox.BorderColor = AppTheme.TextBoxBorderColor;
            daysTextBox.ForeColor = AppTheme.TextColor;

            // Buttons
            CalculateButton.FillColor = AppTheme.PrimaryButtonColor;
            CalculateButton.ForeColor = Color.White;
            ClearBtn.FillColor = AppTheme.SecondaryButtonColor;

            // ListBox
            populationListBox.BackColor = AppTheme.TextBoxBackColor;
            populationListBox.ForeColor = AppTheme.TextColor;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                populationListBox.Items.Clear();
                // Validate empty inputs
                if (string.IsNullOrWhiteSpace(startTextBox.Text) ||
                    string.IsNullOrWhiteSpace(increaseTextBox.Text) ||
                    string.IsNullOrWhiteSpace(daysTextBox.Text))
                {
                    MessageBox.Show("Please enter all required values.", "Input Missing",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Parse input
                if (!double.TryParse(startTextBox.Text, out double startPop) || startPop <= 0)
                {
                    MessageBox.Show("Starting number must be a positive number.", "Invalid Input",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(increaseTextBox.Text, out double dailyIncrease) || dailyIncrease < 0)
                {
                    MessageBox.Show("Daily increase must be a non-negative number.", "Invalid Input",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(daysTextBox.Text, out int days) || days <= 0)
                {
                    MessageBox.Show("Days must be a positive whole number.", "Invalid Input",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Clear ListBox before new data
                populationListBox.Items.Clear();
                populationListBox.Items.Add("Day\tApproximate Population");

                double population = startPop;
                double rate = dailyIncrease / 100.0;

                for (int day = 1; day <= days; day++)
                {
                    populationListBox.Items.Add($"{day}\t{population:F6}");
                    population += (population * rate);
                }
                
                startTextBox.Clear();
                increaseTextBox.Clear();
                daysTextBox.Clear();

                startTextBox.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            populationListBox.Items.Clear();
        }
    }
}
