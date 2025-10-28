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
    public partial class ColorMix : Form
    {
        public ColorMix()
        {
            InitializeComponent();
        }

        private void MixButton_Click(object sender, EventArgs e)
        {
            try
            {
                string color1 = "";
                string color2 = "";

                // First Color
                if (rdoRed1.Checked) color1 = "Red";
                else if (rdoBlue1.Checked) color1 = "Blue";
                else if (rdoYellow1.Checked) color1 = "Yellow";
                else
                {
                    MessageBox.Show("Please select a color from the First Color group.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Second Color
                if (rdoRed2.Checked) color2 = "Red";
                else if (rdoBlue2.Checked) color2 = "Blue";
                else if (rdoYellow2.Checked) color2 = "Yellow";
                else
                {
                    MessageBox.Show("Please select a color from the Second Color group.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Mix colors
                if (color1 == color2)
                {
                    BackColor = Color.FromName(color1);
                }
                else if ((color1 == "Red" && color2 == "Blue") || (color1 == "Blue" && color2 == "Red"))
                    BackColor = Color.Purple;
                else if ((color1 == "Red" && color2 == "Yellow") || (color1 == "Yellow" && color2 == "Red"))
                    BackColor = Color.Orange;
                else if ((color1 == "Blue" && color2 == "Yellow") || (color1 == "Yellow" && color2 == "Blue"))
                    BackColor = Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
