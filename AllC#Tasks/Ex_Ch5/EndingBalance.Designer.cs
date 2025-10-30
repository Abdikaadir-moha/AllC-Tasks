namespace Wholeproject
{
    partial class EndingBalance
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
            groupBox2 = new GroupBox();
            endingBalanceLabel = new Label();
            label1 = new Label();
            monthsTextBox = new TextBox();
            startingBalTextBox = new TextBox();
            Exitbutton = new Button();
            Clearsbutton = new Button();
            CalculateButton = new Button();
            label4 = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(endingBalanceLabel);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(monthsTextBox);
            groupBox2.Controls.Add(startingBalTextBox);
            groupBox2.Controls.Add(Exitbutton);
            groupBox2.Controls.Add(Clearsbutton);
            groupBox2.Controls.Add(CalculateButton);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(173, 78);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(455, 294);
            groupBox2.TabIndex = 88;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ending Balance";
            // 
            // endingBalanceLabel
            // 
            endingBalanceLabel.BorderStyle = BorderStyle.FixedSingle;
            endingBalanceLabel.Location = new Point(214, 146);
            endingBalanceLabel.Name = "endingBalanceLabel";
            endingBalanceLabel.Size = new Size(190, 37);
            endingBalanceLabel.TabIndex = 86;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(39, 98);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(176, 25);
            label1.TabIndex = 84;
            label1.Text = "Number Of months";
            // 
            // monthsTextBox
            // 
            monthsTextBox.Location = new Point(214, 98);
            monthsTextBox.Name = "monthsTextBox";
            monthsTextBox.Size = new Size(190, 31);
            monthsTextBox.TabIndex = 83;
            // 
            // startingBalTextBox
            // 
            startingBalTextBox.Location = new Point(214, 45);
            startingBalTextBox.Name = "startingBalTextBox";
            startingBalTextBox.Size = new Size(190, 31);
            startingBalTextBox.TabIndex = 82;
            // 
            // Exitbutton
            // 
            Exitbutton.BackColor = Color.Crimson;
            Exitbutton.Location = new Point(320, 209);
            Exitbutton.Name = "Exitbutton";
            Exitbutton.Size = new Size(112, 66);
            Exitbutton.TabIndex = 80;
            Exitbutton.Text = "Exit";
            Exitbutton.UseVisualStyleBackColor = false;
            Exitbutton.Click += Exitbutton_Click;
            // 
            // Clearsbutton
            // 
            Clearsbutton.BackColor = Color.CornflowerBlue;
            Clearsbutton.Location = new Point(183, 209);
            Clearsbutton.Name = "Clearsbutton";
            Clearsbutton.Size = new Size(112, 66);
            Clearsbutton.TabIndex = 79;
            Clearsbutton.Text = "Clear";
            Clearsbutton.UseVisualStyleBackColor = false;
            Clearsbutton.Click += Clearsbutton_Click;
            // 
            // CalculateButton
            // 
            CalculateButton.BackColor = Color.Coral;
            CalculateButton.Location = new Point(39, 209);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(134, 66);
            CalculateButton.TabIndex = 78;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = false;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.OrangeRed;
            label4.Location = new Point(39, 48);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(153, 25);
            label4.TabIndex = 75;
            label4.Text = "Starting Balance";
            // 
            // EndingBalance
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Name = "EndingBalance";
            Text = "EndingBalance";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox monthsTextBox;
        private TextBox startingBalTextBox;
        private Button Exitbutton;
        private Button Clearsbutton;
        private Button CalculateButton;
        private Label label4;
        private Label label1;
        private Label endingBalanceLabel;
    }
}