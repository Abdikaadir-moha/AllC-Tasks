namespace AllC_Tasks.Ex_Ch4
{
    partial class CheckBoxProg
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
            label1 = new Label();
            pepperoniCheckBox = new CheckBox();
            cheeseCheckBox = new CheckBox();
            anchoviesCheckBox = new CheckBox();
            OkButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 44);
            label1.Name = "label1";
            label1.Size = new Size(336, 25);
            label1.TabIndex = 0;
            label1.Text = "Select Your Pizza Toppings:";
            // 
            // pepperoniCheckBox
            // 
            pepperoniCheckBox.AutoSize = true;
            pepperoniCheckBox.Location = new Point(128, 112);
            pepperoniCheckBox.Name = "pepperoniCheckBox";
            pepperoniCheckBox.Size = new Size(157, 29);
            pepperoniCheckBox.TabIndex = 1;
            pepperoniCheckBox.Text = "Pepperoni";
            pepperoniCheckBox.UseVisualStyleBackColor = true;
            // 
            // cheeseCheckBox
            // 
            cheeseCheckBox.AutoSize = true;
            cheeseCheckBox.Location = new Point(128, 171);
            cheeseCheckBox.Name = "cheeseCheckBox";
            cheeseCheckBox.Size = new Size(122, 29);
            cheeseCheckBox.TabIndex = 2;
            cheeseCheckBox.Text = "Cheese";
            cheeseCheckBox.UseVisualStyleBackColor = true;
            // 
            // anchoviesCheckBox
            // 
            anchoviesCheckBox.AutoSize = true;
            anchoviesCheckBox.Location = new Point(128, 225);
            anchoviesCheckBox.Name = "anchoviesCheckBox";
            anchoviesCheckBox.Size = new Size(157, 29);
            anchoviesCheckBox.TabIndex = 3;
            anchoviesCheckBox.Text = "Anchovies";
            anchoviesCheckBox.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            OkButton.ForeColor = Color.Black;
            OkButton.Location = new Point(184, 334);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(112, 34);
            OkButton.TabIndex = 5;
            OkButton.Text = "Ok";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // CheckBoxProg
            // 
            AutoScaleDimensions = new SizeF(14F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(526, 450);
            Controls.Add(OkButton);
            Controls.Add(anchoviesCheckBox);
            Controls.Add(cheeseCheckBox);
            Controls.Add(pepperoniCheckBox);
            Controls.Add(label1);
            Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            ForeColor = Color.White;
            Margin = new Padding(4, 3, 4, 3);
            Name = "CheckBoxProg";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckBoxProg";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox pepperoniCheckBox;
        private CheckBox cheeseCheckBox;
        private CheckBox anchoviesCheckBox;
        private Button OkButton;
    }
}