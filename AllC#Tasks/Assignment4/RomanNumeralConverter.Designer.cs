namespace AllC_Tasks.Assignment4
{
    partial class RomanNumeralConverter
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
            LblResult = new Label();
            label4 = new Label();
            NumberTextBox = new TextBox();
            ConvertButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 35);
            label1.Name = "label1";
            label1.Size = new Size(323, 25);
            label1.TabIndex = 0;
            label1.Text = "Roman Numeral Converter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 143);
            label2.Name = "label2";
            label2.Size = new Size(291, 25);
            label2.TabIndex = 1;
            label2.Text = "Enter a number (1–10):";
            // 
            // LblResult
            // 
            LblResult.BackColor = Color.DarkKhaki;
            LblResult.Location = new Point(271, 257);
            LblResult.Name = "LblResult";
            LblResult.Size = new Size(350, 51);
            LblResult.TabIndex = 2;
            LblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(160, 270);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 3;
            label4.Text = "Result:";
            // 
            // NumberTextBox
            // 
            NumberTextBox.Location = new Point(471, 140);
            NumberTextBox.Name = "NumberTextBox";
            NumberTextBox.Size = new Size(150, 32);
            NumberTextBox.TabIndex = 0;
            // 
            // ConvertButton
            // 
            ConvertButton.ForeColor = Color.Black;
            ConvertButton.Location = new Point(366, 371);
            ConvertButton.Name = "ConvertButton";
            ConvertButton.Size = new Size(149, 52);
            ConvertButton.TabIndex = 1;
            ConvertButton.Text = "Convert";
            ConvertButton.UseVisualStyleBackColor = true;
            ConvertButton.Click += ConvertButton_Click;
            // 
            // RomanNumeralConverter
            // 
            AutoScaleDimensions = new SizeF(14F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(839, 450);
            Controls.Add(ConvertButton);
            Controls.Add(NumberTextBox);
            Controls.Add(label4);
            Controls.Add(LblResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            ForeColor = Color.White;
            Margin = new Padding(4, 3, 4, 3);
            Name = "RomanNumeralConverter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RomanNumeralConverter";
            Load += RomanNumeralConverter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label LblResult;
        private Label label4;
        private TextBox NumberTextBox;
        private Button ConvertButton;
    }
}