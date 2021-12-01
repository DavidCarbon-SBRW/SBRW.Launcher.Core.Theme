using System.Drawing;

namespace SBRW.Launcher.Core.Theme
{
    /// <summary>
    /// WinForm (Screens) Text and Background Colors
    /// </summary>
    public class Color_Winform
    {
        /// <summary>
        /// 
        /// </summary>
        public static Color Text_Fore_Color { get; set; } = Color.FromArgb(224, 224, 224);
        /// <summary>
        /// 
        /// </summary>
        public static Color Secondary_Text_Fore_Color { get; set; } = Color.FromArgb(178, 210, 255);
        /// <summary>
        /// 
        /// </summary>
        public static Color Success_Text_Fore_Color { get; set; } = Color.FromArgb(0, 192, 0);
        /// <summary>
        /// 
        /// </summary>
        public static Color Warning_Text_Fore_Color { get; set; } = Color.FromArgb(224, 200, 0);
        /// <summary>
        /// 
        /// </summary>
        public static Color Error_Text_Fore_Color { get; set; } = Color.FromArgb(224, 0, 0);
        /// <summary>
        /// 
        /// </summary>
        public static Color BG_Fore_Color { get; set; } = Color.FromArgb(29, 36, 45);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// RGB: 22, 29, 38 <code></code>
        /// HEX: 161D26
        /// </remarks>
        public static Color BG_Darker_Fore_Color { get; set; } = Color.FromArgb(22, 29, 38);
        /// <summary>
        /// List View Line Color
        /// </summary>
        /// <remarks>
        /// RGB: 77, 181, 191 <code></code>
        /// HEX: 4DB5BF
        /// </remarks>
        public static Color Grid_Fore_Color { get; set; } = Color.FromArgb(77, 181, 191);
    }
}
