using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ParallelProgDemo6
    {
        static void Main()
        {
            int Result1 = 0;
            string Result2 = string.Empty;

            Parallel.Invoke(
                () => Result1 = Method1(),
                () => Result2 = Method2("Pranaya"),
                () => Method3(100)
            );

            Console.WriteLine($"Method1 Result: {Result1}");
            Console.WriteLine($"\nMethod2 Result: {Result2}");
            Console.WriteLine($"\nParallel Execution Completed");

            Console.ReadKey();
        }
        static int Method1()
        {
            Task.Delay(200);
            Console.WriteLine($"Method 1: Thread={Thread.CurrentThread.ManagedThreadId}");
            return 100;
        }
        static string Method2(string name)
        {
            Task.Delay(200);
            Console.WriteLine($"Method 2 :Thread={Thread.CurrentThread.ManagedThreadId}");
            return "Hello:" + name;
        }
        static void Method3(int number)
        {
            Task.Delay(200);
            Console.WriteLine($"Method 3:Thread={Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
