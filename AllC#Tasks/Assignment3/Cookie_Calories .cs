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
    public partial class Cookie_Calories : Form
    {
        public Cookie_Calories()
        {
            InitializeComponent();
        }

        private void Calculatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                double cookies = double.Parse(CookiestextBox.Text);
                double totalcalories = cookies * 75;
                Resultlabel.Text = totalcalories.ToString("0.0") + " " + "calories";
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter a numeric value.");
                CookiestextBox.Clear();
                Resultlabel.Text = "";
                return;
            }
            
        }
    }
}
