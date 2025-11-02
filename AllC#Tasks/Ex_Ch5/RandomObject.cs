using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AllC_Tasks;

namespace Wholeproject
{
    public partial class RandomObject : Form
    {
        public RandomObject()
        {
            InitializeComponent();
        }

        private void RandomObject_Load(object sender, EventArgs e)
        {
            BackColor = AppTheme.BackgroundColor;
            headerPanel.FillColor = AppTheme.HeaderColor;
            titleLabel.ForeColor = AppTheme.HeaderTextColor;

            GenerateButton.FillColor = AppTheme.PrimaryButtonColor;
            GenerateButton.ForeColor = Color.White;

            ClearButton.FillColor = AppTheme.SecondaryButtonColor;
            ClearButton.ForeColor = Color.White;
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            int number;
            // Create a Random object. 
            Random rand = new Random();
            // Get a random integer and assign it to number. 
            number = rand.Next();
            lblRandomNumber.Text = "Random number: " + number.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            lblRandomNumber.Text = "";
        }
    }
}
