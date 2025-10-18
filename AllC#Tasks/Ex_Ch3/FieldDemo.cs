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
    public partial class FieldDemo : Form
    {
        string name = "Diiriye";
        public FieldDemo()
        {
            InitializeComponent();
        }



        private void ShowNameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(name);
        }

        private void OmarButton_Click(object sender, EventArgs e)
        {
            name = "Omar";
        }

        private void SiyadButton_Click(object sender, EventArgs e)
        {
            name = "Siyad";
        }
    }
}
