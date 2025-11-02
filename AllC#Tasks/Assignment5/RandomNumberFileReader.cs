using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AllC_Tasks.Assignment5
{
    public partial class RandomNumberFileReader : Form
    {
        public RandomNumberFileReader()
        {
            InitializeComponent();
        }

        private void RandomNumberFileReader_Load(object sender, EventArgs e)
        {
            BackColor = AppTheme.BackgroundColor;

            headerPanel.FillColor = AppTheme.HeaderColor;
            titleLabel.ForeColor = AppTheme.HeaderTextColor;

            descriptionLabel.ForeColor = AppTheme.TextColor;
            descriptionLabel.BackColor = AppTheme.TextBoxBackColor;

            OpenFileButton.FillColor = AppTheme.PrimaryButtonColor;
            OpenFileButton.ForeColor = Color.White;

            numbersListBox.BackColor = AppTheme.TextBoxBackColor;
            numbersListBox.ForeColor = AppTheme.TextColor;

            totalLabel.ForeColor = AppTheme.TextColor;
            countLabel.ForeColor = AppTheme.TextColor;

            messageLabel.ForeColor = AppTheme.TextColor;
            messageLabel.BackColor = AppTheme.TextBoxBackColor;
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select a Random Number File";
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                messageLabel.Text = "File selection cancelled.";
                messageLabel.ForeColor = AppTheme.InfoColor;
                return;
            }

            try
            {
                numbersListBox.Items.Clear();
                int total = 0;
                int count = 0;

                using (StreamReader reader = new(openFileDialog1.FileName))
                {
                    string? line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (int.TryParse(line, out int number))
                        {
                            numbersListBox.Items.Add(number);
                            total += number;
                            count++;
                        }
                    }
                }

                totalLabel.Text = $"Total: {total}";
                countLabel.Text = $"Count: {count}";
                messageLabel.Text = "File loaded successfully!";
                messageLabel.ForeColor = AppTheme.SuccessColor;
            }
            catch (Exception ex)
            {
                messageLabel.Text = $"Error reading file: {ex.Message}";
                messageLabel.ForeColor = AppTheme.DangerButtonColor;
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            numbersListBox.Items.Clear();
            totalLabel.Text = "";
            countLabel.Text = "";
            messageLabel.Text = "";
        }
    }
}
