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
    public partial class MutipleAlternative_Switch_ : Form
    {
        public MutipleAlternative_Switch_()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            try
            {
                int month = int.Parse(monthTextBox.Text);

                switch (month)
                {
                    case 1:
                        MessageBox.Show("January");
                        break;

                    case 2:
                        MessageBox.Show("February");
                        break;

                    case 3:
                        MessageBox.Show("March");
                        break;
                    case 4:
                        MessageBox.Show("April");
                        break;
                    case 5:
                        MessageBox.Show("May");
                        break;
                    case 6:
                        MessageBox.Show("June");
                        break;
                    case 7:
                        MessageBox.Show("July");
                        break;
                    case 8:
                        MessageBox.Show("August");
                        break;
                    case 9:
                        MessageBox.Show("September");
                        break;
                    case 10:
                        MessageBox.Show("October");
                        break;
                    case 11:
                        MessageBox.Show("November");
                        break;
                    case 12:
                        MessageBox.Show("December");
                        break;
                    default:
                        MessageBox.Show("Error: Invalid month");
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid month number. Please enter a value between 1 and 12.", "Invalid Input",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                monthTextBox.Focus();
            }
        }
    }
}
