using System;

namespace MaxSubArraySum
{
    class Program
    {
        static long MaxSubArraySum(int[] a)
        {
            long maxSoFar = a[0];
            long maxEndinghere = a[0];
            for(int i = 1; i <a.Length; i++){
                maxEndinghere = Math.Max(a[i], maxEndinghere + a[i]);
                maxSoFar = Math.Max(maxSoFar, maxEndinghere);
            }
            return maxSoFar;
        }

        static long MaxSubArraySum(int[] a, out int[] index)
        {
            long maxSoFar = a[0];
            long maxEndinghere = a[0];
            int startindex = 0;
            int endindex = 0;
            for (int i = 1; i < a.Length; i++)
            {
                maxEndinghere += a[i];
                if(a[i] > maxEndinghere)
                {
                    //restart anopther subarray from this index;
                    startindex = i;
                    //reset maxending here
                    maxEndinghere = a[i];
                }
                //maxEndinghere = Math.Max(a[i], maxEndinghere + a[i]);
                if(maxSoFar < maxEndinghere)
                {
                    maxSoFar = maxEndinghere;
                    endindex = i;
                }
            }
            index = new int[2];
            index[0] = startindex;
            index[1] = endindex;
            return maxSoFar;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] a = { 1, 2, 3, -2, 5 };
            int[] b;
            Console.Write("MAxsubarray sum of array [1, 2, 3, -2, 5]  is {0} ", MaxSubArraySum(a, out b));

            Console.Write("" +
                "with start and end index {0} {1} ", b[0], b[1]);
            Console.WriteLine();
            int[] c = { -1, -2, -3, -4 };
            Console.Write("MAxsubarray sum of array [-1, -2, -3, -4] is {0}", MaxSubArraySum(c));
        }
    }
}
