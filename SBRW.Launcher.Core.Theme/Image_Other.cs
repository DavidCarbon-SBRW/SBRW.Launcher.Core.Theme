#if NETFRAMEWORK || NET6_0_OR_GREATER && WINDOWS
using System.Drawing;

namespace SBRW.Launcher.Core.Theme
{
    /// <summary>
    /// 
    /// </summary>
    public class Image_Other
    {
        /// <summary>
        /// 
        /// </summary>
        public static Image Information_Window { get; set; } = Image_Converter.Value(Properties.Resources.information_window_outline, 0);
        /// <summary>
        /// 
        /// </summary>
        public static Image Information_Window_Error { get; set; } = Image_Converter.Value(Properties.Resources.information_window_outline_error, 3);
        /// <summary>
        /// 
        /// </summary>
        public static Image Information_Window_Success { get; set; } = Image_Converter.Value(Properties.Resources.information_window_outline_success, 1);
        /// <summary>
        /// 
        /// </summary>
        public static Image Information_Window_Unknown { get; set; } = Image_Converter.Value(Properties.Resources.information_window_outline_unknown, 4);
        /// <summary>
        /// 
        /// </summary>
        public static Image Information_Window_Warning { get; set; } = Image_Converter.Value(Properties.Resources.information_window_outline_warning, 2);
        /// <summary>
        /// 
        /// </summary>
        public static Image Server_Banner { get; set; } = Image_Converter.Value(Properties.Resources.server_banner);
        /// <summary>
        /// 
        /// </summary>
        public static Image Server_Banner_Outline { get; set; } = Image_Converter.Value(Properties.Resources.server_banner_outline, 3);
        /// <summary>
        /// 
        /// </summary>
        public static Image Server_Banner_Error_Outline { get; set; } = Image_Converter.Value(Properties.Resources.server_banner_error_outline, 3);
        /// <summary>
        /// 
        /// </summary>
        public static Image Logo { get; set; } = Image_Converter.Value(Properties.Resources.logo_main);
        /// <summary>
        /// 
        /// </summary>
        public static Image Logo_Splash { get; set; } = Image_Converter.Value(Properties.Resources.logo_splash);
    }
}
#endif