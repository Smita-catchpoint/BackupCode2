using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    internal class Demo2
    {
        static void Main()
        {
            List<int> items = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = from num in items
                         where num % 2 == 0
                         select num;

            foreach (var num in result)
            {
                Console.WriteLine(num);

            }
        }
    }
}

