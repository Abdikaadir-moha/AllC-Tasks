using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllC_Tasks.Assignment6
{
    public partial class Joe_s_Automotive : Form
    {
        // === Constants ===
        private const double OIL_CHANGE = 26.00;
        private const double LUBE_JOB = 18.00;
        private const double RADIATOR_FLUSH = 30.00;
        private const double TRANSMISSION_FLUSH = 80.00;
        private const double INSPECTION = 15.00;
        private const double MUFFLER = 100.00;
        private const double TIRE_ROTATION = 20.00;
        private const double LABOR_RATE = 20.00;
        private const double TAX_RATE = 0.06;
        public Joe_s_Automotive()
        {
            InitializeComponent();
        }

        private void Joe_s_Automotive_Load(object sender, EventArgs e)
        {
            BackColor = AppTheme.BackgroundColor;

            // Iterate actual Guna2GroupBox instances on the form instead of assuming
            // System.Windows.Forms.GroupBox fields or specific designer field names exist.
            foreach (var gb in this.Controls.OfType<Guna.UI2.WinForms.Guna2GroupBox>())
            {
                gb.BackColor = AppTheme.BackgroundColor;
                gb.ForeColor = AppTheme.TextColor;
            }

            foreach (var txt in new Guna.UI2.WinForms.Guna2TextBox[]
            { partsTextBox, laborTextBox })
            {
                txt.FillColor = AppTheme.TextBoxBackColor;
                txt.BorderColor = AppTheme.TextBoxBorderColor;
                txt.ForeColor = AppTheme.TextColor;
                txt.Font = AppTheme.BodyFont;
            }

            foreach (var lbl in new Control[]
            { serviceAndLaborLabel, partsTotalLabel, taxLabel, totalFeesLabel, messageLabel })
            {
                lbl.ForeColor = AppTheme.TextColor;
                lbl.Font = AppTheme.BodyFont;
                lbl.BackColor = AppTheme.BackgroundColor;
            }

            CalculateButton.FillColor = AppTheme.PrimaryButtonColor;
            ClearButton.FillColor = AppTheme.SecondaryButtonColor;

            CalculateButton.Font = AppTheme.ButtonFont;
            ClearButton.Font = AppTheme.ButtonFont;


            partsTextBox.Select();
        }

        // === Helper Methods ===
        private double OilLubeCharges()
        {
            double total = 0;
            if (oilChangeCheckBox.Checked) total += OIL_CHANGE;
            if (lubeJobCheckBox.Checked) total += LUBE_JOB;
            return total;
        }

        private double FlushCharges()
        {
            double total = 0;
            if (radiatorFlushCheckBox.Checked) total += RADIATOR_FLUSH;
            if (transmissionFlushCheckBox.Checked) total += TRANSMISSION_FLUSH;
            return total;
        }

        private double MiscCharges()
        {
            double total = 0;
            if (inspectionCheckBox.Checked) total += INSPECTION;
            if (mufflerCheckBox.Checked) total += MUFFLER;
            if (tireRotationCheckBox.Checked) total += TIRE_ROTATION;
            return total;
        }

        private double OtherCharges()
        {
            try
            {
                double parts = string.IsNullOrWhiteSpace(partsTextBox.Text) ? 0 : Convert.ToDouble(partsTextBox.Text);
                double laborHours = string.IsNullOrWhiteSpace(laborTextBox.Text) ? 0 : Convert.ToDouble(laborTextBox.Text);
                return parts + (laborHours * LABOR_RATE);
            }
            catch
            {
                messageLabel.ForeColor = AppTheme.WarningColor;
                messageLabel.Text = "Enter valid numeric values for Parts and Labor.";
                return 0;
            }
        }

        private double TaxCharges(double parts)
        {
            return parts > 0 ? parts * TAX_RATE : 0;
        }

        private double TotalCharges()
        {
            double parts = string.IsNullOrWhiteSpace(partsTextBox.Text) ? 0 : Convert.ToDouble(partsTextBox.Text);
            return OilLubeCharges() + FlushCharges() + MiscCharges() + OtherCharges() + TaxCharges(parts);
        }

        // === Clear Methods ===
        private void ClearOilLube() => oilChangeCheckBox.Checked = lubeJobCheckBox.Checked = false;
        private void ClearFlushes() => radiatorFlushCheckBox.Checked = transmissionFlushCheckBox.Checked = false;
        private void ClearMisc() => inspectionCheckBox.Checked = mufflerCheckBox.Checked = tireRotationCheckBox.Checked = false;
        private void ClearOther()
        {
            partsTextBox.Clear();
            laborTextBox.Clear();
        }
        private void ClearFees()
        {
            serviceAndLaborLabel.Text = "";
            partsTotalLabel.Text = "";
            taxLabel.Text = "";
            totalFeesLabel.Text = "";
            messageLabel.Text = "";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double parts = string.IsNullOrWhiteSpace(partsTextBox.Text) ? 0 : Convert.ToDouble(partsTextBox.Text);
                double laborHours = string.IsNullOrWhiteSpace(laborTextBox.Text) ? 0 : Convert.ToDouble(laborTextBox.Text);
                double serviceAndLabor = OilLubeCharges() + FlushCharges() + MiscCharges() + (laborHours * LABOR_RATE);
                double tax = TaxCharges(parts);
                double total = serviceAndLabor + parts + tax;

                serviceAndLaborLabel.Text = serviceAndLabor.ToString("C");
                partsTotalLabel.Text = parts.ToString("C");
                taxLabel.Text = tax.ToString("C");
                totalFeesLabel.Text = total.ToString("C");

                messageLabel.ForeColor = AppTheme.SuccessColor;
                messageLabel.Text = "Calculation complete.";

                partsTextBox.Clear();
                laborTextBox.Clear();

                partsTextBox.Select();
            }
            catch
            {
                messageLabel.ForeColor = AppTheme.DangerButtonColor;
                messageLabel.Text = "Error: Please enter valid numeric input.";
            }
        }

        // PSEUDOCODE / PLAN:
        // 1. When Clear button is clicked, completely reset the form state.
        // 2. Clear displayed fee labels and any messages.
        // 3. Uncheck all service-related checkboxes (oil/lube, flushes, misc).
        // 4. Clear parts and labor input textboxes.
        // 5. Reset message color to normal and focus the Parts textbox.
        // Implementation:
        // - Reuse the existing helper methods: ClearFees(), ClearOilLube(), ClearFlushes(), ClearMisc(), ClearOther().
        // - Ensure message label color is restored to AppTheme.TextColor (neutral).
        // - Select the partsTextBox for user convenience.

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clear displayed fee labels and message
            ClearFees();

            // Uncheck all service checkboxes
            ClearOilLube();
            ClearFlushes();
            ClearMisc();

            // Clear parts and labor inputs
            ClearOther();

            // Reset message label color to default/neutral
            messageLabel.ForeColor = AppTheme.TextColor;

            // Focus the parts textbox for convenience
            partsTextBox.Select();
        }
    }
}
