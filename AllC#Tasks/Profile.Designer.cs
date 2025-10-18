namespace Assignments1
{
    partial class Profile
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
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            label5 = new Label();
            Labeldate = new Label();
            HeaderTitle = new Label();
            BackToMenu = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.BackColor = Color.DeepSkyBlue;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(114, 101);
            label3.Name = "label3";
            label3.Size = new Size(547, 211);
            label3.TabIndex = 12;
            label3.Text = "Name:  Abdiqaadir Mohemed Hassan\r\nTel :   0617076922\r\nUniversity: Jazeera University\r\nFoculty:  CS /  IT\r\nSemister:  5";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(132, 44);
            label4.TabIndex = 15;
            label4.Text = "JU FOCOSIT";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(-2, 0);
            label1.Name = "label1";
            label1.Size = new Size(806, 68);
            label1.TabIndex = 13;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(216, 407);
            label5.Name = "label5";
            label5.Size = new Size(312, 44);
            label5.TabIndex = 17;
            label5.Text = "@ 2025 abdiqadir mohamed";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Labeldate
            // 
            Labeldate.BackColor = Color.Transparent;
            Labeldate.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Labeldate.ForeColor = Color.White;
            Labeldate.Location = new Point(574, 13);
            Labeldate.Name = "Labeldate";
            Labeldate.RightToLeft = RightToLeft.No;
            Labeldate.Size = new Size(214, 36);
            Labeldate.TabIndex = 19;
            Labeldate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HeaderTitle
            // 
            HeaderTitle.BackColor = Color.Transparent;
            HeaderTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeaderTitle.ForeColor = Color.White;
            HeaderTitle.Location = new Point(299, -1);
            HeaderTitle.Name = "HeaderTitle";
            HeaderTitle.Size = new Size(169, 69);
            HeaderTitle.TabIndex = 20;
            HeaderTitle.Text = "Profile";
            HeaderTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackToMenu
            // 
            BackToMenu.BackColor = Color.MediumBlue;
            BackToMenu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackToMenu.ForeColor = Color.Transparent;
            BackToMenu.Location = new Point(280, 351);
            BackToMenu.Name = "BackToMenu";
            BackToMenu.Size = new Size(189, 53);
            BackToMenu.TabIndex = 21;
            BackToMenu.Text = "Back To Main ";
            BackToMenu.UseVisualStyleBackColor = false;
            BackToMenu.Click += BackToMenu_Click;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(BackToMenu);
            Controls.Add(HeaderTitle);
            Controls.Add(Labeldate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "Profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            Load += Profile_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label3;
        private Label label4;
        private Label label1;
        private Label label5;
        private Label Labeldate;
        private Label HeaderTitle;
        private Button BackToMenu;
    }
}