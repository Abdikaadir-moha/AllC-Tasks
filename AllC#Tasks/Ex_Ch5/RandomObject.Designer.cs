namespace Wholeproject
{
    partial class RandomObject
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
            lblRandomNumber = new Label();
            headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            titleLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ClearButton = new Guna.UI2.WinForms.Guna2Button();
            GenerateButton = new Guna.UI2.WinForms.Guna2Button();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblRandomNumber
            // 
            lblRandomNumber.BackColor = Color.DarkKhaki;
            lblRandomNumber.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRandomNumber.ForeColor = Color.White;
            lblRandomNumber.Location = new Point(56, 108);
            lblRandomNumber.Name = "lblRandomNumber";
            lblRandomNumber.Size = new Size(350, 51);
            lblRandomNumber.TabIndex = 3;
            lblRandomNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(titleLabel);
            headerPanel.CustomizableEdges = customizableEdges1;
            headerPanel.Location = new Point(-2, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            headerPanel.Size = new Size(460, 72);
            headerPanel.TabIndex = 5;
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.Black;
            titleLabel.Location = new Point(44, 12);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(351, 40);
            titleLabel.TabIndex = 6;
            titleLabel.Text = "Random Number Program";
            titleLabel.TextAlignment = ContentAlignment.MiddleCenter;
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
            ClearButton.Location = new Point(237, 231);
            ClearButton.Name = "ClearButton";
            ClearButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ClearButton.Size = new Size(156, 58);
            ClearButton.TabIndex = 7;
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
            GenerateButton.Location = new Point(57, 217);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            GenerateButton.Size = new Size(143, 72);
            GenerateButton.TabIndex = 6;
            GenerateButton.Text = "Generate Numbrs";
            GenerateButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // RandomObject
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 314);
            Controls.Add(ClearButton);
            Controls.Add(GenerateButton);
            Controls.Add(headerPanel);
            Controls.Add(lblRandomNumber);
            Name = "RandomObject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RandomObject";
            Load += RandomObject_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblRandomNumber;
        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel titleLabel;
        private Guna.UI2.WinForms.Guna2Button ClearButton;
        private Guna.UI2.WinForms.Guna2Button GenerateButton;
    }
}