namespace AllC_Tasks
{
    partial class Cel_Fahrenheit_Temp
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
            label2 = new Label();
            ToCelciusBtn = new Button();
            Resultlabel = new Label();
            TempTextBox = new TextBox();
            labelTemp = new Label();
            ToFahrenheitBtn = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(458, 167);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 40;
            label2.Text = "Result:";
            // 
            // ToCelciusBtn
            // 
            ToCelciusBtn.BackColor = Color.YellowGreen;
            ToCelciusBtn.ForeColor = Color.White;
            ToCelciusBtn.Location = new Point(612, 261);
            ToCelciusBtn.Margin = new Padding(2);
            ToCelciusBtn.Name = "ToCelciusBtn";
            ToCelciusBtn.Size = new Size(149, 62);
            ToCelciusBtn.TabIndex = 3;
            ToCelciusBtn.Text = "Convert to Celcius";
            ToCelciusBtn.UseVisualStyleBackColor = false;
            ToCelciusBtn.Click += ToCelciusBtn_Click;
            // 
            // Resultlabel
            // 
            Resultlabel.BackColor = Color.LightSeaGreen;
            Resultlabel.BorderStyle = BorderStyle.FixedSingle;
            Resultlabel.Location = new Point(553, 157);
            Resultlabel.Margin = new Padding(2, 0, 2, 0);
            Resultlabel.Name = "Resultlabel";
            Resultlabel.Size = new Size(155, 41);
            Resultlabel.TabIndex = 1;
            // 
            // TempTextBox
            // 
            TempTextBox.Location = new Point(553, 94);
            TempTextBox.Margin = new Padding(2);
            TempTextBox.Name = "TempTextBox";
            TempTextBox.Size = new Size(155, 28);
            TempTextBox.TabIndex = 0;
            // 
            // labelTemp
            // 
            labelTemp.AutoSize = true;
            labelTemp.ForeColor = Color.White;
            labelTemp.Location = new Point(339, 97);
            labelTemp.Margin = new Padding(2, 0, 2, 0);
            labelTemp.Name = "labelTemp";
            labelTemp.Size = new Size(195, 20);
            labelTemp.TabIndex = 35;
            labelTemp.Text = "Enter Temperature:";
            // 
            // ToFahrenheitBtn
            // 
            ToFahrenheitBtn.BackColor = Color.SeaGreen;
            ToFahrenheitBtn.ForeColor = Color.White;
            ToFahrenheitBtn.Location = new Point(419, 261);
            ToFahrenheitBtn.Margin = new Padding(2);
            ToFahrenheitBtn.Name = "ToFahrenheitBtn";
            ToFahrenheitBtn.Size = new Size(149, 62);
            ToFahrenheitBtn.TabIndex = 2;
            ToFahrenheitBtn.Text = "Convert to Fahrenheit";
            ToFahrenheitBtn.UseVisualStyleBackColor = false;
            ToFahrenheitBtn.Click += ToFahrenheitBtn_Click;
            // 
            // Cel_Fahrenheit_Temp
            // 
            AutoScaleDimensions = new SizeF(12F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1200, 450);
            Controls.Add(ToFahrenheitBtn);
            Controls.Add(label2);
            Controls.Add(ToCelciusBtn);
            Controls.Add(Resultlabel);
            Controls.Add(TempTextBox);
            Controls.Add(labelTemp);
            Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Cel_Fahrenheit_Temp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cel_Fahrenheit_Temp";
            Load += Cel_Fahrenheit_Temp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button ToCelciusBtn;
        private Label Resultlabel;
        private TextBox TempTextBox;
        private Label labelTemp;
        private Button ToFahrenheitBtn;
    }
}