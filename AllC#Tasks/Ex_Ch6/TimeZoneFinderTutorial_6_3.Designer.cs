namespace AllC_Tasks.Ex_Ch6
{
    partial class TimeZoneFinderTutorial_6_3
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
            descriptionLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            titleLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ClearBtn = new Guna.UI2.WinForms.Guna2Button();
            OkButton = new Guna.UI2.WinForms.Guna2Button();
            headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            countriesListBox = new ListBox();
            messageLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            openFileDialog1 = new OpenFileDialog();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = false;
            descriptionLabel.BackColor = Color.Transparent;
            descriptionLabel.BorderStyle = BorderStyle.Fixed3D;
            descriptionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptionLabel.Location = new Point(49, 89);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Padding = new Padding(5);
            descriptionLabel.Size = new Size(380, 48);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "The Countries Of North America ";
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.Black;
            titleLabel.Location = new Point(147, 11);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(233, 40);
            titleLabel.TabIndex = 6;
            titleLabel.Text = "Time Zone Finder";
            titleLabel.TextAlignment = ContentAlignment.MiddleCenter;
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
            ClearBtn.Location = new Point(285, 643);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ClearBtn.Size = new Size(156, 58);
            ClearBtn.TabIndex = 2;
            ClearBtn.Text = "Clear";
            ClearBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // OkButton
            // 
            OkButton.BorderColor = Color.Transparent;
            OkButton.BorderRadius = 8;
            OkButton.CustomBorderColor = Color.Transparent;
            OkButton.CustomizableEdges = customizableEdges3;
            OkButton.DisabledState.BorderColor = Color.DarkGray;
            OkButton.DisabledState.CustomBorderColor = Color.DarkGray;
            OkButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            OkButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            OkButton.FillColor = SystemColors.Highlight;
            OkButton.FocusedColor = Color.Transparent;
            OkButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OkButton.ForeColor = Color.White;
            OkButton.Location = new Point(102, 643);
            OkButton.Name = "OkButton";
            OkButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            OkButton.Size = new Size(164, 58);
            OkButton.TabIndex = 0;
            OkButton.Text = "Get Countries";
            OkButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            OkButton.Click += OkButton_Click;
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(titleLabel);
            headerPanel.CustomizableEdges = customizableEdges5;
            headerPanel.Location = new Point(-1, 1);
            headerPanel.Name = "headerPanel";
            headerPanel.ShadowDecoration.CustomizableEdges = customizableEdges6;
            headerPanel.Size = new Size(532, 72);
            headerPanel.TabIndex = 23;
            // 
            // countriesListBox
            // 
            countriesListBox.BackColor = Color.White;
            countriesListBox.BorderStyle = BorderStyle.FixedSingle;
            countriesListBox.FormattingEnabled = true;
            countriesListBox.ItemHeight = 25;
            countriesListBox.Items.AddRange(new object[] { "—" });
            countriesListBox.Location = new Point(119, 159);
            countriesListBox.Name = "countriesListBox";
            countriesListBox.Size = new Size(260, 327);
            countriesListBox.TabIndex = 1;
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = false;
            messageLabel.BackColor = Color.Transparent;
            messageLabel.BorderStyle = BorderStyle.Fixed3D;
            messageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            messageLabel.Location = new Point(49, 543);
            messageLabel.Name = "messageLabel";
            messageLabel.Padding = new Padding(2);
            messageLabel.Size = new Size(429, 73);
            messageLabel.TabIndex = 3;
            messageLabel.Text = "—";
            messageLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // TimeZoneFinderTutorial_6_3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 713);
            Controls.Add(descriptionLabel);
            Controls.Add(messageLabel);
            Controls.Add(countriesListBox);
            Controls.Add(ClearBtn);
            Controls.Add(OkButton);
            Controls.Add(headerPanel);
            Name = "TimeZoneFinderTutorial_6_3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "]";
            Load += TimeZoneFinderTutorial_6_3_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel descriptionLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel titleLabel;
        private Guna.UI2.WinForms.Guna2Button ClearBtn;
        private Guna.UI2.WinForms.Guna2Button OkButton;
        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private ListBox countriesListBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel messageLabel;
        private OpenFileDialog openFileDialog1;
    }
}