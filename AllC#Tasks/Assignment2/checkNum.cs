using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2
{
    public partial class checkNum : Form
    {
        public checkNum()
        {
            InitializeComponent();
        }

        private void OnepictureBox_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = "One";
        }

        private void TwopictureBox_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = "Two";
        }

        private void ThreepictureBox_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = "Three";
        }

        private void FourpictureBox_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = "Four";
        }

        private void FivepictureBox_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = "Five";
        }

        private void checkNum_Load(object sender, EventArgs e)
        {
            Labeldate.Text = DateTime.Now.ToString("dd, MM, yyyy, hh:mm:ss");
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
