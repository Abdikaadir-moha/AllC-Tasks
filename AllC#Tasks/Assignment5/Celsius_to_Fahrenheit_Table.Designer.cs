namespace AllC_Tasks.Assignment5
{
    partial class Celsius_to_Fahrenheit_Table
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
            headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            titleLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ShowButton = new Guna.UI2.WinForms.Guna2Button();
            resultListBox = new ListBox();
            ClearBtn = new Guna.UI2.WinForms.Guna2Button();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(titleLabel);
            headerPanel.CustomizableEdges = customizableEdges1;
            headerPanel.Location = new Point(0, 1);
            headerPanel.Name = "headerPanel";
            headerPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            headerPanel.Size = new Size(673, 64);
            headerPanel.TabIndex = 4;
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.Black;
            titleLabel.Location = new Point(158, 11);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(356, 40);
            titleLabel.TabIndex = 7;
            titleLabel.Text = "Celsius to Fahrenheit Table";
            titleLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // ShowButton
            // 
            ShowButton.BorderColor = Color.Transparent;
            ShowButton.BorderRadius = 8;
            ShowButton.CustomBorderColor = Color.Transparent;
            ShowButton.CustomizableEdges = customizableEdges3;
            ShowButton.DisabledState.BorderColor = Color.DarkGray;
            ShowButton.DisabledState.CustomBorderColor = Color.DarkGray;
            ShowButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ShowButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ShowButton.FillColor = SystemColors.Highlight;
            ShowButton.FocusedColor = Color.Transparent;
            ShowButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowButton.ForeColor = Color.White;
            ShowButton.Location = new Point(146, 490);
            ShowButton.Name = "ShowButton";
            ShowButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ShowButton.Size = new Size(156, 58);
            ShowButton.TabIndex = 0;
            ShowButton.Text = "Show Table";
            ShowButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            ShowButton.Click += ShowButton_Click;
            // 
            // resultListBox
            // 
            resultListBox.BackColor = Color.White;
            resultListBox.BorderStyle = BorderStyle.FixedSingle;
            resultListBox.FormattingEnabled = true;
            resultListBox.ItemHeight = 25;
            resultListBox.Location = new Point(50, 119);
            resultListBox.Name = "resultListBox";
            resultListBox.Size = new Size(554, 302);
            resultListBox.TabIndex = 11;
            // 
            // ClearBtn
            // 
            ClearBtn.BorderColor = Color.Transparent;
            ClearBtn.BorderRadius = 8;
            ClearBtn.CustomBorderColor = Color.Transparent;
            ClearBtn.CustomizableEdges = customizableEdges5;
            ClearBtn.DisabledState.BorderColor = Color.DarkGray;
            ClearBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            ClearBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ClearBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ClearBtn.FillColor = SystemColors.Highlight;
            ClearBtn.FocusedColor = Color.Transparent;
            ClearBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearBtn.ForeColor = Color.White;
            ClearBtn.Location = new Point(346, 490);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            ClearBtn.Size = new Size(156, 58);
            ClearBtn.TabIndex = 1;
            ClearBtn.Text = "Clear";
            ClearBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // Celsius_to_Fahrenheit_Table
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 583);
            Controls.Add(ClearBtn);
            Controls.Add(resultListBox);
            Controls.Add(ShowButton);
            Controls.Add(headerPanel);
            Name = "Celsius_to_Fahrenheit_Table";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Celsius_to_Fahrenheit_Table";
            Load += Celsius_to_Fahrenheit_Table_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel titleLabel;
        private Guna.UI2.WinForms.Guna2Button ShowButton;
        private ListBox resultListBox;
        private Guna.UI2.WinForms.Guna2Button ClearBtn;
    }
}