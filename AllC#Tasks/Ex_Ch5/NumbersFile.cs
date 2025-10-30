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
    public partial class NumbersFile : Form
    {
        public NumbersFile()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Writenumberbutton_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare a StreamWriter variable.
                StreamWriter outputFile;

                // Create a file and get a StreamWriter object.
                outputFile = File.CreateText("Numbers.txt");
                // Write the numbers 1 through 10 to the file.
                for (int count = 1; count <= 10; count++)
                {
                    outputFile.WriteLine(count);
                }

                // Close the file.
                outputFile.Close();
                MessageBox.Show("The numbers was writen successfully.");
            }
            catch (Exception ex)
            {
                // Display an error message.
                MessageBox.Show(ex.Message);
            }

        }
    }
}
