using AllC_Tasks.Assignment4;
using AllC_Tasks.Assignment5;
using AllC_Tasks.Assignment6;
using AllC_Tasks.Ex_Ch2;
using AllC_Tasks.Ex_Ch6;
using assignment2;
using Assignments1;
using Freind_Files;
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

        private void Exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProfileToolStripMenuIte_Click(object sender, EventArgs e)
        {
            Profile ProfileForm = new();
            ProfileForm.Show();
        }

        //chapter 2 examples
        private void PictureBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureProg pictureProgForm = new();
            pictureProgForm.Show();
        }

        private void Tutorial_2_2_toolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DisplayMsg Msg = new();
            Msg.Show();
        }

        private void PresidentalTraviaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PresidentialTravia presidentalTraviaForm = new();
            presidentalTraviaForm.Show();
        }

        private void MultipleButtonControlsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            multiple_Button_controls multiple_Button_ControlsForm = new();
            multiple_Button_ControlsForm.Show();
        }

        private void Tutorial_2_3_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Translator translatorForm = new();
            translatorForm.Show();
        }

        private void Tutorial_2_4_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlagProg flagProgForm = new();
            flagProgForm.Show();
        }

        private void Tutorial_2_5_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            CardFlipProg cardFlipProgForm = new();
            cardFlipProgForm.Show();
        }

        //chapter 2 assignments
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
        private void JokeAndPunchLineProgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Joke_and_PunchLine joke_And_PunchLineForm = new();
            joke_And_PunchLineForm.Show();
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

        //chapter 3 examples
        private void StringDemoProgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String_Variable_Demo string_Variable_DemoForm = new();
            string_Variable_DemoForm.Show();
        }

        private void Tutorial_3_1toolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BirthDateProg birthDateProgform = new();
            birthDateProgform.Show();
        }

        private void Tutorial_3_2toolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Calcltng_Fuel_EconomyProg2 calcFuelEconform = new();
            calcFuelEconform.Show();
        }

        private void Tutorial_3_3toolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Sell_Price_Prog sellPriceProgform = new();
            sellPriceProgform.Show();
        }

        private void Tutorial_3_4toolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Test_AverageProg testAverageProgform = new();
            testAverageProgform.Show();
        }

        private void Tutorial_3_5toolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Change_CounterProg changeCounterProgform = new();
            changeCounterProgform.Show();
        }

        private void DemoFieldToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FieldDemo fieldDemoForm = new();
            fieldDemoForm.Show();
        }

        private void TabOrderProgToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TabOrder tabOrderForm = new();
            tabOrderForm.Show();
        }

        //Chapter 3 Assignments
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

        //Chapter 4 examples












        //Chapter 4 Assignments
        private void RomanNuturalToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            RomanNumeralConverter romanNumeralConverterform = new();
            romanNumeralConverterform.Show();
        }

        private void Mass_and_WeightToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Mass_and_Weight mass_And_Weightform = new();
            mass_And_Weightform.Show();
        }

        private void Magic_DatestoolStripMenuItem4_Click(object sender, EventArgs e)
        {
            MagicDates magicDatesform = new();
            magicDatesform.Show();
        }

        private void ColorMixerToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ColorMix colorMixform = new();
            colorMixform.Show();
        }

        private void Distance_ConverterToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            DistanceConverter distanceConverterform = new();
            distanceConverterform.Show();
        }

        private void Book_Club_PointsToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Book_Club_Points book_Club_Pointsform = new();
            book_Club_Pointsform.Show();
        }

        private void Software_SalesToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Software_Sales software_Salesform = new();
            software_Salesform.Show();
        }

        private void BodyMassToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            BodyMassIndex bodyMassIndexform = new();
            bodyMassIndexform.Show();
        }

        private void ChangeForDollarToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            ChangeForDollar changeForDollarform = new();
            changeForDollarform.Show();
        }

        private void FatPercentageToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Fat_Percentage_Calculator fat_Percentage_CalculatorForm = new();
            fat_Percentage_CalculatorForm.Show();
        }

        private void TimeCalculatorToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            TimeCalculator TimeCalculatorform = new();
            TimeCalculatorform.Show();
        }

        private void WorkshopSelectorToolStripMenuItem13_Click(object sender, EventArgs e)
        {
            WorkshopSelectorcs workshopSelectorcForm = new();
            workshopSelectorcForm.Show();
        }

        //Chapter 5 examples
















        //Chapter 5 Assignments
        private void DistanceCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DistanceCalculator distanceCalculatorform = new();
            distanceCalculatorform.Show();
        }

        private void DistanceFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Distance_File distance_Fileform = new();
            distance_Fileform.Show();
        }

        private void CelsiusToFahrenheitTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Celsius_to_Fahrenheit_Table celsius_To_Fahrenheit_Tableform = new();
            celsius_To_Fahrenheit_Tableform.Show();
        }

        private void PopulatioonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Population populationform = new();
            populationform.Show();
        }

        private void PenniesForPayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pennies_for_Pay pennies_For_Payform = new();
            pennies_For_Payform.Show();
        }

        private void OceanLevelsRiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ocean_Levels ocean_LevelsForm = new();
            ocean_LevelsForm.Show();
        }
        private void CaloriesBurnedTrackerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calories_Burned calories_BurnedForm = new();
            calories_BurnedForm.Show();
        }

        private void TuitionIncreaseProjectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tuition_Increase_Projection tuition_Increase_ProjectionForm = new();
            tuition_Increase_ProjectionForm.Show();
        }


        private void DiceSimulatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dice_Simulator dice_SimulatorForm = new();
            dice_SimulatorForm.Show();
        }

        private void AdditionTutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addition_Tutor addition_TutorForm = new();
            addition_TutorForm.Show();
        }

        private void RandomNumberGuessingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random_Number_Guessing_Game random_Number_Guessing_GameForm = new();
            random_Number_Guessing_GameForm.Show();
        }

        private void CalculatingTheFactorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculating_the_Factorialr calculating_The_FactorialrForm = new();
            calculating_The_FactorialrForm.Show();
        }

        private void RandomNumberFileWriterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomNumberFile randomNumberFileForm = new();
            randomNumberFileForm.Show();
        }

        private void RandomNumberFileReaderToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            RandomNumberFileReader randomNumberFileReader = new();
            randomNumberFileReader.Show();
        }

        //Chapter 6 examples
        private void Tutorial6_1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calling_Method_Tutorial_6_1 calling_Method_Tutorial_6_1Form = new();
            calling_Method_Tutorial_6_1Form.Show();
        }

        private void Tutorial6_2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PassingAnArgumentToMethodTutorial_6_2 passingAnArgumentToMethodTutorial_6_2Form = new();
            passingAnArgumentToMethodTutorial_6_2Form.Show();
        }

        private void PassByRefferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PassByRefApp passByRefAppForm = new();
            passByRefAppForm.Show();
        }

        private void Tutorial_6_3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimeZoneFinderTutorial_6_3 timeZoneFinderTutorial_6_3Form = new();
            timeZoneFinderTutorial_6_3Form.Show();
        }

        private void Tutorial_6_4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnMethod_Tutorial_6_4 returnMethod_Tutorial_6_4Form = new();
            returnMethod_Tutorial_6_4Form.Show();
        }

        private void Tutorial_6_5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModularizingBoolean_Tutorial_6_5 modularizingBoolean_Tutorial_6_5Form = new();
            modularizingBoolean_Tutorial_6_5Form.Show();
        }

        private void ReturningStringProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnStringProgram returnStringProgramForm = new();
            returnStringProgramForm.Show();
        }

        //Chapter 6 Assignments

        private void RetailPriceCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RetailPriceCalculator retailPriceCalculatorForm = new();
            retailPriceCalculatorForm.Show();
        }

        private void FallingDistanceCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FallingDistanceCalculator fallingDistanceCalculatorForm = new();
            fallingDistanceCalculatorForm.Show();
        }

        private void KineticEnergyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KineticEnergy kineticEnergyForm = new();
            kineticEnergyForm.Show();
        }

        private void CaloriesAndCarbohydratesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaloriesAndCarbohydrates caloriesAndCarbohydratesForm = new();
            caloriesAndCarbohydratesForm.Show();
        }

        private void JoesAutomotiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Joe_s_Automotive joe_S_AutomotiveForm = new();
            joe_S_AutomotiveForm.Show();
        }

        private void HospitalChargesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HospitalChargesCalculator hospitalChargesCalculatorForm = new();
            hospitalChargesCalculatorForm.Show();
        }

        private void PresentValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PresentValue PresentValueForm = new();
            PresentValueForm.Show();
        }

        private void PrimeNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrimeNumberChecker primeNumberCheckerForm = new();
            primeNumberCheckerForm.Show();
        }

        private void PrimeNumberListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrimeNumberList primeNumberListForm = new();
            primeNumberListForm.Show();
        }

        private void RockPaperScissorsGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RockPaperScissorsGame rockPaperScissorsGameForm = new();
            rockPaperScissorsGameForm.Show();
        }


        //chapter 5 example
        private void Tutorial_5_1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EndingBalance endingBalanceform = new();
            endingBalanceform.Show();
        }

        private void Tutorial_5_2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EndingBalanceListBox endingBalanceListBoxForm = new();
            endingBalanceListBoxForm.Show();
        }

        private void Tutorial_5_3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpeedConverter speedConverterForm = new();
            speedConverterForm.Show();
        }

        private void RandomObjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomObject randomObjectForm = new();
            randomObjectForm.Show();
        }

        private void WriteReadOpenSaveAndTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Write_read_Open_Save write_Read_Open_SaveForm = new();
            write_Read_Open_SaveForm.Show();
        }

        private void Tutorial58ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoinandToss coinandTossForm = new();
            coinandTossForm.Show();
        }
    }
}
