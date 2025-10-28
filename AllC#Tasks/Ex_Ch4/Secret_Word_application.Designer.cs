namespace AllC_Tasks.Ex_Ch4
{
    partial class Secret_Word_application
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
            inputTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // CheckButton
            // 
            CheckButton.ForeColor = Color.Black;
            CheckButton.Location = new Point(252, 239);
            CheckButton.Name = "CheckButton";
            CheckButton.Size = new Size(149, 67);
            CheckButton.TabIndex = 4;
            CheckButton.Text = "Check The Word";
            CheckButton.UseVisualStyleBackColor = true;
            CheckButton.Click += CheckButton_Click;
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(238, 129);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(175, 32);
            inputTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(185, 50);
            label1.Name = "label1";
            label1.Size = new Size(281, 25);
            label1.TabIndex = 5;
            label1.Text = "Enter the Secret Word.";
            // 
            // Secret_Word_application
            // 
            AutoScaleDimensions = new SizeF(14F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(655, 345);
            Controls.Add(CheckButton);
            Controls.Add(inputTextBox);
            Controls.Add(label1);
            Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            ForeColor = Color.White;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Secret_Word_application";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Secret_Word_application";
            Load += Secret_Word_application_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CheckButton;
        private TextBox inputTextBox;
        private Label label1;
    }
}