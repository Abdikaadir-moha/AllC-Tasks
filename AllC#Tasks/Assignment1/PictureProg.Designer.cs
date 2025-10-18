namespace Assignments1
{
    partial class PictureProg
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
            PictureBox = new PictureBox();
            Labeldate = new Label();
            HeaderTitle = new Label();
            label1 = new Label();
            Header = new Label();
            label3 = new Label();
            BackToMenu = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            SuspendLayout();
            // 
            // PictureBox
            // 
            PictureBox.BackColor = SystemColors.ActiveCaption;
            PictureBox.Image = AllC_Tasks.Properties.Resources.lion;
            PictureBox.Location = new Point(493, 172);
            PictureBox.Margin = new Padding(3, 4, 3, 4);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(299, 300);
            PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            PictureBox.Click += PictureBox_Click;
            // 
            // Labeldate
            // 
            Labeldate.BackColor = Color.Transparent;
            Labeldate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Labeldate.ForeColor = Color.White;
            Labeldate.Location = new Point(1051, 9);
            Labeldate.Name = "Labeldate";
            Labeldate.RightToLeft = RightToLeft.No;
            Labeldate.Size = new Size(256, 36);
            Labeldate.TabIndex = 25;
            Labeldate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HeaderTitle
            // 
            HeaderTitle.BackColor = Color.Transparent;
            HeaderTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeaderTitle.ForeColor = Color.White;
            HeaderTitle.Location = new Point(459, -4);
            HeaderTitle.Name = "HeaderTitle";
            HeaderTitle.Size = new Size(357, 60);
            HeaderTitle.TabIndex = 24;
            HeaderTitle.Text = "Picture Box Program";
            HeaderTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 5);
            label1.Name = "label1";
            label1.Size = new Size(173, 44);
            label1.TabIndex = 23;
            label1.Text = "JU FOCOSIT";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Header
            // 
            Header.BackColor = Color.White;
            Header.Location = new Point(-1, -4);
            Header.Name = "Header";
            Header.Size = new Size(1323, 60);
            Header.TabIndex = 22;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(355, 666);
            label3.Name = "label3";
            label3.Size = new Size(581, 30);
            label3.TabIndex = 27;
            label3.Text = "@ 2025 abdikadir mohamed";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackToMenu
            // 
            BackToMenu.BackColor = Color.MediumBlue;
            BackToMenu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackToMenu.ForeColor = Color.Transparent;
            BackToMenu.Location = new Point(550, 578);
            BackToMenu.Margin = new Padding(3, 4, 3, 4);
            BackToMenu.Name = "BackToMenu";
            BackToMenu.Size = new Size(189, 53);
            BackToMenu.TabIndex = 1;
            BackToMenu.Text = "Back To Main ";
            BackToMenu.UseVisualStyleBackColor = false;
            BackToMenu.Click += BackToMenu_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(475, 124);
            label2.Name = "label2";
            label2.Size = new Size(341, 29);
            label2.TabIndex = 0;
            label2.Text = "Click the image to see the name:";
            // 
            // PictureProg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1321, 695);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(BackToMenu);
            Controls.Add(Labeldate);
            Controls.Add(HeaderTitle);
            Controls.Add(label1);
            Controls.Add(Header);
            Controls.Add(PictureBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PictureProg";
            StartPosition = FormStartPosition.CenterScreen;
            Load += PictureProg_Load;
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PictureBox;
        private Label Labeldate;
        private Label HeaderTitle;
        private Label label1;
        private Label Header;
        private Label label3;
        private Button BackToMenu;
        private Label label2;
    }
}