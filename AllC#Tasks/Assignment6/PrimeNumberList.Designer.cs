namespace AllC_Tasks.Assignment6
{
    partial class PrimeNumberList
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
            titleLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            ClearButton = new Guna.UI2.WinForms.Guna2Button();
            ShowButton = new Guna.UI2.WinForms.Guna2Button();
            primeListBox = new ListBox();
            messageLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.Black;
            titleLabel.Location = new Point(142, 12);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(314, 40);
            titleLabel.TabIndex = 6;
            titleLabel.Text = "Prime Numbers (1–100)";
            titleLabel.TextAlignment = ContentAlignment.MiddleCenter;
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
            ClearButton.Location = new Point(234, 470);
            ClearButton.Name = "ClearButton";
            ClearButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ClearButton.Size = new Size(156, 58);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "Clear List";
            ClearButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            ClearButton.Click += ClearButton_Click;
            // 
            // ShowButton
            // 
            ShowButton.BorderColor = Color.Transparent;
            ShowButton.BorderRadius = 8;
            ShowButton.CustomBorderColor = Color.Transparent;
            ShowButton.CustomizableEdges = customizableEdges5;
            ShowButton.DisabledState.BorderColor = Color.DarkGray;
            ShowButton.DisabledState.CustomBorderColor = Color.DarkGray;
            ShowButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ShowButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ShowButton.FillColor = SystemColors.Highlight;
            ShowButton.FocusedColor = Color.Transparent;
            ShowButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowButton.ForeColor = Color.White;
            ShowButton.Location = new Point(214, 94);
            ShowButton.Name = "ShowButton";
            ShowButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            ShowButton.Size = new Size(158, 69);
            ShowButton.TabIndex = 0;
            ShowButton.Text = "Show Prime Numbers";
            ShowButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            ShowButton.Click += ShowButton_Click;
            // 
            // primeListBox
            // 
            primeListBox.BackColor = Color.White;
            primeListBox.BorderStyle = BorderStyle.FixedSingle;
            primeListBox.FormattingEnabled = true;
            primeListBox.ItemHeight = 25;
            primeListBox.Items.AddRange(new object[] { "—" });
            primeListBox.Location = new Point(24, 185);
            primeListBox.Name = "primeListBox";
            primeListBox.Size = new Size(260, 252);
            primeListBox.TabIndex = 46;
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = false;
            messageLabel.BackColor = Color.Transparent;
            messageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            messageLabel.Location = new Point(309, 274);
            messageLabel.Name = "messageLabel";
            messageLabel.Padding = new Padding(2);
            messageLabel.Size = new Size(285, 56);
            messageLabel.TabIndex = 47;
            messageLabel.Text = null;
            messageLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // PrimeNumberList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 540);
            Controls.Add(messageLabel);
            Controls.Add(primeListBox);
            Controls.Add(ClearButton);
            Controls.Add(ShowButton);
            Controls.Add(headerPanel);
            Name = "PrimeNumberList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrimeNumberList";
            Load += PrimeNumberList_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel titleLabel;
        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private Guna.UI2.WinForms.Guna2Button ClearButton;
        private Guna.UI2.WinForms.Guna2Button ShowButton;
        private ListBox primeListBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel messageLabel;
    }
}