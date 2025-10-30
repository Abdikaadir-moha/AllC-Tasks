using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllC_Tasks.Ex_Ch5
{
    public partial class NumberListApp : Form
    {
        public NumberListApp()
        {
            InitializeComponent();
        }

        private void WriteNameButton_Click(object sender, EventArgs e)
        {
            DataListBox.Items.Add(nameTextBox.Text);
        }
    }
}
