using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_Processes
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShowProc();

            /*ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "notepad++";
            info.Arguments = @"C:\Lesson6\SavedPoint.txt";
            info.WindowStyle = ProcessWindowStyle.Maximized;
            Process.Start(info);*/

            Process proc = Process.GetProcessesByName("notepad++")[0];
            foreach (ProcessThread thread in proc.Threads)
            {
                Console.WriteLine(thread.Id);
                Console.WriteLine(thread.StartTime);
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        private static void ShowProc()
        {
            Process[] processes = Process.GetProcesses();
            /*foreach (Process process in processes)
            {
                Console.WriteLine(process.ProcessName);
                try
                {
                    Console.WriteLine(process.PeakPagedMemorySize64);
                    Console.WriteLine(process.StartTime);
                }
                catch { }
                Console.WriteLine();
            }*/

            /*foreach (Process proc in processes)
            {
                if (proc.ProcessName == "notepad++")
                {
                    proc.Kill();
                    Console.WriteLine("Убит");
                }
            }*/

            //Process.Start("notepad++", @"C:\Lesson6\SavedPoint.txt");
            //Process.Start("chrome", @"http:\\google.com");
        }
    }
}
