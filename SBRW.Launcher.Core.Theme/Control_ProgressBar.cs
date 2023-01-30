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
    /// <remarks><see href="https://stackoverflow.com/questions/778678/how-to-change-the-color-of-progressbar-in-c-sharp-net-3-5">
    /// Based on the Following Concepts (Thanks to Those who Explored this Function)</see></remarks>
    [ToolboxBitmap(typeof(ProgressBar))]
    public class Control_ProgressBar : ProgressBar
    {
        /// <summary>
        /// Draws an empty (Border) progress bar control that fills in horizontally.
        /// </summary>
        [Category("Appearance"), Description("Draws an empty (Border) progress bar control that fills in horizontally.")]
        [Browsable(true)]
        public bool DrawHorizontalBar { get; set; }
        /// <summary>
        /// A single inset value to control the sizing of the inner Rectangle.
        /// </summary>
        [Category("Appearance"), Description("A single inset value to control the sizing of the inner Rectangle.")]
        [Browsable(true)]
        public int InnerRectangle { get; set; } = 2;
        /// <summary>
        /// Vanilla Progressbar, but allows custom colors
        /// </summary>
        public Control_ProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pevent"></param>
        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            // None... Helps control the flicker.
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
                    Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
                    double scaleFactor = (((double)Value - (double)Minimum) / ((double)Maximum - (double)Minimum));

                    if (ProgressBarRenderer.IsSupported && DrawHorizontalBar)
                    {
                        ProgressBarRenderer.DrawHorizontalBar(offscreen, rect);
                    }
                    // Deflate inner rect.
                    rect.Inflate(new Size(-InnerRectangle, -InnerRectangle));

                    if (Value == Maximum)
                    {
                        rect.Width = rect.Width * InnerRectangle;
                    }
                    else
                    {
                        rect.Width = (int)((rect.Width - 2 * InnerRectangle) * scaleFactor);
                    }

                    // Can't draw rec with width of 0.
                    if (rect.Width == 0)
                    {
                        rect.Width = 1;
                    }

                    LinearGradientBrush brush = new LinearGradientBrush(rect, this.BackColor, this.ForeColor, LinearGradientMode.Vertical);
                    offscreen.FillRectangle(brush, InnerRectangle, InnerRectangle, rect.Width, rect.Height);

                    Live_Control.Graphics.DrawImage(offscreenImage, 0, 0);
                }
            }

            this.Invalidate();
        }
    }
}
#endif