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
    public partial class CoinandToss : Form
    {
        public CoinandToss()
        {
            InitializeComponent();
        }


        private void TossButton_Click(object sender, EventArgs e)
        {
            // Variable to indicate which side is up  
            int sideUp;

            // Create a Random object.  
            Random rand = new Random();

            // Get a random integer in the range of 0 through 1.  
            // 0 means tails up, 1 means heads up.  
            sideUp = rand.Next(2);

            // Display the side that is up.  
            if (sideUp == 0)
            {
                // Display tails up.  
                tailsPictureBox.Visible = true;
                headsPictureBox.Visible = false;
            }
            else
            {
                // Display heads up.  
                headsPictureBox.Visible = true;
                tailsPictureBox.Visible = false;
            }
        }

        private void CoinandToss_Load(object sender, EventArgs e)
        {
            BackColor = AppTheme.BackgroundColor;
            headerPanel.FillColor = AppTheme.HeaderColor;
            titleLabel.ForeColor = AppTheme.HeaderTextColor;

            TossButton.FillColor = AppTheme.PrimaryButtonColor;
            TossButton.ForeColor = Color.White;

            ClearButton.FillColor = AppTheme.SecondaryButtonColor;
            ClearButton.ForeColor = Color.White;
        }
    }
}
