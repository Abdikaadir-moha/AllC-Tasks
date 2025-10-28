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
    public partial class Payroll_with_Overtime : Form
    {
        public Payroll_with_Overtime()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // Named constants  
            const decimal BASE_HOURS = 40m;
            const decimal OT_MULTIPLIER = 1.5m;

            try
            {
                // Local variables  
                decimal hoursWorked;     // Number of hours worked  
                decimal hourlyPayRate;   // Hourly pay rate  
                decimal basePay;         // Pay not including overtime  
                decimal overtimeHours;   // overtime hours worked  
                decimal overtimePay;     // overtime pay  
                decimal grossPay;        // total gross pay

                // Get the hours worked and hourly pay rate.  
                hoursWorked = decimal.Parse(hoursWorkedTextBox.Text);
                hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text);


                if (hoursWorked <= 40)
                {

                    basePay = hourlyPayRate * BASE_HOURS;

                    overtimeHours = hoursWorked - BASE_HOURS;

                    overtimePay = overtimeHours * hourlyPayRate * OT_MULTIPLIER;

                    grossPay = basePay + overtimePay;
                }
                else
                {
                    grossPay = hoursWorked * hourlyPayRate;
                }
                // Display result
                grossPayLabel.Text = grossPay.ToString("c");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for hours worked and hourly rate.", "Input Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

            hoursWorkedTextBox.Clear();
            hourlyPayRateTextBox.Clear();
            grossPayLabel.Text = string.Empty;

            hoursWorkedTextBox.Focus();
        }
    }
}
