using System;
using System.Linq;
using System.Collections.Generic;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a set of integers separated by commas that needs to be sorted");
            string inputStr = Console.ReadLine();
            //This will also take care of removing invalid integers and return an array of valid integers that can be sorted
            int[] inputArray = inputStr.Split(",").Where(m => int.TryParse(m, out _)).Select(m => int.Parse(m)).ToArray();
            // let us sort using insertion sort

            for (int i = 1; i < inputArray.Length; i++)
            {
                int key = inputArray[i];
                int j = i - 1;
                //Compare the key element with all the elements before they key element and insert is appropriately.
                while (j >= 0 && key < inputArray[j])
                {
                    inputArray[j + 1] = inputArray[j];
                    j = j - 1;
                }
                inputArray[j + 1] = key;

            }
            //Print the array
            Console.WriteLine("The array sorted using Insertion sort is ");
            foreach (int elem in inputArray)
            {
                Console.Write("{0} ", elem);
            }
            Console.WriteLine();
        }
    }
}
