using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllC_Tasks.Assignment4
{
    public partial class RomanNumeralConverter : Form
    {
        public RomanNumeralConverter()
        {
            InitializeComponent();
        }

        private void RomanNumeralConverter_Load(object sender, EventArgs e)
        {

        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Try to parse input
                int number = int.Parse(NumberTextBox.Text);

                string romanNumeral = "";

                switch (number)
                {
                    case 1: romanNumeral = "I"; break;
                    case 2: romanNumeral = "II"; break;
                    case 3: romanNumeral = "III"; break;
                    case 4: romanNumeral = "IV"; break;
                    case 5: romanNumeral = "V"; break;
                    case 6: romanNumeral = "VI"; break;
                    case 7: romanNumeral = "VII"; break;
                    case 8: romanNumeral = "VIII"; break;
                    case 9: romanNumeral = "IX"; break;
                    case 10: romanNumeral = "X"; break;
                    default:
                        MessageBox.Show("Number must be between 1 and 10.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                LblResult.Text = $"Roman Numeral: {romanNumeral}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input! Please enter a numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
