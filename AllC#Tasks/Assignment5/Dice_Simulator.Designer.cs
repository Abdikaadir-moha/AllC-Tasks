namespace AllC_Tasks.Assignment5
{
    partial class Dice_Simulator
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            titleLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            die1PictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            die2PictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            RollButton = new Guna.UI2.WinForms.Guna2Button();
            ClearBtn = new Guna.UI2.WinForms.Guna2Button();
            resultLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)die1PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)die2PictureBox).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.Black;
            titleLabel.Location = new Point(231, 12);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(197, 40);
            titleLabel.TabIndex = 6;
            titleLabel.Text = "Dice Simulator";
            titleLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(titleLabel);
            headerPanel.CustomizableEdges = customizableEdges1;
            headerPanel.Location = new Point(-1, 1);
            headerPanel.Name = "headerPanel";
            headerPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            headerPanel.Size = new Size(681, 72);
            headerPanel.TabIndex = 3;
            // 
            // die1PictureBox
            // 
            die1PictureBox.CustomizableEdges = customizableEdges3;
            die1PictureBox.ErrorImage = Properties.Resources.Die1;
            die1PictureBox.ImageRotate = 0F;
            die1PictureBox.Location = new Point(46, 135);
            die1PictureBox.Name = "die1PictureBox";
            die1PictureBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            die1PictureBox.Size = new Size(197, 191);
            die1PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            die1PictureBox.TabIndex = 4;
            die1PictureBox.TabStop = false;
            // 
            // die2PictureBox
            // 
            die2PictureBox.CustomizableEdges = customizableEdges5;
            die2PictureBox.ImageRotate = 0F;
            die2PictureBox.Location = new Point(383, 135);
            die2PictureBox.Name = "die2PictureBox";
            die2PictureBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            die2PictureBox.Size = new Size(197, 191);
            die2PictureBox.TabIndex = 5;
            die2PictureBox.TabStop = false;
            // 
            // RollButton
            // 
            RollButton.BorderColor = Color.Transparent;
            RollButton.BorderRadius = 8;
            RollButton.CustomBorderColor = Color.Transparent;
            RollButton.CustomizableEdges = customizableEdges7;
            RollButton.DisabledState.BorderColor = Color.DarkGray;
            RollButton.DisabledState.CustomBorderColor = Color.DarkGray;
            RollButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            RollButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            RollButton.FillColor = SystemColors.Highlight;
            RollButton.FocusedColor = Color.Transparent;
            RollButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RollButton.ForeColor = Color.White;
            RollButton.Location = new Point(126, 435);
            RollButton.Name = "RollButton";
            RollButton.ShadowDecoration.CustomizableEdges = customizableEdges8;
            RollButton.Size = new Size(143, 58);
            RollButton.TabIndex = 15;
            RollButton.Text = "Roll Dice";
            RollButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            RollButton.Click += RollButton_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.BorderColor = Color.Transparent;
            ClearBtn.BorderRadius = 8;
            ClearBtn.CustomBorderColor = Color.Transparent;
            ClearBtn.CustomizableEdges = customizableEdges9;
            ClearBtn.DisabledState.BorderColor = Color.DarkGray;
            ClearBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            ClearBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ClearBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ClearBtn.FillColor = Color.FromArgb(100, 181, 246);
            ClearBtn.FocusedColor = Color.Transparent;
            ClearBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearBtn.ForeColor = Color.White;
            ClearBtn.Location = new Point(353, 435);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.ShadowDecoration.CustomizableEdges = customizableEdges10;
            ClearBtn.Size = new Size(156, 58);
            ClearBtn.TabIndex = 19;
            ClearBtn.Text = "Clear";
            ClearBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // resultLabel
            // 
            resultLabel.BackColor = Color.Transparent;
            resultLabel.Location = new Point(230, 369);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(3, 2);
            resultLabel.TabIndex = 20;
            // 
            // Dice_Simulator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 524);
            Controls.Add(resultLabel);
            Controls.Add(ClearBtn);
            Controls.Add(RollButton);
            Controls.Add(die2PictureBox);
            Controls.Add(die1PictureBox);
            Controls.Add(headerPanel);
            Name = "Dice_Simulator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dice_Simulator";
            Load += Dice_Simulator_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)die1PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)die2PictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel titleLabel;
        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private Guna.UI2.WinForms.Guna2PictureBox die1PictureBox;
        private Guna.UI2.WinForms.Guna2PictureBox die2PictureBox;
        private Guna.UI2.WinForms.Guna2Button RollButton;
        private Guna.UI2.WinForms.Guna2Button ClearBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel resultLabel;
    }
}