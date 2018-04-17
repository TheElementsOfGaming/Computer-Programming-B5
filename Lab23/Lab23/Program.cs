using System;

namespace Lab23
{
    class MainClass
    {
        const int HALVES = 50;
        const int QUARTERS = 25;
        const int DIMES = 10;
        const int NICKELS = 5;
        const int PENNIES = 1;
        public static void Main(string[] args)
        {
            Console.WriteLine("Kyler Draper");
            Console.WriteLine("Computer Programming B5");
            Console.WriteLine("Lab 23");
            Console.WriteLine("================================================");
            Console.Title = "Lab 23 Passing by Value and Passing by Reference © Kyler Draper";
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            Console.Clear();

            int money; //the value we want to count change for

            Console.WriteLine("I will make change for you.");
            Console.Write("Enter in an amount between 1 and 99: ");
            money = int.Parse(Console.ReadLine( ) );

            Console.WriteLine("For {0} you get:", money);

            Console.WriteLine("{0} halves", ComputeChange(ref money, HALVES));
            Console.WriteLine("{0} quaters", ComputeChange(ref money, QUARTERS));
            Console.WriteLine("{0} dimes", ComputeChange(ref money, DIMES));
            Console.WriteLine("{0} nickels", ComputeChange(ref money, NICKELS));
            Console.WriteLine("{0} pennies\n", ComputeChange(ref money, PENNIES));
            Console.ReadLine();

        }
       static int ComputeChange(ref int changeValue, int coinValue)
        {
            return changeValue;

        }
    }
}