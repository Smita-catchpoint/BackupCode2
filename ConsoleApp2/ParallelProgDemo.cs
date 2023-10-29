using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ParallelProgDemo
    {
        static void Main()
        {
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();

            //Calling sequentially
            //Method1();
            //Method2();
            //Method3();

            //Calling Parallely
            Parallel.Invoke(Method1, Method2, Method3);

            stopWatch.Stop();
            Console.WriteLine($"Time: {stopWatch.ElapsedMilliseconds} Milliseconds");

            Console.ReadKey();
        }
        static void Method1()
        {
            Thread.Sleep(200);
            Console.WriteLine($"Method 1:ThreadId :{Thread.CurrentThread.ManagedThreadId}");
        }
        static void Method2()
        {
            Thread.Sleep(200);
            Console.WriteLine($"Method 2:ThreadId :{Thread.CurrentThread.ManagedThreadId}");
        }
        static void Method3()
        {
            Thread.Sleep(200);
            Console.WriteLine($"Method 3:ThreadId ::{Thread.CurrentThread.ManagedThreadId}");
        }
    }
}


