using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllC_Tasks
{
    public partial class Cel_Fahrenheit_Temp : Form
    {
        public Cel_Fahrenheit_Temp()
        {
            InitializeComponent();
        }

        private void Cel_Fahrenheit_Temp_Load(object sender, EventArgs e)
        {

        }

        private void ToFahrenheitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double celsius, fahrenheit;
                celsius = double.Parse(TempTextBox.Text);
                fahrenheit = (9.0 / 5.0) * celsius + 32;
                Resultlabel.Text = fahrenheit.ToString("F1") + " °F";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        private void ToCelciusBtn_Click(object sender, EventArgs e)
        {
            try {
                double celsius, fahrenheit;
                fahrenheit = double.Parse(TempTextBox.Text);
                celsius = (5.0 / 9.0) * (fahrenheit - 32);
                Resultlabel.Text = celsius.ToString("F1") + " °C";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid Temperature.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }
    }
}
