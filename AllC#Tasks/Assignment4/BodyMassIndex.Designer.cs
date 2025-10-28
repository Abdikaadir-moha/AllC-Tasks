namespace AllC_Tasks.Assignment4
{
    partial class BodyMassIndex
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
            BmiResultLabel = new Label();
            MessageLabel = new Label();
            label5 = new Label();
            WeightTextBox = new TextBox();
            HeightTextBox = new TextBox();
            label2 = new Label();
            CalculateBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 77);
            label1.Name = "label1";
            label1.Size = new Size(193, 25);
            label1.TabIndex = 3;
            label1.Text = "Enter Weight (pounds):";
            // 
            // BmiResultLabel
            // 
            BmiResultLabel.BackColor = Color.LemonChiffon;
            BmiResultLabel.Location = new Point(353, 250);
            BmiResultLabel.Name = "BmiResultLabel";
            BmiResultLabel.Size = new Size(147, 39);
            BmiResultLabel.TabIndex = 6;
            // 
            // MessageLabel
            // 
            MessageLabel.BackColor = Color.LightCyan;
            MessageLabel.Location = new Point(255, 319);
            MessageLabel.Name = "MessageLabel";
            MessageLabel.Size = new Size(298, 52);
            MessageLabel.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(218, 256);
            label5.Name = "label5";
            label5.Size = new Size(104, 25);
            label5.TabIndex = 5;
            label5.Text = "Your BMI is:";
            // 
            // WeightTextBox
            // 
            WeightTextBox.Location = new Point(353, 77);
            WeightTextBox.Name = "WeightTextBox";
            WeightTextBox.Size = new Size(150, 31);
            WeightTextBox.TabIndex = 0;
            // 
            // HeightTextBox
            // 
            HeightTextBox.Location = new Point(353, 148);
            HeightTextBox.Name = "HeightTextBox";
            HeightTextBox.Size = new Size(150, 31);
            HeightTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 151);
            label2.Name = "label2";
            label2.Size = new Size(178, 25);
            label2.TabIndex = 4;
            label2.Text = "Enter Height (inches):";
            // 
            // CalculateBtn
            // 
            CalculateBtn.Location = new Point(339, 407);
            CalculateBtn.Name = "CalculateBtn";
            CalculateBtn.Size = new Size(139, 51);
            CalculateBtn.TabIndex = 2;
            CalculateBtn.Text = "Calculate BMI";
            CalculateBtn.UseVisualStyleBackColor = true;
            CalculateBtn.Click += CalculateBtn_Click;
            // 
            // BodyMassIndex
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 483);
            Controls.Add(CalculateBtn);
            Controls.Add(label2);
            Controls.Add(HeightTextBox);
            Controls.Add(WeightTextBox);
            Controls.Add(label5);
            Controls.Add(MessageLabel);
            Controls.Add(BmiResultLabel);
            Controls.Add(label1);
            Name = "BodyMassIndex";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BodyMassIndex";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label BmiResultLabel;
        private Label MessageLabel;
        private Label label5;
        private TextBox WeightTextBox;
        private TextBox HeightTextBox;
        private Label label2;
        private Button CalculateBtn;
    }
}