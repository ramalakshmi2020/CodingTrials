using System;
using System.Collections.Generic;

namespace Leaders
{
    class Program
    {
        static List<int> Leaders(int[] a)
        {
            List<int> leaders = new List<int>();
            //right element is always leader add it first
            int maxfromright = a[a.Length - 1]; // to begin with
            leaders.Add(maxfromright);

            for (int i = a.Length - 2; i >= 0; i--)
            {
                if ((a[i]) > maxfromright)
                {
                    //a leader since all the elements to the right are less than this
                    leaders.Add(a[i]);
                }
                //update max from right
                maxfromright = Math.Max(maxfromright, a[i]);
            }

            return leaders;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] a = { 1, 2, 3, 4, 0 };
            List<int> leaders = Leaders(a);
            Console.Write("leaders of array { 1, 2, 3, 4, 0 } is ");
            leaders.Reverse();
            foreach (int i in leaders)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
