using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{           //sync program
    internal class SyncProgram
    {
        static void Task1()
        {
            Console.WriteLine("\ntask1 is started");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Task1:" + i);
            }
            Console.WriteLine("task1 is exitng");
        }

        static void Task2()
        {
            Console.WriteLine("\ntask2 is started");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Task2:" + i);
                if (i == 5)
                {
                    Thread.Sleep(5000);
                    Console.WriteLine("\ntask2 is waiting");
                }
            }
            Console.WriteLine("task2 is exitng");
        }
        static void Task3()
        {
            Console.WriteLine("\ntask3 is started");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Task3:" + i);
            }
            Console.WriteLine("task3 is exitng");
        }


        public static void Main()
        {
            Task1();
            Task2();
            Task3();

        }

    }
}
