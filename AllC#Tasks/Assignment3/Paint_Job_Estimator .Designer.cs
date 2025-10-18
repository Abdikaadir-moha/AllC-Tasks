namespace AllC_Tasks
{
    partial class Paint_Job_Estimator
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
            squareFeetLabel = new Label();
            priceTextBox = new TextBox();
            priceLabel = new Label();
            gallonsLabel = new Label();
            hoursLabel = new Label();
            paintCostLabel = new Label();
            laborCostLabel = new Label();
            totalCostLabel = new Label();
            gallonsResultLabel = new Label();
            CalculateButton = new Button();
            squareFeetTextBox = new TextBox();
            laborCostResultLabel = new Label();
            paintCostResultLabel = new Label();
            hoursResultLabel = new Label();
            ClearButton = new Button();
            totalCostResultLabel = new Label();
            SuspendLayout();
            // 
            // squareFeetLabel
            // 
            squareFeetLabel.AutoSize = true;
            squareFeetLabel.Location = new Point(106, 66);
            squareFeetLabel.Name = "squareFeetLabel";
            squareFeetLabel.Size = new Size(187, 20);
            squareFeetLabel.TabIndex = 0;
            squareFeetLabel.Text = "Wall Space (sq ft):";
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(315, 130);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(125, 28);
            priceTextBox.TabIndex = 1;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(71, 133);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(222, 20);
            priceLabel.TabIndex = 3;
            priceLabel.Text = "Paint Price per Gallon:";
            // 
            // gallonsLabel
            // 
            gallonsLabel.AutoSize = true;
            gallonsLabel.Location = new Point(505, 55);
            gallonsLabel.Name = "gallonsLabel";
            gallonsLabel.Size = new Size(178, 20);
            gallonsLabel.TabIndex = 4;
            gallonsLabel.Text = "Gallons Required:";
            // 
            // hoursLabel
            // 
            hoursLabel.AutoSize = true;
            hoursLabel.Location = new Point(526, 123);
            hoursLabel.Name = "hoursLabel";
            hoursLabel.Size = new Size(157, 20);
            hoursLabel.TabIndex = 5;
            hoursLabel.Text = "Hours of Labor:";
            // 
            // paintCostLabel
            // 
            paintCostLabel.AutoSize = true;
            paintCostLabel.Location = new Point(545, 192);
            paintCostLabel.Name = "paintCostLabel";
            paintCostLabel.Size = new Size(138, 20);
            paintCostLabel.TabIndex = 6;
            paintCostLabel.Text = "Cost of Paint:";
            // 
            // laborCostLabel
            // 
            laborCostLabel.AutoSize = true;
            laborCostLabel.Location = new Point(531, 263);
            laborCostLabel.Name = "laborCostLabel";
            laborCostLabel.Size = new Size(152, 20);
            laborCostLabel.TabIndex = 7;
            laborCostLabel.Text = "Labor Charges:";
            // 
            // totalCostLabel
            // 
            totalCostLabel.AutoSize = true;
            totalCostLabel.Location = new Point(159, 278);
            totalCostLabel.Name = "totalCostLabel";
            totalCostLabel.Size = new Size(113, 20);
            totalCostLabel.TabIndex = 8;
            totalCostLabel.Text = "Total Cost:";
            // 
            // gallonsResultLabel
            // 
            gallonsResultLabel.BackColor = Color.MediumAquamarine;
            gallonsResultLabel.Location = new Point(705, 40);
            gallonsResultLabel.Name = "gallonsResultLabel";
            gallonsResultLabel.Size = new Size(119, 50);
            gallonsResultLabel.TabIndex = 4;
            gallonsResultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CalculateButton
            // 
            CalculateButton.BackColor = Color.DarkKhaki;
            CalculateButton.ForeColor = Color.White;
            CalculateButton.Location = new Point(545, 372);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(104, 45);
            CalculateButton.TabIndex = 2;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = false;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // squareFeetTextBox
            // 
            squareFeetTextBox.Location = new Point(315, 66);
            squareFeetTextBox.Name = "squareFeetTextBox";
            squareFeetTextBox.Size = new Size(125, 28);
            squareFeetTextBox.TabIndex = 0;
            // 
            // laborCostResultLabel
            // 
            laborCostResultLabel.BackColor = Color.MediumAquamarine;
            laborCostResultLabel.Location = new Point(705, 248);
            laborCostResultLabel.Name = "laborCostResultLabel";
            laborCostResultLabel.Size = new Size(119, 50);
            laborCostResultLabel.TabIndex = 7;
            laborCostResultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // paintCostResultLabel
            // 
            paintCostResultLabel.BackColor = Color.MediumAquamarine;
            paintCostResultLabel.Location = new Point(705, 177);
            paintCostResultLabel.Name = "paintCostResultLabel";
            paintCostResultLabel.Size = new Size(119, 50);
            paintCostResultLabel.TabIndex = 6;
            paintCostResultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hoursResultLabel
            // 
            hoursResultLabel.BackColor = Color.MediumAquamarine;
            hoursResultLabel.Location = new Point(705, 108);
            hoursResultLabel.Name = "hoursResultLabel";
            hoursResultLabel.Size = new Size(119, 50);
            hoursResultLabel.TabIndex = 5;
            hoursResultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.DarkKhaki;
            ClearButton.ForeColor = Color.White;
            ClearButton.Location = new Point(380, 372);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(104, 45);
            ClearButton.TabIndex = 3;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click_1;
            // 
            // totalCostResultLabel
            // 
            totalCostResultLabel.BackColor = Color.MediumAquamarine;
            totalCostResultLabel.Location = new Point(299, 263);
            totalCostResultLabel.Name = "totalCostResultLabel";
            totalCostResultLabel.Size = new Size(119, 50);
            totalCostResultLabel.TabIndex = 8;
            totalCostResultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Paint_Job_Estimator
            // 
            AutoScaleDimensions = new SizeF(12F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(902, 450);
            Controls.Add(totalCostResultLabel);
            Controls.Add(ClearButton);
            Controls.Add(hoursResultLabel);
            Controls.Add(paintCostResultLabel);
            Controls.Add(laborCostResultLabel);
            Controls.Add(squareFeetTextBox);
            Controls.Add(CalculateButton);
            Controls.Add(gallonsResultLabel);
            Controls.Add(totalCostLabel);
            Controls.Add(laborCostLabel);
            Controls.Add(paintCostLabel);
            Controls.Add(hoursLabel);
            Controls.Add(gallonsLabel);
            Controls.Add(priceLabel);
            Controls.Add(priceTextBox);
            Controls.Add(squareFeetLabel);
            Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            ForeColor = Color.White;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Paint_Job_Estimator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Paint_Job_Estimator";
            Load += Paint_Job_Estimator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label squareFeetLabel;
        private TextBox priceTextBox;
        private Label priceLabel;
        private Label gallonsLabel;
        private Label hoursLabel;
        private Label paintCostLabel;
        private Label laborCostLabel;
        private Label totalCostLabel;
        private Label gallonsResultLabel;
        private Button CalculateButton;
        private TextBox squareFeetTextBox;
        private Label laborCostResultLabel;
        private Label paintCostResultLabel;
        private Label hoursResultLabel;
        private Button ClearButton;
        private Label totalCostResultLabel;
    }
}