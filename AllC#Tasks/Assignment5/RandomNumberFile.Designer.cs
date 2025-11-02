namespace AllC_Tasks.Assignment5
{
    partial class RandomNumberFile
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
            countTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            countLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ClearButton = new Guna.UI2.WinForms.Guna2Button();
            GenerateButton = new Guna.UI2.WinForms.Guna2Button();
            descriptionLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            titleLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            saveFileDialog1 = new SaveFileDialog();
            messageLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // countTextBox
            // 
            countTextBox.BorderRadius = 8;
            countTextBox.CustomizableEdges = customizableEdges1;
            countTextBox.DefaultText = "";
            countTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            countTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            countTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            countTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            countTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            countTextBox.Font = new Font("Segoe UI", 9F);
            countTextBox.ForeColor = Color.Black;
            countTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            countTextBox.Location = new Point(361, 216);
            countTextBox.Margin = new Padding(4, 5, 4, 5);
            countTextBox.Name = "countTextBox";
            countTextBox.PlaceholderForeColor = Color.Gray;
            countTextBox.PlaceholderText = "Enter value…";
            countTextBox.SelectedText = "";
            countTextBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            countTextBox.Size = new Size(155, 38);
            countTextBox.TabIndex = 0;
            // 
            // countLabel
            // 
            countLabel.BackColor = Color.Transparent;
            countLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            countLabel.ForeColor = Color.FromArgb(44, 44, 44);
            countLabel.Location = new Point(84, 219);
            countLabel.Name = "countLabel";
            countLabel.Size = new Size(263, 30);
            countLabel.TabIndex = 29;
            countLabel.Text = "Number of Random Values:";
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
            ClearButton.Location = new Point(373, 467);
            ClearButton.Name = "ClearButton";
            ClearButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ClearButton.Size = new Size(156, 58);
            ClearButton.TabIndex = 2;
            ClearButton.Text = "Clear";
            ClearButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            ClearButton.Click += ClearButton_Click;
            // 
            // GenerateButton
            // 
            GenerateButton.BorderColor = Color.Transparent;
            GenerateButton.BorderRadius = 8;
            GenerateButton.CustomBorderColor = Color.Transparent;
            GenerateButton.CustomizableEdges = customizableEdges5;
            GenerateButton.DisabledState.BorderColor = Color.DarkGray;
            GenerateButton.DisabledState.CustomBorderColor = Color.DarkGray;
            GenerateButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            GenerateButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            GenerateButton.FillColor = SystemColors.Highlight;
            GenerateButton.FocusedColor = Color.Transparent;
            GenerateButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GenerateButton.ForeColor = Color.White;
            GenerateButton.Location = new Point(104, 467);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            GenerateButton.Size = new Size(224, 58);
            GenerateButton.TabIndex = 1;
            GenerateButton.Text = "Generate And Save";
            GenerateButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = false;
            descriptionLabel.BackColor = Color.Transparent;
            descriptionLabel.BorderStyle = BorderStyle.Fixed3D;
            descriptionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptionLabel.Location = new Point(90, 89);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Padding = new Padding(2);
            descriptionLabel.Size = new Size(451, 75);
            descriptionLabel.TabIndex = 28;
            descriptionLabel.Text = "Enter how many random numbers \r\nto generate and save to a file.";
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.Black;
            titleLabel.Location = new Point(219, 13);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(256, 40);
            titleLabel.TabIndex = 6;
            titleLabel.Text = "Factorial Calculator";
            titleLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(titleLabel);
            headerPanel.CustomizableEdges = customizableEdges7;
            headerPanel.Location = new Point(2, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.ShadowDecoration.CustomizableEdges = customizableEdges8;
            headerPanel.Size = new Size(681, 72);
            headerPanel.TabIndex = 30;
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = false;
            messageLabel.BackColor = Color.Transparent;
            messageLabel.BorderStyle = BorderStyle.Fixed3D;
            messageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            messageLabel.Location = new Point(63, 297);
            messageLabel.Name = "messageLabel";
            messageLabel.Padding = new Padding(2);
            messageLabel.Size = new Size(486, 89);
            messageLabel.TabIndex = 31;
            messageLabel.Text = "—";
            messageLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // RandomNumberFile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 537);
            Controls.Add(messageLabel);
            Controls.Add(headerPanel);
            Controls.Add(countTextBox);
            Controls.Add(countLabel);
            Controls.Add(ClearButton);
            Controls.Add(GenerateButton);
            Controls.Add(descriptionLabel);
            Name = "RandomNumberFile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RandomNumberFile";
            Load += RandomNumberFile_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox countTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel countLabel;
        private Guna.UI2.WinForms.Guna2Button ClearButton;
        private Guna.UI2.WinForms.Guna2Button GenerateButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel descriptionLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel titleLabel;
        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private SaveFileDialog saveFileDialog1;
        private Guna.UI2.WinForms.Guna2HtmlLabel messageLabel;
    }
}