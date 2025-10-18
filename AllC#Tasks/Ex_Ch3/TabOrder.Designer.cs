namespace Wholeproject
{
    partial class TabOrder
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            nametextBox = new TextBox();
            addresstextBox = new TextBox();
            citytextBox = new TextBox();
            ziptextBox = new TextBox();
            statetextBox = new TextBox();
            clearbutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(171, 46);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 5;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(149, 87);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 6;
            label2.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(188, 134);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 7;
            label3.Text = "City:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(175, 177);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 8;
            label4.Text = "State:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(195, 221);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 9;
            label5.Text = "Zip:";
            // 
            // nametextBox
            // 
            nametextBox.Location = new Point(273, 46);
            nametextBox.Margin = new Padding(3, 2, 3, 2);
            nametextBox.Name = "nametextBox";
            nametextBox.Size = new Size(180, 28);
            nametextBox.TabIndex = 0;
            // 
            // addresstextBox
            // 
            addresstextBox.Location = new Point(273, 87);
            addresstextBox.Margin = new Padding(3, 2, 3, 2);
            addresstextBox.Name = "addresstextBox";
            addresstextBox.Size = new Size(180, 28);
            addresstextBox.TabIndex = 1;
            // 
            // citytextBox
            // 
            citytextBox.Location = new Point(273, 131);
            citytextBox.Margin = new Padding(3, 2, 3, 2);
            citytextBox.Name = "citytextBox";
            citytextBox.Size = new Size(180, 28);
            citytextBox.TabIndex = 2;
            // 
            // ziptextBox
            // 
            ziptextBox.Location = new Point(273, 218);
            ziptextBox.Margin = new Padding(3, 2, 3, 2);
            ziptextBox.Name = "ziptextBox";
            ziptextBox.Size = new Size(180, 28);
            ziptextBox.TabIndex = 4;
            // 
            // statetextBox
            // 
            statetextBox.Location = new Point(273, 174);
            statetextBox.Margin = new Padding(3, 2, 3, 2);
            statetextBox.Name = "statetextBox";
            statetextBox.Size = new Size(180, 28);
            statetextBox.TabIndex = 3;
            // 
            // clearbutton
            // 
            clearbutton.Location = new Point(286, 282);
            clearbutton.Margin = new Padding(3, 2, 3, 2);
            clearbutton.Name = "clearbutton";
            clearbutton.Size = new Size(147, 50);
            clearbutton.TabIndex = 10;
            clearbutton.Text = "&Clear";
            clearbutton.UseVisualStyleBackColor = true;
            clearbutton.Click += clearbutton_Click;
            // 
            // TabOrder
            // 
            AutoScaleDimensions = new SizeF(12F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(753, 360);
            Controls.Add(clearbutton);
            Controls.Add(statetextBox);
            Controls.Add(ziptextBox);
            Controls.Add(citytextBox);
            Controls.Add(addresstextBox);
            Controls.Add(nametextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TabOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TabOrder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox nametextBox;
        private TextBox addresstextBox;
        private TextBox citytextBox;
        private TextBox ziptextBox;
        private TextBox statetextBox;
        private Button clearbutton;
    }
}