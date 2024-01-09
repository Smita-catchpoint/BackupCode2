using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ParallelProgDemo4
    {       //parallel foreach takes less time.
        static void Main()
        {
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Loop Started");
            stopwatch.Start();
            List<int> integerList = Enumerable.Range(1, 10).ToList();

            //foreach (int i in integerList)
            //{
            //    long total = IndependentTask();
            //     Console.WriteLine($" i: {i} total: {total} Thread:{Thread.CurrentThread.ManagedThreadId}");
            //};

            // var options = new ParallelOptions() { MaxDegreeOfParallelism = 2 };
            Parallel.ForEach(integerList, i =>
                {
                    long total = IndependentTask();
                    Console.WriteLine($" i: {i} total: {total} Thread:{Thread.CurrentThread.ManagedThreadId}");
                });


            Console.WriteLine("loop Ended");
            stopwatch.Stop();

            Console.WriteLine($"Execution time: {stopwatch.ElapsedMilliseconds}");
            Console.ReadLine();
        }

        static long IndependentTask()
        {
            //Do Some Time Consuming Task here
            long total = 0;
            for (int i = 1; i < 100000000; i++)
            {
                total += i;
            }
            return total;
        }
    }
}
