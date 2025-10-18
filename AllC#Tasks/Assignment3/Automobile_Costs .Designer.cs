namespace AllC_Tasks
{
    partial class Automobile_Costs
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            annualResultLabel = new Label();
            label7 = new Label();
            label8 = new Label();
            monthlyResultLabel = new Label();
            label10 = new Label();
            loanTextBox = new TextBox();
            insuranceTextBox = new TextBox();
            gasTextBox = new TextBox();
            oilTextBox = new TextBox();
            maintenanceTextBox = new TextBox();
            tiresTextBox = new TextBox();
            ClearButton = new Button();
            calculateButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(43, 69);
            label1.Name = "label1";
            label1.Size = new Size(151, 20);
            label1.TabIndex = 0;
            label1.Text = "Loan Payment:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 116);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 1;
            label2.Text = "Insurance:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 165);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 2;
            label3.Text = "Gas:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(127, 271);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 3;
            label4.Text = "Tires:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 315);
            label5.Name = "label5";
            label5.Size = new Size(136, 20);
            label5.TabIndex = 4;
            label5.Text = "Maintenance:";
            // 
            // annualResultLabel
            // 
            annualResultLabel.BackColor = Color.SeaGreen;
            annualResultLabel.Location = new Point(514, 180);
            annualResultLabel.Name = "annualResultLabel";
            annualResultLabel.Size = new Size(131, 42);
            annualResultLabel.TabIndex = 5;
            annualResultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(486, 141);
            label7.Name = "label7";
            label7.Size = new Size(185, 20);
            label7.TabIndex = 6;
            label7.Text = "Total Annual Cost:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(152, 218);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 7;
            label8.Text = "Oil:";
            // 
            // monthlyResultLabel
            // 
            monthlyResultLabel.BackColor = Color.MediumAquamarine;
            monthlyResultLabel.Location = new Point(514, 76);
            monthlyResultLabel.Name = "monthlyResultLabel";
            monthlyResultLabel.Size = new Size(131, 42);
            monthlyResultLabel.TabIndex = 8;
            monthlyResultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(486, 40);
            label10.Name = "label10";
            label10.Size = new Size(196, 20);
            label10.TabIndex = 9;
            label10.Text = "Total Monthly Cost:";
            // 
            // loanTextBox
            // 
            loanTextBox.Location = new Point(200, 66);
            loanTextBox.Name = "loanTextBox";
            loanTextBox.Size = new Size(120, 28);
            loanTextBox.TabIndex = 0;
            // 
            // insuranceTextBox
            // 
            insuranceTextBox.Location = new Point(200, 113);
            insuranceTextBox.Name = "insuranceTextBox";
            insuranceTextBox.Size = new Size(120, 28);
            insuranceTextBox.TabIndex = 1;
            // 
            // gasTextBox
            // 
            gasTextBox.Location = new Point(200, 162);
            gasTextBox.Name = "gasTextBox";
            gasTextBox.Size = new Size(120, 28);
            gasTextBox.TabIndex = 2;
            // 
            // oilTextBox
            // 
            oilTextBox.Location = new Point(200, 215);
            oilTextBox.Name = "oilTextBox";
            oilTextBox.Size = new Size(120, 28);
            oilTextBox.TabIndex = 3;
            // 
            // maintenanceTextBox
            // 
            maintenanceTextBox.Location = new Point(200, 315);
            maintenanceTextBox.Name = "maintenanceTextBox";
            maintenanceTextBox.Size = new Size(120, 28);
            maintenanceTextBox.TabIndex = 5;
            // 
            // tiresTextBox
            // 
            tiresTextBox.Location = new Point(200, 267);
            tiresTextBox.Name = "tiresTextBox";
            tiresTextBox.Size = new Size(120, 28);
            tiresTextBox.TabIndex = 4;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.DarkCyan;
            ClearButton.ForeColor = Color.White;
            ClearButton.Location = new Point(451, 310);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(111, 45);
            ClearButton.TabIndex = 7;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click_1;
            // 
            // calculateButton
            // 
            calculateButton.BackColor = Color.PowderBlue;
            calculateButton.ForeColor = Color.Black;
            calculateButton.Location = new Point(580, 310);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(111, 45);
            calculateButton.TabIndex = 6;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click_1;
            // 
            // Automobile_Costs
            // 
            AutoScaleDimensions = new SizeF(12F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(896, 450);
            Controls.Add(calculateButton);
            Controls.Add(ClearButton);
            Controls.Add(tiresTextBox);
            Controls.Add(maintenanceTextBox);
            Controls.Add(oilTextBox);
            Controls.Add(gasTextBox);
            Controls.Add(insuranceTextBox);
            Controls.Add(loanTextBox);
            Controls.Add(label10);
            Controls.Add(monthlyResultLabel);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(annualResultLabel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            ForeColor = Color.White;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Automobile_Costs";
            Text = "Automobile_Costs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label annualResultLabel;
        private Label label7;
        private Label label8;
        private Label monthlyResultLabel;
        private Label label10;
        private TextBox loanTextBox;
        private TextBox insuranceTextBox;
        private TextBox gasTextBox;
        private TextBox oilTextBox;
        private TextBox maintenanceTextBox;
        private TextBox tiresTextBox;
        private Button ClearButton;
        private Button calculateButton;
    }
}