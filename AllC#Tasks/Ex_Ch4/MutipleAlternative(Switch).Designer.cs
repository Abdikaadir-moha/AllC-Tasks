namespace AllC_Tasks.Ex_Ch4
{
    partial class MutipleAlternative_Switch_
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
            CheckButton = new Button();
            monthTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // CheckButton
            // 
            CheckButton.ForeColor = Color.Black;
            CheckButton.Location = new Point(211, 243);
            CheckButton.Margin = new Padding(4, 3, 4, 3);
            CheckButton.Name = "CheckButton";
            CheckButton.Size = new Size(184, 58);
            CheckButton.TabIndex = 1;
            CheckButton.Text = "Show Month";
            CheckButton.UseVisualStyleBackColor = true;
            CheckButton.Click += CheckButton_Click;
            // 
            // monthTextBox
            // 
            monthTextBox.Location = new Point(189, 128);
            monthTextBox.Margin = new Padding(4, 3, 4, 3);
            monthTextBox.Name = "monthTextBox";
            monthTextBox.Size = new Size(243, 32);
            monthTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(374, 25);
            label1.TabIndex = 2;
            label1.Text = "Enter a month number (1–12):";
            // 
            // MutipleAlternative_Switch_
            // 
            AutoScaleDimensions = new SizeF(14F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(635, 348);
            Controls.Add(CheckButton);
            Controls.Add(monthTextBox);
            Controls.Add(label1);
            Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            ForeColor = Color.White;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MutipleAlternative_Switch_";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MutipleAlternative_Switch_";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CheckButton;
        private TextBox monthTextBox;
        private Label label1;
    }
}