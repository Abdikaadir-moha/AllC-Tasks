namespace assignment2
{
    partial class HeadAndTail
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
            HeaderTitle = new Label();
            Labeldate = new Label();
            label1 = new Label();
            Header = new Label();
            label3 = new Label();
            BackToMenu = new Button();
            ShowTailBtn = new Button();
            ShowHeadBtn = new Button();
            HeadpictureBox = new PictureBox();
            TailpictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)HeadpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TailpictureBox).BeginInit();
            SuspendLayout();
            // 
            // HeaderTitle
            // 
            HeaderTitle.BackColor = Color.Transparent;
            HeaderTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeaderTitle.ForeColor = Color.White;
            HeaderTitle.Location = new Point(444, -4);
            HeaderTitle.Name = "HeaderTitle";
            HeaderTitle.Size = new Size(356, 60);
            HeaderTitle.TabIndex = 30;
            HeaderTitle.Text = "Show H/T Program";
            HeaderTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Labeldate
            // 
            Labeldate.BackColor = Color.Transparent;
            Labeldate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Labeldate.ForeColor = Color.White;
            Labeldate.Location = new Point(1052, 8);
            Labeldate.Name = "Labeldate";
            Labeldate.RightToLeft = RightToLeft.No;
            Labeldate.Size = new Size(256, 36);
            Labeldate.TabIndex = 29;
            Labeldate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 5);
            label1.Name = "label1";
            label1.Size = new Size(173, 44);
            label1.TabIndex = 28;
            label1.Text = "JU FOCOSIT";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Header
            // 
            Header.BackColor = Color.White;
            Header.Location = new Point(0, -4);
            Header.Name = "Header";
            Header.Size = new Size(1323, 60);
            Header.TabIndex = 27;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(345, 781);
            label3.Name = "label3";
            label3.Size = new Size(580, 30);
            label3.TabIndex = 33;
            label3.Text = "@ 2025 abdikadir mohamed";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackToMenu
            // 
            BackToMenu.BackColor = Color.MediumBlue;
            BackToMenu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackToMenu.ForeColor = Color.Transparent;
            BackToMenu.Location = new Point(540, 696);
            BackToMenu.Name = "BackToMenu";
            BackToMenu.Size = new Size(189, 53);
            BackToMenu.TabIndex = 32;
            BackToMenu.Text = "Back To Main ";
            BackToMenu.UseVisualStyleBackColor = false;
            BackToMenu.Visible = false;
            BackToMenu.Click += BackToMenu_Click;
            // 
            // ShowTailBtn
            // 
            ShowTailBtn.BackColor = Color.YellowGreen;
            ShowTailBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowTailBtn.ForeColor = Color.Transparent;
            ShowTailBtn.Location = new Point(687, 538);
            ShowTailBtn.Name = "ShowTailBtn";
            ShowTailBtn.Size = new Size(200, 53);
            ShowTailBtn.TabIndex = 36;
            ShowTailBtn.Text = "Show Tail";
            ShowTailBtn.UseVisualStyleBackColor = false;
            ShowTailBtn.Click += ShowTailBtn_Click;
            // 
            // ShowHeadBtn
            // 
            ShowHeadBtn.BackColor = Color.Peru;
            ShowHeadBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowHeadBtn.ForeColor = Color.Transparent;
            ShowHeadBtn.Location = new Point(353, 538);
            ShowHeadBtn.Name = "ShowHeadBtn";
            ShowHeadBtn.Size = new Size(200, 53);
            ShowHeadBtn.TabIndex = 35;
            ShowHeadBtn.Text = "Show Head";
            ShowHeadBtn.UseVisualStyleBackColor = false;
            ShowHeadBtn.Click += ShowHeadBtn_Click;
            // 
            // HeadpictureBox
            // 
            HeadpictureBox.Image = AllC_Tasks.Properties.Resources.head_1;
            HeadpictureBox.Location = new Point(154, 125);
            HeadpictureBox.Name = "HeadpictureBox";
            HeadpictureBox.Size = new Size(304, 310);
            HeadpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            HeadpictureBox.TabIndex = 37;
            HeadpictureBox.TabStop = false;
            HeadpictureBox.Visible = false;
            // 
            // TailpictureBox
            // 
            TailpictureBox.Image = AllC_Tasks.Properties.Resources.tail_1;
            TailpictureBox.Location = new Point(773, 125);
            TailpictureBox.Name = "TailpictureBox";
            TailpictureBox.Size = new Size(304, 310);
            TailpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            TailpictureBox.TabIndex = 38;
            TailpictureBox.TabStop = false;
            TailpictureBox.Visible = false;
            // 
            // HeadAndTail
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1323, 810);
            Controls.Add(TailpictureBox);
            Controls.Add(HeadpictureBox);
            Controls.Add(ShowTailBtn);
            Controls.Add(ShowHeadBtn);
            Controls.Add(label3);
            Controls.Add(BackToMenu);
            Controls.Add(HeaderTitle);
            Controls.Add(Labeldate);
            Controls.Add(label1);
            Controls.Add(Header);
            Font = new Font("Roboto Condensed", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "HeadAndTail";
            Text = "HeadAndTail";
            Load += HeadAndTail_Load;
            ((System.ComponentModel.ISupportInitialize)HeadpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)TailpictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label HeaderTitle;
        private Label Labeldate;
        private Label label1;
        private Label Header;
        private Label label3;
        private Button BackToMenu;
        private Button ShowTailBtn;
        private Button ShowHeadBtn;
        private PictureBox HeadpictureBox;
        private PictureBox TailpictureBox;
    }
}