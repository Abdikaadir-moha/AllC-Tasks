namespace assignment2
{
    partial class latinTranslator
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
            label1 = new Label();
            label2 = new Label();
            HeaderTitle = new Label();
            Labeldate = new Label();
            label3 = new Label();
            Header = new Label();
            SinisterLabel = new Label();
            MediumLabel = new Label();
            DexterLabel = new Label();
            En_1_Label = new Label();
            En_3_Label = new Label();
            En_2_Label = new Label();
            label10 = new Label();
            BackToMenu = new Button();
            ResetLabelsBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Roboto Condensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(412, 120);
            label1.Name = "label1";
            label1.Size = new Size(135, 38);
            label1.TabIndex = 3;
            label1.Text = "Latin Word";
            // 
            // label2
            // 
            label2.Font = new Font("Roboto Condensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(718, 120);
            label2.Name = "label2";
            label2.Size = new Size(163, 38);
            label2.TabIndex = 7;
            label2.Text = "English Word";
            // 
            // HeaderTitle
            // 
            HeaderTitle.BackColor = Color.Transparent;
            HeaderTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeaderTitle.ForeColor = SystemColors.Control;
            HeaderTitle.Location = new Point(446, -4);
            HeaderTitle.Name = "HeaderTitle";
            HeaderTitle.Size = new Size(367, 60);
            HeaderTitle.TabIndex = 42;
            HeaderTitle.Text = "Latin Translator Program";
            HeaderTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Labeldate
            // 
            Labeldate.BackColor = Color.Transparent;
            Labeldate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Labeldate.ForeColor = Color.White;
            Labeldate.Location = new Point(1048, 9);
            Labeldate.Name = "Labeldate";
            Labeldate.RightToLeft = RightToLeft.No;
            Labeldate.Size = new Size(223, 36);
            Labeldate.TabIndex = 41;
            Labeldate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(16, 4);
            label3.Name = "label3";
            label3.Size = new Size(173, 44);
            label3.TabIndex = 40;
            label3.Text = "JU FOCOSIT";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Header
            // 
            Header.BackColor = Color.SeaShell;
            Header.Location = new Point(0, -4);
            Header.Name = "Header";
            Header.Size = new Size(1288, 60);
            Header.TabIndex = 39;
            // 
            // SinisterLabel
            // 
            SinisterLabel.BackColor = Color.PowderBlue;
            SinisterLabel.Font = new Font("Roboto Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SinisterLabel.ForeColor = SystemColors.ControlText;
            SinisterLabel.Location = new Point(405, 186);
            SinisterLabel.Name = "SinisterLabel";
            SinisterLabel.Size = new Size(142, 52);
            SinisterLabel.TabIndex = 43;
            SinisterLabel.Text = "Sinister ";
            SinisterLabel.TextAlign = ContentAlignment.MiddleCenter;
            SinisterLabel.Click += SinisterLabel_Click;
            // 
            // MediumLabel
            // 
            MediumLabel.BackColor = Color.PowderBlue;
            MediumLabel.Font = new Font("Roboto Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MediumLabel.ForeColor = SystemColors.ControlText;
            MediumLabel.Location = new Point(405, 364);
            MediumLabel.Name = "MediumLabel";
            MediumLabel.Size = new Size(142, 52);
            MediumLabel.TabIndex = 44;
            MediumLabel.Text = "Medium ";
            MediumLabel.TextAlign = ContentAlignment.MiddleCenter;
            MediumLabel.Click += MediumLabel_Click;
            // 
            // DexterLabel
            // 
            DexterLabel.BackColor = Color.PowderBlue;
            DexterLabel.Font = new Font("Roboto Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DexterLabel.ForeColor = SystemColors.ControlText;
            DexterLabel.Location = new Point(405, 272);
            DexterLabel.Name = "DexterLabel";
            DexterLabel.Size = new Size(142, 52);
            DexterLabel.TabIndex = 45;
            DexterLabel.Text = "Dexter ";
            DexterLabel.TextAlign = ContentAlignment.MiddleCenter;
            DexterLabel.Click += DexterLabel_Click;
            // 
            // En_1_Label
            // 
            En_1_Label.BackColor = Color.Gold;
            En_1_Label.Font = new Font("Roboto Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            En_1_Label.ForeColor = SystemColors.ControlText;
            En_1_Label.Location = new Point(727, 186);
            En_1_Label.Name = "En_1_Label";
            En_1_Label.Size = new Size(142, 52);
            En_1_Label.TabIndex = 46;
            En_1_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // En_3_Label
            // 
            En_3_Label.BackColor = Color.Gold;
            En_3_Label.Font = new Font("Roboto Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            En_3_Label.ForeColor = SystemColors.ControlText;
            En_3_Label.Location = new Point(727, 364);
            En_3_Label.Name = "En_3_Label";
            En_3_Label.Size = new Size(142, 52);
            En_3_Label.TabIndex = 47;
            En_3_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // En_2_Label
            // 
            En_2_Label.BackColor = Color.Gold;
            En_2_Label.Font = new Font("Roboto Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            En_2_Label.ForeColor = SystemColors.ControlText;
            En_2_Label.Location = new Point(727, 272);
            En_2_Label.Name = "En_2_Label";
            En_2_Label.Size = new Size(142, 52);
            En_2_Label.TabIndex = 48;
            En_2_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(365, 564);
            label10.Name = "label10";
            label10.Size = new Size(580, 30);
            label10.TabIndex = 50;
            label10.Text = "@ 2025 abdikadir mohamed";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackToMenu
            // 
            BackToMenu.BackColor = Color.MediumBlue;
            BackToMenu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackToMenu.ForeColor = Color.Transparent;
            BackToMenu.Location = new Point(394, 474);
            BackToMenu.Name = "BackToMenu";
            BackToMenu.Size = new Size(189, 53);
            BackToMenu.TabIndex = 49;
            BackToMenu.Text = "Back To Main ";
            BackToMenu.UseVisualStyleBackColor = false;
            BackToMenu.Visible = false;
            BackToMenu.Click += BackToMenu_Click;
            // 
            // ResetLabelsBtn
            // 
            ResetLabelsBtn.BackColor = Color.CornflowerBlue;
            ResetLabelsBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResetLabelsBtn.ForeColor = Color.Transparent;
            ResetLabelsBtn.Location = new Point(684, 474);
            ResetLabelsBtn.Name = "ResetLabelsBtn";
            ResetLabelsBtn.Size = new Size(212, 53);
            ResetLabelsBtn.TabIndex = 52;
            ResetLabelsBtn.Text = "Reset";
            ResetLabelsBtn.UseVisualStyleBackColor = false;
            ResetLabelsBtn.Click += ResetLabelsBtn_Click;
            // 
            // latinTranslator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1283, 600);
            Controls.Add(ResetLabelsBtn);
            Controls.Add(label10);
            Controls.Add(BackToMenu);
            Controls.Add(En_2_Label);
            Controls.Add(En_3_Label);
            Controls.Add(En_1_Label);
            Controls.Add(DexterLabel);
            Controls.Add(MediumLabel);
            Controls.Add(SinisterLabel);
            Controls.Add(HeaderTitle);
            Controls.Add(Labeldate);
            Controls.Add(label3);
            Controls.Add(Header);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "latinTranslator";
            Text = "LatinTranslator";
            Load += latinTranslator_Load;
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label HeaderTitle;
        private Label Labeldate;
        private Label label3;
        private Label Header;
        private Label SinisterLabel;
        private Label MediumLabel;
        private Label DexterLabel;
        private Label En_1_Label;
        private Label En_3_Label;
        private Label En_2_Label;
        private Label label10;
        private Button BackToMenu;
        private Button ResetLabelsBtn;
    }
}
