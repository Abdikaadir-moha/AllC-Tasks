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
    public partial class NameList : Form
    {
        public NameList()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            nameListBox.Items.Add("Chris");
            nameListBox.Items.Add("Alicia");
            nameListBox.Items.Add("Justin");
            nameListBox.Items.Add("Holly");
        }

        private void Clearsbutton_Click(object sender, EventArgs e)
        {
            nameListBox.Items.Clear();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
