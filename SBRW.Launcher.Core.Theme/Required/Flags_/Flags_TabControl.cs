using System;
using System.Drawing;

namespace SBRW.Launcher.Core.Theme.Required.Flags_
{
    /// <summary>
    /// 
    /// </summary>
    public static class Flags_TabControl
    {
        /// <summary>
        /// 
        /// </summary>
        public const int NM_FIRST = 0;
        /// <summary>
        /// 
        /// </summary>
        public const int TCN_FIRST = -550;
        /// <summary>
        /// 
        /// </summary>
        public const int CCM_FIRST = 8192;
        /// <summary>
        /// 
        /// </summary>
        public const int TCM_FIRST = 4864;
        /// <summary>
        /// 
        /// </summary>
        public const int OPAQUE = 2;
        /// <summary>
        /// 
        /// </summary>
        public const int TRANSPARENT = 1;
        /// <summary>
        /// 
        /// </summary>
        public const int SRCCOPY = 13369376;
        /// <summary>
        /// 
        /// </summary>
        public const int LAYOUT_RTL = 1;
        /// <summary>
        /// 
        /// </summary>
        public const int LAYOUT_BITMAPORIENTATIONPRESERVED = 8;
        /// <summary>
        /// 
        /// </summary>
        [Flags]
        public enum TCHITTESTFLAGS
        {
            /// <summary>
            /// 
            /// </summary>
            NOWHERE = 1,
            /// <summary>
            /// 
            /// </summary>
            ONITEMICON = 2,
            /// <summary>
            /// 
            /// </summary>
            ONITEMLABEL = 4,
            /// <summary>
            /// 0x00000006
            /// </summary>
            ONITEM = ONITEMLABEL | ONITEMICON,
        }
        /// <summary>
        /// 
        /// </summary>
        public enum ClassPartsTab
        {
            /// <summary>
            /// 
            /// </summary>
            TABITEM = 1,
            /// <summary>
            /// 
            /// </summary>
            TABITEMLEFTEDGE = 2,
            /// <summary>
            /// 
            /// </summary>
            TABITEMRIGHTEDGE = 3,
            /// <summary>
            /// 
            /// </summary>
            TABITEMBOTHEDGE = 4,
            /// <summary>
            /// 
            /// </summary>
            TOPTABITEM = 5,
            /// <summary>
            /// 
            /// </summary>
            TOPTABITEMLEFTEDGE = 6,
            /// <summary>
            /// 
            /// </summary>
            TOPTABITEMRIGHTEDGE = 7,
            /// <summary>
            /// 
            /// </summary>
            TOPTABITEMBOTHEDGE = 8,
            /// <summary>
            /// 
            /// </summary>
            PANE = 9,
            /// <summary>
            /// 0x0000000A
            /// </summary>
            BODY = 10,
        }
        /// <summary>
        /// 
        /// </summary>
        [Flags]
        public enum DrawStateFlags
        {
            /// <summary>
            /// 
            /// </summary>
            COMPLEX = 0,
            /// <summary>
            /// 
            /// </summary>
            TEXT = 1,
            /// <summary>
            /// 
            /// </summary>
            PREFIXTEXT = 2,
            /// <summary>
            /// 0x00000003
            /// </summary>
            ICON = PREFIXTEXT | TEXT,
            /// <summary>
            /// 
            /// </summary>
            BITMAP = 4,
            /// <summary>
            /// 0x00000020
            /// </summary>
            DISABLED = 32,
            /// <summary>
            /// 0x00000200
            /// </summary>
            HIDEPREFIX = 512,
            /// <summary>
            /// 0x00008000
            /// </summary>
            RIGHT = 32768,
            /// <summary>
            /// 0x00020000
            /// </summary>
            RTLREADING = 131072,
        }
        /// <summary>
        /// 
        /// </summary>
        public enum WinMessage
        {
            NULL = 0,
            CREATE = 1,
            DESTROY = 2,
            MOVE = 3,
            SIZE = 5,
            ACTIVATE = 6,
            SETFOCUS = 7,
            KILLFOCUS = 8,
            ENABLE = 10, // 0x0000000A
            SETREDRAW = 11, // 0x0000000B
            SETTEXT = 12, // 0x0000000C
            GETTEXT = 13, // 0x0000000D
            GETTEXTLENGTH = 14, // 0x0000000E
            PAINT = 15, // 0x0000000F
            CLOSE = 16, // 0x00000010
            QUERYENDSESSION = 17, // 0x00000011
            QUIT = 18, // 0x00000012
            QUERYOPEN = 19, // 0x00000013
            ERASEBKGND = 20, // 0x00000014
            SYSCOLORCHANGE = 21, // 0x00000015
            ENDSESSION = 22, // 0x00000016
            SHOWWINDOW = 24, // 0x00000018
            SETTINGCHANGE = 26, // 0x0000001A
            WININICHANGE = 26, // 0x0000001A
            DEVMODECHANGE = 27, // 0x0000001B
            ACTIVATEAPP = 28, // 0x0000001C
            FONTCHANGE = 29, // 0x0000001D
            TIMECHANGE = 30, // 0x0000001E
            CANCELMODE = 31, // 0x0000001F
            SETCURSOR = 32, // 0x00000020
            MOUSEACTIVATE = 33, // 0x00000021
            CHILDACTIVATE = 34, // 0x00000022
            QUEUESYNC = 35, // 0x00000023
            GETMINMAXINFO = 36, // 0x00000024
            PAINTICON = 38, // 0x00000026
            ICONERASEBKGND = 39, // 0x00000027
            NEXTDLGCTL = 40, // 0x00000028
            SPOOLERSTATUS = 42, // 0x0000002A
            DRAWITEM = 43, // 0x0000002B
            MEASUREITEM = 44, // 0x0000002C
            DELETEITEM = 45, // 0x0000002D
            VKEYTOITEM = 46, // 0x0000002E
            CHARTOITEM = 47, // 0x0000002F
            SETFONT = 48, // 0x00000030
            GETFONT = 49, // 0x00000031
            SETHOTKEY = 50, // 0x00000032
            GETHOTKEY = 51, // 0x00000033
            QUERYDRAGICON = 55, // 0x00000037
            COMPAREITEM = 57, // 0x00000039
            GETOBJECT = 61, // 0x0000003D
            COMPACTING = 65, // 0x00000041
            COMMNOTIFY = 68, // 0x00000044
            WINDOWPOSCHANGING = 70, // 0x00000046
            WINDOWPOSCHANGED = 71, // 0x00000047
            COPYDATA = 74, // 0x0000004A
            CANCELJOURNAL = 75, // 0x0000004B
            NOTIFY = 78, // 0x0000004E
            INPUTLANGCHANGEREQUEST = 80, // 0x00000050
            INPUTLANGCHANGE = 81, // 0x00000051
            TCARD = 82, // 0x00000052
            HELP = 83, // 0x00000053
            USERCHANGED = 84, // 0x00000054
            NOTIFYFORMAT = 85, // 0x00000055
            CONTEXTMENU = 123, // 0x0000007B
            STYLECHANGING = 124, // 0x0000007C
            STYLECHANGED = 125, // 0x0000007D
            DISPLAYCHANGE = 126, // 0x0000007E
            GETICON = 127, // 0x0000007F
            SETICON = 128, // 0x00000080
            NCCREATE = 129, // 0x00000081
            NCDESTROY = 130, // 0x00000082
            NCCALCSIZE = 131, // 0x00000083
            NCHITTEST = 132, // 0x00000084
            NCPAINT = 133, // 0x00000085
            NCACTIVATE = 134, // 0x00000086
            GETDLGCODE = 135, // 0x00000087
            SYNCPAINT = 136, // 0x00000088
            NCMOUSEMOVE = 160, // 0x000000A0
            NCLBUTTONDOWN = 161, // 0x000000A1
            NCLBUTTONUP = 162, // 0x000000A2
            NCLBUTTONDBLCLK = 163, // 0x000000A3
            NCRBUTTONDOWN = 164, // 0x000000A4
            NCRBUTTONUP = 165, // 0x000000A5
            NCRBUTTONDBLCLK = 166, // 0x000000A6
            NCMBUTTONDOWN = 167, // 0x000000A7
            NCMBUTTONUP = 168, // 0x000000A8
            NCMBUTTONDBLCLK = 169, // 0x000000A9
            NCXBUTTONDOWN = 171, // 0x000000AB
            NCXBUTTONUP = 172, // 0x000000AC
            NCXBUTTONDBLCLK = 173, // 0x000000AD
            INPUT = 255, // 0x000000FF
            KEYDOWN = 256, // 0x00000100
            KEYFIRST = 256, // 0x00000100
            KEYUP = 257, // 0x00000101
            CHAR = 258, // 0x00000102
            DEADCHAR = 259, // 0x00000103
            SYSKEYDOWN = 260, // 0x00000104
            SYSKEYUP = 261, // 0x00000105
            SYSCHAR = 262, // 0x00000106
            SYSDEADCHAR = 263, // 0x00000107
            KEYLAST = 264, // 0x00000108
            KEYLAST_XP = 265, // 0x00000109
            UNICHAR = 265, // 0x00000109
            IME_STARTCOMPOSITION = 269, // 0x0000010D
            IME_ENDCOMPOSITION = 270, // 0x0000010E
            IME_COMPOSITION = 271, // 0x0000010F
            IME_KEYLAST = 271, // 0x0000010F
            INITDIALOG = 272, // 0x00000110
            COMMAND = 273, // 0x00000111
            SYSCOMMAND = 274, // 0x00000112
            TIMER = 275, // 0x00000113
            HSCROLL = 276, // 0x00000114
            VSCROLL = 277, // 0x00000115
            INITMENU = 278, // 0x00000116
            INITMENUPOPUP = 279, // 0x00000117
            MENUSELECT = 287, // 0x0000011F
            MENUCHAR = 288, // 0x00000120
            ENTERIDLE = 289, // 0x00000121
            MENURBUTTONUP = 290, // 0x00000122
            MENUDRAG = 291, // 0x00000123
            MENUGETOBJECT = 292, // 0x00000124
            UNINITMENUPOPUP = 293, // 0x00000125
            MENUCOMMAND = 294, // 0x00000126
            CHANGEUISTATE = 295, // 0x00000127
            UPDATEUISTATE = 296, // 0x00000128
            QUERYUISTATE = 297, // 0x00000129
            CTLCOLORMSGBOX = 306, // 0x00000132
            CTLCOLOREDIT = 307, // 0x00000133
            CTLCOLORLISTBOX = 308, // 0x00000134
            CTLCOLORBTN = 309, // 0x00000135
            CTLCOLORDLG = 310, // 0x00000136
            CTLCOLORSCROLLBAR = 311, // 0x00000137
            CTLCOLORSTATIC = 312, // 0x00000138
            MOUSEFIRST = 512, // 0x00000200
            MOUSEMOVE = 512, // 0x00000200
            LBUTTONDOWN = 513, // 0x00000201
            LBUTTONUP = 514, // 0x00000202
            LBUTTONDBLCLK = 515, // 0x00000203
            RBUTTONDOWN = 516, // 0x00000204
            RBUTTONUP = 517, // 0x00000205
            RBUTTONDBLCLK = 518, // 0x00000206
            MBUTTONDOWN = 519, // 0x00000207
            MBUTTONUP = 520, // 0x00000208
            MBUTTONDBLCLK = 521, // 0x00000209
            MOUSELAST = 521, // 0x00000209
            MOUSELAST_NT = 522, // 0x0000020A
            MOUSEWHEEL = 522, // 0x0000020A
            XBUTTONDOWN = 523, // 0x0000020B
            XBUTTONUP = 524, // 0x0000020C
            MOUSELAST_2K = 525, // 0x0000020D
            XBUTTONDBLCLK = 525, // 0x0000020D
            PARENTNOTIFY = 528, // 0x00000210
            ENTERMENULOOP = 529, // 0x00000211
            EXITMENULOOP = 530, // 0x00000212
            NEXTMENU = 531, // 0x00000213
            SIZING = 532, // 0x00000214
            CAPTURECHANGED = 533, // 0x00000215
            MOVING = 534, // 0x00000216
            POWERBROADCAST = 536, // 0x00000218
            DEVICECHANGE = 537, // 0x00000219
            MDICREATE = 544, // 0x00000220
            MDIDESTROY = 545, // 0x00000221
            MDIACTIVATE = 546, // 0x00000222
            MDIRESTORE = 547, // 0x00000223
            MDINEXT = 548, // 0x00000224
            MDIMAXIMIZE = 549, // 0x00000225
            MDITILE = 550, // 0x00000226
            MDICASCADE = 551, // 0x00000227
            MDIICONARRANGE = 552, // 0x00000228
            MDIGETACTIVE = 553, // 0x00000229
            MDISETMENU = 560, // 0x00000230
            ENTERSIZEMOVE = 561, // 0x00000231
            EXITSIZEMOVE = 562, // 0x00000232
            DROPFILES = 563, // 0x00000233
            MDIREFRESHMENU = 564, // 0x00000234
            IME_SETCONTEXT = 641, // 0x00000281
            IME_NOTIFY = 642, // 0x00000282
            IME_CONTROL = 643, // 0x00000283
            IME_COMPOSITIONFULL = 644, // 0x00000284
            IME_SELECT = 645, // 0x00000285
            IME_CHAR = 646, // 0x00000286
            IME_REQUEST = 648, // 0x00000288
            IME_KEYDOWN = 656, // 0x00000290
            IME_KEYUP = 657, // 0x00000291
            NCMOUSEHOVER = 672, // 0x000002A0
            MOUSEHOVER = 673, // 0x000002A1
            NCMOUSELEAVE = 674, // 0x000002A2
            MOUSELEAVE = 675, // 0x000002A3
            WTSSESSION_CHANGE = 689, // 0x000002B1
            TABLET_FIRST = 704, // 0x000002C0
            TABLET_LAST = 735, // 0x000002DF
            CUT = 768, // 0x00000300
            COPY = 769, // 0x00000301
            PASTE = 770, // 0x00000302
            CLEAR = 771, // 0x00000303
            UNDO = 772, // 0x00000304
            RENDERFORMAT = 773, // 0x00000305
            RENDERALLFORMATS = 774, // 0x00000306
            DESTROYCLIPBOARD = 775, // 0x00000307
            DRAWCLIPBOARD = 776, // 0x00000308
            PAINTCLIPBOARD = 777, // 0x00000309
            VSCROLLCLIPBOARD = 778, // 0x0000030A
            SIZECLIPBOARD = 779, // 0x0000030B
            ASKCBFORMATNAME = 780, // 0x0000030C
            CHANGECBCHAIN = 781, // 0x0000030D
            HSCROLLCLIPBOARD = 782, // 0x0000030E
            QUERYNEWPALETTE = 783, // 0x0000030F
            PALETTEISCHANGING = 784, // 0x00000310
            PALETTECHANGED = 785, // 0x00000311
            HOTKEY = 786, // 0x00000312
            TASKBUTTONMENU = 787, // 0x00000313
            PRINT = 791, // 0x00000317
            PRINTCLIENT = 792, // 0x00000318
            APPCOMMAND = 793, // 0x00000319
            THEMECHANGED = 794, // 0x0000031A
            HANDHELDFIRST = 856, // 0x00000358
            HANDHELDLAST = 863, // 0x0000035F
            AFXFIRST = 864, // 0x00000360
            AFXLAST = 895, // 0x0000037F
            PENWINFIRST = 896, // 0x00000380
            PENWINLAST = 911, // 0x0000038F
            USER = 1024, // 0x00000400
            REFLECT = 8192, // 0x00002000
            APP = 32768, // 0x00008000
        }
        /// <summary>
        /// 
        /// </summary>
        public enum TCMessage
        {
            /// <summary>
            /// 0x00001302
            /// </summary>
            GETIMAGELIST = 4866,
            /// <summary>
            /// 0x00001303
            /// </summary>
            SETIMAGELIST = 4867,
            /// <summary>
            /// 0x00001304
            /// </summary>
            GETITEMCOUNT = 4868,
            /// <summary>
            /// 0x00001305
            /// </summary>
            GETITEMA = 4869,
            /// <summary>
            /// 0x00001306
            /// </summary>
            SETITEMA = 4870,
            /// <summary>
            /// 0x00001307
            /// </summary>
            INSERTITEMA = 4871,
            /// <summary>
            /// 0x00001308
            /// </summary>
            DELETEITEM = 4872,
            /// <summary>
            /// 0x00001309
            /// </summary>
            DELETEALLITEMS = 4873,
            /// <summary>
            /// 0x0000130A
            /// </summary>
            GETITEMRECT = 4874,
            /// <summary>
            /// 0x0000130B
            /// </summary>
            GETCURSEL = 4875,
            /// <summary>
            /// 0x0000130C
            /// </summary>
            SETCURSEL = 4876,
            /// <summary>
            /// 0x0000130D
            /// </summary>
            HITTEST = 4877,
            /// <summary>
            /// 0x0000130E
            /// </summary>
            SETITEMEXTRA = 4878,
            /// <summary>
            /// 0x00001328
            /// </summary>
            ADJUSTRECT = 4904,
            /// <summary>
            /// 0x00001329
            /// </summary>
            SETITEMSIZE = 4905,
            /// <summary>
            /// 0x0000132A
            /// </summary>
            REMOVEIMAGE = 4906,
            /// <summary>
            /// 0x0000132B
            /// </summary>
            SETPADDING = 4907,
            /// <summary>
            /// 0x0000132C
            /// </summary>
            GETROWCOUNT = 4908,
            /// <summary>
            /// 0x0000132D
            /// </summary>
            GETTOOLTIPS = 4909,
            /// <summary>
            /// 0x0000132E
            /// </summary>
            SETTOOLTIPS = 4910,
            /// <summary>
            /// 0x0000132F
            /// </summary>
            GETCURFOCUS = 4911,
            /// <summary>
            /// 0x00001330
            /// </summary>
            SETCURFOCUS = 4912,
            /// <summary>
            /// 0x00001331
            /// </summary>
            SETMINTABWIDTH = 4913,
            /// <summary>
            /// 0x00001332
            /// </summary>
            DESELECTALL = 4914,
            /// <summary>
            /// 0x00001333
            /// </summary>
            HIGHLIGHTITEM = 4915,
            /// <summary>
            /// 0x00001334
            /// </summary>
            SETEXTENDEDSTYLE = 4916,
            /// <summary>
            /// 0x00001335
            /// </summary>
            GETEXTENDEDSTYLE = 4917,
            /// <summary>
            /// 0x0000133C
            /// </summary>
            GETITEMW = 4924,
            /// <summary>
            /// 0x0000133D
            /// </summary>
            SETITEMW = 4925,
            /// <summary>
            /// 0x0000133E
            /// </summary>
            INSERTITEMW = 4926,
        }
        /// <summary>
        /// 
        /// </summary>
        public enum TC_NOTIFYMESSAGECODE
        {
            /// <summary>
            /// 0xFFFFFDD6
            /// </summary>
            FOCUSCHANGE = -554,
            /// <summary>
            /// 0xFFFFFDD7
            /// </summary>
            GETOBJECT = -553,
            /// <summary>
            /// 0xFFFFFDD8
            /// </summary>
            SELCHANGING = -552,
            /// <summary>
            /// 0xFFFFFDD9
            /// </summary>
            SELCHANGE = -551,
            /// <summary>
            /// 0xFFFFFDDA
            /// </summary>
            KEYDOWN = -550,
            /// <summary>
            /// 0xFFFFFFF0
            /// </summary>
            RELEASEDCAPTURE = -16,
            /// <summary>
            /// 0xFFFFFFFB
            /// </summary>
            RCLICK = -5,
            /// <summary>
            /// 0xFFFFFFFE
            /// </summary>
            CLICK = -2,
        }
        /// <summary>
        /// 
        /// </summary>
        [Flags]
        public enum DRAWTEXTFLAGS
        {
            /// <summary>
            /// 
            /// </summary>
            LEFT = 0,
            /// <summary>
            /// 
            /// </summary>
            TOP = 0,
            /// <summary>
            /// 
            /// </summary>
            CENTER = 1,
            /// <summary>
            /// 
            /// </summary>
            RIGHT = 2,
            /// <summary>
            /// 
            /// </summary>
            VCENTER = 4,
            /// <summary>
            /// 
            /// </summary>
            BOTTOM = 8,
            /// <summary>
            /// 0x00000010
            /// </summary>
            WORDBREAK = 16,
            /// <summary>
            /// 0x00000020
            /// </summary>
            SINGLELINE = 32,
            /// <summary>
            /// 0x00000040
            /// </summary>
            EXPANDTABS = 64,
            /// <summary>
            /// 0x00000080
            /// </summary>
            TABSTOP = 128,
            /// <summary>
            /// 0x00000100
            /// </summary>
            NOCLIP = 256,
            /// <summary>
            /// 0x00000200
            /// </summary>
            EXTERNALLEADING = 512,
            /// <summary>
            /// 0x00000400
            /// </summary>
            CALCRECT = 1024,
            /// <summary>
            /// 0x00000800
            /// </summary>
            NOPREFIX = 2048,
            /// <summary>
            /// 0x00001000
            /// </summary>
            INTERNAL = 4096,
            /// <summary>
            /// 0x00100000
            /// </summary>
            HIDEPREFIX = 1048576,
        }
        /// <summary>
        /// Contains information about a hit test. This structure supersedes the <b>TC_HITTESTINFO</b> structure.
        /// </summary>
        public struct TCHITTESTINFO
        {
            /// <summary>
            /// Position to hit test, in client coordinates.
            /// </summary>
            public Point pt;
            /// <summary>
            /// Variable that receives the results of a hit test. 
            /// The tab control sets this member to one of the <see href="https://learn.microsoft.com/en-us/windows/win32/api/commctrl/ns-commctrl-tchittestinfo#members">following</see> values:
            /// </summary>
            public TCHITTESTFLAGS flags;
            /// <summary>
            /// Contains information about a hit test. This structure supersedes the <b>TC_HITTESTINFO</b> structure.
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            public TCHITTESTINFO(int x, int y)
            {
                this.pt = new Point(x, y);
                this.flags = TCHITTESTFLAGS.ONITEM;
            }
        }
        /// <summary>
        /// Contains information about a notification message.
        /// </summary>
        public struct NMHDR
        {
            /// <summary>
            /// A window handle to the control sending the message.
            /// </summary>
            public IntPtr hWnd;
            /// <summary>
            /// An identifier of the control sending the message.
            /// </summary>
            public int idFrom;
            /// <summary>
            /// A notification code. 
            /// This member can be one of the common notification codes (see Notifications under <see href="https://learn.microsoft.com/en-us/windows/desktop/Controls/common-control-reference">General Control Reference</see>), or it can be a control-specific notification code.
            /// </summary>
            public int code;
        }
        /// <summary>
        /// Contains information used with the <see href="https://learn.microsoft.com/en-us/windows/desktop/Controls/tbn-getobject">TBN_GETOBJECT</see>,
        /// <see href="https://learn.microsoft.com/en-us/windows/desktop/Controls/tcn-getobject">TCN_GETOBJECT</see>, and 
        /// <see href="https://learn.microsoft.com/en-us/windows/desktop/Controls/psn-getobject">PSN_GETOBJECT</see> notification codes.
        /// </summary>
        public struct NMOBJECTNOTIFY
        {
            /// <summary>
            /// An <see href="https://learn.microsoft.com/en-us/windows/desktop/api/richedit/ns-richedit-nmhdr">NMHDR</see> structure that contains additional information about this notification.
            /// </summary>
            public NMHDR hdr;
            /// <summary>
            /// A control-specific item identifier. This value will comply to item identification standards for the control sending the notification.
            /// However, this member is not used with the <see href="https://learn.microsoft.com/en-us/windows/desktop/Controls/psn-getobject">PSN_GETOBJECT</see> notification code.
            /// </summary>
            public int iItem;
            /// <summary>
            /// A pointer to an interface identifier of the requested object.
            /// </summary>
            public IntPtr piid;
            /// <summary>
            /// A pointer to an object provided by the window processing the notification code. The application processing the notification code sets this member.
            /// </summary>
            public IntPtr pObject;
            /// <summary>
            /// COM success or failure flags. The application processing the notification code sets this member.
            /// </summary>
            public IntPtr hResult;
        }
        /// <summary>
        /// 
        /// </summary>
        public struct TCKEYDOWN
        {
            /// <summary>
            /// 
            /// </summary>
            public NMHDR hdr;
            /// <summary>
            /// 
            /// </summary>
            public short wVKey;
            /// <summary>
            /// 
            /// </summary>
            public int flags;
        }
        /// <summary>
        /// The RECT structure defines a rectangle by the coordinates of its upper-left and lower-right corners.
        /// </summary>
        public struct RECT
        {
            /// <summary>
            /// Specifies the x-coordinate of the upper-left corner of the rectangle.
            /// </summary>
            public int Left;
            /// <summary>
            /// Specifies the y-coordinate of the upper-left corner of the rectangle.
            /// </summary>
            public int Top;
            /// <summary>
            /// Specifies the x-coordinate of the lower-right corner of the rectangle.
            /// </summary>
            public int Right;
            /// <summary>
            /// Specifies the y-coordinate of the lower-right corner of the rectangle.
            /// </summary>
            public int Bottom;
            /// <summary>
            /// 
            /// </summary>
            public int Height
            {
                get
                {
                    return this.Bottom - this.Top;
                }
            }
            /// <summary>
            /// 
            /// </summary>
            public int Width
            {
                get
                {
                    return this.Right - this.Left;
                }
            }
            /// <summary>
            /// 
            /// </summary>
            public Size Size
            {
                get
                {
                    return new Size(this.Width, this.Height);
                }
            }
        }
    }
}
