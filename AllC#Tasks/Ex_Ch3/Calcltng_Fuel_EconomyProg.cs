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
    public partial class Calcltng_Fuel_EconomyProg2 : Form
    {
        public Calcltng_Fuel_EconomyProg2()
        {
            InitializeComponent();
        }

        private void Calcltng_Fuel_EconomyProg_Load(object sender, EventArgs e)
        {
            Labeldate.Text = DateTime.Now.ToString("dd, MM , yyyy hh:mm:ss tt");
            milesTextBox.Focus();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double miles;     // To hold miles driven  
            double gallons;   // To hold gallons used  
            double mpg;       // To hold MPG

            miles = double.Parse(milesTextBox.Text);

            gallons = double.Parse(gallonsTextBox.Text);

            mpg = miles / gallons;


            outputDescriptionLabel.Text = mpg.ToString();

        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            milesTextBox.Clear();
            gallonsTextBox.Clear();
            outputDescriptionLabel.Text  = "";
            milesTextBox.Focus();
        }
    }
}
