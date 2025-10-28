namespace AllC_Tasks.Ex_Ch3
{
    partial class RadioButtonProg
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
            footballRadioButton = new RadioButton();
            basketballRadioButton = new RadioButton();
            baseballRadioButton = new RadioButton();
            OkButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(170, 46);
            label1.Name = "label1";
            label1.Size = new Size(320, 25);
            label1.TabIndex = 0;
            label1.Text = "Select Your Favorite Sport";
            // 
            // footballRadioButton
            // 
            footballRadioButton.AutoSize = true;
            footballRadioButton.Location = new Point(202, 118);
            footballRadioButton.Name = "footballRadioButton";
            footballRadioButton.Size = new Size(132, 29);
            footballRadioButton.TabIndex = 1;
            footballRadioButton.TabStop = true;
            footballRadioButton.Text = "Football";
            footballRadioButton.UseVisualStyleBackColor = true;
            // 
            // basketballRadioButton
            // 
            basketballRadioButton.AutoSize = true;
            basketballRadioButton.Location = new Point(202, 182);
            basketballRadioButton.Name = "basketballRadioButton";
            basketballRadioButton.Size = new Size(160, 29);
            basketballRadioButton.TabIndex = 2;
            basketballRadioButton.TabStop = true;
            basketballRadioButton.Text = "Basketball";
            basketballRadioButton.UseVisualStyleBackColor = true;
            // 
            // baseballRadioButton
            // 
            baseballRadioButton.AutoSize = true;
            baseballRadioButton.Location = new Point(202, 248);
            baseballRadioButton.Name = "baseballRadioButton";
            baseballRadioButton.Size = new Size(136, 29);
            baseballRadioButton.TabIndex = 3;
            baseballRadioButton.TabStop = true;
            baseballRadioButton.Text = "Baseball";
            baseballRadioButton.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            OkButton.ForeColor = Color.Black;
            OkButton.Location = new Point(226, 354);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(112, 34);
            OkButton.TabIndex = 4;
            OkButton.Text = "Ok";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // RadioButtonProg
            // 
            AutoScaleDimensions = new SizeF(14F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(624, 450);
            Controls.Add(OkButton);
            Controls.Add(baseballRadioButton);
            Controls.Add(basketballRadioButton);
            Controls.Add(footballRadioButton);
            Controls.Add(label1);
            Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            ForeColor = Color.White;
            Margin = new Padding(4, 3, 4, 3);
            Name = "RadioButtonProg";
            Text = "RadioButtonProg";
            Load += RadioButtonProg_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton footballRadioButton;
        private RadioButton basketballRadioButton;
        private RadioButton baseballRadioButton;
        private Button OkButton;
    }
}