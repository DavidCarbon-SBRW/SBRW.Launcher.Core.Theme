#if NETFRAMEWORK || NET6_0_OR_GREATER && WINDOWS
using System.Drawing;

namespace SBRW.Launcher.Core.Theme
{
    /// <summary>
    /// 
    /// </summary>
    public class Image_Button
    {
        /// <summary>
        /// 
        /// </summary>
        public static Image Grey { get; set; } = Image_Converter.Value(Properties.Resources.graybutton);
        /// <summary>
        /// 
        /// </summary>
        public static Image Grey_Click { get; set; } = Image_Converter.Value(Properties.Resources.graybutton_click);
        /// <summary>
        /// 
        /// </summary>
        public static Image Grey_Hover { get; set; } = Image_Converter.Value(Properties.Resources.graybutton_hover);
        /// <summary>
        /// 
        /// </summary>
        public static Image Green{ get; set; } = Image_Converter.Value(Properties.Resources.greenbutton);
        /// <summary>
        /// 
        /// </summary>
        public static Image Green_Click { get; set; } = Image_Converter.Value(Properties.Resources.greenbutton_click);
        /// <summary>
        /// 
        /// </summary>
        public static Image Green_Hover { get; set; } = Image_Converter.Value(Properties.Resources.greenbutton_hover);
        /// <summary>
        /// 
        /// </summary>
        public static Image Play { get; set; } = Image_Converter.Value(Properties.Resources.playbutton);
        /// <summary>
        /// 
        /// </summary>
        public static Image Play_Click { get; set; } = Image_Converter.Value(Properties.Resources.playbutton_click);
        /// <summary>
        /// 
        /// </summary>
        public static Image Play_Hover { get; set; } = Image_Converter.Value(Properties.Resources.playbutton_hover);
    }
}
#endif
