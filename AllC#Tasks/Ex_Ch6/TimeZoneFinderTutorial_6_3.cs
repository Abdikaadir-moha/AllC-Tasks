using System.Xml.Linq;

namespace AllC_Tasks.Ex_Ch6
{
    public partial class TimeZoneFinderTutorial_6_3 : Form
    {
        public TimeZoneFinderTutorial_6_3()
        {
            InitializeComponent();
        }
        private void GetFileName(out string selectedFile)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedFile = openFileDialog1.FileName;
            }
            else
            {
                selectedFile = "";
            }
        }

        private void GetCountries(string filename)
        {
            try
            {
                // Clear the ListBox before adding new items
                countriesListBox.Items.Clear();

                // Read all lines from the file and add them to the ListBox
                foreach (string countryName in File.ReadLines(filename))
                {
                    countriesListBox.Items.Add(countryName);
                }

                // Clear any previous error messages if successful
                messageLabel.ForeColor = AppTheme.SuccessColor;
                messageLabel.Text = "Countries loaded successfully.";
            }
            catch (Exception ex)
            {
                // Handle the exception by displaying error in label
                messageLabel.Text = $"Error reading file: {ex.Message}";
                messageLabel.Visible = true;
                messageLabel.ForeColor = Color.Red; // Optional: set error color
            }
        }
        private void TimeZoneFinderTutorial_6_3_Load(object sender, EventArgs e)
        {
            BackColor = AppTheme.BackgroundColor;

            headerPanel.FillColor = AppTheme.HeaderColor;
            titleLabel.ForeColor = AppTheme.HeaderTextColor;
            titleLabel.Font = AppTheme.HeaderFont;

            // Style standard ListBox manually
            countriesListBox.BackColor = AppTheme.TextBoxBackColor;
            countriesListBox.BorderStyle = BorderStyle.FixedSingle;
            countriesListBox.ForeColor = AppTheme.TextColor;
            countriesListBox.Font = AppTheme.BodyFont;

            OkButton.FillColor = AppTheme.PrimaryButtonColor;
            OkButton.Font = AppTheme.ButtonFont;
            OkButton.ForeColor = Color.White;

            messageLabel.ForeColor = AppTheme.TextColor;
            messageLabel.Font = AppTheme.BodyFont;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string filename; // To hold the filename

            // Get the filename from the user.
            GetFileName(out filename);

            // Get the countries from the file.
            GetCountries(filename);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            countriesListBox.Items.Clear();
            messageLabel.Text = "";
        }
    }
}
