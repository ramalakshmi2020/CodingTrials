// C# program to print all permutations using
// Heap's algorithm
using System;
using System.Collections.Generic;
using System.Text;

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

    static int KthSmallestElement(int[] a, int low, int high, int k)
    {
        if (high == low)
        {
            //if (low == k - 1)
            //{
                return a[low];
            //}
        }else
        {
            int pos = Partition(a, low, high);
            if (pos == k - 1)
            {
                return a[pos];
            }
            if (pos > k - 1)
            {
                return KthSmallestElement(a, low, pos - 1, k);
            }
            else
                return KthSmallestElement(a, pos + 1, high, k);
        }
       // return int.MaxValue;
    }
    static int Partition(int[] a, int low, int high)
    {
        int pi = a[high];
        int i = low - 1;
        for(int j=low; j<high; j++)
        {
            if(a[j] <= pi)
            {
                i++;
                swap(a, i, j);
            }
        }
        swap(a, i + 1, high);
        return i + 1;

    }

    static void swap(int[] a , int i, int j)
    {
        int temp = a[i];
        a[i] = a[j];
        a[j] = temp;
    
    }
    public class data
    {
       public int value;
       public int frequency;
      
    }
    static void SortByDecreasingFrequency(int[] a, int n)
    {
        Dictionary<int, int> frequencymap = new Dictionary<int, int>();
        Dictionary<int, int> indexmap = new Dictionary<int, int>();
        data[] finalarray = new data[frequencymap.Count];

        for(int i = 0; i<n; i++)
        {
            if (!frequencymap.ContainsKey(a[i])){

                frequencymap[a[i]] = 0;

            }
            frequencymap[a[i]]++;
            if (!indexmap.ContainsKey(a[i]))
            {
                indexmap[a[i]] = i;
            }
        }
        //string s;

        Stack<string> st = new Stack<string>();
        StringBuilder sb = new StringBuilder();
        int lengthofString = 0;
        for (int i = 0,j=0; i<j; i++,j++)
        {
            char[] arr;
            string x;
            Convert.ToInt32(x,
        }

            

        
        //for (int i = 0, j = 1;  i < j; i++,j--)

        /*    a.Sort(delegate(int x, int y)
            {
                int freq1 = frequencymap[x];
                int freq2 = frequencymap[y];
                if(freq1 != freq2)
                {
                    return freq1 - freq2;

                }
                return indexmap[x] - indexmap[y];


            });*/

        //copy dictionary to vector

        //sort the array

        quickSort(a, 0, a.Length - 1, frequencymap, indexmap);

    }

    public class data1
    {
        public int frequency;
        public int index;
    }
    public int FirstUniqChar(string s)
    {
        Dictionary<char, data1> map = new Dictionary<char, data1>();
        //Dictionary<char, int> indexmap = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (!map.ContainsKey(s[i]))
            {
                data1 da = new data { frequency = 0, index = i };
                map[s[i]] = da;

            }
            map[s[i]].frequency++;
        }
        int resindex = int.MaxValue;
        foreach (char key in map.Keys)
        {
            if ((map[key].frequency) == 1)
            {
                resindex = Math.Min(resindex, map[key].index);
            }
        }
        if (resindex == int.MaxValue)
        {
            resindex = -1;
        }
        return -1;

    }
    static int Custompartition(int[] arr, int low, int high, Dictionary<int,int> frequencymap, Dictionary<int,int> indexmap)
    {
        int i = low - 1;
        int pi = arr[high];
        int pifreq = frequencymap[pi];

        for (int j = low; j < high; j++)
        {
            int freq1 = frequencymap[arr[j]];
           
            if (freq1 > pifreq)
            {
                i++;
                swap(arr, i, j);

            } 
            else if(freq1 == pifreq)
            {
                if(indexmap[arr[j]] < indexmap[pi])
                {
                    i++;
                    swap(arr, i, j);

                }
            }
            
        }
        swap(arr, i + 1, high);
        return i + 1;
        //code here
    }
    
    //Function to sort an array using quick sort algorithm.
    static void quickSort(int[] arr, int low, int high, Dictionary<int, int> frequencymap, Dictionary<int, int> indexmap)
    {
        //code here
        if (low < high)
        {
            int pos = Custompartition(arr, low, high,frequencymap, indexmap);
            quickSort(arr, low, pos - 1, frequencymap, indexmap);
            quickSort(arr, pos + 1, high, frequencymap, indexmap);
        }
    }

    // Driver code
    public static void Main()
    {

        int[] list  = { 9,9,5,5,2,10,0,5,9};
        // heapPermutation(a, a.Length, a.Length);
        //int small = KthSmallestElement(a, 0, 5, 6);
        SortByDecreasingFrequency(list, 9);
        foreach (int i in list) Console.Write("{0} ", i);
    }
}