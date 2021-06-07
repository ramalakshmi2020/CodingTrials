// C# program to print all permutations using
// Heap's algorithm
using System;

public class GFG
{
    // Prints the array
    static void printArr(int[] a, int n)
    {
        for (int i = 0; i < n; i++)
            Console.Write(a[i] + " ");
        Console.WriteLine();
    }

    // Generating permutation using Heap Algorithm
    static void heapPermutation(int[] a, int size, int n)
    {
        // if size becomes 1 then prints the obtained
        // permutation
        if (size == 1)
            printArr(a, n);

        for (int i = 0; i < size; i++)
        {
            heapPermutation(a, size - 1, n);

            // if size is odd, swap 0th i.e (first) and
            // (size-1)th i.e (last) element
            if (size % 2 == 1)
            {
                int temp = a[0];
                a[0] = a[size - 1];
                a[size - 1] = temp;
            }

            // If size is even, swap ith and
            // (size-1)th i.e (last) element
            else
            {
                int temp = a[i];
                a[i] = a[size - 1];
                a[size - 1] = temp;
            }
        }
    }

    // Driver code
    public static void Main()
    {

        int[] a = { 1, 2, 3 };
        heapPermutation(a, a.Length, a.Length);
    }
}