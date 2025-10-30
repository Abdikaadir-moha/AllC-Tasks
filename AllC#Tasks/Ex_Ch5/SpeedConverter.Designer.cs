namespace Wholeproject
{
    partial class SpeedConverter
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
            clearbutton = new Button();
            outputListBox = new ListBox();
            displaybutton = new Button();
            Exitbutton = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(clearbutton);
            groupBox2.Controls.Add(outputListBox);
            groupBox2.Controls.Add(displaybutton);
            groupBox2.Controls.Add(Exitbutton);
            groupBox2.Location = new Point(173, 40);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(455, 370);
            groupBox2.TabIndex = 91;
            groupBox2.TabStop = false;
            groupBox2.Text = "Spee Converter";
            // 
            // clearbutton
            // 
            clearbutton.BackColor = Color.DarkCyan;
            clearbutton.Location = new Point(23, 286);
            clearbutton.Name = "clearbutton";
            clearbutton.Size = new Size(134, 66);
            clearbutton.TabIndex = 84;
            clearbutton.Text = "Clear";
            clearbutton.UseVisualStyleBackColor = false;
            clearbutton.Click += clearbutton_Click;
            // 
            // outputListBox
            // 
            outputListBox.FormattingEnabled = true;
            outputListBox.ItemHeight = 25;
            outputListBox.Location = new Point(23, 41);
            outputListBox.Name = "outputListBox";
            outputListBox.Size = new Size(414, 229);
            outputListBox.TabIndex = 82;
            // 
            // displaybutton
            // 
            displaybutton.BackColor = Color.Cornsilk;
            displaybutton.Location = new Point(303, 286);
            displaybutton.Name = "displaybutton";
            displaybutton.Size = new Size(134, 66);
            displaybutton.TabIndex = 81;
            displaybutton.Text = "Display Speeds";
            displaybutton.UseVisualStyleBackColor = false;
            displaybutton.Click += displaybutton_Click;
            // 
            // Exitbutton
            // 
            Exitbutton.BackColor = Color.Crimson;
            Exitbutton.Location = new Point(163, 286);
            Exitbutton.Name = "Exitbutton";
            Exitbutton.Size = new Size(134, 66);
            Exitbutton.TabIndex = 80;
            Exitbutton.Text = "Exit";
            Exitbutton.UseVisualStyleBackColor = false;
            Exitbutton.Click += Exitbutton_Click;
            // 
            // SpeedConverter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Name = "SpeedConverter";
            Text = "SpeedConverter";
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private ListBox outputListBox;
        private Button displaybutton;
        private Button Exitbutton;
        private Button clearbutton;
    }
}