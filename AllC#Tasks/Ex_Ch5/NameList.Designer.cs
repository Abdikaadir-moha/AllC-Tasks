namespace Wholeproject
{
    partial class NameList
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
            groupBox2 = new GroupBox();
            nameListBox = new ListBox();
            ClearBtn = new Guna.UI2.WinForms.Guna2Button();
            AddingButton = new Guna.UI2.WinForms.Guna2Button();
            headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            titleLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            messageLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            groupBox2.SuspendLayout();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(nameListBox);
            groupBox2.Location = new Point(61, 95);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(455, 250);
            groupBox2.TabIndex = 86;
            groupBox2.TabStop = false;
            groupBox2.Text = "Name List";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // nameListBox
            // 
            nameListBox.FormattingEnabled = true;
            nameListBox.ItemHeight = 25;
            nameListBox.Location = new Point(38, 45);
            nameListBox.Name = "nameListBox";
            nameListBox.Size = new Size(393, 179);
            nameListBox.TabIndex = 81;
            nameListBox.SelectedIndexChanged += nameListBox_SelectedIndexChanged;
            // 
            // ClearBtn
            // 
            ClearBtn.BorderColor = Color.Transparent;
            ClearBtn.BorderRadius = 8;
            ClearBtn.CustomBorderColor = Color.Transparent;
            ClearBtn.CustomizableEdges = customizableEdges1;
            ClearBtn.DisabledState.BorderColor = Color.DarkGray;
            ClearBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            ClearBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ClearBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ClearBtn.FillColor = Color.FromArgb(100, 181, 246);
            ClearBtn.FocusedColor = Color.Transparent;
            ClearBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearBtn.ForeColor = Color.White;
            ClearBtn.Location = new Point(331, 474);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ClearBtn.Size = new Size(156, 58);
            ClearBtn.TabIndex = 83;
            ClearBtn.Text = "Clear";
            ClearBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            ClearBtn.Click += ClearBtn_Click;
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
            AddingButton.Location = new Point(131, 474);
            AddingButton.Name = "AddingButton";
            AddingButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            AddingButton.Size = new Size(143, 58);
            AddingButton.TabIndex = 82;
            AddingButton.Text = "Add";
            AddingButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            AddingButton.Click += AddingButton_Click;
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(titleLabel);
            headerPanel.CustomizableEdges = customizableEdges5;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.ShadowDecoration.CustomizableEdges = customizableEdges6;
            headerPanel.Size = new Size(608, 72);
            headerPanel.TabIndex = 87;
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.Black;
            titleLabel.Location = new Point(131, 12);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(318, 40);
            titleLabel.TabIndex = 6;
            titleLabel.Text = "Number List  application ";
            titleLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = false;
            messageLabel.BackColor = Color.Transparent;
            messageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            messageLabel.Location = new Point(61, 380);
            messageLabel.Name = "messageLabel";
            messageLabel.Padding = new Padding(2);
            messageLabel.Size = new Size(459, 56);
            messageLabel.TabIndex = 88;
            messageLabel.Text = null;
            messageLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // NameList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 548);
            Controls.Add(messageLabel);
            Controls.Add(headerPanel);
            Controls.Add(AddingButton);
            Controls.Add(ClearBtn);
            Controls.Add(groupBox2);
            Name = "NameList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NameList";
            Load += NameList_Load;
            groupBox2.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private ListBox nameListBox;
        private Guna.UI2.WinForms.Guna2Button ClearBtn;
        private Guna.UI2.WinForms.Guna2Button AddingButton;
        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel titleLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel messageLabel;
    }
}