using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AllC_Tasks;

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

        private void AddingButton_Click(object sender, EventArgs e)
        {
            nameListBox.Items.Add("Chris");
            nameListBox.Items.Add("Alicia");
            nameListBox.Items.Add("Justin");
            nameListBox.Items.Add("Holly");
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            nameListBox.Items.Clear();
        }

        private void NameList_Load(object sender, EventArgs e)
        {
            BackColor = AppTheme.BackgroundColor;
            headerPanel.FillColor = AppTheme.HeaderColor;
            titleLabel.ForeColor = AppTheme.HeaderTextColor;

            AddingButton.FillColor = AppTheme.PrimaryButtonColor;
            AddingButton.ForeColor = Color.White;

            ClearBtn.FillColor = AppTheme.SecondaryButtonColor;
            ClearBtn.ForeColor = Color.White;

            messageLabel.ForeColor = AppTheme.TextColor;
        }
    }
}
