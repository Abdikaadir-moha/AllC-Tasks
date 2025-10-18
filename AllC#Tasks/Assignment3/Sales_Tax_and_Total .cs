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
    public partial class Sales_Tax_and_Total : Form
    {
        public Sales_Tax_and_Total()
        {
            InitializeComponent();
        }

        private void Sales_Tax_and_Total_Load(object sender, EventArgs e)
        {

        }

        private void Calculatebutton_Click(object sender, EventArgs e)
        {
            double AmountPurchase, StateSale, CounrySale, total;
            AmountPurchase = double.Parse(amountpurchasetextBox.Text);
            StateSale = AmountPurchase * 0.04;
            CounrySale = AmountPurchase * 0.02;
            total = AmountPurchase + StateSale + CounrySale;

            Sate_label.Text = StateSale.ToString("c");
            Country_Sales_TaxLabel.Text = CounrySale.ToString("c");
            TotalSalesLabel.Text = total.ToString("c");
        }
    }
}
