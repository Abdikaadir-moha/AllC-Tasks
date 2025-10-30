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
    public partial class WhileLoopDemo : Form
    {
        public WhileLoopDemo()
        {
            InitializeComponent();
        }

        private void gobutton_Click(object sender, EventArgs e)
        {
            int count = 1;

            // Display "Hello" in a message box five times. 
            while (count <= 5)

            {
                // Display the message box. 
                MessageBox.Show("Hello");

                // Add one to count. 
                count = count + 1;

            }
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
