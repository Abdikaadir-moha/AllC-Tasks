
namespace Wholeproject
{
    partial class String_Variable_Demo
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
            showNameButton = new Button();
            label2 = new Label();
            label1 = new Label();
            fullNamelabel = new Label();
            firstNametextBox = new TextBox();
            label3 = new Label();
            lastNametextBox = new TextBox();
            SuspendLayout();
            // 
            // showNameButton
            // 
            showNameButton.BackColor = Color.LightSalmon;
            showNameButton.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showNameButton.ForeColor = Color.Black;
            showNameButton.Location = new Point(312, 310);
            showNameButton.Margin = new Padding(2);
            showNameButton.Name = "showNameButton";
            showNameButton.Size = new Size(179, 54);
            showNameButton.TabIndex = 2;
            showNameButton.Text = "Show Name";
            showNameButton.UseVisualStyleBackColor = false;
            showNameButton.Click += showNameButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 226);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(193, 25);
            label2.TabIndex = 9;
            label2.Text = "This is your full name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 109);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(192, 25);
            label1.TabIndex = 8;
            label1.Text = "Enter your first name:";
            // 
            // fullNamelabel
            // 
            fullNamelabel.BackColor = Color.Wheat;
            fullNamelabel.BorderStyle = BorderStyle.FixedSingle;
            fullNamelabel.Location = new Point(289, 222);
            fullNamelabel.Margin = new Padding(2, 0, 2, 0);
            fullNamelabel.Name = "fullNamelabel";
            fullNamelabel.Size = new Size(324, 38);
            fullNamelabel.TabIndex = 7;
            fullNamelabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // firstNametextBox
            // 
            firstNametextBox.Location = new Point(336, 109);
            firstNametextBox.Margin = new Padding(2);
            firstNametextBox.Name = "firstNametextBox";
            firstNametextBox.Size = new Size(168, 31);
            firstNametextBox.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(139, 158);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(188, 25);
            label3.TabIndex = 13;
            label3.Text = "Enter your last name:";
            // 
            // lastNametextBox
            // 
            lastNametextBox.Location = new Point(336, 158);
            lastNametextBox.Margin = new Padding(2);
            lastNametextBox.Name = "lastNametextBox";
            lastNametextBox.Size = new Size(168, 31);
            lastNametextBox.TabIndex = 1;
            // 
            // String_Variable_Demo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(lastNametextBox);
            Controls.Add(showNameButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(fullNamelabel);
            Controls.Add(firstNametextBox);
            Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Margin = new Padding(2);
            Name = "String_Variable_Demo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StringVariableDemo";
            Load += String_Variable_Demo_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion
        private Button showNameButton;
        private Label label2;
        private Label label1;
        private Label fullNamelabel;
        private TextBox firstNametextBox;
        private Label label3;
        private TextBox lastNametextBox;
    }
}