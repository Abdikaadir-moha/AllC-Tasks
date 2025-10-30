using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wholeproject
{
    public partial class InfiniteLoop : Form
    {
        public InfiniteLoop()
        {
            InitializeComponent();
        }

        private void gobutton_Click(object sender, EventArgs e)
        {
           int count = 1;
            
  // How many times will this loop iterate?
           while (count <= 5)
            {
                
                MessageBox.Show("Hello");
            }
        }
    }
}
