namespace Wholeproject
{
    partial class NumbersFile
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
            groupBox2 = new GroupBox();
            nameTextBox = new TextBox();
            clearbutton = new Button();
            Writenumberbutton = new Button();
            Exitbutton = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(nameTextBox);
            groupBox2.Controls.Add(clearbutton);
            groupBox2.Controls.Add(Writenumberbutton);
            groupBox2.Controls.Add(Exitbutton);
            groupBox2.Location = new Point(173, 80);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(455, 291);
            groupBox2.TabIndex = 93;
            groupBox2.TabStop = false;
            groupBox2.Text = "Number File";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(120, 108);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(216, 31);
            nameTextBox.TabIndex = 85;
            // 
            // clearbutton
            // 
            clearbutton.BackColor = Color.DarkCyan;
            clearbutton.Location = new Point(158, 202);
            clearbutton.Name = "clearbutton";
            clearbutton.Size = new Size(134, 66);
            clearbutton.TabIndex = 84;
            clearbutton.Text = "Clear";
            clearbutton.UseVisualStyleBackColor = false;
            // 
            // Writenumberbutton
            // 
            Writenumberbutton.BackColor = Color.Cornsilk;
            Writenumberbutton.Location = new Point(18, 202);
            Writenumberbutton.Name = "Writenumberbutton";
            Writenumberbutton.Size = new Size(134, 66);
            Writenumberbutton.TabIndex = 81;
            Writenumberbutton.Text = "Write Number";
            Writenumberbutton.UseVisualStyleBackColor = false;
            Writenumberbutton.Click += Writenumberbutton_Click;
            // 
            // Exitbutton
            // 
            Exitbutton.BackColor = Color.Crimson;
            Exitbutton.Location = new Point(298, 202);
            Exitbutton.Name = "Exitbutton";
            Exitbutton.Size = new Size(134, 66);
            Exitbutton.TabIndex = 80;
            Exitbutton.Text = "Exit";
            Exitbutton.UseVisualStyleBackColor = false;
            // 
            // NumbersFile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Name = "NumbersFile";
            Text = "NumbersFile";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox nameTextBox;
        private Button clearbutton;
        private Button Writenumberbutton;
        private Button Exitbutton;
    }
}