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
    public partial class Book_Club_Points : Form
    {
        public Book_Club_Points()
        {
            InitializeComponent();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int books = int.Parse(txtBooks.Text);

                if (books < 0)
                {
                    MessageBox.Show("Number of books cannot be negative.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int points = books switch
                {
                    0 => 0,
                    1 => 5,
                    2 => 15,
                    3 => 30,
                    _ => 60
                };

                LblResult.Text = $"You earned {points} points!";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
