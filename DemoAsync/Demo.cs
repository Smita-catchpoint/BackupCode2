using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAsync
{
    internal class Demo

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Started");

           Method1();

          // Method2();

            Console.WriteLine("Main Method End");
            Console.ReadKey();
        }
        async static void Method1()
        {
            Console.WriteLine("Method1 Started......");
             //await Task.Delay(1000);
            await Task.Delay(TimeSpan.FromSeconds(10));
            Console.WriteLine("\nMethod1 End");
        }

        public static void Method2()
        {
            Console.WriteLine("Method2 Started......");

            Thread.Sleep(TimeSpan.FromSeconds(10));
            // Thread.Sleep(1000);

            Console.WriteLine("\nMethod2 End");
        }
    }
}

