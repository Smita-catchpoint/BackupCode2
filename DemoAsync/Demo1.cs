using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{                  //TPL in c#
    internal class Demo1
    {
        static void Main()
        {
            Task task1 = Task.Run(() => DoWork(1));
            Task task2 = Task.Run(() => DoWork(2));

            Task.WaitAll(task1, task2);

            Console.Write("All tasks Completed");

        }
        static void DoWork(int id)
        {
            Console.WriteLine("Task {0} is starting ...", id);
            Task.Delay(1000).Wait();
            Console.WriteLine("Task {0} is done...", id);

        }
    }
}
