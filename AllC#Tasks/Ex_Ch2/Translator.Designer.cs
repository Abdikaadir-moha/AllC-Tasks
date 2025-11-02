namespace Assignments1
{
    partial class Translator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            Header = new Label();
            label1 = new Label();
            label3 = new Label();
            HeaderTitle = new Label();
            BackToMenu = new Button();
            instructionLabel = new Label();
            translationLabel = new Label();
            SomaliBtn = new Button();
            FranceBtn = new Button();
            TurkeyBtn = new Button();
            Labeldate = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(-247, 204);
            label2.Name = "label2";
            label2.Size = new Size(173, 44);
            label2.TabIndex = 14;
            label2.Text = "JU FOCOSIT";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Header
            // 
            Header.BackColor = Color.White;
            Header.Location = new Point(-4, -3);
            Header.Name = "Header";
            Header.Size = new Size(1323, 60);
            Header.TabIndex = 12;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(173, 44);
            label1.TabIndex = 15;
            label1.Text = "JU FOCOSIT";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(353, 681);
            label3.Name = "label3";
            label3.Size = new Size(580, 30);
            label3.TabIndex = 18;
            label3.Text = "@ 2025 abdikadir mohamed";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HeaderTitle
            // 
            HeaderTitle.BackColor = Color.Transparent;
            HeaderTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeaderTitle.ForeColor = Color.White;
            HeaderTitle.Location = new Point(457, -3);
            HeaderTitle.Name = "HeaderTitle";
            HeaderTitle.Size = new Size(356, 60);
            HeaderTitle.TabIndex = 20;
            HeaderTitle.Text = "Translator Program";
            HeaderTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackToMenu
            // 
            BackToMenu.BackColor = Color.MediumBlue;
            BackToMenu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackToMenu.ForeColor = Color.Transparent;
            BackToMenu.Location = new Point(541, 574);
            BackToMenu.Name = "BackToMenu";
            BackToMenu.Size = new Size(189, 53);
            BackToMenu.TabIndex = 16;
            BackToMenu.Text = "Back To Main ";
            BackToMenu.UseVisualStyleBackColor = false;
            BackToMenu.Click += BackToMenu_Click;
            // 
            // instructionLabel
            // 
            instructionLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            instructionLabel.ForeColor = SystemColors.Control;
            instructionLabel.Location = new Point(383, 181);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new Size(494, 24);
            instructionLabel.TabIndex = 22;
            instructionLabel.Text = " Select a language and I will say Welcome.";
            instructionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // translationLabel
            // 
            translationLabel.BackColor = Color.DarkCyan;
            translationLabel.BorderStyle = BorderStyle.FixedSingle;
            translationLabel.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            translationLabel.ForeColor = Color.White;
            translationLabel.Location = new Point(411, 252);
            translationLabel.Name = "translationLabel";
            translationLabel.Size = new Size(437, 49);
            translationLabel.TabIndex = 24;
            translationLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SomaliBtn
            // 
            SomaliBtn.BackColor = Color.RoyalBlue;
            SomaliBtn.Font = new Font("Roboto", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SomaliBtn.ForeColor = SystemColors.Control;
            SomaliBtn.Location = new Point(368, 369);
            SomaliBtn.Name = "SomaliBtn";
            SomaliBtn.Size = new Size(169, 68);
            SomaliBtn.TabIndex = 25;
            SomaliBtn.Text = "Af-Somali";
            SomaliBtn.UseVisualStyleBackColor = false;
            SomaliBtn.Click += SomaliBtn_Click;
            // 
            // FranceBtn
            // 
            FranceBtn.BackColor = Color.White;
            FranceBtn.Font = new Font("Roboto", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FranceBtn.ForeColor = SystemColors.Highlight;
            FranceBtn.Location = new Point(736, 369);
            FranceBtn.Name = "FranceBtn";
            FranceBtn.Size = new Size(169, 68);
            FranceBtn.TabIndex = 27;
            FranceBtn.Text = "France";
            FranceBtn.UseVisualStyleBackColor = false;
            FranceBtn.Click += FranceBtn_Click;
            // 
            // TurkeyBtn
            // 
            TurkeyBtn.BackColor = Color.Crimson;
            TurkeyBtn.Font = new Font("Roboto", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TurkeyBtn.ForeColor = SystemColors.Control;
            TurkeyBtn.Location = new Point(552, 369);
            TurkeyBtn.Name = "TurkeyBtn";
            TurkeyBtn.Size = new Size(169, 68);
            TurkeyBtn.TabIndex = 28;
            TurkeyBtn.Text = "Turkish";
            TurkeyBtn.UseVisualStyleBackColor = false;
            TurkeyBtn.Click += TurkeyBtn_Click;
            // 
            // Labeldate
            // 
            Labeldate.BackColor = Color.Transparent;
            Labeldate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Labeldate.ForeColor = Color.White;
            Labeldate.Location = new Point(1048, 8);
            Labeldate.Name = "Labeldate";
            Labeldate.RightToLeft = RightToLeft.No;
            Labeldate.Size = new Size(256, 36);
            Labeldate.TabIndex = 29;
            Labeldate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Translator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1316, 710);
            Controls.Add(Labeldate);
            Controls.Add(TurkeyBtn);
            Controls.Add(FranceBtn);
            Controls.Add(SomaliBtn);
            Controls.Add(translationLabel);
            Controls.Add(instructionLabel);
            Controls.Add(HeaderTitle);
            Controls.Add(label3);
            Controls.Add(BackToMenu);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(Header);
            Name = "Translator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Translator";
            Load += Translator_Load;
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label Header;
        private Label label1;
        private Label label3;
        private Label HeaderTitle;
        private Button BackToMenu;
        private Label instructionLabel;
        private Label translationLabel;
        private Button SomaliBtn;
        private Button FranceBtn;
        private Button TurkeyBtn;
        private Label Labeldate;
    }
}
