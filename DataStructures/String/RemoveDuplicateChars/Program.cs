using System;
using System.Linq;

namespace RemoveDuplicateChars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string whose duplicate characters should be removed");
            char[] input = Console.ReadLine().ToCharArray();
            char[] output = input.Distinct().ToArray();
            Console.WriteLine("String After removal of duplicates is as follows: ");
            foreach (char ch in output)
            {
                Console.Write(ch);
            }
            Console.WriteLine();

        }
    }
}
