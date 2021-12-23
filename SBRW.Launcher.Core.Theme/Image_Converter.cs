using System.IO;

namespace SBRW.Launcher.Core.Theme
{
    /// <summary>
    /// Image Conversion Class
    /// </summary>
    public class Image_Converter
    {
        /// <summary>
        /// Converts Bytes to an Image
        /// </summary>
        /// <param name="Quick_Bytes"></param>
        /// <returns>Valid Image</returns>
#if NETFRAMEWORK || NET6_0_OR_GREATER && WINDOWS
        public static System.Drawing.Image Value(byte[] Quick_Bytes)
        {
            using (MemoryStream Live_Data = new MemoryStream(Quick_Bytes))
            {
                System.Drawing.Image Checkout_Image = System.Drawing.Image.FromStream(Live_Data);
                return Checkout_Image;
            }
        }
#endif
    }
}
