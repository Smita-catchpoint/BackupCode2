using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ParallelProgDemo3
    {
        static void Main(string[] args)
        {

            var options = new ParallelOptions()
            {
                // MaxDegreeOfParallelism = 2
                MaxDegreeOfParallelism = Environment.ProcessorCount - 1
            };
            int n = 10;
            Parallel.For(0, n, options, i =>
            {
                // Console.WriteLine("i : {0}, thread : {1}", i, Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine($"i :{i}, thread: {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(100);
            });

            Console.ReadLine();
        }
    }
}

