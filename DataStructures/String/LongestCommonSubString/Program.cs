using System;

namespace LongestCommonSubString
{
    class Program
    {
        static int LongestCommonSubString(string s1, string s2, out string ss)
        {
            int lcsslength = 0;
            int startindex = 0;
            int[,] dp = new int[s1.Length, s2.Length];
            for(int i =0; i<s1.Length; i++)
            {
                for(int j =0; j<s2.Length; j++)
                {
                    if (s1[i] == s2[j])
                    {
                        //check if the strings are also same
                        if (i > 0 && j > 0)
                        {

                            dp[i, j] = 1 + dp[i - 1, j - 1];
                        }
                        else
                            dp[i, j] = 1;
                        if(lcsslength < dp[i, j])
                        {
                            lcsslength = dp[i, j];
                            startindex = j - lcsslength +1;
                        }
                    }
                    else
                        dp[i, j] = 0;
                }
            }
            ss = s2.Substring(startindex, lcsslength);
            return lcsslength;
        }
        static void Main(string[] args)
        {
            string output;
            Console.WriteLine("The ss string index and length are {0} - {1} ",LongestCommonSubString("efghijabcdef", "abcdef",out output), output);
        }
    }
}
