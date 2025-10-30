using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllC_Tasks
{
    internal class AppTheme
    {
        // === Base Theme Colors ===
        // 🌆 Background and Form Colors
        public static Color BackgroundColor = Color.FromArgb(245, 247, 250);   // Light soft gray
        public static Color HeaderColor = Color.FromArgb(0, 122, 204);         // Modern blue (header)
        public static Color HeaderTextColor = Color.White;                     // White text for header

        // 🖊️ Text and Input Colors
        public static Color TextColor = Color.FromArgb(33, 37, 41);            // Dark gray text
        public static Color TextBoxBackColor = Color.White;                    // Clean white textboxes
        public static Color TextBoxBorderColor = Color.FromArgb(220, 225, 230);// Subtle gray border

        // 🔘 Button Colors
        public static Color PrimaryButtonColor = Color.FromArgb(0, 122, 204);  // Blue (main actions)
        public static Color SecondaryButtonColor = Color.FromArgb(100, 181, 246); // Light blue
        public static Color DangerButtonColor = Color.FromArgb(220, 53, 69);   // Red for exit/delete

        // 🌈 Additional Optional Colors (for future problems)
        public static Color SuccessColor = Color.FromArgb(40, 167, 69);        // Green for success
        public static Color WarningColor = Color.FromArgb(255, 193, 7);        // Yellow for alerts
        public static Color InfoColor = Color.FromArgb(23, 162, 184);  
    }
}
