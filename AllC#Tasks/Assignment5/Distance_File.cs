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
    public partial class Distance_File : Form
    {
        public Distance_File()
        {
            InitializeComponent();
        }

        private void Distance_File_Load(object sender, EventArgs e)
        {
            // Apply AppTheme colors (only colors, no fonts or layout)
            BackColor = AppTheme.BackgroundColor;
            headerPanel.FillColor = AppTheme.HeaderColor;
            titleLabel.ForeColor = AppTheme.HeaderTextColor;

            speedTextBox.FillColor = AppTheme.TextBoxBackColor;
            speedTextBox.ForeColor = AppTheme.TextColor;
            hoursTextBox.FillColor = AppTheme.TextBoxBackColor;
            hoursTextBox.ForeColor = AppTheme.TextColor;

            CalculateButton.FillColor = AppTheme.PrimaryButtonColor;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double speed = double.Parse(speedTextBox.Text);
                int hours = int.Parse(hoursTextBox.Text);

                if (speed <= 0 || hours <= 0)
                {
                    MessageBox.Show("Speed and hours must be greater than zero.", "Input Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 📝 Create and write output file
                using (StreamWriter outputFile = File.CreateText("DistanceReport.txt"))
                {
                    outputFile.WriteLine("Hour\tDistance Traveled (miles)");
                    outputFile.WriteLine("-----------------------------------");

                    for (int hour = 1; hour <= hours; hour++)
                    {
                        double distance = speed * hour;
                        outputFile.WriteLine($"{hour}\t{distance:F2}");
                    }
                }

                MessageBox.Show("Report saved successfully as DistanceReport.txt", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 🧾 Optional: Ask if user wants to open the file
                DialogResult result = MessageBox.Show("Do you want to view the report file?", "Open File",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (StreamReader inputFile = File.OpenText("DistanceReport.txt"))
                    {
                        string? line;
                        string allText = "";

                        while ((line = inputFile.ReadLine()) != null)
                        {
                            allText += line + Environment.NewLine;
                        }

                        // Show preview in a message box or console
                        MessageBox.Show(allText, "Distance Report Preview");
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for speed and hours.", "Format Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
