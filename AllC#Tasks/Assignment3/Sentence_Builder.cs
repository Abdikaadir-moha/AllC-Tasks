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
    public partial class Sentence_Builder : Form
    {
        public Sentence_Builder()
        {
            InitializeComponent();
        }

        private void Sentence_Builder_Load(object sender, EventArgs e)
        {

        }

        private void ButtonA_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "A ";
        }

        private void AButton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "a ";
        }

        private void Button_An_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "An ";
        }

        private void Btn_an_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "an ";
        }

        private void Button_The_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "The ";
        }

        private void Btn_the_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "the ";
        }

        private void Beautybutton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "beautiful ";
        }

        private void Bigbutton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "big ";
        }

        private void Smallbutton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "small ";
        }

        private void Strangebutton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "strange";
        }

        private void Manbutton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "Man ";
        }

        private void Womenbutton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "Women ";
        }

        private void Dobutton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "Dog ";
        }

        private void Catbutton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "Cat ";
        }

        private void Carbutton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "car";
        }

        private void Bicyclebutton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "bicycle ";
        }

        private void Lokedbutton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "looked at ";
        }

        private void Nodebutton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "node ";
        }

        private void SpokeTobutton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "spoke to ";
        }

        private void LaughtedAtbutton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "laughed at ";
        }

        private void Drovebutton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "drove";
        }

        private void Spacebutton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "  ";
        }

        private void Dotbutton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += ".";
        }

        private void Exclamationbutton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "!";
        }
    }
}
