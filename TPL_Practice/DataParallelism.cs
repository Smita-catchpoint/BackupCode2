using System;
using System.Threading.Tasks;

namespace TPL_Practice
{
    internal class DataParallelism
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Parallel.ForEach
            Parallel.ForEach(numbers, num =>
            {
                Console.WriteLine($"Square of {num} is {num * num}");
            });

            Console.ReadLine();
        }
    }
}

