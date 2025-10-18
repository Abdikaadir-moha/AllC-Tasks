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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            Labeldate.Text = DateTime.Now.ToString("dd, MM , yyyy hh:mm:ss tt");
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
