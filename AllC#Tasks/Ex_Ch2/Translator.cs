using AllC_Tasks;

namespace Assignments1
{
    public partial class Translator : Form
    {
        public Translator()
        {
            InitializeComponent();
        }


        private void Translator_Load(object sender, EventArgs e)
        {
            Labeldate.Text = DateTime.Now.ToString("dd, MM , yyyy hh:mm:ss tt");
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SomaliBtn_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Soo Dhowow";
        }

        private void TurkeyBtn_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Hoş geldin.";
        }

        private void FranceBtn_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Bienvenue";
        }

    }
}
