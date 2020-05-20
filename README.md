Message: Failed to set or retrieve rusage information. See the error code for OS-specific error information.
StackTrace:    at Interop.libproc.proc_pid_rusage(Int32 pid)
   at System.Diagnostics.Process.get_TotalProcessorTime()
   at TotalProcessorTimeOsxProblem.Program.<>c.<Main>b__0_0(Process x) in /Users/dmitrykhryukin/Projects/TotalProcessorTimeOsxProblem/TotalProcessorTimeOsxProblem/Program.cs:line 15
   at System.Linq.Enumerable.SelectArrayIterator`2.ToList()
   at System.Linq.Enumerable.ToList[TSource](IEnumerable`1 source)
   at TotalProcessorTimeOsxProblem.Program.Main(String[] args) in /Users/dmitrykhryukin/Projects/TotalProcessorTimeOsxProblem/TotalProcessorTimeOsxProblem/Program.cs:line 15
