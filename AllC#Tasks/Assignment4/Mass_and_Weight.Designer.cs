namespace AllC_Tasks.Assignment4
{
    partial class Mass_and_Weight
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
            CalculateButton = new Button();
            MassTextBox = new TextBox();
            label4 = new Label();
            LblResult = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // CalculateButton
            // 
            CalculateButton.ForeColor = Color.Black;
            CalculateButton.Location = new Point(375, 352);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(150, 71);
            CalculateButton.TabIndex = 1;
            CalculateButton.Text = "Calculate Weight";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // MassTextBox
            // 
            MassTextBox.Location = new Point(422, 136);
            MassTextBox.Name = "MassTextBox";
            MassTextBox.Size = new Size(150, 32);
            MassTextBox.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(196, 266);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 9;
            label4.Text = "Result:";
            // 
            // LblResult
            // 
            LblResult.BackColor = Color.DarkKhaki;
            LblResult.Location = new Point(307, 253);
            LblResult.Name = "LblResult";
            LblResult.Size = new Size(350, 51);
            LblResult.TabIndex = 2;
            LblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(187, 139);
            label2.Name = "label2";
            label2.Size = new Size(208, 25);
            label2.TabIndex = 7;
            label2.Text = "Enter mass (kg):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 31);
            label1.Name = "label1";
            label1.Size = new Size(338, 25);
            label1.TabIndex = 5;
            label1.Text = "Mass and Weight Calculator";
            // 
            // Mass_and_Weight
            // 
            AutoScaleDimensions = new SizeF(14F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(844, 450);
            Controls.Add(CalculateButton);
            Controls.Add(MassTextBox);
            Controls.Add(label4);
            Controls.Add(LblResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            ForeColor = Color.White;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Mass_and_Weight";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mass_and_Weight";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CalculateButton;
        private TextBox MassTextBox;
        private Label label4;
        private Label LblResult;
        private Label label2;
        private Label label1;
    }
}