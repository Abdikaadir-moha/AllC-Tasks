using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AllC_Tasks;

namespace Freind_Files
{
    public partial class Write_read_Open_Save : Form
    {
        int total = 0;
        public Write_read_Open_Save()
        {

            InitializeComponent();
        }

        private void Write_button_Click(object sender, EventArgs e)
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
            }
            catch (Exception ex)
            {
                // Display an error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void Read_button_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare a variable to hold an item read from the file.
                int num;

                // Declare a StreamReader variable.
                StreamReader inputFile;

                // Open the file and get a StreamReader object.
                inputFile = File.OpenText("Numbers.txt");

                // Read and display the first name.
                while (!inputFile.EndOfStream)
                {
                    num = int.Parse(inputFile.ReadLine());
                    DisplaylistBox.Items.Add(num);

                    total += num;

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

        private void ShowTotal_Click(object sender, EventArgs e)
        {
            TotalLabel.Text = total.ToString("c");
        }

        private void OpenFIleButton_Click(object sender, EventArgs e)
        {
            StreamReader OutputFile;

            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                OutputFile = File.OpenText(OpenFile.FileName);
                while (!OutputFile.EndOfStream)
                {
                    DisplaylistBox.Items.Add(OutputFile.ReadLine());
                }
            }
            else
            {
                MessageBox.Show("Operation canceled.");
            }
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            StreamWriter InputFile;
            InputFile = File.CreateText(SaveFile.FileName);

            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                // Write the numbers 1 through 10 to the file.
                for (int count = 10; count <= 20; count++)
                {
                    InputFile.WriteLine(count);
                }
                // Close the file.
                InputFile.Close();
            }
            else
            {
                MessageBox.Show("Operation canceled.");
            }
        }

        private void Write_read_Open_Save_Load(object sender, EventArgs e)
        {
            BackColor = AppTheme.BackgroundColor;
            headerPanel.FillColor = AppTheme.HeaderColor;
            titleLabel.ForeColor = AppTheme.HeaderTextColor;

            ClearButton.FillColor = AppTheme.SecondaryButtonColor;
            ClearButton.ForeColor = Color.White;
        }
    }
}
