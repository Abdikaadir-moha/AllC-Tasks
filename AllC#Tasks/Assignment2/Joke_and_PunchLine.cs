using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2
{
    public partial class Joke_and_PunchLine : Form
    {
        public Joke_and_PunchLine()
        {
            InitializeComponent();
        }

        private void btnSetup__Click(object sender, EventArgs e)
        {
            Jokelabel.Text = "Why do programmers prefer dark mode?";

        }

        private void btnPunchLine_Click(object sender, EventArgs e)
        {
            Jokelabel.Text = "Because light attracts bugs!";
        }

    }
}
