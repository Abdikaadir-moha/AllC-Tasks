using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AllC_Tasks;

namespace Assignments1
{
    public partial class FlagProg : Form
    {
        public FlagProg()
        {
            InitializeComponent();
        }

        private void SomaliaPictureBox_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "Somalia";
        }
        private void PalestinePictureBox_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "Palestine";
        }

        private void TurkeyPictureBox_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "Turkey";
        }

        private void FlagProg_Load(object sender, EventArgs e)
        {
            Labeldate.Text = DateTime.Now.ToString("dd, MM , yyyy hh:mm:ss tt");
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
