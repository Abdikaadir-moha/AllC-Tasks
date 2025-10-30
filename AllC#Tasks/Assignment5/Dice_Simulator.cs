using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace AllC_Tasks.Assignment5
{
    public partial class Dice_Simulator : Form
    {
        public Dice_Simulator()
        {
            InitializeComponent();
        }

        private void Dice_Simulator_Load(object sender, EventArgs e)
        {
            BackColor = AppTheme.BackgroundColor;

            headerPanel.FillColor = AppTheme.HeaderColor;
            titleLabel.ForeColor = AppTheme.HeaderTextColor;

            RollButton.FillColor = AppTheme.PrimaryButtonColor;
            RollButton.ForeColor = Color.White;

            ClearBtn.FillColor = AppTheme.SecondaryButtonColor;
            ClearBtn.ForeColor = AppTheme.TextBoxBackColor;

            // 🖼️ Initial dice display
            die1PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            die2PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            Random rand = new();
            try
            {
                int die1 = rand.Next(1, 7); // 1–6
                int die2 = rand.Next(1, 7); // 1–6

                // Display dice images
                die1PictureBox.Image = GetDieImage(die1);
                die2PictureBox.Image = GetDieImage(die2);

                // Optional: Show rolled values
                resultLabel.Text = $"You rolled: {die1} and {die2}  (Total: {die1 + die2})";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dice images.\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            die1PictureBox.Image = null;
            die2PictureBox.Image = null;

            resultLabel.Text = "";
        }

        private Image? GetDieImage(int number)
        {
            switch (number)
            {
                case 1: return Properties.Resources.Die1;
                case 2: return Properties.Resources.Die2;
                case 3: return Properties.Resources.Die3;
                case 4: return Properties.Resources.Die4;
                case 5: return Properties.Resources.Die5;
                case 6: return Properties.Resources.Die6;
                default: return null;
            }
        }
    }
}
