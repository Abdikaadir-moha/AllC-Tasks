namespace AllC_Tasks
{
    partial class Tip_Tax_Total
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
            label1 = new Label();
            FoodChargetextBox = new TextBox();
            label3 = new Label();
            Clearbutton = new Button();
            label2 = new Label();
            taxLabel = new Label();
            label5 = new Label();
            tipLabel = new Label();
            Totallabel = new Label();
            SuspendLayout();
            // 
            // Calculatebutton
            // 
            Calculatebutton.BackColor = Color.SkyBlue;
            Calculatebutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Calculatebutton.ForeColor = Color.Black;
            Calculatebutton.Location = new Point(235, 334);
            Calculatebutton.Name = "Calculatebutton";
            Calculatebutton.Size = new Size(132, 53);
            Calculatebutton.TabIndex = 0;
            Calculatebutton.Text = "Calculate";
            Calculatebutton.UseVisualStyleBackColor = false;
            Calculatebutton.Click += Calculatebutton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(160, 87);
            label1.Name = "label1";
            label1.Size = new Size(164, 23);
            label1.TabIndex = 1;
            label1.Text = "Enter Food Charge:";
            // 
            // FoodChargetextBox
            // 
            FoodChargetextBox.Location = new Point(342, 87);
            FoodChargetextBox.Name = "FoodChargetextBox";
            FoodChargetextBox.Size = new Size(125, 27);
            FoodChargetextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(254, 253);
            label3.Name = "label3";
            label3.Size = new Size(54, 23);
            label3.TabIndex = 4;
            label3.Text = "Total:";
            // 
            // Clearbutton
            // 
            Clearbutton.BackColor = Color.LightCyan;
            Clearbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Clearbutton.ForeColor = Color.Black;
            Clearbutton.Location = new Point(386, 334);
            Clearbutton.Name = "Clearbutton";
            Clearbutton.Size = new Size(132, 53);
            Clearbutton.TabIndex = 5;
            Clearbutton.Text = "Clear";
            Clearbutton.UseVisualStyleBackColor = false;
            Clearbutton.Click += Clearbutton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(254, 205);
            label2.Name = "label2";
            label2.Size = new Size(42, 23);
            label2.TabIndex = 7;
            label2.Text = "Tax:";
            // 
            // taxLabel
            // 
            taxLabel.BackColor = Color.Turquoise;
            taxLabel.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taxLabel.Location = new Point(323, 205);
            taxLabel.Name = "taxLabel";
            taxLabel.Size = new Size(168, 30);
            taxLabel.TabIndex = 6;
            taxLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(254, 155);
            label5.Name = "label5";
            label5.Size = new Size(41, 23);
            label5.TabIndex = 9;
            label5.Text = "Tip:";
            // 
            // tipLabel
            // 
            tipLabel.BackColor = Color.MediumAquamarine;
            tipLabel.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tipLabel.Location = new Point(323, 155);
            tipLabel.Name = "tipLabel";
            tipLabel.Size = new Size(168, 30);
            tipLabel.TabIndex = 8;
            tipLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Totallabel
            // 
            Totallabel.BackColor = Color.PaleTurquoise;
            Totallabel.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Totallabel.Location = new Point(323, 253);
            Totallabel.Name = "Totallabel";
            Totallabel.Size = new Size(168, 30);
            Totallabel.TabIndex = 10;
            Totallabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Tip_Tax_Total
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(Totallabel);
            Controls.Add(label5);
            Controls.Add(tipLabel);
            Controls.Add(label2);
            Controls.Add(taxLabel);
            Controls.Add(Clearbutton);
            Controls.Add(label3);
            Controls.Add(FoodChargetextBox);
            Controls.Add(label1);
            Controls.Add(Calculatebutton);
            Name = "Tip_Tax_Total";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tip_Tax_Total";
            Load += Tip_Tax_Total_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Calculatebutton;
        private Label label1;
        private TextBox FoodChargetextBox;
        private Label label3;
        private Button Clearbutton;
        private Label label2;
        private Label taxLabel;
        private Label label5;
        private Label tipLabel;
        private Label Totallabel;
    }
}