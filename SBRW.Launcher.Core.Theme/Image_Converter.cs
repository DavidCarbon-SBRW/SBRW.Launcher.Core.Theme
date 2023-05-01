using System.IO;

namespace SBRW.Launcher.Core.Theme
{
    /// <summary>
    /// Image Conversion Class
    /// </summary>
    public class Image_Converter
    {
#if NETFRAMEWORK || NET6_0_OR_GREATER && WINDOWS
        /// <summary>
        /// Converts Bytes to an Image
        /// </summary>
        /// <param name="Quick_Bytes"></param>
        /// <returns>Valid Image</returns>
        public static System.Drawing.Image Value(byte[] Quick_Bytes)
        {
            return Value(Quick_Bytes, 0);
        }
        /// <summary>
        /// Converts Bytes to an Image
        /// </summary>
        /// <param name="Quick_Bytes"></param>
        /// <param name="Quick_ID"></param>
        /// <returns>Valid Image</returns>
        public static System.Drawing.Image Value(byte[] Quick_Bytes, int Quick_ID)
        {
            using (MemoryStream Live_Data = new MemoryStream(Quick_Bytes))
            {
                System.Drawing.Image Checkout_Image = System.Drawing.Image.FromStream(Live_Data);
                Checkout_Image.Tag = Quick_ID;
                return Checkout_Image;
            }
        }
#endif
    }
}
