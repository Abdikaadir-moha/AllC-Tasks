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
    public partial class String_Variable_Demo : Form
    {
        public String_Variable_Demo()
        {
            InitializeComponent();
        }

        private void showNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                string Fullname;
                Fullname = firstNametextBox.Text + " " + lastNametextBox.Text;
                fullNamelabel.Text = Fullname;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void String_Variable_Demo_Load(object sender, EventArgs e)
        {
            firstNametextBox.Focus();
        }

    }
}
