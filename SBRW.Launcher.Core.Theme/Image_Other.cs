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
        public static Image Text_Border_Email { get; set; } = Image_Converter.Value(Properties.Resources.email_text_border);
        /// <summary>
        /// 
        /// </summary>
        public static Image Text_Border_Email_Error { get; set; } = Image_Converter.Value(Properties.Resources.email_error_text_border);
        /// <summary>
        /// 
        /// </summary>
        public static Image Text_Border_Password { get; set; } = Image_Converter.Value(Properties.Resources.password_text_border);
        /// <summary>
        /// 
        /// </summary>
        public static Image Text_Border_Password_Error { get; set; } = Image_Converter.Value(Properties.Resources.password_error_text_border);
        /// <summary>
        /// 
        /// </summary>
        public static Image Text_Border_Ticket { get; set; } = Image_Converter.Value(Properties.Resources.ticket_text_border);
        /// <summary>
        /// 
        /// </summary>
        public static Image Text_Border_Ticket_Error { get; set; } = Image_Converter.Value(Properties.Resources.ticket_error_text_border);
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