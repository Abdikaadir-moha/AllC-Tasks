namespace AllC_Tasks.Assignment4
{
    partial class ChangeForDollar
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
            messageLabel = new Label();
            penniesTextBox = new TextBox();
            quartersTextBox = new TextBox();
            dimesTextBox = new TextBox();
            nickelsTextBox = new TextBox();
            CalculateBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(237, 54);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 0;
            label1.Text = "Pennies:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 129);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 1;
            label2.Text = "Nickels:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(246, 202);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 2;
            label3.Text = "Dimes:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(228, 273);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 3;
            label4.Text = "Quarters:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(228, 350);
            label5.Name = "label5";
            label5.Size = new Size(68, 25);
            label5.TabIndex = 4;
            label5.Text = "Result: ";
            // 
            // messageLabel
            // 
            messageLabel.BackColor = Color.Beige;
            messageLabel.Location = new Point(332, 337);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(188, 49);
            messageLabel.TabIndex = 5;
            messageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // penniesTextBox
            // 
            penniesTextBox.Location = new Point(344, 51);
            penniesTextBox.Name = "penniesTextBox";
            penniesTextBox.Size = new Size(150, 31);
            penniesTextBox.TabIndex = 0;
            // 
            // quartersTextBox
            // 
            quartersTextBox.Location = new Point(344, 270);
            quartersTextBox.Name = "quartersTextBox";
            quartersTextBox.Size = new Size(150, 31);
            quartersTextBox.TabIndex = 3;
            // 
            // dimesTextBox
            // 
            dimesTextBox.Location = new Point(344, 199);
            dimesTextBox.Name = "dimesTextBox";
            dimesTextBox.Size = new Size(150, 31);
            dimesTextBox.TabIndex = 2;
            // 
            // nickelsTextBox
            // 
            nickelsTextBox.Location = new Point(344, 126);
            nickelsTextBox.Name = "nickelsTextBox";
            nickelsTextBox.Size = new Size(150, 31);
            nickelsTextBox.TabIndex = 1;
            // 
            // CalculateBtn
            // 
            CalculateBtn.Location = new Point(332, 419);
            CalculateBtn.Name = "CalculateBtn";
            CalculateBtn.Size = new Size(139, 51);
            CalculateBtn.TabIndex = 11;
            CalculateBtn.Text = "Calculate";
            CalculateBtn.UseVisualStyleBackColor = true;
            CalculateBtn.Click += CalculateBtn_Click;
            // 
            // ChangeForDollar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(CalculateBtn);
            Controls.Add(nickelsTextBox);
            Controls.Add(dimesTextBox);
            Controls.Add(quartersTextBox);
            Controls.Add(penniesTextBox);
            Controls.Add(messageLabel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ChangeForDollar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangeForDollar";
            Load += ChangeForDollar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label messageLabel;
        private TextBox penniesTextBox;
        private TextBox quartersTextBox;
        private TextBox dimesTextBox;
        private TextBox nickelsTextBox;
        private Button CalculateBtn;
    }
}