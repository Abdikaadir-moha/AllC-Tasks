using AllC_Tasks.Ex_Ch2;
using assignment2;
using Assignments1;
using Wholeproject;
namespace AllC_Tasks
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void Chapter1_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There is no program in Chapter One.", "INFO");
        }

        private void Exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Translator_TSMI_Click(object sender, EventArgs e)
        {
            Translator translator = new();
            translator.Show();
        }

        private void Tutorial_2_2_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayMsg Msg = new();
            Msg.Show();
        }

        private void ProfileToolStripMenuIte_Click(object sender, EventArgs e)
        {
            Profile profileForm = new();
            profileForm.Show();
        }

        private void Pic_box_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox pictureBoxForm = new();
            pictureBoxForm.Show();
        }

        private void Flag_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlagProg flagProgForm = new();
            flagProgForm.Show();
        }

        private void CardFlipProg_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CardFlipProg cardFlipProgForm = new();
            cardFlipProgForm.Show();
        }
        private void LatinTrnlrProgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            latinTranslator latinTranslatorform = new();
            latinTranslatorform.Show();
        }



        private void CheckNumImgProgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkNum chekNumImgform = new();
            chekNumImgform.Show();
        }

        private void CardIdentifierProgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CardIdentifier cardIdentifierForm = new();
            cardIdentifierForm.Show();
        }

        private void Sh_H_CoinProgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HeadAndTail headAndTailForm = new();
            headAndTailForm.Show();
        }

        private void ShowHideShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StarProg starProgform = new();
            starProgform.Show();

        }

        private void Tutorial_3_1toolStripMenuItem_Click(object sender, EventArgs e)
        {
            BirthDateProg birthDateProgform = new();
            birthDateProgform.Show();
        }

        private void Tutorial_3_2toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calcltng_Fuel_EconomyProg2 calcFuelEconform = new();
            calcFuelEconform.Show();
        }

        private void Tutorial_3_3toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sell_Price_Prog sellPriceProgform = new();
            sellPriceProgform.Show();
        }

        private void Tutorial_3_4toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Test_AverageProg testAverageProgform = new();
            testAverageProgform.Show();
        }

        private void Tutorial_3_5toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_CounterProg changeCounterProgform = new();
            changeCounterProgform.Show();
        }

        private void Tutorial_2_3_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Language Translator Program is in the assignment one section.", "INFO");
        }

        private void Tutorial_2_4_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Flag Program is in the assignment one section.", "INFO");
        }

        private void Tutorial_2_5_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            CardFlipProg cardFlipProgForm = new();
            cardFlipProgForm.Show();
        }

        private void NameFormatterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NameFormatter nameFormatterForm = new();
            nameFormatterForm.Show();
        }

        private void TipTaxAndTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tip_Tax_Total tip_Tax_Totalform = new();
            tip_Tax_Totalform.Show();
        }

        private void DistanceTraveledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DistanceTravel distanceTravelform = new();
            distanceTravelform.Show();
        }

        private void SalesTaxAndTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales_Tax_and_Total sales_Tax_And_TotalForm = new();
            sales_Tax_And_TotalForm.Show();
        }

        private void CelsiusAndFahrenheitTemperatureConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cel_Fahrenheit_Temp cel_Fahrenheit_Tempform = new();
            cel_Fahrenheit_Tempform.Show();
        }

        private void BodyMassIndexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Body_Mass_Index body_Mass_Indexform = new();
            body_Mass_Indexform.Show();
        }

        private void SentenceBuilderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sentence_Builder sentence_Builderform = new();
            sentence_Builderform.Show();
        }

        private void HowMuchInsuranceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            How_Much_Insurance how_Much_Insuranceform = new();
            how_Much_Insuranceform.Show();
        }

        private void CookieCaloriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cookie_Calories how_Cookie_Caloriesform = new();
            how_Cookie_Caloriesform.Show();
        }

        private void CalorieCounterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calorie_Counter Calorie_CounterForm = new();
            Calorie_CounterForm.Show();
        }

        private void AutomobileCostsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Automobile_Costs automobile_CostsForm = new();
            automobile_CostsForm.Show();
        }

        private void PaintJobEstimatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paint_Job_Estimator paint_Job_EstimatorForm = new();
            paint_Job_EstimatorForm.Show();
        }

        private void PropertyTaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Property_Tax property_TaxForm = new();
            property_TaxForm.Show();
        }

        private void StadiumSeatingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stadium_Seating stadium_SeatingForm = new();
            stadium_SeatingForm.Show();
        }

        private void PresidentalTraviaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PresidentialTravia presidentalTraviaForm = new();
            presidentalTraviaForm.Show();
        }

        private void JokeAndPunchLineProgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Joke_and_PunchLine joke_And_PunchLineForm = new();
            joke_And_PunchLineForm.Show();
        }

        private void StringDemoProgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String_Variable_Demo string_Variable_DemoForm = new();
            string_Variable_DemoForm.Show();
        }

        private void TabOrderProgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabOrder tabOrderForm = new();
            tabOrderForm.Show();
        }

        private void DemoFieldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FieldDemo fieldDemoForm = new();
            fieldDemoForm.Show();
        }

        private void MultipleButtonControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            multiple_Button_controls multiple_Button_ControlsForm = new();
            multiple_Button_ControlsForm.Show();
        }

        
    }
}
