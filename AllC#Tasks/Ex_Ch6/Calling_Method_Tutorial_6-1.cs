using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllC_Tasks.Ex_Ch6
{
    public partial class Calling_Method_Tutorial_6_1 : Form
    {
        public Calling_Method_Tutorial_6_1()
        {
            InitializeComponent();
        }
        private void TurnLightOn()
        {
            // Display the "light on" image
            lightOnPictureBox.Visible = true;

            // Hide the "light off" image
            lightOffPictureBox.Visible = false;

            // Display the light's state
            lightStateLabel.Text = "ON";
        }

        private void TurnLightOff()
        {
            // Display the "light off" image
            lightOffPictureBox.Visible = true;

            // Hide the "light on" image
            lightOnPictureBox.Visible = false;

            // Display the light's state
            lightStateLabel.Text = "OFF";
        }

        private void SwitchButton_Click(object sender, EventArgs e)
        {
            // Reverse the light’s state
            if (lightOnPictureBox.Visible == true)
            {
                TurnLightOff();
            }
            else
            {
                TurnLightOn();
            }
        }
    }
}
