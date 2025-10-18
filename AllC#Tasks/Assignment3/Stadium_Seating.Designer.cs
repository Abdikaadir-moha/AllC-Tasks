namespace AllC_Tasks
{
    partial class Stadium_Seating
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
            ticketsGroupBox = new GroupBox();
            classCTextBox = new TextBox();
            classBTextBox = new TextBox();
            classATextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            revenueGroupBox = new GroupBox();
            totalResultLabel = new Label();
            label11 = new Label();
            revCResultLabel = new Label();
            revBResultLabel = new Label();
            revAResultLabel = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ClearButton = new Button();
            CalculateButton = new Button();
            ticketsGroupBox.SuspendLayout();
            revenueGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ticketsGroupBox
            // 
            ticketsGroupBox.Controls.Add(classCTextBox);
            ticketsGroupBox.Controls.Add(classBTextBox);
            ticketsGroupBox.Controls.Add(classATextBox);
            ticketsGroupBox.Controls.Add(label4);
            ticketsGroupBox.Controls.Add(label3);
            ticketsGroupBox.Controls.Add(label2);
            ticketsGroupBox.Controls.Add(label1);
            ticketsGroupBox.ForeColor = Color.White;
            ticketsGroupBox.Location = new Point(53, 55);
            ticketsGroupBox.Name = "ticketsGroupBox";
            ticketsGroupBox.Size = new Size(404, 383);
            ticketsGroupBox.TabIndex = 0;
            ticketsGroupBox.TabStop = false;
            ticketsGroupBox.Text = "Tickets Sold";
            // 
            // classCTextBox
            // 
            classCTextBox.Location = new Point(153, 289);
            classCTextBox.Name = "classCTextBox";
            classCTextBox.Size = new Size(125, 28);
            classCTextBox.TabIndex = 3;
            // 
            // classBTextBox
            // 
            classBTextBox.Location = new Point(153, 209);
            classBTextBox.Name = "classBTextBox";
            classBTextBox.Size = new Size(125, 28);
            classBTextBox.TabIndex = 2;
            // 
            // classATextBox
            // 
            classATextBox.Location = new Point(153, 136);
            classATextBox.Name = "classATextBox";
            classATextBox.Size = new Size(125, 28);
            classATextBox.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 212);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 3;
            label4.Text = "Class B:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 292);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 2;
            label3.Text = "Class C:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 139);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 1;
            label2.Text = "Class A:";
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 47);
            label1.Name = "label1";
            label1.Size = new Size(339, 46);
            label1.TabIndex = 0;
            label1.Text = "Enter the number of tickets sold for each class of seats:";
            // 
            // revenueGroupBox
            // 
            revenueGroupBox.Controls.Add(totalResultLabel);
            revenueGroupBox.Controls.Add(label11);
            revenueGroupBox.Controls.Add(revCResultLabel);
            revenueGroupBox.Controls.Add(revBResultLabel);
            revenueGroupBox.Controls.Add(revAResultLabel);
            revenueGroupBox.Controls.Add(label5);
            revenueGroupBox.Controls.Add(label6);
            revenueGroupBox.Controls.Add(label7);
            revenueGroupBox.ForeColor = Color.White;
            revenueGroupBox.Location = new Point(512, 55);
            revenueGroupBox.Name = "revenueGroupBox";
            revenueGroupBox.Size = new Size(404, 383);
            revenueGroupBox.TabIndex = 4;
            revenueGroupBox.TabStop = false;
            revenueGroupBox.Text = "Revenue Generated";
            // 
            // totalResultLabel
            // 
            totalResultLabel.BackColor = Color.Gold;
            totalResultLabel.ForeColor = Color.Black;
            totalResultLabel.Location = new Point(182, 304);
            totalResultLabel.Name = "totalResultLabel";
            totalResultLabel.Size = new Size(140, 40);
            totalResultLabel.TabIndex = 8;
            totalResultLabel.Text = "—";
            totalResultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(74, 314);
            label11.Name = "label11";
            label11.Size = new Size(65, 20);
            label11.TabIndex = 7;
            label11.Text = "Total:";
            // 
            // revCResultLabel
            // 
            revCResultLabel.BackColor = Color.LemonChiffon;
            revCResultLabel.ForeColor = Color.Black;
            revCResultLabel.Location = new Point(182, 231);
            revCResultLabel.Name = "revCResultLabel";
            revCResultLabel.Size = new Size(140, 40);
            revCResultLabel.TabIndex = 6;
            revCResultLabel.Text = "—";
            revCResultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // revBResultLabel
            // 
            revBResultLabel.BackColor = Color.LemonChiffon;
            revBResultLabel.ForeColor = Color.Black;
            revBResultLabel.Location = new Point(182, 151);
            revBResultLabel.Name = "revBResultLabel";
            revBResultLabel.Size = new Size(140, 40);
            revBResultLabel.TabIndex = 5;
            revBResultLabel.Text = "—";
            revBResultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // revAResultLabel
            // 
            revAResultLabel.BackColor = Color.LemonChiffon;
            revAResultLabel.ForeColor = Color.Black;
            revAResultLabel.Location = new Point(182, 78);
            revAResultLabel.Name = "revAResultLabel";
            revAResultLabel.Size = new Size(140, 40);
            revAResultLabel.TabIndex = 4;
            revAResultLabel.Text = "—";
            revAResultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 90);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 1;
            label5.Text = "Class A:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 243);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 2;
            label6.Text = "Class C:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(56, 163);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 3;
            label7.Text = "Class B:";
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.MediumSeaGreen;
            ClearButton.ForeColor = Color.White;
            ClearButton.Location = new Point(347, 469);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(104, 45);
            ClearButton.TabIndex = 6;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // CalculateButton
            // 
            CalculateButton.BackColor = Color.MediumSeaGreen;
            CalculateButton.ForeColor = Color.White;
            CalculateButton.Location = new Point(512, 469);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(104, 45);
            CalculateButton.TabIndex = 5;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = false;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // Stadium_Seating
            // 
            AutoScaleDimensions = new SizeF(12F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(987, 539);
            Controls.Add(ClearButton);
            Controls.Add(CalculateButton);
            Controls.Add(revenueGroupBox);
            Controls.Add(ticketsGroupBox);
            Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Stadium_Seating";
            Text = "Stadium_Seating";
            Load += Stadium_Seating_Load;
            ticketsGroupBox.ResumeLayout(false);
            ticketsGroupBox.PerformLayout();
            revenueGroupBox.ResumeLayout(false);
            revenueGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ticketsGroupBox;
        private TextBox classATextBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox revenueGroupBox;
        private TextBox classCTextBox;
        private TextBox classBTextBox;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label revAResultLabel;
        private Label revCResultLabel;
        private Label revBResultLabel;
        private Label totalResultLabel;
        private Label label11;
        private Button ClearButton;
        private Button CalculateButton;
    }
}