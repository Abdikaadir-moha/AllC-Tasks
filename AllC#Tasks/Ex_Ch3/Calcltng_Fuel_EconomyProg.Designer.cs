namespace AllC_Tasks
{
    partial class Calcltng_Fuel_EconomyProg2
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
            label5 = new Label();
            BackToMenu = new Button();
            HeaderTitle = new Label();
            Labeldate = new Label();
            label4 = new Label();
            Header = new Label();
            gallonsTextBox = new TextBox();
            label2 = new Label();
            label6 = new Label();
            label1 = new Label();
            outputDescriptionLabel = new Label();
            ClearBtn = new Button();
            milesTextBox = new TextBox();
            CalculateButton = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(360, 510);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(403, 30);
            label5.TabIndex = 50;
            label5.Text = "@ 2025 abdikadir mohamed";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackToMenu
            // 
            BackToMenu.BackColor = Color.MediumBlue;
            BackToMenu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackToMenu.ForeColor = Color.Transparent;
            BackToMenu.Location = new Point(466, 445);
            BackToMenu.Margin = new Padding(4, 3, 4, 3);
            BackToMenu.Name = "BackToMenu";
            BackToMenu.Size = new Size(191, 50);
            BackToMenu.TabIndex = 4;
            BackToMenu.Text = "Back To Main ";
            BackToMenu.UseVisualStyleBackColor = false;
            BackToMenu.Click += BackToMenu_Click;
            // 
            // HeaderTitle
            // 
            HeaderTitle.BackColor = Color.Transparent;
            HeaderTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeaderTitle.ForeColor = Color.White;
            HeaderTitle.Location = new Point(314, -2);
            HeaderTitle.Margin = new Padding(4, 0, 4, 0);
            HeaderTitle.Name = "HeaderTitle";
            HeaderTitle.Size = new Size(500, 60);
            HeaderTitle.TabIndex = 48;
            HeaderTitle.Text = "Calculating Fuel Economy Program";
            HeaderTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Labeldate
            // 
            Labeldate.BackColor = Color.Transparent;
            Labeldate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Labeldate.ForeColor = Color.White;
            Labeldate.Location = new Point(881, 9);
            Labeldate.Margin = new Padding(4, 0, 4, 0);
            Labeldate.Name = "Labeldate";
            Labeldate.RightToLeft = RightToLeft.No;
            Labeldate.Size = new Size(253, 36);
            Labeldate.TabIndex = 47;
            Labeldate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(26, 7);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(187, 44);
            label4.TabIndex = 46;
            label4.Text = "JU FOCOSIT";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Header
            // 
            Header.BackColor = Color.White;
            Header.Location = new Point(-2, -2);
            Header.Margin = new Padding(4, 0, 4, 0);
            Header.Name = "Header";
            Header.Size = new Size(1153, 60);
            Header.TabIndex = 45;
            // 
            // gallonsTextBox
            // 
            gallonsTextBox.ForeColor = Color.Black;
            gallonsTextBox.Location = new Point(575, 182);
            gallonsTextBox.Name = "gallonsTextBox";
            gallonsTextBox.Size = new Size(125, 32);
            gallonsTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(187, 185);
            label2.Name = "label2";
            label2.Size = new Size(368, 25);
            label2.TabIndex = 54;
            label2.Text = " Enter the gallons of gas used:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(140, 127);
            label6.Name = "label6";
            label6.Size = new Size(415, 25);
            label6.TabIndex = 52;
            label6.Text = " Enter the number of miles driven:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(336, 265);
            label1.Name = "label1";
            label1.Size = new Size(202, 25);
            label1.TabIndex = 56;
            label1.Text = " Your car’s MPG:";
            // 
            // outputDescriptionLabel
            // 
            outputDescriptionLabel.BackColor = Color.Beige;
            outputDescriptionLabel.Location = new Point(560, 259);
            outputDescriptionLabel.Name = "outputDescriptionLabel";
            outputDescriptionLabel.Size = new Size(183, 37);
            outputDescriptionLabel.TabIndex = 4;
            outputDescriptionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ClearBtn
            // 
            ClearBtn.BackColor = Color.DarkSlateBlue;
            ClearBtn.ForeColor = Color.White;
            ClearBtn.Location = new Point(573, 350);
            ClearBtn.Margin = new Padding(4, 3, 4, 3);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(170, 65);
            ClearBtn.TabIndex = 3;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = false;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // milesTextBox
            // 
            milesTextBox.ForeColor = Color.Black;
            milesTextBox.Location = new Point(575, 127);
            milesTextBox.Name = "milesTextBox";
            milesTextBox.Size = new Size(125, 32);
            milesTextBox.TabIndex = 0;
            // 
            // CalculateButton
            // 
            CalculateButton.BackColor = Color.DarkSlateBlue;
            CalculateButton.ForeColor = Color.White;
            CalculateButton.Location = new Point(385, 350);
            CalculateButton.Margin = new Padding(4, 3, 4, 3);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(170, 65);
            CalculateButton.TabIndex = 2;
            CalculateButton.Text = "Calculate MPG";
            CalculateButton.UseVisualStyleBackColor = false;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // Calcltng_Fuel_EconomyProg2
            // 
            AutoScaleDimensions = new SizeF(14F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1147, 537);
            Controls.Add(CalculateButton);
            Controls.Add(milesTextBox);
            Controls.Add(ClearBtn);
            Controls.Add(outputDescriptionLabel);
            Controls.Add(gallonsTextBox);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(BackToMenu);
            Controls.Add(HeaderTitle);
            Controls.Add(Labeldate);
            Controls.Add(label4);
            Controls.Add(Header);
            Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Calcltng_Fuel_EconomyProg2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calcltng_Fuel_EconomyProg";
            Load += Calcltng_Fuel_EconomyProg_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Button BackToMenu;
        private Label HeaderTitle;
        private Label Labeldate;
        private Label label4;
        private Label Header;
        private TextBox gallonsTextBox;
        private Label label2;
        private Label label6;
        private Label label1;
        private Label outputDescriptionLabel;
        private Button ClearBtn;
        private TextBox milesTextBox;
        private Button CalculateButton;
    }
}