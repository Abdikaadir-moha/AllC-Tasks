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
    public partial class LoadEventApplication : Form
    {
        public LoadEventApplication()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadEventApplication_Load(object sender, EventArgs e)
        {
            try
            {
                // Declare a variable to hold a country name.
                string countryName;

                // Declare a StreamReader variable.
                StreamReader inputFile;

                // Open the file and get a StreamReader object.
                inputFile = File.OpenText("Countries.txt");

                // Read the file's contents.
                while (!inputFile.EndOfStream)
                {
                    // Get a country name.
                    countryName = inputFile.ReadLine();

                    // Add the country name to the ListBox.
                    countriesListBox.Items.Add(countryName);
                }

                // Close the file.
                inputFile.Close();
            }
            catch (Exception ex)
            {
                // Display an error message.
                MessageBox.Show(ex.Message);
            }

        }
    }
}
