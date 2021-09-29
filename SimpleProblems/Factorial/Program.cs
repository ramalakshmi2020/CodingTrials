using System;

namespace Factorial
{
    class Program
    {
        static int Factorial(int num)
        {
            if (num == 0) { return 1; }
            return num * Factorial(num - 1);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to calculate factorial");
            int number;
            number = int.Parse(Console.ReadLine());
            //The number should be greater that 0
            while (number <= 0)
            {
                Console.WriteLine("Enter a valid integer");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("FActorial of number {0} is {1} ", number.ToString(), Factorial(number).ToString());
            Console.Read();
        }
    }
}

