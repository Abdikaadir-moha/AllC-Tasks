using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Wholeproject
{
    public partial class FriendFile : Form
    {
        public FriendFile()
        {
            InitializeComponent();
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Writebutton_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare a StreamWriter variable.
                StreamWriter outputFile;

                // Create a file and get a StreamWriter object.
                outputFile = File.CreateText("Friend.txt");

                // Write the friend's name to the file.
                outputFile.WriteLine(nameTextBox.Text);

                // Close the file.
                outputFile.Close();

                // Let the user know the name was written.
                MessageBox.Show("The name was written.");
            }
            catch (Exception ex)
            {
                // Display an error message.
                MessageBox.Show(ex.Message);
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
