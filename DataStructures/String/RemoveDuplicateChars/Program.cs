using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemoveDuplicateChars
{
    class Program
    {
        static string RemoveDuplicateRecursion(string str, int startindex)
        {
           
            if((startindex == str.Length - 1) || string.IsNullOrEmpty(str)) { return str; }
            int start = startindex;
            //check if duplicate
           while (str[start] == str[start + 1])
            {
                start++;
                if (start == str.Length - 1) break;
               
            }
            if(start == startindex)
            {
                // no duplicates
                startindex++;
            }
            else
            {
                //remoe duplicates adn send the new string
                //from start till start index to be removed
                str = str.Remove(startindex, start - startindex + 1);
                if (startindex > 0) startindex--;
            }
            //call the function recursively
            return RemoveDuplicateRecursion(str, startindex);
        }
        static string removeDuplicates(String str)
        {
            char[] stack = new char[str.Length];
            int i = 0;
            for(int j=0; j<str.Length; j++)
            {
                char ch = str[j];
                if(i>0 && stack[i-1] == ch)
                {
                    i--;
                }
                else
                {
                    stack[i] = ch;
                    i++;
                }
            }
            return new string(stack, 0, i);
        }
        static void printRepeating(int[] arr, int size)
        {
            int i;

            Console.Write("The repeating" +
                          " elements are : ");

            for (i = 0; i < size; i++)
            {
                int j = Math.Abs(arr[i]);
                if (arr[j] >= 0)
                    arr[j] = -arr[j];
                else
                    Console.Write(j + " ");
            }
        }

        static string removeUtil(String str,
                            char last_removed)
        {

            // If length of string is 1 or 0 
            if (str.Length == 0 || str.Length == 1)
                return str;

            // Remove leftmost same characters 
            // and recur for remaining  
            // string 
            if (str[0] == str[1])
            {
                last_removed = str[0];
                while (str.Length > 1 && str[0] ==
                                             str[1])
                    str = str.Substring(1);
                str = str.Substring(1);
                return removeUtil(str, last_removed);
            }

            // At this point, the first 
            // character is definiotely different  
            // from its adjacent. Ignore first 
            // character and recursively  
            // remove characters from remaining string 
            String rem_str = removeUtil(str.Substring(
                          1), last_removed);

            // Check if the first character of 
            // the rem_string matches with  
            // the first character of the original string
            if (rem_str.Length != 0 &&
                     rem_str[0] == str[0])
            {
                last_removed = str[0];

                // Remove first character
                return rem_str.Substring(1);
            }

            // If remaining string becomes 
            // empty and last removed character 
            // is same as first character of 
            // original string. This is needed 
            // for a string like "acbbcddc" 
            if (rem_str.Length == 0 && last_removed ==
                                              str[0])
                return rem_str;

            // If the two first characters 
            // of str and rem_str don't match,  
            // append first character of str 
            // before the first character of 
            // rem_str
            return (str[0] + rem_str);
        }
        private static String removeDuplicates(
    String s, char ch)
        {

            // If length of string is 1 or 0
            if (s == null || s.Length <= 1)
            {
                return s;
            }

            int i = 0;
            while (i < s.Length)
            {
                if (i + 1 < s.Length
                    && s[i] == s[i + 1])
                {
                    int j = i;
                    while (j + 1 < s.Length
                           && s[j] ==
                            s[j + 1])
                    {
                        j++;
                    }
                    char lastChar
                      = i > 0 ? s[i - 1] : ch;

                    string remStr = removeDuplicates(
                      s.Substring(j + 1),
                      lastChar);

                    s = s.Substring(0, i);
                    int k = s.Length, l = 0;

                    // Recursively remove all the adjacent
                    // characters formed by removing the
                    // adjacent characters
                    while (remStr.Length > 0 &&
                           s.Length > 0 &&
                           remStr[0] ==
                           s[s.Length - 1])
                    {

                        // Have to check whether this is the
                        // repeated character that matches the
                        // last char of the parent String
                        while (remStr.Length > 0
                               && remStr[0] != ch
                               && remStr[0]
                               == s[s.Length- 1])
                        {
                            remStr = remStr.Substring(
                              1);
                        }
                        s = s.Substring(0, s.Length - 1);
                    }
                    s = s + remStr;
                    i = j;
                }
                else
                {
                    i++;
                }
            }
            return s;
        }
        static string remove(String str)
        {
            char last_removed = '\0';
            return removeUtil(str, last_removed);
        }

        static string RemoveDuplicateLetters(string s)
        {
            s.IndexOf()
            Dictionary<char, int> map = new Dictionary<char, int>();
            int minSSLength = s.Length;
            int startindex = 0;
            int prevstart = 0;
            int minSSstart = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (map.ContainsKey(s[i]))
                {
                    prevstart = startindex;
                    startindex = map[s[i]] + 1;
                    if (minSSLength > i - startindex + 1)
                    {
                        minSSLength = i - startindex + 1;
                        minSSstart = startindex;

                    }
                    if (minSSLength == i - startindex + 1)
                    {
                        //check the first charater and thenupdate
                        if (s[startindex] < s[prevstart])
                            minSSstart = startindex;
                    }
                }
                map[s[i]] = i;
                //calculate the length now;
               
            }
            return s.Substring(minSSstart, minSSLength);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string whose duplicate characters should be removed");
            //char[] input = Console.ReadLine().ToCharArray();
            //char[] output = input.Distinct().ToArray();
            /*string output = removeDuplicates(Console.ReadLine(), ' ');

            Console.WriteLine("String After removal of duplicates is as follows: ");
             foreach (char ch in output)
             {
                 Console.Write(ch);
             }
             Console.WriteLine();
            /*int[] arr = { 6, 2, 3, 1, 3, 6, 1 };
            int arr_size = arr.Length;

            printRepeating(arr, arr_size);*/
            string output = RemoveDuplicateLetters(Console.ReadLine());

            Console.WriteLine("String After removal of duplicates is as follows: {0} ", output);


        }
    }
}
