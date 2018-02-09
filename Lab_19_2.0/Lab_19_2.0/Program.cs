using System;

namespace Lab_19_2._0
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //create a random number generator
            Random rng = new Random();
            //create a string named response
            string response;
            //create a counter
            int counter = 0;
            //create a do loop for the whole program.
            do
            {
                //do loop to validate the user’s response of yes(y) or no(n)
                do
                {
                    //Ask the user if they want to roll the dice
                    Console.WriteLine("Do you want to roll the dice?");
                    //Get the users input 
                    response = Console.ReadLine();
                    Console.WriteLine("Invaild response try again!");
                } while (response != "y" && response != "n");
                //if the user answered “yes(y) roll the dice 
                if (response == "y")
                    Console.Clear();
                {
                    //declare two integers die1 and die2
                    int die1, die2;
                    //set the value of die1 to random number between 1 and 6
                    die1 = rng.Next(1, 7);
                    //set the value of die2 to random number between 1 and 6 
                    die2 = rng.Next(1, 7);
                    //if die 1 == die2 == 6 
                    if (die1 == 6 && die2 == 6)
                    {
                        //print out you rolled boxcars
                        counter++;
                        Console.WriteLine("You rolled boxcars!");
                        Console.WriteLine("It took you {0} tries to get boxcars!", counter);
                        counter = 0;
                    }
                    //else if die 1 == die 2 == 1
                    else if (die1 == 1 && die2 == 1)
                    {

                        //print out you rolled snake eyes
                        counter++;
                        Console.WriteLine("You rolled snake eyes!");
                        Console.WriteLine("It took you {0} tries to get snake eyes!", counter);
                        counter = 0;
                    }
                    else if (die1 == die2)
                    {

                        //print out you rolled double numbers
                        Console.WriteLine("You rolled double {0}s", die2);
                        counter++;
                    }
                    else if (response == "n")
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for playing!");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    //else
                    else
                    {
                        //print out you rolled a 5 and 6, replacing the 5 and 6 wilth the real roll values
                        Console.WriteLine("You rolled {0} and a {1}", die1, die2);
                        counter++;
                    }

                }

            } while (response != "n");
         
        }

    }
}

