using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    internal class LinqDemo1
    {
        static void Main()
        {
            String[] names = { "Bill", "Steve", "James", "Mohan" };

            // LINQ Query 
            var myLinqQuery = from name in names
                              where name.Contains('a')
                              select name;

            // Query execution
            foreach (var name in myLinqQuery)
                Console.Write(name + " ");
        }
    }
}
