using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleOOP
{
    abstract class Animal : IAnimal
    {
        protected string name;
        protected string sound;
        string IAnimal.Name { get { return name; } }
        string IAnimal.Sound { get { return sound; } }
        void IAnimal.Action()
        {
            Console.WriteLine("Animal base: typically overriden by respective derived classes and not to be used");
        }
        //constructor to initialize the name and sound

    }

    class Pig : Animal, IAnimal
    {
        //constructor to initialize name and sound
        public Pig(string n, string s)
        {
            name = n;
            sound = s;
        }
        void IAnimal.Action()
        {
            Console.WriteLine("I am a pig and thank you for choosing me");
            Console.WriteLine("my sound is " + sound);
        }




    }
    class Duck : Animal, IAnimal
    {
        public Duck(string n, string s)
        {
            name = n;
            sound = s;
        }
        void IAnimal.Action()
        {
            Console.WriteLine("I am a duck and I can swim and i can also live in the land for sometime");
            Console.WriteLine("my sound is " + sound);
        }


    }

    class Lion : Animal, IAnimal
    {
        public Lion(string n, string s)
        {
            name = n;
            sound = s;
        }

        void IAnimal.Action()
        {
            Console.WriteLine("I am a lion and I am the king of the forest");
            Console.WriteLine("my sound is " + sound);
        }

    }

}
