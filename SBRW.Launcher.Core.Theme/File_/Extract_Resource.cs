using System;
using System.IO;
using System.Reflection;

namespace SBRW.Launcher.Core.Theme.File_
{
    internal class Extract_Resource
    {
        internal static byte[] AsByte(string File_Name)
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
                        if (LiveStream == null)
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
    }
}
