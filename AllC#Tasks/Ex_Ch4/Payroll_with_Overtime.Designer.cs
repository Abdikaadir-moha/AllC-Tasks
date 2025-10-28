namespace AllC_Tasks.Ex_Ch4
{
    partial class Payroll_with_Overtime
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
            CalculateButton = new Button();
            hourlyPayRateTextBox = new TextBox();
            hoursWorkedTextBox = new TextBox();
            grossPayLabel = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // ClearButton
            // 
            ClearButton.ForeColor = Color.Black;
            ClearButton.Location = new Point(401, 350);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(153, 66);
            ClearButton.TabIndex = 4;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // CalculateButton
            // 
            CalculateButton.ForeColor = Color.Black;
            CalculateButton.Location = new Point(224, 350);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(153, 66);
            CalculateButton.TabIndex = 2;
            CalculateButton.Text = "Calculate Gross Pay";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // hourlyPayRateTextBox
            // 
            hourlyPayRateTextBox.Location = new Point(401, 153);
            hourlyPayRateTextBox.Name = "hourlyPayRateTextBox";
            hourlyPayRateTextBox.Size = new Size(175, 32);
            hourlyPayRateTextBox.TabIndex = 1;
            // 
            // hoursWorkedTextBox
            // 
            hoursWorkedTextBox.Location = new Point(401, 86);
            hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            hoursWorkedTextBox.Size = new Size(175, 32);
            hoursWorkedTextBox.TabIndex = 0;
            // 
            // grossPayLabel
            // 
            grossPayLabel.BackColor = Color.DarkKhaki;
            grossPayLabel.Location = new Point(372, 250);
            grossPayLabel.Name = "grossPayLabel";
            grossPayLabel.Size = new Size(171, 50);
            grossPayLabel.TabIndex = 3;
            grossPayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(217, 260);
            label5.Name = "label5";
            label5.Size = new Size(135, 25);
            label5.TabIndex = 12;
            label5.Text = "Gross pay:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(180, 156);
            label3.Name = "label3";
            label3.Size = new Size(203, 25);
            label3.TabIndex = 11;
            label3.Text = "Hourly pay rate:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 89);
            label2.Name = "label2";
            label2.Size = new Size(184, 25);
            label2.TabIndex = 10;
            label2.Text = "Hours worked:";
            // 
            // Payroll_with_Overtime
            // 
            AutoScaleDimensions = new SizeF(14F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(801, 484);
            Controls.Add(ClearButton);
            Controls.Add(CalculateButton);
            Controls.Add(hourlyPayRateTextBox);
            Controls.Add(hoursWorkedTextBox);
            Controls.Add(grossPayLabel);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            ForeColor = Color.White;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Payroll_with_Overtime";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payroll_with_Overtime";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ClearButton;
        private Button CalculateButton;
        private TextBox hourlyPayRateTextBox;
        private TextBox hoursWorkedTextBox;
        private Label grossPayLabel;
        private Label label5;
        private Label label3;
        private Label label2;
    }
}