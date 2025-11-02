namespace Wholeproject
{
    partial class NumberListBox
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
            numbersListBox = new ListBox();
            ClearButton = new Guna.UI2.WinForms.Guna2Button();
            AddingButton = new Guna.UI2.WinForms.Guna2Button();
            headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            titleLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // numbersListBox
            // 
            numbersListBox.FormattingEnabled = true;
            numbersListBox.ItemHeight = 25;
            numbersListBox.Location = new Point(48, 108);
            numbersListBox.Name = "numbersListBox";
            numbersListBox.Size = new Size(393, 179);
            numbersListBox.TabIndex = 81;
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
            ClearButton.Location = new Point(264, 341);
            ClearButton.Name = "ClearButton";
            ClearButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ClearButton.Size = new Size(156, 58);
            ClearButton.TabIndex = 83;
            ClearButton.Text = "Clear";
            ClearButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            ClearButton.Click += ClearButton_Click;
            // 
            // AddingButton
            // 
            AddingButton.BorderColor = Color.Transparent;
            AddingButton.BorderRadius = 8;
            AddingButton.CustomBorderColor = Color.Transparent;
            AddingButton.CustomizableEdges = customizableEdges3;
            AddingButton.DisabledState.BorderColor = Color.DarkGray;
            AddingButton.DisabledState.CustomBorderColor = Color.DarkGray;
            AddingButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            AddingButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            AddingButton.FillColor = SystemColors.Highlight;
            AddingButton.FocusedColor = Color.Transparent;
            AddingButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddingButton.ForeColor = Color.White;
            AddingButton.Location = new Point(79, 341);
            AddingButton.Name = "AddingButton";
            AddingButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            AddingButton.Size = new Size(159, 58);
            AddingButton.TabIndex = 82;
            AddingButton.Text = "Add";
            AddingButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            AddingButton.Click += AddingButton_Click;
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(titleLabel);
            headerPanel.CustomizableEdges = customizableEdges5;
            headerPanel.Location = new Point(1, -1);
            headerPanel.Name = "headerPanel";
            headerPanel.ShadowDecoration.CustomizableEdges = customizableEdges6;
            headerPanel.Size = new Size(484, 72);
            headerPanel.TabIndex = 84;
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.Black;
            titleLabel.Location = new Point(64, 13);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(355, 40);
            titleLabel.TabIndex = 6;
            titleLabel.Text = "Number list Using TextBox";
            titleLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // NumberListBox
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 435);
            Controls.Add(headerPanel);
            Controls.Add(ClearButton);
            Controls.Add(AddingButton);
            Controls.Add(numbersListBox);
            Name = "NumberListBox";
            Text = "NumberListBox";
            Load += NumberListBox_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListBox numbersListBox;
        private Guna.UI2.WinForms.Guna2Button ClearButton;
        private Guna.UI2.WinForms.Guna2Button AddingButton;
        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel titleLabel;
    }
}