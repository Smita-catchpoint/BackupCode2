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
            Parallel.ForEach(numbers, number =>
            {
                Console.WriteLine($"Square of {number} is {number * number}");
            });

            Console.ReadLine();
        }
    }
}

