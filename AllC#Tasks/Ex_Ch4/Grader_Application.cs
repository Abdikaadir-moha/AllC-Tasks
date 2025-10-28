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
    public partial class Grader_Application : Form
    {
        public Grader_Application()
        {
            InitializeComponent();
        }

        private void DetermineGradeButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Read the test score from the textbox
                double testScore = double.Parse(testScoreTextBox.Text);
                string grade;

                // Determine the grade based on the score
                if (testScore < 60)
                {
                    grade = "F";
                }
                else if (testScore < 70)
                {
                    grade = "D";
                }
                else if (testScore < 80)
                {
                    grade = "C";
                }
                else if (testScore < 90)
                {
                    grade = "B";
                }
                else
                {
                    grade = "A";
                }

                // Display the grade
                gradeLabel.Text = grade;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric test score.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("An unexpected error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Grader_Application_Load(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            testScoreTextBox.Clear();
            gradeLabel.Text = string.Empty;

            testScoreTextBox.Focus();
        }
    }
}
