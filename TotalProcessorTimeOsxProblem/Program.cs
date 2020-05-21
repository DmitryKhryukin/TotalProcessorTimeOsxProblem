using System;
using System.Diagnostics;
using System.Linq;

namespace TotalProcessorTimeOsxProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var processes = Process.GetProcesses();

            try
            {
                var timeInformationToBeUsed = processes.Select(x => x.TotalProcessorTime).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Hi dear, I'm {e.GetType()}!");
                Console.WriteLine("Why am I happening? :P");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"StackTrace: {e.StackTrace}");
            }

            Console.ReadKey();
        }
    }
}
