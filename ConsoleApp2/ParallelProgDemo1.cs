using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ParallelProgDemo1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# For Loop");

            for (int count = 0; count < 10; count++)
            {

                Console.WriteLine($"count = {count}, thread = {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(100);
            }
            Console.WriteLine();

            Console.WriteLine("Parallel For Loop");
            Parallel.For(0, 11, count =>
            {
                Console.WriteLine($"count = {count}, thread = {Thread.CurrentThread.ManagedThreadId}");

                Thread.Sleep(100);
            });
            Console.ReadLine();
        }
    }
}