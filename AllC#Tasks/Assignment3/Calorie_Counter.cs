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
    public partial class Calorie_Counter : Form
    {
        int total = 0;
        public Calorie_Counter()
        {
            InitializeComponent();
        }
        private void BananPictureBox_Click(object sender, EventArgs e)
        {
            total += 115;
            Resultlabel.Text = total.ToString();
        }

        private void ApplePictureBox_Click_1(object sender, EventArgs e)
        {
            total += 80;
            Resultlabel.Text = total.ToString();
        }

        private void OrangePictureBox_Click_1(object sender, EventArgs e)
        {
            total += 90;
            Resultlabel.Text = total.ToString();
        }

        private void PearPictureBox_Click_1(object sender, EventArgs e)
        {
            total += 120;
            Resultlabel.Text = total.ToString();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            total = 0;
            Resultlabel.Text = "0";
        }
    }
}
