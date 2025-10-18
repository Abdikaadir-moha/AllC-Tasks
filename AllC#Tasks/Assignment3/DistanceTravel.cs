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
    public partial class DistanceTravel : Form
    {
        public DistanceTravel()
        {
            InitializeComponent();
        }

        private void DistanceTravel_Load(object sender, EventArgs e)
        {

        }

        private void Cal5Hoursbutton_Click(object sender, EventArgs e)
        {
            try
            {
                double Speed = double.Parse(SpeedtextBox.Text);
                double Distance = Speed * 5;

                Resultlabel.Text = Distance.ToString() + " " + "miles";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cal8Hoursbutton_Click(object sender, EventArgs e)
        {
            try
            {
                double Speed = double.Parse(SpeedtextBox.Text);
                double Distance = Speed * 8;

                Resultlabel.Text = Distance.ToString() + " " + "miles";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cal12Hoursbutton_Click(object sender, EventArgs e)
        {
            try
            {
                double Speed = double.Parse(SpeedtextBox.Text);
                double Distance = Speed * 12;

                Resultlabel.Text = Distance.ToString() + " " + "miles";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
