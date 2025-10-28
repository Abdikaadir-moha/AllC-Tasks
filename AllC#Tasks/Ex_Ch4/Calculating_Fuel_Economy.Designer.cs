namespace AllC_Tasks.Ex_Ch4
{
    partial class Calculating_Fuel_Economy
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
            milesTextBox = new TextBox();
            ClearBtn = new Button();
            mpgLabel = new Label();
            gallonsTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // CalculateButton
            // 
            CalculateButton.BackColor = Color.DarkSlateBlue;
            CalculateButton.ForeColor = Color.White;
            CalculateButton.Location = new Point(208, 338);
            CalculateButton.Margin = new Padding(6, 3, 6, 3);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(177, 65);
            CalculateButton.TabIndex = 2;
            CalculateButton.Text = "Calculate MPG";
            CalculateButton.UseVisualStyleBackColor = false;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // milesTextBox
            // 
            milesTextBox.ForeColor = Color.Black;
            milesTextBox.Location = new Point(470, 79);
            milesTextBox.Margin = new Padding(4, 3, 4, 3);
            milesTextBox.Name = "milesTextBox";
            milesTextBox.Size = new Size(173, 32);
            milesTextBox.TabIndex = 0;
            // 
            // ClearBtn
            // 
            ClearBtn.BackColor = Color.DarkSlateBlue;
            ClearBtn.ForeColor = Color.White;
            ClearBtn.Location = new Point(427, 338);
            ClearBtn.Margin = new Padding(6, 3, 6, 3);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(177, 65);
            ClearBtn.TabIndex = 4;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = false;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // mpgLabel
            // 
            mpgLabel.BackColor = Color.Beige;
            mpgLabel.Location = new Point(395, 226);
            mpgLabel.Margin = new Padding(4, 0, 4, 0);
            mpgLabel.Name = "mpgLabel";
            mpgLabel.Size = new Size(237, 47);
            mpgLabel.TabIndex = 3;
            mpgLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gallonsTextBox
            // 
            gallonsTextBox.ForeColor = Color.Black;
            gallonsTextBox.Location = new Point(470, 134);
            gallonsTextBox.Margin = new Padding(4, 3, 4, 3);
            gallonsTextBox.Name = "gallonsTextBox";
            gallonsTextBox.Size = new Size(173, 32);
            gallonsTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(169, 236);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(202, 25);
            label1.TabIndex = 65;
            label1.Text = " Your car’s MPG:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(81, 137);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(368, 25);
            label2.TabIndex = 64;
            label2.Text = " Enter the gallons of gas used:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(34, 79);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(415, 25);
            label6.TabIndex = 63;
            label6.Text = " Enter the number of miles driven:";
            // 
            // Calculating_Fuel_Economy
            // 
            AutoScaleDimensions = new SizeF(14F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(811, 450);
            Controls.Add(CalculateButton);
            Controls.Add(milesTextBox);
            Controls.Add(ClearBtn);
            Controls.Add(mpgLabel);
            Controls.Add(gallonsTextBox);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label6);
            Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Calculating_Fuel_Economy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculating_Fuel_Economy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CalculateButton;
        private TextBox milesTextBox;
        private Button ClearBtn;
        private Label mpgLabel;
        private TextBox gallonsTextBox;
        private Label label1;
        private Label label2;
        private Label label6;
    }
}