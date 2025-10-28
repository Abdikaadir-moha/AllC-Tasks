namespace AllC_Tasks.Assignment4
{
    partial class Book_Club_Points
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
            label7 = new Label();
            LblResult = new Label();
            label2 = new Label();
            txtBooks = new TextBox();
            CalculateBtn = new Button();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(152, 219);
            label7.Name = "label7";
            label7.Size = new Size(104, 25);
            label7.TabIndex = 23;
            label7.Text = "You earned:";
            // 
            // LblResult
            // 
            LblResult.BackColor = Color.DarkKhaki;
            LblResult.Location = new Point(276, 208);
            LblResult.Name = "LblResult";
            LblResult.Size = new Size(138, 46);
            LblResult.TabIndex = 22;
            LblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 111);
            label2.Name = "label2";
            label2.Size = new Size(287, 25);
            label2.TabIndex = 21;
            label2.Text = "Enter number of books purchased:";
            // 
            // txtBooks
            // 
            txtBooks.Location = new Point(314, 108);
            txtBooks.Name = "txtBooks";
            txtBooks.Size = new Size(150, 31);
            txtBooks.TabIndex = 20;
            // 
            // CalculateBtn
            // 
            CalculateBtn.Location = new Point(232, 321);
            CalculateBtn.Name = "CalculateBtn";
            CalculateBtn.Size = new Size(126, 62);
            CalculateBtn.TabIndex = 24;
            CalculateBtn.Text = "Calculate Points";
            CalculateBtn.UseVisualStyleBackColor = true;
            CalculateBtn.Click += CalculateBtn_Click;
            // 
            // Book_Club_Points
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 450);
            Controls.Add(CalculateBtn);
            Controls.Add(label7);
            Controls.Add(LblResult);
            Controls.Add(label2);
            Controls.Add(txtBooks);
            Name = "Book_Club_Points";
            Text = "Book_Club_Points";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label LblResult;
        private Label label2;
        private TextBox txtBooks;
        private Button CalculateBtn;
    }
}