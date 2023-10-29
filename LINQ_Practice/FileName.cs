using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    internal class FileName
    {
            static void Main()
            {
                var random = new Random();
                int[] values = Enumerable.Range(1, 99999999)
                    .Select(x => random.Next(1, 1000))
                    .ToArray();

                Console.WriteLine("LINQ");

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                
                var linqMin = values.Min();
                var linqMax = values.Max();
                var linqAverage = values.Average();
                stopwatch.Stop();

                var time1 = stopwatch.ElapsedMilliseconds;

                DisplayResults(linqMin, linqMax, linqAverage, time1);

                
                Console.WriteLine("\nPLINQ");
                stopwatch.Restart();
                var plinqMin = values.AsParallel().Min();
                var plinqMax = values.AsParallel().Max();
                var plinqAverage = values.AsParallel().Average();
                stopwatch.Stop();
                var time2 = stopwatch.ElapsedMilliseconds;

                DisplayResults(plinqMin, plinqMax, plinqAverage, time2);

                Console.ReadKey();
            }
            static void DisplayResults(int min, int max, double average, double time)
            {
                Console.WriteLine($"Min: {min}\nMax: {max}\n" + $"Average: {average:F}\nTotal time in milliseconds: {time}");
            }
        }
    }


