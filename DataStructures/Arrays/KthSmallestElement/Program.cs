using System;

namespace KthSmallestElement
{
    class Program
    {
        static int KthSmallestElement(int[] a, int low, int high, int k)               
        {
            if(low == high)
            {
                // found the element - return
                return a[low];
            }
            else
            {
                int pos = Partition(a, low, high);
                if (pos == k - 1) return a[pos];
                if(pos < k - 1) { return KthSmallestElement(a, pos + 1, high, k); }
                return KthSmallestElement(a, low, pos - 1, k);
            }
        }
        static int Partition(int[] arr, int low, int high)
        {
            int i = low - 1;
            int pi = arr[high];
            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pi)
                {
                    i++;
                    swap(arr, i, j);
                }
            }
            swap(arr, i + 1, high);
            return i + 1;
            //code here
        }
        static void swap(int[] a, int i, int j)
        {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] c = { 7, 10, 4, 3, 20, 15 };
            Console.Write("k=3rd Smallest element in aray sum of array [7, 10, 4, 3, 20, 15] is {0}", KthSmallestElement(c, 0, 5,3));
            Console.WriteLine();
            int[] a = { 7, 10, 4, 20, 15 };
            Console.Write("k=4rd Smallest element in aray sum of array [ 7, 10, 4, 20, 15] is {0}", KthSmallestElement(a, 0, 4, 4));
            Console.WriteLine();
        }
    }
}
