using System;
using System.Diagnostics;
using System.Linq;

namespace Gesk.Library.Outputs
{
    public static class AdobePrint
    {
        public static void Print()
        {
            StartProcess();
        }

        public static void Print(int copies)
        {
            for (int i = 0; i < copies; i++)
            {
                StartProcess();
            }
        }

        private static void StartProcess()
        {
            try
            {
                Process process = new Process();                
                process.StartInfo.FileName = @".\tag.pdf";
                process.StartInfo.Verb = "print";
                process.StartInfo.Arguments = String.Format(@"/p /h {0}", @".\tag.pdf");
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                process.Start();

                if (process.HasExited == false)
                {
                    process.WaitForExit(1000);
                }

                process.EnableRaisingEvents = true;

                if (!process.WaitForExit(1000))
                {
                    process.Kill();
                }

                KillAdobe();            
            }
            catch (Exception ex)
            {
                ErrorsCare.AppendErrorOnErrorsFile(ex.Message);

                System.Windows.Forms.MessageBox.Show("Houve um erro fatal ao tentar imprimir a etiqueta! Mais informações no arquivo logs.txt.");
            }
        }

        public static void KillAdobe()
        {
            Process[] processes = Process.GetProcessesByName("AcroRd32.exe *32");
            foreach (Process process in processes)
            {
                process.Kill();
                process.WaitForExit();
            }
        }
    }
}
