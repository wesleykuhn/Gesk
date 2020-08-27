using System;
using System.IO;

namespace Gesk.Library
{
    public static class ErrorsCare
    {
        public static bool AntiInvalidInstance = true;

        public static void AppendErrorOnErrorsFile(string errorText)
        {
            StreamWriter sw = File.AppendText(InformationsCore.Directories.Errors);
            sw.WriteLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " -> " + errorText);
            sw.Close();
        }
    }
}
