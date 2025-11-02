namespace AllC_Tasks.Assignment5
{
    partial class Calculating_the_Factorialr
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
            headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            titleLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            descriptionLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ClearBtn = new Guna.UI2.WinForms.Guna2Button();
            CalculateButton = new Guna.UI2.WinForms.Guna2Button();
            numberTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            speedLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            messageLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            stepsListBox = new ListBox();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(titleLabel);
            headerPanel.CustomizableEdges = customizableEdges1;
            headerPanel.Location = new Point(0, -1);
            headerPanel.Name = "headerPanel";
            headerPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            headerPanel.Size = new Size(681, 72);
            headerPanel.TabIndex = 3;
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.Black;
            titleLabel.Location = new Point(219, 13);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(256, 40);
            titleLabel.TabIndex = 6;
            titleLabel.Text = "Factorial Calculator";
            titleLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = false;
            descriptionLabel.BackColor = Color.Transparent;
            descriptionLabel.BorderStyle = BorderStyle.Fixed3D;
            descriptionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptionLabel.Location = new Point(88, 87);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Padding = new Padding(2);
            descriptionLabel.Size = new Size(451, 75);
            descriptionLabel.TabIndex = 20;
            descriptionLabel.Text = "Enter a nonnegative integer to calculate its factorial.";
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
            ClearBtn.Location = new Point(345, 698);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ClearBtn.Size = new Size(156, 58);
            ClearBtn.TabIndex = 2;
            ClearBtn.Text = "Clear";
            ClearBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            ClearBtn.Click += ClearBtn_Click;
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
            CalculateButton.Location = new Point(162, 698);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            CalculateButton.Size = new Size(143, 58);
            CalculateButton.TabIndex = 1;
            CalculateButton.Text = "Calculate";
            CalculateButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // numberTextBox
            // 
            numberTextBox.BorderRadius = 8;
            numberTextBox.CustomizableEdges = customizableEdges7;
            numberTextBox.DefaultText = "";
            numberTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            numberTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            numberTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            numberTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            numberTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            numberTextBox.Font = new Font("Segoe UI", 9F);
            numberTextBox.ForeColor = Color.Black;
            numberTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            numberTextBox.Location = new Point(289, 213);
            numberTextBox.Margin = new Padding(4, 5, 4, 5);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.PlaceholderForeColor = Color.Gray;
            numberTextBox.PlaceholderText = "Enter value…";
            numberTextBox.SelectedText = "";
            numberTextBox.ShadowDecoration.CustomizableEdges = customizableEdges8;
            numberTextBox.Size = new Size(155, 38);
            numberTextBox.TabIndex = 0;
            // 
            // speedLabel
            // 
            speedLabel.BackColor = Color.Transparent;
            speedLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            speedLabel.ForeColor = Color.FromArgb(44, 44, 44);
            speedLabel.Location = new Point(105, 215);
            speedLabel.Name = "speedLabel";
            speedLabel.Size = new Size(173, 32);
            speedLabel.TabIndex = 24;
            speedLabel.Text = "Enter a Number:";
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = false;
            messageLabel.BackColor = Color.Transparent;
            messageLabel.BorderStyle = BorderStyle.Fixed3D;
            messageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            messageLabel.Location = new Point(377, 407);
            messageLabel.Name = "messageLabel";
            messageLabel.Padding = new Padding(2);
            messageLabel.Size = new Size(227, 56);
            messageLabel.TabIndex = 5;
            messageLabel.Text = "—";
            messageLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.ForeColor = Color.FromArgb(44, 44, 44);
            guna2HtmlLabel2.Location = new Point(445, 357);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(74, 34);
            guna2HtmlLabel2.TabIndex = 27;
            guna2HtmlLabel2.Text = "Result";
            // 
            // stepsListBox
            // 
            stepsListBox.BackColor = Color.White;
            stepsListBox.BorderStyle = BorderStyle.FixedSingle;
            stepsListBox.FormattingEnabled = true;
            stepsListBox.ItemHeight = 25;
            stepsListBox.Items.AddRange(new object[] { "—" });
            stepsListBox.Location = new Point(45, 295);
            stepsListBox.Name = "stepsListBox";
            stepsListBox.Size = new Size(260, 327);
            stepsListBox.TabIndex = 4;
            // 
            // Calculating_the_Factorialr
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 768);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(messageLabel);
            Controls.Add(stepsListBox);
            Controls.Add(numberTextBox);
            Controls.Add(speedLabel);
            Controls.Add(ClearBtn);
            Controls.Add(CalculateButton);
            Controls.Add(descriptionLabel);
            Controls.Add(headerPanel);
            Name = "Calculating_the_Factorialr";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculating_the_Factorialr";
            Load += Calculating_the_Factorialr_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel titleLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel descriptionLabel;
        private Guna.UI2.WinForms.Guna2Button ClearBtn;
        private Guna.UI2.WinForms.Guna2Button CalculateButton;
        private Guna.UI2.WinForms.Guna2TextBox numberTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel speedLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel messageLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private ListBox stepsListBox;
    }
}