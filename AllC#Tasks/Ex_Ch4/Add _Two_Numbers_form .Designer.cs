namespace AllC_Tasks.Ex_Ch4
{
    partial class Add__Two_Numbers_form
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
            AddButton = new Button();
            firstTextBox = new TextBox();
            label1 = new Label();
            secondTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.ForeColor = Color.Black;
            AddButton.Location = new Point(194, 318);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(149, 51);
            AddButton.TabIndex = 2;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // firstTextBox
            // 
            firstTextBox.Location = new Point(179, 163);
            firstTextBox.Name = "firstTextBox";
            firstTextBox.Size = new Size(175, 32);
            firstTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 72);
            label1.Name = "label1";
            label1.Size = new Size(279, 50);
            label1.TabIndex = 8;
            label1.Text = "Enter Two Numbers \r\n(Integers Only Please)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // secondTextBox
            // 
            secondTextBox.Location = new Point(179, 221);
            secondTextBox.Name = "secondTextBox";
            secondTextBox.Size = new Size(175, 32);
            secondTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(91, 163);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 10;
            label2.Text = "First:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(59, 221);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 11;
            label3.Text = "Second:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Add__Two_Numbers_form
            // 
            AutoScaleDimensions = new SizeF(14F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(532, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(secondTextBox);
            Controls.Add(AddButton);
            Controls.Add(firstTextBox);
            Controls.Add(label1);
            Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            ForeColor = Color.White;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Add__Two_Numbers_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add__Two_Numbers_form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddButton;
        private TextBox firstTextBox;
        private Label label1;
        private TextBox secondTextBox;
        private Label label2;
        private Label label3;
    }
}