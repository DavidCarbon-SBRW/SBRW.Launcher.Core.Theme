using SBRW.Launcher.Core.Theme.Required.Flags_;
using System;
using System.Runtime.InteropServices;
#if NETSTANDARD
using Vanara.PInvoke;
#endif

namespace SBRW.Launcher.Core.Theme.Required.DLL.User32_
{
    /// <summary>
    /// This header is used by multiple technologies.
    /// </summary>
    public static class DLL_User32
    {
        /// <summary>
        /// Sends the specified message to a window or windows. 
        /// The SendMessage function calls the window procedure for the specified window and does not return until the window procedure has processed the message.
        /// </summary>
        /// <param name="hWnd">
        /// A handle to the window whose window procedure will receive the message.
        /// If this parameter is HWND_BROADCAST ((HWND)0xffff), the message is sent to all top-level windows in the system, including disabled or invisible unowned windows, overlapped windows, and pop-up windows; but the message is not sent to child windows.
        /// Message sending is subject to UIPI.The thread of a process can send messages only to message queues of threads in processes of lesser or equal integrity level.
        /// </param>
        /// <param name="Msg">
        /// The message to be sent.
        /// For lists of the system-provided messages, see <see href="https://learn.microsoft.com/en-us/windows/desktop/winmsg/about-messages-and-message-queues">System-Defined Messages</see>.</param>
        /// <param name="wParam">Additional message-specific information.</param>
        /// <param name="lParam">Additional message-specific information.</param>
        /// <returns>The return value specifies the result of the message processing; it depends on the message sent.</returns>
#if !NETSTANDARD
        [DllImport("user32.dll")]
#else
        [DllImport(nameof(User32))]
#endif
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        /// <summary>
        /// Sends the specified message to a window or windows. 
        /// The SendMessage function calls the window procedure for the specified window and does not return until the window procedure has processed the message.
        /// </summary>
        /// <param name="hWnd">
        /// A handle to the window whose window procedure will receive the message.
        /// If this parameter is HWND_BROADCAST ((HWND)0xffff), the message is sent to all top-level windows in the system, including disabled or invisible unowned windows, overlapped windows, and pop-up windows; but the message is not sent to child windows.
        /// Message sending is subject to UIPI.The thread of a process can send messages only to message queues of threads in processes of lesser or equal integrity level.
        /// </param>
        /// <param name="Msg">
        /// The message to be sent.
        /// For lists of the system-provided messages, see <see href="https://learn.microsoft.com/en-us/windows/desktop/winmsg/about-messages-and-message-queues">System-Defined Messages</see>.</param>
        /// <param name="wParam">Additional message-specific information.</param>
        /// <param name="lParam">Additional message-specific information.</param>
        /// <returns>The return value specifies the result of the message processing; it depends on the message sent.</returns>
        public static IntPtr MessageSend(this IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam)
        {
            return SendMessage(hWnd, Msg, wParam, lParam);
        }
        /// <summary>
        /// Sends the specified message to a window or windows. 
        /// The SendMessage function calls the window procedure for the specified window and does not return until the window procedure has processed the message.
        /// </summary>
        /// <param name="hwnd">
        /// A handle to the window whose window procedure will receive the message.
        /// If this parameter is HWND_BROADCAST ((HWND)0xffff), the message is sent to all top-level windows in the system, including disabled or invisible unowned windows, overlapped windows, and pop-up windows; but the message is not sent to child windows.
        /// Message sending is subject to UIPI.The thread of a process can send messages only to message queues of threads in processes of lesser or equal integrity level.
        /// </param>
        /// <param name="msg">
        /// The message to be sent.
        /// For lists of the system-provided messages, see <see href="https://learn.microsoft.com/en-us/windows/desktop/winmsg/about-messages-and-message-queues">System-Defined Messages</see>.</param>
        /// <param name="wParam">Additional message-specific information.</param>
        /// <param name="lParam">Additional message-specific information.</param>
        /// <returns>The return value specifies the result of the message processing; it depends on the message sent.</returns>
#if !NETSTANDARD
        [DllImport("user32.dll")]
#else
        [DllImport(nameof(User32))]
#endif
        internal static extern IntPtr SendMessage(IntPtr hwnd, int msg, IntPtr wParam, ref Flags_TabControl.TCHITTESTINFO lParam);
        /// <summary>
        /// Sends the specified message to a window or windows. 
        /// The SendMessage function calls the window procedure for the specified window and does not return until the window procedure has processed the message.
        /// </summary>
        /// <param name="hwnd">
        /// A handle to the window whose window procedure will receive the message.
        /// If this parameter is HWND_BROADCAST ((HWND)0xffff), the message is sent to all top-level windows in the system, including disabled or invisible unowned windows, overlapped windows, and pop-up windows; but the message is not sent to child windows.
        /// Message sending is subject to UIPI.The thread of a process can send messages only to message queues of threads in processes of lesser or equal integrity level.
        /// </param>
        /// <param name="msg">
        /// The message to be sent.
        /// For lists of the system-provided messages, see <see href="https://learn.microsoft.com/en-us/windows/desktop/winmsg/about-messages-and-message-queues">System-Defined Messages</see>.</param>
        /// <param name="wParam">Additional message-specific information.</param>
        /// <param name="lParam">Additional message-specific information.</param>
        /// <returns>The return value specifies the result of the message processing; it depends on the message sent.</returns>
        internal static IntPtr MessageSend(this IntPtr hwnd, int msg, IntPtr wParam, ref Flags_TabControl.TCHITTESTINFO lParam)
        {
            return SendMessage(hwnd, msg, wParam, ref lParam);
        }
        /// <summary>
        /// The DrawState function displays an image and applies a visual effect to indicate a state, such as a disabled or default state.
        /// </summary>
        /// <param name="hdc">A handle to the device context to draw in.</param>
        /// <param name="hbr">A handle to the brush used to draw the image, if the state specified by the fuFlags parameter is DSS_MONO.
        /// This parameter is ignored for other states.</param>
        /// <param name="lpOutputFunc">
        /// A pointer to an application-defined callback function used to render the image.
        /// This parameter is required if the image type in fuFlags is DST_COMPLEX.
        /// It is optional and can be NULL if the image type is DST_TEXT.
        /// For all other image types, this parameter is ignored.
        /// For more information about the callback function, see the <see href="https://learn.microsoft.com/en-us/windows/desktop/api/winuser/nc-winuser-drawstateproc">DrawStateProc</see> function.</param>
        /// <param name="lData">Information about the image. The meaning of this parameter depends on the image type.</param>
        /// <param name="wData">Information about the image.
        /// The meaning of this parameter depends on the image type.
        /// It is, however, zero extended for use with the DrawStateProc function.</param>
        /// <param name="x">The horizontal location, in device units, at which to draw the image.</param>
        /// <param name="y">The vertical location, in device units, at which to draw the image.</param>
        /// <param name="cx">The width of the image, in device units. This parameter is required if the image type is DST_COMPLEX. Otherwise, it can be zero to calculate the width of the image.</param>
        /// <param name="cy">The height of the image, in device units. This parameter is required if the image type is DST_COMPLEX. Otherwise, it can be zero to calculate the height of the image.</param>
        /// <param name="fuFlags">The image type and state. This parameter can be one of the <see href="https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-drawstatea#parameters">following</see> type values.</param>
        /// <returns>
        /// If the function succeeds, the return value is nonzero.
        /// If the function fails, the return value is zero.
        /// </returns>
#if !NETSTANDARD
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
#else
        [DllImport(nameof(User32), CharSet = CharSet.Auto)]
#endif
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern int DrawState(IntPtr hdc, IntPtr hbr, IntPtr lpOutputFunc, IntPtr lData, IntPtr wData, int x, int y, int cx, int cy, int fuFlags);
        /// <summary>
        /// The DrawState function displays an image and applies a visual effect to indicate a state, such as a disabled or default state.
        /// </summary>
        /// <param name="hdc">A handle to the device context to draw in.</param>
        /// <param name="hbr">A handle to the brush used to draw the image, if the state specified by the fuFlags parameter is DSS_MONO.
        /// This parameter is ignored for other states.</param>
        /// <param name="lpOutputFunc">
        /// A pointer to an application-defined callback function used to render the image.
        /// This parameter is required if the image type in fuFlags is DST_COMPLEX.
        /// It is optional and can be NULL if the image type is DST_TEXT.
        /// For all other image types, this parameter is ignored.
        /// For more information about the callback function, see the <see href="https://learn.microsoft.com/en-us/windows/desktop/api/winuser/nc-winuser-drawstateproc">DrawStateProc</see> function.</param>
        /// <param name="lData">Information about the image. The meaning of this parameter depends on the image type.</param>
        /// <param name="wData">Information about the image.
        /// The meaning of this parameter depends on the image type.
        /// It is, however, zero extended for use with the DrawStateProc function.</param>
        /// <param name="x">The horizontal location, in device units, at which to draw the image.</param>
        /// <param name="y">The vertical location, in device units, at which to draw the image.</param>
        /// <param name="cx">The width of the image, in device units. This parameter is required if the image type is DST_COMPLEX. Otherwise, it can be zero to calculate the width of the image.</param>
        /// <param name="cy">The height of the image, in device units. This parameter is required if the image type is DST_COMPLEX. Otherwise, it can be zero to calculate the height of the image.</param>
        /// <param name="fuFlags">The image type and state. This parameter can be one of the <see href="https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-drawstatea#parameters">following</see> type values.</param>
        /// <returns>
        /// If the function succeeds, the return value is nonzero.
        /// If the function fails, the return value is zero.
        /// </returns>
        public static int StateDraw(this IntPtr hdc, IntPtr hbr, IntPtr lpOutputFunc, IntPtr lData, IntPtr wData, int x, int y, int cx, int cy, int fuFlags)
        {
            return DrawState(hdc, hbr, lpOutputFunc, lData, wData, x, y, cx, cy, fuFlags);
        }
        /// <summary>
        /// The DrawText function draws formatted text in the specified rectangle. It formats the text according to the specified method (expanding tabs, justifying characters, breaking lines, and so forth).
        /// </summary>
        /// <param name="hDC">A handle to the device context.</param>
        /// <param name="lpString">A pointer to the string that specifies the text to be drawn. If the nCount parameter is -1, the string must be null-terminated.
        /// If uFormat includes DT_MODIFYSTRING, the function could add up to four additional characters to this string.
        /// The buffer containing the string should be large enough to accommodate these extra characters.</param>
        /// <param name="nCount">The length, in characters, of the string. If nCount is -1, then the lpchText parameter is assumed to be a pointer to a null-terminated string and <b>DrawText</b> computes the character count automatically.</param>
        /// <param name="lpRect">A pointer to a <see href="https://learn.microsoft.com/en-us/windows/desktop/api/windef/ns-windef-rect">RECT</see> structure that contains the rectangle (in logical coordinates) in which the text is to be formatted.</param>
        /// <param name="uFormat">The method of formatting the text. This parameter can be one or more of the <see href="https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-drawtext#parameters">following</see> values.</param>
        /// <returns></returns>
#if !NETSTANDARD
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
#else
        [DllImport(nameof(User32), CharSet = CharSet.Auto)]
#endif
        [return: MarshalAs(UnmanagedType.I4)]
        internal static extern int DrawText(IntPtr hDC, string lpString, int nCount, ref Flags_TabControl.RECT lpRect, Flags_TabControl.DRAWTEXTFLAGS uFormat);
        /// <summary>
        /// The DrawText function draws formatted text in the specified rectangle. It formats the text according to the specified method (expanding tabs, justifying characters, breaking lines, and so forth).
        /// </summary>
        /// <param name="hDC">A handle to the device context.</param>
        /// <param name="lpString">A pointer to the string that specifies the text to be drawn. If the nCount parameter is -1, the string must be null-terminated.
        /// If uFormat includes DT_MODIFYSTRING, the function could add up to four additional characters to this string.
        /// The buffer containing the string should be large enough to accommodate these extra characters.</param>
        /// <param name="nCount">The length, in characters, of the string. If nCount is -1, then the lpchText parameter is assumed to be a pointer to a null-terminated string and <b>DrawText</b> computes the character count automatically.</param>
        /// <param name="lpRect">A pointer to a <see href="https://learn.microsoft.com/en-us/windows/desktop/api/windef/ns-windef-rect">RECT</see> structure that contains the rectangle (in logical coordinates) in which the text is to be formatted.</param>
        /// <param name="uFormat">The method of formatting the text. This parameter can be one or more of the <see href="https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-drawtext#parameters">following</see> values.</param>
        /// <returns></returns>
        internal static int TextDraw(this IntPtr hDC, string lpString, int nCount, ref Flags_TabControl.RECT lpRect, Flags_TabControl.DRAWTEXTFLAGS uFormat)
        {
            return DrawText(hDC, lpString, nCount, ref lpRect, uFormat);
        }
    }
}
