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
    public partial class CardFlipProg : Form
    {
        public CardFlipProg()
        {
            InitializeComponent();
        }

        private void ShowFaceButton_Click(object sender, EventArgs e)
        {
            CardBackPictureBox.Visible = false;
            CardFacePictureBox.Visible = true;
        }

        private void ShowBackButton_Click(object sender, EventArgs e)
        {
            CardBackPictureBox.Visible = true;
            CardFacePictureBox.Visible = false;
        }

        private void CardFlipProg_Load(object sender, EventArgs e)
        {
            Labeldate.Text = DateTime.Now.ToString("dd, MM, yyyy, hh:mm:ss");
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
