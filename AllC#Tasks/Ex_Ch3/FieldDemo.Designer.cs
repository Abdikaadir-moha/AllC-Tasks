namespace Wholeproject
{
    partial class FieldDemo
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
            ShowNameButton = new Button();
            SiyadButton = new Button();
            OmarButton = new Button();
            SuspendLayout();
            // 
            // ShowNameButton
            // 
            ShowNameButton.BackColor = Color.CadetBlue;
            ShowNameButton.ForeColor = Color.White;
            ShowNameButton.Location = new Point(291, 85);
            ShowNameButton.Margin = new Padding(2);
            ShowNameButton.Name = "ShowNameButton";
            ShowNameButton.Size = new Size(137, 55);
            ShowNameButton.TabIndex = 3;
            ShowNameButton.Text = "Show Name";
            ShowNameButton.UseVisualStyleBackColor = false;
            ShowNameButton.Click += ShowNameButton_Click;
            // 
            // SiyadButton
            // 
            SiyadButton.BackColor = Color.MediumSlateBlue;
            SiyadButton.ForeColor = Color.White;
            SiyadButton.Location = new Point(380, 170);
            SiyadButton.Margin = new Padding(2);
            SiyadButton.Name = "SiyadButton";
            SiyadButton.Size = new Size(143, 68);
            SiyadButton.TabIndex = 5;
            SiyadButton.Text = "Change Name to Siyad";
            SiyadButton.UseVisualStyleBackColor = false;
            SiyadButton.Click += SiyadButton_Click;
            // 
            // OmarButton
            // 
            OmarButton.BackColor = Color.RoyalBlue;
            OmarButton.ForeColor = Color.White;
            OmarButton.Location = new Point(197, 170);
            OmarButton.Margin = new Padding(2);
            OmarButton.Name = "OmarButton";
            OmarButton.Size = new Size(143, 68);
            OmarButton.TabIndex = 4;
            OmarButton.Text = "Change Name to Omar";
            OmarButton.UseVisualStyleBackColor = false;
            OmarButton.Click += OmarButton_Click;
            // 
            // FieldDemo
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(743, 324);
            Controls.Add(SiyadButton);
            Controls.Add(OmarButton);
            Controls.Add(ShowNameButton);
            Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(2);
            Name = "FieldDemo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FieldDemo";
            ResumeLayout(false);
        }

        #endregion
        private Button ShowNameButton;
        private Button SiyadButton;
        private Button OmarButton;
    }
}