using System;
using System.Collections.Generic;

namespace DectoBin
{
    class Program
    {
        static void DecBin(int n, ref List<int> binarray)
        {
            if (n / 2 == 0)
            {
                binarray.Add(1);
                return;
            }

            binarray.Add(n % 2);
            DecBin(n / 2, ref binarray);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the decimal number to convert to binary");
            int deci = int.Parse(Console.ReadLine());
            List<int> binarray = new List<int>();

            DecBin(deci, ref binarray);
            binarray.Reverse();
            Console.Write("The binary value of {0} is ", deci);
            foreach (int i in binarray) Console.Write(i);
            Console.WriteLine();
        }
    }
}
