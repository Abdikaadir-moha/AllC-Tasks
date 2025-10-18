using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignments1
{
    public partial class PictureProg : Form
    {
        public PictureProg()
        {
            InitializeComponent();
        }
        private void PictureProg_Load(object sender, EventArgs e)
        {
            Labeldate.Text = DateTime.Now.ToString("dd, MM , yyyy hh:mm:ss tt");
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is lion");
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
