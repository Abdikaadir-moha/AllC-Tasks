namespace AllC_Tasks.Assignment4
{
    partial class Fat_Percentage_Calculator
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
            totalCaloriesTextBox = new TextBox();
            fatGramsTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            percentageResultLabel = new Label();
            caloriesFromFatResultLabel = new Label();
            lowFatCheckBox = new CheckBox();
            messageLabel = new Label();
            CalculateBtn = new Button();
            label6 = new Label();
            ClearBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 35);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 0;
            label1.Text = "Total Calories:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 106);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 1;
            label2.Text = "Fat Grams:";
            // 
            // totalCaloriesTextBox
            // 
            totalCaloriesTextBox.Location = new Point(338, 32);
            totalCaloriesTextBox.Name = "totalCaloriesTextBox";
            totalCaloriesTextBox.Size = new Size(150, 31);
            totalCaloriesTextBox.TabIndex = 0;
            // 
            // fatGramsTextBox
            // 
            fatGramsTextBox.Location = new Point(338, 103);
            fatGramsTextBox.Name = "fatGramsTextBox";
            fatGramsTextBox.Size = new Size(150, 31);
            fatGramsTextBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 261);
            label3.Name = "label3";
            label3.Size = new Size(263, 25);
            label3.TabIndex = 2;
            label3.Text = "Percentage of Calories from Fat:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(161, 206);
            label4.Name = "label4";
            label4.Size = new Size(150, 25);
            label4.TabIndex = 3;
            label4.Text = "Calories from Fat:";
            // 
            // percentageResultLabel
            // 
            percentageResultLabel.BackColor = Color.BlanchedAlmond;
            percentageResultLabel.Location = new Point(361, 261);
            percentageResultLabel.Name = "percentageResultLabel";
            percentageResultLabel.Size = new Size(127, 46);
            percentageResultLabel.TabIndex = 5;
            // 
            // caloriesFromFatResultLabel
            // 
            caloriesFromFatResultLabel.BackColor = Color.BlanchedAlmond;
            caloriesFromFatResultLabel.Location = new Point(361, 194);
            caloriesFromFatResultLabel.Name = "caloriesFromFatResultLabel";
            caloriesFromFatResultLabel.Size = new Size(127, 46);
            caloriesFromFatResultLabel.TabIndex = 6;
            // 
            // lowFatCheckBox
            // 
            lowFatCheckBox.AutoSize = true;
            lowFatCheckBox.Location = new Point(161, 356);
            lowFatCheckBox.Name = "lowFatCheckBox";
            lowFatCheckBox.Size = new Size(351, 29);
            lowFatCheckBox.TabIndex = 7;
            lowFatCheckBox.Text = "Check if you want to know if it’s low-fat";
            lowFatCheckBox.UseVisualStyleBackColor = true;
            // 
            // messageLabel
            // 
            messageLabel.BackColor = Color.CadetBlue;
            messageLabel.ForeColor = Color.White;
            messageLabel.Location = new Point(246, 425);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(266, 49);
            messageLabel.TabIndex = 9;
            messageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CalculateBtn
            // 
            CalculateBtn.Location = new Point(255, 504);
            CalculateBtn.Name = "CalculateBtn";
            CalculateBtn.Size = new Size(139, 51);
            CalculateBtn.TabIndex = 3;
            CalculateBtn.Text = "Calculate";
            CalculateBtn.UseVisualStyleBackColor = true;
            CalculateBtn.Click += CalculateBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(177, 435);
            label6.Name = "label6";
            label6.Size = new Size(63, 25);
            label6.TabIndex = 13;
            label6.Text = "Result:";
            // 
            // ClearBtn
            // 
            ClearBtn.Location = new Point(424, 504);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(139, 51);
            ClearBtn.TabIndex = 14;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // Fat_Percentage_Calculator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 584);
            Controls.Add(ClearBtn);
            Controls.Add(label6);
            Controls.Add(CalculateBtn);
            Controls.Add(messageLabel);
            Controls.Add(lowFatCheckBox);
            Controls.Add(caloriesFromFatResultLabel);
            Controls.Add(percentageResultLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(fatGramsTextBox);
            Controls.Add(totalCaloriesTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Fat_Percentage_Calculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fat_Percentage_Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox totalCaloriesTextBox;
        private TextBox fatGramsTextBox;
        private Label label3;
        private Label label4;
        private Label percentageResultLabel;
        private Label caloriesFromFatResultLabel;
        private CheckBox lowFatCheckBox;
        private Label messageLabel;
        private Button CalculateBtn;
        private Label label6;
        private Button ClearBtn;
    }
}