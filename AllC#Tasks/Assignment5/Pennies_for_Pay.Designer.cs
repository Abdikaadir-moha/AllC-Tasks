namespace AllC_Tasks.Assignment5
{
    partial class Pennies_for_Pay
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
            titleLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            daysLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            daysTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            totalLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            CalculateButton = new Guna.UI2.WinForms.Guna2Button();
            payListBox = new ListBox();
            ClearBtn = new Guna.UI2.WinForms.Guna2Button();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.Black;
            titleLabel.Location = new Point(231, 12);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(206, 40);
            titleLabel.TabIndex = 6;
            titleLabel.Text = "Pennies for Pay";
            titleLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(titleLabel);
            headerPanel.CustomizableEdges = customizableEdges1;
            headerPanel.Location = new Point(-4, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            headerPanel.Size = new Size(681, 72);
            headerPanel.TabIndex = 1;
            // 
            // daysLabel
            // 
            daysLabel.BackColor = Color.Transparent;
            daysLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            daysLabel.Location = new Point(60, 116);
            daysLabel.Name = "daysLabel";
            daysLabel.Size = new Size(288, 30);
            daysLabel.TabIndex = 2;
            daysLabel.Text = "Enter number of days worked:";
            // 
            // daysTextBox
            // 
            daysTextBox.BorderRadius = 8;
            daysTextBox.CustomizableEdges = customizableEdges3;
            daysTextBox.DefaultText = "";
            daysTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            daysTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            daysTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            daysTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            daysTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            daysTextBox.Font = new Font("Segoe UI", 9F);
            daysTextBox.ForeColor = Color.Black;
            daysTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            daysTextBox.Location = new Point(353, 113);
            daysTextBox.Margin = new Padding(4, 5, 4, 5);
            daysTextBox.Name = "daysTextBox";
            daysTextBox.PlaceholderForeColor = Color.Gray;
            daysTextBox.PlaceholderText = "Enter value…";
            daysTextBox.SelectedText = "";
            daysTextBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            daysTextBox.Size = new Size(155, 38);
            daysTextBox.TabIndex = 8;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = false;
            totalLabel.BackColor = Color.Transparent;
            totalLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalLabel.Location = new Point(148, 188);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(200, 48);
            totalLabel.TabIndex = 9;
            totalLabel.Text = null;
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
            CalculateButton.Location = new Point(179, 622);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            CalculateButton.Size = new Size(143, 58);
            CalculateButton.TabIndex = 11;
            CalculateButton.Text = "Calculate";
            CalculateButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // payListBox
            // 
            payListBox.BackColor = Color.White;
            payListBox.BorderStyle = BorderStyle.FixedSingle;
            payListBox.FormattingEnabled = true;
            payListBox.ItemHeight = 28;
            payListBox.Location = new Point(60, 294);
            payListBox.Name = "payListBox";
            payListBox.Size = new Size(554, 282);
            payListBox.TabIndex = 12;
            // 
            // ClearBtn
            // 
            ClearBtn.BorderColor = Color.Transparent;
            ClearBtn.BorderRadius = 8;
            ClearBtn.CustomBorderColor = Color.Transparent;
            ClearBtn.CustomizableEdges = customizableEdges7;
            ClearBtn.DisabledState.BorderColor = Color.DarkGray;
            ClearBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            ClearBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ClearBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ClearBtn.FillColor = Color.FromArgb(100, 181, 246);
            ClearBtn.FocusedColor = Color.Transparent;
            ClearBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearBtn.ForeColor = Color.White;
            ClearBtn.Location = new Point(366, 622);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.ShadowDecoration.CustomizableEdges = customizableEdges8;
            ClearBtn.Size = new Size(156, 58);
            ClearBtn.TabIndex = 17;
            ClearBtn.Text = "Clear";
            ClearBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // Pennies_for_Pay
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 692);
            Controls.Add(ClearBtn);
            Controls.Add(payListBox);
            Controls.Add(CalculateButton);
            Controls.Add(totalLabel);
            Controls.Add(daysTextBox);
            Controls.Add(daysLabel);
            Controls.Add(headerPanel);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Pennies_for_Pay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pennies_for_Pay";
            Load += Pennies_for_Pay_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel titleLabel;
        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel daysLabel;
        private Guna.UI2.WinForms.Guna2TextBox daysTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel totalLabel;
        private Guna.UI2.WinForms.Guna2Button CalculateButton;
        private ListBox payListBox;
        private Guna.UI2.WinForms.Guna2Button ClearBtn;
    }
}