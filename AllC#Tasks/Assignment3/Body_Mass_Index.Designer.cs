namespace AllC_Tasks
{
    partial class Body_Mass_Index
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
            HeighttextBox = new TextBox();
            Heightlabel = new Label();
            Calculatebutton = new Button();
            Resultlabel = new Label();
            Resultlable = new Label();
            WeighttextBox = new TextBox();
            Weightlabel = new Label();
            SuspendLayout();
            // 
            // HeighttextBox
            // 
            HeighttextBox.Location = new Point(287, 153);
            HeighttextBox.Margin = new Padding(2);
            HeighttextBox.Name = "HeighttextBox";
            HeighttextBox.Size = new Size(121, 28);
            HeighttextBox.TabIndex = 1;
            // 
            // Heightlabel
            // 
            Heightlabel.AutoSize = true;
            Heightlabel.ForeColor = Color.White;
            Heightlabel.Location = new Point(51, 156);
            Heightlabel.Margin = new Padding(2, 0, 2, 0);
            Heightlabel.Name = "Heightlabel";
            Heightlabel.Size = new Size(224, 20);
            Heightlabel.TabIndex = 40;
            Heightlabel.Text = "Enter Height (Inches):";
            // 
            // Calculatebutton
            // 
            Calculatebutton.BackColor = Color.MediumAquamarine;
            Calculatebutton.ForeColor = Color.Black;
            Calculatebutton.Location = new Point(196, 347);
            Calculatebutton.Margin = new Padding(2);
            Calculatebutton.Name = "Calculatebutton";
            Calculatebutton.Size = new Size(143, 56);
            Calculatebutton.TabIndex = 2;
            Calculatebutton.Text = "Calculate BMI";
            Calculatebutton.UseVisualStyleBackColor = false;
            Calculatebutton.Click += Calculatebutton_Click;
            // 
            // Resultlabel
            // 
            Resultlabel.BackColor = Color.PaleTurquoise;
            Resultlabel.BorderStyle = BorderStyle.FixedSingle;
            Resultlabel.Location = new Point(205, 251);
            Resultlabel.Margin = new Padding(2, 0, 2, 0);
            Resultlabel.Name = "Resultlabel";
            Resultlabel.Size = new Size(155, 47);
            Resultlabel.TabIndex = 2;
            Resultlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Resultlable
            // 
            Resultlable.AutoSize = true;
            Resultlable.ForeColor = Color.White;
            Resultlable.Location = new Point(72, 264);
            Resultlable.Margin = new Padding(2, 0, 2, 0);
            Resultlable.Name = "Resultlable";
            Resultlable.Size = new Size(117, 20);
            Resultlable.TabIndex = 37;
            Resultlable.Text = "The BMI is:";
            // 
            // WeighttextBox
            // 
            WeighttextBox.Location = new Point(287, 110);
            WeighttextBox.Margin = new Padding(2);
            WeighttextBox.Name = "WeighttextBox";
            WeighttextBox.Size = new Size(121, 28);
            WeighttextBox.TabIndex = 0;
            // 
            // Weightlabel
            // 
            Weightlabel.AutoSize = true;
            Weightlabel.ForeColor = Color.White;
            Weightlabel.Location = new Point(40, 113);
            Weightlabel.Margin = new Padding(2, 0, 2, 0);
            Weightlabel.Name = "Weightlabel";
            Weightlabel.Size = new Size(235, 20);
            Weightlabel.TabIndex = 35;
            Weightlabel.Text = "Enter Weight (Pounds):";
            // 
            // Body_Mass_Index
            // 
            AutoScaleDimensions = new SizeF(12F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(503, 450);
            Controls.Add(HeighttextBox);
            Controls.Add(Heightlabel);
            Controls.Add(Calculatebutton);
            Controls.Add(Resultlabel);
            Controls.Add(Resultlable);
            Controls.Add(WeighttextBox);
            Controls.Add(Weightlabel);
            Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Body_Mass_Index";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Body_Mass_Index";
            Load += Body_Mass_Index_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox HeighttextBox;
        private Label Heightlabel;
        private Button Calculatebutton;
        private Label Resultlabel;
        private Label Resultlable;
        private TextBox WeighttextBox;
        private Label Weightlabel;
    }
}