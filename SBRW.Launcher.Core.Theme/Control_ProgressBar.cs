#if NETFRAMEWORK || NET6_0_OR_GREATER && WINDOWS
using System;
using System.ComponentModel;
//If you are using this code to build a Class Library Project instead of just adding it to a Form Project then you
//will need to add a reference to System.Drawing and System.Windows.Forms for the next three Imports. You can do
//that after you create the new Class Library by going to the VB menu and clicking (Project) and then selecting (Add Reference...).
//Then on the (.Net) tab you can find and select (System.Drawing) and (System.Windows.Forms) to add the references.
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SBRW.Launcher.Core.Theme
{
    /// <summary>
    /// 
    /// </summary>
    [ToolboxBitmap("PBEX.bmp")]
    public class Control_ProgressBar : Control
    {
        /// <summary>
        /// 
        /// </summary>
        public Blend BBlend { get; set; } = new Blend();
        private int Minimum_ { get; set; } = 0;
        private int Maximum_ { get; set; } = 100;
        private int Value_ { get; set; } = 0;
        private bool Border_ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Pen Border_Pen { get; set; }
        private Color Border_Color { get; set; } = Color.Black;
        private GradiantArea GradiantPosition_ { get; set; }
        private Color GradiantColor_ { get; set; } = Color.White;
        private Color BackColor_ { get; set; } = Color.DarkGray;
        private Color ProgressColor_ { get; set; } = Color.Lime;
        /// <summary>
        /// 
        /// </summary>
        public SolidBrush ForeColorBrush_ { get; set; }
        private bool ShowPercentage_ { get; set; }
        private bool ShowText_ { get; set; }
        private ImageLayoutType ImageLayout_ { get; set; } = ImageLayoutType.None;
        private Bitmap Image_ { get; set; }
        private bool RoundedCorners_ { get; set; } = true;
        private ProgressDir ProgressDirection_ { get; set; } = ProgressDir.Horizontal;
        /// <summary>Enum of positions used for the ProgressBar`s GradiantPosition property.</summary>
        public enum GradiantArea : int
        {
            /// <summary>
            /// 
            /// </summary>
            None = 0,
            /// <summary>
            /// 
            /// </summary>
            Top = 1,
            /// <summary>
            /// 
            /// </summary>
            Center = 2,
            /// <summary>
            /// 
            /// </summary>
            Bottom = 3
        }
        /// <summary>Enum of ImageLayout types used for the ProgressBar`s ImageLayout property.</summary>
        public enum ImageLayoutType : int
        {
            /// <summary>
            /// 
            /// </summary>
            None = 0,
            /// <summary>
            /// 
            /// </summary>
            Center = 1,
            /// <summary>
            /// 
            /// </summary>
            Stretch = 2
        }
        /// <summary>Enum of Progress Direction types used for the ProgressDirection property.</summary>
        public enum ProgressDir : int
        {
            /// <summary>
            /// 
            /// </summary>
            Horizontal = 0,
            /// <summary>
            /// 
            /// </summary>
            Vertical = 1
        }
        /// <summary>
        /// 
        /// </summary>
        public Control_ProgressBar()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
            base.TabStop = false;
            this.Size = new Size(200, 23);
            BBlend.Positions = new float[] { 0f, 0.2f, 0.4f, 0.6f, 0.8f, 1f };
            this.GradiantPosition = GradiantArea.Top;
            base.BackColor = Color.Transparent;
            ForeColorBrush_ = new SolidBrush(base.ForeColor);
            Border_Pen = new Pen(Color.Black);
        }
        /// <summary>
        /// The foreground color of the ProgressBars text.
        /// </summary>
        [Category("Appearance"), Description("The foreground color of the ProgressBars text.")]
        [Browsable(true)]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                if (value == Color.Transparent)
                {
                    value = ForeColorBrush_.Color;
                }
                base.ForeColor = value;
                ForeColorBrush_.Color = value;
            }
        }
        /// <summary>
        /// The background color of the ProgressBar.
        /// </summary>
        [Category("Appearance"), Description("The background color of the ProgressBar.")]
        [Browsable(true)]
        [DefaultValue(typeof(Color), "DarkGray")]
        public Color BackgroundColor
        {
            get { return BackColor_; }
            set
            {
                if (value == Color.Transparent)
                {
                    value = BackColor_;
                }
                BackColor_ = value;
                this.Refresh();
            }
        }
        /// <summary>
        /// The progress color of the ProgressBar.
        /// </summary>
        [Category("Appearance"), Description("The progress color of the ProgressBar.")]
        [Browsable(true)]
        [DefaultValue(typeof(Color), "Lime")]
        public Color ProgressColor
        {
            get { return ProgressColor_; }
            set
            {
                if (value == Color.Transparent)
                {
                    value = ProgressColor_;
                }
                ProgressColor_ = value;
                this.Refresh();
            }
        }
        /// <summary>
        /// The gradiant highlight color of the ProgressBar.
        /// </summary>
        [Category("Appearance"), Description("The gradiant highlight color of the ProgressBar.")]
        [Browsable(true)]
        [DefaultValue(typeof(Color), "White")]
        public Color GradiantColor
        {
            get { return GradiantColor_; }
            set
            {
                GradiantColor_ = value;
                this.Refresh();
            }
        }
        /// <summary>
        /// The minimum value of the ProgressBar.
        /// </summary>
        [Category("Behavior"), Description("The minimum value of the ProgressBar.")]
        [Browsable(true)]
        [DefaultValue(0)]
        public int Minimum
        {
            get { return Minimum_; }
            set
            {
                if (value > Maximum_)
                {
                    value = Maximum_ - 1;
                }
                Minimum_ = value;
                this.Refresh();
            }
        }
        /// <summary>
        /// The maximum value of the ProgressBar.
        /// </summary>
        [Category("Behavior"), Description("The maximum value of the ProgressBar.")]
        [Browsable(true)]
        [DefaultValue(100)]
        public int Maximum
        {
            get { return Maximum_; }
            set
            {
                if (value <= Minimum_)
                {
                    value = Minimum_ + 1;
                }
                Maximum_ = value;
                this.Refresh();
            }
        }
        /// <summary>
        /// The current value of the ProgressBar.
        /// </summary>
        [Category("Behavior"), Description("The current value of the ProgressBar.")]
        [Browsable(true)]
        [DefaultValue(0)]
        public int Value
        {
            get { return Value_; }
            set
            {
                if (value < Minimum_)
                {
                    value = Minimum_;
                }
                if (value > Maximum_)
                {
                    value = Maximum_;
                }
                Value_ = value;
                this.Refresh();
            }
        }
        /// <summary>
        /// Draw a border around the ProgressBar.
        /// </summary>
        [Category("Appearance"), Description("Draw a border around the ProgressBar.")]
        [Browsable(true)]
        [DefaultValue(true)]
        public bool Border
        {
            get { return Border_; }
            set
            {
                Border_ = value;
                this.Refresh();
            }
        }
        /// <summary>
        /// The color of the border around the ProgressBar.
        /// </summary>
        [Category("Appearance"), Description("The color of the border around the ProgressBar.")]
        [Browsable(true)]
        [DefaultValue(typeof(Color), "Black")]
        public Color BorderColor
        {
            get { return Border_Color; }
            set
            {
                if (value == Color.Transparent)
                {
                    value = Border_Color;
                }
                Border_Color = value;
                Border_Pen.Color = value;
                this.Refresh();
            }
        }
        /// <summary>
        /// Shows the progress percentge as text in the ProgressBar.
        /// </summary>
        [Category("Appearance"), Description("Shows the progress percentge as text in the ProgressBar.")]
        [Browsable(true)]
        [DefaultValue(false)]
        public bool ShowPercentage
        {
            get { return ShowPercentage_; }
            set
            {
                ShowPercentage_ = value;
                this.Refresh();
            }
        }
        /// <summary>
        /// Shows the text of the Text property in the ProgressBar.
        /// </summary>
        [Category("Appearance"), Description("Shows the text of the Text property in the ProgressBar.")]
        [Browsable(true)]
        [DefaultValue(false)]
        public bool ShowText
        {
            get { return ShowText_; }
            set
            {
                ShowText_ = value;
                this.Refresh();
            }
        }
        /// <summary>
        /// Determins the position of the gradiant shine in the ProgressBar.
        /// </summary>
        [Category("Appearance"), Description("Determins the position of the gradiant shine in the ProgressBar.")]
        [Browsable(true)]
        [DefaultValue(typeof(GradiantArea), "Top")]
        public GradiantArea GradiantPosition
        {
            get { return GradiantPosition_; }
            set
            {
                GradiantPosition_ = value;
                if (value == GradiantArea.None)
                {
                    BBlend.Factors = new float[] { 0f, 0f, 0f, 0f, 0f, 0f }; /* Shine None */
                }
                else if (value == GradiantArea.Top)
                {
                    BBlend.Factors = new float[] { 0.8f, 0.7f, 0.6f, 0.4f, 0f, 0f }; /* Shine Top */
                }
                else if (value == GradiantArea.Center)
                {
                    BBlend.Factors = new float[] { 0f, 0.4f, 0.6f, 0.6f, 0.4f, 0f }; /* Shine Center */
                }
                else
                {
                    BBlend.Factors = new float[] { 0f, 0f, 0.4f, 0.6f, 0.7f, 0.8f }; /* Shine Bottom */
                }
                this.Refresh();
            }
        }
        /// <summary>
        /// An image to display on the ProgressBar.
        /// </summary>
        [Category("Appearance"), Description("An image to display on the ProgressBar.")]
        [Browsable(true)]
        public Bitmap Image
        {
            get { return Image_; }
            set
            {
                Image_ = value;
                this.Refresh();
            }
        }
        /// <summary>
        /// Determins how the image is displayed in the ProgressBar.
        /// </summary>
        [Category("Appearance"), Description("Determins how the image is displayed in the ProgressBar.")]
        [Browsable(true)]
        [DefaultValue(typeof(ImageLayoutType), "None")]
        public ImageLayoutType ImageLayout
        {
            get { return ImageLayout_; }
            set
            {
                ImageLayout_ = value;
                if (Image_ != null)
                    this.Refresh();
            }
        }
        /// <summary>
        /// True to draw corners rounded. False to draw square corners.
        /// </summary>
        [Category("Appearance"), Description("True to draw corners rounded. False to draw square corners.")]
        [Browsable(true)]
        [DefaultValue(true)]
        public bool RoundedCorners
        {
            get { return RoundedCorners_; }
            set
            {
                RoundedCorners_ = value;
                this.Refresh();
            }
        }
        /// <summary>
        /// Determins the direction of progress displayed in the ProgressBar.
        /// </summary>
        [Category("Appearance"), Description("Determins the direction of progress displayed in the ProgressBar.")]
        [Browsable(true)]
        [DefaultValue(typeof(ProgressDir), "Horizontal")]
        public ProgressDir ProgressDirection
        {
            get { return ProgressDirection_; }
            set
            {
                ProgressDirection_ = value;
                this.Refresh();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Point StartPoint = new Point(0, 0);
            Point EndPoint = new Point(0, this.Height);

            if (ProgressDirection_ == ProgressDir.Vertical)
            {
                EndPoint = new Point(this.Width, 0);
            }

            using (GraphicsPath gp = new GraphicsPath())
            {
                Rectangle rec = new Rectangle(0, 0, this.Width, this.Height);
                int rad = Convert.ToInt32(rec.Height / 2.5);
                if (rec.Width < rec.Height)
                {
                    rad = Convert.ToInt32(rec.Width / 2.5);
                }

                using (Brush BackColor_Brush = new SolidBrush(Color.FromArgb(0, 0, 0, 0)))
                {
                    if (RoundedCorners_)
                    {
                        gp.AddArc(rec.X, rec.Y, rad, rad, 180, 90);
                        gp.AddArc(rec.Right - (rad), rec.Y, rad, rad, 270, 90);
                        gp.AddArc(rec.Right - (rad), rec.Bottom - (rad), rad, rad, 0, 90);
                        gp.AddArc(rec.X, rec.Bottom - (rad), rad, rad, 90, 90);
                        gp.CloseFigure();
                        e.Graphics.FillPath(BackColor_Brush, gp);
                    }
                    else
                    {
                        e.Graphics.FillRectangle(BackColor_Brush, rec);
                    }
                }

                if (Value_ > Minimum_)
                {
                    int lngth = Convert.ToInt32((double)(this.Width / (double)(Maximum_ - Minimum_)) * Value_);
                    if (ProgressDirection_ == ProgressDir.Vertical)
                    {
                        lngth = Convert.ToInt32((double)(this.Height / (double)(Maximum_ - Minimum_)) * Value_);
                        rec.Y = rec.Height - lngth;
                        rec.Height = lngth;
                    }
                    else
                    {
                        rec.Width = lngth;
                    }

                    using (LinearGradientBrush _ProgressBrush = new LinearGradientBrush(StartPoint, EndPoint, ProgressColor_, GradiantColor_))
                    {
                        _ProgressBrush.Blend = BBlend;
                        if (RoundedCorners_)
                        {
                            if (ProgressDirection_ == ProgressDir.Horizontal)
                            {
                                rec.Height -= 1;
                            }
                            else
                            {
                                rec.Width -= 1;
                            }

                            using (GraphicsPath gp2 = new GraphicsPath())
                            {
                                gp2.AddArc(rec.X, rec.Y, rad, rad, 180, 90);
                                gp2.AddArc(rec.Right - (rad), rec.Y, rad, rad, 270, 90);
                                gp2.AddArc(rec.Right - (rad), rec.Bottom - (rad), rad, rad, 0, 90);
                                gp2.AddArc(rec.X, rec.Bottom - (rad), rad, rad, 90, 90);
                                gp2.CloseFigure();
                                using (GraphicsPath gp3 = new GraphicsPath())
                                {
                                    using (Region rgn = new Region(gp))
                                    {
                                        rgn.Intersect(gp2);
                                        gp3.AddRectangles(rgn.GetRegionScans(new Matrix()));
                                    }
                                    e.Graphics.FillPath(_ProgressBrush, gp3);
                                }
                            }
                        }
                        else
                        {
                            e.Graphics.FillRectangle(_ProgressBrush, rec);
                        }
                    }
                }

                if (Image_ != null)
                {
                    if (ImageLayout_ == ImageLayoutType.Stretch)
                    {
                        e.Graphics.DrawImage(Image_, 0, 0, this.Width, this.Height);
                    }
                    else if (ImageLayout_ == ImageLayoutType.None)
                    {
                        e.Graphics.DrawImage(Image_, 0, 0);
                    }
                    else
                    {
                        int xx = Convert.ToInt32((this.Width / 2) - (Image_.Width / 2));
                        int yy = Convert.ToInt32((this.Height / 2) - (Image_.Height / 2));
                        e.Graphics.DrawImage(Image_, xx, yy);
                    }
                }

                if (ShowPercentage_ | ShowText_)
                {
                    string perc = "";
                    if (ShowText_)
                    {
                        perc = this.Text;
                    }
                    if (ShowPercentage_)
                    {
                        perc += Convert.ToString(Convert.ToInt32(((double)100 / (double)(Maximum_ - Minimum_)) * Value_)) + "%";
                    }
                    using (StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                    {
                        e.Graphics.DrawString(perc, this.Font, ForeColorBrush_, new Rectangle(0, 0, this.Width, this.Height), sf);
                    }
                }

                if (Border_)
                {
                    rec = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
                    if (RoundedCorners_)
                    {
                        gp.Reset();
                        gp.AddArc(rec.X, rec.Y, rad, rad, 180, 90);
                        gp.AddArc(rec.Right - (rad), rec.Y, rad, rad, 270, 90);
                        gp.AddArc(rec.Right - (rad), rec.Bottom - (rad), rad, rad, 0, 90);
                        gp.AddArc(rec.X, rec.Bottom - (rad), rad, rad, 90, 90);
                        gp.CloseFigure();
                        e.Graphics.DrawPath(Border_Pen, gp);
                    }
                    else
                    {
                        e.Graphics.DrawRectangle(Border_Pen, rec);
                    }
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnTextChanged(System.EventArgs e)
        {
            this.Refresh();
            base.OnTextChanged(e);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            ForeColorBrush_.Dispose();
            Border_Pen.Dispose();
            base.Dispose(disposing);
        }
        /// <summary>
        /// 
        /// </summary>
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set { base.BackColor = Color.Transparent; }
        }
        /// <summary>
        /// 
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [System.Obsolete("BackgroundImageLayout is not implemented.", true)]
        public new ImageLayout BackgroundImageLayout
        {
            get { return base.BackgroundImageLayout; }
            set { throw new NotImplementedException("BackgroundImageLayout is not implemented."); }
        }
        /// <summary>
        /// 
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [System.Obsolete("BackgroundImage is not implemented.", true)]
        public new Image BackgroundImage
        {
            get { return null; }
            set { throw new NotImplementedException("BackgroundImage is not implemented."); }
        }
        /// <summary>
        /// 
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [System.Obsolete("TabStop is not implemented.", true)]
        public new bool TabStop
        {
            get { return false; }
            set { throw new NotImplementedException("TabStop is not implemented."); }
        }
        /// <summary>
        /// 
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [System.Obsolete("TabIndex is not implemented.", true)]
        public new int TabIndex
        {
            get { return base.TabIndex; }
            set { throw new NotImplementedException("TabIndex is not implemented."); }
        }
    }
}
#endif