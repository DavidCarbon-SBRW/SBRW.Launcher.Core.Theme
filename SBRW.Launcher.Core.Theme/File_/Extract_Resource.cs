using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace SBRW.Launcher.Core.Theme.File_
{
    /// <summary>
    /// 
    /// </summary>
    internal static class Extract_Resource
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="File_Name"></param>
        /// <returns></returns>
        internal static byte[] To_Byte(this string File_Name)
        {
            if (string.IsNullOrWhiteSpace(File_Name))
            {
                return default;
            }
            else
            {
                try
                {
                    Assembly TheRun = Assembly.GetExecutingAssembly();
                    using (Stream LiveStream = TheRun.GetManifestResourceStream(File_Name))
                    {
                        if (LiveStream == default)
                        {
                            return default;
                        }
                        else
                        {
                            byte[] ba = new byte[LiveStream.Length];
                            LiveStream.Read(ba, 0, ba.Length);
                            return ba;
                        }
                    }
                }
                catch (Exception)
                {
                    return default;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="File_Name"></param>
        /// <returns></returns>
        internal static string ByteToString(this string File_Name)
        {
            if (string.IsNullOrWhiteSpace(File_Name))
            {
                return default;
            }
            else
            {
                try
                {
                    using (Stream SVG_Stream = new MemoryStream(File_Name.To_Byte()))
                    {
                        using (StreamReader SVG_Reader = new StreamReader(SVG_Stream, Encoding.UTF8))
                        {
                            return SVG_Reader.ReadToEnd();
                        }
                    }
                }
                catch (Exception)
                {
                    return string.Empty;
                }
            }
        }
    }
}
