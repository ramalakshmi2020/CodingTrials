using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {

        static void PrintNonRepeatingCharactersusingQ(char[] arr)
        {
            
            Queue<char> nrc = new Queue<char>();
            int[] frequency = new int[26];
            for(int i =0; i< arr.Length; i++)
            {
                frequency[arr[i] - 'a']++;
                if(frequency[arr[i] - 'a'] == 1)
                {
                    //add it to the non repeating character queue;
                    nrc.Enqueue(arr[i]);
                }

                //keep popping elements till you reach the end of the queue
                while (nrc.Count > 0)
                {
                    if (frequency[nrc.Peek() - 'a'] > 1)
                        nrc.Dequeue();
                    else break;
                }
                if(nrc.Count == 0) 
                    Console.WriteLine("Adding character at index {0} and the NRC is -1 ", i);
                else
                    Console.WriteLine("Adding character at index {0} and the NRC is {1} ", i, nrc.Peek());
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            char[] arr = { 'a', 'b', 'c', 'a', 'c','b','d','d' };
            PrintNonRepeatingCharactersusingQ(arr);
        }
    }
}
