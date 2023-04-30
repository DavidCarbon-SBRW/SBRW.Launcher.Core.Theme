#if NETFRAMEWORK || NET6_0_OR_GREATER && WINDOWS
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
    /// <remarks><see href="https://stackoverflow.com/questions/778678/how-to-change-the-color-of-progressbar-in-c-sharp-net-3-5">
    /// Based on the Following Concepts (Thanks to Those who Explored this Function)</see></remarks>
    [ToolboxBitmap(typeof(ProgressBar))]
    public class Control_ProgressBar : ProgressBar
    {
        /// <summary>
        /// Draws a Default Background (Border) progress bar control that fills in horizontally.
        /// </summary>
        [Category("Appearance"), Description("Draws a Default Background (Border) progress bar control that fills in horizontally.")]
        [Browsable(true)]
        public bool DrawHorizontalBarDefault { get; set; }
        /// <summary>
        /// Draws a Custom Colored Background (Border) progress bar control that fills in horizontally.
        /// </summary>
        [Category("Appearance"), Description("Draws a Custom Colored Background (Border) progress bar control that fills in horizontally.")]
        [Browsable(true)]
        public bool DrawHorizontalBarCustomColor { get; set; }
        /// <summary>
        /// A single inset value to control the sizing of the Inner Rectangle.
        /// </summary>
        [Category("Appearance"), Description("A single inset value to control the sizing of the Inner Rectangle.")]
        [Browsable(true)]
        public int InnerRectangle { get; set; } = 2;
        /// <summary>
        /// Specifies the direction of a linear gradient of the Inner Rectangle.
        /// </summary>
        [Category("Appearance"), Description("Specifies the direction of a linear gradient of the Inner Rectangle.")]
        [Browsable(true)]
        public LinearGradientMode InnerRectangleLinearGradient { get; set; } = LinearGradientMode.Vertical;
        /// <summary>
        /// Gets or sets the background color for the ProgressBar.
        /// </summary>
        /// <returns>A <see cref="Color"/> that represents the background color of the ProgressBar.
        /// The default <see cref="Color"/> is <see cref="Color.WhiteSmoke">WhiteSmoke</see></returns>
        [Category("Appearance"), Description("Specifies the background color for the ProgressBar.")]
        [Browsable(true)]
        public Color OuterRectangleBackColor { get; set; } = Color.WhiteSmoke;
        /// <summary>
        /// Gets or sets an ID that provides additional data about the ProgressBar.
        /// </summary>
        /// <returns>ID about the ProgressBar</returns>
        [Category("Data"), Description("Specifies the ID for the ProgressBar.")]
        [Browsable(true)]
        public int ID { get; set; }
        /// <summary>
        /// Vanilla Progressbar, but allows custom colors
        /// </summary>
        public Control_ProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
            base.TabStop = false;
            this.UpdateStyles();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pevent"></param>
        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            /* None... Helps control the flicker. */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Live_Control"></param>
        protected override void OnPaint(PaintEventArgs Live_Control)
        {
            using (Image offscreenImage = new Bitmap(this.Width, this.Height))
            {
                using (Graphics offscreen = Graphics.FromImage(offscreenImage))
                {
                    /* */
                    Rectangle Inner_Rectangle = new Rectangle(0, 0, this.Width, this.Height);
                    /* */
                    if (ProgressBarRenderer.IsSupported && DrawHorizontalBarDefault)
                    {
                        ProgressBarRenderer.DrawHorizontalBar(offscreen, Inner_Rectangle);
                    }
                    else if (DrawHorizontalBarDefault)
                    {
                        /* So the Programmer wants the Default ProgressBar Background but is not supported */
                        DrawHorizontalBarCustomColor = true;
                        /* Lets use a near-Default Color as a substitute */
                        OuterRectangleBackColor = Color.WhiteSmoke;
                    }
                    /* */
                    if (DrawHorizontalBarCustomColor)
                    {
                        /* Draw the Background (Outer) Rectangle */
                        Rectangle Outer_Rectangle = new Rectangle(0, 0, this.Width, this.Height);
                        /* */
                        Brush Outer_Rectangle_Background_Brush = new SolidBrush(OuterRectangleBackColor);
                        /* */
                        offscreen.FillRectangle(Outer_Rectangle_Background_Brush, Outer_Rectangle);
                    }
                    /* If Inner Rectangle Size is Less than Zero just set it to 0 */
                    if (InnerRectangle < 0)
                    {
                        InnerRectangle = 0;
                    }
                    /* */
                    double Scale_Factor = (((double)Value - (double)Minimum) / ((double)Maximum - (double)Minimum));
                    /* Deflate Inner Rectangle so its Visually Smaller */
                    Inner_Rectangle.Inflate(new Size(-InnerRectangle, -InnerRectangle));
                    /* */
                    Inner_Rectangle.Width = (int)(Inner_Rectangle.Width * Scale_Factor);
                    /* Can't draw Rectangle with width of 0. */
                    if (Inner_Rectangle.Width == 0)
                    {
                        Inner_Rectangle.Width = 1;
                    }
                    /* */
                    LinearGradientBrush Inner_Brush = new LinearGradientBrush(Inner_Rectangle, this.BackColor, this.ForeColor, InnerRectangleLinearGradient);
                    /* */
                    offscreen.FillRectangle(Inner_Brush, InnerRectangle, InnerRectangle, Inner_Rectangle.Width, Inner_Rectangle.Height);
                    /* */
                    Live_Control.Graphics.DrawImage(offscreenImage, 0, 0);
                }
            }
        }
    }
}
#endif