namespace Wholeproject
{
    partial class SpeedConverter
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
            outputListBox = new ListBox();
            ClearButton = new Guna.UI2.WinForms.Guna2Button();
            CalculateButton = new Guna.UI2.WinForms.Guna2Button();
            headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            titleLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // outputListBox
            // 
            outputListBox.FormattingEnabled = true;
            outputListBox.ItemHeight = 25;
            outputListBox.Location = new Point(40, 94);
            outputListBox.Name = "outputListBox";
            outputListBox.Size = new Size(414, 229);
            outputListBox.TabIndex = 82;
            // 
            // ClearButton
            // 
            ClearButton.BorderColor = Color.Transparent;
            ClearButton.BorderRadius = 8;
            ClearButton.CustomBorderColor = Color.Transparent;
            ClearButton.CustomizableEdges = customizableEdges1;
            ClearButton.DisabledState.BorderColor = Color.DarkGray;
            ClearButton.DisabledState.CustomBorderColor = Color.DarkGray;
            ClearButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ClearButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ClearButton.FillColor = Color.FromArgb(100, 181, 246);
            ClearButton.FocusedColor = Color.Transparent;
            ClearButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearButton.ForeColor = Color.White;
            ClearButton.Location = new Point(258, 400);
            ClearButton.Name = "ClearButton";
            ClearButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ClearButton.Size = new Size(156, 58);
            ClearButton.TabIndex = 86;
            ClearButton.Text = "Clear";
            ClearButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            ClearButton.Click += ClearButton_Click;
            // 
            // CalculateButton
            // 
            CalculateButton.BorderColor = Color.Transparent;
            CalculateButton.BorderRadius = 8;
            CalculateButton.CustomBorderColor = Color.Transparent;
            CalculateButton.CustomizableEdges = customizableEdges3;
            CalculateButton.DisabledState.BorderColor = Color.DarkGray;
            CalculateButton.DisabledState.CustomBorderColor = Color.DarkGray;
            CalculateButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            CalculateButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            CalculateButton.FillColor = SystemColors.Highlight;
            CalculateButton.FocusedColor = Color.Transparent;
            CalculateButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CalculateButton.ForeColor = Color.White;
            CalculateButton.Location = new Point(75, 400);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            CalculateButton.Size = new Size(143, 58);
            CalculateButton.TabIndex = 85;
            CalculateButton.Text = "Calculate";
            CalculateButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(titleLabel);
            headerPanel.CustomizableEdges = customizableEdges5;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.ShadowDecoration.CustomizableEdges = customizableEdges6;
            headerPanel.Size = new Size(507, 72);
            headerPanel.TabIndex = 87;
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.Black;
            titleLabel.Location = new Point(142, 12);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(222, 40);
            titleLabel.TabIndex = 6;
            titleLabel.Text = "Speed Convertor";
            titleLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // SpeedConverter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 472);
            Controls.Add(headerPanel);
            Controls.Add(ClearButton);
            Controls.Add(CalculateButton);
            Controls.Add(outputListBox);
            Name = "SpeedConverter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SpeedConverter";
            Load += SpeedConverter_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListBox outputListBox;
        private Guna.UI2.WinForms.Guna2Button ClearButton;
        private Guna.UI2.WinForms.Guna2Button CalculateButton;
        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel titleLabel;
    }
}