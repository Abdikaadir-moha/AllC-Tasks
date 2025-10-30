namespace Wholeproject
{
    partial class InfiniteLoop
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
            gobutton = new Button();
            Exitbutton = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(gobutton);
            groupBox2.Controls.Add(Exitbutton);
            groupBox2.Location = new Point(173, 40);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(455, 370);
            groupBox2.TabIndex = 89;
            groupBox2.TabStop = false;
            groupBox2.Text = "Infinite Loops";
            // 
            // gobutton
            // 
            gobutton.BackColor = Color.Cornsilk;
            gobutton.Location = new Point(154, 99);
            gobutton.Name = "gobutton";
            gobutton.Size = new Size(134, 66);
            gobutton.TabIndex = 81;
            gobutton.Text = "Go";
            gobutton.UseVisualStyleBackColor = false;
            gobutton.Click += gobutton_Click;
            // 
            // Exitbutton
            // 
            Exitbutton.BackColor = Color.Crimson;
            Exitbutton.Location = new Point(154, 245);
            Exitbutton.Name = "Exitbutton";
            Exitbutton.Size = new Size(134, 66);
            Exitbutton.TabIndex = 80;
            Exitbutton.Text = "Exit";
            Exitbutton.UseVisualStyleBackColor = false;
            // 
            // InfiniteLoop
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Name = "InfiniteLoop";
            Text = "InfiniteLoop";
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button gobutton;
        private Button Exitbutton;
    }
}