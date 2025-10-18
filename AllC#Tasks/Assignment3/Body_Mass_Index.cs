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
    public partial class Body_Mass_Index : Form
    {
        public Body_Mass_Index()
        {
            InitializeComponent();
        }

        private void Body_Mass_Index_Load(object sender, EventArgs e)
        {

        }

        private void Calculatebutton_Click(object sender, EventArgs e)
        {
            try {
                double weight, height, bmi;
                weight = double.Parse(WeighttextBox.Text);
                height = double.Parse(HeighttextBox.Text);
                bmi = (weight * 703) / (height * height);
                Resultlabel.Text = bmi.ToString("F1");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for weight and height.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }
    }
}
