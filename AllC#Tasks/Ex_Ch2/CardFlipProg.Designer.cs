namespace assignment2
{
    partial class CardFlipProg
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
            Labeldate = new Label();
            label1 = new Label();
            Header = new Label();
            HeaderTitle = new Label();
            CardFacePictureBox = new PictureBox();
            CardBackPictureBox = new PictureBox();
            label3 = new Label();
            BackToMenu = new Button();
            ShowBackButton = new Button();
            ShowFaceButton = new Button();
            ((System.ComponentModel.ISupportInitialize)CardFacePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CardBackPictureBox).BeginInit();
            SuspendLayout();
            // 
            // Labeldate
            // 
            Labeldate.BackColor = Color.Transparent;
            Labeldate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Labeldate.ForeColor = Color.White;
            Labeldate.Location = new Point(1049, 10);
            Labeldate.Name = "Labeldate";
            Labeldate.RightToLeft = RightToLeft.No;
            Labeldate.Size = new Size(256, 36);
            Labeldate.TabIndex = 25;
            Labeldate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 7);
            label1.Name = "label1";
            label1.Size = new Size(173, 44);
            label1.TabIndex = 23;
            label1.Text = "JU FOCOSIT";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Header
            // 
            Header.BackColor = Color.White;
            Header.Location = new Point(-3, -2);
            Header.Name = "Header";
            Header.Size = new Size(1323, 60);
            Header.TabIndex = 22;
            // 
            // HeaderTitle
            // 
            HeaderTitle.BackColor = Color.Transparent;
            HeaderTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeaderTitle.ForeColor = Color.White;
            HeaderTitle.Location = new Point(441, -2);
            HeaderTitle.Name = "HeaderTitle";
            HeaderTitle.Size = new Size(356, 60);
            HeaderTitle.TabIndex = 26;
            HeaderTitle.Text = "Card Flip Program";
            HeaderTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CardFacePictureBox
            // 
            CardFacePictureBox.Image = AllC_Tasks.Properties.Resources.Screenshot_2025_10_07_011546;
            CardFacePictureBox.Location = new Point(761, 128);
            CardFacePictureBox.Name = "CardFacePictureBox";
            CardFacePictureBox.Size = new Size(300, 428);
            CardFacePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            CardFacePictureBox.TabIndex = 27;
            CardFacePictureBox.TabStop = false;
            CardFacePictureBox.Visible = false;
            // 
            // CardBackPictureBox
            // 
            CardBackPictureBox.Image = AllC_Tasks.Properties.Resources.Screenshot_2025_10_07_011558;
            CardBackPictureBox.Location = new Point(201, 128);
            CardBackPictureBox.Name = "CardBackPictureBox";
            CardBackPictureBox.Size = new Size(300, 428);
            CardBackPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            CardBackPictureBox.TabIndex = 28;
            CardBackPictureBox.TabStop = false;
            CardBackPictureBox.Visible = false;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(365, 844);
            label3.Name = "label3";
            label3.Size = new Size(580, 30);
            label3.TabIndex = 30;
            label3.Text = "@ 2025 abdikadir mohamed";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackToMenu
            // 
            BackToMenu.BackColor = Color.MediumBlue;
            BackToMenu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackToMenu.ForeColor = Color.Transparent;
            BackToMenu.Location = new Point(565, 765);
            BackToMenu.Name = "BackToMenu";
            BackToMenu.Size = new Size(189, 53);
            BackToMenu.TabIndex = 29;
            BackToMenu.Text = "Back To Main ";
            BackToMenu.UseVisualStyleBackColor = false;
            BackToMenu.Visible = false;
            BackToMenu.Click += BackToMenu_Click;
            // 
            // ShowBackButton
            // 
            ShowBackButton.BackColor = Color.Peru;
            ShowBackButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowBackButton.ForeColor = Color.Transparent;
            ShowBackButton.Location = new Point(388, 637);
            ShowBackButton.Name = "ShowBackButton";
            ShowBackButton.Size = new Size(200, 53);
            ShowBackButton.TabIndex = 32;
            ShowBackButton.Text = " Show the Card Back";
            ShowBackButton.UseVisualStyleBackColor = false;
            ShowBackButton.Click += ShowBackButton_Click;
            // 
            // ShowFaceButton
            // 
            ShowFaceButton.BackColor = Color.YellowGreen;
            ShowFaceButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowFaceButton.ForeColor = Color.Transparent;
            ShowFaceButton.Location = new Point(722, 637);
            ShowFaceButton.Name = "ShowFaceButton";
            ShowFaceButton.Size = new Size(200, 53);
            ShowFaceButton.TabIndex = 33;
            ShowFaceButton.Text = " Show the Card Face";
            ShowFaceButton.UseVisualStyleBackColor = false;
            ShowFaceButton.Click += ShowFaceButton_Click;
            // 
            // CardFlipProg
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1316, 875);
            Controls.Add(ShowFaceButton);
            Controls.Add(ShowBackButton);
            Controls.Add(label3);
            Controls.Add(BackToMenu);
            Controls.Add(CardBackPictureBox);
            Controls.Add(CardFacePictureBox);
            Controls.Add(HeaderTitle);
            Controls.Add(Labeldate);
            Controls.Add(label1);
            Controls.Add(Header);
            Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CardFlipProg";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CardFlipProg";
            Load += CardFlipProg_Load;
            ((System.ComponentModel.ISupportInitialize)CardFacePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)CardBackPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label Labeldate;
        private Label label1;
        private Label Header;
        private Label HeaderTitle;
        private PictureBox CardFacePictureBox;
        private PictureBox CardBackPictureBox;
        private Label label3;
        private Button BackToMenu;
        private Button ShowBackButton;
        private Button ShowFaceButton;
    }
}