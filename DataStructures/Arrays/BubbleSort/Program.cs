using System;
using System.Collections.Generic;
using System.Linq;

namespace bubblesort
{
    class Program
    {
        static void BubbleSortRecursion(int[] intarray, int count)
        {
            if (count == 1)
            {
                //list is already sorted , so return
                return;
            }
            for (int j = 0; j < count - 1; j++)
            {
                if (intarray[j] > intarray[j + 1])
                {
                    int temp = intarray[j];
                    intarray[j] = intarray[j + 1];
                    intarray[j + 1] = temp;
                }
            }
            BubbleSortRecursion(intarray, count - 1);
        }
        static void BubbleSort(int[] inputarray)
        {
            int count = inputarray.Length;
            for (int i = 0; i < count - 1; i++)
            {
                // the last element will always be the largest after every iteration and so doesnt need to be compared!!
                for (int j = 0; j < count - i - 1; j++)
                {
                    //Compare adj elements and swap - this will push the largest element to the end
                    if (inputarray[j] > inputarray[j + 1])
                    {
                        int temp = inputarray[j];
                        inputarray[j] = inputarray[j + 1];
                        inputarray[j + 1] = temp;
                    }
                }

            }
        }

        static void printSorted(int[] sortedarray)
        {
            //Display the array
            foreach (int elem in sortedarray) { Console.Write("{0} ", elem); }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a list of integers separated by comma that will be sorted using Bubble Sort Algorithm");
            string inputStr = Console.ReadLine();
            // This will also take care of correcting the user input and making sure that it has valid values
            int[] inputarray = inputStr.Split(',')
                 .Where(m => int.TryParse(m, out _))
                 .Select(m => int.Parse(m))
                 .ToArray();
            //create a copy of this array to use in bubblesort recursion
            int[] copyarray = new int[inputarray.Length];
            inputarray.CopyTo(copyarray, 0);


            BubbleSort(inputarray);
            Console.WriteLine("\n The sorted array using Bubblesort as follows: ");
            printSorted(inputarray);
            //Recursion
            BubbleSortRecursion(copyarray, copyarray.Length);
            Console.WriteLine("\n\n The sorted array using Bubblesort Recursion as follows: ");
            printSorted(copyarray);
            Console.WriteLine();

        }
    }
}
