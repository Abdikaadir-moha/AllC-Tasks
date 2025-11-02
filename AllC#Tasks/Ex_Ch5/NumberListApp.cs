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
    public partial class NameListApp : Form
    {
        public NameListApp()
        {
            InitializeComponent();
        }

        private void NumberListApp_Load(object sender, EventArgs e)
        {
            BackColor = AppTheme.BackgroundColor;
            headerPanel.FillColor = AppTheme.HeaderColor;
            titleLabel.ForeColor = AppTheme.HeaderTextColor;

            WritingNameButton.FillColor = AppTheme.PrimaryButtonColor;
            WritingNameButton.ForeColor = Color.White;

            ClearButton.FillColor = AppTheme.SecondaryButtonColor;
            ClearButton.ForeColor = Color.White;
        }

        private void WritingNameButton_Click(object sender, EventArgs e)
        {
            DataListBox.Items.Add(nameTextBox.Text);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DataListBox.Items.Clear();

        }
    }
}
