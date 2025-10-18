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
    public partial class NameFormatter : Form
    {
        public NameFormatter()
        {
            InitializeComponent();
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            FirstNametextBox.Clear();
            MiddleNametextBox.Clear();
            LastNametextBox.Clear();
            TitleNametextBox.Clear();
            OutputLabel.Text = "";

            FirstNametextBox.Focus();
        }

        private void NameFormatter_Load(object sender, EventArgs e)
        {
            FirstNametextBox.Focus();
        }

        private void Way1DisplayButton_Click(object sender, EventArgs e)
        {
            string Firstname = FirstNametextBox.Text;
            string MiddleName = MiddleNametextBox.Text;
            string Lastname = LastNametextBox.Text;
            string Title = TitleNametextBox.Text;

            string fullname = Title + " " + Firstname + " " + MiddleName + " " + Lastname;

            OutputLabel.Text = fullname;
        }

        private void Way2DisplayButton_Click(object sender, EventArgs e)
        {
            string Firstname = FirstNametextBox.Text;
            string MiddleName = MiddleNametextBox.Text;
            string Lastname = LastNametextBox.Text;

            string fullname = Firstname + " " + MiddleName + " " + Lastname;

            OutputLabel.Text = fullname;
        }

        private void Way3DisplayButton_Click(object sender, EventArgs e)
        {
            string Firstname = FirstNametextBox.Text;
            string MiddleName = MiddleNametextBox.Text;
            string Lastname = LastNametextBox.Text;

            string fullname = Firstname + Lastname;

            OutputLabel.Text = fullname;
        }

        private void Way4DisplayButton_Click(object sender, EventArgs e)
        {
            string Firstname = FirstNametextBox.Text;
            string MiddleName = MiddleNametextBox.Text;
            string Lastname = LastNametextBox.Text;
            string Title = TitleNametextBox.Text;

            string fullname = Lastname + " " + Firstname + " " + MiddleName + " " + Title;

            OutputLabel.Text = fullname;
        }

        private void Way5DisplayButton_Click(object sender, EventArgs e)
        {
            string Firstname = FirstNametextBox.Text;
            string MiddleName = MiddleNametextBox.Text;
            string Lastname = LastNametextBox.Text;
            string Title = TitleNametextBox.Text;

            string fullname = Lastname + " " + Firstname + " " + MiddleName;

            OutputLabel.Text = fullname;
        }

        private void Way6DisplayButton_Click(object sender, EventArgs e)
        {
            string Firstname = FirstNametextBox.Text;
            string MiddleName = MiddleNametextBox.Text;
            string Lastname = LastNametextBox.Text;
            string Title = TitleNametextBox.Text;

            string fullname = Lastname + " " + Firstname + " " + MiddleName;

            OutputLabel.Text = fullname;
        }
    }
}
