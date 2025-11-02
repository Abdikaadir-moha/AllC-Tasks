using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AllC_Tasks;

namespace Wholeproject
{
    public partial class EndingBalanceListBox : Form
    {
        public EndingBalanceListBox()
        {
            InitializeComponent();
        }


        private void ClearBtn_Click(object sender, EventArgs e)
        {
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";
            DetailListBox.Items.Clear();
            startingBalTextBox.Focus();
        }

        private void CalcEndingButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Constant for the monthly interest rate. 
                const decimal INTEREST_RATE = 0.005m;

                // Local variables 
                decimal balance;     // The account balance 
                int months;          // The number of months 
                int count = 1;       // Loop counter, initialized with 1 

                // Clear the detail list before adding new results (optional but recommended)
                DetailListBox.Items.Clear();

                // Get the starting balance. 
                if (decimal.TryParse(startingBalTextBox.Text, out balance))
                {
                    // Get the number of months. 
                    if (int.TryParse(monthsTextBox.Text, out months))
                    {
                        // The following loop calculates the ending balance. 
                        while (count <= months)
                        {
                            // Add this month's interest to the balance. 
                            balance = balance + (INTEREST_RATE * balance);

                            // Display this month's ending balance.  
                            DetailListBox.Items.Add("The ending balance for month " +
                                count + " is " + balance.ToString("c"));

                            // Add one to the loop counter. 
                            count = count + 1;
                        }

                        // Display the final ending balance. 
                        endingBalanceLabel.Text = balance.ToString("c");
                    }
                    else
                    {
                        // Invalid number of months was entered. 
                        messageLabel.Text = "Invalid value for months.";
                    }
                }
                else
                {
                    // Invalid starting balance was entered. 
                    messageLabel.Text = "Invalid value for starting balance.";
                }
            }
            catch (Exception ex)
            {
                // Handle unexpected errors gracefully. 
                messageLabel.Text = "An unexpected error occurred: " + ex.Message;
            }
        }

        private void EndingBalanceListBox_Load(object sender, EventArgs e)
        {
            BackColor = AppTheme.BackgroundColor;
            headerPanel.FillColor = AppTheme.HeaderColor;
            titleLabel.ForeColor = AppTheme.HeaderTextColor;

            CalcEndingButton.FillColor = AppTheme.PrimaryButtonColor;
            CalcEndingButton.ForeColor = Color.White;

            ClearBtn.FillColor = AppTheme.SecondaryButtonColor;
            ClearBtn.ForeColor = Color.White;

            messageLabel.ForeColor = AppTheme.TextColor;
        }
    }
}
