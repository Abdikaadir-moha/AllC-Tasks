using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllC_Tasks
{
    internal class Apptheme2
    {
        // === 🩵 BASE THEME COLORS ===
        public static Color BackgroundColor = Color.FromArgb(245, 247, 250);   // Light gray background
        public static Color HeaderColor = Color.FromArgb(0, 122, 204);         // Modern blue header
        public static Color HeaderTextColor = Color.White;                     // White text for header

        // === ⚙️ TEXT & SURFACE COLORS ===
        public static Color TextColor = Color.FromArgb(33, 37, 41);            // Deep gray text
        public static Color TextBoxBackColor = Color.White;                    // White textbox
        public static Color TextBoxBorderColor = Color.FromArgb(220, 225, 230);// Subtle border
        public static Color PanelColor = Color.FromArgb(255, 255, 255);        // Clean white panels

        // === 🔘 BUTTON COLORS ===
        public static Color PrimaryButtonColor = Color.FromArgb(0, 122, 204);  // Deep blue
        public static Color SecondaryButtonColor = Color.FromArgb(100, 181, 246); // Light blue
        public static Color DangerButtonColor = Color.FromArgb(220, 53, 69);   // Red (exit/delete)
        public static Color HighlightColor = Color.FromArgb(255, 193, 7);      // Yellow (special)
        public static Color AccentColor = Color.FromArgb(52, 152, 219);        // Sky blue accent

        // === 🌈 STATUS COLORS ===
        public static Color SuccessColor = Color.FromArgb(40, 167, 69);        // Green for success
        public static Color WarningColor = Color.FromArgb(255, 193, 7);        // Yellow for warning
        public static Color InfoColor = Color.FromArgb(23, 162, 184);          // Cyan info

        // === 🌚 DARK THEME (Optional Future Expansion) ===
        public static Color DarkBackground = Color.FromArgb(24, 26, 27);
        public static Color DarkPanel = Color.FromArgb(33, 37, 41);
        public static Color DarkText = Color.FromArgb(230, 230, 230);
        public static Color DarkAccent = Color.FromArgb(0, 122, 204);

        // === 🧠 UTILITY METHOD: Apply Common Control Styles ===
        // You can call this in each Form_Load for consistency
        public static void ApplyButtonStyle(Guna.UI2.WinForms.Guna2Button button, bool isPrimary = true)
        {
            button.FillColor = isPrimary ? PrimaryButtonColor : SecondaryButtonColor;
            button.ForeColor = Color.White;
            button.BorderRadius = 8;
            button.HoverState.FillColor = isPrimary ? Color.FromArgb(0, 100, 180) : Color.FromArgb(80, 160, 220);
        }

        public static void ApplyLabelStyle(System.Windows.Forms.Label label, bool isHeader = false)
        {
            label.ForeColor = isHeader ? HeaderTextColor : TextColor;
        }

        public static void ApplyPanelStyle(Guna.UI2.WinForms.Guna2Panel panel, bool isHeader = false)
        {
            panel.FillColor = isHeader ? HeaderColor : PanelColor;
        }
    }
}
