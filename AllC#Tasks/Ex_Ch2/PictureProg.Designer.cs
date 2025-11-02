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
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            HeaderTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            SuspendLayout();
            // 
            // PictureBox
            // 
            PictureBox.BackColor = SystemColors.ActiveCaption;
            PictureBox.Image = AllC_Tasks.Properties.Resources.lion;
            PictureBox.Location = new Point(211, 219);
            PictureBox.Margin = new Padding(4, 5, 4, 5);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(374, 375);
            PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            PictureBox.Click += PictureBox_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 6);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(216, 55);
            label1.TabIndex = 23;
            label1.Text = "JU FOCOSIT";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(40, 652);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(726, 38);
            label3.TabIndex = 27;
            label3.Text = "@ 2025 abdikadir mohamed";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(185, 156);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(426, 36);
            label2.TabIndex = 0;
            label2.Text = "Click the image to see the name:";
            // 
            // HeaderTitle
            // 
            HeaderTitle.BackColor = Color.Transparent;
            HeaderTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeaderTitle.ForeColor = Color.White;
            HeaderTitle.Location = new Point(263, -8);
            HeaderTitle.Margin = new Padding(4, 0, 4, 0);
            HeaderTitle.Name = "HeaderTitle";
            HeaderTitle.Size = new Size(446, 75);
            HeaderTitle.TabIndex = 24;
            HeaderTitle.Text = "Picture Box Program";
            HeaderTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PictureProg
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(850, 727);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(HeaderTitle);
            Controls.Add(label1);
            Controls.Add(PictureBox);
            Margin = new Padding(4, 5, 4, 5);
            Name = "PictureProg";
            StartPosition = FormStartPosition.CenterScreen;
            Load += PictureProg_Load;
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PictureBox;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label HeaderTitle;
    }
}