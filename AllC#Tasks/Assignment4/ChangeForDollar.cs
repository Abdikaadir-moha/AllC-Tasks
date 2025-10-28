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
    public partial class ChangeForDollar : Form
    {
        public ChangeForDollar()
        {
            InitializeComponent();
        }

        private void ChangeForDollar_Load(object sender, EventArgs e)
        {

        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Get user input
                int pennies = int.Parse(penniesTextBox.Text);
                int nickels = int.Parse(nickelsTextBox.Text);
                int dimes = int.Parse(dimesTextBox.Text);
                int quarters = int.Parse(quartersTextBox.Text);

                // Calculate total in cents
                int totalCents = (pennies * 1) + (nickels * 5) + (dimes * 10) + (quarters * 25);

                // Determine the result
                if (totalCents == 100)
                {
                    messageLabel.Text = "🎉 Congratulations! You made exactly one dollar!";
                    messageLabel.ForeColor = System.Drawing.Color.Green;
                }
                else if (totalCents > 100)
                {
                    messageLabel.Text = "💰 Too much! You went over one dollar.";
                    messageLabel.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    messageLabel.Text = "🪙 Not enough! You are under one dollar.";
                    messageLabel.ForeColor = System.Drawing.Color.Blue;
                }
            }
            catch
            {
                MessageBox.Show("Please enter valid whole numbers for all coins.",
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
