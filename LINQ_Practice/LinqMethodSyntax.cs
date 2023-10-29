using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    internal class LinqMethodSyntax
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 5, 3, 8, 1, 7, 6, 4, 2, 9, 10 };

            var orderedNum = numbers.OrderBy(num => num);
            Console.WriteLine("Ordered Numbers:");
            foreach (var num in orderedNum)
            {
                Console.WriteLine(num);
            }

            var groupedNum = numbers.GroupBy(num => num % 3);
            Console.WriteLine("\nGrouped Num:");
            foreach (var group in groupedNum)
            {
                Console.WriteLine($"Group {group.Key}: {string.Join(", ", group)}");
            }

            List<int> moreNumbers = new List<int> { 11, 12, 13, 14, 15 };

            var concatenatedNumbers = numbers.Concat(moreNumbers);

            Console.WriteLine("\nConcatenated Numbers:");
            foreach (var num in concatenatedNumbers)
            {
                 Console.WriteLine(num);
                //Console.Write(num.ToString() + " ");
            }


            var num2 = numbers.All(num => num < 20);
            Console.WriteLine($"\nAll Numbers Less Than 20: {num2}");

            var count = numbers.Count();
            Console.WriteLine($"\nCount: {count}");

            var skippedAndTaken = numbers.Skip(3).Take(2);

            Console.WriteLine("\nSkipped and Taken:");
            foreach (var num in skippedAndTaken)
            {
                Console.WriteLine(num);
            }


            var Greater = numbers.First(num => num > 5);
            Console.WriteLine($"\nFirst Number > 5: {Greater}");

            var firstGreaterThan20OrDefault = numbers.FirstOrDefault(num => num > 20);
            Console.WriteLine($"\nFirst Number > 20 or Default: {firstGreaterThan20OrDefault}");

            var singleNumberEight = numbers.Single(num => num == 8);
            Console.WriteLine($"\nSingle Number 8: {singleNumberEight}");

            var singleNumberElevenOrDefault = numbers.SingleOrDefault(num => num == 11);
            Console.WriteLine($"Single Number 11 or Default: {singleNumberElevenOrDefault}");


        }
    }
}

