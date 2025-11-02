namespace Freind_Files
{
    partial class Write_read_Open_Save
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DisplaylistBox = new ListBox();
            Write_button = new Button();
            Read_button = new Button();
            SaveFileButton = new Button();
            label1 = new Label();
            TotalLabel = new Label();
            ShowTotal = new Button();
            OpenFile = new OpenFileDialog();
            OpenFIleButton = new Button();
            SaveFile = new SaveFileDialog();
            headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            titleLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ClearButton = new Guna.UI2.WinForms.Guna2Button();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // DisplaylistBox
            // 
            DisplaylistBox.BackColor = SystemColors.Window;
            DisplaylistBox.FormattingEnabled = true;
            DisplaylistBox.Location = new Point(32, 100);
            DisplaylistBox.Name = "DisplaylistBox";
            DisplaylistBox.Size = new Size(385, 316);
            DisplaylistBox.TabIndex = 0;
            // 
            // Write_button
            // 
            Write_button.BackColor = Color.DeepSkyBlue;
            Write_button.ForeColor = Color.White;
            Write_button.Location = new Point(477, 116);
            Write_button.Name = "Write_button";
            Write_button.Size = new Size(161, 61);
            Write_button.TabIndex = 1;
            Write_button.Text = "Write File";
            Write_button.UseVisualStyleBackColor = false;
            Write_button.Click += Write_button_Click;
            // 
            // Read_button
            // 
            Read_button.BackColor = Color.MediumAquamarine;
            Read_button.ForeColor = Color.White;
            Read_button.Location = new Point(704, 116);
            Read_button.Name = "Read_button";
            Read_button.Size = new Size(161, 61);
            Read_button.TabIndex = 3;
            Read_button.Text = "Read FIle";
            Read_button.UseVisualStyleBackColor = false;
            Read_button.Click += Read_button_Click;
            // 
            // SaveFileButton
            // 
            SaveFileButton.BackColor = Color.SteelBlue;
            SaveFileButton.ForeColor = Color.White;
            SaveFileButton.Location = new Point(704, 225);
            SaveFileButton.Name = "SaveFileButton";
            SaveFileButton.Size = new Size(161, 61);
            SaveFileButton.TabIndex = 5;
            SaveFileButton.Text = "Save File";
            SaveFileButton.UseVisualStyleBackColor = false;
            SaveFileButton.Click += SaveFileButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(452, 356);
            label1.Name = "label1";
            label1.Size = new Size(62, 24);
            label1.TabIndex = 6;
            label1.Text = "Total:";
            // 
            // TotalLabel
            // 
            TotalLabel.BackColor = Color.NavajoWhite;
            TotalLabel.Location = new Point(520, 344);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(138, 49);
            TotalLabel.TabIndex = 7;
            TotalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ShowTotal
            // 
            ShowTotal.BackColor = Color.PowderBlue;
            ShowTotal.ForeColor = Color.Black;
            ShowTotal.Location = new Point(704, 338);
            ShowTotal.Name = "ShowTotal";
            ShowTotal.Size = new Size(161, 61);
            ShowTotal.TabIndex = 8;
            ShowTotal.Text = "Show total";
            ShowTotal.UseVisualStyleBackColor = false;
            ShowTotal.Click += ShowTotal_Click;
            // 
            // OpenFile
            // 
            OpenFile.FileName = "openFileDialog1";
            // 
            // OpenFIleButton
            // 
            OpenFIleButton.BackColor = Color.PaleTurquoise;
            OpenFIleButton.Location = new Point(477, 225);
            OpenFIleButton.Name = "OpenFIleButton";
            OpenFIleButton.Size = new Size(161, 61);
            OpenFIleButton.TabIndex = 9;
            OpenFIleButton.Text = "Open File";
            OpenFIleButton.UseVisualStyleBackColor = false;
            OpenFIleButton.Click += OpenFIleButton_Click;
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(titleLabel);
            headerPanel.CustomizableEdges = customizableEdges5;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.ShadowDecoration.CustomizableEdges = customizableEdges6;
            headerPanel.Size = new Size(956, 72);
            headerPanel.TabIndex = 10;
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.Black;
            titleLabel.Location = new Point(263, 12);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(445, 40);
            titleLabel.TabIndex = 6;
            titleLabel.Text = "Write, read, Open, Save and Total";
            titleLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // ClearButton
            // 
            ClearButton.BorderColor = Color.Transparent;
            ClearButton.BorderRadius = 8;
            ClearButton.CustomBorderColor = Color.Transparent;
            ClearButton.CustomizableEdges = customizableEdges7;
            ClearButton.DisabledState.BorderColor = Color.DarkGray;
            ClearButton.DisabledState.CustomBorderColor = Color.DarkGray;
            ClearButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ClearButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ClearButton.FillColor = Color.FromArgb(100, 181, 246);
            ClearButton.FocusedColor = Color.Transparent;
            ClearButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearButton.ForeColor = Color.White;
            ClearButton.Location = new Point(583, 440);
            ClearButton.Name = "ClearButton";
            ClearButton.ShadowDecoration.CustomizableEdges = customizableEdges8;
            ClearButton.Size = new Size(156, 58);
            ClearButton.TabIndex = 11;
            ClearButton.Text = "Clear";
            ClearButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // Write_read_Open_Save
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 510);
            Controls.Add(ClearButton);
            Controls.Add(headerPanel);
            Controls.Add(OpenFIleButton);
            Controls.Add(ShowTotal);
            Controls.Add(TotalLabel);
            Controls.Add(label1);
            Controls.Add(SaveFileButton);
            Controls.Add(Read_button);
            Controls.Add(Write_button);
            Controls.Add(DisplaylistBox);
            Font = new Font("Roboto Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Write_read_Open_Save";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Write_read_Open_Save";
            Load += Write_read_Open_Save_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox DisplaylistBox;
        private Button Write_button;
        private Button Read_button;
        private Button SaveFileButton;
        private Label label1;
        private Label TotalLabel;
        private Button ShowTotal;
        private OpenFileDialog OpenFile;
        private Button OpenFIleButton;
        private SaveFileDialog SaveFile;
        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel titleLabel;
        private Guna.UI2.WinForms.Guna2Button ClearButton;
    }
}