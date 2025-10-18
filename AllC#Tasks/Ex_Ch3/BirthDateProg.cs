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
    public partial class BirthDateProg : Form
    {
        public BirthDateProg()
        {
            InitializeComponent();
        }

        private void BirthDateProg_Load(object sender, EventArgs e)
        {
            Labeldate.Text = DateTime.Now.ToString("dd, MM , yyyy hh:mm:ss tt");
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowDateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string Output;
                Output = DayOfWeekTextBox.Text + ", " +
                MonthTextBox.Text + " " +
                DayOfMonthTextBox.Text + ", " +
                YearTextBox.Text;

                DateOutputlabel.Text = Output;
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            DayOfWeekTextBox.Text = "";
            MonthTextBox.Text = "";
            DayOfMonthTextBox.Text = "";
            YearTextBox.Text = "";
            DateOutputlabel.Text = "";
            DayOfWeekTextBox.Focus();
        }
    }
}
