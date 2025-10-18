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
    public partial class Change_CounterProg : Form
    {
        // Constant fields
        const decimal FIVE_CENTS_VALUE = 0.05m;
        const decimal TEN_CENTS_VALUE = 0.10m;
        const decimal TWENTY_FIVE_CENTS_VALUE = 0.25m;
        const decimal FIFTY_CENTS_VALUE = 0.50m;

        private decimal total = 0m;

        public Change_CounterProg()
        {
            InitializeComponent();
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            total = +FIVE_CENTS_VALUE;
            totalLabel.Text = total.ToString("c");
        }

        private void TenCentsPictureBox_Click(object sender, EventArgs e)
        {
            total =+ TEN_CENTS_VALUE;
            totalLabel.Text = total.ToString("c");
        }

        private void TwentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            total =+ TWENTY_FIVE_CENTS_VALUE;
            totalLabel.Text = total.ToString("c");
        }

        private void FiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            total =+ FIFTY_CENTS_VALUE;
            totalLabel.Text = total.ToString("c");
        }
    }
}
