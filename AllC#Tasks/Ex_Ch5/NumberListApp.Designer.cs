namespace AllC_Tasks.Ex_Ch5
{
    partial class NameListApp
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            nameTextBox = new TextBox();
            label1 = new Label();
            DataListBox = new ListBox();
            titleLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            ClearButton = new Guna.UI2.WinForms.Guna2Button();
            WritingNameButton = new Guna.UI2.WinForms.Guna2Button();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(198, 98);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(150, 31);
            nameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 98);
            label1.Name = "label1";
            label1.Size = new Size(132, 28);
            label1.TabIndex = 5;
            label1.Text = "Enter a data:";
            // 
            // DataListBox
            // 
            DataListBox.FormattingEnabled = true;
            DataListBox.ItemHeight = 25;
            DataListBox.Location = new Point(83, 152);
            DataListBox.Name = "DataListBox";
            DataListBox.Size = new Size(245, 204);
            DataListBox.TabIndex = 3;
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.Black;
            titleLabel.Location = new Point(34, 11);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(325, 40);
            titleLabel.TabIndex = 6;
            titleLabel.Text = "Name list Using TextBox";
            titleLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(titleLabel);
            headerPanel.CustomizableEdges = customizableEdges13;
            headerPanel.Location = new Point(-2, 1);
            headerPanel.Name = "headerPanel";
            headerPanel.ShadowDecoration.CustomizableEdges = customizableEdges14;
            headerPanel.Size = new Size(424, 72);
            headerPanel.TabIndex = 6;
            // 
            // ClearButton
            // 
            ClearButton.BorderColor = Color.Transparent;
            ClearButton.BorderRadius = 8;
            ClearButton.CustomBorderColor = Color.Transparent;
            ClearButton.CustomizableEdges = customizableEdges15;
            ClearButton.DisabledState.BorderColor = Color.DarkGray;
            ClearButton.DisabledState.CustomBorderColor = Color.DarkGray;
            ClearButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ClearButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ClearButton.FillColor = Color.FromArgb(100, 181, 246);
            ClearButton.FocusedColor = Color.Transparent;
            ClearButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearButton.ForeColor = Color.White;
            ClearButton.Location = new Point(217, 412);
            ClearButton.Name = "ClearButton";
            ClearButton.ShadowDecoration.CustomizableEdges = customizableEdges16;
            ClearButton.Size = new Size(156, 58);
            ClearButton.TabIndex = 8;
            ClearButton.Text = "Clear";
            ClearButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            ClearButton.Click += ClearButton_Click;
            // 
            // WritingNameButton
            // 
            WritingNameButton.BorderColor = Color.Transparent;
            WritingNameButton.BorderRadius = 8;
            WritingNameButton.CustomBorderColor = Color.Transparent;
            WritingNameButton.CustomizableEdges = customizableEdges17;
            WritingNameButton.DisabledState.BorderColor = Color.DarkGray;
            WritingNameButton.DisabledState.CustomBorderColor = Color.DarkGray;
            WritingNameButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            WritingNameButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            WritingNameButton.FillColor = SystemColors.Highlight;
            WritingNameButton.FocusedColor = Color.Transparent;
            WritingNameButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WritingNameButton.ForeColor = Color.White;
            WritingNameButton.Location = new Point(34, 412);
            WritingNameButton.Name = "WritingNameButton";
            WritingNameButton.ShadowDecoration.CustomizableEdges = customizableEdges18;
            WritingNameButton.Size = new Size(159, 58);
            WritingNameButton.TabIndex = 7;
            WritingNameButton.Text = "Write Name";
            WritingNameButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            WritingNameButton.Click += WritingNameButton_Click;
            // 
            // NameListApp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 493);
            Controls.Add(ClearButton);
            Controls.Add(WritingNameButton);
            Controls.Add(headerPanel);
            Controls.Add(DataListBox);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Name = "NameListApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NumberListApp";
            Load += NumberListApp_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox nameTextBox;
        private Label label1;
        private ListBox DataListBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel titleLabel;
        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private Guna.UI2.WinForms.Guna2Button ClearButton;
        private Guna.UI2.WinForms.Guna2Button WritingNameButton;
    }
}