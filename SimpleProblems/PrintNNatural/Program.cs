using System;

namespace SimpleRecursion
{
    class Program
    {
        static void PrintNatural(int start, int number)
        {
            Console.WriteLine(start);
            number--;
            if (number > 0) { PrintNatural(start + 1, number); }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a natural number to start with");
            int startnum = int.Parse(Console.ReadLine());
            Console.WriteLine(" Enter the number of natural numbers to display");
            int number = int.Parse(Console.ReadLine());
            PrintNatural(startnum, number);

        }
    }
}
