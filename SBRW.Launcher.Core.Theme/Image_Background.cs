#if NETFRAMEWORK || NET6_0_OR_GREATER
using System.Drawing;

namespace SBRW.Launcher.Core.Theme
{
    /// <summary>
    /// 
    /// </summary>
    public class Image_Background
    {
        /// <summary>
        /// 
        /// </summary>
        public static Image Login { get; set; } = Image_Converter.Value(Properties.Resources.Background_Login);
        /// <summary>
        /// 
        /// </summary>
        public static Image Registration { get; set; } = Image_Converter.Value(Properties.Resources.Background_Register);
        /// <summary>
        /// 
        /// </summary>
        public static Image Security_Center { get; set; } = Image_Converter.Value(Properties.Resources.Background_Settings);
        /// <summary>
        /// 
        /// </summary>
        public static Image Server_Information { get; set; } = Image_Converter.Value(Properties.Resources.Background_Social);
        /// <summary>
        /// 
        /// </summary>
        public static Image Settings { get; set; } = Image_Converter.Value(Properties.Resources.Background_Settings);
        /// <summary>
        /// 
        /// </summary>
        public static Image User_XML_Settings { get; set; } = Image_Converter.Value(Properties.Resources.Background_USXE);
    }
}
#endif