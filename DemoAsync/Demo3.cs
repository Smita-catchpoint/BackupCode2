using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAsync
{
    internal class Demo3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Started");

            Method2();

            Console.WriteLine("Main Method End");
            Console.ReadKey();
        }
        async static void Method2()
        {
            Console.WriteLine("Method2 Started......");

            //Method2
            await Method1();

            Console.WriteLine("\nMethod2 End");
        }

        // async static void Method2()
        async static Task Method1()
        {
            Console.WriteLine("Method1 Started......");
            await Task.Delay(1000);

            Console.WriteLine("\nMethod1 End");
        }


    }
}
