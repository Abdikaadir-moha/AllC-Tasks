namespace AllC_Tasks.Assignment5
{
    partial class RandomNumberFileReader
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
            countLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ClearBtn = new Guna.UI2.WinForms.Guna2Button();
            OpenFileButton = new Guna.UI2.WinForms.Guna2Button();
            numbersListBox = new ListBox();
            descriptionLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            totalLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            messageLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            openFileDialog1 = new OpenFileDialog();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.Black;
            titleLabel.Location = new Point(140, 13);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(382, 40);
            titleLabel.TabIndex = 6;
            titleLabel.Text = "Random Number File Reader";
            titleLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(titleLabel);
            headerPanel.CustomizableEdges = customizableEdges1;
            headerPanel.Location = new Point(0, -1);
            headerPanel.Name = "headerPanel";
            headerPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            headerPanel.Size = new Size(681, 72);
            headerPanel.TabIndex = 4;
            // 
            // countLabel
            // 
            countLabel.AutoSize = false;
            countLabel.BackColor = Color.Transparent;
            countLabel.BorderStyle = BorderStyle.Fixed3D;
            countLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            countLabel.Location = new Point(381, 363);
            countLabel.Name = "countLabel";
            countLabel.Padding = new Padding(2);
            countLabel.Size = new Size(227, 56);
            countLabel.TabIndex = 6;
            countLabel.Text = "—";
            countLabel.TextAlignment = ContentAlignment.MiddleCenter;
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
            ClearBtn.Location = new Point(263, 770);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ClearBtn.Size = new Size(143, 58);
            ClearBtn.TabIndex = 1;
            ClearBtn.Text = "Clear";
            ClearBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // OpenFileButton
            // 
            OpenFileButton.BorderColor = Color.Transparent;
            OpenFileButton.BorderRadius = 8;
            OpenFileButton.CustomBorderColor = Color.Transparent;
            OpenFileButton.CustomizableEdges = customizableEdges5;
            OpenFileButton.DisabledState.BorderColor = Color.DarkGray;
            OpenFileButton.DisabledState.CustomBorderColor = Color.DarkGray;
            OpenFileButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            OpenFileButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            OpenFileButton.FillColor = SystemColors.Highlight;
            OpenFileButton.FocusedColor = Color.Transparent;
            OpenFileButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OpenFileButton.ForeColor = Color.White;
            OpenFileButton.Location = new Point(263, 213);
            OpenFileButton.Name = "OpenFileButton";
            OpenFileButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            OpenFileButton.Size = new Size(143, 58);
            OpenFileButton.TabIndex = 0;
            OpenFileButton.Text = "Open File";
            OpenFileButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            OpenFileButton.Click += OpenFileButton_Click;
            // 
            // numbersListBox
            // 
            numbersListBox.BackColor = Color.White;
            numbersListBox.BorderStyle = BorderStyle.FixedSingle;
            numbersListBox.FormattingEnabled = true;
            numbersListBox.ItemHeight = 25;
            numbersListBox.Items.AddRange(new object[] { "—" });
            numbersListBox.Location = new Point(27, 321);
            numbersListBox.Name = "numbersListBox";
            numbersListBox.Size = new Size(260, 277);
            numbersListBox.TabIndex = 9;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = false;
            descriptionLabel.BackColor = Color.Transparent;
            descriptionLabel.BorderStyle = BorderStyle.Fixed3D;
            descriptionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptionLabel.Location = new Point(99, 88);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Padding = new Padding(2);
            descriptionLabel.Size = new Size(451, 75);
            descriptionLabel.TabIndex = 21;
            descriptionLabel.Text = "Select a file to display its numbers, total, and count.";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.ForeColor = Color.FromArgb(44, 44, 44);
            guna2HtmlLabel2.Location = new Point(444, 310);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(79, 34);
            guna2HtmlLabel2.TabIndex = 28;
            guna2HtmlLabel2.Text = "Count:";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(44, 44, 44);
            guna2HtmlLabel1.Location = new Point(455, 454);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(68, 34);
            guna2HtmlLabel1.TabIndex = 30;
            guna2HtmlLabel1.Text = "Total:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = false;
            totalLabel.BackColor = Color.Transparent;
            totalLabel.BorderStyle = BorderStyle.Fixed3D;
            totalLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalLabel.Location = new Point(381, 508);
            totalLabel.Name = "totalLabel";
            totalLabel.Padding = new Padding(2);
            totalLabel.Size = new Size(227, 56);
            totalLabel.TabIndex = 29;
            totalLabel.Text = "—";
            totalLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = false;
            messageLabel.BackColor = Color.Transparent;
            messageLabel.BorderStyle = BorderStyle.Fixed3D;
            messageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            messageLabel.Location = new Point(99, 666);
            messageLabel.Name = "messageLabel";
            messageLabel.Padding = new Padding(2);
            messageLabel.Size = new Size(486, 74);
            messageLabel.TabIndex = 32;
            messageLabel.Text = "—";
            messageLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // RandomNumberFileReader
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 840);
            Controls.Add(messageLabel);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(totalLabel);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(descriptionLabel);
            Controls.Add(numbersListBox);
            Controls.Add(ClearBtn);
            Controls.Add(OpenFileButton);
            Controls.Add(countLabel);
            Controls.Add(headerPanel);
            Name = "RandomNumberFileReader";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RandomNumberFileReader";
            Load += RandomNumberFileReader_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel titleLabel;
        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel countLabel;
        private Guna.UI2.WinForms.Guna2Button ClearBtn;
        private Guna.UI2.WinForms.Guna2Button OpenFileButton;
        private ListBox numbersListBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel descriptionLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel totalLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel messageLabel;
        private OpenFileDialog openFileDialog1;
    }
}