using System;
using System.Drawing;
using System.Runtime.InteropServices;
#if NETSTANDARD
using Vanara.PInvoke;
#endif

namespace SBRW.Launcher.Core.Theme.Required.DLL.UxTheme_
{
    /// <summary>
    /// This header is used by multiple technologies.
    /// </summary>
    public static class DLL_UxTheme
    {
        /// <summary>
        /// Causes a window to use a different set of visual style information than its class normally uses.
        /// </summary>
        /// <param name="hwnd">Handle to the window whose visual style information is to be changed.</param>
        /// <param name="pszSubAppName">
        /// Pointer to a string that contains the application name to use in place of the calling application's name. 
        /// If this parameter is NULL, the calling application's name is used.</param>
        /// <param name="pszSubIdList">
        /// Pointer to a string that contains a semicolon-separated list of CLSID names to use in place of the actual list passed by the window's class. 
        /// If this parameter is NULL, the ID list from the calling class is used.
        /// </param>
        /// <returns>If this function succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.</returns>
#if !NETSTANDARD
        [DllImport("uxtheme")]
#else
        [DllImport(nameof(UxTheme))]
#endif
        internal static extern int SetWindowTheme(IntPtr hwnd, [MarshalAs(UnmanagedType.LPWStr)] string pszSubAppName, [MarshalAs(UnmanagedType.LPWStr)] string pszSubIdList);
        /// <summary>
        /// Causes a window to use a different set of visual style information than its class normally uses.
        /// </summary>
        /// <param name="hwnd">Handle to the window whose visual style information is to be changed.</param>
        /// <param name="pszSubAppName">
        /// Pointer to a string that contains the application name to use in place of the calling application's name. 
        /// If this parameter is NULL, the calling application's name is used.</param>
        /// <param name="pszSubIdList">
        /// Pointer to a string that contains a semicolon-separated list of CLSID names to use in place of the actual list passed by the window's class. 
        /// If this parameter is NULL, the ID list from the calling class is used.
        /// </param>
        /// <returns>If this function succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.</returns>
        public static int WindowThemeSet(this IntPtr hwnd, [MarshalAs(UnmanagedType.LPWStr)] string pszSubAppName, [MarshalAs(UnmanagedType.LPWStr)] string pszSubIdList)
        {
            return SetWindowTheme(hwnd, pszSubAppName, pszSubIdList);
        }
        /// <summary>
        /// Retrieves a theme handle to a window that has visual styles applied.
        /// </summary>
        /// <param name="hWnd">Handle of the window.</param>
        /// <returns>The most recent theme handle from <see href="https://learn.microsoft.com/en-us/windows/win32/api/uxtheme/nf-uxtheme-openthemedata">OpenThemeData</see></returns>
#if !NETSTANDARD
        [DllImport("uxtheme")]
#else
        [DllImport(nameof(UxTheme))]
#endif
        internal static extern IntPtr GetWindowTheme(IntPtr hWnd);
        /// <summary>
        /// Retrieves a theme handle to a window that has visual styles applied.
        /// </summary>
        /// <param name="hWnd">Handle of the window.</param>
        /// <returns>The most recent theme handle from <see href="https://learn.microsoft.com/en-us/windows/win32/api/uxtheme/nf-uxtheme-openthemedata">OpenThemeData</see></returns>
        public static IntPtr WindowThemeGet(this IntPtr hWnd)
        {
            return GetWindowTheme(hWnd);
        }
        /// <summary>
        /// Draws the part of a parent control that is covered by a partially-transparent or alpha-blended child control.
        /// </summary>
        /// <param name="hWnd">The child control.</param>
        /// <param name="hdc">The child control's DC.</param>
        /// <param name="pRect">
        /// The area to be drawn. The rectangle is in the child window's coordinates. 
        /// If this parameter is NULL, the area to be drawn includes the entire area occupied by the child control.
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.
        /// </returns>
        [DllImport("uxtheme", ExactSpelling = true)]
        public extern static Int32 DrawThemeParentBackground(IntPtr hWnd, IntPtr hdc, ref Rectangle pRect);
        /// <summary>
        /// Draws the part of a parent control that is covered by a partially-transparent or alpha-blended child control.
        /// </summary>
        /// <param name="hWnd">The child control.</param>
        /// <param name="hdc">The child control's DC.</param>
        /// <param name="pRect">
        /// The area to be drawn. The rectangle is in the child window's coordinates. 
        /// If this parameter is NULL, the area to be drawn includes the entire area occupied by the child control.
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.
        /// </returns>
        public static Int32 ThemeParentBackground(this IntPtr hWnd, IntPtr hdc, ref Rectangle pRect)
        {
            return DrawThemeParentBackground(hWnd, hdc, ref pRect);
        }
    }
}
