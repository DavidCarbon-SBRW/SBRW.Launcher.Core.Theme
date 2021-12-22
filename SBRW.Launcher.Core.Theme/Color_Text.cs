using System.Drawing;

namespace SBRW.Launcher.Core.Theme
{
    /// <summary>
    /// Themed Text Colors for the Launcher or App
    /// </summary>
    public class Color_Text
    {
        ///<summary>Silver</summary>
        public static Color L_One { get; set; } = Color.FromArgb(224, 224, 224);
        ///<summary>Pinging Blue</summary>
        public static Color L_Two { get; set; } = Color.FromArgb(66, 179, 189);
        ///<summary>Gray</summary>
        public static Color L_Three { get; set; } = Color.FromArgb(132, 132, 132);
        ///<summary>Dark Blue</summary>
        public static Color L_Four { get; set; } = Color.FromArgb(44, 58, 76);
        ///<summary>White</summary>
        public static Color L_Five { get; set; } = Color.FromArgb(255, 255, 255);
        ///<summary>Grey</summary>
        ///<remarks>Slightly Darker</remarks>
        public static Color L_Six { get; set; } = Color.FromArgb(128, 128, 128);
        ///<summary>Successful Green</summary>
        public static Color L_Seven { get; set; } = Color.FromArgb(159, 193, 32);
        ///<summary>Orange</summary>
        ///<remarks>Color Bind</remarks>
        public static Color L_Eight { get; set; } = Color.FromArgb(230, 159, 0);
        ///<summary>Status Color: Successful Green</summary>
        /// <remarks>
        /// RGB: 159, 193, 32<code></code>
        /// HEX: 9FC120
        /// </remarks>
        public static Color S_Sucess { get; set; } = Color.FromArgb(159, 193, 32);
        ///<summary>Status Color: Red</summary>
        /// <remarks>
        /// RGB: 254, 0, 0<code></code>
        /// HEX: FE0000
        /// </remarks>
        public static Color S_Error { get; set; } = Color.FromArgb(254, 0, 0);
        ///<summary>Status Color: Orange [Color Bind]</summary>
        /// <remarks>
        /// RGB: 230, 159, 0<code></code>
        /// HEX: E69F00
        /// </remarks>
        public static Color S_Warning { get; set; } = Color.FromArgb(230, 159, 0);
    }
}
