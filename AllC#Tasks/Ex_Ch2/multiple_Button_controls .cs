using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllC_Tasks.Ex_Ch2
{
    public partial class multiple_Button_controls : Form
    {
        public multiple_Button_controls()
        {
            InitializeComponent();
        }

        private void FirstBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the First Button");
        }

        private void SecondBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the Second Button");
        }

        private void ThirdBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the Third Button");
        }
    }
}
