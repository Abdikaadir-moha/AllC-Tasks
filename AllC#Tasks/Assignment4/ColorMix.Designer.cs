namespace AllC_Tasks.Assignment4
{
    partial class ColorMix
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
            rdoBlue1 = new RadioButton();
            rdoYellow1 = new RadioButton();
            rdoRed1 = new RadioButton();
            groupBox2 = new GroupBox();
            rdoBlue2 = new RadioButton();
            rdoYellow2 = new RadioButton();
            rdoRed2 = new RadioButton();
            MixButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(rdoBlue1);
            groupBox1.Controls.Add(rdoYellow1);
            groupBox1.Controls.Add(rdoRed1);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(37, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(347, 267);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select the First Color";
            // 
            // rdoBlue1
            // 
            rdoBlue1.AutoSize = true;
            rdoBlue1.Location = new Point(68, 127);
            rdoBlue1.Name = "rdoBlue1";
            rdoBlue1.Size = new Size(70, 29);
            rdoBlue1.TabIndex = 8;
            rdoBlue1.Text = "Blue";
            rdoBlue1.UseVisualStyleBackColor = true;
            // 
            // rdoYellow1
            // 
            rdoYellow1.AutoSize = true;
            rdoYellow1.Location = new Point(68, 193);
            rdoYellow1.Name = "rdoYellow1";
            rdoYellow1.Size = new Size(86, 29);
            rdoYellow1.TabIndex = 6;
            rdoYellow1.Text = "Yellow";
            rdoYellow1.UseVisualStyleBackColor = true;
            // 
            // rdoRed1
            // 
            rdoRed1.AutoSize = true;
            rdoRed1.Location = new Point(71, 67);
            rdoRed1.Name = "rdoRed1";
            rdoRed1.Size = new Size(67, 29);
            rdoRed1.TabIndex = 7;
            rdoRed1.Text = "Red";
            rdoRed1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(rdoBlue2);
            groupBox2.Controls.Add(rdoYellow2);
            groupBox2.Controls.Add(rdoRed2);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(411, 47);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(347, 267);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Select the Second Color";
            // 
            // rdoBlue2
            // 
            rdoBlue2.AutoSize = true;
            rdoBlue2.Location = new Point(121, 116);
            rdoBlue2.Name = "rdoBlue2";
            rdoBlue2.Size = new Size(70, 29);
            rdoBlue2.TabIndex = 11;
            rdoBlue2.Text = "Blue";
            rdoBlue2.UseVisualStyleBackColor = true;
            // 
            // rdoYellow2
            // 
            rdoYellow2.AutoSize = true;
            rdoYellow2.Location = new Point(121, 182);
            rdoYellow2.Name = "rdoYellow2";
            rdoYellow2.Size = new Size(86, 29);
            rdoYellow2.TabIndex = 9;
            rdoYellow2.Text = "Yellow";
            rdoYellow2.UseVisualStyleBackColor = true;
            // 
            // rdoRed2
            // 
            rdoRed2.AutoSize = true;
            rdoRed2.Location = new Point(124, 56);
            rdoRed2.Name = "rdoRed2";
            rdoRed2.Size = new Size(67, 29);
            rdoRed2.TabIndex = 10;
            rdoRed2.Text = "Red";
            rdoRed2.UseVisualStyleBackColor = true;
            // 
            // MixButton
            // 
            MixButton.Location = new Point(325, 357);
            MixButton.Name = "MixButton";
            MixButton.Size = new Size(132, 43);
            MixButton.TabIndex = 13;
            MixButton.Text = "Mix";
            MixButton.UseVisualStyleBackColor = true;
            MixButton.Click += MixButton_Click;
            // 
            // ColorMix
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MixButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ColorMix";
            Text = "ColorMix";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rdoBlue1;
        private RadioButton rdoYellow1;
        private RadioButton rdoRed1;
        private GroupBox groupBox2;
        private RadioButton rdoBlue2;
        private RadioButton rdoYellow2;
        private RadioButton rdoRed2;
        private Button MixButton;
    }
}