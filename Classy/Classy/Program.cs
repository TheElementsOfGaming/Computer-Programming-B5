using System;
using System.Diagnostics;

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
                string message = "just keep swimming! ";
                Voice(message); 
                Console.WriteLine(message);
            }
        }
        public void Voice(string message){
            Process p = Process.Start("/bin/bash", "-c \"say '" + message + "'\" ");
            p.WaitForExit();
            Console.WriteLine(message);

        }
        public void Flight(int howHigh)
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
    class Cat
    {
        public bool canfly { get; set; }
        public void fly(int height)
        {
            if (canfly)
            {
                for (int i = 0; i < height; i++)
                {
                    Console.WriteLine("I can fly {0} miles high!", i);
                }
            }
            else
            {
                Console.WriteLine("I'm so sad, I can't fly " + height + " miles high!");
            }
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
            //Fish fish1 = new Fish();
            //fish1.name = "Leroy";
            //fish1.numEyes = 1;
            //fish1.canFly = true;
            //fish1.Voice("Stop, get some help");

            //fish1.Swim(10);
            //fish1.flight(10);
            //Fish fish2 = new Fish("Bill", 2, false);
            //make fish 2 fly
            //fish2.flight(5);

            Cat cat1 = new Cat();
            cat1.fly(0);


            //Console.WriteLine("Hello World!");
            //printMessage("Enter a greeting:");
            //string message = Console.ReadLine();
            //printMessage(message);
        }
    }
}
