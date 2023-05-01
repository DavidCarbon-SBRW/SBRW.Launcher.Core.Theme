#if NETFRAMEWORK || NET6_0_OR_GREATER && WINDOWS
using System.Drawing;

namespace SBRW.Launcher.Core.Theme
{
    /// <summary>
    /// 
    /// </summary>
    public class Image_Icon
    {
        /// <summary>
        /// 
        /// </summary>
        public static Image Close { get; set; } = Image_Converter.Value(Properties.Resources.icon_close);
        /// <summary>
        /// 
        /// </summary>
        public static Image Close_Click { get; set; } = Image_Converter.Value(Properties.Resources.icon_close_click);
        /// <summary>
        /// 
        /// </summary>
        public static Image Close_Hover { get; set; } = Image_Converter.Value(Properties.Resources.icon_close_hover);
        /// <summary>
        /// 
        /// </summary>
        public static Image Discord { get; set; } = Image_Converter.Value(Properties.Resources.social_discord);
        /// <summary>
        /// 
        /// </summary>
        public static Image Discord_Disabled { get; set; } = Image_Converter.Value(Properties.Resources.social_discord_disabled);
        /// <summary>
        /// 
        /// </summary>
        public static Image Engine_Checking { get; set; } = Image_Converter.Value(Properties.Resources.icon_engine_checking);
        /// <summary>
        /// 
        /// </summary>
        public static Image Engine_Error { get; set; } = Image_Converter.Value(Properties.Resources.icon_engine_error, 3);
        /// <summary>
        /// 
        /// </summary>
        public static Image Engine_Good { get; set; } = Image_Converter.Value(Properties.Resources.icon_engine_success, 1);
        /// <summary>
        /// 
        /// </summary>
        public static Image Engine_Unknown { get; set; } = Image_Converter.Value(Properties.Resources.icon_engine_unknown, 4);
        /// <summary>
        /// 
        /// </summary>
        public static Image Engine_Warning { get; set; } = Image_Converter.Value(Properties.Resources.icon_engine_warning, 2);
        /// <summary>
        /// 
        /// </summary>
        public static Image Facebook { get; set; } = Image_Converter.Value(Properties.Resources.social_facebook);
        /// <summary>
        /// 
        /// </summary>
        public static Image Facebook_Disabled { get; set; } = Image_Converter.Value(Properties.Resources.social_facebook_disabled);
        /// <summary>
        /// 
        /// </summary>
        public static Image Home { get; set; } = Image_Converter.Value(Properties.Resources.social_home_page);
        /// <summary>
        /// 
        /// </summary>
        public static Image Home_Disabled { get; set; } = Image_Converter.Value(Properties.Resources.social_home_page_disabled);
        /// <summary>
        /// 
        /// </summary>
        public static Image Gear { get; set; } = Image_Converter.Value(Properties.Resources.icon_gear);
        /// <summary>
        /// 
        /// </summary>
        public static Image Gear_Click { get; set; } = Image_Converter.Value(Properties.Resources.icon_gear_click);
        /// <summary>
        /// 
        /// </summary>
        public static Image Gear_Hover { get; set; } = Image_Converter.Value(Properties.Resources.icon_gear_hover);
        /// <summary>
        /// 
        /// </summary>
        public static Image Gear_Warning { get; set; } = Image_Converter.Value(Properties.Resources.icon_gear_warning);
        /// <summary>
        /// 
        /// </summary>
        public static Image Gear_Warning_Click { get; set; } = Image_Converter.Value(Properties.Resources.icon_gear_warning_click);
        /// <summary>
        /// 
        /// </summary>
        public static Image Gear_Warning_Hover { get; set; } = Image_Converter.Value(Properties.Resources.icon_gear_warning_hover);
        /// <summary>
        /// 
        /// </summary>
        public static Image Plug_Checking { get; set; } = Image_Converter.Value(Properties.Resources.icon_api_checking);
        /// <summary>
        /// 
        /// </summary>
        public static Image Plug_Offline { get; set; } = Image_Converter.Value(Properties.Resources.icon_api_offline, 3);
        /// <summary>
        /// 
        /// </summary>
        public static Image Plug_Online { get; set; } = Image_Converter.Value(Properties.Resources.icon_api_online, 1);
        /// <summary>
        /// 
        /// </summary>
        public static Image Plug_Warning { get; set; } = Image_Converter.Value(Properties.Resources.icon_api_warning, 2);
        /// <summary>
        /// 
        /// </summary>
        public static Image Plug_Unknown { get; set; } = Image_Converter.Value(Properties.Resources.icon_api_unknown, 4);
        /// <summary>
        /// 
        /// </summary>
        public static Image Server_Checking { get; set; } = Image_Converter.Value(Properties.Resources.icon_game_server_checking);
        /// <summary>
        /// 
        /// </summary>
        public static Image Server_Offline { get; set; } = Image_Converter.Value(Properties.Resources.icon_game_server_offline, 3);
        /// <summary>
        /// 
        /// </summary>
        public static Image Server_Online { get; set; } = Image_Converter.Value(Properties.Resources.icon_game_server_online, 1);
        /// <summary>
        /// 
        /// </summary>
        public static Image Server_Unknown { get; set; } = Image_Converter.Value(Properties.Resources.icon_game_server_unknown, 4);
        /// <summary>
        /// 
        /// </summary>
        public static Image Server_Warning { get; set; } = Image_Converter.Value(Properties.Resources.icon_game_server_warning, 2);
        /// <summary>
        /// 
        /// </summary>
        public static Image Shield_Checking { get; set; } = Image_Converter.Value(Properties.Resources.icon_shield_checking);
        /// <summary>
        /// 
        /// </summary>
        public static Image Shield_Checking_Click { get; set; } = Image_Converter.Value(Properties.Resources.icon_shield_checking_click);
        /// <summary>
        /// 
        /// </summary>
        public static Image Shield_Checking_Hover { get; set; } = Image_Converter.Value(Properties.Resources.icon_shield_checking_hover);
        /// <summary>
        /// 
        /// </summary>
        public static Image Shield_Error { get; set; } = Image_Converter.Value(Properties.Resources.icon_shield_error, 3);
        /// <summary>
        /// 
        /// </summary>
        public static Image Shield_Error_Click { get; set; } = Image_Converter.Value(Properties.Resources.icon_shield_error_click, 3);
        /// <summary>
        /// 
        /// </summary>
        public static Image Shield_Error_Hover { get; set; } = Image_Converter.Value(Properties.Resources.icon_shield_error_hover, 3);
        /// <summary>
        /// 
        /// </summary>
        public static Image Shield_Success { get; set; } = Image_Converter.Value(Properties.Resources.icon_shield_success, 1);
        /// <summary>
        /// 
        /// </summary>
        public static Image Shield_Success_Click { get; set; } = Image_Converter.Value(Properties.Resources.icon_shield_success_click, 1);
        /// <summary>
        /// 
        /// </summary>
        public static Image Shield_Success_Hover { get; set; } = Image_Converter.Value(Properties.Resources.icon_shield_success_hover, 1);
        /// <summary>
        /// 
        /// </summary>
        public static Image Shield_Unknown { get; set; } = Image_Converter.Value(Properties.Resources.icon_shield_unknown, 4);
        /// <summary>
        /// 
        /// </summary>
        public static Image Shield_Unknown_Click { get; set; } = Image_Converter.Value(Properties.Resources.icon_shield_unknown_click, 4);
        /// <summary>
        /// 
        /// </summary>
        public static Image Shield_Unknown_Hover { get; set; } = Image_Converter.Value(Properties.Resources.icon_shield_unknown_hover, 4);
        /// <summary>
        /// 
        /// </summary>
        public static Image Shield_Warning { get; set; } = Image_Converter.Value(Properties.Resources.icon_shield_warning, 2);
        /// <summary>
        /// 
        /// </summary>
        public static Image Shield_Warning_Click { get; set; } = Image_Converter.Value(Properties.Resources.icon_shield_warning_click, 2);
        /// <summary>
        /// 
        /// </summary>
        public static Image Shield_Warning_Hover { get; set; } = Image_Converter.Value(Properties.Resources.icon_shield_warning_hover, 2);
        /// <summary>
        /// 
        /// </summary>
        public static Image Twitter { get; set; } = Image_Converter.Value(Properties.Resources.social_twitter);
        /// <summary>
        /// 
        /// </summary>
        public static Image Twitter_Disabled { get; set; } = Image_Converter.Value(Properties.Resources.social_twitter_disabled);
    }
}
#endif