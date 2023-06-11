using System;
using System.Drawing;
using System.Linq;

namespace SBRW.Launcher.Core.Theme
{
    /// <summary>
    /// Color Conversion Class
    /// </summary>
    public static class Color_Converter
    {
        /// <summary>
        /// Converts a RGB String Value for Validation
        /// </summary>
        /// <param name="Raw_Color">(A)RGB Color Value</param>
        /// <returns>Color Value</returns>
        public static Color Value(this string Raw_Color)
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="colorIn"></param>
        /// <param name="percent"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static Color Darken(this Color colorIn, int percent)
        {
            if (percent < 0 || percent > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(percent));
            }
            else
            {
                return Color.FromArgb((int)byte.MaxValue, (int)colorIn.R - (int)colorIn.R / 100 * percent, (int)colorIn.G - (int)colorIn.G / 100 * percent, (int)colorIn.B - (int)colorIn.B / 100 * percent);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="colorIn"></param>
        /// <param name="percent"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static Color Lighten(this Color colorIn, int percent)
        {
            if (percent < 0 || percent > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(percent));
            }
            else
            {
                return Color.FromArgb((int)byte.MaxValue, (int)colorIn.R + (int)(((double)byte.MaxValue - (double)colorIn.R) / 100.0 * (double)percent), (int)colorIn.G + (int)(((double)byte.MaxValue - (double)colorIn.G) / 100.0 * (double)percent), (int)colorIn.B + (int)(((double)byte.MaxValue - (double)colorIn.B) / 100.0 * (double)percent));
            }
        }
    }
}
