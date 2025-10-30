namespace Wholeproject
{
    partial class FriendFile
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
            label1 = new Label();
            nameTextBox = new TextBox();
            clearbutton = new Button();
            Writebutton = new Button();
            Exitbutton = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(nameTextBox);
            groupBox2.Controls.Add(clearbutton);
            groupBox2.Controls.Add(Writebutton);
            groupBox2.Controls.Add(Exitbutton);
            groupBox2.Location = new Point(173, 40);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(455, 291);
            groupBox2.TabIndex = 92;
            groupBox2.TabStop = false;
            groupBox2.Text = "Friend File";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(18, 95);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(188, 25);
            label1.TabIndex = 86;
            label1.Text = "Enter a friend Name:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(216, 95);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(216, 31);
            nameTextBox.TabIndex = 85;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
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
            clearbutton.Click += clearbutton_Click;
            // 
            // Writebutton
            // 
            Writebutton.BackColor = Color.Cornsilk;
            Writebutton.Location = new Point(18, 202);
            Writebutton.Name = "Writebutton";
            Writebutton.Size = new Size(134, 66);
            Writebutton.TabIndex = 81;
            Writebutton.Text = "Write Name";
            Writebutton.UseVisualStyleBackColor = false;
            Writebutton.Click += Writebutton_Click;
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
            Exitbutton.Click += Exitbutton_Click;
            // 
            // FriendFile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Name = "FriendFile";
            Text = "FriendFile";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button clearbutton;
        private Button Writebutton;
        private Button Exitbutton;
        private TextBox nameTextBox;
        private Label label1;
    }
}