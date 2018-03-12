using System;

namespace TheElementsOfGaming_Game_Library
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Start();
        }
        private static void Start()
        {
            Console.Clear();
            Console.WriteLine("Choose a game:");
            Console.WriteLine("1) Dice Game");
            Console.WriteLine("2) Guessings Game");
            Console.WriteLine("3) Higher or Lower");
            Console.WriteLine("4) TicTacToe");
            Console.WriteLine("5) Exit");
            string output = Console.ReadLine();
            if (output == "1" || output == "Dice Game")
            {
                Console.Clear();
                Dice_Game();
            }
            else if (output == "2" || output == "Guessing Game")
            {
                Console.Clear();
                guessing_Game();
            }
            else if (output == "3" || output == "Higher or Lower")
            {
                Console.Clear();
                Higher_Lower();
            }
            else if (output == "4" || output == "TicTacToe")
            {
                Console.Clear();
                TicTacToe();
            }
            else if (output == "5" || output == "Exit")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Start();
            }
        }
        private static void Dice_Game()
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
                        Console.WriteLine("Thank you for playing!!");
                        Console.ReadLine();
                        Start();
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
        private static void guessing_Game()
        {
            Console.Clear();
            Console.WriteLine("Would you like to play the guessing game?");
            string input = Console.ReadLine();
            if (input == "y" || input == "yes")
            {
                
            Console.WriteLine("Guessing game!");

            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);

            int guesses = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10: ");
                string result = Console.ReadLine();
                guesses++;
                    if (result == randomNumber.ToString())
                    {
                        incorrect = false;
                    }
                    else
                    {
                        Console.WriteLine("Wrong!");
                    }
            } while (incorrect);
            Console.WriteLine("Correct! It took you {0} guesses.", guesses);
                Console.ReadLine();
                guessing_Game();
            }
            else
            {
                Start();
            }
        
        }
        private static void Higher_Lower()
        {
            int player1_Num = 0;
            int player2_Guess = 0;

            bool incorrect = true;

            int counter = 0;
            Console.Clear();
            Console.WriteLine("Do you want to play the higher or lower game?");
            string solution = Console.ReadLine();
            if (solution == "y" || solution == "yes")
            {
                    Console.WriteLine("This is a two player game!");
                    Console.WriteLine("Player one what is your name?");
                    string Player1_Name = Console.ReadLine();
                    Console.WriteLine("Player two what is your name?");
                    string Player2_Name = Console.ReadLine();
                    Console.Write("{0} pick a number between 1 and 100:", Player1_Name);
                string result2 = Console.ReadLine();
                int.TryParse(result2, out player1_Num);
                Console.Clear();
                do
                {
                        Console.Write("{0} guess player one's number:", Player2_Name);
                    string player2_result = Console.ReadLine();
                    counter++;
                    int.TryParse(player2_result, out player2_Guess);
                    if (player2_Guess == player1_Num)
                        incorrect = false;
                    else if (player1_Num > 100)
                    {

                            Console.WriteLine("{0} your number can't be greater than 100.", Player1_Name);
                        Console.Write("Pick a new number between 1 amd 100:");
                        result2 = Console.ReadLine();
                        Console.ReadLine();
                       
                    }
                    else if (player1_Num > player2_Guess)
                            Console.WriteLine("{0}'s number is higher!", Player1_Name);
                    else if (player1_Num < player2_Guess)
                            Console.WriteLine("{0}'s number is lower!", Player1_Name);
                    else
                        Console.WriteLine("You broke the game.");
                } while (incorrect);
                    Console.WriteLine("Congrats {0}, you guessed the number right!", Player2_Name);
                    if (counter == 1)
                    {
                        Console.WriteLine("It took you {0} try to guess {1}'s number.", counter, Player1_Name);
                        Console.WriteLine("{0}'s number was {1}.", player1_Num, Player1_Name);
                        Console.WriteLine("Hit enter to continue."); 
                        Console.ReadLine();
                        Higher_Lower();
                    }
                    else
                    {
                        Console.WriteLine("It took you {0} tries to guess {1} number.", counter, Player1_Name);
                        Console.WriteLine("{0}'s number was {1}.", player1_Num, Player1_Name);
                        Console.WriteLine("Hit enter to continue.");
                        Console.ReadLine();
                        Higher_Lower();
                    }
            }
            else if (solution == "n" || solution == "no")
            {
                Console.WriteLine("Thanks for playing!");
                Console.WriteLine("Hit enter to continue");
                Console.ReadLine();
                Start();
            }
            else
            {
                Higher_Lower();
            }
        }
        public static void TicTacToe()
        {
            Console.WriteLine("Do you want to play TicTacToe?");
            string resultTic = Console.ReadLine();
            if (resultTic == "yes" || resultTic == "y")
            {
                Console.WriteLine("WIP" + "Press enter to continue to go back to the start of the game.");
                Console.ReadLine();
                Start();
            }
            else if (resultTic == "no" || resultTic == "n")
            {
                Console.WriteLine("Thanks for playing!");
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                Start();
            }
            else 
            {
                TicTacToe(); 
            }
        }
    }

}
