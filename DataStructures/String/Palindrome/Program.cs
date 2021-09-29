using System;

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
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string to check if it is a Palidrome");
            string input = Console.ReadLine();
            Console.WriteLine(CheckPalindrome(input.ToLower()) ? "The input string is a palindrome" : "The input string is not a palindrome");
            Console.Read();
        }
    }
}
