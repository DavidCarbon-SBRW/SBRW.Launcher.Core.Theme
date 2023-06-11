#if NETFRAMEWORK || NET6_0_OR_GREATER && WINDOWS
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Media;
using System.Reflection;
using System.Security.Permissions;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using SBRW.Launcher.Core.Theme.Required.DLL.Gdi32_;
using SBRW.Launcher.Core.Theme.Required.DLL.User32_;
using SBRW.Launcher.Core.Theme.Required.DLL.UxTheme_;
using SBRW.Launcher.Core.Theme.Required.Flags_;

namespace SBRW.Launcher.Core.Theme
{
    /// <summary>
    /// 
    /// </summary>
    [ToolboxItemFilter("Containers")]
    [ToolboxBitmap(typeof(System.Windows.Forms.TabControl))]
    public class Control_TabControl : System.Windows.Forms.TabControl
    {
        /// <summary>
        /// 
        /// </summary>
        private Color myBackColor = Color.Empty;
        /// <summary>
        /// 
        /// </summary>
        private int myHotTabID = -1;
        /// <summary>
        /// 
        /// </summary>
        private Color myTabColor = SystemColors.Control;
        /// <summary>
        /// 
        /// </summary>
        private Color mySelectedTabColor = SystemColors.Control;
        /// <summary>
        /// 
        /// </summary>
        private Color myHotColor = SystemColors.HotTrack;
        /// <summary>
        /// 
        /// </summary>
        private TabDrawMode myDrawMode;
        /// <summary>
        /// 
        /// </summary>
        private bool firstShown;
        /// <summary>
        /// 
        /// </summary>
        private bool rotateImageWithTab;
        /// <summary>
        /// 
        /// </summary>
        private Bitmap BufferImage;
        /// <summary>
        /// 
        /// </summary>
        private bool myDoubleBufferTabpages;
        /// <summary>
        /// 
        /// </summary>
        private bool myUseBackColorBehindTabs;
        /// <summary>
        /// 
        /// </summary>
        public Control_TabControl()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.Opaque, false);
            this.DoubleBuffered = false;
        }
        /// <summary>
        /// 
        /// </summary>
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public override Color BackColor
        {
            get
            {
                return this.myBackColor.Equals((object)Color.Empty) ? base.BackColor : this.myBackColor;
            }
            set
            {
                this.myBackColor = value;
                this.OnBackColorChanged(EventArgs.Empty);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public new void ResetBackColor()
        {
            this.BackColor = Color.Empty;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool ShouldSerializeBackColor()
        {
            return !this.myBackColor.Equals((object)Color.Empty);
        }
        /// <summary>
        /// 
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public override Rectangle DisplayRectangle
        {
            get
            {
                int num1 = 0;
                if (this.Appearance == TabAppearance.Normal)
                    num1 = 4;
                int num2 = this.Alignment > TabAlignment.Bottom ? this.ItemSize.Width : this.ItemSize.Height;
                int num3 = this.Appearance != TabAppearance.Normal ? (3 + num2) * this.RowCount : 5 + num2 * this.RowCount;
                Rectangle rectangle;
                switch (this.Alignment)
                {
                    case TabAlignment.Bottom:
                        rectangle = new Rectangle(num1, num1, this.Width - num1 * 2, this.Height - num3 - num1);
                        break;
                    case TabAlignment.Left:
                        rectangle = new Rectangle(num3, num1, this.Width - num3 - num1, this.Height - num1 * 2);
                        break;
                    case TabAlignment.Right:
                        rectangle = new Rectangle(num1, num1, this.Width - num3 - num1, this.Height - num1 * 2);
                        break;
                    default:
                        rectangle = new Rectangle(num1, num3, this.Width - num1 * 2, this.Height - num3 - num1);
                        break;
                }
                return rectangle;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(typeof(TabDrawMode), "Normal")]
        public new TabDrawMode DrawMode
        {
            get
            {
                return this.myDrawMode;
            }
            set
            {
                this.myDrawMode = value;
                base.DrawMode = TabDrawMode.Normal;
                this.Invalidate();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public new TabAppearance Appearance
        {
            get
            {
                return base.Appearance;
            }
            set
            {
                base.Appearance = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Description("The color of unselected tabs without Visual Style.")]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "Control")]
        public Color TabColor
        {
            get
            {
                return this.myTabColor;
            }
            set
            {
                this.myTabColor = value;
                this.Invalidate();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Category("Appearance")]
        [Description("The color of the selected tab without Visual Style.")]
        [DefaultValue(typeof(Color), "Control")]
        public Color SelectedTabColor
        {
            get
            {
                return this.mySelectedTabColor;
            }
            set
            {
                this.mySelectedTabColor = value;
                this.Invalidate();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(typeof(Color), "HotTrack")]
        [Description("The color of text on a tab which the mouse is over. Only applies if HotTrack is true.")]
        [Category("Appearance")]
        public Color HotColor
        {
            get
            {
                return this.myHotColor;
            }
            set
            {
                this.myHotColor = value;
                this.Invalidate();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Category("Behavior")]
        [Description("Sets DoubleBuffer on TabPages to help with flicker. Should only be set if using transparency.")]
        [DefaultValue(false)]
        public bool DoubleBufferTabPages
        {
            get
            {
                return this.myDoubleBufferTabpages;
            }
            set
            {
                if (this.myDoubleBufferTabpages == value)
                    return;
                this.myDoubleBufferTabpages = value;
                if (this.SelectedIndex == -1)
                    return;
                this.SetDoubleBuffered(this.SelectedTab);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(false)]
        [Category("Appearance")]
        [Description("Gets/sets whether or not the BackColor should be painted behind tabs.")]
        public bool UseBackColorBehindTabs
        {
            get
            {
                return this.myUseBackColorBehindTabs;
            }
            set
            {
                this.myUseBackColorBehindTabs = value;
                this.Invalidate();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Description("Gets/sets whether or not a tabs Image should be rotated with the tab.")]
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool RotateImageWithTab
        {
            get
            {
                return this.rotateImageWithTab;
            }
            set
            {
                if (this.rotateImageWithTab == value)
                    return;
                this.rotateImageWithTab = value;
                this.Invalidate();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private TabPage TabUnderMouse
        {
            get
            {
                return this.TabFromPoint(this.PointToClient(Control.MousePosition));
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private TabPage TabWithFocus
        {
            get
            {
                if (this.Appearance == TabAppearance.Normal)
                    return this.SelectedTab;
                int int32 = this.Handle.MessageSend(4911, IntPtr.Zero, IntPtr.Zero).ToInt32();
                return int32 != -1 ? this.TabPages[int32] : (TabPage)null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private int HotTabID
        {
            get
            {
                return this.myHotTabID;
            }
            set
            {
                if (this.myHotTabID == value)
                    return;
                this.myHotTabID = value;
                this.Invalidate();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private bool VisualStylesEnabled
        {
            get
            {
                if (this.Appearance != TabAppearance.Normal || !Application.RenderWithVisualStyles)
                    return false;
                return this.DesignMode ? VisualStyleRenderer.IsSupported : this.Handle.WindowThemeGet() != IntPtr.Zero;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pevent"></param>
        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            if (this.Width <= 0 || this.Height <= 0)
                return;
            pevent.Graphics.Flush(FlushIntention.Sync);
            using (Bitmap bitmap = new Bitmap(this.Width, this.Height, PixelFormat.Format32bppPArgb))
            {
                using (Graphics graphics = Graphics.FromImage((Image)bitmap))
                {
                    if (this.BufferImage != null)
                        graphics.DrawImage((Image)this.BufferImage, Point.Empty);
                    Rectangle rect = this.ClientRectangle;
                    if (!this.myUseBackColorBehindTabs)
                        rect = this.DisplayRectangle;
                    using (SolidBrush solidBrush = new SolidBrush(this.BackColor))
                        graphics.FillRectangle((Brush)solidBrush, rect);
                    this.DrawBorder(graphics);
                    for (int id = 0; id < this.TabCount; ++id)
                    {
                        if (id != this.SelectedIndex)
                            this.PaintTab(graphics, id);
                    }
                    if (this.SelectedIndex != -1)
                        this.PaintTab(graphics, this.SelectedIndex);
                    IntPtr hbitmap = bitmap.GetHbitmap();
                    IntPtr hdc1 = graphics.GetHdc();
                    IntPtr compatibleDc = hdc1.DeviceContextCreateCompatible();
                    IntPtr hdc2 = compatibleDc.ObjectSelect(hbitmap);
                    IntPtr hdc3 = pevent.Graphics.GetHdc();
                    hdc3.BitBlock(0, 0, this.Width, this.Height, compatibleDc, 0, 0, 13369376);
                    pevent.Graphics.ReleaseHdc(hdc3);
                    hdc2.ObjectSelect(hbitmap);
                    compatibleDc.DeviceContextDelete();
                    graphics.ReleaseHdc(hdc1);
                    hbitmap.ObjectDelete();
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.OnFontChanged(EventArgs.Empty);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (this.Visible && !this.firstShown)
            {
                this.firstShown = true;
                if (this.SelectedIndex != -1)
                    this.SelectedTab = this.GetFirstEnabledTab();
                if (Application.RenderWithVisualStyles && this.Appearance == TabAppearance.Normal)
                {
                    this.Handle.WindowThemeSet("", "");
                    this.Handle.WindowThemeSet(null, null);
                }
            }
            this.DrawBufferImage();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            this.Handle.MessageSend(48, this.Font.ToHfont(), (IntPtr)(-1));
            this.Handle.MessageSend(29, IntPtr.Zero, IntPtr.Zero);
            this.UpdateStyles();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            this.Invalidate();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.DrawBufferImage();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (this.DrawMode == TabDrawMode.OwnerDrawFixed)
            {
                base.OnDrawItem(e);
            }
            else
            {
                TabPage tabPage = this.TabPages[e.Index];
                Rectangle bounds1 = e.Bounds;
                bool flag1 = this.RightToLeft == RightToLeft.Yes && this.RightToLeftLayout;
                bool visualStylesEnabled = this.VisualStylesEnabled;
                bool flag2 = (tabPage.ImageIndex >= 0 || !string.IsNullOrEmpty(tabPage.ImageKey)) && this.ImageList != null;
                bool flag3 = e.Index == this.SelectedIndex;
                Flags_TabControl.RECT lpRect = new Flags_TabControl.RECT();
                IntPtr hdc1 = e.Graphics.GetHdc();
                IntPtr hfont = this.Font.ToHfont();
                IntPtr hgdiobj = hdc1.ObjectSelect(hfont);
                hdc1.TextDraw(tabPage.Text, tabPage.Text.Length, ref lpRect, Flags_TabControl.DRAWTEXTFLAGS.CALCRECT | Flags_TabControl.DRAWTEXTFLAGS.HIDEPREFIX);
                hdc1.ObjectSelect(hgdiobj);
                hfont.ObjectDelete();
                e.Graphics.ReleaseHdc(hdc1);
                Rectangle bounds2 = new Rectangle(Point.Empty, lpRect.Size);
                Rectangle empty = Rectangle.Empty;
                Rectangle rectangle = bounds2;
                if (flag2)
                {
                    empty.Size = this.ImageList.ImageSize;
                    rectangle.Width += empty.Width + this.Padding.X;
                    rectangle.Height = Math.Max(bounds2.Height, empty.Height);
                }
                rectangle.Offset((bounds1.Width - rectangle.Width) / 2, (bounds1.Height - rectangle.Height) / 2);
                empty.X = flag1 ? rectangle.Right - empty.Width : rectangle.Left;
                bounds2.X = rectangle.Right - bounds2.Width;
                empty.Offset(0, (bounds1.Height - empty.Height) / 2);
                bounds2.Offset(0, (bounds1.Height - lpRect.Size.Height) / 2);
                if (flag3)
                {
                    if (this.Appearance == TabAppearance.Normal)
                    {
                        empty.Offset(0, this.Alignment == TabAlignment.Bottom ? 2 : -2);
                        bounds2.Offset(0, this.Alignment == TabAlignment.Bottom ? 2 : -2);
                    }
                    else
                    {
                        empty.Offset(1, 1);
                        bounds2.Offset(flag1 ? -1 : 1, 1);
                    }
                }
                if (this.Alignment != TabAlignment.Bottom)
                {
                    empty.Offset(0, 1);
                    bounds2.Offset(0, 1);
                }
                if (flag2)
                {
                    Bitmap bitmap = tabPage.ImageIndex != -1 ? (Bitmap)this.ImageList.Images[tabPage.ImageIndex] : (Bitmap)this.ImageList.Images[tabPage.ImageKey];
                    if (!this.RotateImageWithTab)
                    {
                        switch (this.Alignment)
                        {
                            case TabAlignment.Left:
                                bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
                                break;
                            case TabAlignment.Right:
                                bitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
                                break;
                        }
                    }
                    if (tabPage.Enabled)
                        e.Graphics.DrawImage((Image)bitmap, empty);
                    else
                        ControlPaint.DrawImageDisabled(e.Graphics, (Image)bitmap, empty.X, empty.Y, Color.Empty);
                    bitmap.Dispose();
                }
                Flags_TabControl.DrawStateFlags drawStateFlags = Flags_TabControl.DrawStateFlags.PREFIXTEXT;
                Color textColor = e.Index != this.HotTabID || !this.HotTrack || (this.Appearance == TabAppearance.FlatButtons || visualStylesEnabled) ? this.ForeColor : this.HotColor;
                if (!tabPage.Enabled)
                {
                    if (visualStylesEnabled)
                        textColor = SystemColors.GrayText;
                    else
                        drawStateFlags |= Flags_TabControl.DrawStateFlags.DISABLED;
                }
                if (!this.ShowKeyboardCues)
                    drawStateFlags |= Flags_TabControl.DrawStateFlags.HIDEPREFIX;
                if (this.RightToLeft == RightToLeft.Yes)
                    drawStateFlags |= Flags_TabControl.DrawStateFlags.RIGHT | Flags_TabControl.DrawStateFlags.RTLREADING;
                IntPtr hdc2 = e.Graphics.GetHdc();
                if (flag1)
                    hdc2.LayoutSet(9);
                e.Graphics.ReleaseHdc(hdc2);
                Control_TabControl.GdiDrawStateText(hdc2, tabPage.Text, this.Font, textColor, bounds2, (int)drawStateFlags);
                e.Graphics.Flush(FlushIntention.Sync);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (this.DesignMode)
                return;
            TabPage tabUnderMouse = this.TabUnderMouse;
            this.HotTabID = tabUnderMouse == null ? -1 : this.TabPages.IndexOf(tabUnderMouse);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            if (this.DesignMode)
                return;
            this.HotTabID = -1;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);
            if (this.SelectedIndex == -1)
                return;
            this.SetDoubleBuffered(this.SelectedTab);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnDeselected(TabControlEventArgs e)
        {
            base.OnDeselected(e);
            this.Invalidate();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool flag = base.ProcessCmdKey(ref msg, keyData);
            if (!flag)
            {
                switch (keyData)
                {
                    case Keys.Tab | Keys.Control:
                    case Keys.Tab | Keys.Shift | Keys.Control:
                        this.SelectedTab = this.GetNextEnabledTab((keyData & Keys.Shift) == Keys.None, true);
                        this.Focus();
                        return true;
                    case Keys.Prior | Keys.Control:
                    case Keys.Next | Keys.Control:
                        this.SelectedTab = this.GetNextEnabledTab((keyData & Keys.Next) == Keys.Next, true);
                        this.Focus();
                        return true;
                }
            }
            return flag;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="charCode"></param>
        /// <returns></returns>
        protected override bool ProcessMnemonic(char charCode)
        {
            foreach (TabPage tabPage in this.TabPages)
            {
                if (tabPage.Enabled && Control.IsMnemonic(charCode, tabPage.Text))
                {
                    this.SelectedTab = tabPage;
                    return true;
                }
            }
            return base.ProcessMnemonic(charCode);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (this.Focused)
            {
                switch (e.KeyCode)
                {
                    case Keys.Return:
                    case Keys.Space:
                        if (this.Appearance != TabAppearance.Normal)
                        {
                            TabPage tabWithFocus = this.TabWithFocus;
                            if (tabWithFocus != null)
                            {
                                e.Handled = !tabWithFocus.Enabled;
                                if (e.Handled)
                                {
                                    SystemSounds.Beep.Play();
                                    break;
                                }
                                break;
                            }
                            break;
                        }
                        break;
                    case Keys.End:
                        e.Handled = true;
                        TabPage lastEnabledTab = this.GetLastEnabledTab();
                        if (lastEnabledTab != null)
                            this.SelectedTab = lastEnabledTab;
                        this.Focus();
                        break;
                    case Keys.Home:
                        e.Handled = true;
                        TabPage firstEnabledTab = this.GetFirstEnabledTab();
                        if (firstEnabledTab != null)
                            this.SelectedTab = firstEnabledTab;
                        this.Focus();
                        break;
                    case Keys.Left:
                    case Keys.Up:
                    case Keys.Right:
                    case Keys.Down:
                        if (this.Appearance == TabAppearance.Normal)
                        {
                            e.Handled = this.HandleArrowKeys(e.KeyCode);
                            break;
                        }
                        break;
                }
            }
            base.OnKeyDown(e);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="m"></param>
        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 20:
                    m.Msg = 0;
                    m.Result = IntPtr.Zero;
                    break;
                case 276:
                    this.Invalidate();
                    break;
                case 513:
                    TabPage tabUnderMouse = this.TabUnderMouse;
                    if (tabUnderMouse != null && !tabUnderMouse.Enabled)
                    {
                        m.Msg = 0;
                        break;
                    }
                    break;
                case 794:
                    this.Invalidate(true);
                    break;
            }
            base.WndProc(ref m);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="id"></param>
        private void PaintTab(Graphics graphics, int id)
        {
            if (id == -1)
                return;
            int alignment = (int)this.Alignment;
            Bitmap tabBaseBitmap = this.CreateTabBaseBitmap(id);
            Rectangle rect = new Rectangle(Point.Empty, tabBaseBitmap.Size);
            using (Graphics graphics1 = Graphics.FromImage((Image)tabBaseBitmap))
            {
                IntPtr hdc1 = graphics1.GetHdc();
                IntPtr hbitmap = tabBaseBitmap.GetHbitmap();
                IntPtr compatibleDc = hdc1.DeviceContextCreateCompatible();
                IntPtr hdc2 = compatibleDc.ObjectSelect(hbitmap);
                if (this.DrawMode == TabDrawMode.Normal)
                {
                    using (Graphics graphics2 = Graphics.FromHdc(compatibleDc))
                        this.OnDrawItem(new DrawItemEventArgs(graphics2, this.Font, rect, id, DrawItemState.Default));
                }
                hdc1.BitBlock(0, 0, rect.Width, rect.Height, compatibleDc, 0, 0, 13369376);
                hdc2.ObjectSelect(hbitmap);
                compatibleDc.DeviceContextDelete();
                hbitmap.ObjectDelete();
                graphics1.ReleaseHdc(hdc1);
                graphics1.Flush(FlushIntention.Sync);
            }
            switch (this.Alignment)
            {
                case TabAlignment.Left:
                    tabBaseBitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    break;
                case TabAlignment.Right:
                    tabBaseBitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;
            }
            Rectangle tabRect = this.GetTabRect(id);
            if (id == this.SelectedIndex && this.Appearance == TabAppearance.Normal)
                tabRect.Inflate(2, 2);
            if (this.DrawMode == TabDrawMode.OwnerDrawFixed)
            {
                bool flag = this.RightToLeft == RightToLeft.Yes && this.RightToLeftLayout;
                if (flag)
                    tabBaseBitmap.RotateFlip(RotateFlipType.RotateNoneFlipX);
                IntPtr hbitmap = tabBaseBitmap.GetHbitmap();
                using (Graphics graphics1 = Graphics.FromImage((Image)tabBaseBitmap))
                {
                    IntPtr hdc1 = graphics1.GetHdc();
                    IntPtr compatibleDc = hdc1.DeviceContextCreateCompatible();
                    IntPtr hdc2 = compatibleDc.ObjectSelect(hbitmap);
                    Graphics graphics2 = Graphics.FromHdc(compatibleDc);
                    graphics2.TranslateTransform((float)-tabRect.Left, (float)-tabRect.Top);
                    this.OnDrawItem(new DrawItemEventArgs(graphics2, this.Font, tabRect, id, DrawItemState.Default));
                    hdc1.BitBlock(0, 0, tabRect.Width, tabRect.Height, compatibleDc, 0, 0, 13369376);
                    graphics2.ResetTransform();
                    hdc2.ObjectSelect(hbitmap);
                    graphics2.Dispose();
                    compatibleDc.ObjectDelete();
                    graphics1.ReleaseHdc(hdc1);
                }
                hbitmap.ObjectDelete();
                if (flag)
                    tabBaseBitmap.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }
            graphics.DrawImage((Image)tabBaseBitmap, tabRect);
            tabBaseBitmap.Dispose();
            if (this.Appearance == TabAppearance.FlatButtons)
            {
                using (Pen pen = new Pen(this.BackColor.Darken(25)))
                {
                    graphics.DrawLine(pen, tabRect.Right + 4, tabRect.Top, tabRect.Right + 4, tabRect.Bottom);
                    pen.Color = this.BackColor.Lighten(80);
                    graphics.DrawLine(pen, tabRect.Right + 5, tabRect.Top, tabRect.Right + 5, tabRect.Bottom);
                }
            }
            tabRect.Inflate(-2, -2);
            if (this.Focused && this.ShowFocusCues && id == this.SelectedIndex)
                ControlPaint.DrawFocusRectangle(graphics, tabRect);
            graphics.Flush(FlushIntention.Sync);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="g"></param>
        /// <param name="r"></param>
        /// <param name="id"></param>
        private void Paint3DTab(Graphics g, Rectangle r, int id)
        {
            if (id == -1)
                return;
            if (this.VisualStylesEnabled)
            {
                new VisualStyleRenderer(this.GetVisualStyleElement(id)).DrawBackground((IDeviceContext)g, r);
            }
            else
            {
                Color color1 = this.TabColor;
                if (this.SelectedIndex == id)
                    color1 = this.SelectedTabColor;
                Color color2 = color1.Lighten(40);
                Color color3 = color1.Lighten(80);
                Color color4 = color1.Darken(25);
                Color color5 = color1.Darken(40);
                if (color1.A != (byte)0)
                {
                    Rectangle rect = r;
                    rect.Inflate(-2, -2);
                    rect.Height += 2;
                    using (SolidBrush solidBrush = new SolidBrush(color1))
                        g.FillRectangle((Brush)solidBrush, rect);
                }
                using (Pen pen = new Pen(color3))
                {
                    switch (this.Alignment)
                    {
                        case TabAlignment.Top:
                        case TabAlignment.Left:
                            g.DrawLines(pen, new Point[4]
                            {
                new Point(r.Left, r.Bottom),
                new Point(r.Left, r.Top + 2),
                new Point(r.Left + 2, r.Top),
                new Point(r.Right - 3, r.Top)
                            });
                            pen.Color = color2;
                            g.DrawLines(pen, new Point[4]
                            {
                new Point(r.Left + 1, r.Bottom),
                new Point(r.Left + 1, r.Top + 2),
                new Point(r.Left + 2, r.Top + 1),
                new Point(r.Right - 3, r.Top + 1)
                            });
                            pen.Color = color4;
                            g.DrawLines(pen, new Point[2]
                            {
                new Point(r.Right - 2, r.Top + 1),
                new Point(r.Right - 2, r.Bottom)
                            });
                            pen.Color = color5;
                            g.DrawLines(pen, new Point[2]
                            {
                new Point(r.Right - 1, r.Top + 2),
                new Point(r.Right - 1, r.Bottom)
                            });
                            break;
                        case TabAlignment.Bottom:
                        case TabAlignment.Right:
                            g.DrawLines(pen, new Point[2]
                            {
                new Point(r.Left, r.Bottom),
                new Point(r.Left, r.Top + 2)
                            });
                            pen.Color = color2;
                            g.DrawLines(pen, new Point[2]
                            {
                new Point(r.Left + 1, r.Bottom),
                new Point(r.Left + 1, r.Top + 1)
                            });
                            pen.Color = color5;
                            g.DrawLines(pen, new Point[4]
                            {
                new Point(r.Left + 2, r.Top),
                new Point(r.Right - 3, r.Top),
                new Point(r.Right - 1, r.Top + 2),
                new Point(r.Right - 1, r.Bottom)
                            });
                            pen.Color = color4;
                            g.DrawLines(pen, new Point[4]
                            {
                new Point(r.Left + 2, r.Top + 1),
                new Point(r.Right - 3, r.Top + 1),
                new Point(r.Right - 2, r.Top + 2),
                new Point(r.Right - 2, r.Bottom)
                            });
                            break;
                    }
                }
            }
            g.Flush(FlushIntention.Sync);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="g"></param>
        /// <param name="r"></param>
        /// <param name="id"></param>
        private void PaintButtonTab(Graphics g, Rectangle r, int id)
        {
            Color color1 = this.TabColor;
            TabPage tabPage = this.TabPages[id];
            if (this.SelectedIndex == id)
                color1 = this.SelectedTabColor;
            bool flag = id == this.SelectedIndex || tabPage == this.TabWithFocus;
            Color color2 = flag ? color1.Darken(25) : color1.Lighten(40);
            Color color3 = flag ? color1.Darken(40) : color1.Lighten(80);
            Color color4 = flag ? color1.Lighten(40) : color1.Darken(25);
            Color color5 = flag ? color1.Lighten(80) : color1.Darken(40);
            using (SolidBrush solidBrush = new SolidBrush(color1))
                g.FillRectangle((Brush)solidBrush, r);
            using (Pen pen = new Pen(color3))
            {
                switch (this.Alignment)
                {
                    case TabAlignment.Top:
                    case TabAlignment.Left:
                        g.DrawLines(pen, new Point[3]
                        {
              new Point(r.Left, r.Bottom - 1),
              new Point(r.Left, r.Top),
              new Point(r.Right - 1, r.Top)
                        });
                        pen.Color = color5;
                        g.DrawLines(pen, new Point[3]
                        {
              new Point(r.Right - 1, r.Top),
              new Point(r.Right - 1, r.Bottom - 1),
              new Point(r.Left, r.Bottom - 1)
                        });
                        pen.Color = color2;
                        g.DrawLines(pen, new Point[3]
                        {
              new Point(r.Left + 1, r.Bottom - 2),
              new Point(r.Left + 1, r.Top + 1),
              new Point(r.Right - 2, r.Top + 1)
                        });
                        pen.Color = color4;
                        g.DrawLines(pen, new Point[3]
                        {
              new Point(r.Right - 2, r.Top + 1),
              new Point(r.Right - 2, r.Bottom - 2),
              new Point(r.Left + 1, r.Bottom - 2)
                        });
                        break;
                    case TabAlignment.Bottom:
                    case TabAlignment.Right:
                        g.DrawLines(pen, new Point[3]
                        {
              new Point(r.Left, r.Top),
              new Point(r.Left, r.Bottom - 1),
              new Point(r.Right - 1, r.Bottom - 1)
                        });
                        pen.Color = color5;
                        g.DrawLines(pen, new Point[3]
                        {
              new Point(r.Right - 1, r.Bottom - 1),
              new Point(r.Right - 1, r.Top),
              new Point(r.Left, r.Top)
                        });
                        pen.Color = color2;
                        g.DrawLines(pen, new Point[3]
                        {
              new Point(r.Left + 1, r.Top + 1),
              new Point(r.Left + 1, r.Bottom - 2),
              new Point(r.Right - 2, r.Bottom - 2)
                        });
                        pen.Color = color4;
                        g.DrawLines(pen, new Point[3]
                        {
              new Point(r.Right - 2, r.Bottom - 2),
              new Point(r.Right - 2, r.Top + 1),
              new Point(r.Left + 1, r.Top + 1)
                        });
                        break;
                }
            }
            g.Flush(FlushIntention.Sync);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="g"></param>
        /// <param name="r"></param>
        /// <param name="id"></param>
        private void PaintFlatTab(Graphics g, Rectangle r, int id)
        {
            Color color1 = this.TabColor;
            TabPage tabPage = this.TabPages[id];
            if (this.SelectedIndex == id)
                color1 = this.SelectedTabColor;
            bool flag = id == this.SelectedIndex;
            Color color2 = flag ? color1.Darken(25) : color1.Lighten(40);
            Color color3 = flag ? color1.Darken(40) : color1.Lighten(80);
            Color color4 = flag ? color1.Lighten(40) : color1.Darken(25);
            Color color5 = flag ? color1.Lighten(80) : color1.Darken(25);
            using (SolidBrush solidBrush = new SolidBrush(color1))
                g.FillRectangle((Brush)solidBrush, r);
            if (tabPage == this.TabWithFocus || id == this.SelectedIndex || id == this.HotTabID && this.HotTrack)
            {
                using (Pen pen = new Pen(color3))
                {
                    switch (this.Alignment)
                    {
                        case TabAlignment.Top:
                        case TabAlignment.Left:
                            g.DrawLines(pen, new Point[3]
                            {
                new Point(r.Left, r.Bottom - 1),
                new Point(r.Left, r.Top),
                new Point(r.Right - 1, r.Top)
                            });
                            pen.Color = color5;
                            g.DrawLines(pen, new Point[3]
                            {
                new Point(r.Right - 1, r.Top),
                new Point(r.Right - 1, r.Bottom - 1),
                new Point(r.Left, r.Bottom - 1)
                            });
                            if (flag)
                            {
                                pen.Color = color2;
                                g.DrawLines(pen, new Point[3]
                                {
                  new Point(r.Left + 1, r.Bottom - 2),
                  new Point(r.Left + 1, r.Top + 1),
                  new Point(r.Right - 2, r.Top + 1)
                                });
                                pen.Color = color4;
                                g.DrawLines(pen, new Point[3]
                                {
                  new Point(r.Right - 2, r.Top + 1),
                  new Point(r.Right - 2, r.Bottom - 2),
                  new Point(r.Left + 1, r.Bottom - 2)
                                });
                                break;
                            }
                            break;
                        case TabAlignment.Bottom:
                        case TabAlignment.Right:
                            g.DrawLines(pen, new Point[3]
                            {
                new Point(r.Left, r.Top),
                new Point(r.Left, r.Bottom - 1),
                new Point(r.Right - 1, r.Bottom - 1)
                            });
                            pen.Color = color5;
                            g.DrawLines(pen, new Point[3]
                            {
                new Point(r.Right - 1, r.Bottom - 1),
                new Point(r.Right - 1, r.Top),
                new Point(r.Left, r.Top)
                            });
                            if (flag)
                            {
                                pen.Color = color2;
                                g.DrawLines(pen, new Point[3]
                                {
                  new Point(r.Left + 1, r.Top + 1),
                  new Point(r.Left + 1, r.Bottom - 2),
                  new Point(r.Right - 2, r.Bottom - 2)
                                });
                                pen.Color = color4;
                                g.DrawLines(pen, new Point[3]
                                {
                  new Point(r.Right - 2, r.Bottom - 2),
                  new Point(r.Right - 2, r.Top + 1),
                  new Point(r.Left + 1, r.Top + 1)
                                });
                                break;
                            }
                            break;
                    }
                }
            }
            g.Flush(FlushIntention.Sync);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="graphics"></param>
        private void DrawBorder(Graphics graphics)
        {
            if (this.Appearance == TabAppearance.Normal)
            {
                Rectangle displayRectangle1 = this.DisplayRectangle;
                displayRectangle1.Inflate(4, 4);
                switch (this.Alignment)
                {
                    case TabAlignment.Top:
                        ++displayRectangle1.Y;
                        --displayRectangle1.Height;
                        break;
                    case TabAlignment.Bottom:
                        ++displayRectangle1.Height;
                        break;
                    case TabAlignment.Left:
                        ++displayRectangle1.X;
                        --displayRectangle1.Width;
                        break;
                    case TabAlignment.Right:
                        ++displayRectangle1.Width;
                        break;
                }
                if (this.VisualStylesEnabled)
                {
                    new VisualStyleRenderer(VisualStyleElement.Tab.Pane.Normal).DrawBackground((IDeviceContext)graphics, displayRectangle1);
                }
                else
                {
                    Rectangle rect = Rectangle.Empty;
                    if (this.SelectedIndex != -1)
                    {
                        rect = this.GetTabRect(this.SelectedIndex);
                        rect.Inflate(2, 2);
                    }
                    graphics.SetClip(rect, CombineMode.Exclude);
                    Rectangle displayRectangle2 = this.DisplayRectangle;
                    displayRectangle2.Inflate(4, 4);
                    if (this.Alignment <= TabAlignment.Bottom)
                    {
                        --displayRectangle2.Height;
                        if (this.Alignment == TabAlignment.Top)
                            ++displayRectangle2.Y;
                    }
                    else
                    {
                        --displayRectangle2.Width;
                        if (this.Alignment == TabAlignment.Left)
                            ++displayRectangle2.X;
                    }
                    Color color1 = this.SelectedIndex == -1 ? this.BackColor : (this.SelectedTab.UseVisualStyleBackColor ? Control.DefaultBackColor : this.SelectedTab.BackColor);
                    using (SolidBrush solidBrush = new SolidBrush(color1))
                        graphics.FillRectangle((Brush)solidBrush, displayRectangle2);
                    Color color2 = color1.Lighten(40);
                    Color color3 = color1.Lighten(80);
                    Color color4 = color1.Darken(25);
                    Color color5 = color1.Darken(40);
                    using (Pen pen = new Pen(color3))
                    {
                        graphics.DrawLines(pen, new Point[3]
                        {
              new Point(displayRectangle2.Left, displayRectangle2.Bottom - 2),
              new Point(displayRectangle2.Left, displayRectangle2.Top),
              new Point(displayRectangle2.Right - 2, displayRectangle2.Top)
                        });
                        pen.Color = color2;
                        graphics.DrawLines(pen, new Point[3]
                        {
              new Point(displayRectangle2.Left + 1, displayRectangle2.Bottom - 3),
              new Point(displayRectangle2.Left + 1, displayRectangle2.Top + 1),
              new Point(displayRectangle2.Right - 3, displayRectangle2.Top + 1)
                        });
                        pen.Color = color5;
                        graphics.DrawLines(pen, new Point[3]
                        {
              new Point(displayRectangle2.Right - 1, displayRectangle2.Top),
              new Point(displayRectangle2.Right - 1, displayRectangle2.Bottom - 1),
              new Point(displayRectangle2.Left, displayRectangle2.Bottom - 1)
                        });
                        pen.Color = color4;
                        graphics.DrawLines(pen, new Point[3]
                        {
              new Point(displayRectangle2.Right - 2, displayRectangle2.Top + 1),
              new Point(displayRectangle2.Right - 2, displayRectangle2.Bottom - 2),
              new Point(displayRectangle2.Left + 1, displayRectangle2.Bottom - 2)
                        });
                    }
                    graphics.ResetClip();
                }
            }
            graphics.Flush(FlushIntention.Sync);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private VisualStyleElement GetVisualStyleElement(int id)
        {
            bool flag1 = this.Alignment >= TabAlignment.Left;
            Rectangle tabRect = this.GetTabRect(id);
            bool flag2 = flag1 ? tabRect.Top <= 3 : tabRect.Left <= 3;
            bool flag3 = flag1 ? tabRect.Bottom >= this.Height - 4 : tabRect.Right >= this.Width - 4;
            bool flag4 = flag1 ? (this.Alignment == TabAlignment.Left ? tabRect.Left <= 3 : tabRect.Right >= this.Width - 3) : tabRect.Top <= 3;
            int part = 1;
            TabItemState tabItemState = TabItemState.Normal;
            if (flag2)
                ++part;
            if (flag3)
                part += 2;
            if (flag4)
                part += 4;
            if (id == this.SelectedIndex)
                tabItemState = TabItemState.Selected;
            else if (this.TabPages[id].Enabled)
            {
                if (this.TabPages[id] == this.TabUnderMouse && this.HotTrack && !this.DesignMode)
                    tabItemState = TabItemState.Hot;
            }
            else
                tabItemState = TabItemState.Disabled;
            return VisualStyleElement.CreateElement("TAB", part, (int)tabItemState);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private Bitmap CreateTabBaseBitmap(int id)
        {
            Rectangle tabRect = this.GetTabRect(id);
            if (this.Appearance == TabAppearance.Normal && id == this.SelectedIndex)
                tabRect.Inflate(2, 2);
            Bitmap bitmap1 = new Bitmap(tabRect.Width, tabRect.Height, PixelFormat.Format32bppPArgb);
            using (Graphics graphics = Graphics.FromImage((Image)bitmap1))
            {
                GraphicsContainer container = graphics.BeginContainer();
                if (this.TabIsPartiallyTransparent(id) && (this.BackColor.A < byte.MaxValue || !this.UseBackColorBehindTabs))
                {
                    if (this.BufferImage == null)
                        this.DrawBufferImage();
                    if (this.BufferImage != null)
                        graphics.DrawImage((Image)this.BufferImage, 0, 0, tabRect, GraphicsUnit.Pixel);
                }
                else
                    graphics.Clear(this.BackColor);
                graphics.EndContainer(container);
                graphics.Flush(FlushIntention.Sync);
            }
            switch (this.Alignment)
            {
                case TabAlignment.Bottom:
                    bitmap1.RotateFlip(RotateFlipType.Rotate180FlipX);
                    break;
                case TabAlignment.Left:
                    bitmap1.RotateFlip(RotateFlipType.Rotate90FlipX);
                    break;
                case TabAlignment.Right:
                    bitmap1.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    break;
            }
            Bitmap bitmap2 = new Bitmap((Image)bitmap1);
            using (Graphics g = Graphics.FromImage((Image)bitmap2))
            {
                GraphicsContainer container = g.BeginContainer();
                switch (this.Appearance)
                {
                    case TabAppearance.Buttons:
                        this.PaintButtonTab(g, new Rectangle(Point.Empty, bitmap2.Size), id);
                        break;
                    case TabAppearance.FlatButtons:
                        this.PaintFlatTab(g, new Rectangle(Point.Empty, bitmap2.Size), id);
                        break;
                    default:
                        this.Paint3DTab(g, new Rectangle(Point.Empty, bitmap2.Size), id);
                        break;
                }
                g.EndContainer(container);
                g.Flush(FlushIntention.Sync);
            }
            if (this.Alignment == TabAlignment.Bottom)
                bitmap2.RotateFlip(RotateFlipType.Rotate180FlipX);
            else if (this.Alignment == TabAlignment.Left)
                bitmap2.RotateFlip(RotateFlipType.RotateNoneFlipX);
            if (this.RightToLeftLayout && this.RightToLeft == RightToLeft.Yes && this.DrawMode == TabDrawMode.Normal)
                bitmap2.RotateFlip(RotateFlipType.RotateNoneFlipX);
            return bitmap2;
        }
        /// <summary>
        /// 
        /// </summary>
        private void DrawBufferImage()
        {
            if (this.Parent == null || !this.Created || (this.Width <= 0 || this.Height <= 0))
                return;
            if (this.BufferImage == null || !this.BufferImage.Size.Equals((object)this.Size))
                this.BufferImage = new Bitmap(this.Width, this.Height, PixelFormat.Format32bppPArgb);
            using (Graphics graphics = Graphics.FromImage((Image)this.BufferImage))
            {
                GraphicsContainer container = graphics.BeginContainer();
                Rectangle bounds = this.Bounds;
                graphics.TranslateTransform((float)-this.Left, (float)-this.Top);
                PaintEventArgs e = new PaintEventArgs(graphics, bounds);
                this.InvokePaintBackground(this.Parent, e);
                this.InvokePaint(this.Parent, e);
                graphics.ResetTransform();
                graphics.EndContainer(container);
                graphics.Flush(FlushIntention.Sync);
            }
            if (this.RightToLeft != RightToLeft.Yes || !this.RightToLeftLayout)
                return;
            this.BufferImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private TabPage GetFirstEnabledTab()
        {
            if (this.TabCount > 0)
            {
                for (int index = 0; index < this.TabCount; ++index)
                {
                    TabPage tabPage = this.TabPages[index];
                    if (tabPage.Enabled)
                        return tabPage;
                }
            }
            return (TabPage)null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private TabPage GetLastEnabledTab()
        {
            if (this.TabCount > 0)
            {
                for (int index = this.TabCount - 1; index >= 0; --index)
                {
                    TabPage tabPage = this.TabPages[index];
                    if (tabPage.Enabled)
                        return tabPage;
                }
            }
            return (TabPage)null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="forward"></param>
        /// <param name="wrap"></param>
        /// <returns></returns>
        private TabPage GetNextEnabledTab(bool forward, bool wrap)
        {
            if (forward)
            {
                for (int index = this.SelectedIndex + 1; index <= this.TabCount - 1; ++index)
                {
                    if (this.TabPages[index].Enabled)
                        return this.TabPages[index];
                }
                if (wrap)
                {
                    for (int index = 0; index <= this.SelectedIndex; ++index)
                    {
                        if (this.TabPages[index].Enabled)
                            return this.TabPages[index];
                    }
                }
            }
            else
            {
                for (int index = this.SelectedIndex - 1; index >= 0; --index)
                {
                    if (this.TabPages[index].Enabled)
                        return this.TabPages[index];
                }
                if (wrap)
                {
                    for (int index = this.TabCount - 1; index > this.SelectedIndex; --index)
                    {
                        if (this.TabPages[index].Enabled)
                            return this.TabPages[index];
                    }
                }
            }
            return (TabPage)null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        private TabPage TabFromPoint(Point point)
        {
            Flags_TabControl.TCHITTESTINFO lParam = new Flags_TabControl.TCHITTESTINFO(point.X, point.Y);
            int int32 = this.Handle.MessageSend(4877, IntPtr.Zero, ref lParam).ToInt32();
            return int32 >= 0 && int32 < this.TabCount ? this.TabPages[int32] : (TabPage)null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool TabIsPartiallyTransparent(int id)
        {
            if (this.VisualStylesEnabled)
                return new VisualStyleRenderer(this.GetVisualStyleElement(id)).IsBackgroundPartiallyTransparent();
            if (this.Appearance == TabAppearance.Normal)
                return true;
            return id == this.SelectedIndex ? this.SelectedTabColor.A < byte.MaxValue : this.TabColor.A < byte.MaxValue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hdc"></param>
        /// <param name="text"></param>
        /// <param name="font"></param>
        /// <param name="textColor"></param>
        /// <param name="bounds"></param>
        /// <param name="flags"></param>
        private static void GdiDrawStateText(
          IntPtr hdc,
          string text,
          Font font,
          Color textColor,
          Rectangle bounds,
          int flags)
        {
            IntPtr hfont = font.ToHfont();
            IntPtr hgdiobj = hdc.ObjectSelect(hfont);
            int nBkMode = hdc.BackgroundModeSet(1);
            int crColor = hdc.TextColorSet(ColorTranslator.ToWin32(textColor));
            hdc.StateDraw(IntPtr.Zero, IntPtr.Zero, Marshal.StringToHGlobalAuto(text), new IntPtr(text.Length), bounds.Left, bounds.Top, bounds.Width, bounds.Height, flags);
            hdc.TextColorSet(crColor);
            hdc.BackgroundModeSet(nBkMode);
            hdc.ObjectSelect(hgdiobj);
            hfont.ObjectDelete();
        }

        private void SetDoubleBuffered(TabPage page)
        {
            PropertyInfo property = page.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            if (property == (PropertyInfo)null)
                return;
            property.SetValue((object)page, (object)this.myDoubleBufferTabpages, (object[])null);
        }

        private bool HandleArrowKeys(Keys keys)
        {
            if (this.Appearance == TabAppearance.Normal)
            {
                if (this.SelectedIndex == -1)
                {
                    this.SelectedTab = this.GetFirstEnabledTab();
                    return true;
                }
                Rectangle tabRect = this.GetTabRect(this.SelectedIndex);
                bool flag = this.Alignment >= TabAlignment.Left;
                if (this.RightToLeft == RightToLeft.Yes && this.RightToLeftLayout)
                {
                    if (keys == Keys.Left)
                        keys = Keys.Right;
                    else if (keys == Keys.Right)
                        keys = Keys.Left;
                }
                Point point;
                Point p;
                switch (keys - 37)
                {
                    case Keys.None:
                        if (!flag)
                        {
                            TabPage nextEnabledTab = this.GetNextEnabledTab(false, false);
                            if (nextEnabledTab != null)
                                this.SelectedTab = nextEnabledTab;
                            return true;
                        }
                        point = new Point(tabRect.Left - 3, tabRect.Top + tabRect.Height / 2);
                        p = flag ? new Point(0, -3) : Point.Empty;
                        break;
                    case Keys.LButton:
                        if (flag)
                        {
                            TabPage nextEnabledTab = this.GetNextEnabledTab(false, false);
                            if (nextEnabledTab != null)
                                this.SelectedTab = nextEnabledTab;
                            return true;
                        }
                        point = new Point(tabRect.Left + tabRect.Width / 2, tabRect.Top - 3);
                        p = flag ? Point.Empty : new Point(-3, 0);
                        break;
                    case Keys.RButton:
                        if (!flag)
                        {
                            TabPage nextEnabledTab = this.GetNextEnabledTab(true, false);
                            if (nextEnabledTab != null)
                                this.SelectedTab = nextEnabledTab;
                            return true;
                        }
                        point = new Point(tabRect.Right + 3, tabRect.Top + tabRect.Height / 2);
                        p = flag ? new Point(0, -3) : Point.Empty;
                        break;
                    case Keys.Cancel:
                        if (flag)
                        {
                            TabPage nextEnabledTab = this.GetNextEnabledTab(true, false);
                            if (nextEnabledTab != null)
                                this.SelectedTab = nextEnabledTab;
                            return true;
                        }
                        point = new Point(tabRect.Left + tabRect.Width / 2, tabRect.Bottom + 3);
                        p = flag ? Point.Empty : new Point(-3, 0);
                        break;
                    default:
                        return false;
                }
                while (this.ClientRectangle.Contains(point) && !this.DisplayRectangle.Contains(point))
                {
                    TabPage tabPage = this.TabFromPoint(point);
                    if (tabPage != null && tabPage.Enabled)
                    {
                        this.SelectedTab = tabPage;
                        return true;
                    }
                    if (p.IsEmpty)
                        return true;
                    point.Offset(p);
                }
            }
            return true;
        }
    }
}
#endif