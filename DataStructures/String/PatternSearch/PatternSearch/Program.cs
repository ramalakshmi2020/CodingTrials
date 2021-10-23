using System;

namespace PatternSearch
{
    class Program
    {
        static int Patternsearch(string s1, string s2)
        {
          
            int counter = 0;
            for(int i=0; i<s1.Length; i++)
            {
                if (s2[counter] == s1[i])
                    counter++;
                else
                {
                    if (counter > 0) i -= counter;
                    counter = 0;
                }
                //found the first match
                if(counter == s2.Length)
                {
                    //found the pattern
                    return i - counter +1;
                }
            
            }
            
            return -1;
        }

        static int PatternSearchKMP(string s1, string pat)
        {
            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(pat) || pat.Length > s1.Length) return -1;
            //update KMP Array
            int[] lps = new int[pat.Length];
            lps[0] = 0;
            int index = 0;
            int j = index + 1;
            
            while (j < pat.Length)
            {
                if (pat[j] != pat[index])
                {
                    if(index != 0)
                    {
                        index = lps[index - 1];
                    } else
                    lps[j++] = 0;
                  
                }else
                {
                    lps[j++] = index + 1;
                    index++;
                }
            }
            int patindex = 0;
            int i = 0;
            while(i<s1.Length)
            {
                if(s1[i] == pat[patindex])
                {
                    i++;
                    patindex++;
                }
                else
                {
                    if (patindex != 0)
                    {
                        patindex = lps[patindex - 1];
                    }
                    else i++;
                }
                if(patindex == pat.Length)
                {
                    //pattern found 
                    return i-patindex;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Console.WriteLine(PatternSearchKMP("poiAAACAAAAACkj", "AAACAAAAAC"));
        }
    }
}
