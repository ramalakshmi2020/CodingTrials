using System;

namespace BintoDec
{
    class Program
    {
        static double toDecimal(long binary, int i = 0)
        {
            // If we reached last character
            if (binary / 10 == 0)
                //reached the end of the binary - just returnt he last digit 
                return (binary % 10) * Math.Pow(2, i);


            return ((binary % 10) * Math.Pow(2, i)) +
                    toDecimal(binary / 10, i + 1);
        }
        static double toDecimal(string binary, int i = 0)
        {
            if (binary.Length == 1)
                //reached the end of the binary - just return the value for the last digit. no need to recurse now 
                return (binary[0] - '0') * Math.Pow(2, i);


            return (Math.Pow(2, i) * (binary[binary.Length - 1] - '0')) +
                    toDecimal(binary.Substring(0, binary.Length - 1), i + 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the world of bits and bytes");
            Console.WriteLine("Enter the binary number to be converted to decimal");

            bool valid;
            string input;
            do
            {
                valid = true;
                input = Console.ReadLine();
                foreach (char c in input)
                {
                    if (c - '0' > 1)
                    {
                        valid = false;
                        Console.WriteLine("Enter a valid binary number");
                        break;
                    }

                }

            } while (!valid);



            //Let us get each index of the string and validate it if it is a binary and put it in an array

            long binarray = Convert.ToInt64(input);
            //First let us validate the input if it is a binary or not;

            Console.WriteLine("The decimal value of {0} using Remainder method is {1}", binarray, toDecimal(binarray, 0));
            Console.WriteLine("The decimal value of {0} using string method is {1}", input, toDecimal(input, 0));



        }
    }
}
