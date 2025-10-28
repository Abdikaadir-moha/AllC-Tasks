namespace AllC_Tasks.Ex_Ch4
{
    partial class Color_Theme_Application
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
            WhiteRadioButton = new RadioButton();
            RedRadioButton = new RadioButton();
            YellowRadioButton = new RadioButton();
            groupBox1 = new GroupBox();
            NormalRadioButton = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // WhiteRadioButton
            // 
            WhiteRadioButton.AutoSize = true;
            WhiteRadioButton.Location = new Point(129, 193);
            WhiteRadioButton.Name = "WhiteRadioButton";
            WhiteRadioButton.Size = new Size(107, 29);
            WhiteRadioButton.TabIndex = 8;
            WhiteRadioButton.Text = "White";
            WhiteRadioButton.UseVisualStyleBackColor = true;
            WhiteRadioButton.CheckedChanged += WhiteRadioButton_CheckedChanged;
            // 
            // RedRadioButton
            // 
            RedRadioButton.AutoSize = true;
            RedRadioButton.Location = new Point(129, 127);
            RedRadioButton.Name = "RedRadioButton";
            RedRadioButton.Size = new Size(82, 29);
            RedRadioButton.TabIndex = 7;
            RedRadioButton.Text = "Red";
            RedRadioButton.UseVisualStyleBackColor = true;
            RedRadioButton.CheckedChanged += RedRadioButton_CheckedChanged;
            // 
            // YellowRadioButton
            // 
            YellowRadioButton.AutoSize = true;
            YellowRadioButton.Location = new Point(129, 67);
            YellowRadioButton.Name = "YellowRadioButton";
            YellowRadioButton.Size = new Size(115, 29);
            YellowRadioButton.TabIndex = 6;
            YellowRadioButton.Text = "Yellow";
            YellowRadioButton.UseVisualStyleBackColor = true;
            YellowRadioButton.CheckedChanged += YellowRadioButton_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(NormalRadioButton);
            groupBox1.Controls.Add(WhiteRadioButton);
            groupBox1.Controls.Add(YellowRadioButton);
            groupBox1.Controls.Add(RedRadioButton);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(104, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(463, 335);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = " Select a Background Color:";
            // 
            // NormalRadioButton
            // 
            NormalRadioButton.AutoSize = true;
            NormalRadioButton.Checked = true;
            NormalRadioButton.Location = new Point(129, 260);
            NormalRadioButton.Name = "NormalRadioButton";
            NormalRadioButton.Size = new Size(216, 29);
            NormalRadioButton.TabIndex = 10;
            NormalRadioButton.TabStop = true;
            NormalRadioButton.Text = "Back to Normal";
            NormalRadioButton.UseVisualStyleBackColor = true;
            NormalRadioButton.CheckedChanged += NormalRadioButton_CheckedChanged;
            // 
            // Color_Theme_Application
            // 
            AutoScaleDimensions = new SizeF(14F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(685, 466);
            Controls.Add(groupBox1);
            Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            ForeColor = Color.White;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Color_Theme_Application";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Color_Theme_Application";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private RadioButton WhiteRadioButton;
        private RadioButton RedRadioButton;
        private RadioButton YellowRadioButton;
        private GroupBox groupBox1;
        private RadioButton NormalRadioButton;
    }
}