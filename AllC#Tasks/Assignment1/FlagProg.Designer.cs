namespace Assignments1
{
    partial class FlagProg
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
            label3 = new Label();
            BackToMenu = new Button();
            label2 = new Label();
            countryLabel = new Label();
            HeaderTitle = new Label();
            label4 = new Label();
            SomaliaPictureBox = new PictureBox();
            TurkeyPictureBox = new PictureBox();
            PalestinePictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)SomaliaPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TurkeyPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PalestinePictureBox).BeginInit();
            SuspendLayout();
            // 
            // Labeldate
            // 
            Labeldate.BackColor = Color.Transparent;
            Labeldate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Labeldate.ForeColor = Color.White;
            Labeldate.Location = new Point(1048, 9);
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
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(173, 44);
            label1.TabIndex = 23;
            label1.Text = "JU FOCOSIT";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Header
            // 
            Header.BackColor = Color.White;
            Header.Location = new Point(-4, -3);
            Header.Name = "Header";
            Header.Size = new Size(1323, 60);
            Header.TabIndex = 22;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(380, 704);
            label3.Name = "label3";
            label3.Size = new Size(580, 30);
            label3.TabIndex = 27;
            label3.Text = "@ 2025 abdikadir mohamed";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackToMenu
            // 
            BackToMenu.BackColor = Color.MediumBlue;
            BackToMenu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackToMenu.ForeColor = Color.Transparent;
            BackToMenu.Location = new Point(578, 628);
            BackToMenu.Name = "BackToMenu";
            BackToMenu.Size = new Size(189, 53);
            BackToMenu.TabIndex = 26;
            BackToMenu.Text = "Back To Main ";
            BackToMenu.UseVisualStyleBackColor = false;
            BackToMenu.Click += BackToMenu_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Roboto Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(397, 98);
            label2.Name = "label2";
            label2.Size = new Size(513, 39);
            label2.TabIndex = 31;
            label2.Text = " Click a flag to see the name of the country";
            // 
            // countryLabel
            // 
            countryLabel.BackColor = Color.SeaGreen;
            countryLabel.Font = new Font("Roboto Medium", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            countryLabel.ForeColor = Color.White;
            countryLabel.Location = new Point(413, 462);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(497, 66);
            countryLabel.TabIndex = 32;
            countryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HeaderTitle
            // 
            HeaderTitle.BackColor = Color.Transparent;
            HeaderTitle.Font = new Font("Roboto Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeaderTitle.ForeColor = SystemColors.Control;
            HeaderTitle.Location = new Point(466, -3);
            HeaderTitle.Name = "HeaderTitle";
            HeaderTitle.Size = new Size(356, 60);
            HeaderTitle.TabIndex = 33;
            HeaderTitle.Text = "Flag Identifier";
            HeaderTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.SteelBlue;
            label4.Location = new Point(-4, 150);
            label4.Name = "label4";
            label4.Size = new Size(1334, 289);
            label4.TabIndex = 34;
            // 
            // SomaliaPictureBox
            // 
            SomaliaPictureBox.Image = AllC_Tasks.Properties.Resources.Somalia;
            SomaliaPictureBox.Location = new Point(67, 188);
            SomaliaPictureBox.Name = "SomaliaPictureBox";
            SomaliaPictureBox.Size = new Size(373, 227);
            SomaliaPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            SomaliaPictureBox.TabIndex = 35;
            SomaliaPictureBox.TabStop = false;
            SomaliaPictureBox.Click += SomaliaPictureBox_Click;
            // 
            // TurkeyPictureBox
            // 
            TurkeyPictureBox.Image = AllC_Tasks.Properties.Resources.Turkey;
            TurkeyPictureBox.Location = new Point(875, 188);
            TurkeyPictureBox.Name = "TurkeyPictureBox";
            TurkeyPictureBox.Size = new Size(373, 227);
            TurkeyPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            TurkeyPictureBox.TabIndex = 37;
            TurkeyPictureBox.TabStop = false;
            TurkeyPictureBox.Click += TurkeyPictureBox_Click;
            // 
            // PalestinePictureBox
            // 
            PalestinePictureBox.Image = AllC_Tasks.Properties.Resources.Palestine;
            PalestinePictureBox.Location = new Point(475, 188);
            PalestinePictureBox.Name = "PalestinePictureBox";
            PalestinePictureBox.Size = new Size(373, 227);
            PalestinePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PalestinePictureBox.TabIndex = 36;
            PalestinePictureBox.TabStop = false;
            PalestinePictureBox.Click += PalestinePictureBox_Click;
            // 
            // FlagProg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1316, 736);
            Controls.Add(TurkeyPictureBox);
            Controls.Add(PalestinePictureBox);
            Controls.Add(SomaliaPictureBox);
            Controls.Add(HeaderTitle);
            Controls.Add(countryLabel);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(BackToMenu);
            Controls.Add(Labeldate);
            Controls.Add(label1);
            Controls.Add(Header);
            Controls.Add(label4);
            Name = "FlagProg";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FlagProg";
            Load += FlagProg_Load;
            ((System.ComponentModel.ISupportInitialize)SomaliaPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)TurkeyPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PalestinePictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label Labeldate;
        private Label label1;
        private Label Header;
        private Label label3;
        private Button BackToMenu;
        private Label label2;
        private Label countryLabel;
        private Label HeaderTitle;
        private Label label4;
        private PictureBox SomaliaPictureBox;
        private PictureBox TurkeyPictureBox;
        private PictureBox PalestinePictureBox;
    }
}