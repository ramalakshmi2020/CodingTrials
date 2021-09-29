using System;
using System.Collections.Generic;
namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello: " + name);
            Console.WriteLine("Press Any key to continue");
            Console.ReadLine();
        }
    }
}
