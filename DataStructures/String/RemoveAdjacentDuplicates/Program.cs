using System;

namespace RemoveAdjacentDuplicates
{
    class Program
    {
        static string removeConsecutiveCharacter(String s)
        {
            string s2 = "";
            int i = 0;
            
            bool duplicates = false;
            while (i < s.Length)
            {
                bool flag = false;
                int j = i + 1;
                while (j < s.Length && s[i] == s[j])
                {
                    j++;
                    flag = true;
                    duplicates = true;
                }
                if (!flag) { s2+= s[i]; i++; }
                else
                {
                    if ((j - i) % 2 == 1) { s2 += s[i]; }
                    i = j;
                }


            }
            if (duplicates)
                return removeConsecutiveCharacter(s2);
            else return s2;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(removeConsecutiveCharacter("aaaaa"));
        }
    }
}
