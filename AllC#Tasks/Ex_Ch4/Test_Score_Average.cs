using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllC_Tasks.Ex_Ch4
{
    public partial class Test_Score_Average : Form
    {
        public Test_Score_Average()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                const double HIGH_SCORE = 95.0;
                double test1, test2, test3, average;

                // Get scores
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                // Calculate average
                average = (test1 + test2 + test3) / 3.0;

                // Display the result (1 decimal)
                averageLabel.Text = average.ToString("n1");

                // Congratulate if average is high
                if (average > HIGH_SCORE)
                {
                    MessageBox.Show("Congratulations! Great job!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid test score(s). Please enter numeric values (e.g. 0–100) for all three tests.", "Invalid Input",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Test_Score_Average_Load(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            test1TextBox.Clear();
            test2TextBox.Clear();
            test3TextBox.Clear();
            averageLabel.Text = string.Empty;
            test1TextBox.Focus();
        }
    }
}
