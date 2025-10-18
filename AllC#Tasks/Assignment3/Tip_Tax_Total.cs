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
    public partial class Tip_Tax_Total : Form
    {
        const decimal percent_tip = 0.15m;
        const decimal percent_sales_tax = 0.07m;

        public Tip_Tax_Total()
        {
            InitializeComponent();
        }

        private void Calculatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal foodCharge = decimal.Parse(FoodChargetextBox.Text);

                decimal total = foodCharge + percent_tip + percent_sales_tax;

                Totallabel.Text = total.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Tip_Tax_Total_Load(object sender, EventArgs e)
        {
            FoodChargetextBox.Focus();
            tipLabel.Text = percent_tip.ToString();
            taxLabel.Text = percent_sales_tax.ToString();
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            FoodChargetextBox.Clear();
            Totallabel.Text = "";
        }
    }
}
