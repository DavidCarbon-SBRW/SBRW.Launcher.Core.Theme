using SBRW.Launcher.Core.Theme.File_;

namespace SBRW.Launcher.Core.Theme.Conversion_
{
    /// <summary>
    /// Embeded Files Function Extraction
    /// </summary>
    public class Embeded_Files
    {
        /// <summary>
        /// At Compilee Time Constant Static String File
        /// </summary>
        internal const string BootFlow_GFX_File = "SBRW.Launcher.Core.Theme.Resources.BootScreen.BootFlow.gfx";
        /// <summary>
        /// At Compilee Time Constant Static String File
        /// </summary>
        internal const string Cursor_Ani_File = "SBRW.Launcher.Core.Theme.Resources.Cursors.Cursor.ani";
        /// <summary>
        /// At Compilee Time Constant Static String File
        /// </summary>
        internal const string DejaVuSans_Ttf_File = "SBRW.Launcher.Core.Theme.Resources.Fonts.DejaVuSans.ttf";
        /// <summary>
        /// At Compilee Time Constant Static String File
        /// </summary>
        internal const string DejaVuSans_Bold_Ttf_File = "SBRW.Launcher.Core.Theme.Resources.Fonts.DejaVuSans-Bold.ttf";
        /// <summary>
        /// At Compilee Time Constant Static String File
        /// </summary>
        internal const string SBRW_Ico_File = "SBRW.Launcher.Core.Theme.Resources.Ico.SBRW.ico";
        /// <summary>
        /// BootFlow GFX File
        /// </summary>
        /// <returns>Embeded Resource BootFlow GFX File in Bytes</returns>
        public static byte[] BootFlow_GFX_Bytes()
        {
            return Extract_Resource.AsByte(BootFlow_GFX_File);
        }
        /// <summary>
        /// Cursor File
        /// </summary>
        /// <returns>Embeded Resource Cursor File in Bytes</returns>
        public static byte[] Cursor_Ani_Bytes()
        {
            return Extract_Resource.AsByte(Cursor_Ani_File);
        }
        /// <summary>
        /// DejaVuSans Font File
        /// </summary>
        /// <returns>Embeded Resource DejaVuSans Font File in Bytes</returns>
        public static byte[] DejaVuSans_Ttf_Bytes()
        {
            return Extract_Resource.AsByte(DejaVuSans_Ttf_File);
        }
        /// <summary>
        /// DejaVuSans Bold Font File
        /// </summary>
        /// <returns>Embeded Resource DejaVuSans Bold Font File in Bytes</returns>
        public static byte[] DejaVuSans_Bold_Ttf_Bytes()
        {
            return Extract_Resource.AsByte(DejaVuSans_Bold_Ttf_File);
        }
        /// <summary>
        /// SBRW Ico File
        /// </summary>
        /// <returns>Embeded Resource SBRW Ico File in Bytes</returns>
        public static byte[] SBRW_Ico_Bytes()
        {
            return Extract_Resource.AsByte(SBRW_Ico_File);
        }
    }
}
