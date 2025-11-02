using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllC_Tasks.Assignment6
{
    public partial class PrimeNumberList : Form
    {
        public PrimeNumberList()
        {
            InitializeComponent();
        }

        private void PrimeNumberList_Load(object sender, EventArgs e)
        {
            BackColor = AppTheme.BackgroundColor;

            // Header
            headerPanel.FillColor = AppTheme.HeaderColor;
            titleLabel.ForeColor = AppTheme.HeaderTextColor;
            titleLabel.Font = AppTheme.HeaderFont;

            // Labels
            messageLabel.ForeColor = AppTheme.InfoColor;
            messageLabel.Font = AppTheme.BodyFont;

            // ListBox
            primeListBox.ForeColor = AppTheme.TextColor;
            primeListBox.Font = AppTheme.BodyFont;

            // Buttons
            ShowButton.FillColor = AppTheme.PrimaryButtonColor;
            ShowButton.Font = AppTheme.ButtonFont;
            ShowButton.ForeColor = AppTheme.HeaderTextColor;

            ClearButton.FillColor = AppTheme.SecondaryButtonColor;
            ClearButton.Font = AppTheme.ButtonFont;
            ClearButton.ForeColor = AppTheme.HeaderTextColor;

            // Message Label
            messageLabel.Text = "";
        }

        private bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                primeListBox.Items.Clear();

                for (int i = 1; i <= 100; i++)
                {
                    if (IsPrime(i))
                        primeListBox.Items.Add(i);
                }

                messageLabel.ForeColor = AppTheme.SuccessColor;
                messageLabel.Text = "Prime numbers from 1 to 100 displayed successfully.";
            }
            catch (Exception ex)
            {
                messageLabel.ForeColor = AppTheme.DangerButtonColor;
                messageLabel.Text = $"Error: {ex.Message}";
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            primeListBox.Items.Clear();
            messageLabel.Text = "";
        }
    }
}
