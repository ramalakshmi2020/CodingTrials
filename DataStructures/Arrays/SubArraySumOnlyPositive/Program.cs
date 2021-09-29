using System;
using System.Collections.Generic;

namespace SubArraySumOnlyPositive
{
    class Program
    {
        static List<int> SubArraySumEqualsSPositive(int[] a, int s) {
            List<int> retindex = new List<int>(2);

            //start from the beginning to the end and find the subarray equalling to sum s
            int currentsum = 0;
            int startindex = 0;
            for(int i=0; i<a.Length; i++)
            {
                currentsum += a[i];
                
                while (currentsum > s && startindex <i)
                {
                    currentsum -= a[startindex++];
                }
                if (currentsum == s)
                {
                    retindex.Add(startindex);
                    retindex.Add(i);
                    break;

                }
                if(i == a.Length -1)
                {
                    retindex.Add(-1);
                }
            }
            return retindex;
        
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] a = { 1, 2, 3, 7, 5 };
            Console.Write("Subarrayindexes with sum equals 12 for array A[] = {1,2,3,7,5} is ");
            List<int> li = SubArraySumEqualsSPositive(a, 12);
            foreach(int i in li)
            Console.Write("{0} ",i);
        }
    }
}
