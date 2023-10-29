using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class MultithreadingExample
    {
        static void Task1()
        {
            Console.WriteLine("\nthread1 is started");
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("Task1:" + i);
            }
            Console.WriteLine("\nthread1 is exitng");
        }

        static void Task2()
        {
            Console.WriteLine("\nthread2 is started");
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("Task2:" + i);
                if (i == 20)
                {
                    Thread.Sleep(5000);
                    Console.WriteLine("\n Thread 2 is waiting");
                }
            }
            Console.WriteLine("\nthread2 is exitng");
        }
        static void Task3()
        {
            Console.WriteLine("\nthread3 is started");
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("Task3:" + i);
            }
            Console.WriteLine("\nthread3 is exitng");
        }

        public static void Main()
        {
            Console.WriteLine("Main thread is started");
            Thread t1 = new Thread(Task1);
            Thread t2 = new Thread(Task2);
            Thread t3 = new Thread(Task3);
            Console.WriteLine("Main thread is exitng");

            t1.Start();
            t2.Start();
            t3.Start();



        }

    }
}
