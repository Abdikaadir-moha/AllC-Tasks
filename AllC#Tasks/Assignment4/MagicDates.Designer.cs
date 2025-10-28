namespace AllC_Tasks.Assignment4
{
    partial class MagicDates
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
            CheckButton = new Button();
            MonthTextBox = new TextBox();
            YearTextBox = new TextBox();
            DayTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label7 = new Label();
            LblResult = new Label();
            ClearBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 18);
            label1.Name = "label1";
            label1.Size = new Size(169, 25);
            label1.TabIndex = 0;
            label1.Text = "Magic Date Checker";
            // 
            // CheckButton
            // 
            CheckButton.Location = new Point(243, 436);
            CheckButton.Name = "CheckButton";
            CheckButton.Size = new Size(132, 43);
            CheckButton.TabIndex = 1;
            CheckButton.Text = "Check Date";
            CheckButton.UseVisualStyleBackColor = true;
            CheckButton.Click += CheckButton_Click;
            // 
            // MonthTextBox
            // 
            MonthTextBox.Location = new Point(380, 99);
            MonthTextBox.Name = "MonthTextBox";
            MonthTextBox.Size = new Size(150, 31);
            MonthTextBox.TabIndex = 2;
            // 
            // YearTextBox
            // 
            YearTextBox.Location = new Point(380, 255);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.Size = new Size(150, 31);
            YearTextBox.TabIndex = 3;
            // 
            // DayTextBox
            // 
            DayTextBox.Location = new Point(380, 172);
            DayTextBox.Name = "DayTextBox";
            DayTextBox.Size = new Size(150, 31);
            DayTextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 102);
            label2.Name = "label2";
            label2.Size = new Size(168, 25);
            label2.TabIndex = 6;
            label2.Text = "Enter month (1–12):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(212, 172);
            label3.Name = "label3";
            label3.Size = new Size(144, 25);
            label3.TabIndex = 7;
            label3.Text = "Enter day (1–31):";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(184, 255);
            label4.Name = "label4";
            label4.Size = new Size(172, 25);
            label4.TabIndex = 8;
            label4.Text = "Enter two-digit year:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(129, 349);
            label7.Name = "label7";
            label7.Size = new Size(63, 25);
            label7.TabIndex = 12;
            label7.Text = "Result:";
            // 
            // LblResult
            // 
            LblResult.BackColor = Color.DarkKhaki;
            LblResult.Location = new Point(223, 336);
            LblResult.Name = "LblResult";
            LblResult.Size = new Size(350, 51);
            LblResult.TabIndex = 11;
            LblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ClearBtn
            // 
            ClearBtn.Location = new Point(412, 436);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(132, 43);
            ClearBtn.TabIndex = 13;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // MagicDates
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 524);
            Controls.Add(ClearBtn);
            Controls.Add(label7);
            Controls.Add(LblResult);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(DayTextBox);
            Controls.Add(YearTextBox);
            Controls.Add(MonthTextBox);
            Controls.Add(CheckButton);
            Controls.Add(label1);
            Name = "MagicDates";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MagicDates";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button CheckButton;
        private TextBox MonthTextBox;
        private TextBox YearTextBox;
        private TextBox DayTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label LblResult;
        private Button ClearBtn;
    }
}