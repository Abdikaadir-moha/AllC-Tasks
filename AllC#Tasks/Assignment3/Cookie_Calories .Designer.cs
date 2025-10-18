namespace AllC_Tasks
{
    partial class Cookie_Calories
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
            Calculatebutton = new Button();
            Resultlabel = new Label();
            CookiestextBox = new TextBox();
            Weightlabel = new Label();
            Resultlable = new Label();
            SuspendLayout();
            // 
            // Calculatebutton
            // 
            Calculatebutton.Location = new Point(308, 303);
            Calculatebutton.Margin = new Padding(2);
            Calculatebutton.Name = "Calculatebutton";
            Calculatebutton.Size = new Size(134, 50);
            Calculatebutton.TabIndex = 1;
            Calculatebutton.Text = "show colories";
            Calculatebutton.UseVisualStyleBackColor = true;
            Calculatebutton.Click += Calculatebutton_Click;
            // 
            // Resultlabel
            // 
            Resultlabel.BackColor = Color.LightCyan;
            Resultlabel.BorderStyle = BorderStyle.FixedSingle;
            Resultlabel.Location = new Point(241, 198);
            Resultlabel.Margin = new Padding(2, 0, 2, 0);
            Resultlabel.Name = "Resultlabel";
            Resultlabel.Size = new Size(223, 39);
            Resultlabel.TabIndex = 37;
            // 
            // CookiestextBox
            // 
            CookiestextBox.Location = new Point(395, 81);
            CookiestextBox.Margin = new Padding(2);
            CookiestextBox.Name = "CookiestextBox";
            CookiestextBox.Size = new Size(121, 28);
            CookiestextBox.TabIndex = 0;
            // 
            // Weightlabel
            // 
            Weightlabel.AutoSize = true;
            Weightlabel.ForeColor = Color.White;
            Weightlabel.Location = new Point(29, 84);
            Weightlabel.Margin = new Padding(2, 0, 2, 0);
            Weightlabel.Name = "Weightlabel";
            Weightlabel.Size = new Size(349, 20);
            Weightlabel.TabIndex = 34;
            Weightlabel.Text = "Enter number of cookies you eaten:";
            // 
            // Resultlable
            // 
            Resultlable.AutoSize = true;
            Resultlable.ForeColor = Color.White;
            Resultlable.Location = new Point(136, 204);
            Resultlable.Margin = new Padding(2, 0, 2, 0);
            Resultlable.Name = "Resultlable";
            Resultlable.Size = new Size(76, 20);
            Resultlable.TabIndex = 39;
            Resultlable.Text = "Result:";
            // 
            // Cookie_Calories
            // 
            AutoScaleDimensions = new SizeF(12F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(704, 450);
            Controls.Add(Resultlable);
            Controls.Add(Calculatebutton);
            Controls.Add(Resultlabel);
            Controls.Add(CookiestextBox);
            Controls.Add(Weightlabel);
            Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Cookie_Calories";
            Text = "Cookie_Calories";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Calculatebutton;
        private Label Resultlabel;
        private TextBox CookiestextBox;
        private Label Weightlabel;
        private Label Resultlable;
    }
}