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
    public partial class MagicDates : Form
    {
        public MagicDates()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            try
            {
                int month = int.Parse(MonthTextBox.Text);
                int day = int.Parse(DayTextBox.Text);
                int year = int.Parse(YearTextBox.Text);

                // Validate ranges
                if (month < 1 || month > 12)
                {
                    MessageBox.Show("Month must be between 1 and 12.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (day < 1 || day > 31)
                {
                    MessageBox.Show("Day must be between 1 and 31.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (year < 0 || year > 99)
                {
                    MessageBox.Show("Year must be a two-digit number (0–99).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check magic condition
                if (month * day == year)
                    LblResult.Text = "This date is magic!";
                else
                    LblResult.Text = "This date is not magic.";
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input! Please enter numeric values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            MonthTextBox.Clear();
            DayTextBox.Clear();
            YearTextBox.Clear();
            LblResult.Text = string.Empty;

            MonthTextBox.Focus();
        }
    }
}
