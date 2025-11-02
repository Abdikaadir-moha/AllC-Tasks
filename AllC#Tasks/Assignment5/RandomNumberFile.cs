using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace AllC_Tasks.Assignment5
{
    public partial class RandomNumberFile : Form
    {
        Random rand = new Random();
        public RandomNumberFile()
        {
            InitializeComponent();
        }
        private void RandomNumberFile_Load(object sender, EventArgs e)
        {
            // Apply AppTheme colors (only colors)
            BackColor = AppTheme.BackgroundColor;
            headerPanel.FillColor = AppTheme.HeaderColor;
            titleLabel.ForeColor = AppTheme.HeaderTextColor;

            descriptionLabel.ForeColor = AppTheme.TextColor;
            descriptionLabel.BackColor = AppTheme.TextBoxBackColor;
            countLabel.ForeColor = AppTheme.TextColor;

            countTextBox.FillColor = AppTheme.TextBoxBackColor;
            countTextBox.ForeColor = AppTheme.TextColor;
            countTextBox.BorderColor = AppTheme.TextBoxBorderColor;

            GenerateButton.FillColor = AppTheme.PrimaryButtonColor;
            ClearButton.FillColor = AppTheme.SecondaryButtonColor;

            messageLabel.ForeColor = AppTheme.TextColor;

            countTextBox.Select();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(countTextBox.Text))
                {
                    messageLabel.Text = "Please enter how many random numbers to generate.";
                    messageLabel.ForeColor = AppTheme.WarningColor;
                    return;
                }

                if (!int.TryParse(countTextBox.Text, out int count) || count <= 0)
                {
                    messageLabel.Text = "Please enter a valid positive number.";
                    messageLabel.ForeColor = AppTheme.WarningColor;
                    return;
                }

                // Configure SaveFileDialog (already placed on form)
                saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
                saveFileDialog1.Title = "Save Random Numbers File";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int number = rand.Next(1, 101); // Random between 1–100
                            writer.WriteLine(number);
                        }
                    }

                    messageLabel.Text = $"Successfully wrote {count} random numbers to: {Path.GetFileName(saveFileDialog1.FileName)}";
                    messageLabel.ForeColor = AppTheme.SuccessColor;
                }
                else
                {
                    messageLabel.Text = "File save cancelled.";
                    messageLabel.ForeColor = AppTheme.InfoColor;
                }
            }
            catch (Exception ex)
            {
                messageLabel.Text = $"Error: {ex.Message}";
                messageLabel.ForeColor = AppTheme.DangerButtonColor;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            countTextBox.Clear();
            messageLabel.Text = string.Empty;

            countTextBox.Select();
        }
    }
}
