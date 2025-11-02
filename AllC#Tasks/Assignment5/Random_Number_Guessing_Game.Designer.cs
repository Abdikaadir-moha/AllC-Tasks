namespace AllC_Tasks.Assignment5
{
    partial class Random_Number_Guessing_Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            titleLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            messageLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ClearBtn = new Guna.UI2.WinForms.Guna2Button();
            CheckButton = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guessTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            descriptionLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(titleLabel);
            headerPanel.CustomizableEdges = customizableEdges1;
            headerPanel.Location = new Point(-1, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            headerPanel.Size = new Size(681, 72);
            headerPanel.TabIndex = 3;
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.Black;
            titleLabel.Location = new Point(107, 12);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(439, 40);
            titleLabel.TabIndex = 6;
            titleLabel.Text = "Random Number Guessing Game";
            titleLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = false;
            messageLabel.BackColor = Color.Transparent;
            messageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            messageLabel.Location = new Point(119, 246);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(426, 37);
            messageLabel.TabIndex = 22;
            messageLabel.Text = null;
            // 
            // ClearBtn
            // 
            ClearBtn.BorderColor = Color.Transparent;
            ClearBtn.BorderRadius = 8;
            ClearBtn.CustomBorderColor = Color.Transparent;
            ClearBtn.CustomizableEdges = customizableEdges3;
            ClearBtn.DisabledState.BorderColor = Color.DarkGray;
            ClearBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            ClearBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ClearBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ClearBtn.FillColor = Color.FromArgb(100, 181, 246);
            ClearBtn.FocusedColor = Color.Transparent;
            ClearBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearBtn.ForeColor = Color.White;
            ClearBtn.Location = new Point(345, 380);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ClearBtn.Size = new Size(156, 58);
            ClearBtn.TabIndex = 2;
            ClearBtn.Text = "Clear";
            ClearBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // CheckButton
            // 
            CheckButton.BorderColor = Color.Transparent;
            CheckButton.BorderRadius = 8;
            CheckButton.CustomBorderColor = Color.Transparent;
            CheckButton.CustomizableEdges = customizableEdges5;
            CheckButton.DisabledState.BorderColor = Color.DarkGray;
            CheckButton.DisabledState.CustomBorderColor = Color.DarkGray;
            CheckButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            CheckButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            CheckButton.FillColor = SystemColors.Highlight;
            CheckButton.FocusedColor = Color.Transparent;
            CheckButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckButton.ForeColor = Color.White;
            CheckButton.Location = new Point(162, 380);
            CheckButton.Name = "CheckButton";
            CheckButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            CheckButton.Size = new Size(165, 58);
            CheckButton.TabIndex = 1;
            CheckButton.Text = "Check Guess";
            CheckButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            CheckButton.Click += CheckButton_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.AutoSize = false;
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(136, 164);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(191, 37);
            guna2HtmlLabel1.TabIndex = 24;
            guna2HtmlLabel1.Text = "Enter your Guess:";
            // 
            // guessTextBox
            // 
            guessTextBox.BorderRadius = 8;
            guessTextBox.CustomizableEdges = customizableEdges7;
            guessTextBox.DefaultText = "";
            guessTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guessTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guessTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guessTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guessTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guessTextBox.Font = new Font("Segoe UI", 9F);
            guessTextBox.ForeColor = Color.Black;
            guessTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guessTextBox.Location = new Point(346, 163);
            guessTextBox.Margin = new Padding(4, 5, 4, 5);
            guessTextBox.Name = "guessTextBox";
            guessTextBox.PlaceholderForeColor = Color.Gray;
            guessTextBox.PlaceholderText = "Enter value…";
            guessTextBox.SelectedText = "";
            guessTextBox.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guessTextBox.Size = new Size(155, 38);
            guessTextBox.TabIndex = 0;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = false;
            descriptionLabel.BackColor = Color.Transparent;
            descriptionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptionLabel.Location = new Point(126, 88);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(410, 37);
            descriptionLabel.TabIndex = 26;
            descriptionLabel.Text = "Guess a number between 1 and 100";
            // 
            // Random_Number_Guessing_Game
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 450);
            Controls.Add(descriptionLabel);
            Controls.Add(guessTextBox);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(messageLabel);
            Controls.Add(ClearBtn);
            Controls.Add(CheckButton);
            Controls.Add(headerPanel);
            Name = "Random_Number_Guessing_Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Random_Number_Guessing_Game";
            Load += Random_Number_Guessing_Game_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel titleLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel messageLabel;
        private Guna.UI2.WinForms.Guna2Button ClearBtn;
        private Guna.UI2.WinForms.Guna2Button CheckButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox guessTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel descriptionLabel;
    }
}