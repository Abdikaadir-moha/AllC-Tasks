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
    public partial class TimeCalculator : Form
    {
        public TimeCalculator()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double seconds = double.Parse(secondsTextBox.Text);

                if (seconds < 0)
                {
                    MessageBox.Show("Please enter a positive number of seconds.",
                                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string message = "";

                if (seconds >= 86400)
                {
                    double days = seconds / 86400;
                    message = $"That’s equal to {days:F2} day(s).";
                    resultLabel.ForeColor =Color.DarkCyan;
                }
                else if (seconds >= 3600)
                {
                    double hours = seconds / 3600;
                    message = $"That’s equal to {hours:F2} hour(s).";
                    resultLabel.ForeColor =Color.Purple;
                }
                else if (seconds >= 60)
                {
                    double minutes = seconds / 60;
                    message = $"That’s equal to {minutes:F2} minute(s).";
                    resultLabel.ForeColor = Color.Green;
                }
                else
                {
                    message = "That’s less than one minute.";
                    resultLabel.ForeColor = Color.Gray;
                }

                resultLabel.Text = message;

                secondsTextBox.Clear();
            }
            catch
            {
                MessageBox.Show("Please enter a valid numeric value for seconds.",
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
