namespace Wholeproject
{
    partial class CoinandToss
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            headsPictureBox = new PictureBox();
            tailsPictureBox = new PictureBox();
            ClearButton = new Guna.UI2.WinForms.Guna2Button();
            TossButton = new Guna.UI2.WinForms.Guna2Button();
            titleLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)headsPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tailsPictureBox).BeginInit();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headsPictureBox
            // 
            headsPictureBox.Image = AllC_Tasks.Properties.Resources.tail_1;
            headsPictureBox.Location = new Point(144, 114);
            headsPictureBox.Name = "headsPictureBox";
            headsPictureBox.Size = new Size(165, 166);
            headsPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            headsPictureBox.TabIndex = 17;
            headsPictureBox.TabStop = false;
            headsPictureBox.Visible = false;
            // 
            // tailsPictureBox
            // 
            tailsPictureBox.Image = AllC_Tasks.Properties.Resources.head_1;
            tailsPictureBox.Location = new Point(144, 114);
            tailsPictureBox.Name = "tailsPictureBox";
            tailsPictureBox.Size = new Size(165, 166);
            tailsPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            tailsPictureBox.TabIndex = 18;
            tailsPictureBox.TabStop = false;
            tailsPictureBox.Visible = false;
            // 
            // ClearButton
            // 
            ClearButton.BorderColor = Color.Transparent;
            ClearButton.BorderRadius = 8;
            ClearButton.CustomBorderColor = Color.Transparent;
            ClearButton.CustomizableEdges = customizableEdges7;
            ClearButton.DisabledState.BorderColor = Color.DarkGray;
            ClearButton.DisabledState.CustomBorderColor = Color.DarkGray;
            ClearButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ClearButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ClearButton.FillColor = Color.FromArgb(100, 181, 246);
            ClearButton.FocusedColor = Color.Transparent;
            ClearButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearButton.ForeColor = Color.White;
            ClearButton.Location = new Point(234, 406);
            ClearButton.Name = "ClearButton";
            ClearButton.ShadowDecoration.CustomizableEdges = customizableEdges8;
            ClearButton.Size = new Size(156, 58);
            ClearButton.TabIndex = 20;
            ClearButton.Text = "Clear";
            ClearButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // TossButton
            // 
            TossButton.BorderColor = Color.Transparent;
            TossButton.BorderRadius = 8;
            TossButton.CustomBorderColor = Color.Transparent;
            TossButton.CustomizableEdges = customizableEdges9;
            TossButton.DisabledState.BorderColor = Color.DarkGray;
            TossButton.DisabledState.CustomBorderColor = Color.DarkGray;
            TossButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            TossButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            TossButton.FillColor = SystemColors.Highlight;
            TossButton.FocusedColor = Color.Transparent;
            TossButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TossButton.ForeColor = Color.White;
            TossButton.Location = new Point(51, 406);
            TossButton.Name = "TossButton";
            TossButton.ShadowDecoration.CustomizableEdges = customizableEdges10;
            TossButton.Size = new Size(159, 58);
            TossButton.TabIndex = 19;
            TossButton.Text = "Toss";
            TossButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            TossButton.Click += TossButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.Black;
            titleLabel.Location = new Point(99, 12);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(249, 40);
            titleLabel.TabIndex = 6;
            titleLabel.Text = "Coin Toss Program";
            titleLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(titleLabel);
            headerPanel.CustomizableEdges = customizableEdges11;
            headerPanel.Location = new Point(-1, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.ShadowDecoration.CustomizableEdges = customizableEdges12;
            headerPanel.Size = new Size(464, 72);
            headerPanel.TabIndex = 21;
            // 
            // CoinandToss
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(462, 479);
            Controls.Add(headerPanel);
            Controls.Add(ClearButton);
            Controls.Add(TossButton);
            Controls.Add(tailsPictureBox);
            Controls.Add(headsPictureBox);
            ForeColor = Color.White;
            Name = "CoinandToss";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CoinandToss";
            Load += CoinandToss_Load;
            ((System.ComponentModel.ISupportInitialize)headsPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)tailsPictureBox).EndInit();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox headsPictureBox;
        private PictureBox tailsPictureBox;
        private Guna.UI2.WinForms.Guna2Button ClearButton;
        private Guna.UI2.WinForms.Guna2Button TossButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel titleLabel;
        private Guna.UI2.WinForms.Guna2Panel headerPanel;
    }
}