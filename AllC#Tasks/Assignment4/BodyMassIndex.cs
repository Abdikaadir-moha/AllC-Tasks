using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllC_Tasks.Assignment4
{
    public partial class BodyMassIndex : Form
    {
        public BodyMassIndex()
        {
            InitializeComponent();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double weight = double.Parse(WeightTextBox.Text);
                double height = double.Parse(HeightTextBox.Text);

                double bmi = (weight * 703) / (height * height);

                BmiResultLabel.Text = bmi.ToString("F1");

                if (bmi < 18.5)
                {
                    MessageLabel.Text = "You are Underweight.";
                    MessageLabel.ForeColor = Color.Blue;
                }
                else if (bmi >= 18.5 && bmi <= 25)
                {
                    MessageLabel.Text = "You have Optimal weight.";
                    MessageLabel.ForeColor = Color.Green;
                }
                else
                {
                    MessageLabel.Text = "You are Overweight.";
                    MessageLabel.ForeColor = Color.Red;
                }
            }
            catch
            {
                MessageBox.Show("Please enter valid numeric values for weight and height.",
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
