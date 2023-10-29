using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelProgramming
{
    class MultithreadingDemo
    {
        static void Main(string[] args)
        {
            //    Thread t1 = new Thread((Method1) => { Console.WriteLine("Hello"); });
            //    t1.Start();
            //    Thread t2 = new Thread((Method2) => { Console.WriteLine("World"); });
            //    t2.Start();


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nParallel For loop:");
            Parallel.For(0, 11, i => { Console.WriteLine(i); });

        }



    }
}
