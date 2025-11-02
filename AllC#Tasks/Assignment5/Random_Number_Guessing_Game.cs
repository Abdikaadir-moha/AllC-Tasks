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
    public partial class Random_Number_Guessing_Game : Form
    {
        private int secretNumber;
        private int guessCount;
        private Random random = new ();
        public Random_Number_Guessing_Game()
        {
            InitializeComponent();
        }

        private void Random_Number_Guessing_Game_Load(object sender, EventArgs e)
        {
            BackColor = AppTheme.BackgroundColor;

            headerPanel.FillColor = AppTheme.HeaderColor;
            titleLabel.ForeColor = AppTheme.HeaderTextColor;

            descriptionLabel.ForeColor = AppTheme.TextColor;
            descriptionLabel.BackColor = AppTheme.TextBoxBackColor;

            guessTextBox.FillColor = AppTheme.TextBoxBackColor;
            guessTextBox.ForeColor = AppTheme.TextColor;

            CheckButton.FillColor = AppTheme.PrimaryButtonColor;
            CheckButton.ForeColor = Color.White;

            ClearBtn.FillColor = AppTheme.SecondaryButtonColor;
            ClearBtn.ForeColor = AppTheme.TextBoxBackColor;

            messageLabel.ForeColor = AppTheme.InfoColor;
            messageLabel.BackColor = AppTheme.TextBoxBackColor;

            // Initialize game
            GenerateNewNumber();
        }
        private void GenerateNewNumber()
        {

            secretNumber = random.Next(1, 101);
            guessCount = 0;
            guessTextBox.Select();
            guessTextBox.Clear();

        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            try
            {
                int userGuess = int.Parse(guessTextBox.Text);
                guessCount++;

                if (userGuess < secretNumber)
                {
                    messageLabel.ForeColor = AppTheme.WarningColor;
                    messageLabel.Text = $"{userGuess} Too low, try again!";
                    guessTextBox.Clear();
                    guessTextBox.Select();
                }
                else if (userGuess > secretNumber)
                {
                    messageLabel.ForeColor = AppTheme.WarningColor;
                    messageLabel.Text = $"{userGuess} Too high, try again!";
                    guessTextBox.Clear();
                    guessTextBox.Select();
                }
                else
                {
                    messageLabel.Text = $"Correct! You guessed it in {guessCount} tries.";
                    messageLabel.ForeColor = AppTheme.SuccessColor;

                    // Generate new number automatically
                    GenerateNewNumber();
                }
            }
            catch
            {
                messageLabel.ForeColor = AppTheme.DangerButtonColor;
                messageLabel.Text = "Please enter a valid number.";
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            guessTextBox.Clear();
            messageLabel.Text = "";

            guessTextBox.Select();
        }
    }
}
