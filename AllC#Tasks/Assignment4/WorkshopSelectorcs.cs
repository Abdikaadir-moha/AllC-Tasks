using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllC_Tasks.Assignment4
{
    public partial class WorkshopSelectorcs : Form
    {
        public WorkshopSelectorcs()
        {
            InitializeComponent();
        }

        private void WorkshopSelectorcs_Load(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure selections made
                if (workshopListBox.SelectedItem == null || locationListBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select both a workshop and a location.",
                                    "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Workshop info
                string workshop = workshopListBox.SelectedItem!.ToString() ?? string.Empty;
                int days = 0;
                double regFee = 0;

                switch (workshop)
                {
                    case "Handling Stress":
                        days = 3; regFee = 1000; break;
                    case "Time Management":
                        days = 3; regFee = 800; break;
                    case "Supervision Skills":
                        days = 3; regFee = 1500; break;
                    case "Negotiation":
                        days = 5; regFee = 1300; break;
                    case "How to Interview":
                        days = 1; regFee = 500; break;
                    default:
                        throw new InvalidOperationException("Unknown workshop selected.");
                }

                // Location info
                string location = locationListBox.SelectedItem!.ToString() ?? string.Empty;
                double lodgingFee = 0;

                switch (location)
                {
                    case "Austin": lodgingFee = 150; break;
                    case "Chicago": lodgingFee = 225; break;
                    case "Dallas": lodgingFee = 175; break;
                    case "Orlando": lodgingFee = 300; break;
                    case "Phoenix": lodgingFee = 175; break;
                    case "Raleigh": lodgingFee = 150; break;
                    default:
                        throw new InvalidOperationException("Unknown location selected.");
                }

                // Calculations
                double lodgingCost = lodgingFee * days;
                double totalCost = regFee + lodgingCost;

                // Display results (following your naming convention)
                registrationOutputLabel.Text = regFee.ToString("C");
                lodgingOutputLabel.Text = lodgingCost.ToString("C");
                totalOutputLabel.Text = totalCost.ToString("C");

                totalOutputLabel.ForeColor = System.Drawing.Color.DarkBlue;
            }
            catch (InvalidOperationException invEx)
            {
                // specific known invalid states
                MessageBox.Show(invEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // generic fallback for unexpected errors
                MessageBox.Show("An unexpected error occurred:\n" + ex.Message,
                                "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
