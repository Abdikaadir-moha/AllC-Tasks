namespace AllC_Tasks.Assignment5
{
    partial class Distance_File
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
            hoursTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            CalculateButton = new Guna.UI2.WinForms.Guna2Button();
            speedTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            hoursLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            speedLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
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
            headerPanel.Size = new Size(677, 64);
            headerPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.Black;
            titleLabel.Location = new Point(173, 11);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(309, 40);
            titleLabel.TabIndex = 6;
            titleLabel.Text = "Distance File Calculator";
            titleLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // hoursTextBox
            // 
            hoursTextBox.BorderRadius = 8;
            hoursTextBox.CustomizableEdges = customizableEdges3;
            hoursTextBox.DefaultText = "";
            hoursTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            hoursTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            hoursTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            hoursTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            hoursTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            hoursTextBox.Font = new Font("Segoe UI", 9F);
            hoursTextBox.ForeColor = Color.Black;
            hoursTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            hoursTextBox.Location = new Point(327, 189);
            hoursTextBox.Margin = new Padding(4, 5, 4, 5);
            hoursTextBox.Name = "hoursTextBox";
            hoursTextBox.PlaceholderForeColor = Color.Gray;
            hoursTextBox.PlaceholderText = "Enter value…";
            hoursTextBox.SelectedText = "";
            hoursTextBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            hoursTextBox.Size = new Size(155, 38);
            hoursTextBox.TabIndex = 8;
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
            CalculateButton.Location = new Point(237, 313);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            CalculateButton.Size = new Size(224, 58);
            CalculateButton.TabIndex = 9;
            CalculateButton.Text = "Calculate And Save";
            CalculateButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // speedTextBox
            // 
            speedTextBox.BorderRadius = 8;
            speedTextBox.CustomizableEdges = customizableEdges7;
            speedTextBox.DefaultText = "";
            speedTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            speedTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            speedTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            speedTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            speedTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            speedTextBox.Font = new Font("Segoe UI", 9F);
            speedTextBox.ForeColor = Color.Black;
            speedTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            speedTextBox.Location = new Point(327, 104);
            speedTextBox.Margin = new Padding(4, 5, 4, 5);
            speedTextBox.Name = "speedTextBox";
            speedTextBox.PlaceholderForeColor = Color.Gray;
            speedTextBox.PlaceholderText = "Enter value…";
            speedTextBox.SelectedText = "";
            speedTextBox.ShadowDecoration.CustomizableEdges = customizableEdges8;
            speedTextBox.Size = new Size(155, 38);
            speedTextBox.TabIndex = 7;
            // 
            // hoursLabel
            // 
            hoursLabel.BackColor = Color.Transparent;
            hoursLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hoursLabel.Location = new Point(177, 191);
            hoursLabel.Name = "hoursLabel";
            hoursLabel.Size = new Size(138, 27);
            hoursLabel.TabIndex = 12;
            hoursLabel.Text = "Hours Traveled:";
            // 
            // speedLabel
            // 
            speedLabel.BackColor = Color.Transparent;
            speedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            speedLabel.ForeColor = Color.FromArgb(44, 44, 44);
            speedLabel.Location = new Point(118, 111);
            speedLabel.Name = "speedLabel";
            speedLabel.Size = new Size(195, 27);
            speedLabel.TabIndex = 11;
            speedLabel.Text = "Vehicle Speed in MPH:";
            // 
            // Distance_File
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 414);
            Controls.Add(hoursTextBox);
            Controls.Add(CalculateButton);
            Controls.Add(speedTextBox);
            Controls.Add(hoursLabel);
            Controls.Add(speedLabel);
            Controls.Add(headerPanel);
            Name = "Distance_File";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Distance_File";
            Load += Distance_File_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel titleLabel;
        private Guna.UI2.WinForms.Guna2TextBox hoursTextBox;
        private Guna.UI2.WinForms.Guna2Button CalculateButton;
        private Guna.UI2.WinForms.Guna2TextBox speedTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel hoursLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel speedLabel;
    }
}