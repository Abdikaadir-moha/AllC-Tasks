namespace AllC_Tasks.Ex_Ch2
{
    partial class multiple_Button_controls
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
            FirstBtn = new Button();
            SecondBtn = new Button();
            ThirdBtn = new Button();
            SuspendLayout();
            // 
            // FirstBtn
            // 
            FirstBtn.Location = new Point(247, 178);
            FirstBtn.Name = "FirstBtn";
            FirstBtn.Size = new Size(160, 52);
            FirstBtn.TabIndex = 0;
            FirstBtn.Text = "First Button";
            FirstBtn.UseVisualStyleBackColor = true;
            FirstBtn.Click += FirstBtn_Click;
            // 
            // SecondBtn
            // 
            SecondBtn.Location = new Point(423, 178);
            SecondBtn.Name = "SecondBtn";
            SecondBtn.Size = new Size(160, 52);
            SecondBtn.TabIndex = 1;
            SecondBtn.Text = "Second Button";
            SecondBtn.UseVisualStyleBackColor = true;
            SecondBtn.Click += SecondBtn_Click;
            // 
            // ThirdBtn
            // 
            ThirdBtn.Location = new Point(591, 178);
            ThirdBtn.Name = "ThirdBtn";
            ThirdBtn.Size = new Size(160, 52);
            ThirdBtn.TabIndex = 2;
            ThirdBtn.Text = "Third button";
            ThirdBtn.UseVisualStyleBackColor = true;
            ThirdBtn.Click += ThirdBtn_Click;
            // 
            // multiple_Button_controls
            // 
            AutoScaleDimensions = new SizeF(12F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(987, 450);
            Controls.Add(ThirdBtn);
            Controls.Add(SecondBtn);
            Controls.Add(FirstBtn);
            Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "multiple_Button_controls";
            Text = "multiple_Button_controls";
            ResumeLayout(false);
        }

        #endregion

        private Button FirstBtn;
        private Button SecondBtn;
        private Button ThirdBtn;
    }
}