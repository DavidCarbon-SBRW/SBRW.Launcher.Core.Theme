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
        public static Image Complete_Outline { get; set; } = Image_Converter.Value(Properties.Resources.progress_outline_complete);
        /// <summary>
        /// 
        /// </summary>
        public static Image Complete { get; set; } = Image_Converter.Value(Properties.Resources.progress_complete);
        /// <summary>
        /// 
        /// </summary>
        public static Image Checking_Outline { get; set; } = Image_Converter.Value(Properties.Resources.progress_outline);
        /// <summary>
        /// 
        /// </summary>
        public static Image Checking { get; set; } = Image_Converter.Value(Properties.Resources.progress_success);
        /// <summary>
        /// 
        /// </summary>
        public static Image Preload_Outline { get; set; } = Image_Converter.Value(Properties.Resources.progress_outline_unknown);
        /// <summary>
        /// 
        /// </summary>
        public static Image Preload { get; set; } = Image_Converter.Value(Properties.Resources.progress_preload);
        /// <summary>
        /// 
        /// </summary>
        public static Image Warning_Outline { get; set; } = Image_Converter.Value(Properties.Resources.progress_outline_warning);
        /// <summary>
        /// 
        /// </summary>
        public static Image Warning { get; set; } = Image_Converter.Value(Properties.Resources.progress_warning);
        /// <summary>
        /// 
        /// </summary>
        public static Image Error_Outline { get; set; } = Image_Converter.Value(Properties.Resources.progress_outline_error);
        /// <summary>
        /// 
        /// </summary>
        public static Image Error { get; set; } = Image_Converter.Value(Properties.Resources.progress_error);
    }
}
#endif