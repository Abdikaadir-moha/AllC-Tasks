namespace AllC_Tasks.Assignment4
{
    partial class Software_Sales
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
            txtQuantity = new TextBox();
            label2 = new Label();
            LblDiscount = new Label();
            LblTotal = new Label();
            label5 = new Label();
            CalculateButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 118);
            label1.Name = "label1";
            label1.Size = new Size(224, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter number of packages:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(392, 115);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(150, 31);
            txtQuantity.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(276, 204);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 2;
            label2.Text = "Discount:";
            // 
            // LblDiscount
            // 
            LblDiscount.BackColor = Color.Khaki;
            LblDiscount.Location = new Point(393, 193);
            LblDiscount.Name = "LblDiscount";
            LblDiscount.Size = new Size(150, 49);
            LblDiscount.TabIndex = 3;
            // 
            // LblTotal
            // 
            LblTotal.BackColor = Color.Khaki;
            LblTotal.Location = new Point(392, 271);
            LblTotal.Name = "LblTotal";
            LblTotal.Size = new Size(150, 49);
            LblTotal.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(309, 282);
            label5.Name = "label5";
            label5.Size = new Size(53, 25);
            label5.TabIndex = 4;
            label5.Text = "Total:";
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(309, 365);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(132, 43);
            CalculateButton.TabIndex = 6;
            CalculateButton.Text = "Calculate Total";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // Software_Sales
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CalculateButton);
            Controls.Add(LblTotal);
            Controls.Add(label5);
            Controls.Add(LblDiscount);
            Controls.Add(label2);
            Controls.Add(txtQuantity);
            Controls.Add(label1);
            Name = "Software_Sales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Software_Sales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtQuantity;
        private Label label2;
        private Label LblDiscount;
        private Label LblTotal;
        private Label label5;
        private Button CalculateButton;
    }
}