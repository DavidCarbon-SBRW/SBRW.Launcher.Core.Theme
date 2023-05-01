#if NETFRAMEWORK || NET6_0_OR_GREATER && WINDOWS
using System.Drawing;

namespace SBRW.Launcher.Core.Theme
{
    /// <summary>
    /// 
    /// </summary>
    public class Image_ProgressBar
    {
        /// <summary>
        /// 
        /// </summary>
        public static Image Complete_Outline { get; set; } = Image_Converter.Value(Properties.Resources.progress_outline_complete, 1);
        /// <summary>
        /// 
        /// </summary>
        public static Image Checking_Outline { get; set; } = Image_Converter.Value(Properties.Resources.progress_outline, 0);
        /// <summary>
        /// 
        /// </summary>
        public static Image Preload_Outline { get; set; } = Image_Converter.Value(Properties.Resources.progress_outline_unknown, 4);
        /// <summary>
        /// 
        /// </summary>
        public static Image Warning_Outline { get; set; } = Image_Converter.Value(Properties.Resources.progress_outline_warning, 2);
        /// <summary>
        /// 
        /// </summary>
        public static Image Error_Outline { get; set; } = Image_Converter.Value(Properties.Resources.progress_outline_error, 3);
    }
}
#endif