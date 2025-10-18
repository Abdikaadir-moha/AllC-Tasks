using AllC_Tasks;

namespace assignment2
{
    public partial class latinTranslator : Form
    {
        public latinTranslator()
        {
            InitializeComponent();
        }

        private void SinisterLabel_Click(object sender, EventArgs e)
        {
            En_1_Label.Text = "Left";
            En_2_Label.Text = "";
            En_3_Label.Text = "";
        }

        private void DexterLabel_Click(object sender, EventArgs e)
        {
            En_2_Label.Text = "Right";
            En_1_Label.Text = "";
            En_3_Label.Text = "";
        }

        private void MediumLabel_Click(object sender, EventArgs e)
        {
            En_3_Label.Text = "Center";
            En_1_Label.Text = "";
            En_2_Label.Text = "";
        }

        private void latinTranslator_Load(object sender, EventArgs e)
        {
            Labeldate.Text = DateTime.Now.ToString("dd, MM, yyyy, hh:mm:ss");
        }



        private void BackToMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuForm = new();
            mainMenuForm.Show();
            Close();
        }

        private void ResetLabelsBtn_Click(object sender, EventArgs e)
        {
            En_1_Label.Text = "";
            En_2_Label.Text = "";
            En_3_Label.Text = "";
        }
    }
}
