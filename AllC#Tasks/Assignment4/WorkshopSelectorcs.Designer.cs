namespace AllC_Tasks.Assignment4
{
    partial class WorkshopSelectorcs
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            locationListBox = new ListBox();
            workshopListBox = new ListBox();
            registrationOutputLabel = new Label();
            lodgingOutputLabel = new Label();
            totalOutputLabel = new Label();
            CalculateButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 67);
            label1.Name = "label1";
            label1.Size = new Size(168, 27);
            label1.TabIndex = 0;
            label1.Text = "Select Workshop:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(522, 67);
            label2.Name = "label2";
            label2.Size = new Size(157, 27);
            label2.TabIndex = 1;
            label2.Text = "Select Location:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 356);
            label3.Name = "label3";
            label3.Size = new Size(173, 27);
            label3.TabIndex = 2;
            label3.Text = "Registration Cost:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(136, 421);
            label4.Name = "label4";
            label4.Size = new Size(136, 27);
            label4.TabIndex = 3;
            label4.Text = "Lodging Cost:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(164, 475);
            label5.Name = "label5";
            label5.Size = new Size(108, 27);
            label5.TabIndex = 4;
            label5.Text = "Total Cost:";
            // 
            // locationListBox
            // 
            locationListBox.FormattingEnabled = true;
            locationListBox.ItemHeight = 27;
            locationListBox.Items.AddRange(new object[] { "Austin", "Chicago", "Dallas", "Orlando", "Phoenix", "Raleigh" });
            locationListBox.Location = new Point(522, 102);
            locationListBox.Name = "locationListBox";
            locationListBox.Size = new Size(180, 193);
            locationListBox.TabIndex = 5;
            // 
            // workshopListBox
            // 
            workshopListBox.FormattingEnabled = true;
            workshopListBox.ItemHeight = 27;
            workshopListBox.Items.AddRange(new object[] { "Handling Stress", "Time Management", "Supervision Skills", "Negotiation", "How to Interview" });
            workshopListBox.Location = new Point(81, 102);
            workshopListBox.Name = "workshopListBox";
            workshopListBox.Size = new Size(180, 193);
            workshopListBox.TabIndex = 8;
            // 
            // registrationOutputLabel
            // 
            registrationOutputLabel.BackColor = Color.PaleGoldenrod;
            registrationOutputLabel.Font = new Font("Roboto Condensed", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registrationOutputLabel.Location = new Point(305, 350);
            registrationOutputLabel.Name = "registrationOutputLabel";
            registrationOutputLabel.Size = new Size(236, 43);
            registrationOutputLabel.TabIndex = 9;
            registrationOutputLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lodgingOutputLabel
            // 
            lodgingOutputLabel.BackColor = Color.PaleGoldenrod;
            lodgingOutputLabel.Font = new Font("Roboto Condensed", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lodgingOutputLabel.Location = new Point(305, 415);
            lodgingOutputLabel.Name = "lodgingOutputLabel";
            lodgingOutputLabel.Size = new Size(236, 43);
            lodgingOutputLabel.TabIndex = 10;
            lodgingOutputLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // totalOutputLabel
            // 
            totalOutputLabel.BackColor = Color.PaleGoldenrod;
            totalOutputLabel.Font = new Font("Roboto Condensed", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalOutputLabel.Location = new Point(305, 475);
            totalOutputLabel.Name = "totalOutputLabel";
            totalOutputLabel.Size = new Size(236, 43);
            totalOutputLabel.TabIndex = 11;
            totalOutputLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(317, 577);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(168, 54);
            CalculateButton.TabIndex = 12;
            CalculateButton.Text = "Calculate Total";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // WorkshopSelectorcs
            // 
            AutoScaleDimensions = new SizeF(11F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 662);
            Controls.Add(CalculateButton);
            Controls.Add(totalOutputLabel);
            Controls.Add(lodgingOutputLabel);
            Controls.Add(registrationOutputLabel);
            Controls.Add(workshopListBox);
            Controls.Add(locationListBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Roboto Condensed", 10.8F, FontStyle.Bold);
            Name = "WorkshopSelectorcs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WorkshopSelectorcs";
            Load += WorkshopSelectorcs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox locationListBox;
        private ListBox workshopListBox;
        private Label registrationOutputLabel;
        private Label lodgingOutputLabel;
        private Label totalOutputLabel;
        private Button CalculateButton;
    }
}