using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    internal class LinqOperators
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var sum = numbers.Sum();
            Console.WriteLine($"Sum: {sum}");

            var maxNumber = numbers.Max();
            Console.WriteLine($"Max Number: {maxNumber}");

            var minNumber = numbers.Min();
            Console.WriteLine($"Min Number: {minNumber}");


            var anyGreaterThanFive = numbers.Any(num => num > 5);
            Console.WriteLine($"Any Number > 5: {anyGreaterThanFive}");

            // even numbers
            var evenNumbers = numbers.Where(num => num % 2 == 0);
            Console.WriteLine("Even Numbers:");

            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine($"Sum: {sum}");

            var squares = numbers.Select(num => num * num);
            Console.WriteLine("Squares:");
            foreach (var square in squares)
            {
                Console.WriteLine(square);
            }
        }
    }
}