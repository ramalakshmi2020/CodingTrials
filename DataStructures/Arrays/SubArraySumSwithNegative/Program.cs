using System;
using System.Collections.Generic;

namespace SubArraySumSwithNegative
{
    class Program
    {
        //This method will return the number of subarrays matching current sum
        static int SubArraySumEqualsSCount(int[] a, int s)
        {
            int count = 0;
            //the map will maintiant the number of times this sum occured
            Dictionary<int, int> map = new Dictionary<int, int>();
            int currentsum = 0;
            for(int i =0; i<a.Length; i++)
            {
                currentsum += a[i];

                if (currentsum == s) count++;
                if (map.ContainsKey(currentsum - s))
                {
                    count += map[currentsum - s];
                }
                if (!map.ContainsKey(currentsum)) map[currentsum] = 0;
                map[currentsum]++;
            }
           
            return count;
            
        }

        //this method willr eturn the start and end index of 1 subarray matching the given sum
        static List<int> SubArraySumEqualsSwithNegative(int[] a, int s)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            List<int> retindex = new List<int>(2);
            int currentsum = 0;
            for(int i=0; i<a.Length; i++)
            {
                currentsum += a[i];
                if(s==currentsum)
                {
                    //found sum break
                    retindex.Add(0);
                    retindex.Add(i);
                    break;
                }
                if (map.ContainsKey(currentsum - s))
                {
                    retindex.Add(map[currentsum - s] + 1);
                    retindex.Add(i);
                    break;
                }
                if(i == a.Length - 1)
                {
                    retindex.Add(-1);
                }
                
                map[currentsum] = i;
            }

            return retindex;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = { -1, 4, 20, 3, 10, 5 };
            List<int> li = SubArraySumEqualsSwithNegative(arr, 33);
            Console.Write("Subarray (startindex and endindex )with sum equals 33 in array [ -1, 4, 20, 3, 10, 5] is ");
            foreach (int i in li) Console.Write("{0} ", i);
            Console.WriteLine();
            Console.Write("No of subarrays in [10, 2, -2, -20, 10 ] with sum -10 are ");
            int[] a = { 10, 2, -2, -20, 10 };
            Console.Write(SubArraySumEqualsSCount(a, -10));

        }
    }
}
