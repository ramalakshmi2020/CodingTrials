using System;

namespace LongestPalindromeSubstring
{
    class Program
    {
        static int LongestPalindromeSubStringRecursion(string str, int start, int end)
        {
            if (start > end) return 0;
            if (start == end) return 1;
            if(str[start] == str[end])
            {
                //check if the midle string in palindrome
                int length = end - start - 1;
                int lpsremaining = LongestPalindromeSubStringRecursion(str, start + 1, end - 1);
                if (length == lpsremaining)
                {
                    return 2 + lpsremaining;
                }
            }
            return Math.Max(LongestPalindromeSubStringRecursion(str, start + 1, end), LongestPalindromeSubStringRecursion(str, start, end - 1));

        }
        static string LongestPalindromeSubstringDP(string str)
        {
            //decalare an array to store the results as we traverse through the array
            int startindex = 0;
            
            int maxlength = 1;
            bool[,] arr = new bool[str.Length, str.Length];
            //first update the results for all possible substrings of length 1 & 2
            /*for(int i =0; i<str.Length; i++)
            {
                arr[i,i] = true;
                
            }*/
            // now we can traverse the array to find the longest string
            for(int i =str.Length-1; i >=0; i--)
            {
                for (int j = i; j<str.Length; j++)
                {
                    bool ispalindrome = false;
                    //compare i with j first
                    if((str[i] == str[j]))
                       
                    {
                        //for conditions where string length is 1 &2 - these are straightforward boundary cases - so neeed to check in between
                        if (j -i <= 1)
                            ispalindrome = true;
                        else if ((arr[i + 1, j - 1])) ispalindrome = true;
                        //palindrome found - check with max length and update the matrix too
                        if (ispalindrome) {
                            arr[i, j] = true;
                            int len = j - i + 1;
                            if (len >= maxlength)
                            {
                                startindex = i;

                                maxlength = len;
                            }

                        }
                    }   
                }
            }
            return str.Substring(startindex, maxlength);
        }

        static string LongestPalindromeSubstringConstantSpace(string str)
        {
            int startindex = 0;
            
            int maxlps = 1;
            //let us start with one
            for(int i = 1; i<str.Length; i++)
            {
                int low = i -1; 
                int high = i + 1;
                
                while(low >= 0 && high < str.Length && str[low] == str[high])
                {
                    
                        
                        low--;
                        high++;
                        
                    }
                low++;
                high--;
                if(high - low +1 > maxlps)
                {
                    maxlps = high - low + 1;
                    startindex = low;
                }
            
            //for the even palindrome possibility
                low = i-1;
                high = i;
               
                while (low >= 0 && high < str.Length && str[low] == str[high])
                {
                       
                        low--;
                        high++;

                 
                }
                low++;
                high--;
                if (high - low + 1 > maxlps)
                {
                    maxlps = high - low + 1;
                    startindex = low;
                }

            }
            return str.Substring(startindex, maxlps);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(LongestPalindromeSubstringConstantSpace("babad"));
            Console.WriteLine(LongestPalindromeSubstringDP("babad"));
        }
    }
}
