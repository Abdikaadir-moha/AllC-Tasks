namespace AllC_Tasks.Assignment4
{
    partial class TimeCalculator
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
            resultLabel = new Label();
            secondsTextBox = new TextBox();
            CalculateButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 73);
            label1.Name = "label1";
            label1.Size = new Size(239, 27);
            label1.TabIndex = 2;
            label1.Text = "Enter number of seconds:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 183);
            label2.Name = "label2";
            label2.Size = new Size(75, 27);
            label2.TabIndex = 3;
            label2.Text = "Result:";
            // 
            // resultLabel
            // 
            resultLabel.BackColor = Color.PaleGoldenrod;
            resultLabel.Font = new Font("Roboto Condensed", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultLabel.Location = new Point(256, 174);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(236, 43);
            resultLabel.TabIndex = 4;
            resultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // secondsTextBox
            // 
            secondsTextBox.Location = new Point(345, 73);
            secondsTextBox.Name = "secondsTextBox";
            secondsTextBox.Size = new Size(165, 33);
            secondsTextBox.TabIndex = 0;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(270, 310);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(123, 54);
            CalculateButton.TabIndex = 1;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // TimeCalculator
            // 
            AutoScaleDimensions = new SizeF(11F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 409);
            Controls.Add(CalculateButton);
            Controls.Add(secondsTextBox);
            Controls.Add(resultLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Roboto Condensed", 10.8F, FontStyle.Bold);
            Name = "TimeCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TimeCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label resultLabel;
        private TextBox secondsTextBox;
        private Button CalculateButton;
    }
}