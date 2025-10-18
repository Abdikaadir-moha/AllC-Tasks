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
    public partial class Sell_Price_Prog : Form
    {
        public Sell_Price_Prog()
        {
            InitializeComponent();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            originalPriceTextBox.Clear();
            discountPercentageTextBox.Clear();
            outputDescriptionLabel.Text = "";
            originalPriceTextBox.Focus();
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            decimal originalPrice;
            decimal discountPercentage;
            decimal discountAmount;
            decimal salePrice;


            originalPrice = decimal.Parse(originalPriceTextBox.Text);


            discountPercentage = decimal.Parse(discountPercentageTextBox.Text);


            discountPercentage = discountPercentage / 100;


            discountAmount = originalPrice * discountPercentage;


            salePrice = originalPrice - discountAmount;


            outputDescriptionLabel.Text = salePrice.ToString("c");
        }

        private void Sell_Price_Prog_Load(object sender, EventArgs e)
        {
            originalPriceTextBox.Focus();
            Labeldate.Text = DateTime.Now.ToString("dd, MM , yyyy hh:mm:ss tt");
        }
    }
}
