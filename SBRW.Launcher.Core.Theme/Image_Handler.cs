#if NETFRAMEWORK || NET6_0_OR_GREATER && WINDOWS
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
#endif

namespace SBRW.Launcher.Core.Theme
{
#if NETFRAMEWORK || NET6_0_OR_GREATER && WINDOWS
    /// <summary>
    /// Image loading toolset class which corrects the bug that prevents paletted PNG images with transparency from being loaded as paletted.
    /// </summary>
    /// <remarks><i>Includes Gray Scale for Bitmap Images</i></remarks>
    public class Image_Handler
    {
        /// <summary>
        /// Turns the Image in a Monochrome Color
        /// </summary>
        /// <param name="Image_Location">File Location</param>
        /// <returns>Monochrome Image</returns>
        public static Image Grayscale(string Image_Location)
        {
            if (!File.Exists(Image_Location))
            {
                return default;
            }
            else
            {
                try
                {
                    using (FileStream The_Image = File.Open(Image_Location, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
                    {
                        try
                        {
                            using (Bitmap The_Viewer = new Bitmap(The_Image))
                            {
                                try
                                {
                                    return GreyScale(The_Viewer);
                                }
                                catch (Exception)
                                {
                                    /* Error #2 */
                                    return default;
                                }
                            }
                        }
                        catch (Exception)
                        {
                            return default;
                        }
                    }
                }
                catch (Exception)
                {
                    return default;
                }
            }
        }
        /// <summary>
        /// Coverts an Image into a Gray Scale
        /// </summary>
        /// <param name="Image_Original">Bitmap Image File</param>
        /// <returns>The Bitmap Image in Gray Scale</returns>
        /// Source: https://web.archive.org/web/20130208001434/http://tech.pro:80/tutorial/660/csharp-tutorial-convert-a-color-image-to-grayscale
        private static Bitmap GreyScale(Bitmap Image_Original)
        {
            if (Image_Original != default)
            {
                try
                {
                    //Create a blank bitmap the same size as original
                    Bitmap New_Bitmap = new Bitmap(Image_Original.Width, Image_Original.Height);

                    //Get a graphics object from the new image
                    using (Graphics Custom_Graphics = Graphics.FromImage(New_Bitmap))
                    {
                        //Create the grayscale ColorMatrix
                        ColorMatrix colorMatrix = new ColorMatrix(new float[][]
                           { new float[] {.3f, .3f, .3f, 0, 0}, new float[] {.59f, .59f, .59f, 0, 0}, new float[]
                           {.11f, .11f, .11f, 0, 0}, new float[] {0, 0, 0, 1, 0}, new float[] {0, 0, 0, 0, 1} });

                        //create some image attributes
                        using (ImageAttributes Image_Attributes = new ImageAttributes())
                        {
                            //set the color matrix attribute
                            Image_Attributes.SetColorMatrix(colorMatrix);

                            //Draw the original image on the new image
                            //using the grayscale color matrix
                            Custom_Graphics.DrawImage(Image_Original, new Rectangle(0, 0, Image_Original.Width, Image_Original.Height),
                                0, 0, Image_Original.Width, Image_Original.Height, GraphicsUnit.Pixel, Image_Attributes);
                        }
                    }

                    return New_Bitmap;
                }
                catch (Exception)
                {
                    return default;
                }
            }
            else
            {
                return default;
            }
        }
    }
#else
    /// <summary>
    /// Image loading toolset class which corrects the bug that prevents paletted PNG images with transparency from being loaded as paletted.
    /// </summary>
    /// <remarks><i><b>Supported only on .NET-Windows and .NET Frameworks</b></i></remarks>
    public class Image_Handler { }
#endif
}
