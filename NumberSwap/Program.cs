using System;

namespace NumberSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Number Swap");
            Console.WriteLine(" Enter first number :");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine(" Enter second number :");
            int secondNum = int.Parse(Console.ReadLine());
            int tempNum = firstNum;
            firstNum = secondNum;
            secondNum = tempNum;
            Console.WriteLine("Numbers swapped now, Result as follows");
            Console.WriteLine("First number is " + firstNum.ToString());
            Console.WriteLine("Second number is " + secondNum.ToString());
            Console.WriteLine("Press Any key to Continue");
            Console.ReadLine();

        }
    }
}
