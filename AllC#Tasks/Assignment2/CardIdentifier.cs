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
    public partial class CardIdentifier : Form
    {
        public CardIdentifier()
        {
            InitializeComponent();
        }

        private void CardIdentifier_Load(object sender, EventArgs e)
        {
            Labeldate.Text = DateTime.Now.ToString("dd, MM, yyyy, hh:mm:ss");
        }

        private void KingpictureBox_Click(object sender, EventArgs e)
        {
            DisplayCardNameLabel.Text = "King";
        }

        private void EightHeartpictureBox_Click(object sender, EventArgs e)
        {
            DisplayCardNameLabel.Text = "Eight of Hearts";
        }

        private void QueenpictureBox_Click(object sender, EventArgs e)
        {
            DisplayCardNameLabel.Text = "Queen";
        }

        private void AcepictureBox_Click(object sender, EventArgs e)
        {
            DisplayCardNameLabel.Text = "Ace";
        }

        private void JokerpictureBox_Click(object sender, EventArgs e)
        {
            DisplayCardNameLabel.Text = "Joker";
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
