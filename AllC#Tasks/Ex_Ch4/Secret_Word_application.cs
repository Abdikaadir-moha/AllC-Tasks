using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllC_Tasks.Ex_Ch4
{
    public partial class Secret_Word_application : Form
    {
        public Secret_Word_application()
        {
            InitializeComponent();
        }

        private void Secret_Word_application_Load(object sender, EventArgs e)
        {

        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the user's input
                string secretWord = inputTextBox.Text;

                // Check if the user entered the correct secret word
                if (secretWord == "Ariel")
                {
                    MessageBox.Show("That is the correct secret word.");
                }
                else
                {
                    MessageBox.Show("Sorry, that is NOT the secret word.");
                }
            }
            catch (Exception ex)
            {
                // Display an error message if something goes wrong
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
