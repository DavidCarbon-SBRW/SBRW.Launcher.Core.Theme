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
        /// Launcher Primary Font
        /// </summary>
        public static FontFamily Launcher_Font { get; set; }
        /// <summary>
        /// Launcher Secondary Font
        /// </summary>
        public static FontFamily Launcher_Font_Bold { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public PrivateFontCollection MPrivateFontCollection { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, int> MFontMapping { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public static Font_Wrapper Cached_Instance { get; set; } = new Font_Wrapper();
        /// <summary>
        /// 
        /// </summary>
        public static Font_Wrapper Instance
        {
            get
            {
                return Cached_Instance;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private Font_Wrapper()
        {
            MPrivateFontCollection = new PrivateFontCollection();
            MFontMapping = new Dictionary<string, int>();
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
                if (MFontMapping.ContainsKey(Font_Name))
                {
                    return MPrivateFontCollection.Families[MFontMapping[Font_Name]];
                }
                else
                {
                    int num = LoadEmbeddedFont(Font_Name, ManifestResourceStream);
                    if (num >= 0)
                    {
                        return MPrivateFontCollection.Families[num];
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Font_Name"></param>
        /// <param name="ManifestResourceStream"></param>
        /// <returns></returns>
        private int LoadEmbeddedFont(string Font_Name, Stream ManifestResourceStream = null)
        {
            if (ManifestResourceStream != null)
            {
                IntPtr intPtr = Marshal.AllocCoTaskMem((int)ManifestResourceStream.Length);
                byte[] array = new byte[ManifestResourceStream.Length];
                ManifestResourceStream.Read(array, 0, (int)ManifestResourceStream.Length);
                Marshal.Copy(array, 0, intPtr, (int)ManifestResourceStream.Length);
                uint num = 0u;
                DLL_Font.AddFontMemResourceEx(intPtr, (uint)array.Length, IntPtr.Zero, ref num);
                MPrivateFontCollection.AddMemoryFont(intPtr, (int)ManifestResourceStream.Length);
                ManifestResourceStream.Close();
                Marshal.FreeCoTaskMem(intPtr);
                MFontMapping.Add(Font_Name, MPrivateFontCollection.Families.Length - 1);
                return MPrivateFontCollection.Families.Length - 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
