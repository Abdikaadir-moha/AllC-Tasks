namespace AllC_Tasks
{
    partial class Sales_Tax_and_Total
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
            Calculatebutton = new Button();
            TotalSalesLabel = new Label();
            Country_Sales_TaxLabel = new Label();
            Sate_label = new Label();
            label2 = new Label();
            tax = new Label();
            tip = new Label();
            amountpurchasetextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Calculatebutton
            // 
            Calculatebutton.BackColor = Color.CadetBlue;
            Calculatebutton.ForeColor = Color.White;
            Calculatebutton.Location = new Point(553, 345);
            Calculatebutton.Margin = new Padding(2);
            Calculatebutton.Name = "Calculatebutton";
            Calculatebutton.Size = new Size(129, 40);
            Calculatebutton.TabIndex = 4;
            Calculatebutton.Text = "Calculate";
            Calculatebutton.UseVisualStyleBackColor = false;
            Calculatebutton.Click += Calculatebutton_Click;
            // 
            // TotalSalesLabel
            // 
            TotalSalesLabel.BackColor = Color.LightGoldenrodYellow;
            TotalSalesLabel.BorderStyle = BorderStyle.FixedSingle;
            TotalSalesLabel.Location = new Point(574, 273);
            TotalSalesLabel.Margin = new Padding(2, 0, 2, 0);
            TotalSalesLabel.Name = "TotalSalesLabel";
            TotalSalesLabel.Size = new Size(155, 37);
            TotalSalesLabel.TabIndex = 3;
            TotalSalesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Country_Sales_TaxLabel
            // 
            Country_Sales_TaxLabel.BackColor = Color.PaleTurquoise;
            Country_Sales_TaxLabel.BorderStyle = BorderStyle.FixedSingle;
            Country_Sales_TaxLabel.Location = new Point(574, 211);
            Country_Sales_TaxLabel.Margin = new Padding(2, 0, 2, 0);
            Country_Sales_TaxLabel.Name = "Country_Sales_TaxLabel";
            Country_Sales_TaxLabel.Size = new Size(155, 44);
            Country_Sales_TaxLabel.TabIndex = 2;
            Country_Sales_TaxLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Sate_label
            // 
            Sate_label.BackColor = Color.DarkSeaGreen;
            Sate_label.BorderStyle = BorderStyle.FixedSingle;
            Sate_label.Location = new Point(574, 152);
            Sate_label.Margin = new Padding(2, 0, 2, 0);
            Sate_label.Name = "Sate_label";
            Sate_label.Size = new Size(155, 44);
            Sate_label.TabIndex = 1;
            Sate_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(422, 282);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 39;
            label2.Text = "Total Sales:";
            // 
            // tax
            // 
            tax.AutoSize = true;
            tax.ForeColor = Color.White;
            tax.Location = new Point(367, 223);
            tax.Margin = new Padding(2, 0, 2, 0);
            tax.Name = "tax";
            tax.Size = new Size(176, 20);
            tax.TabIndex = 38;
            tax.Text = "Country Sales tax";
            // 
            // tip
            // 
            tip.AutoSize = true;
            tip.ForeColor = Color.White;
            tip.Location = new Point(394, 163);
            tip.Margin = new Padding(2, 0, 2, 0);
            tip.Name = "tip";
            tip.Size = new Size(149, 20);
            tip.TabIndex = 37;
            tip.Text = "State sales tax";
            // 
            // amountpurchasetextBox
            // 
            amountpurchasetextBox.Location = new Point(593, 103);
            amountpurchasetextBox.Margin = new Padding(2);
            amountpurchasetextBox.Name = "amountpurchasetextBox";
            amountpurchasetextBox.Size = new Size(121, 28);
            amountpurchasetextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(318, 106);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(256, 20);
            label1.TabIndex = 35;
            label1.Text = "Enter amount of purchase";
            // 
            // Sales_Tax_and_Total
            // 
            AutoScaleDimensions = new SizeF(12F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1200, 484);
            Controls.Add(Calculatebutton);
            Controls.Add(TotalSalesLabel);
            Controls.Add(Country_Sales_TaxLabel);
            Controls.Add(Sate_label);
            Controls.Add(label2);
            Controls.Add(tax);
            Controls.Add(tip);
            Controls.Add(amountpurchasetextBox);
            Controls.Add(label1);
            Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "Sales_Tax_and_Total";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sales_Tax_and_Total";
            Load += Sales_Tax_and_Total_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Calculatebutton;
        private Label TotalSalesLabel;
        private Label Country_Sales_TaxLabel;
        private Label Sate_label;
        private Label label2;
        private Label tax;
        private Label tip;
        private TextBox amountpurchasetextBox;
        private Label label1;
    }
}