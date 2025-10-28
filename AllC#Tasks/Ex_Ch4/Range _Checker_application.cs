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
    public partial class Range__Checker_application : Form
    {
        public Range__Checker_application()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the user's input and convert it to an integer
                int number = int.Parse(inputTextBox.Text);

                // Check whether the number is between 1 and 10 (inclusive)
                if (number >= 1 && number <= 10)
                {
                    MessageBox.Show("That number is acceptable.");
                }
                else
                {
                    MessageBox.Show("That number is NOT acceptable.");
                }
            }
            catch (Exception ex)
            {
                // Display an error message if input is invalid
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
