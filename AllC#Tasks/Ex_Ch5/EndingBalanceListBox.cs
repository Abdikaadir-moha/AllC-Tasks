using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wholeproject
{
    public partial class EndingBalanceListBox : Form
    {
        public EndingBalanceListBox()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
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
                detailListBox.Items.Clear();

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
                            detailListBox.Items.Add("The ending balance for month " +
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
                        MessageBox.Show("Invalid value for months.");
                    }
                }
                else
                {
                    // Invalid starting balance was entered. 
                    MessageBox.Show("Invalid value for starting balance.");
                }
            }
            catch (Exception ex)
            {
                // Handle unexpected errors gracefully. 
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }

        }

        private void Clearsbutton_Click(object sender, EventArgs e)
        {
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";
            detailListBox.Items.Clear();
            startingBalTextBox.Focus();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
