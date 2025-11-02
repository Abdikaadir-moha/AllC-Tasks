namespace AllC_Tasks.Ex_Ch6
{
    partial class Calling_Method_Tutorial_6_1
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
            lightOnPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            lightOffPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            lightStateLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SwitchButton = new Guna.UI2.WinForms.Guna2Button();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lightOnPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lightOffPictureBox).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(titleLabel);
            headerPanel.CustomizableEdges = customizableEdges1;
            headerPanel.Location = new Point(1, 1);
            headerPanel.Name = "headerPanel";
            headerPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            headerPanel.Size = new Size(645, 72);
            headerPanel.TabIndex = 4;
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.Black;
            titleLabel.Location = new Point(152, 11);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(324, 40);
            titleLabel.TabIndex = 6;
            titleLabel.Text = "Creating Calling Method";
            titleLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lightOnPictureBox
            // 
            lightOnPictureBox.CustomizableEdges = customizableEdges3;
            lightOnPictureBox.Image = Properties.Resources.on;
            lightOnPictureBox.ImageRotate = 0F;
            lightOnPictureBox.InitialImage = Properties.Resources.off;
            lightOnPictureBox.Location = new Point(135, 101);
            lightOnPictureBox.Name = "lightOnPictureBox";
            lightOnPictureBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            lightOnPictureBox.Size = new Size(364, 300);
            lightOnPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            lightOnPictureBox.TabIndex = 5;
            lightOnPictureBox.TabStop = false;
            // 
            // lightOffPictureBox
            // 
            lightOffPictureBox.CustomizableEdges = customizableEdges5;
            lightOffPictureBox.Image = Properties.Resources.off;
            lightOffPictureBox.ImageRotate = 0F;
            lightOffPictureBox.Location = new Point(135, 101);
            lightOffPictureBox.Name = "lightOffPictureBox";
            lightOffPictureBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            lightOffPictureBox.Size = new Size(364, 300);
            lightOffPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            lightOffPictureBox.TabIndex = 6;
            lightOffPictureBox.TabStop = false;
            // 
            // lightStateLabel
            // 
            lightStateLabel.AutoSize = false;
            lightStateLabel.BackColor = Color.Transparent;
            lightStateLabel.BorderStyle = BorderStyle.Fixed3D;
            lightStateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lightStateLabel.Location = new Point(194, 422);
            lightStateLabel.Name = "lightStateLabel";
            lightStateLabel.Padding = new Padding(2);
            lightStateLabel.Size = new Size(240, 74);
            lightStateLabel.TabIndex = 1;
            lightStateLabel.Text = "—";
            lightStateLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // SwitchButton
            // 
            SwitchButton.BorderColor = Color.Transparent;
            SwitchButton.BorderRadius = 8;
            SwitchButton.CustomBorderColor = Color.Transparent;
            SwitchButton.CustomizableEdges = customizableEdges7;
            SwitchButton.DisabledState.BorderColor = Color.DarkGray;
            SwitchButton.DisabledState.CustomBorderColor = Color.DarkGray;
            SwitchButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SwitchButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SwitchButton.FillColor = SystemColors.Highlight;
            SwitchButton.FocusedColor = Color.Transparent;
            SwitchButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SwitchButton.ForeColor = Color.White;
            SwitchButton.Location = new Point(237, 529);
            SwitchButton.Name = "SwitchButton";
            SwitchButton.ShadowDecoration.CustomizableEdges = customizableEdges8;
            SwitchButton.Size = new Size(156, 64);
            SwitchButton.TabIndex = 0;
            SwitchButton.Text = "Switch Light";
            SwitchButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            SwitchButton.Click += SwitchButton_Click;
            // 
            // Calling_Method_Tutorial_6_1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 605);
            Controls.Add(SwitchButton);
            Controls.Add(lightStateLabel);
            Controls.Add(headerPanel);
            Controls.Add(lightOffPictureBox);
            Controls.Add(lightOnPictureBox);
            Name = "Calling_Method_Tutorial_6_1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calling_Method_Tutorial_6_1";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lightOnPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)lightOffPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel titleLabel;
        private Guna.UI2.WinForms.Guna2PictureBox lightOnPictureBox;
        private Guna.UI2.WinForms.Guna2PictureBox lightOffPictureBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel lightStateLabel;
        private Guna.UI2.WinForms.Guna2Button SwitchButton;
    }
}