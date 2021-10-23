using System;

namespace AtoI
{
    class Program
    {
        static int AtoI (string s)
        {
            int res = 0;
            
            int sign = 1;

            int i = 0;
            if(s[i] == '-')
            {
                sign = -1;
                i++;

            }
            for(; i<s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    res = res * 10 + (s[i] - '0');
                    
                }
                else return 0;
            }
            return res * sign;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(AtoI("10029"));
            int val = 65;
            char ch = (char)val;

            Console.WriteLine("{0} converts to '{1}'", val, ch);
        }
    }
}
