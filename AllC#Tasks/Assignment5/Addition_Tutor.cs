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
    public partial class Addition_Tutor : Form
    {
        // Change: Make 'rng' field readonly as it is only assigned in the constructor.
        private readonly Random rng;
        private int currentA;
        private int currentB;
        public Addition_Tutor()
        {
            InitializeComponent();
            // initialize RNG and first problem
            rng = new Random();
        }

        private void Addition_Tutor_Load(object sender, EventArgs e)
        {
            BackColor = AppTheme.BackgroundColor;
            headerPanel.FillColor = AppTheme.HeaderColor;
            titleLabel.ForeColor = AppTheme.HeaderTextColor;

            // 🧾 Labels (problem labels)
            firstNumberLabel.ForeColor = AppTheme.TextColor;
            plusSignLabel.ForeColor = AppTheme.TextColor;
            secondNumberLabel.ForeColor = AppTheme.TextColor;
            equalsLabel.ForeColor = AppTheme.TextColor;

            // 📝 TextBox
            answerTextBox.FillColor = AppTheme.TextBoxBackColor;
            answerTextBox.ForeColor = AppTheme.TextColor;
            answerTextBox.BorderColor = AppTheme.HeaderColor;

            // 🔘 Buttons
            CheckButton.FillColor = AppTheme.PrimaryButtonColor;
            CheckButton.ForeColor = Color.White;

            // 💬 Message label (optional)
            messageLabel.ForeColor = AppTheme.TextColor;
            messageLabel.BackColor = AppTheme.TextBoxBackColor;






            GenerateNewProblem();

            answerTextBox.Select();

        }

        // Generate two random integers [100..500] and show them
        private void GenerateNewProblem()
        {
            currentA = rng.Next(100, 501); // 100..500 inclusive
            currentB = rng.Next(100, 501);

            firstNumberLabel.Text = currentA.ToString();
            secondNumberLabel.Text = currentB.ToString();

            answerTextBox.Clear();
            answerTextBox.Focus();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            int currentC = currentA + currentB;
            try
            {
                if (int.TryParse(answerTextBox.Text, out int ansText))
                {
                    if (ansText == currentC)
                    {

                        messageLabel.Text = "Correct ✔ Well done.";
                    }
                    else
                    {
                        messageLabel.Text = $"Incorrect — The correct answer was: {currentC}";
                    }
                }
                else
                {
                    MessageBox.Show("Please enter your answer.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    answerTextBox.Clear();
                    answerTextBox.Focus();
                    return;
                }

                // Generate a new problem regardless (as spec requires)
                GenerateNewProblem();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            messageLabel.Text = string.Empty;
            GenerateNewProblem();
            answerTextBox.Clear();
        }
    }
}
