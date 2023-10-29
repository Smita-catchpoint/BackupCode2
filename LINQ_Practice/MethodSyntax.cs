using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    internal class MethodSyntax
    {
        static void Main()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var Result = list.Where(num => num % 2 == 0).Select(num => num);

            foreach (var num in Result)
            {
                Console.WriteLine(num);
            }
        }
    }
}
