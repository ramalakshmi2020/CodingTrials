using System;

namespace DigitSum
{
    class Program
    {
        static int DigitSum(int number)
        {
            if (number / 10 == 0)
            {
                return number;
            }
            return number % 10 + DigitSum(number / 10);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a valid integer whose sum of digits to be computed :");
            int number;
            bool valid = int.TryParse(Console.ReadLine(), out number);

            while (!valid)
            {
                Console.WriteLine("Enter a valid integer ");
                valid = int.TryParse(Console.ReadLine(), out number);
            }
            
            Console.WriteLine("The sum of the digits of number {0} is {1}", number, DigitSum(Math.Abs(number)));

        }
    }
}
