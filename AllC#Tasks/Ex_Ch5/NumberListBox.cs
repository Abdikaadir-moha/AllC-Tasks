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
    public partial class NumberListBox : Form
    {
        public NumberListBox()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            numbersListBox.Items.Add(10);
            numbersListBox.Items.Add(20);
            numbersListBox.Items.Add(30);
            numbersListBox.Items.Add(40);
        }

        private void Clearsbutton_Click(object sender, EventArgs e)
        {
            numbersListBox.Items.Clear();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
