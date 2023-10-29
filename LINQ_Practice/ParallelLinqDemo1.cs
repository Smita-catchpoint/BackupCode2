using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    internal class ParallelLinqDemo1
    {
        static void Main()
        {
            int[] numbers = Enumerable.Range(1, 100).ToArray();

            numbers.AsParallel().ForAll(num => Console.WriteLine($"Number: {num}"));

            var evenNumbers = numbers.AsParallel().Where(num => num % 2 == 0);

            Console.WriteLine("Even Numbers:");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }

            var squares = numbers.AsParallel().Select(num => num * num);

            Console.WriteLine("\nSquares:");
            foreach (var num in squares)
            {
                Console.WriteLine(num);
            }
            var sum = numbers.AsParallel().Aggregate((sum, num) => sum + num);
            Console.WriteLine($"\nSum: {sum}");

            Parallel.For(0, 10, i => Console.WriteLine($"Iteration {i}"));

          
            bool anyGreaterThan50 = numbers.AsParallel().Any(num => num > 50);
             Console.WriteLine($"Any Number > 50: {anyGreaterThan50}");

           
            bool allLessThan100 = numbers.AsParallel().All(num => num < 100);
            Console.WriteLine($"All Numbers < 100: {allLessThan100}");

            int countGreaterThan75 = numbers.AsParallel().Count(num => num > 75);
            Console.WriteLine($"Count > 75: {countGreaterThan75}");

           
            int minNumber = numbers.AsParallel().Min();
            Console.WriteLine($"Min Number: {minNumber}");

            int maxNumber = numbers.AsParallel().Max();
            Console.WriteLine($"Max Number: {maxNumber}");

            int sumOfSquares = squares.AsParallel().Sum();
            Console.WriteLine($"Sum of Squares: {sumOfSquares}");

            
            double average = numbers.AsParallel().Average();
            Console.WriteLine($"Average: {average}");

            
  
        }
    }
}

