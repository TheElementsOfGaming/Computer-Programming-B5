using System;

namespace Classy
{
    class Fish
    {
        //Data members or properties or attributes
        public string name { get; set; }
        public int numEyes { get; set; }
        public bool canFly { get; set; }

        //Constructors  : Special Functions
        //1. A constructor does not have a return type!
        //2. A constructor is always the same name as the class!
        public Fish()
        {

        }
        //parameterized constructor or overloaded constructor
        public Fish(string _name, int _numEyes, bool _canFly)
        {
            name = _name;
            numEyes = _numEyes;
            canFly = _canFly;
        }

        //Member Methods, functions or behaviors
        public void Swim(int howfar)

        {
            for (int i = 0; i < howfar; i++)
            {
                Console.Write("Just keep swimming!");
            }
        }

        public void flight(int howHigh)
        {
            if (canFly)
            {
                for (int i = 0; i < howHigh; i++)
                {
                    Console.WriteLine("I can fly {0} miles high!", i);
                }
            }
            else
                Console.WriteLine("I'm so sad, I can't fly " + howHigh + " miles high!");
        }
    }
    class MainClass
    {
        public static void printMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void Main(string[] args)
        {
            Fish fish1 = new Fish();
            fish1.name = "Leroy";
            fish1.numEyes = 1;
            fish1.canFly = false;

            fish1.Swim(10);
            fish1.flight(10);
            Fish fish2 = new Fish("Bill", 2, true);

            Console.WriteLine("Hello World!");
            //printMessage("Enter a greeting:");
            //string message = Console.ReadLine();
            //printMessage(message);
        }
    }
}
