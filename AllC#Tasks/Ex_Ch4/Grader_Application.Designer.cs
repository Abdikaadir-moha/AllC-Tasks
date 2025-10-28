namespace AllC_Tasks.Ex_Ch4
{
    partial class Grader_Application
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
            ClearButton = new Button();
            DetermineGradeButton = new Button();
            testScoreTextBox = new TextBox();
            gradeLabel = new Label();
            label5 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // ClearButton
            // 
            ClearButton.ForeColor = Color.Black;
            ClearButton.Location = new Point(415, 288);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(153, 66);
            ClearButton.TabIndex = 3;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // DetermineGradeButton
            // 
            DetermineGradeButton.ForeColor = Color.Black;
            DetermineGradeButton.Location = new Point(184, 288);
            DetermineGradeButton.Name = "DetermineGradeButton";
            DetermineGradeButton.Size = new Size(202, 66);
            DetermineGradeButton.TabIndex = 1;
            DetermineGradeButton.Text = "Determine Grade";
            DetermineGradeButton.UseVisualStyleBackColor = true;
            DetermineGradeButton.Click += DetermineGradeButton_Click;
            // 
            // testScoreTextBox
            // 
            testScoreTextBox.Location = new Point(353, 57);
            testScoreTextBox.Name = "testScoreTextBox";
            testScoreTextBox.Size = new Size(175, 32);
            testScoreTextBox.TabIndex = 0;
            // 
            // gradeLabel
            // 
            gradeLabel.BackColor = Color.DarkKhaki;
            gradeLabel.Location = new Point(311, 154);
            gradeLabel.Name = "gradeLabel";
            gradeLabel.Size = new Size(229, 45);
            gradeLabel.TabIndex = 2;
            gradeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(140, 164);
            label5.Name = "label5";
            label5.Size = new Size(149, 25);
            label5.TabIndex = 28;
            label5.Text = "Your grade:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 60);
            label2.Name = "label2";
            label2.Size = new Size(265, 25);
            label2.TabIndex = 26;
            label2.Text = "Enter your test score:";
            // 
            // Grader_Application
            // 
            AutoScaleDimensions = new SizeF(14F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(728, 428);
            Controls.Add(ClearButton);
            Controls.Add(DetermineGradeButton);
            Controls.Add(testScoreTextBox);
            Controls.Add(gradeLabel);
            Controls.Add(label5);
            Controls.Add(label2);
            Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            ForeColor = Color.White;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Grader_Application";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grader_Application";
            Load += Grader_Application_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ClearButton;
        private Button DetermineGradeButton;
        private TextBox testScoreTextBox;
        private Label gradeLabel;
        private Label label5;
        private Label label2;
    }
}