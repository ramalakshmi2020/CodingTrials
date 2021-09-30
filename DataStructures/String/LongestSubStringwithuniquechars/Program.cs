using System;
using System.Collections.Generic;

namespace LongestSubStringwithuniquechars
{
    class Program
    {
        static int LongestSubStringSol1(string s, int[] index)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
          
            int startindex = 0;
            int maxsslength = 0;
            for(int i=0; i<s.Length; i++)
            {
                if (map.ContainsKey(s[i])) startindex = map[s[i]] + 1;
                map[s[i]] = i;
                if(maxsslength < i - startindex + 1)
                {
                    maxsslength = i - startindex + 1;
                    index[0] = startindex;
                    index[1] = i;
                }
            }
            return maxsslength;

        }

        static int LongestSubStringSolconstantspace(string s, int[] index)
        {
            int startindex = 0;
            
            int maxlength = 0;
            for(int currpos = 0; currpos < s.Length; currpos++)
            {
                for (int i = startindex; i < currpos; i++)
                {
                    if (s[i] == s[currpos])
                    {
                        //this will ensure there are no duplicates
                        //reset start index
                        startindex = i+ 1;
                        
                        break;
                    }
                }
                    if(maxlength < currpos - startindex + 1)
                    {
                        //reset max length
                        maxlength = currpos - startindex + 1;
                        index[1] = currpos;
                        index[0] = startindex;
                }
                


            }
            return maxlength;
                
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            int[] index = new int[2];
            int length = LongestSubStringSol1("abcabcbb", index);
            Console.WriteLine("The longest substring length unique characters in string abcabcbb is {0} with startindex {1} and endindex {2} ", length, index[0], index[1]);
            length = LongestSubStringSol1("bbbbb", index);
            Console.WriteLine("The longest substring length unique characters in string bbbbb is {0} with startindex {1} and endindex {2} ", length, index[0], index[1]);
            length = LongestSubStringSol1("pwwkew", index);
            Console.WriteLine("The longest substring length unique characters in string pwwkew is {0} with startindex {1} and endindex {2} ", length, index[0], index[1]);
            index[0] = -1;
            index[1] = -1;
            length = LongestSubStringSol1("", index);
            Console.WriteLine("The longest substring length unique characters an empty string is {0} with startindex {1} and endindex {2} ", length, index[0], index[1]);

            length = LongestSubStringSolconstantspace("abcabcbb", index);
            Console.WriteLine("The longest substring length unique characters(constant space) in string abcabcbb is {0} with startindex {1} and endindex {2} ", length, index[0], index[1]);
            length = LongestSubStringSolconstantspace("bbbbb", index);
            Console.WriteLine("The longest substring length unique characters(constant space) in string bbbbb is {0} with startindex {1} and endindex {2} ", length, index[0], index[1]);
            length = LongestSubStringSolconstantspace("pwwkew", index);
            Console.WriteLine("The longest substring length unique characters(constant space) in string pwwkew is {0} with startindex {1} and endindex {2} ", length, index[0], index[1]);
            index[0] = -1;
            index[1] = -1;
            length = LongestSubStringSolconstantspace("", index);
            Console.WriteLine("The longest substring length unique characters(constant space) an empty string is {0} with startindex {1} and endindex {2} ", length, index[0], index[1]);

            Console.Read();
        }
    }
}
