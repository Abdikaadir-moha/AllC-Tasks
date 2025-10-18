namespace AllC_Tasks
{
    partial class Property_Tax
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
            label3 = new Label();
            valueTextBox = new TextBox();
            ClearButton = new Button();
            CalculateButton = new Button();
            taxResultLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 114);
            label1.Name = "label1";
            label1.Size = new Size(193, 20);
            label1.TabIndex = 0;
            label1.Text = "Property Value ($):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 192);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 2;
            label3.Text = "Property Tax:";
            // 
            // valueTextBox
            // 
            valueTextBox.Location = new Point(372, 111);
            valueTextBox.Name = "valueTextBox";
            valueTextBox.Size = new Size(125, 28);
            valueTextBox.TabIndex = 0;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.DarkKhaki;
            ClearButton.ForeColor = Color.White;
            ClearButton.Location = new Point(285, 311);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(104, 45);
            ClearButton.TabIndex = 2;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // CalculateButton
            // 
            CalculateButton.BackColor = Color.DarkKhaki;
            CalculateButton.ForeColor = Color.White;
            CalculateButton.Location = new Point(450, 311);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(104, 45);
            CalculateButton.TabIndex = 1;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = false;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // taxResultLabel
            // 
            taxResultLabel.BackColor = Color.DarkSeaGreen;
            taxResultLabel.ForeColor = Color.Black;
            taxResultLabel.Location = new Point(372, 180);
            taxResultLabel.Name = "taxResultLabel";
            taxResultLabel.Size = new Size(123, 41);
            taxResultLabel.TabIndex = 22;
            taxResultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Property_Tax
            // 
            AutoScaleDimensions = new SizeF(12F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(846, 450);
            Controls.Add(taxResultLabel);
            Controls.Add(ClearButton);
            Controls.Add(CalculateButton);
            Controls.Add(valueTextBox);
            Controls.Add(label3);
            Controls.Add(label1);
            Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            ForeColor = Color.White;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Property_Tax";
            Text = "s";
            Load += Property_Tax_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox valueTextBox;
        private Button ClearButton;
        private Button CalculateButton;
        private Label taxResultLabel;
    }
}