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
    public partial class Add__Two_Numbers_form : Form
    {
        public Add__Two_Numbers_form()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Local variables
                int first,second,sum;

                // Try to parse the first input
                if (int.TryParse(firstTextBox.Text, out first))
                {
                    // Try to parse the second input
                    if (int.TryParse(secondTextBox.Text, out second))
                    {
                        // Add the two numbers and display the sum
                        sum = first + second;
                        MessageBox.Show("The sum is: " + sum.ToString());
                    }
                    else
                    {
                        // Error message for invalid second TextBox input
                        MessageBox.Show("The second TextBox contains invalid data.");
                    }
                }
                else
                {
                    // Error message for invalid first TextBox input
                    MessageBox.Show("The first TextBox contains invalid data.");
                }
            }
            catch (Exception ex)
            {
                // Display an error message for any unexpected exceptions
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
