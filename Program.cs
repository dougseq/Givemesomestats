using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"My Input: {args[0]}");

            Console.WriteLine($"Max number is: {MaxNumber(args[0])} ");
            Console.WriteLine($"Min number is: {MinNumber(args[0])} ");
            Console.WriteLine($"Average number is: {Average(args[0])} ");
            Console.WriteLine($"Std Deviation is: {StdDeviation(args[0])} ");

            Console.ReadLine();
        }
        static int MaxNumber(string input)
        {
            var numbers = input.Split(',');
            return numbers.Max(c => int.Parse(c));
        }
        static int MinNumber(string input)
        {
            var numbers = input.Split(',');
            return numbers.Min(c => int.Parse(c));
        }
        static decimal Average(string input)
        {
            var numbers = input.Split(',');
            return numbers.Average(c => decimal.Parse(c));
        }
        static double StdDeviation(string input)
        {
            double[] doubles = Array.ConvertAll(input.Split(','), new Converter<string, double>(Double.Parse));
            double average = doubles.Average();
            double sumSquareDif = doubles.Select(val => (val - average) * (val * average)).Sum();
            return Math.Sqrt(sumSquareDif / doubles.Length);
        }
    }
}
