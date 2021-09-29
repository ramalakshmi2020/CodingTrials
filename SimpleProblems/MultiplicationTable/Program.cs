using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Enter the number to display the multiplication table");
            int num;
            bool valid = int.TryParse(Console.ReadLine(), out num);
            while (!valid)
            {
                Console.WriteLine("\n Incorrect value entered. Enter a valid integer");
                valid = int.TryParse(Console.ReadLine(), out num);
            }

            Console.WriteLine("Multiplication table of " + num.ToString());
            int index = 0;
            do
            {
                Console.WriteLine("{0} * {1} = {2}", num, index, num * index);
                index++;

            } while (index <= 10);
            Console.WriteLine("Press Any key to Continue ");
            Console.Read();

        }
    }
}
