using System;
using System.Runtime.InteropServices;
#if NETSTANDARD
using Vanara.PInvoke;
#endif

namespace SBRW.Launcher.Core.Theme.Required.DLL.Gdi32_
{
    /// <summary>
    /// The AddFontMemResourceEx function adds the font resource from a memory image to the system.
    /// </summary>
    public class DLL_Font
    {
        /// <summary>
        /// The AddFontMemResourceEx function adds the font resource from a memory image to the system.
        /// </summary>
        /// <param name="pbFont">
        /// A pointer to a font resource.
        /// </param>
        /// <param name="cbFont">
        /// The number of bytes in the font resource that is pointed to by pbFont.
        /// </param>
        /// <param name="pdv">
        /// Reserved. Must be 0.
        /// </param>
        /// <param name="pcFonts">
        /// A pointer to a variable that specifies the number of fonts installed.
        /// </param>
        /// <returns>
        /// If the function succeeds, the return value specifies the handle to the font added. 
        /// This handle uniquely identifies the fonts that were installed on the system. 
        /// If the function fails, the return value is zero. 
        /// No extended error information is available.
        /// </returns>
#if !NETSTANDARD
        [DllImport("gdi32.dll")]
#else
        [DllImport(nameof(Gdi32))]
#endif
        public static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);
    }
}
