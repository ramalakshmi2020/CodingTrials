using System;

namespace sampleOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome the the world of OOP - A small program to demonstrate the OOP Concepts");

            Console.WriteLine("Enter an animal name from the following options: Pig, Duck, Lion");
            string userinput = Console.ReadLine();
            Animal selectedanimal = null;
            switch (userinput.ToLower())
            {
                case "pig":

                    selectedanimal = new Pig("PIG", "OINK");
                    break;
                case "lion":
                    selectedanimal = new Lion("LION", "ROAR");
                    break;

                case "duck":
                    selectedanimal = new Duck("DUCK", "QUACK");
                    break;
                default:
                    Console.WriteLine("Sorry, better luck next time");
                    break;
            }
            if (selectedanimal != null)
            {
                ((IAnimal)selectedanimal).Action();

            }
            Console.Read();
        }
    }
}
