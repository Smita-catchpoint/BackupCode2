using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ParallelProgDemo2
    {
        static void Main()
        {

            Stopwatch stopWatch = new Stopwatch();

            Console.WriteLine("For Loop Execution start");
            stopWatch.Start();
            //for (int i = 0; i < 10; i++)
            //{
            //    long total = IndependentTask();
            //    Console.WriteLine("{0} - {1}", i, total);
            //}

            Parallel.For(0, 10, i =>
            {
                long total = IndependentTask();
                Console.WriteLine("{0} - {1}", i, total);
            });

            Console.WriteLine("For Loop Execution end ");
            stopWatch.Stop();
            Console.WriteLine($"Execution Time: {stopWatch.ElapsedMilliseconds}");
            Console.ReadLine();
        }

        static long IndependentTask()
        {

            long total = 0;
            for (int i = 1; i < 100000000; i++)
            {
                total += i;
            }
            return total;
            //return 10;
        }
    }
}