using System;

namespace Sort012
{
    class Program
    {
        static void Sort3Distinct(int[] a)
        {
            int l = 0;
            int h = a.Length - 1;
            int m = 0;
            while (l <= h)
            {
                if(a[m] < a[l])
                {
                    // swapping is required and move the low pointer
                    m++;
                    l++;
                }
               // if()
            }
        }
        static void Sort012(int[] a)
        {
            int count0 = 0;
            int count1 = 0;
            int count2 = 0;
            for(int i=0; i<a.Length; i++)
            {
                if (a[i] == 0) count0++;
                if (a[i] == 1) count1++;
                if (a[i] == 2) count2++;
            }
            int index = 0;
            while(count0 > 0)
            {
                a[index++] = 0;
                count0--;
            }
            while (count1 > 0)
            {
                a[index++] = 1;
                count1--;
            }
            while (count2 > 0)
            {
                a[index++] = 2;
                count2--;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] a = { 0, 2, 1, 2, 0 };
            Console.Write("Sorted array of [0, 2, 1, 2, 0] is ");
            Sort012(a);
            foreach (int i in a) Console.Write("{0} ", i);
        }
    }
}
