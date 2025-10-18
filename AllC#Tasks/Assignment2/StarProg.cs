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
    public partial class StarProg : Form
    {
        public StarProg()
        {
            InitializeComponent();
        }

        private void StarProg_Load(object sender, EventArgs e)
        {
            Labeldate.Text = DateTime.Now.ToString("dd, MM , yyyy hh:mm:ss tt");
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Show_button_Click(object sender, EventArgs e)
        {
            Alnilam_label.Visible = true;
            Betel_label.Visible = true;
            Saiph_label.Visible = true;
            Mei_label.Visible = true;
            Mintaka_label.Visible = true;
            Alni_label.Visible = true;
            Rigel_label.Visible = true;
        }

        private void Hide_button_Click(object sender, EventArgs e)
        {
            Alnilam_label.Visible = false;
            Betel_label.Visible = false;
            Saiph_label.Visible = false;
            Mei_label.Visible = false;
            Mintaka_label.Visible = false;
            Alni_label.Visible = false;
            Rigel_label.Visible = false;
        }
    }
}
