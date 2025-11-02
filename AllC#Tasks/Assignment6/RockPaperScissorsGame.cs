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
    public partial class RockPaperScissorsGame : Form
    {
        // Fix: Initialize labels to non-null values to avoid CS8601
        private Guna.UI2.WinForms.Guna2HtmlLabel computerChoiceLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
        private Guna.UI2.WinForms.Guna2HtmlLabel ResultLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
        private Guna.UI2.WinForms.Guna2HtmlLabel MessageLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();

        public RockPaperScissorsGame()
        {
            InitializeComponent();
        }

        private void RockPaperScissorsGame_Load(object sender, EventArgs e)
        {
            BackColor = AppTheme.BackgroundColor;

            // Header
            headerPanel.FillColor = AppTheme.HeaderColor;
            titleLabel.ForeColor = AppTheme.HeaderTextColor;
            titleLabel.Font = AppTheme.HeaderFont;

            // Labels (use correct type: Guna2HtmlLabel)
            foreach (Guna.UI2.WinForms.Guna2HtmlLabel lbl in new Guna.UI2.WinForms.Guna2HtmlLabel[] { computerChoiceLabel, resultLabel, messageLabel })
            {
                lbl.ForeColor = AppTheme.TextColor;
                lbl.Font = AppTheme.BodyFont;
            }

            messageLabel.ForeColor = AppTheme.InfoColor;
            messageLabel.Text = "";

            // === Buttons (with unique colors) ===
            RockButton.FillColor = AppTheme.DangerButtonColor;      // Red - Rock
            RockButton.Font = AppTheme.ButtonFont;
            RockButton.ForeColor = AppTheme.HeaderTextColor;

            PaperButton.FillColor = AppTheme.PrimaryButtonColor;    // Blue - Paper
            PaperButton.Font = AppTheme.ButtonFont;
            PaperButton.ForeColor = AppTheme.HeaderTextColor;

            ScissorsButton.FillColor = AppTheme.WarningColor;       // Yellow - Scissors
            ScissorsButton.Font = AppTheme.ButtonFont;
            ScissorsButton.ForeColor = AppTheme.TextColor;

            PlayAgainButton.FillColor = AppTheme.SecondaryButtonColor;  // Light Blue
            PlayAgainButton.Font = AppTheme.ButtonFont;
            PlayAgainButton.ForeColor = AppTheme.HeaderTextColor;
        }
    }
}
