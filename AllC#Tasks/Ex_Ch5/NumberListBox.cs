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
    public partial class NumberListBox : Form
    {
        public NumberListBox()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void Clearsbutton_Click(object sender, EventArgs e)
        {

        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NumberListBox_Load(object sender, EventArgs e)
        {
            BackColor = AppTheme.BackgroundColor;
            headerPanel.FillColor = AppTheme.HeaderColor;
            titleLabel.ForeColor = AppTheme.HeaderTextColor;

            AddingButton.FillColor = AppTheme.PrimaryButtonColor;
            AddingButton.ForeColor = Color.White;

            ClearButton.FillColor = AppTheme.SecondaryButtonColor;
            ClearButton.ForeColor = Color.White;
        }

        private void AddingButton_Click(object sender, EventArgs e)
        {
            numbersListBox.Items.Add(10);
            numbersListBox.Items.Add(20);
            numbersListBox.Items.Add(30);
            numbersListBox.Items.Add(40);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            numbersListBox.Items.Clear();
        }
    }
}
