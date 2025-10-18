namespace AllC_Tasks
{
    partial class Calorie_Counter
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
            Resultlabel = new Label();
            Resultlable = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            PearPictureBox = new PictureBox();
            OrangePictureBox = new PictureBox();
            ApplePictureBox = new PictureBox();
            BananPictureBox = new PictureBox();
            ResetBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)PearPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrangePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ApplePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BananPictureBox).BeginInit();
            SuspendLayout();
            // 
            // Resultlabel
            // 
            Resultlabel.BackColor = Color.PaleGreen;
            Resultlabel.BorderStyle = BorderStyle.FixedSingle;
            Resultlabel.Location = new Point(520, 145);
            Resultlabel.Margin = new Padding(2, 0, 2, 0);
            Resultlabel.Name = "Resultlabel";
            Resultlabel.Size = new Size(155, 48);
            Resultlabel.TabIndex = 40;
            Resultlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Resultlable
            // 
            Resultlable.AutoSize = true;
            Resultlable.ForeColor = Color.White;
            Resultlable.Location = new Point(520, 109);
            Resultlable.Margin = new Padding(2, 0, 2, 0);
            Resultlable.Name = "Resultlable";
            Resultlable.Size = new Size(147, 20);
            Resultlable.TabIndex = 39;
            Resultlable.Text = "Total Calories:";
            // 
            // label4
            // 
            label4.BackColor = Color.Black;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(261, 359);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(144, 42);
            label4.TabIndex = 50;
            label4.Text = "120 Calories";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.Black;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(120, 359);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(144, 42);
            label3.TabIndex = 49;
            label3.Text = "90 Calories";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(261, 201);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 40);
            label2.TabIndex = 48;
            label2.Text = "80 Calories";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(120, 201);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 40);
            label1.TabIndex = 47;
            label1.Text = "115 Calories";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PearPictureBox
            // 
            PearPictureBox.BackColor = Color.DarkCyan;
            PearPictureBox.Image = Properties.Resources.pear;
            PearPictureBox.Location = new Point(261, 243);
            PearPictureBox.Margin = new Padding(2);
            PearPictureBox.Name = "PearPictureBox";
            PearPictureBox.Size = new Size(144, 114);
            PearPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            PearPictureBox.TabIndex = 46;
            PearPictureBox.TabStop = false;
            PearPictureBox.Click += PearPictureBox_Click_1;
            // 
            // OrangePictureBox
            // 
            OrangePictureBox.BackColor = Color.DarkCyan;
            OrangePictureBox.Image = Properties.Resources.orange;
            OrangePictureBox.Location = new Point(120, 243);
            OrangePictureBox.Margin = new Padding(2);
            OrangePictureBox.Name = "OrangePictureBox";
            OrangePictureBox.Size = new Size(144, 114);
            OrangePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            OrangePictureBox.TabIndex = 45;
            OrangePictureBox.TabStop = false;
            OrangePictureBox.Click += OrangePictureBox_Click_1;
            // 
            // ApplePictureBox
            // 
            ApplePictureBox.BackColor = Color.DarkCyan;
            ApplePictureBox.Image = Properties.Resources.Apple2;
            ApplePictureBox.Location = new Point(261, 71);
            ApplePictureBox.Margin = new Padding(2);
            ApplePictureBox.Name = "ApplePictureBox";
            ApplePictureBox.Size = new Size(144, 128);
            ApplePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            ApplePictureBox.TabIndex = 44;
            ApplePictureBox.TabStop = false;
            ApplePictureBox.Click += ApplePictureBox_Click_1;
            // 
            // BananPictureBox
            // 
            BananPictureBox.BackColor = Color.DarkCyan;
            BananPictureBox.Image = Properties.Resources.Banana;
            BananPictureBox.Location = new Point(120, 71);
            BananPictureBox.Margin = new Padding(2);
            BananPictureBox.Name = "BananPictureBox";
            BananPictureBox.Size = new Size(144, 128);
            BananPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            BananPictureBox.TabIndex = 43;
            BananPictureBox.TabStop = false;
            BananPictureBox.Click += BananPictureBox_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = Color.Olive;
            ResetBtn.ForeColor = Color.White;
            ResetBtn.Location = new Point(539, 359);
            ResetBtn.Margin = new Padding(2);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(114, 42);
            ResetBtn.TabIndex = 0;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = false;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // Calorie_Counter
            // 
            AutoScaleDimensions = new SizeF(12F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(882, 531);
            Controls.Add(ResetBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PearPictureBox);
            Controls.Add(OrangePictureBox);
            Controls.Add(ApplePictureBox);
            Controls.Add(BananPictureBox);
            Controls.Add(Resultlabel);
            Controls.Add(Resultlable);
            Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Calorie_Counter";
            Text = "Calorie_Counter";
            ((System.ComponentModel.ISupportInitialize)PearPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrangePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ApplePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BananPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Resultlabel;
        private Label Resultlable;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox PearPictureBox;
        private PictureBox OrangePictureBox;
        private PictureBox ApplePictureBox;
        private PictureBox BananPictureBox;
        private Button ResetBtn;
    }
}