using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string to be reversed");
            string input = Console.ReadLine();
            char[] array = input.ToCharArray();
            Array.Reverse(array);
            string reverse = new string(array);

            Console.WriteLine("Reversed string: " + reverse);
            Console.WriteLine("Press any key to continue");
            Console.Read();
        }
    }
}
