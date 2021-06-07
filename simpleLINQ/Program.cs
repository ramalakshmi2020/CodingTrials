using System;
using System.Linq;
using System.Collections.Generic;

namespace simpleLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter ane set of integers separated by comma:");
            List<int> input = (Console.ReadLine().Split(',')).Select(int.Parse).ToList();
            var nQuery = from i in input where i % 2 == 0 select i;
            Console.WriteLine("The following is the set of even numbers: ");
            foreach (int output in nQuery) { Console.Write("{0} ", output); }
            Console.WriteLine("\n\n");
        }
    }
}
