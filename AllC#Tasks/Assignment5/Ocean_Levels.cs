using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllC_Tasks.Assignment5
{
    public partial class Ocean_Levels : Form
    {
        public Ocean_Levels()
        {
            InitializeComponent();
        }

        private void Ocean_Levels_Load(object sender, EventArgs e)
        {
            BackColor = AppTheme.BackgroundColor;
            headerPanel.FillColor = AppTheme.HeaderColor;
            titleLabel.ForeColor = AppTheme.HeaderTextColor;

            descriptionLabel.ForeColor = AppTheme.TextColor;
            descriptionLabel.BackColor = AppTheme.TextBoxBackColor;

            // 🔘 Buttons
            CalculateButton.FillColor = AppTheme.PrimaryButtonColor;
            CalculateButton.ForeColor = Color.White;

            ClearBtn.FillColor = AppTheme.SecondaryButtonColor;
            ClearBtn.ForeColor = AppTheme.TextBoxBackColor;

            // 📋 ListBox
            oceanListBox.BackColor = AppTheme.TextBoxBackColor;
            oceanListBox.ForeColor = AppTheme.TextColor;

            oceanListBox.Items.Clear();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {

                double risePerYear = 1.5; // mm per year
                double totalRise = 0;

                oceanListBox.Items.Add("Year\tTotal Rise (mm)");
                oceanListBox.Items.Add("------------------------");

                for (int year = 1; year <= 10; year++)
                {
                    totalRise += risePerYear;
                    oceanListBox.Items.Add($"{year}\t{totalRise:F1}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while calculating ocean levels.\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            oceanListBox.Items.Clear();
        }
    }
}
