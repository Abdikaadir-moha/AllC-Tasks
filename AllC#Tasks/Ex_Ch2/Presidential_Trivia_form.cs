using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllC_Tasks.Ex_Ch2
{
    public partial class PresidentialTravia : Form
    {
        public PresidentialTravia()
        {
            InitializeComponent();
        }

        private void ShowAnswerBtn_Click(object sender, EventArgs e)
        {
            AnswerLabel.Text = "Hassan Shiekh Mohamud";
        }
    }
}
