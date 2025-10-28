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
    public partial class Time_Zone_Application : Form
    {
        public Time_Zone_Application()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string city;   // To hold the name of a city

            // Make sure the user selected a city.
            if (cityListBox.SelectedIndex != -1 && cityListBox.SelectedItem != null)
            {
                // Get the selected item.
                city = cityListBox.SelectedItem?.ToString() ?? string.Empty;

                // Determine the time zone.
                switch (city)
                {
                    case "Honolulu":
                        timeZoneLabel.Text = "Honolulu is in the Hawaii-Aleutian Time zone.";
                        break;

                    case "Denver":
                        timeZoneLabel.Text = "Denver is in the Mountain Time Zone.";
                        break;

                    case "Minneapolis":
                        timeZoneLabel.Text = "Minneapolis is in the Central Time Zone.";
                        break;

                    case "New York":
                        timeZoneLabel.Text = "New York is in the Eastern Time Zone.";
                        break;

                    default:
                        MessageBox.Show("Please select a valid city.");
                        break;
                }
            }
            else
            {
                // Display an error if no city is selected.
                MessageBox.Show("Select a city from the list.");
            }
        }
    }
}
