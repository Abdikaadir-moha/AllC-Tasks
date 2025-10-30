using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllC_Tasks.Assignment5
{
    public partial class Celsius_to_Fahrenheit_Table : Form
    {
        public Celsius_to_Fahrenheit_Table()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            resultListBox.Items.Clear();
            resultListBox.Items.Add("Celsius\tFahrenheit");
            resultListBox.Items.Add("----------------------");

            // Loop from 0°C to 20°C
            for (int celsius = 0; celsius <= 20; celsius++)
            {
                double fahrenheit = (9.0 / 5.0) * celsius + 32;
                resultListBox.Items.Add($"{celsius}°C\t{fahrenheit:F1}°F");
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            resultListBox.Items.Clear();
        }

        private void Celsius_to_Fahrenheit_Table_Load(object sender, EventArgs e)
        {
            BackColor = AppTheme.BackgroundColor;
            headerPanel.FillColor = AppTheme.HeaderColor;
            titleLabel.ForeColor = AppTheme.HeaderTextColor;

            ShowButton.FillColor = AppTheme.PrimaryButtonColor;
            ClearBtn.FillColor = AppTheme.SecondaryButtonColor;

            resultListBox.BackColor = AppTheme.TextBoxBackColor;
            resultListBox.ForeColor = AppTheme.TextColor;
        }
    }
}
