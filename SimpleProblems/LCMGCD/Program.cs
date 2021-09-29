using System;

namespace LCMGCDRecursion
{
    class Program
    {
        static int FindGCD(int n1, int n2)
        {
            if (n2 == 0)
            {
                return n1;
            }
            return FindGCD(n2, n1 % n2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the world of GCM and LCD");
            Console.WriteLine("Enter the first number");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int number2 = int.Parse(Console.ReadLine());

            int GCD = FindGCD(number1, number2);
            int LCM = number1 * number2 / GCD;

            Console.WriteLine("The LCM of {0} and {1} is {2}", number1, number2, LCM);
            Console.WriteLine("The GCD of {0} and {1} is {2}", number1, number2, GCD);
            Console.Read();


        }
    }
}
