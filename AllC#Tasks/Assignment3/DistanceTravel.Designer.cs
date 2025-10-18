namespace AllC_Tasks
{
    partial class DistanceTravel
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
            Cal5Hoursbutton = new Button();
            Cal8Hoursbutton = new Button();
            Cal12Hoursbutton = new Button();
            label3 = new Label();
            Resultlabel = new Label();
            SpeedtextBox = new TextBox();
            label = new Label();
            SuspendLayout();
            // 
            // Cal5Hoursbutton
            // 
            Cal5Hoursbutton.Location = new Point(357, 272);
            Cal5Hoursbutton.Name = "Cal5Hoursbutton";
            Cal5Hoursbutton.Size = new Size(117, 53);
            Cal5Hoursbutton.TabIndex = 16;
            Cal5Hoursbutton.Text = "Calculate 5 Hours";
            Cal5Hoursbutton.UseVisualStyleBackColor = true;
            Cal5Hoursbutton.Click += Cal5Hoursbutton_Click;
            // 
            // Cal8Hoursbutton
            // 
            Cal8Hoursbutton.Location = new Point(516, 272);
            Cal8Hoursbutton.Name = "Cal8Hoursbutton";
            Cal8Hoursbutton.Size = new Size(114, 53);
            Cal8Hoursbutton.TabIndex = 15;
            Cal8Hoursbutton.Text = "Calculate 8 Hours";
            Cal8Hoursbutton.UseVisualStyleBackColor = true;
            Cal8Hoursbutton.Click += Cal8Hoursbutton_Click;
            // 
            // Cal12Hoursbutton
            // 
            Cal12Hoursbutton.Location = new Point(667, 272);
            Cal12Hoursbutton.Name = "Cal12Hoursbutton";
            Cal12Hoursbutton.Size = new Size(117, 53);
            Cal12Hoursbutton.TabIndex = 14;
            Cal12Hoursbutton.Text = "Calculate 12 Hours";
            Cal12Hoursbutton.UseVisualStyleBackColor = true;
            Cal12Hoursbutton.Click += Cal12Hoursbutton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(407, 181);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 13;
            label3.Text = "Result";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Resultlabel
            // 
            Resultlabel.BackColor = Color.SkyBlue;
            Resultlabel.ForeColor = Color.White;
            Resultlabel.Location = new Point(505, 170);
            Resultlabel.Name = "Resultlabel";
            Resultlabel.Size = new Size(162, 42);
            Resultlabel.TabIndex = 12;
            Resultlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SpeedtextBox
            // 
            SpeedtextBox.Location = new Point(520, 100);
            SpeedtextBox.Name = "SpeedtextBox";
            SpeedtextBox.Size = new Size(125, 28);
            SpeedtextBox.TabIndex = 11;
            // 
            // label
            // 
            label.AutoSize = true;
            label.ForeColor = Color.White;
            label.Location = new Point(145, 103);
            label.Name = "label";
            label.Size = new Size(359, 20);
            label.TabIndex = 10;
            label.Text = "Enter Speed in Miles Per Hour(mph):";
            label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DistanceTravel
            // 
            AutoScaleDimensions = new SizeF(12F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1200, 439);
            Controls.Add(Cal5Hoursbutton);
            Controls.Add(Cal8Hoursbutton);
            Controls.Add(Cal12Hoursbutton);
            Controls.Add(label3);
            Controls.Add(Resultlabel);
            Controls.Add(SpeedtextBox);
            Controls.Add(label);
            Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DistanceTravel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DistanceTravel";
            Load += DistanceTravel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cal5Hoursbutton;
        private Button Cal8Hoursbutton;
        private Button Cal12Hoursbutton;
        private Label label3;
        private Label Resultlabel;
        private TextBox SpeedtextBox;
        private Label label;
    }
}