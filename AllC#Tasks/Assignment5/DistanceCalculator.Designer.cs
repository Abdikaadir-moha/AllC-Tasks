namespace AllC_Tasks.Assignment5
{
    partial class DistanceCalculator
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
            resultListBox = new ListBox();
            speedLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            hoursLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            speedTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            CalculateButton = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            titleLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            hoursTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // resultListBox
            // 
            resultListBox.BackColor = Color.White;
            resultListBox.BorderStyle = BorderStyle.FixedSingle;
            resultListBox.FormattingEnabled = true;
            resultListBox.ItemHeight = 28;
            resultListBox.Location = new Point(100, 254);
            resultListBox.Name = "resultListBox";
            resultListBox.Size = new Size(554, 282);
            resultListBox.TabIndex = 3;
            // 
            // speedLabel
            // 
            speedLabel.BackColor = Color.Transparent;
            speedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            speedLabel.ForeColor = Color.FromArgb(44, 44, 44);
            speedLabel.Location = new Point(112, 108);
            speedLabel.Name = "speedLabel";
            speedLabel.Size = new Size(195, 27);
            speedLabel.TabIndex = 5;
            speedLabel.Text = "Vehicle Speed in MPH:";
            // 
            // hoursLabel
            // 
            hoursLabel.BackColor = Color.Transparent;
            hoursLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hoursLabel.Location = new Point(171, 188);
            hoursLabel.Name = "hoursLabel";
            hoursLabel.Size = new Size(138, 27);
            hoursLabel.TabIndex = 6;
            hoursLabel.Text = "Hours Traveled:";
            // 
            // speedTextBox
            // 
            speedTextBox.BorderRadius = 8;
            speedTextBox.CustomizableEdges = customizableEdges1;
            speedTextBox.DefaultText = "";
            speedTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            speedTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            speedTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            speedTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            speedTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            speedTextBox.Font = new Font("Segoe UI", 9F);
            speedTextBox.ForeColor = Color.Black;
            speedTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            speedTextBox.Location = new Point(321, 101);
            speedTextBox.Margin = new Padding(4, 5, 4, 5);
            speedTextBox.Name = "speedTextBox";
            speedTextBox.PlaceholderForeColor = Color.Gray;
            speedTextBox.PlaceholderText = "Enter value…";
            speedTextBox.SelectedText = "";
            speedTextBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            speedTextBox.Size = new Size(155, 38);
            speedTextBox.TabIndex = 0;
            // 
            // CalculateButton
            // 
            CalculateButton.BorderColor = Color.Transparent;
            CalculateButton.BorderRadius = 8;
            CalculateButton.CustomBorderColor = Color.Transparent;
            CalculateButton.CustomizableEdges = customizableEdges3;
            CalculateButton.DisabledState.BorderColor = Color.DarkGray;
            CalculateButton.DisabledState.CustomBorderColor = Color.DarkGray;
            CalculateButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            CalculateButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            CalculateButton.FillColor = SystemColors.Highlight;
            CalculateButton.FocusedColor = Color.Transparent;
            CalculateButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CalculateButton.ForeColor = Color.White;
            CalculateButton.Location = new Point(321, 596);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            CalculateButton.Size = new Size(161, 59);
            CalculateButton.TabIndex = 2;
            CalculateButton.Text = "Calculate";
            CalculateButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(titleLabel);
            guna2Panel1.CustomizableEdges = customizableEdges5;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.FillColor = SystemColors.Highlight;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel1.Size = new Size(793, 60);
            guna2Panel1.TabIndex = 7;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = false;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(793, 60);
            titleLabel.TabIndex = 10;
            titleLabel.Text = "Distance Calculator\r\n";
            titleLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // hoursTextBox
            // 
            hoursTextBox.BorderRadius = 8;
            hoursTextBox.CustomizableEdges = customizableEdges7;
            hoursTextBox.DefaultText = "";
            hoursTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            hoursTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            hoursTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            hoursTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            hoursTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            hoursTextBox.Font = new Font("Segoe UI", 9F);
            hoursTextBox.ForeColor = Color.Black;
            hoursTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            hoursTextBox.Location = new Point(321, 186);
            hoursTextBox.Margin = new Padding(4, 5, 4, 5);
            hoursTextBox.Name = "hoursTextBox";
            hoursTextBox.PlaceholderForeColor = Color.Gray;
            hoursTextBox.PlaceholderText = "Enter value…";
            hoursTextBox.SelectedText = "";
            hoursTextBox.ShadowDecoration.CustomizableEdges = customizableEdges8;
            hoursTextBox.Size = new Size(155, 38);
            hoursTextBox.TabIndex = 1;
            // 
            // DistanceCalculator
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(793, 691);
            Controls.Add(hoursTextBox);
            Controls.Add(guna2Panel1);
            Controls.Add(CalculateButton);
            Controls.Add(speedTextBox);
            Controls.Add(hoursLabel);
            Controls.Add(speedLabel);
            Controls.Add(resultListBox);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "DistanceCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Distance Calculator";
            Load += DistanceCalculator_Load;
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox resultListBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel speedLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel hoursLabel;
        private Guna.UI2.WinForms.Guna2TextBox speedTextBox;
        private Guna.UI2.WinForms.Guna2Button CalculateButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel titleLabel;
        private Guna.UI2.WinForms.Guna2TextBox hoursTextBox;
    }
}