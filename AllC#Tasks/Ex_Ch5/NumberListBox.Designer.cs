namespace Wholeproject
{
    partial class NumberListBox
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
            numbersListBox = new ListBox();
            Exitbutton = new Button();
            Clearsbutton = new Button();
            addButton = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numbersListBox);
            groupBox2.Controls.Add(Exitbutton);
            groupBox2.Controls.Add(Clearsbutton);
            groupBox2.Controls.Add(addButton);
            groupBox2.Location = new Point(173, 40);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(455, 370);
            groupBox2.TabIndex = 87;
            groupBox2.TabStop = false;
            groupBox2.Text = "Number List";
            // 
            // numbersListBox
            // 
            numbersListBox.FormattingEnabled = true;
            numbersListBox.ItemHeight = 25;
            numbersListBox.Location = new Point(38, 45);
            numbersListBox.Name = "numbersListBox";
            numbersListBox.Size = new Size(393, 179);
            numbersListBox.TabIndex = 81;
            // 
            // Exitbutton
            // 
            Exitbutton.BackColor = Color.Crimson;
            Exitbutton.Location = new Point(319, 244);
            Exitbutton.Name = "Exitbutton";
            Exitbutton.Size = new Size(112, 66);
            Exitbutton.TabIndex = 80;
            Exitbutton.Text = "Exit";
            Exitbutton.UseVisualStyleBackColor = false;
            Exitbutton.Click += Exitbutton_Click;
            // 
            // Clearsbutton
            // 
            Clearsbutton.BackColor = Color.CornflowerBlue;
            Clearsbutton.Location = new Point(182, 244);
            Clearsbutton.Name = "Clearsbutton";
            Clearsbutton.Size = new Size(112, 66);
            Clearsbutton.TabIndex = 79;
            Clearsbutton.Text = "Clear";
            Clearsbutton.UseVisualStyleBackColor = false;
            Clearsbutton.Click += Clearsbutton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.Coral;
            addButton.Location = new Point(38, 244);
            addButton.Name = "addButton";
            addButton.Size = new Size(134, 66);
            addButton.TabIndex = 78;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // NumberListBox
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Name = "NumberListBox";
            Text = "NumberListBox";
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private ListBox numbersListBox;
        private Button Exitbutton;
        private Button Clearsbutton;
        private Button addButton;
    }
}