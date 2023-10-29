using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    internal class LinqQuerySyntax
    {

        static void Main()
        {
            List<int> numbers = new List<int> { 5, 3, 8, 1, 7, 6, 4, 2, 9, 10 };

            var orderedNumbers = from num in numbers
                                 orderby num
                                 select num;

            Console.WriteLine("Ordered Numbers:");
            foreach (var num in orderedNumbers)
            {
                Console.WriteLine(num);
            }

            var groupedNumbers = from num in numbers
                                 group num by num % 3;

            Console.WriteLine("\nGrouped Numbers:");
            foreach (var group in groupedNumbers)
            {
                Console.WriteLine($"Group {group.Key}: {string.Join(", ", group)}");
            }

        }
    }
}
