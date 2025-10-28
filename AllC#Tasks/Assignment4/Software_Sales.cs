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
    public partial class Software_Sales : Form
    {
        const double PACKAGE_PRICE = 99.0;
        public Software_Sales()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                int quantity = int.Parse(txtQuantity.Text);

                if (quantity <= 0)
                {
                    MessageBox.Show("Please enter a quantity greater than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Determine discount rate
                double discountRate = 0;

                if (quantity >= 100)
                    discountRate = 0.50;
                else if (quantity >= 50)
                    discountRate = 0.40;
                else if (quantity >= 20)
                    discountRate = 0.30;
                else if (quantity >= 10)
                    discountRate = 0.20;

                // Calculate totals
                double subtotal = quantity * PACKAGE_PRICE;
                double discountAmount = subtotal * discountRate;
                double total = subtotal - discountAmount;

                // Display results
                LblDiscount.Text = $"Discount: {(discountRate * 100):F0}%";
                LblTotal.Text = $"Total Price: ${total:F2}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid whole number for quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
