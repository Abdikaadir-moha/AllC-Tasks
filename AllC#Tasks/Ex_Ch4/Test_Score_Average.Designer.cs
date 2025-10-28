namespace AllC_Tasks.Ex_Ch4
{
    partial class Test_Score_Average
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            averageLabel = new Label();
            test1TextBox = new TextBox();
            test3TextBox = new TextBox();
            test2TextBox = new TextBox();
            CalculateButton = new Button();
            ClearButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(228, 53);
            label1.Name = "label1";
            label1.Size = new Size(290, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter Three Test Scores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 133);
            label2.Name = "label2";
            label2.Size = new Size(174, 25);
            label2.TabIndex = 1;
            label2.Text = "Test Score #1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(145, 200);
            label3.Name = "label3";
            label3.Size = new Size(174, 25);
            label3.TabIndex = 2;
            label3.Text = "Test Score #2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(145, 269);
            label4.Name = "label4";
            label4.Size = new Size(174, 25);
            label4.TabIndex = 3;
            label4.Text = "Test Score #3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(215, 366);
            label5.Name = "label5";
            label5.Size = new Size(117, 25);
            label5.TabIndex = 4;
            label5.Text = "Average:";
            // 
            // averageLabel
            // 
            averageLabel.BackColor = Color.DarkKhaki;
            averageLabel.Location = new Point(370, 356);
            averageLabel.Name = "averageLabel";
            averageLabel.Size = new Size(171, 50);
            averageLabel.TabIndex = 5;
            averageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // test1TextBox
            // 
            test1TextBox.Location = new Point(366, 130);
            test1TextBox.Name = "test1TextBox";
            test1TextBox.Size = new Size(175, 32);
            test1TextBox.TabIndex = 0;
            // 
            // test3TextBox
            // 
            test3TextBox.Location = new Point(366, 266);
            test3TextBox.Name = "test3TextBox";
            test3TextBox.Size = new Size(175, 32);
            test3TextBox.TabIndex = 2;
            // 
            // test2TextBox
            // 
            test2TextBox.Location = new Point(366, 197);
            test2TextBox.Name = "test2TextBox";
            test2TextBox.Size = new Size(175, 32);
            test2TextBox.TabIndex = 1;
            // 
            // CalculateButton
            // 
            CalculateButton.ForeColor = Color.Black;
            CalculateButton.Location = new Point(228, 478);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(153, 66);
            CalculateButton.TabIndex = 6;
            CalculateButton.Text = "Calculate Average";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.ForeColor = Color.Black;
            ClearButton.Location = new Point(405, 478);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(153, 66);
            ClearButton.TabIndex = 7;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // Test_Score_Average
            // 
            AutoScaleDimensions = new SizeF(14F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(770, 596);
            Controls.Add(ClearButton);
            Controls.Add(CalculateButton);
            Controls.Add(test2TextBox);
            Controls.Add(test3TextBox);
            Controls.Add(test1TextBox);
            Controls.Add(averageLabel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            ForeColor = Color.White;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Test_Score_Average";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Test_Score_Average";
            Load += Test_Score_Average_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label averageLabel;
        private TextBox test1TextBox;
        private TextBox test3TextBox;
        private TextBox test2TextBox;
        private Button CalculateButton;
        private Button ClearButton;
    }
}