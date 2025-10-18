using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllC_Tasks
{
    public partial class Stadium_Seating : Form
    {
        public Stadium_Seating()
        {
            InitializeComponent();
        }

        private void Stadium_Seating_Load(object sender, EventArgs e)
        {
            classATextBox.Focus();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Ticket prices
                const double CLASS_A_PRICE = 15.0;
                const double CLASS_B_PRICE = 12.0;
                const double CLASS_C_PRICE = 9.0;

                // Read number of tickets sold
                int classA_Tickets = int.Parse(classATextBox.Text);
                int classB_Tickets = int.Parse(classBTextBox.Text);
                int classC_Tickets = int.Parse(classCTextBox.Text);

                // Calculate revenue for each class
                double classA_Revenue = classA_Tickets * CLASS_A_PRICE;
                double classB_Revenue = classB_Tickets * CLASS_B_PRICE;
                double classC_Revenue = classC_Tickets * CLASS_C_PRICE;

                // Calculate total
                double totalRevenue = classA_Revenue + classB_Revenue + classC_Revenue;

                // Display results
                revAResultLabel.Text = classA_Revenue.ToString("C");
                revBResultLabel.Text = classB_Revenue.ToString("C");
                revCResultLabel.Text = classC_Revenue.ToString("C");
                totalResultLabel.Text = totalRevenue.ToString("C");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid whole numbers for tickets sold.",
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clear inputs
            classATextBox.Clear();
            classBTextBox.Clear();
            classCTextBox.Clear();

            // Clear results
            revAResultLabel.Text = "—";
            revBResultLabel.Text = "—";
            revCResultLabel.Text = "—";
            totalResultLabel.Text = "—";

            classATextBox.Focus();
        }
    }
}
