using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    internal class ParallelLinqDemo
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 20);

            var num1 = numbers.Where(x => x % 2 == 0).ToList();
            Console.WriteLine("Regular linq:");
            foreach (var number in num1)
            {
                Console.WriteLine(number);
            }

            var num2 = numbers.AsParallel().Where(x => x % 2 == 0).ToList();
            Console.WriteLine("Parallel linq");
            foreach (var number in num2)
            {
                Console.WriteLine(number);
            }

            var num3 = numbers
                .AsParallel() //Parallel Processing
                .AsOrdered() //Original Order of the numbers
                .Where(x => x % 2 == 0)
                .ToList();
            Console.WriteLine("Maintain the Original Order in Parallel linq");
            foreach (var number in num3)
            {
                Console.WriteLine(number);
            }
        }
    }
}