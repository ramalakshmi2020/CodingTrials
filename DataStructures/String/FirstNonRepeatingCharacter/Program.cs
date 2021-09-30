using System;
using System.Collections.Generic;

namespace FirstNonRepeatingCharacter
{
    class Program
    {
        public class data
        {
            public int frequency;
            public int index;
        }
        static char FirstNonRepeatingCharacter(string s)
        {
            Dictionary<char, data> map = new Dictionary<char, data>();
            for(int i=0; i<s.Length; i++)
            {
                if (!map.ContainsKey(s[i])) map[s[i]] = new data { frequency = 0, index = i };
                map[s[i]].frequency++;
            }
            int resindex = int.MaxValue;
            foreach(char c in map.Keys)
            {
                if(map[c].frequency == 1)
                {
                    resindex = Math.Min(resindex, map[c].index);
                }
            }
            if (resindex == int.MaxValue)
            {
                return '$';

            }
            else return s[resindex];
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Frist non repeating character in leetcode is  {0} ", FirstNonRepeatingCharacter("leetcode"));
            Console.WriteLine();
            Console.WriteLine("Frist non repeating character in geeksforgeeks is  {0} ", FirstNonRepeatingCharacter("geeksforgeeks"));
            Console.Read();
        }
    }
}
