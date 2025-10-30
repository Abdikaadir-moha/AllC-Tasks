using System;
using System.Windows.Forms;
using Guna.UI2.WinForms;


namespace AllC_Tasks.Assignment5
{
    public partial class DistanceCalculator : Form
    {

        public DistanceCalculator()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Read input values
                double speed = double.Parse(speedTextBox.Text);
                int hours = int.Parse(hoursTextBox.Text);

                // Validate input
                if (speed <= 0 || hours <= 0)
                {
                    MessageBox.Show("Please enter positive numbers for speed and hours.",
                                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Add header row
                resultListBox.Items.Add("Hour\tDistance Traveled (miles)");
                resultListBox.Items.Add("--------------------------------");

                // Calculate distance each hour
                for (int hour = 1; hour <= hours; hour++)
                {
                    double distance = speed * hour;
                    resultListBox.Items.Add($"After hour {hour} the distance is {distance:N1}");
                }

                speedTextBox.Clear();
                hoursTextBox.Clear();

                speedTextBox.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for speed and hours.",
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DistanceCalculator_Load(object sender, EventArgs e)
        {
            BackColor = ColorTranslator.FromHtml("#F4F9F9");

            resultListBox.BackColor = Color.White;
            resultListBox.ForeColor = ColorTranslator.FromHtml("#343A40");

            CalculateButton.HoverState.FillColor = ColorTranslator.FromHtml("#138496");

            // Clear previous results
            resultListBox.Items.Clear();
        }

        
    }
}
