using System;
using System.Collections.Generic;

namespace SortArrayByFrequencynIndex
{
    public class data
    {
        public int value;
        public int frequency;
        public int index;
    }
    class Program
    {
        static void SortArrayByFrequency(int[] a)
        {
            Dictionary<int, data> map = new Dictionary<int, data>();

            //update map
            for(int i =0; i<a.Length; i++)
            {
                //update map first
                if (!map.ContainsKey(a[i]))
                {
                    data da = new data { frequency = 0, value = a[i], index = i };
                    map[a[i]] = da;
                }
                map[a[i]].frequency++;
            }
            //now copy values of this map to an array and sort the array and then arrange the array in the order
            data[] arr = new data[map.Count];
            int index = 0;
            foreach (data val in map.Values) arr[index++] = val;
            //now let us sort this array using quicksort
            QuickSort(arr, 0, arr.Length-1);
            //rearrang the elements as per frequency now
            index = 0;
            foreach(data da in arr)
            {
                for (int j = 0; j < da.frequency; j++)
                    a[index++] = da.value;

            }
        }
        static void SortByDecreasingFrequencyusingComparator(int[] a, int n)
        {
            Dictionary<int, int> frequencymap = new Dictionary<int, int>();
            Dictionary<int, int> indexmap = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                if (frequencymap.ContainsKey(a[i]))
                {
                    frequencymap[a[i]]++;

                }
                else frequencymap[a[i]] = 1;
                if (!indexmap.ContainsKey(a[i]))
                {
                    indexmap[a[i]] = i;
                }
            }
            Array.Sort(a, delegate (int x, int y)
            {
                int freq1 = frequencymap[x];
                int freq2 = frequencymap[y];
                if (freq1 != freq2)
                {
                    return freq2 - freq1;

                }
                return indexmap[x] - indexmap[y];


            });
            //copy dictionary to vector
        }

        static void SortByDecreasingFrequencyusingCustomarray(int[] a, int n)
        {
            Dictionary<int, data> map = new Dictionary<int, data>();

            //update map
            for (int i = 0; i < a.Length ; i++)
            {
                //update map first
                if (!map.ContainsKey(a[i]))
                {
                    data da = new data { frequency = 0, value = a[i], index = i };
                    map[a[i]] = da;
                }
                map[a[i]].frequency++;
            }
            //now copy values of this map to an array and sort the array and then arrange the array in the order
            data[] arr = new data[map.Count];
            int index = 0;
            foreach (data val in map.Values) arr[index++] = val;
            Array.Sort(arr, delegate (data x, data y)
            {
                int freq1 = x.frequency;
                int freq2 = y.frequency;
                if (freq1 != freq2)
                {
                    return freq2 - freq1;

                }
                return x.index - y.index;


            });
            index = 0;
            foreach (data da in arr)
            {
                for (int j = 0; j < da.frequency; j++)
                    a[index++] = da.value;

            }
        }
        static void QuickSort(data[] arr, int low, int high)
        {
            if (low < high)
            {
                int pos = Partition(arr, low, high);
                QuickSort(arr, low, pos - 1);
                QuickSort(arr, pos + 1, high);
            }
        }
        static int Partition(data[] arr, int low, int high)
        {
            int i = low - 1;
            data pi = arr[high];
            for (int j = low; j<high; j++)
            {
                if(arr[j].frequency > pi.frequency)
                {
                    //frequency more should go to the left of pivot elemetn so swap
                    i++;
                    Swap(arr, i, j);
                }else 
                if(arr[j].frequency == pi.frequency)
                {
                    if(arr[j].index < pi.index)
                    {
                        i++;
                        Swap(arr, i, j);
                    }
                }
                //postition of pivot is i+1
                

            }
            Swap(arr, i + 1, high);
            return i + 1;
        }
        static void Swap(data[] arr, int i, int j)
        {
            data temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] a = { 2, 5, 2, 8, 5, 6, 8, 8 };
            SortArrayByFrequency(a);
            Console.WriteLine("The sorted array by frequency n then by index for [2, 5, 2, 8, 5, 6, 8, 8]   is ");
            foreach (int i in a) Console.Write("{0} ", i);
            int[] b = { 2, 5, 2, 6, -1, 9999999, 5, 8, 8, 8};
            Console.WriteLine();
            SortByDecreasingFrequencyusingCustomarray(b, b.Length);
            Console.WriteLine("The sorted array by frequency n then by index for [ 2, 5, 2, 6, -1, 9999999, 5, 8, 8, 8]  is ");
            foreach (int i in b) Console.Write("{0} ", i);
            int[] C = { 1, 3, 7, 7, 7, 3, 2, 2, 2, 7, 3, 1, 7, 1, 6, 3, 5, 5, 4, 5, 6, 2, 1, 2, 4, 7, 3, 1, 3, 5, 4, 1, 7, 2, 6, 1, 2 };

            SortByDecreasingFrequencyusingComparator(C, C.Length);
            Console.WriteLine("The sorted array by frequency n then by index for [1, 3, 7, 7, 7, 3, 2, 2, 2, 7, 3, 1, 7, 1, 6, 3, 5, 5, 4, 5, 6, 2, 1, 2, 4, 7, 3, 1, 3, 5, 4, 1, 7, 2, 6, 1, 2 ]  is ");
            foreach (int i in C) Console.Write("{0} ", i);
        }
    }
}
