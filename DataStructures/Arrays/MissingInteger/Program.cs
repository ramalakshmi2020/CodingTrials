using System;

namespace MissingInteger
{
    class Program
    {
        static int MissingInteger(int[] a, int n)
        {
            int expectedsum = n * (n + 1) / 2;
            int actualsum = 0;
            foreach (int i in a) actualsum += i;
            return expectedsum - actualsum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] a = { 1, 3, 4, 5 };
            Console.WriteLine("The missing integer in the range 1 - {0} in array [1, 3, 4, 5] is {1} ", 5, MissingInteger(a, 5));
            int[] b = { 1, 3, 4, 5, 2,6,7,8 };
            Console.WriteLine("The missing integer in the range 1 - {0} in array [1, 3, 4, 5, 2,6,7,8] is {1} ", 9, MissingInteger(b, 9));
            Console.Read();
        }
    }
}
