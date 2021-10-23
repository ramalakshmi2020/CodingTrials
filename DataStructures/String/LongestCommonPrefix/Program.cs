using System;

namespace LongestCommonPrefix
{
    class Program
    {
        static string LongestCommonPrefix(string[] s)
        {
            //first find the string that has least length
            
            if (s.Length == 1) return s[0][0].ToString();
            string lcp = "";
            //we just need to check the minlength chars of each string adn match them
            for (int j = 0; j< s[0].Length; j++)
            {
                
                char currentchar = s[0][j];
                for(int i=1; i < s.Length; i++)
                {
                    //if the characters dont match - then no prefix
                    if (j >= s[i].Length || s[i][j] != currentchar) { return lcp; }
                    
                }
                //continue only if match found
                lcp += currentchar;
            }
            return lcp;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] s = { "ab", "a"};
            Console.WriteLine(LongestCommonPrefix(s));
        }
    }
}
