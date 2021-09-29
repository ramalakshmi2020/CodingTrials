using System;
using System.Linq;

namespace quicksort
{
    class Program
    {
        static void PrintArray(int[] toprint)
        {
            foreach (int elem in toprint)
            {
                Console.Write("{0} ", elem);
            }

        }
        static void Swap(int[] inputarray, int first, int second)
        {
            int temp = inputarray[first];
            inputarray[first] = inputarray[second];
            inputarray[second] = temp;
        }
        static void SelectionSortRecurse(int[] array, int position)
        {
            if (position == array.Length - 1)
            {
                //reached the end of the array no more sorting 
                return;
            }
            int smallest = position;
            for (int j = position + 1; j < array.Length; j++)
            {
                if (array[j] < array[smallest])
                {
                    smallest = j;
                }

                Swap(array, position, smallest);

            }
            Console.WriteLine();
            //Call print to display the first round
            PrintArray(array);
            //Call the same method again - the first element will always be the smallest so can be ignored
            SelectionSortRecurse(array, position + 1);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the set of integers to be sorted separated by comma ");
            string inputStr = Console.ReadLine();

            int[] inputArray = inputStr.Split(",").Where(m => int.TryParse(m, out _)).Select(m => int.Parse(m)).ToArray();
            int[] copyArray = new int[inputArray.Length];
            inputArray.CopyTo(copyArray, 0);
            // Let us do selection sort
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                int smallest = i;
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[j] < inputArray[smallest])
                    {
                        smallest = j;
                    }



                }
                //swap the first element with the smallest element
                Swap(inputArray, i, smallest);
                Console.WriteLine();

                PrintArray(inputArray);
            }
            //print the array now
            Console.WriteLine("\n The array sorted using selection sort algorithm as follows");
            PrintArray(inputArray);

            //Now let us try the same thing in recursion
            Console.WriteLine();
            SelectionSortRecurse(copyArray, 0);
            Console.WriteLine("\n The array sorted using selection sort recursion algorithm as follows");
            PrintArray(copyArray);



        }
    }
}
