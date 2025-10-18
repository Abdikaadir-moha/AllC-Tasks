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
    public partial class HeadAndTail : Form
    {
        public HeadAndTail()
        {
            InitializeComponent();
        }

        private void HeadAndTail_Load(object sender, EventArgs e)
        {
            Labeldate.Text = DateTime.Now.ToString("dd, MM, yyyy, hh:mm:ss");
        }

        private void ShowHeadBtn_Click(object sender, EventArgs e)
        {
            HeadpictureBox.Visible = true;
            TailpictureBox.Visible = false;
        }

        private void ShowTailBtn_Click(object sender, EventArgs e)
        {
            TailpictureBox.Visible = true;
            HeadpictureBox.Visible = false;
        }

        

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
