using System;

namespace PrimeNumberSum
{
    class Program
    {
        static bool isPrime(int num)
        {
            bool isPrime = true;
            int half = num / 2;
            for (int i = 2; i <= half; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
        static bool isPrimeRecursion(int num, int i)
        {
            if (num == 1)
            { return true; }
            if (num % i == 0) { return false; }
            return isPrimeRecursion(num, i - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("This program will display the sum of first 500 prime numbers");
            long sumPrimeNum = 2; // Initilize the sum with first prime number which is 2
            for (int ctr = 1, num = 3; ctr < 500; num++)
            {
                if (isPrime(num))
                {
                    sumPrimeNum += num;
                    ctr++;
                };

            }
            Console.WriteLine("Sum of first 500 prime numbers is " + sumPrimeNum.ToString());
            Console.WriteLine("Press any key to continue");
            Console.Read();

        }
    }
}
