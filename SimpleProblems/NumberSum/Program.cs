using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers whose sum needs to be calculated separated by commas");
            string input = Console.ReadLine();
            /*List<int> numbers = input.Split(',').Select(int.Parse).ToList();
            int output = numbers.Sum();*/
            var intList = input.Split(',')
                 .Where(m => int.TryParse(m, out _))
                 .Select(m => int.Parse(m))
                 .ToList();
            int output = intList.Sum();
            Console.WriteLine("Sum of numbers entered: " + output.ToString());

            Console.WriteLine("Enter Any key to continue");
            Console.Read();

        }
    }
}
