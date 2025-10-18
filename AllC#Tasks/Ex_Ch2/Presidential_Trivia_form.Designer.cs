namespace AllC_Tasks.Ex_Ch2
{
    partial class PresidentialTravia
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
            label1 = new Label();
            AnswerLabel = new Label();
            ShowAnswerBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 90);
            label1.Name = "label1";
            label1.Size = new Size(276, 20);
            label1.TabIndex = 1;
            label1.Text = "The President of Somalia is:";
            // 
            // AnswerLabel
            // 
            AnswerLabel.BackColor = Color.DarkKhaki;
            AnswerLabel.Location = new Point(202, 147);
            AnswerLabel.Name = "AnswerLabel";
            AnswerLabel.Size = new Size(272, 55);
            AnswerLabel.TabIndex = 1;
            AnswerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ShowAnswerBtn
            // 
            ShowAnswerBtn.BackColor = Color.SandyBrown;
            ShowAnswerBtn.ForeColor = Color.Black;
            ShowAnswerBtn.Location = new Point(268, 286);
            ShowAnswerBtn.Name = "ShowAnswerBtn";
            ShowAnswerBtn.Size = new Size(140, 60);
            ShowAnswerBtn.TabIndex = 0;
            ShowAnswerBtn.Text = "Show Answer";
            ShowAnswerBtn.UseVisualStyleBackColor = false;
            ShowAnswerBtn.Click += ShowAnswerBtn_Click;
            // 
            // PresidentialTravia
            // 
            AutoScaleDimensions = new SizeF(12F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(667, 484);
            Controls.Add(ShowAnswerBtn);
            Controls.Add(AnswerLabel);
            Controls.Add(label1);
            Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            ForeColor = Color.White;
            Margin = new Padding(4, 3, 4, 3);
            Name = "PresidentialTravia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Presidential Trivia form  ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label AnswerLabel;
        private Button ShowAnswerBtn;
    }
}