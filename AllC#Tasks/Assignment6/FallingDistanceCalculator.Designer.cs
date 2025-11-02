namespace AllC_Tasks.Assignment6
{
    partial class FallingDistanceCalculator
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
            descriptionLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            messageLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ClearButton = new Guna.UI2.WinForms.Guna2Button();
            CalculateButton = new Guna.UI2.WinForms.Guna2Button();
            resultLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            displayLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            timeTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            timeLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(titleLabel);
            headerPanel.CustomizableEdges = customizableEdges1;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            headerPanel.Size = new Size(681, 72);
            headerPanel.TabIndex = 4;
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.Black;
            titleLabel.Location = new Point(167, 12);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(351, 40);
            titleLabel.TabIndex = 6;
            titleLabel.Text = "Falling Distance Calculator";
            titleLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = false;
            descriptionLabel.BackColor = Color.Transparent;
            descriptionLabel.BorderStyle = BorderStyle.Fixed3D;
            descriptionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptionLabel.Location = new Point(95, 82);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Padding = new Padding(2);
            descriptionLabel.Size = new Size(488, 47);
            descriptionLabel.TabIndex = 21;
            descriptionLabel.Text = "Enter the time in seconds to calculate falling distance.";
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = false;
            messageLabel.BackColor = Color.Transparent;
            messageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            messageLabel.Location = new Point(108, 325);
            messageLabel.Name = "messageLabel";
            messageLabel.Padding = new Padding(2);
            messageLabel.Size = new Size(459, 56);
            messageLabel.TabIndex = 41;
            messageLabel.Text = null;
            messageLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // ClearButton
            // 
            ClearButton.BorderColor = Color.Transparent;
            ClearButton.BorderRadius = 8;
            ClearButton.CustomBorderColor = Color.Transparent;
            ClearButton.CustomizableEdges = customizableEdges3;
            ClearButton.DisabledState.BorderColor = Color.DarkGray;
            ClearButton.DisabledState.CustomBorderColor = Color.DarkGray;
            ClearButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ClearButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ClearButton.FillColor = Color.FromArgb(100, 181, 246);
            ClearButton.FocusedColor = Color.Transparent;
            ClearButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearButton.ForeColor = Color.White;
            ClearButton.Location = new Point(335, 431);
            ClearButton.Name = "ClearButton";
            ClearButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ClearButton.Size = new Size(156, 58);
            ClearButton.TabIndex = 2;
            ClearButton.Text = "Clear";
            ClearButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            ClearButton.Click += ClearButton_Click;
            // 
            // CalculateButton
            // 
            CalculateButton.BorderColor = Color.Transparent;
            CalculateButton.BorderRadius = 8;
            CalculateButton.CustomBorderColor = Color.Transparent;
            CalculateButton.CustomizableEdges = customizableEdges5;
            CalculateButton.DisabledState.BorderColor = Color.DarkGray;
            CalculateButton.DisabledState.CustomBorderColor = Color.DarkGray;
            CalculateButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            CalculateButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            CalculateButton.FillColor = SystemColors.Highlight;
            CalculateButton.FocusedColor = Color.Transparent;
            CalculateButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CalculateButton.ForeColor = Color.White;
            CalculateButton.Location = new Point(152, 431);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            CalculateButton.Size = new Size(143, 58);
            CalculateButton.TabIndex = 1;
            CalculateButton.Text = "Calculate";
            CalculateButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.BackColor = Color.Transparent;
            resultLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultLabel.ForeColor = Color.FromArgb(44, 44, 44);
            resultLabel.Location = new Point(46, 244);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(238, 34);
            resultLabel.TabIndex = 40;
            resultLabel.Text = "Falling Distance (m):";
            // 
            // displayLabel
            // 
            displayLabel.AutoSize = false;
            displayLabel.BackColor = Color.Transparent;
            displayLabel.BorderStyle = BorderStyle.Fixed3D;
            displayLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displayLabel.Location = new Point(295, 234);
            displayLabel.Name = "displayLabel";
            displayLabel.Padding = new Padding(2);
            displayLabel.Size = new Size(288, 56);
            displayLabel.TabIndex = 3;
            displayLabel.Text = "—";
            displayLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // timeTextBox
            // 
            timeTextBox.BorderRadius = 8;
            timeTextBox.CustomizableEdges = customizableEdges7;
            timeTextBox.DefaultText = "";
            timeTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            timeTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            timeTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            timeTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            timeTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            timeTextBox.Font = new Font("Segoe UI", 9F);
            timeTextBox.ForeColor = Color.Black;
            timeTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            timeTextBox.Location = new Point(295, 155);
            timeTextBox.Margin = new Padding(4, 5, 4, 5);
            timeTextBox.Name = "timeTextBox";
            timeTextBox.PlaceholderForeColor = Color.Gray;
            timeTextBox.PlaceholderText = "Enter value…";
            timeTextBox.SelectedText = "";
            timeTextBox.ShadowDecoration.CustomizableEdges = customizableEdges8;
            timeTextBox.Size = new Size(155, 38);
            timeTextBox.TabIndex = 0;
            // 
            // timeLabel
            // 
            timeLabel.BackColor = Color.Transparent;
            timeLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timeLabel.ForeColor = Color.FromArgb(44, 44, 44);
            timeLabel.Location = new Point(119, 157);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(165, 32);
            timeLabel.TabIndex = 39;
            timeLabel.Text = "Time (seconds):";
            // 
            // FallingDistanceCalculator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 501);
            Controls.Add(messageLabel);
            Controls.Add(ClearButton);
            Controls.Add(CalculateButton);
            Controls.Add(resultLabel);
            Controls.Add(displayLabel);
            Controls.Add(timeTextBox);
            Controls.Add(timeLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(headerPanel);
            Name = "FallingDistanceCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FallingDistanceCalculator";
            Load += FallingDistanceCalculator_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel titleLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel descriptionLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel messageLabel;
        private Guna.UI2.WinForms.Guna2Button ClearButton;
        private Guna.UI2.WinForms.Guna2Button CalculateButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel resultLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel displayLabel;
        private Guna.UI2.WinForms.Guna2TextBox timeTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel timeLabel;
    }
}