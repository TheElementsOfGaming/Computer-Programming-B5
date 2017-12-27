using System;


namespace Stalker_2._0
{
    class Program
    {

        static void Main(string[] args)
        {
            //This prints out my project header.
            Print();
            //This waits until you hit enter before it moves on to the next part of the program.
            Console.ReadLine();
            //This clears the console of everything.
            Console.Clear();
            //This starts my program.
            Start2();






        }
        public static void Print()
        {
            //This is my project header for this assignment.
            Console.WriteLine("Kyler Draper");
            Console.WriteLine("Computer Programming 1A");
            Console.WriteLine("Stalker program");
            Console.WriteLine("===============================================================================");
            Console.Title = "Stalker program © Kyler Draper";
        }

        public static void Start2()

        {
            //This program starts out by telling the console to write out Hello my name is Hal. 
            Console.WriteLine("Hello my name is Hal.");
            //It then asks what your age is. 
            Console.WriteLine("What is your name?");
            //It then has you type your first name where it asks and then says it to a string called MyFirstName.
            Console.Write("Type your first name:");
            string MyFirstName;
            MyFirstName = Console.ReadLine();

            //This is the same as the first name part, but it asks for your last name instead. 
            Console.Write("Type your last name:");
            string MyLastName;
            MyLastName = Console.ReadLine();

            //This part of the program tells the console to write Hello Then it gets your first and last name from the strings you created so you so far have the console saying Hello (Person's first and last name!) Then it has the console ask how old you are.
            Console.WriteLine("Hello " + MyFirstName + " " + MyLastName + "!" + " How old are you?");
            //This is the part of the program where you type your age which makes that into a string titled age/.
            Console.Write("Type age here:");
            string age;
            age = Console.ReadLine();
            //This is where I changed the string age into a integer. 
            int Age = Int32.Parse(s: age);
            //I then made another integer called add which added the integer Age with 1; So if you typed in 16 it would add one to it so that would make it 17. 
            int add = Age + 1;

            Console.WriteLine("How much money do you have " + MyFirstName + "?");
            Console.Write("type money here:");
            string money;
            money = Console.ReadLine();

            Console.WriteLine("Thank you " + MyFirstName + "." + " You are almost " + add + " years old and you have $" + money + ".");
            Console.ReadLine();
        }
        /*
         Questions I have to answer 
         1. Q. What data type did you make the variable that holds the person's age? Why did you choose that data type?
            A. So I used the string data type because I already knew how to use it, but I took that string data type and I converted it into a integer so that I could add it will 1. 
         2. Q. When you output the amount of money that the person has, you could have used any of these formatting directives: {2} {2:F2} {2:C} Describe the benefits of using the last one. 

        */
    }
}