namespace AllC_Tasks.Ex_Ch5
{
    partial class NumberListApp
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
            ExitButton = new Button();
            WriteNameButton = new Button();
            nameTextBox = new TextBox();
            label1 = new Label();
            DataListBox = new ListBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.Location = new Point(406, 367);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(137, 52);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            // 
            // WriteNameButton
            // 
            WriteNameButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WriteNameButton.Location = new Point(228, 367);
            WriteNameButton.Name = "WriteNameButton";
            WriteNameButton.Size = new Size(137, 52);
            WriteNameButton.TabIndex = 1;
            WriteNameButton.Text = "Write Name";
            WriteNameButton.UseVisualStyleBackColor = true;
            WriteNameButton.Visible = false;
            WriteNameButton.Click += WriteNameButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(469, 133);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(150, 31);
            nameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(321, 133);
            label1.Name = "label1";
            label1.Size = new Size(132, 28);
            label1.TabIndex = 5;
            label1.Text = "Enter a data:";
            // 
            // DataListBox
            // 
            DataListBox.FormattingEnabled = true;
            DataListBox.ItemHeight = 25;
            DataListBox.Location = new Point(57, 81);
            DataListBox.Name = "DataListBox";
            DataListBox.Size = new Size(215, 204);
            DataListBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(90, 36);
            label2.Name = "label2";
            label2.Size = new Size(122, 28);
            label2.TabIndex = 4;
            label2.Text = "Stored data";
            // 
            // NumberListApp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(DataListBox);
            Controls.Add(ExitButton);
            Controls.Add(WriteNameButton);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Name = "NumberListApp";
            Text = "NumberListApp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ExitButton;
        private Button WriteNameButton;
        private TextBox nameTextBox;
        private Label label1;
        private ListBox DataListBox;
        private Label label2;
    }
}