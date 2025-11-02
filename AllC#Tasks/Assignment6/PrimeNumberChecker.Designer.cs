namespace AllC_Tasks.Assignment6
{
    partial class PrimeNumberChecker
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
            numberTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            numberLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            resultLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ClearButton = new Guna.UI2.WinForms.Guna2Button();
            CheckButton = new Guna.UI2.WinForms.Guna2Button();
            messageLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
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
            headerPanel.Size = new Size(610, 72);
            headerPanel.TabIndex = 43;
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.Black;
            titleLabel.Location = new Point(144, 12);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(308, 40);
            titleLabel.TabIndex = 6;
            titleLabel.Text = "Prime Number Checker";
            titleLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // numberTextBox
            // 
            numberTextBox.BorderRadius = 8;
            numberTextBox.CustomizableEdges = customizableEdges3;
            numberTextBox.DefaultText = "";
            numberTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            numberTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            numberTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            numberTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            numberTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            numberTextBox.Font = new Font("Segoe UI", 9F);
            numberTextBox.ForeColor = Color.Black;
            numberTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            numberTextBox.Location = new Point(248, 109);
            numberTextBox.Margin = new Padding(4, 5, 4, 5);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.PlaceholderForeColor = Color.Gray;
            numberTextBox.PlaceholderText = "Enter value…";
            numberTextBox.SelectedText = "";
            numberTextBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            numberTextBox.Size = new Size(155, 38);
            numberTextBox.TabIndex = 0;
            // 
            // numberLabel
            // 
            numberLabel.BackColor = Color.Transparent;
            numberLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numberLabel.ForeColor = Color.FromArgb(44, 44, 44);
            numberLabel.Location = new Point(68, 109);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(173, 32);
            numberLabel.TabIndex = 45;
            numberLabel.Text = "Enter a Number:";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.ForeColor = Color.FromArgb(44, 44, 44);
            guna2HtmlLabel2.Location = new Point(152, 195);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(81, 34);
            guna2HtmlLabel2.TabIndex = 47;
            guna2HtmlLabel2.Text = "Result:";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = false;
            resultLabel.BackColor = Color.Transparent;
            resultLabel.BorderStyle = BorderStyle.Fixed3D;
            resultLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultLabel.Location = new Point(247, 188);
            resultLabel.Name = "resultLabel";
            resultLabel.Padding = new Padding(2);
            resultLabel.Size = new Size(156, 49);
            resultLabel.TabIndex = 3;
            resultLabel.Text = null;
            resultLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // ClearButton
            // 
            ClearButton.BorderColor = Color.Transparent;
            ClearButton.BorderRadius = 8;
            ClearButton.CustomBorderColor = Color.Transparent;
            ClearButton.CustomizableEdges = customizableEdges5;
            ClearButton.DisabledState.BorderColor = Color.DarkGray;
            ClearButton.DisabledState.CustomBorderColor = Color.DarkGray;
            ClearButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ClearButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ClearButton.FillColor = Color.FromArgb(100, 181, 246);
            ClearButton.FocusedColor = Color.Transparent;
            ClearButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearButton.ForeColor = Color.White;
            ClearButton.Location = new Point(320, 361);
            ClearButton.Name = "ClearButton";
            ClearButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            ClearButton.Size = new Size(156, 58);
            ClearButton.TabIndex = 2;
            ClearButton.Text = "Clear";
            ClearButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            ClearButton.Click += ClearButton_Click;
            // 
            // CheckButton
            // 
            CheckButton.BorderColor = Color.Transparent;
            CheckButton.BorderRadius = 8;
            CheckButton.CustomBorderColor = Color.Transparent;
            CheckButton.CustomizableEdges = customizableEdges7;
            CheckButton.DisabledState.BorderColor = Color.DarkGray;
            CheckButton.DisabledState.CustomBorderColor = Color.DarkGray;
            CheckButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            CheckButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            CheckButton.FillColor = SystemColors.Highlight;
            CheckButton.FocusedColor = Color.Transparent;
            CheckButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckButton.ForeColor = Color.White;
            CheckButton.Location = new Point(137, 361);
            CheckButton.Name = "CheckButton";
            CheckButton.ShadowDecoration.CustomizableEdges = customizableEdges8;
            CheckButton.Size = new Size(143, 58);
            CheckButton.TabIndex = 1;
            CheckButton.Text = "Check";
            CheckButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            CheckButton.Click += CheckButton_Click;
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = false;
            messageLabel.BackColor = Color.Transparent;
            messageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            messageLabel.Location = new Point(68, 276);
            messageLabel.Name = "messageLabel";
            messageLabel.Padding = new Padding(2);
            messageLabel.Size = new Size(459, 56);
            messageLabel.TabIndex = 4;
            messageLabel.Text = null;
            messageLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // PrimeNumberChecker
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 431);
            Controls.Add(messageLabel);
            Controls.Add(ClearButton);
            Controls.Add(CheckButton);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(resultLabel);
            Controls.Add(numberTextBox);
            Controls.Add(numberLabel);
            Controls.Add(headerPanel);
            Name = "PrimeNumberChecker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrimeNumberChecker";
            Load += PrimeNumberChecker_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel titleLabel;
        private Guna.UI2.WinForms.Guna2TextBox numberTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel numberLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel resultLabel;
        private Guna.UI2.WinForms.Guna2Button ClearButton;
        private Guna.UI2.WinForms.Guna2Button CheckButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel messageLabel;
    }
}