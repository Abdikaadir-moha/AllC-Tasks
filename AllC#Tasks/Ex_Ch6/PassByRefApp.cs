using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllC_Tasks.Ex_Ch6
{
    public partial class PassByRefApp : Form
    {
        public PassByRefApp()
        {
            InitializeComponent();
        }

        private void PassByRefApp_Load(object sender, EventArgs e)
        {
            BackColor = AppTheme.BackgroundColor;

            headerPanel.FillColor = AppTheme.HeaderColor;
            titleLabel.ForeColor = AppTheme.HeaderTextColor;

            outputListBox.BackColor = AppTheme.TextBoxBackColor;
            outputListBox.ForeColor = AppTheme.TextColor;
            outputListBox.BorderStyle = BorderStyle.FixedSingle;

            GoButton.FillColor = AppTheme.PrimaryButtonColor;
            GoButton.ForeColor = AppTheme.HeaderTextColor;

            messageLabel.ForeColor = AppTheme.InfoColor;
            messageLabel.BackColor = AppTheme.BackgroundColor;
        }
        private void SetToZero(ref int number)
        {
            number = 0;
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare some local int variables.
                int x = 99, y = 100, z = 101;

                // Display initial values.
                outputListBox.Items.Clear();
                outputListBox.Items.Add("Initial Values:");
                outputListBox.Items.Add($"x is set to {x}");
                outputListBox.Items.Add($"y is set to {y}");
                outputListBox.Items.Add($"z is set to {z}");

                // Modify values using ref
                SetToZero(ref x);
                SetToZero(ref y);
                SetToZero(ref z);

                // Display results
                outputListBox.Items.Add("--------------------");
                outputListBox.Items.Add("After calling SetToZero:");
                outputListBox.Items.Add($"x is set to {x}");
                outputListBox.Items.Add($"y is set to {y}");
                outputListBox.Items.Add($"z is set to {z}");

                messageLabel.ForeColor = AppTheme.SuccessColor;
                messageLabel.Text = "Values updated successfully!";
            }
            catch (Exception ex)
            {
                messageLabel.ForeColor = AppTheme.DangerButtonColor;
                messageLabel.Text = "Error: " + ex.Message;
            }
        }
    }
}
