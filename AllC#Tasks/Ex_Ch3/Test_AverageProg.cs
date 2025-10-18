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
    public partial class Test_AverageProg : Form
    {
        public Test_AverageProg()
        {
            InitializeComponent();
        }

        private void Test_AverageProg_Load(object sender, EventArgs e)
        {
            Labeldate.Text = DateTime.Now.ToString("dd, MM , yyyy hh:mm:ss tt");
            test1TextBox.Focus();

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double test1;
                double test2;
                double test3;
                double average;

                // Get the three test scores.
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                // Calculate the average test score.
                average = (test1 + test2 + test3) / 3.0;

                // Display the average test score, with
                // the output rounded to 1 decimal point.
                averageLabel.Text = average.ToString("n1");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            test1TextBox.Clear();
            test2TextBox.Clear();
            test3TextBox.Clear();
            averageLabel.Text = "";
            test1TextBox.Focus();
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
