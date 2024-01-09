using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    internal class ParallelLinqDemo3
    {
        static void Main(string[] args)
        {
            //Creating a Collection of integer numbers
            List<int> numbers = new List<int>()
            {
                1, 2, 6, 7, 5, 4, 10, 12, 13, 20, 18, 9, 11, 15, 14, 3, 8, 16, 17, 19
            };

                 var num1 = numbers
                .AsParallel() 
                .AsOrdered() 
                .Where(x => x % 2 == 0)
                .ToList();

            Console.WriteLine("using AsOrdered");
            foreach (var number in num1)
            {
                Console.WriteLine(number);
            }

          
            var num2 = numbers
                .AsParallel() 
                .Where(x => x % 2 == 0)
                .OrderBy(x => x) 
                .ToList();

            Console.WriteLine("\nusing OrderBy");
            foreach (var number in num2)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}

