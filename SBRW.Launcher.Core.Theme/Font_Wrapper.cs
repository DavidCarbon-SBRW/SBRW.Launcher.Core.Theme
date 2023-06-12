using SBRW.Launcher.Core.Theme.Required.DLL.Gdi32_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Text;

namespace SBRW.Launcher.Core.Theme
{
    /// <summary>
    /// 
    /// </summary>
    public class Font_Wrapper
    {
        /// <summary>
        /// Launcher Regular Font
        /// </summary>
        public FontFamily Font_Regular { get; set; }
        /// <summary>
        /// Launcher Bold Font
        /// </summary>
        public FontFamily Font_Bold { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public PrivateFontCollection Private_Font_Collection { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, int> Font_Mapping { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Font_Wrapper()
        {
            Private_Font_Collection = new PrivateFontCollection();
            Font_Mapping = new Dictionary<string, int>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Font_Name"></param>
        /// <param name="ManifestResourceStream">Resource Path: <b>Must be Accessible within the Application or Library</b></param>
        /// <returns></returns>
        public FontFamily GetFontFamily(string Font_Name = null, Stream ManifestResourceStream = null)
        {
            if (!string.IsNullOrWhiteSpace(Font_Name))
            {
                if (Font_Mapping.ContainsKey(Font_Name))
                {
                    return Private_Font_Collection.Families[Font_Mapping[Font_Name]];
                }
                else
                {
                    int num = LoadEmbeddedFont(Font_Name, ManifestResourceStream);
                    if (num >= 0)
                    {
                        return Private_Font_Collection.Families[num];
                    }
                    else
                    {
                        return default;
                    }
                }
            }
            else
            {
                return default;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Font_Name"></param>
        /// <param name="ManifestResourceStream"></param>
        /// <returns></returns>
        public int LoadEmbeddedFont(string Font_Name, Stream ManifestResourceStream = null)
        {
            if (ManifestResourceStream != default)
            {
                IntPtr intPtr = IntPtr.Zero;

                try
                {
                    intPtr = Marshal.AllocCoTaskMem((int)ManifestResourceStream.Length);
                    byte[] array = new byte[ManifestResourceStream.Length];
                    ManifestResourceStream.Read(array, 0, (int)ManifestResourceStream.Length);
                    Marshal.Copy(array, 0, intPtr, (int)ManifestResourceStream.Length);
                    uint num = 0u;
                    intPtr.AddFontMemResource((uint)array.Length, IntPtr.Zero, ref num);
                    Private_Font_Collection.AddMemoryFont(intPtr, (int)ManifestResourceStream.Length);
                    ManifestResourceStream.Close();
                    ManifestResourceStream.Dispose();
                    Marshal.FreeCoTaskMem(intPtr);
                    intPtr = IntPtr.Zero;
                    Font_Mapping.Add(Font_Name, Private_Font_Collection.Families.Length - 1);
                    return Private_Font_Collection.Families.Length - 1;
                }
                catch
                {
                    return -1;
                }
                finally
                {
                    if (intPtr != IntPtr.Zero)
                    {
                        Marshal.FreeCoTaskMem(intPtr);
                    }

                    if (ManifestResourceStream != default)
                    {
                        ManifestResourceStream.Close();
                        ManifestResourceStream.Dispose();
                    }
                }
            }
            else
            {
                return -1;
            }
        }
    }
}
