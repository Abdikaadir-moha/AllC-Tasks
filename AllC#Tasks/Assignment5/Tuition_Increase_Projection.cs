using System;
using System.Windows.Forms;

namespace AllC_Tasks.Assignment4
{
    public partial class Tuition_Increase_Projection : Form
    {
        public Tuition_Increase_Projection()
        {
            InitializeComponent();
        }

        private void Tuition_Increase_Projection_Load(object sender, EventArgs e)
        {
            BackColor = AppTheme.BackgroundColor;

            headerPanel.FillColor = AppTheme.HeaderColor;
            titleLabel.ForeColor = AppTheme.HeaderTextColor;

            descriptionLabel.ForeColor = AppTheme.TextColor;
            descriptionLabel.BackColor = AppTheme.TextBoxBackColor;

            tuitionListBox.BackColor = AppTheme.TextBoxBackColor;
            tuitionListBox.ForeColor = AppTheme.TextColor;

            CalculateButton.FillColor = AppTheme.PrimaryButtonColor;
            CalculateButton.ForeColor = Color.White;

            ClearBtn.FillColor = AppTheme.SecondaryButtonColor;
            ClearBtn.ForeColor = AppTheme.TextBoxBackColor;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                tuitionListBox.Items.Clear();

                double tuition = 6000.0;
                double increaseRate = 0.02; // 2% per year

                tuitionListBox.Items.Add("Year\tProjected Tuition ($)");
                tuitionListBox.Items.Add("--------------------------------");

                for (int year = 1; year <= 5; year++)
                {
                    tuition *= (1 + increaseRate);
                    tuitionListBox.Items.Add($"{year}\t{tuition:F2}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while calculating tuition.\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            tuitionListBox.Items.Clear(); 
        }
    }
}
