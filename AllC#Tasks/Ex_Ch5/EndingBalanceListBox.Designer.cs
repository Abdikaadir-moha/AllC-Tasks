namespace Wholeproject
{
    partial class EndingBalanceListBox
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DetailListBox = new ListBox();
            label2 = new Label();
            endingBalanceLabel = new Label();
            label1 = new Label();
            monthsTextBox = new TextBox();
            startingBalTextBox = new TextBox();
            label4 = new Label();
            headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            titleLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            CalcEndingButton = new Guna.UI2.WinForms.Guna2Button();
            ClearBtn = new Guna.UI2.WinForms.Guna2Button();
            messageLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // DetailListBox
            // 
            DetailListBox.FormattingEnabled = true;
            DetailListBox.ItemHeight = 25;
            DetailListBox.Location = new Point(132, 201);
            DetailListBox.Name = "DetailListBox";
            DetailListBox.Size = new Size(354, 129);
            DetailListBox.TabIndex = 88;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(132, 349);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(148, 25);
            label2.TabIndex = 87;
            label2.Text = "Ending Balance:";
            // 
            // endingBalanceLabel
            // 
            endingBalanceLabel.BorderStyle = BorderStyle.FixedSingle;
            endingBalanceLabel.Location = new Point(287, 344);
            endingBalanceLabel.Name = "endingBalanceLabel";
            endingBalanceLabel.Size = new Size(190, 37);
            endingBalanceLabel.TabIndex = 86;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(113, 147);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(176, 25);
            label1.TabIndex = 84;
            label1.Text = "Number Of months";
            // 
            // monthsTextBox
            // 
            monthsTextBox.Location = new Point(296, 147);
            monthsTextBox.Name = "monthsTextBox";
            monthsTextBox.Size = new Size(190, 31);
            monthsTextBox.TabIndex = 83;
            // 
            // startingBalTextBox
            // 
            startingBalTextBox.Location = new Point(296, 97);
            startingBalTextBox.Name = "startingBalTextBox";
            startingBalTextBox.Size = new Size(190, 31);
            startingBalTextBox.TabIndex = 82;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(122, 101);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(153, 25);
            label4.TabIndex = 75;
            label4.Text = "Starting Balance";
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(titleLabel);
            headerPanel.CustomizableEdges = customizableEdges1;
            headerPanel.Location = new Point(-1, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            headerPanel.Size = new Size(608, 72);
            headerPanel.TabIndex = 89;
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.Black;
            titleLabel.Location = new Point(85, 12);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(388, 40);
            titleLabel.TabIndex = 6;
            titleLabel.Text = "Ending Balance Using ListBox";
            titleLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // CalcEndingButton
            // 
            CalcEndingButton.BorderColor = Color.Transparent;
            CalcEndingButton.BorderRadius = 8;
            CalcEndingButton.CustomBorderColor = Color.Transparent;
            CalcEndingButton.CustomizableEdges = customizableEdges3;
            CalcEndingButton.DisabledState.BorderColor = Color.DarkGray;
            CalcEndingButton.DisabledState.CustomBorderColor = Color.DarkGray;
            CalcEndingButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            CalcEndingButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            CalcEndingButton.FillColor = SystemColors.Highlight;
            CalcEndingButton.FocusedColor = Color.Transparent;
            CalcEndingButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CalcEndingButton.ForeColor = Color.White;
            CalcEndingButton.Location = new Point(154, 501);
            CalcEndingButton.Name = "CalcEndingButton";
            CalcEndingButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            CalcEndingButton.Size = new Size(143, 58);
            CalcEndingButton.TabIndex = 92;
            CalcEndingButton.Text = "Calculate";
            CalcEndingButton.Click += CalcEndingButton_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.BorderColor = Color.Transparent;
            ClearBtn.BorderRadius = 8;
            ClearBtn.CustomBorderColor = Color.Transparent;
            ClearBtn.CustomizableEdges = customizableEdges5;
            ClearBtn.DisabledState.BorderColor = Color.DarkGray;
            ClearBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            ClearBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ClearBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ClearBtn.FillColor = Color.FromArgb(100, 181, 246);
            ClearBtn.FocusedColor = Color.Transparent;
            ClearBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearBtn.ForeColor = Color.White;
            ClearBtn.Location = new Point(316, 501);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            ClearBtn.Size = new Size(156, 58);
            ClearBtn.TabIndex = 93;
            ClearBtn.Text = "Clear";
            ClearBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = false;
            messageLabel.BackColor = Color.Transparent;
            messageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            messageLabel.Location = new Point(84, 411);
            messageLabel.Name = "messageLabel";
            messageLabel.Padding = new Padding(2);
            messageLabel.Size = new Size(459, 56);
            messageLabel.TabIndex = 94;
            messageLabel.Text = null;
            messageLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // EndingBalanceListBox
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 571);
            Controls.Add(messageLabel);
            Controls.Add(CalcEndingButton);
            Controls.Add(ClearBtn);
            Controls.Add(headerPanel);
            Controls.Add(DetailListBox);
            Controls.Add(label2);
            Controls.Add(endingBalanceLabel);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(monthsTextBox);
            Controls.Add(startingBalTextBox);
            Name = "EndingBalanceListBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EndingBalanceListBox";
            Load += EndingBalanceListBox_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label endingBalanceLabel;
        private Label label1;
        private TextBox monthsTextBox;
        private TextBox startingBalTextBox;
        private Label label4;
        private ListBox DetailListBox;
        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel titleLabel;
        private Guna.UI2.WinForms.Guna2Button CalcEndingButton;
        private Guna.UI2.WinForms.Guna2Button ClearBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel messageLabel;
    }
}