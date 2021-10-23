using System;
using System.Text;
using System.Text.RegularExpressions;

namespace PalindromeRecursion
{
    class Program
    {
        static bool CheckPalindrome(string str)
        {
            if (str.Length <= 1) { return true; }
            if (str[0] != str[str.Length - 1]) { return false; }
            else { return CheckPalindrome(str.Substring(1, str.Length - 2)); }




        }
        static bool CheckPalindromenormal(string str)
        {
            bool ispalindrome = true;
                                  
            int left = 0;
            int right = str.Length - 1;
            while (left  < right){
                if(!char.IsLetterOrDigit(str[left]) ){
                    left++;
                    continue;
                }
                if (!char.IsLetterOrDigit(str[right])) {
                    right--;
                    continue;
                }
                if (char.ToLower(str[right]) == char.ToLower(str[left]))
                {
                    right--;
                    left++;

                }else
                {
                    ispalindrome = false;
                    break;

                }
            }

            return ispalindrome;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string to check if it is a Palidrome");
            string input = Console.ReadLine();
            Console.WriteLine(CheckPalindromenormal(input.ToLower()) ? "The input string is a palindrome" : "The input string is not a palindrome");
            Console.Read();
        }
    }
}
