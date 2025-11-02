namespace AllC_Tasks.Ex_Ch6
{
    partial class PassByRefApp
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
            outputListBox = new ListBox();
            ClearBtn = new Guna.UI2.WinForms.Guna2Button();
            GoButton = new Guna.UI2.WinForms.Guna2Button();
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
            headerPanel.Size = new Size(549, 72);
            headerPanel.TabIndex = 4;
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.Black;
            titleLabel.Location = new Point(145, 12);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(249, 40);
            titleLabel.TabIndex = 6;
            titleLabel.Text = "Pass By Refference";
            titleLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // outputListBox
            // 
            outputListBox.BackColor = Color.White;
            outputListBox.BorderStyle = BorderStyle.FixedSingle;
            outputListBox.FormattingEnabled = true;
            outputListBox.ItemHeight = 25;
            outputListBox.Items.AddRange(new object[] { "—" });
            outputListBox.Location = new Point(110, 89);
            outputListBox.Name = "outputListBox";
            outputListBox.Size = new Size(327, 177);
            outputListBox.TabIndex = 2;
            // 
            // ClearBtn
            // 
            ClearBtn.BorderColor = Color.Transparent;
            ClearBtn.BorderRadius = 8;
            ClearBtn.CustomBorderColor = Color.Transparent;
            ClearBtn.CustomizableEdges = customizableEdges3;
            ClearBtn.DisabledState.BorderColor = Color.DarkGray;
            ClearBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            ClearBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ClearBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ClearBtn.FillColor = Color.FromArgb(100, 181, 246);
            ClearBtn.FocusedColor = Color.Transparent;
            ClearBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearBtn.ForeColor = Color.White;
            ClearBtn.Location = new Point(292, 393);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ClearBtn.Size = new Size(156, 58);
            ClearBtn.TabIndex = 1;
            ClearBtn.Text = "Clear";
            ClearBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // GoButton
            // 
            GoButton.BorderColor = Color.Transparent;
            GoButton.BorderRadius = 8;
            GoButton.CustomBorderColor = Color.Transparent;
            GoButton.CustomizableEdges = customizableEdges5;
            GoButton.DisabledState.BorderColor = Color.DarkGray;
            GoButton.DisabledState.CustomBorderColor = Color.DarkGray;
            GoButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            GoButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            GoButton.FillColor = SystemColors.Highlight;
            GoButton.FocusedColor = Color.Transparent;
            GoButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GoButton.ForeColor = Color.White;
            GoButton.Location = new Point(107, 393);
            GoButton.Name = "GoButton";
            GoButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            GoButton.Size = new Size(143, 58);
            GoButton.TabIndex = 0;
            GoButton.Text = "Go";
            GoButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            GoButton.Click += GoButton_Click;
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = false;
            messageLabel.BackColor = Color.Transparent;
            messageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            messageLabel.Location = new Point(119, 308);
            messageLabel.Name = "messageLabel";
            messageLabel.Padding = new Padding(2);
            messageLabel.Size = new Size(307, 48);
            messageLabel.TabIndex = 3;
            messageLabel.Text = null;
            messageLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // PassByRefApp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 463);
            Controls.Add(messageLabel);
            Controls.Add(ClearBtn);
            Controls.Add(GoButton);
            Controls.Add(outputListBox);
            Controls.Add(headerPanel);
            Name = "PassByRefApp";
            Text = "PassByRefApp";
            Load += PassByRefApp_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel titleLabel;
        private ListBox outputListBox;
        private Guna.UI2.WinForms.Guna2Button ClearBtn;
        private Guna.UI2.WinForms.Guna2Button GoButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel messageLabel;
    }
}