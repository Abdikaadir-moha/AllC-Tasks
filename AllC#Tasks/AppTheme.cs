namespace AllC_Tasks
{
    internal class AppTheme
    {
        // === Base Theme Colors ===
        public static Color BackgroundColor = Color.FromArgb(245, 247, 250);
        public static Color HeaderColor = Color.FromArgb(0, 122, 204);
        public static Color HeaderTextColor = Color.White;

        public static Color TextColor = Color.FromArgb(33, 37, 41);
        public static Color TextBoxBackColor = Color.White;
        public static Color TextBoxBorderColor = Color.FromArgb(220, 225, 230);

        public static Color PrimaryButtonColor = Color.FromArgb(0, 122, 204);
        public static Color SecondaryButtonColor = Color.FromArgb(100, 181, 246);
        public static Color DangerButtonColor = Color.FromArgb(220, 53, 69);

        public static Color SuccessColor = Color.FromArgb(40, 167, 69);
        public static Color WarningColor = Color.FromArgb(255, 193, 7);
        public static Color InfoColor = Color.FromArgb(23, 162, 184);

        // === Fonts (💡 new addition) ===
        public static Font HeaderFont = new Font("Segoe UI", 14F, FontStyle.Bold);
        public static Font BodyFont = new Font("Segoe UI", 11F, FontStyle.Regular);
        public static Font ButtonFont = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
    }
}
