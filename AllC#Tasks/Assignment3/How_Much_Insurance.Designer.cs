namespace AllC_Tasks
{
    partial class How_Much_Insurance
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
            Resultlable = new Label();
            RepCostTextBox = new TextBox();
            Weightlabel = new Label();
            SuspendLayout();
            // 
            // Calculatebutton
            // 
            Calculatebutton.BackColor = Color.LightGoldenrodYellow;
            Calculatebutton.Location = new Point(208, 326);
            Calculatebutton.Margin = new Padding(2);
            Calculatebutton.Name = "Calculatebutton";
            Calculatebutton.Size = new Size(153, 50);
            Calculatebutton.TabIndex = 1;
            Calculatebutton.Text = "Calculate Insurance";
            Calculatebutton.UseVisualStyleBackColor = false;
            Calculatebutton.Click += Calculatebutton_Click_1;
            // 
            // Resultlabel
            // 
            Resultlabel.BackColor = Color.PowderBlue;
            Resultlabel.BorderStyle = BorderStyle.FixedSingle;
            Resultlabel.Location = new Point(231, 224);
            Resultlabel.Margin = new Padding(2, 0, 2, 0);
            Resultlabel.Name = "Resultlabel";
            Resultlabel.Size = new Size(155, 35);
            Resultlabel.TabIndex = 38;
            // 
            // Resultlable
            // 
            Resultlable.AutoSize = true;
            Resultlable.ForeColor = Color.White;
            Resultlable.Location = new Point(139, 231);
            Resultlable.Margin = new Padding(2, 0, 2, 0);
            Resultlable.Name = "Resultlable";
            Resultlable.Size = new Size(76, 20);
            Resultlable.TabIndex = 37;
            Resultlable.Text = "Result:";
            // 
            // RepCostTextBox
            // 
            RepCostTextBox.Location = new Point(288, 109);
            RepCostTextBox.Margin = new Padding(2);
            RepCostTextBox.Name = "RepCostTextBox";
            RepCostTextBox.Size = new Size(121, 28);
            RepCostTextBox.TabIndex = 0;
            // 
            // Weightlabel
            // 
            Weightlabel.AutoSize = true;
            Weightlabel.ForeColor = Color.White;
            Weightlabel.Location = new Point(36, 112);
            Weightlabel.Margin = new Padding(2, 0, 2, 0);
            Weightlabel.Name = "Weightlabel";
            Weightlabel.Size = new Size(237, 20);
            Weightlabel.TabIndex = 35;
            Weightlabel.Text = "Enter Replacement Cost";
            // 
            // How_Much_Insurance
            // 
            AutoScaleDimensions = new SizeF(12F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(560, 450);
            Controls.Add(Calculatebutton);
            Controls.Add(Resultlabel);
            Controls.Add(Resultlable);
            Controls.Add(RepCostTextBox);
            Controls.Add(Weightlabel);
            Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "How_Much_Insurance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "How_Much_Insurance";
            Load += How_Much_Insurance_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Calculatebutton;
        private Label Resultlabel;
        private Label Resultlable;
        private TextBox RepCostTextBox;
        private Label Weightlabel;
    }
}