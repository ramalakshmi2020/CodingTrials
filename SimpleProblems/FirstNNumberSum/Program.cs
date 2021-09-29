using System;

namespace FirstNNumberSum
{
    class Program
    {
        static int FindSum(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            else
            {
                return number + FindSum(number - 1);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of natural numbers whose sum to be calculated starting from 1");
            int number = int.Parse(Console.ReadLine());
            while (number <= 0)
            {
                Console.WriteLine("Enter a valid positive number");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The sum of first {0} natural numbers is {1}", number, FindSum(number));
            Console.Read();
        }
    }
}
