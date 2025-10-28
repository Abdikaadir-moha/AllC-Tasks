namespace AllC_Tasks.Ex_Ch4
{
    partial class Time_Zone_Application
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
            timeZoneLabel = new Label();
            label5 = new Label();
            cityListBox = new ListBox();
            label1 = new Label();
            OkButton = new Button();
            SuspendLayout();
            // 
            // timeZoneLabel
            // 
            timeZoneLabel.BackColor = Color.DarkKhaki;
            timeZoneLabel.Location = new Point(315, 264);
            timeZoneLabel.Name = "timeZoneLabel";
            timeZoneLabel.Size = new Size(216, 50);
            timeZoneLabel.TabIndex = 21;
            timeZoneLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(167, 277);
            label5.Name = "label5";
            label5.Size = new Size(142, 25);
            label5.TabIndex = 22;
            label5.Text = "Time Zone:";
            // 
            // cityListBox
            // 
            cityListBox.ForeColor = Color.Navy;
            cityListBox.FormattingEnabled = true;
            cityListBox.ItemHeight = 25;
            cityListBox.Items.AddRange(new object[] { "Denver ", "Honolulu ", "Minneapolis ", "New York ", "San Francisco " });
            cityListBox.Location = new Point(257, 97);
            cityListBox.Name = "cityListBox";
            cityListBox.Size = new Size(238, 129);
            cityListBox.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 38);
            label1.Name = "label1";
            label1.Size = new Size(499, 25);
            label1.TabIndex = 24;
            label1.Text = "Select a city and I will give the time zone";
            // 
            // OkButton
            // 
            OkButton.ForeColor = Color.Black;
            OkButton.Location = new Point(315, 357);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(141, 46);
            OkButton.TabIndex = 25;
            OkButton.Text = "Ok";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // Time_Zone_Application
            // 
            AutoScaleDimensions = new SizeF(14F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(774, 428);
            Controls.Add(OkButton);
            Controls.Add(label1);
            Controls.Add(cityListBox);
            Controls.Add(timeZoneLabel);
            Controls.Add(label5);
            Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            ForeColor = Color.White;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Time_Zone_Application";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Time_Zone_Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeZoneLabel;
        private Label label5;
        private ListBox cityListBox;
        private Label label1;
        private Button OkButton;
    }
}