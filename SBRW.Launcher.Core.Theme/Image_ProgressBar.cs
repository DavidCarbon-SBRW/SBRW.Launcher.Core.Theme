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
        public static Image Outline { get; set; } = Image_Converter.Value(Properties.Resources.progress_outline);
        /// <summary>
        /// 
        /// </summary>
        public static Image Success { get; set; } = Image_Converter.Value(Properties.Resources.progress_success);
        /// <summary>
        /// 
        /// </summary>
        public static Image Preload { get; set; } = Image_Converter.Value(Properties.Resources.progress_preload);
        /// <summary>
        /// 
        /// </summary>
        public static Image Warning { get; set; } = Image_Converter.Value(Properties.Resources.progress_warning);
        /// <summary>
        /// 
        /// </summary>
        public static Image Error { get; set; } = Image_Converter.Value(Properties.Resources.progress_error);
    }
}
#endif