using System;
using System.Text;

namespace ReverseWordsinString
{
    class Program
    {
        static string ReverseWords(string s)
        {
            
            StringBuilder sb = new StringBuilder();
            sb.Capacity = s.Length;
            int i = s.Length - 1;

           while( i>=0)
            {
                if ((s[i] == ' ')) { i--; continue; }
                //let us start the new word now.. 
                // the end index for the word is i and the start index will be till the next occurance of space
                //add space only if the sb is not empty- we are about to write a new word
               
                int endindex = i;
                while(i>=0)
                {
                    if (s[i] == ' ') break;
                    //the first word
                    i--;
                
                }
                if (sb.Length > 0) sb.Append(' ');
                //found the first word right it
                for (int j=i+1; j<= endindex; j++)
                {
                    sb.Append(s[j]);
                }
               
                
            }
            return sb.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string s = "the sky is blue";
            Console.WriteLine("Reverse words in the string .{0}. is .{1}. ", s, ReverseWords(s));
            s = "  hello world  ";
            Console.WriteLine("Reverse words in the string .{0}. is .{1}. ", s, ReverseWords(s));
            s = "a good   example";
            Console.WriteLine("Reverse words in the string .{0}. is .{1}. ", s, ReverseWords(s));
            s = "  Bob    Loves  Alice   ";
            Console.WriteLine("Reverse words in the string .{0}. is .{1}. ", s, ReverseWords(s));
            s = "Alice does not even like bob";
            Console.WriteLine("Reverse words in the string .{0}. is .{1}. ", s, ReverseWords(s));
            Console.Read();
        }
    }
}
