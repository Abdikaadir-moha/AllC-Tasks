namespace AllC_Tasks.Ex_Ch4
{
    partial class Loan_Qualifier
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
            CheckButton = new Button();
            yearsTextBox = new TextBox();
            salaryTextBox = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            decisionLabel = new Label();
            SuspendLayout();
            // 
            // ClearButton
            // 
            ClearButton.ForeColor = Color.Black;
            ClearButton.Location = new Point(425, 357);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(153, 66);
            ClearButton.TabIndex = 4;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // CheckButton
            // 
            CheckButton.ForeColor = Color.Black;
            CheckButton.Location = new Point(202, 357);
            CheckButton.Name = "CheckButton";
            CheckButton.Size = new Size(194, 66);
            CheckButton.TabIndex = 2;
            CheckButton.Text = "Check Qualifications";
            CheckButton.UseVisualStyleBackColor = true;
            CheckButton.Click += CalculateButton_Click;
            // 
            // yearsTextBox
            // 
            yearsTextBox.Location = new Point(349, 123);
            yearsTextBox.Name = "yearsTextBox";
            yearsTextBox.Size = new Size(175, 32);
            yearsTextBox.TabIndex = 1;
            // 
            // salaryTextBox
            // 
            salaryTextBox.Location = new Point(349, 56);
            salaryTextBox.Name = "salaryTextBox";
            salaryTextBox.Size = new Size(175, 32);
            salaryTextBox.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 217);
            label5.Name = "label5";
            label5.Size = new Size(179, 25);
            label5.TabIndex = 20;
            label5.Text = "Loan decision:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 123);
            label3.Name = "label3";
            label3.Size = new Size(253, 25);
            label3.TabIndex = 19;
            label3.Text = "Years at current job:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 56);
            label2.Name = "label2";
            label2.Size = new Size(180, 25);
            label2.TabIndex = 18;
            label2.Text = "Annual salary:";
            // 
            // decisionLabel
            // 
            decisionLabel.BackColor = Color.DarkKhaki;
            decisionLabel.Location = new Point(68, 260);
            decisionLabel.Name = "decisionLabel";
            decisionLabel.Size = new Size(622, 50);
            decisionLabel.TabIndex = 3;
            decisionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Loan_Qualifier
            // 
            AutoScaleDimensions = new SizeF(14F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(777, 451);
            Controls.Add(ClearButton);
            Controls.Add(CheckButton);
            Controls.Add(yearsTextBox);
            Controls.Add(salaryTextBox);
            Controls.Add(decisionLabel);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            ForeColor = Color.White;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Loan_Qualifier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loan_Qualifier";
            Load += Loan_Qualifier_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ClearButton;
        private Button CheckButton;
        private TextBox yearsTextBox;
        private TextBox salaryTextBox;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label decisionLabel;
    }
}