using SBRW.Launcher.Core.Theme.File_;

namespace SBRW.Launcher.Core.Theme.Conversion_
{
    /// <summary>
    /// Embeded Files Function Extraction
    /// </summary>
    public class Embeded_Files
    {
        /// <summary>
        /// 
        /// </summary>
        internal const string SBRW_Resources_Root_Path = "SBRW.Launcher.Core.Theme.Resources.";
        /// <summary>
        /// At Compilee Time Constant Static String File
        /// </summary>
        internal const string BootFlow_GFX_File = $"{SBRW_Resources_Root_Path}BootScreen.BootFlow.gfx";
        /// <summary>
        /// At Compilee Time Constant Static String File
        /// </summary>
        internal const string Cursor_Ani_File = $"{SBRW_Resources_Root_Path}Cursors.Cursor.ani";
        /// <summary>
        /// At Compilee Time Constant Static String File
        /// </summary>
        internal const string DejaVuSans_Ttf_File = $"{SBRW_Resources_Root_Path}Fonts.DejaVuSans.ttf";
        /// <summary>
        /// At Compilee Time Constant Static String File
        /// </summary>
        internal const string DejaVuSans_Bold_Ttf_File = $"{SBRW_Resources_Root_Path}Fonts.DejaVuSans-Bold.ttf";
        /// <summary>
        /// At Compilee Time Constant Static String File
        /// </summary>
        internal const string SBRW_Ico_File = $"{SBRW_Resources_Root_Path}Ico.SBRW.ico";
        /// <summary>
        /// At Compilee Time Constant Static String File
        /// </summary>
        internal const string SVG_Check_Engine = $"{SBRW_Resources_Root_Path}SVGs.Icon_Check_Engine.svg";
        /// <summary>
        /// At Compilee Time Constant Static String File
        /// </summary>
        internal const string SVG_Cross = $"{SBRW_Resources_Root_Path}SVGs.Icon_Cross.svg";
        /// <summary>
        /// At Compilee Time Constant Static String File
        /// </summary>
        internal const string SVG_Discord = $"{SBRW_Resources_Root_Path}SVGs.Icon_Discord.svg";
        /// <summary>
        /// At Compilee Time Constant Static String File
        /// </summary>
        internal const string SVG_Facebook = $"{SBRW_Resources_Root_Path}SVGs.Icon_Facebook.svg";
        /// <summary>
        /// At Compilee Time Constant Static String File
        /// </summary>
        internal const string SVG_Gear = $"{SBRW_Resources_Root_Path}SVGs.Icon_Gear.svg";
        /// <summary>
        /// At Compilee Time Constant Static String File
        /// </summary>
        internal const string SVG_Globe = $"{SBRW_Resources_Root_Path}SVGs.Icon_Globe.svg";
        /// <summary>
        /// At Compilee Time Constant Static String File
        /// </summary>
        internal const string SVG_Home = $"{SBRW_Resources_Root_Path}SVGs.Icon_Home.svg";
        /// <summary>
        /// At Compilee Time Constant Static String File
        /// </summary>
        internal const string SVG_Plug_Connect = $"{SBRW_Resources_Root_Path}SVGs.Icon_Plug_Disconnected.svg";
        /// <summary>
        /// At Compilee Time Constant Static String File
        /// </summary>
        internal const string SVG_Save = $"{SBRW_Resources_Root_Path}SVGs.Icon_Save_Alt.svg";
        /// <summary>
        /// At Compilee Time Constant Static String File
        /// </summary>
        internal const string SVG_Shield = $"{SBRW_Resources_Root_Path}SVGs.Icon_Shield.svg";
        /// <summary>
        /// At Compilee Time Constant Static String File
        /// </summary>
        internal const string SVG_Twitter = $"{SBRW_Resources_Root_Path}SVGs.Icon_Twitter.svg";
        /// <summary>
        /// At Compilee Time Constant Static String File
        /// </summary>
        internal const string SVG_Inputs = $"{SBRW_Resources_Root_Path}SVGs.Input_Global.svg";
        /// <summary>
        /// BootFlow GFX File
        /// </summary>
        /// <returns>Embeded Resource BootFlow GFX File in Bytes</returns>
        public static byte[] BootFlow_GFX_Bytes()
        {
            return BootFlow_GFX_File.To_Byte();
        }
        /// <summary>
        /// Cursor File
        /// </summary>
        /// <returns>Embeded Resource Cursor File in Bytes</returns>
        public static byte[] Cursor_Ani_Bytes()
        {
            return Cursor_Ani_File.To_Byte();
        }
        /// <summary>
        /// DejaVuSans Font File
        /// </summary>
        /// <returns>Embeded Resource DejaVuSans Font File in Bytes</returns>
        public static byte[] DejaVuSans_Ttf_Bytes()
        {
            return DejaVuSans_Ttf_File.To_Byte();
        }
        /// <summary>
        /// DejaVuSans Bold Font File
        /// </summary>
        /// <returns>Embeded Resource DejaVuSans Bold Font File in Bytes</returns>
        public static byte[] DejaVuSans_Bold_Ttf_Bytes()
        {
            return DejaVuSans_Bold_Ttf_File.To_Byte();
        }
        /// <summary>
        /// SBRW Ico File
        /// </summary>
        /// <returns>Embeded Resource SBRW Ico File in Bytes</returns>
        public static byte[] SBRW_Ico_Bytes()
        {
            return SBRW_Ico_File.To_Byte();
        }
        /// <summary>
        /// Check Engine SVG File
        /// </summary>
        /// <returns>Embeded Resource Check Engine SVG File in Bytes</returns>
        public static string SVG_Check_Engine_Bytes()
        {
            return SVG_Check_Engine.ByteToString();
        }
        /// <summary>
        /// Cross SVG File
        /// </summary>
        /// <returns>Embeded Resource Cross SVG File in Bytes</returns>
        public static string SVG_Cross_Bytes()
        {
            return SVG_Cross.ByteToString();
        }
        /// <summary>
        /// Discord SVG File
        /// </summary>
        /// <returns>Embeded Resource Discord SVG File in Bytes</returns>
        public static string SVG_Discord_Bytes()
        {
            return SVG_Discord.ByteToString();
        }
        /// <summary>
        /// Facebook SVG File
        /// </summary>
        /// <returns>Embeded Resource Facebook SVG File in Bytes</returns>
        public static string SVG_Facebook_Bytes()
        {
            return SVG_Facebook.ByteToString();
        }
        /// <summary>
        /// Gear SVG File
        /// </summary>
        /// <returns>Embeded Resource Gear SVG File in Bytes</returns>
        public static string SVG_Gear_Bytes()
        {
            return SVG_Gear.ByteToString();
        }
        /// <summary>
        /// Globe SVG File
        /// </summary>
        /// <returns>Embeded Resource Globe SVG File in Bytes</returns>
        public static string SVG_Globe_Bytes()
        {
            return SVG_Globe.ByteToString();
        }
        /// <summary>
        /// Home SVG File
        /// </summary>
        /// <returns>Embeded Resource Home SVG File in Bytes</returns>
        public static string SVG_Home_Bytes()
        {
            return SVG_Home.ByteToString();
        }
        /// <summary>
        /// Plug Connect SVG File
        /// </summary>
        /// <returns>Embeded Resource Plug Connect SVG File in Bytes</returns>
        public static string SVG_Plug_Connect_Bytes()
        {
            return SVG_Plug_Connect.ByteToString();
        }
        /// <summary>
        /// Save SVG File
        /// </summary>
        /// <returns>Embeded Resource Save SVG File in Bytes</returns>
        public static string SVG_Save_Bytes()
        {
            return SVG_Save.ByteToString();
        }
        /// <summary>
        /// Shield SVG File
        /// </summary>
        /// <returns>Embeded Resource Shield SVG File in Bytes</returns>
        public static string SVG_Shield_Bytes()
        {
            return SVG_Shield.ByteToString();
        }
        /// <summary>
        /// Twitter SVG File
        /// </summary>
        /// <returns>Embeded Resource Twitter SVG File in Bytes</returns>
        public static string SVG_Twitter_Bytes()
        {
            return SVG_Twitter.ByteToString();
        }
        /// <summary>
        /// Inputs Box SVG File
        /// </summary>
        /// <returns>Embeded Resource Inputs Box SVG File in Bytes</returns>
        public static string SVG_Inputs_Box_Bytes()
        {
            return SVG_Inputs.ByteToString();
        }
    }
}
