using System;
using System.Runtime.InteropServices;
#if NETSTANDARD
using Vanara.PInvoke;
#endif

namespace SBRW.Launcher.Core.Theme.Required.DLL.Gdi32_
{
    /// <summary>
    /// This header is used by multiple technologies.
    /// </summary>
    public static class DLL_Gdi32
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
        public static IntPtr AddFontMemResource(this IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts)
        {
            return AddFontMemResourceEx(pbFont, cbFont, pdv, ref pcFonts);
        }
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
        internal static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);
        /// <summary>
        /// The BitBlt function performs a bit-block transfer of the color data corresponding to a rectangle of pixels from the specified source device context into a destination device context.
        /// </summary>
        /// <param name="hdcDest">A handle to the destination device context.</param>
        /// <param name="nXDest">The x-coordinate, in logical units, of the upper-left corner of the destination rectangle.</param>
        /// <param name="nYDest">The y-coordinate, in logical units, of the upper-left corner of the destination rectangle.</param>
        /// <param name="nWidth">The width, in logical units, of the source and destination rectangles.</param>
        /// <param name="nHeight">The height, in logical units, of the source and the destination rectangles.</param>
        /// <param name="hdcSrc">A handle to the source device context.</param>
        /// <param name="nXSrc">The x-coordinate, in logical units, of the upper-left corner of the source rectangle.</param>
        /// <param name="nYSrc">The y-coordinate, in logical units, of the upper-left corner of the source rectangle.</param>
        /// <param name="dwRop">A raster-operation code. These codes define how the color data for the source rectangle is to be combined with the color data for the destination rectangle to achieve the final color.</param>
        /// <returns>If the function succeeds, the return value is nonzero.
        /// If the function fails, the return value is zero. To get extended error information, call <see href="https://learn.microsoft.com/en-us/windows/desktop/api/errhandlingapi/nf-errhandlingapi-getlasterror">GetLastError</see>.</returns>
#if !NETSTANDARD
        [DllImport("gdi32.dll")]
#else
        [DllImport(nameof(Gdi32))]
#endif
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        /// <summary>
        /// The BitBlt function performs a bit-block transfer of the color data corresponding to a rectangle of pixels from the specified source device context into a destination device context.
        /// </summary>
        /// <param name="hdcDest">A handle to the destination device context.</param>
        /// <param name="nXDest">The x-coordinate, in logical units, of the upper-left corner of the destination rectangle.</param>
        /// <param name="nYDest">The y-coordinate, in logical units, of the upper-left corner of the destination rectangle.</param>
        /// <param name="nWidth">The width, in logical units, of the source and destination rectangles.</param>
        /// <param name="nHeight">The height, in logical units, of the source and the destination rectangles.</param>
        /// <param name="hdcSrc">A handle to the source device context.</param>
        /// <param name="nXSrc">The x-coordinate, in logical units, of the upper-left corner of the source rectangle.</param>
        /// <param name="nYSrc">The y-coordinate, in logical units, of the upper-left corner of the source rectangle.</param>
        /// <param name="dwRop">A raster-operation code. These codes define how the color data for the source rectangle is to be combined with the color data for the destination rectangle to achieve the final color.</param>
        /// <returns>If the function succeeds, the return value is nonzero.
        /// If the function fails, the return value is zero. To get extended error information, call <see href="https://learn.microsoft.com/en-us/windows/desktop/api/errhandlingapi/nf-errhandlingapi-getlasterror">GetLastError</see>.</returns>
        public static bool BitBlock(this IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop)
        {
            return BitBlt(hdcDest, nXDest, nYDest, nWidth, nHeight, hdcSrc, nXSrc, nYSrc, dwRop);
        }
        /// <summary>
        /// The CreateCompatibleDC function creates a memory device context (DC) compatible with the specified device.
        /// </summary>
        /// <param name="hdc">A handle to an existing DC. If this handle is <b>NULL</b>, the function creates a memory DC compatible with the application's current screen.</param>
        /// <returns>If the function succeeds, the return value is the handle to a memory DC.
        /// If the function fails, the return value is <b>NULL</b>.</returns>
#if !NETSTANDARD
        [DllImport("gdi32.dll")]
#else
        [DllImport(nameof(Gdi32))]
#endif
        internal static extern IntPtr CreateCompatibleDC(IntPtr hdc);
        /// <summary>
        /// The CreateCompatibleDC function creates a memory device context (DC) compatible with the specified device.
        /// </summary>
        /// <param name="hdc">A handle to an existing DC. If this handle is <b>NULL</b>, the function creates a memory DC compatible with the application's current screen.</param>
        /// <returns>If the function succeeds, the return value is the handle to a memory DC.
        /// If the function fails, the return value is <b>NULL</b>.</returns>
        public static IntPtr DeviceContextCreateCompatible(this IntPtr hdc)
        {
            return CreateCompatibleDC(hdc);
        }
        /// <summary>
        /// The SetTextColor function sets the text color for the specified device context to the specified color.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="crColor">The color of the text.</param>
        /// <returns>If the function succeeds, the return value is a color reference for the previous text color as a <see href="https://learn.microsoft.com/en-us/windows/desktop/gdi/colorref">COLORREF</see> value.
        /// If the function fails, the return value is CLR_INVALID.</returns>
#if !NETSTANDARD
        [DllImport("gdi32.dll")]
#else
        [DllImport(nameof(Gdi32))]
#endif
        internal static extern int SetTextColor(IntPtr hdc, int crColor);
        /// <summary>
        /// The SetTextColor function sets the text color for the specified device context to the specified color.
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="crColor">The color of the text.</param>
        /// <returns>If the function succeeds, the return value is a color reference for the previous text color as a <see href="https://learn.microsoft.com/en-us/windows/desktop/gdi/colorref">COLORREF</see> value.
        /// If the function fails, the return value is CLR_INVALID.</returns>
        public static int TextColorSet(this IntPtr hdc, int crColor)
        {
            return SetTextColor(hdc, crColor);
        }
        /// <summary>
        /// Sets the background mix mode of the specified device context. 
        /// The background mix mode is used with text, hatched brushes, and pen styles that are not solid lines.
        /// </summary>
        /// <param name="hDC">A handle to the device context.</param>
        /// <param name="nBkMode">The background mode. This parameter can be one of the following values.</param>
        /// <returns>If the function succeeds, the return value specifies the previous background mode.
        /// If the function fails, the return value is zero.</returns>
#if !NETSTANDARD
        [DllImport("gdi32.dll")]
#else
        [DllImport(nameof(Gdi32))]
#endif
        internal static extern int SetBkMode(IntPtr hDC, int nBkMode);
        /// <summary>
        /// Sets the background mix mode of the specified device context. 
        /// The background mix mode is used with text, hatched brushes, and pen styles that are not solid lines.
        /// </summary>
        /// <param name="hDC">A handle to the device context.</param>
        /// <param name="nBkMode">The background mode. This parameter can be one of the following values.</param>
        /// <returns>If the function succeeds, the return value specifies the previous background mode.
        /// If the function fails, the return value is zero.</returns>
        public static int BackgroundModeSet(this IntPtr hDC, int nBkMode)
        {
            return SetBkMode(hDC, nBkMode);
        }
        /// <summary>
        /// The SelectObject function selects an object into the specified device context (DC). The new object replaces the previous object of the same type.
        /// </summary>
        /// <param name="hdc">A handle to the DC.</param>
        /// <param name="hgdiobj">A handle to the object to be selected. The specified object must have been created by using one of the following functions.</param>
        /// <returns>If the selected object is not a region and the function succeeds, the return value is a handle to the object being replaced. 
        /// If the selected object is a region and the function succeeds, the return value is one of the <see href="https://learn.microsoft.com/en-us/windows/win32/api/wingdi/nf-wingdi-selectobject#return-value">following</see> values.</returns>
#if !NETSTANDARD
        [DllImport("gdi32.dll")]
#else
        [DllImport(nameof(Gdi32))]
#endif
        internal static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj);
        /// <summary>
        /// The SelectObject function selects an object into the specified device context (DC). The new object replaces the previous object of the same type.
        /// </summary>
        /// <param name="hdc">A handle to the DC.</param>
        /// <param name="hgdiobj">A handle to the object to be selected. The specified object must have been created by using one of the following functions.</param>
        /// <returns>If the selected object is not a region and the function succeeds, the return value is a handle to the object being replaced. 
        /// If the selected object is a region and the function succeeds, the return value is one of the <see href="https://learn.microsoft.com/en-us/windows/win32/api/wingdi/nf-wingdi-selectobject#return-value">following</see> values.</returns>
        public static IntPtr ObjectSelect(this IntPtr hdc, IntPtr hgdiobj)
        {
            return SelectObject(hdc, hgdiobj);
        }
        /// <summary>
        /// The DeleteObject function deletes a logical pen, brush, font, bitmap, region, or palette, freeing all system resources associated with the object. After the object is deleted, the specified handle is no longer valid.
        /// </summary>
        /// <param name="hObject">A handle to a logical pen, brush, font, bitmap, region, or palette.</param>
        /// <returns>If the function succeeds, the return value is nonzero.
        /// If the specified handle is not valid or is currently selected into a DC, the return value is zero.</returns>
#if !NETSTANDARD
        [DllImport("gdi32.dll")]
#else
        [DllImport(nameof(Gdi32))]
#endif
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool DeleteObject(IntPtr hObject);
        /// <summary>
        /// The DeleteObject function deletes a logical pen, brush, font, bitmap, region, or palette, freeing all system resources associated with the object. After the object is deleted, the specified handle is no longer valid.
        /// </summary>
        /// <param name="hObject">A handle to a logical pen, brush, font, bitmap, region, or palette.</param>
        /// <returns>If the function succeeds, the return value is nonzero.
        /// If the specified handle is not valid or is currently selected into a DC, the return value is zero.</returns>
        public static bool ObjectDelete(this IntPtr hObject)
        {
            return DeleteObject(hObject);
        }
        /// <summary>
        /// The DeleteDC function deletes the specified device context (DC).
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <returns>If the function succeeds, the return value is nonzero.
        /// If the function fails, the return value is zero.</returns>
#if !NETSTANDARD
        [DllImport("gdi32.dll")]
#else
        [DllImport(nameof(Gdi32))]
#endif
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool DeleteDC(IntPtr hdc);
        /// <summary>
        /// The DeleteDC function deletes the specified device context (DC).
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <returns>If the function succeeds, the return value is nonzero.
        /// If the function fails, the return value is zero.</returns>
        public static bool DeviceContextDelete(this IntPtr hdc)
        {
            return DeleteDC(hdc);
        }
        /// <summary>
        /// The SetLayout function changes the layout of a device context (DC).
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="dwLayout">The DC layout. This parameter can be one or more of the following values.</param>
        /// <returns>If the function succeeds, it returns the previous layout of the DC.
        /// If the function fails, it returns GDI_ERROR.</returns>
#if !NETSTANDARD
        [DllImport("gdi32.dll")]
#else
        [DllImport(nameof(Gdi32))]
#endif
        internal static extern int SetLayout(IntPtr hdc, int dwLayout);
        /// <summary>
        /// The SetLayout function changes the layout of a device context (DC).
        /// </summary>
        /// <param name="hdc">A handle to the device context.</param>
        /// <param name="dwLayout">The DC layout. This parameter can be one or more of the following values.</param>
        /// <returns>If the function succeeds, it returns the previous layout of the DC.
        /// If the function fails, it returns GDI_ERROR.</returns>
        public static int LayoutSet(this IntPtr hdc, int dwLayout)
        {
            return SetLayout(hdc, dwLayout);
        }
    }
}