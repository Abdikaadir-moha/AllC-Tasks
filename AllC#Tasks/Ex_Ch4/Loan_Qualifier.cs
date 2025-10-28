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
    public partial class Loan_Qualifier : Form
    {
        public Loan_Qualifier()
        {
            InitializeComponent();
        }

        private void Loan_Qualifier_Load(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                const decimal MINIMUM_SALARY = 40000m;
                const int MINIMUM_YEARS_ON_JOB = 2;

                decimal salary;
                int yearsOnJob;

                salary = decimal.Parse(salaryTextBox.Text);
                yearsOnJob = int.Parse(yearsTextBox.Text);

                if (salary >= MINIMUM_SALARY)
                {
                    if (yearsOnJob >= MINIMUM_YEARS_ON_JOB)
                    {
                        // Both conditions are met. The user qualifies.
                        decisionLabel.Text = "You qualify for the loan.";
                    }
                    else
                    {
                        decisionLabel.Text = "Minimum years at current job not met.";
                    }
                }
                else
                {
                    decisionLabel.Text = "Minimum salary requirement not met.";
                }
            }
            catch (FormatException)
            {
                // Catch specific error if user enters non-numeric data or leaves fields empty.
                MessageBox.Show("Please enter valid numerical values for salary and years.", "Input Error");
                salaryTextBox.Focus();
            }
            catch (Exception ex)
            {
                // Catch any other unexpected error.
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

            salaryTextBox.Clear();
            yearsTextBox.Clear();
            decisionLabel.Text = string.Empty;
            salaryTextBox.Focus();
        }
    }
}
