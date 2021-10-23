using System;
using System.Collections.Generic;

namespace RomantoInt
{
    class Program
    {
        static int RomanToInt(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            map.Add('I', 1);
            map.Add('V', 5);
            map.Add('X', 10);
            map.Add('L', 50);
            map.Add('C', 100);
            map.Add('D', 500);
            map.Add('M', 1000);
            
            int retval = map[s[s.Length -1]];
            for(int i= s.Length -2; i>=0; i--)
            {
                if (map[s[i]] < map[s[i + 1]])
                    retval -= map[s[i]];
                else
                    retval += map[s[i]];
               
            }
            return retval;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter the Roman string to be converted to int: ");
            string s = Console.ReadLine();
            Console.WriteLine("The integer value of Roman string {0} is {1} ", s, RomanToInt(s));
        }
    }
}
