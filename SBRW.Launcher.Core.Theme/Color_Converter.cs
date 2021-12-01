using System;
using System.Drawing;
using System.Linq;

namespace SBRW.Launcher.Core.Theme
{
    /// <summary>
    /// Color Conversion Class
    /// </summary>
    public class Color_Converter
    {
        /// <summary>
        /// Converts a RGB String Value for Validation
        /// </summary>
        /// <param name="Raw_Color">(A)RGB Color Value</param>
        /// <returns>Color Value</returns>
        public static Color Value(string Raw_Color)
        {
            try
            {
                int[] Color_Fragments = Raw_Color?.Split(',').Select(sFragment => 
                { int.TryParse(sFragment, out int fragment); return fragment; }).ToArray();

                switch (Color_Fragments?.Length)
                {
                    case 3:
                        /* Regular RGB Conversion */
                        return Color.FromArgb(Color_Fragments[0], Color_Fragments[1], Color_Fragments[2]);
                    case 4:
                        /* Regular ARGB Conversion */
                        return Color.FromArgb(Color_Fragments[0], Color_Fragments[1], Color_Fragments[2], Color_Fragments[3]);
                    default:
                        /* Fail Safe Color */
                        return Color.Silver;
                }
            }
            catch (Exception)
            {
                return Color.Silver;
            }
        }
    }
}
