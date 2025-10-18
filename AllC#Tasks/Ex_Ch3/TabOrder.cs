using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wholeproject
{
    public partial class TabOrder : Form
    {
        public TabOrder()
        {
            InitializeComponent();
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            nametextBox.Text = "";
            addresstextBox.Text = "";
            citytextBox.Text = "";
            statetextBox.Text = "";
            ziptextBox.Text = "";
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
