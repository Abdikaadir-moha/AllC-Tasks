namespace AllC_Tasks.Assignment4
{
    partial class DistanceConverter
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
            groupBox1 = new GroupBox();
            lstFrom = new ListBox();
            groupBox2 = new GroupBox();
            lstTo = new ListBox();
            label2 = new Label();
            DistanceTextBox = new TextBox();
            label7 = new Label();
            LblResult = new Label();
            ConvertButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(lstFrom);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(131, 136);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(221, 185);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "From";
            // 
            // lstFrom
            // 
            lstFrom.FormattingEnabled = true;
            lstFrom.ItemHeight = 25;
            lstFrom.Items.AddRange(new object[] { "Inches", "Feet", "Yards" });
            lstFrom.Location = new Point(19, 58);
            lstFrom.Name = "lstFrom";
            lstFrom.Size = new Size(180, 104);
            lstFrom.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(lstTo);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(393, 136);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(221, 185);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "To";
            // 
            // lstTo
            // 
            lstTo.FormattingEnabled = true;
            lstTo.ItemHeight = 25;
            lstTo.Items.AddRange(new object[] { "Inches", "Feet", "Yards" });
            lstTo.Location = new Point(19, 58);
            lstTo.Name = "lstTo";
            lstTo.Size = new Size(180, 104);
            lstTo.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 60);
            label2.Name = "label2";
            label2.Size = new Size(212, 25);
            label2.TabIndex = 17;
            label2.Text = "Enter distance to convert:";
            // 
            // DistanceTextBox
            // 
            DistanceTextBox.Location = new Point(393, 58);
            DistanceTextBox.Name = "DistanceTextBox";
            DistanceTextBox.Size = new Size(150, 31);
            DistanceTextBox.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(119, 356);
            label7.Name = "label7";
            label7.Size = new Size(170, 25);
            label7.TabIndex = 19;
            label7.Text = "Converted Distance:";
            // 
            // LblResult
            // 
            LblResult.BackColor = Color.DarkKhaki;
            LblResult.Location = new Point(319, 345);
            LblResult.Name = "LblResult";
            LblResult.Size = new Size(224, 46);
            LblResult.TabIndex = 18;
            LblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ConvertButton
            // 
            ConvertButton.Location = new Point(319, 440);
            ConvertButton.Name = "ConvertButton";
            ConvertButton.Size = new Size(132, 43);
            ConvertButton.TabIndex = 20;
            ConvertButton.Text = "Convert";
            ConvertButton.UseVisualStyleBackColor = true;
            ConvertButton.Click += ConvertButton_Click;
            // 
            // DistanceConverter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 509);
            Controls.Add(ConvertButton);
            Controls.Add(label7);
            Controls.Add(LblResult);
            Controls.Add(label2);
            Controls.Add(DistanceTextBox);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "DistanceConverter";
            Text = "DistanceConverter";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lstFrom;
        private GroupBox groupBox2;
        private ListBox lstTo;
        private Label label2;
        private TextBox DistanceTextBox;
        private Label label7;
        private Label LblResult;
        private Button ConvertButton;
    }
}