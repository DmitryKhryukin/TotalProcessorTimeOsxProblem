using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;

namespace TotalProcessorTimeOsxProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var processes = Process.GetProcesses();

            var allExceptions = new List<Tuple<string, int, string, string>>();

            foreach (var process in processes)
            {
                try
                {
                    var timeInformationToBeUsed = process.TotalProcessorTime;
                }
                catch(Exception e)
                {
                    allExceptions.Add(new Tuple<string, int, string, string>(process.ProcessName, process.Id, e.Message, e.StackTrace));
                }
            }

            Console.WriteLine($"Errors count: {allExceptions.Count}");

            var numberOfProcessesWithEmptyName = allExceptions.Count(x => string.IsNullOrWhiteSpace(x.Item1));

            Console.WriteLine($"Processes with empty name: {numberOfProcessesWithEmptyName}");

            allExceptions.ForEach(exception =>
            {
                Console.WriteLine($"ProcessName: {exception.Item1}");
                Console.WriteLine($"ProcessId: {exception.Item2.ToString()}");
                Console.WriteLine($"Message: {exception.Item3}");
                Console.WriteLine($"StackTrace: {exception.Item4}");
            });

            Console.ReadKey();
        }
    }
}
