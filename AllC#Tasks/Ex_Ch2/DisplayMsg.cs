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
    public partial class DisplayMsg : Form
    {
        public DisplayMsg()
        {
            InitializeComponent();
        }

        private void HelloProg_Load(object sender, EventArgs e)
        {
            Labeldate.Text = DateTime.Now.ToString("dd, MM , yyyy hh:mm:ss tt");
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Somalibutton_Click(object sender, EventArgs e)
        {
            Somalialabel.Visible = true;
            Somalibutton.Visible = false;
        }

        private void Arabicbutton_Click(object sender, EventArgs e)
        {
            Arabiclabel.Visible = true;
            Arabicbutton.Visible = false;
        }

        private void Russiabutton_Click(object sender, EventArgs e)
        {
            Russialabel.Visible = true;
            Russiabutton.Visible = false;
        }

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            Somalialabel.Visible = false;
            Arabiclabel.Visible = false;
            Russialabel.Visible = false;
            Somalibutton.Visible = true;
            Arabicbutton.Visible = true;
            Russiabutton.Visible = true;
        }
    }
}
