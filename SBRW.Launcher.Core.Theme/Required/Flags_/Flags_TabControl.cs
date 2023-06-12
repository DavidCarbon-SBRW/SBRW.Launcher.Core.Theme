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
            /// <summary>
            /// 
            /// </summary>
            NULL = 0,
            /// <summary>
            /// 
            /// </summary>
            CREATE = 1,
            /// <summary>
            /// 
            /// </summary>
            DESTROY = 2,
            /// <summary>
            /// 
            /// </summary>
            MOVE = 3,
            /// <summary>
            /// 
            /// </summary>
            SIZE = 5,
            /// <summary>
            /// 
            /// </summary>
            ACTIVATE = 6,
            /// <summary>
            /// 
            /// </summary>
            SETFOCUS = 7,
            /// <summary>
            /// 0x0000000A
            /// </summary>
            KILLFOCUS = 8,
            /// <summary>
            /// 0x0000000B
            /// </summary>
            ENABLE = 10,
            /// <summary>
            /// 0x0000000C
            /// </summary>
            SETREDRAW = 11,
            /// <summary>
            /// 0x0000000D
            /// </summary>
            SETTEXT = 12,
            /// <summary>
            /// 0x0000000E
            /// </summary>
            GETTEXT = 13,
            /// <summary>
            /// 0x0000000F
            /// </summary>
            GETTEXTLENGTH = 14,
            /// <summary>
            /// 
            /// </summary>
            PAINT = 15,
            /// <summary>
            /// 0x00000010
            /// </summary>
            CLOSE = 16,
            /// <summary>
            /// 0x00000011
            /// </summary>
            QUERYENDSESSION = 17,
            /// <summary>
            /// 0x00000012
            /// </summary>
            QUIT = 18,
            /// <summary>
            /// 0x00000013
            /// </summary>
            QUERYOPEN = 19,
            /// <summary>
            /// 0x00000014
            /// </summary>
            ERASEBKGND = 20,
            /// <summary>
            /// 0x00000015
            /// </summary>
            SYSCOLORCHANGE = 21,
            /// <summary>
            /// 0x00000016
            /// </summary>
            ENDSESSION = 22,
            /// <summary>
            /// 0x00000018
            /// </summary>
            SHOWWINDOW = 24,
            /// <summary>
            /// 0x0000001A
            /// </summary>
            SETTINGCHANGE = 26,
            /// <summary>
            /// 0x0000001A
            /// </summary>
            WININICHANGE = 26,
            /// <summary>
            /// 0x0000001B
            /// </summary>
            DEVMODECHANGE = 27,
            /// <summary>
            /// 0x0000001C
            /// </summary>
            ACTIVATEAPP = 28,
            /// <summary>
            /// 0x0000001D
            /// </summary>
            FONTCHANGE = 29,
            /// <summary>
            /// 0x0000001E
            /// </summary>
            TIMECHANGE = 30,
            /// <summary>
            /// 0x0000001F
            /// </summary>
            CANCELMODE = 31,
            /// <summary>
            /// 0x00000020
            /// </summary>
            SETCURSOR = 32,
            /// <summary>
            /// 0x00000021
            /// </summary>
            MOUSEACTIVATE = 33,
            /// <summary>
            /// 0x00000022
            /// </summary>
            CHILDACTIVATE = 34,
            /// <summary>
            /// 0x00000023
            /// </summary>
            QUEUESYNC = 35,
            /// <summary>
            /// 0x00000024
            /// </summary>
            GETMINMAXINFO = 36,
            /// <summary>
            /// 0x00000026
            /// </summary>
            PAINTICON = 38,
            /// <summary>
            /// 0x00000027
            /// </summary>
            ICONERASEBKGND = 39,
            /// <summary>
            /// 0x00000028
            /// </summary>
            NEXTDLGCTL = 40,
            /// <summary>
            /// 0x0000002A
            /// </summary>
            SPOOLERSTATUS = 42,
            /// <summary>
            /// 0x0000002B
            /// </summary>
            DRAWITEM = 43,
            /// <summary>
            /// 0x0000002C
            /// </summary>
            MEASUREITEM = 44,
            /// <summary>
            /// 0x0000002D
            /// </summary>
            DELETEITEM = 45,
            /// <summary>
            /// 0x0000002E
            /// </summary>
            VKEYTOITEM = 46,
            /// <summary>
            /// 0x0000002F
            /// </summary>
            CHARTOITEM = 47,
            /// <summary>
            /// 0x00000030
            /// </summary>
            SETFONT = 48,
            /// <summary>
            /// 0x00000031
            /// </summary>
            GETFONT = 49,
            /// <summary>
            /// 0x00000032
            /// </summary>
            SETHOTKEY = 50,
            /// <summary>
            /// 0x00000033
            /// </summary>
            GETHOTKEY = 51,
            /// <summary>
            /// 0x00000037
            /// </summary>
            QUERYDRAGICON = 55,
            /// <summary>
            /// 0x00000039
            /// </summary>
            COMPAREITEM = 57,
            /// <summary>
            /// 0x0000003D
            /// </summary>
            GETOBJECT = 61,
            /// <summary>
            /// 0x00000041
            /// </summary>
            COMPACTING = 65,
            /// <summary>
            /// 0x00000044
            /// </summary>
            COMMNOTIFY = 68,
            /// <summary>
            /// 0x00000046
            /// </summary>
            WINDOWPOSCHANGING = 70,
            /// <summary>
            /// 0x00000047
            /// </summary>
            WINDOWPOSCHANGED = 71,
            /// <summary>
            /// 0x0000004A
            /// </summary>
            COPYDATA = 74,
            /// <summary>
            /// 0x0000004B
            /// </summary>
            CANCELJOURNAL = 75,
            /// <summary>
            /// 0x0000004E
            /// </summary>
            NOTIFY = 78,
            /// <summary>
            /// 0x00000050
            /// </summary>
            INPUTLANGCHANGEREQUEST = 80,
            /// <summary>
            /// 0x00000051
            /// </summary>
            INPUTLANGCHANGE = 81,
            /// <summary>
            /// 0x00000052
            /// </summary>
            TCARD = 82,
            /// <summary>
            /// 0x00000053
            /// </summary>
            HELP = 83,
            /// <summary>
            /// 0x00000054
            /// </summary>
            USERCHANGED = 84,
            /// <summary>
            /// 0x00000055
            /// </summary>
            NOTIFYFORMAT = 85,
            /// <summary>
            /// 0x0000007B
            /// </summary>
            CONTEXTMENU = 123,
            /// <summary>
            /// 0x0000007C
            /// </summary>
            STYLECHANGING = 124,
            /// <summary>
            /// 0x0000007D
            /// </summary>
            STYLECHANGED = 125,
            /// <summary>
            /// 0x0000007E
            /// </summary>
            DISPLAYCHANGE = 126,
            /// <summary>
            /// 0x0000007F
            /// </summary>
            GETICON = 127,
            /// <summary>
            /// 0x00000080
            /// </summary>
            SETICON = 128,
            /// <summary>
            /// 0x00000081
            /// </summary>
            NCCREATE = 129,
            /// <summary>
            /// 0x00000082
            /// </summary>
            NCDESTROY = 130,
            /// <summary>
            /// 0x00000083
            /// </summary>
            NCCALCSIZE = 131,
            /// <summary>
            /// 0x00000084
            /// </summary>
            NCHITTEST = 132,
            /// <summary>
            /// 0x00000085
            /// </summary>
            NCPAINT = 133,
            /// <summary>
            /// 0x00000086
            /// </summary>
            NCACTIVATE = 134,
            /// <summary>
            /// 0x00000087
            /// </summary>
            GETDLGCODE = 135,
            /// <summary>
            /// 0x00000088
            /// </summary>
            SYNCPAINT = 136,
            /// <summary>
            /// 0x000000A0
            /// </summary>
            NCMOUSEMOVE = 160,
            /// <summary>
            /// 0x000000A1
            /// </summary>
            NCLBUTTONDOWN = 161,
            /// <summary>
            /// 0x000000A2
            /// </summary>
            NCLBUTTONUP = 162,
            /// <summary>
            /// 0x000000A3
            /// </summary>
            NCLBUTTONDBLCLK = 163,
            /// <summary>
            /// 0x000000A4
            /// </summary>
            NCRBUTTONDOWN = 164,
            /// <summary>
            /// 0x000000A5
            /// </summary>
            NCRBUTTONUP = 165,
            /// <summary>
            /// 0x000000A6
            /// </summary>
            NCRBUTTONDBLCLK = 166,
            /// <summary>
            /// 0x000000A7
            /// </summary>
            NCMBUTTONDOWN = 167,
            /// <summary>
            /// 0x000000A8
            /// </summary>
            NCMBUTTONUP = 168,
            /// <summary>
            /// 0x000000A9
            /// </summary>
            NCMBUTTONDBLCLK = 169,
            /// <summary>
            /// 0x000000AB
            /// </summary>
            NCXBUTTONDOWN = 171,
            /// <summary>
            /// 0x000000AC
            /// </summary>
            NCXBUTTONUP = 172,
            /// <summary>
            /// 0x000000AD
            /// </summary>
            NCXBUTTONDBLCLK = 173,
            /// <summary>
            /// 0x000000FF
            /// </summary>
            INPUT = 255,
            /// <summary>
            /// 0x00000100
            /// </summary>
            KEYDOWN = 256,
            /// <summary>
            /// 0x00000100
            /// </summary>
            KEYFIRST = 256,
            /// <summary>
            /// 0x00000101
            /// </summary>
            KEYUP = 257,
            /// <summary>
            /// 0x00000102
            /// </summary>
            CHAR = 258,
            /// <summary>
            /// 0x00000103
            /// </summary>
            DEADCHAR = 259,
            /// <summary>
            /// 0x00000104
            /// </summary>
            SYSKEYDOWN = 260,
            /// <summary>
            /// 0x00000105
            /// </summary>
            SYSKEYUP = 261,
            /// <summary>
            /// 0x00000106
            /// </summary>
            SYSCHAR = 262,
            /// <summary>
            /// 0x00000107
            /// </summary>
            SYSDEADCHAR = 263,
            /// <summary>
            /// 0x00000108
            /// </summary>
            KEYLAST = 264,
            /// <summary>
            /// 0x00000109
            /// </summary>
            KEYLAST_XP = 265,
            /// <summary>
            /// 0x00000109
            /// </summary>
            UNICHAR = 265,
            /// <summary>
            /// 0x0000010D
            /// </summary>
            IME_STARTCOMPOSITION = 269,
            /// <summary>
            /// 0x0000010E
            /// </summary>
            IME_ENDCOMPOSITION = 270,
            /// <summary>
            /// 0x0000010F
            /// </summary>
            IME_COMPOSITION = 271,
            /// <summary>
            /// 0x0000010F
            /// </summary>
            IME_KEYLAST = 271,
            /// <summary>
            /// 0x00000110
            /// </summary>
            INITDIALOG = 272,
            /// <summary>
            /// 0x00000111
            /// </summary>
            COMMAND = 273,
            /// <summary>
            /// 0x00000112
            /// </summary>
            SYSCOMMAND = 274,
            /// <summary>
            /// 0x00000113
            /// </summary>
            TIMER = 275,
            /// <summary>
            /// 0x00000114
            /// </summary>
            HSCROLL = 276,
            /// <summary>
            /// 0x00000115
            /// </summary>
            VSCROLL = 277,
            /// <summary>
            /// 0x00000116
            /// </summary>
            INITMENU = 278,
            /// <summary>
            /// 0x00000117
            /// </summary>
            INITMENUPOPUP = 279,
            /// <summary>
            /// 0x0000011F
            /// </summary>
            MENUSELECT = 287,
            /// <summary>
            /// 0x00000120
            /// </summary>
            MENUCHAR = 288,
            /// <summary>
            /// 0x00000121
            /// </summary>
            ENTERIDLE = 289,
            /// <summary>
            /// 0x00000122
            /// </summary>
            MENURBUTTONUP = 290,
            /// <summary>
            /// 0x00000123
            /// </summary>
            MENUDRAG = 291,
            /// <summary>
            /// 0x00000124
            /// </summary>
            MENUGETOBJECT = 292,
            /// <summary>
            /// 0x00000125
            /// </summary>
            UNINITMENUPOPUP = 293,
            /// <summary>
            /// 0x00000126
            /// </summary>
            MENUCOMMAND = 294,
            /// <summary>
            /// 0x00000127
            /// </summary>
            CHANGEUISTATE = 295,
            /// <summary>
            /// 0x00000128
            /// </summary>
            UPDATEUISTATE = 296,
            /// <summary>
            /// 0x00000129
            /// </summary>
            QUERYUISTATE = 297,
            /// <summary>
            /// 0x00000132
            /// </summary>
            CTLCOLORMSGBOX = 306,
            /// <summary>
            /// 0x00000133
            /// </summary>
            CTLCOLOREDIT = 307,
            /// <summary>
            /// 0x00000134
            /// </summary>
            CTLCOLORLISTBOX = 308,
            /// <summary>
            /// 0x00000135
            /// </summary>
            CTLCOLORBTN = 309,
            /// <summary>
            /// 0x00000136
            /// </summary>
            CTLCOLORDLG = 310,
            /// <summary>
            /// 0x00000137
            /// </summary>
            CTLCOLORSCROLLBAR = 311,
            /// <summary>
            /// 0x00000138
            /// </summary>
            CTLCOLORSTATIC = 312,
            /// <summary>
            /// 0x00000200
            /// </summary>
            MOUSEFIRST = 512,
            /// <summary>
            /// 0x00000200
            /// </summary>
            MOUSEMOVE = 512,
            /// <summary>
            /// 0x00000201
            /// </summary>
            LBUTTONDOWN = 513,
            /// <summary>
            /// 0x00000202
            /// </summary>
            LBUTTONUP = 514,
            /// <summary>
            /// 0x00000203
            /// </summary>
            LBUTTONDBLCLK = 515,
            /// <summary>
            /// 0x00000204
            /// </summary>
            RBUTTONDOWN = 516,
            /// <summary>
            /// 0x00000205
            /// </summary>
            RBUTTONUP = 517,
            /// <summary>
            /// 0x00000206
            /// </summary>
            RBUTTONDBLCLK = 518,
            /// <summary>
            /// 0x00000207
            /// </summary>
            MBUTTONDOWN = 519,
            /// <summary>
            /// 0x00000208
            /// </summary>
            MBUTTONUP = 520,
            /// <summary>
            /// 0x00000209
            /// </summary>
            MBUTTONDBLCLK = 521,
            /// <summary>
            /// 0x00000209
            /// </summary>
            MOUSELAST = 521,
            /// <summary>
            /// 0x0000020A
            /// </summary>
            MOUSELAST_NT = 522,
            /// <summary>
            /// 0x0000020A
            /// </summary>
            MOUSEWHEEL = 522,
            /// <summary>
            /// 0x0000020B
            /// </summary>
            XBUTTONDOWN = 523,
            /// <summary>
            /// 0x0000020C
            /// </summary>
            XBUTTONUP = 524,
            /// <summary>
            /// 0x0000020D
            /// </summary>
            MOUSELAST_2K = 525,
            /// <summary>
            /// 0x0000020D
            /// </summary>
            XBUTTONDBLCLK = 525,
            /// <summary>
            /// 0x00000210
            /// </summary>
            PARENTNOTIFY = 528,
            /// <summary>
            /// 0x00000211
            /// </summary>
            ENTERMENULOOP = 529,
            /// <summary>
            /// 0x00000212
            /// </summary>
            EXITMENULOOP = 530,
            /// <summary>
            /// 0x00000213
            /// </summary>
            NEXTMENU = 531,
            /// <summary>
            /// 0x00000214
            /// </summary>
            SIZING = 532,
            /// <summary>
            /// 0x00000215
            /// </summary>
            CAPTURECHANGED = 533,
            /// <summary>
            /// 0x00000216
            /// </summary>
            MOVING = 534,
            /// <summary>
            /// 0x00000218
            /// </summary>
            POWERBROADCAST = 536,
            /// <summary>
            /// 0x00000219
            /// </summary>
            DEVICECHANGE = 537,
            /// <summary>
            /// 0x00000220
            /// </summary>
            MDICREATE = 544,
            /// <summary>
            /// 0x00000221
            /// </summary>
            MDIDESTROY = 545,
            /// <summary>
            /// 0x00000222
            /// </summary>
            MDIACTIVATE = 546,
            /// <summary>
            /// 0x00000223
            /// </summary>
            MDIRESTORE = 547,
            /// <summary>
            /// 0x00000224
            /// </summary>
            MDINEXT = 548,
            /// <summary>
            /// 0x00000225
            /// </summary>
            MDIMAXIMIZE = 549,
            /// <summary>
            /// 0x00000226
            /// </summary>
            MDITILE = 550,
            /// <summary>
            /// 0x00000227
            /// </summary>
            MDICASCADE = 551,
            /// <summary>
            /// 0x00000228
            /// </summary>
            MDIICONARRANGE = 552,
            /// <summary>
            /// 0x00000229
            /// </summary>
            MDIGETACTIVE = 553,
            /// <summary>
            /// 0x00000230
            /// </summary>
            MDISETMENU = 560,
            /// <summary>
            /// 0x00000231
            /// </summary>
            ENTERSIZEMOVE = 561,
            /// <summary>
            /// 0x00000232
            /// </summary>
            EXITSIZEMOVE = 562,
            /// <summary>
            /// 0x00000233
            /// </summary>
            DROPFILES = 563,
            /// <summary>
            /// 0x00000234
            /// </summary>
            MDIREFRESHMENU = 564,
            /// <summary>
            /// 0x00000281
            /// </summary>
            IME_SETCONTEXT = 641,
            /// <summary>
            /// 0x00000282
            /// </summary>
            IME_NOTIFY = 642,
            /// <summary>
            /// 0x00000283
            /// </summary>
            IME_CONTROL = 643,
            /// <summary>
            /// 0x00000284
            /// </summary>
            IME_COMPOSITIONFULL = 644,
            /// <summary>
            /// 0x00000285
            /// </summary>
            IME_SELECT = 645,
            /// <summary>
            /// 0x00000286
            /// </summary>
            IME_CHAR = 646,
            /// <summary>
            /// 0x00000288
            /// </summary>
            IME_REQUEST = 648,
            /// <summary>
            /// 0x00000290
            /// </summary>
            IME_KEYDOWN = 656,
            /// <summary>
            /// 0x00000291
            /// </summary>
            IME_KEYUP = 657,
            /// <summary>
            /// 0x000002A0
            /// </summary>
            NCMOUSEHOVER = 672,
            /// <summary>
            /// 0x000002A1
            /// </summary>
            MOUSEHOVER = 673,
            /// <summary>
            /// 0x000002A2
            /// </summary>
            NCMOUSELEAVE = 674,
            /// <summary>
            /// 0x000002A3
            /// </summary>
            MOUSELEAVE = 675,
            /// <summary>
            /// 0x000002B1
            /// </summary>
            WTSSESSION_CHANGE = 689,
            /// <summary>
            /// 0x000002C0
            /// </summary>
            TABLET_FIRST = 704,
            /// <summary>
            /// 0x000002DF
            /// </summary>
            TABLET_LAST = 735,
            /// <summary>
            /// 0x00000300
            /// </summary>
            CUT = 768,
            /// <summary>
            /// 0x00000301
            /// </summary>
            COPY = 769,
            /// <summary>
            /// 0x00000302
            /// </summary>
            PASTE = 770,
            /// <summary>
            /// 0x00000303
            /// </summary>
            CLEAR = 771,
            /// <summary>
            /// 0x00000304
            /// </summary>
            UNDO = 772,
            /// <summary>
            /// 0x00000305
            /// </summary>
            RENDERFORMAT = 773,
            /// <summary>
            /// 0x00000306
            /// </summary>
            RENDERALLFORMATS = 774,
            /// <summary>
            /// 0x00000307
            /// </summary>
            DESTROYCLIPBOARD = 775,
            /// <summary>
            /// 0x00000308
            /// </summary>
            DRAWCLIPBOARD = 776,
            /// <summary>
            /// 0x00000309
            /// </summary>
            PAINTCLIPBOARD = 777,
            /// <summary>
            /// 0x0000030A
            /// </summary>
            VSCROLLCLIPBOARD = 778,
            /// <summary>
            /// 0x0000030B
            /// </summary>
            SIZECLIPBOARD = 779,
            /// <summary>
            /// 0x0000030C
            /// </summary>
            ASKCBFORMATNAME = 780,
            /// <summary>
            /// 0x0000030D
            /// </summary>
            CHANGECBCHAIN = 781,
            /// <summary>
            /// 0x0000030E
            /// </summary>
            HSCROLLCLIPBOARD = 782,
            /// <summary>
            /// 0x0000030F
            /// </summary>
            QUERYNEWPALETTE = 783,
            /// <summary>
            /// 0x00000310
            /// </summary>
            PALETTEISCHANGING = 784,
            /// <summary>
            /// 0x00000311
            /// </summary>
            PALETTECHANGED = 785,
            /// <summary>
            /// 0x00000312
            /// </summary>
            HOTKEY = 786,
            /// <summary>
            /// 0x00000313
            /// </summary>
            TASKBUTTONMENU = 787,
            /// <summary>
            /// 0x00000317
            /// </summary>
            PRINT = 791,
            /// <summary>
            /// 0x00000318
            /// </summary>
            PRINTCLIENT = 792,
            /// <summary>
            /// 0x00000319
            /// </summary>
            APPCOMMAND = 793,
            /// <summary>
            /// 0x0000031A
            /// </summary>
            THEMECHANGED = 794,
            /// <summary>
            /// 0x00000358
            /// </summary>
            HANDHELDFIRST = 856,
            /// <summary>
            /// 0x0000035F
            /// </summary>
            HANDHELDLAST = 863,
            /// <summary>
            /// 0x00000360
            /// </summary>
            AFXFIRST = 864,
            /// <summary>
            /// 0x0000037F
            /// </summary>
            AFXLAST = 895,
            /// <summary>
            /// 0x00000380
            /// </summary>
            PENWINFIRST = 896,
            /// <summary>
            /// 0x0000038F
            /// </summary>
            PENWINLAST = 911,
            /// <summary>
            /// 0x00000400
            /// </summary>
            USER = 1024,
            /// <summary>
            /// 0x00002000
            /// </summary>
            REFLECT = 8192,
            /// <summary>
            /// 0x00008000
            /// </summary>
            APP = 32768,
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
            /// <summary>
            /// 0x200000
            /// </summary>
            PREFIXONLY = 2097152,
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
