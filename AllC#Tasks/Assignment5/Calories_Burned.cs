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
    public partial class Calories_Burned : Form
    {
        public Calories_Burned()
        {
            InitializeComponent();
        }

        private void Calories_Burned_Load(object sender, EventArgs e)
        {
            BackColor = AppTheme.BackgroundColor;

            headerPanel.FillColor = AppTheme.HeaderColor;
            titleLabel.ForeColor = AppTheme.HeaderTextColor;

            descriptionLabel.ForeColor = AppTheme.TextColor;
            descriptionLabel.BackColor = AppTheme.TextBoxBackColor;

            CalculateButton.FillColor = AppTheme.PrimaryButtonColor;
            CalculateButton.ForeColor = Color.White;

            ClearBtn.FillColor = AppTheme.SecondaryButtonColor;
            ClearBtn.ForeColor = AppTheme.TextBoxBackColor;

            caloriesListBox.BackColor = AppTheme.TextBoxBackColor;
            caloriesListBox.ForeColor = AppTheme.TextColor;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                caloriesListBox.Items.Clear();

                double caloriesPerMinute = 3.9;
                int[] minutes = { 10, 15, 20, 25, 30 };

                caloriesListBox.Items.Add("Minutes\tCalories Burned");
                caloriesListBox.Items.Add("----------------------------");

                foreach (int m in minutes)
                {
                    double burned = caloriesPerMinute * m;
                    caloriesListBox.Items.Add($"{m}\t{burned:F1}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while calculating calories.\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            caloriesListBox.Items.Clear();  
        }
    }
}
