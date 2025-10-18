namespace AllC_Tasks
{
    partial class Sell_Price_Prog
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
            HeaderTitle = new Label();
            Labeldate = new Label();
            label4 = new Label();
            Header = new Label();
            CalculateButton = new Button();
            ClearBtn = new Button();
            label6 = new Label();
            BackToMenu = new Button();
            originalPriceTextBox = new TextBox();
            outputDescriptionLabel = new Label();
            discountPercentageTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // HeaderTitle
            // 
            HeaderTitle.BackColor = Color.Transparent;
            HeaderTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeaderTitle.ForeColor = Color.White;
            HeaderTitle.Location = new Point(339, -5);
            HeaderTitle.Margin = new Padding(4, 0, 4, 0);
            HeaderTitle.Name = "HeaderTitle";
            HeaderTitle.Size = new Size(407, 60);
            HeaderTitle.TabIndex = 52;
            HeaderTitle.Text = "Sale Price Calculator  Program";
            HeaderTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Labeldate
            // 
            Labeldate.BackColor = Color.Transparent;
            Labeldate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Labeldate.ForeColor = Color.White;
            Labeldate.Location = new Point(895, 9);
            Labeldate.Margin = new Padding(4, 0, 4, 0);
            Labeldate.Name = "Labeldate";
            Labeldate.RightToLeft = RightToLeft.No;
            Labeldate.Size = new Size(242, 36);
            Labeldate.TabIndex = 51;
            Labeldate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(29, 4);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(140, 44);
            label4.TabIndex = 50;
            label4.Text = "JU FOCOSIT";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Header
            // 
            Header.BackColor = Color.White;
            Header.Location = new Point(1, -5);
            Header.Margin = new Padding(4, 0, 4, 0);
            Header.Name = "Header";
            Header.Size = new Size(1153, 60);
            Header.TabIndex = 49;
            // 
            // CalculateButton
            // 
            CalculateButton.BackColor = Color.PowderBlue;
            CalculateButton.ForeColor = Color.Black;
            CalculateButton.Location = new Point(339, 384);
            CalculateButton.Margin = new Padding(4, 3, 4, 3);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(228, 50);
            CalculateButton.TabIndex = 2;
            CalculateButton.Text = "  Calculate Sale Price ";
            CalculateButton.UseVisualStyleBackColor = false;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.BackColor = Color.SkyBlue;
            ClearBtn.ForeColor = Color.Black;
            ClearBtn.Location = new Point(590, 384);
            ClearBtn.Margin = new Padding(4, 3, 4, 3);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(170, 50);
            ClearBtn.TabIndex = 3;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = false;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(377, 530);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(403, 30);
            label6.TabIndex = 64;
            label6.Text = "@ 2025 abdikadir mohamed";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackToMenu
            // 
            BackToMenu.BackColor = Color.MediumBlue;
            BackToMenu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackToMenu.ForeColor = Color.Transparent;
            BackToMenu.Location = new Point(502, 465);
            BackToMenu.Margin = new Padding(4, 3, 4, 3);
            BackToMenu.Name = "BackToMenu";
            BackToMenu.Size = new Size(155, 50);
            BackToMenu.TabIndex = 4;
            BackToMenu.Text = "Back To Main ";
            BackToMenu.UseVisualStyleBackColor = false;
            BackToMenu.Click += BackToMenu_Click;
            // 
            // originalPriceTextBox
            // 
            originalPriceTextBox.ForeColor = Color.Black;
            originalPriceTextBox.Location = new Point(568, 127);
            originalPriceTextBox.Name = "originalPriceTextBox";
            originalPriceTextBox.Size = new Size(125, 28);
            originalPriceTextBox.TabIndex = 0;
            // 
            // outputDescriptionLabel
            // 
            outputDescriptionLabel.BackColor = Color.PaleTurquoise;
            outputDescriptionLabel.ForeColor = Color.Black;
            outputDescriptionLabel.Location = new Point(553, 259);
            outputDescriptionLabel.Name = "outputDescriptionLabel";
            outputDescriptionLabel.Size = new Size(157, 37);
            outputDescriptionLabel.TabIndex = 71;
            outputDescriptionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // discountPercentageTextBox
            // 
            discountPercentageTextBox.ForeColor = Color.Black;
            discountPercentageTextBox.Location = new Point(568, 182);
            discountPercentageTextBox.Name = "discountPercentageTextBox";
            discountPercentageTextBox.Size = new Size(125, 28);
            discountPercentageTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(411, 267);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 69;
            label1.Text = " Sale price: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(239, 185);
            label2.Name = "label2";
            label2.Size = new Size(316, 20);
            label2.TabIndex = 68;
            label2.Text = " Enter the discount percentage: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(237, 130);
            label3.Name = "label3";
            label3.Size = new Size(313, 20);
            label3.TabIndex = 67;
            label3.Text = "  Enter the item’s original price:";
            // 
            // Sell_Price_Prog
            // 
            AutoScaleDimensions = new SizeF(12F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1153, 562);
            Controls.Add(originalPriceTextBox);
            Controls.Add(outputDescriptionLabel);
            Controls.Add(discountPercentageTextBox);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(CalculateButton);
            Controls.Add(ClearBtn);
            Controls.Add(label6);
            Controls.Add(BackToMenu);
            Controls.Add(HeaderTitle);
            Controls.Add(Labeldate);
            Controls.Add(label4);
            Controls.Add(Header);
            Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            ForeColor = Color.White;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Sell_Price_Prog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sale Price Calculator  Application";
            Load += Sell_Price_Prog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderTitle;
        private Label Labeldate;
        private Label label4;
        private Label Header;
        private Button CalculateButton;
        private Button ClearBtn;
        private Label label6;
        private Button BackToMenu;
        private TextBox originalPriceTextBox;
        private Label outputDescriptionLabel;
        private TextBox discountPercentageTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}