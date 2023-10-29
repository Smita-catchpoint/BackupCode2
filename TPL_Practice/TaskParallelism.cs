using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL_Practice
{
    internal class TaskParallelism
    {
        static void Main()
        {
            Parallel.Invoke(() => PrintMessage("Task 1"), () => PrintMessage("Task 2"));
            Console.ReadLine();
        }

        static void PrintMessage(string message)
        {
            Console.WriteLine($"Message from {message}");
        }
    }
}