using System;

namespace Project8BowlingTeamScores
{
    //Possibly create a Plater class here
    class MainClass
    {
        public static void Main(string[] args)
        {
            ProjectHeader();
            Start();
        }
        public static void ProjectHeader() {
            //Change the title of the console
            Console.Title = "Bowling Team Scores - Kyler Draper";
            //Enter the file prologue
            Console.WriteLine("Kyler Draper");
            Console.WriteLine("Computer Programming - B5");
            Console.WriteLine("Bowling Team Scores");
            Console.WriteLine("-------------------------------------------------");

        }
        public static void Start() {

            //declare a constant for the MAX_PLAYERS
            const int MAX_PLAYERS = 10;

            //declare storage variables
            string name;
            string[] names = new string[MAX_PLAYERS];
            int score;
            int[] scores = new int[MAX_PLAYERS];
            int count = 0;
            string line = "";
            //Write a do loop to get the user input 
            do
            {
                Console.Write("Enter a name and a score:");
                line = Console.ReadLine();
                count++;
                //the input should be the name followed by 
                //a spcae and the the score
            } while (line != string.Empty && count < MAX_PLAYERS);
            //Split the user input into name and a score ans store 
            //each in a names and scores array

            //Run the do loop as long as the user entry is not an 
            //empty line and (&&) the count is less than or equal to 
            //ten

            Console.WriteLine("------------INPUT COMPLETE-------------");

            //Print out each player's name and score

            //Determine and print out the player with the highest score 
            //Call the HighScore Function
            //Determine ad print out the player with the lowest score 
            //Call the lowScore function
            //Determine and print out the average score
            //Call the aveScore function
        }
        public static int HighScore(int[] scores, int count)
        {
            int max = -1;
            int maxdex = -1;
            for (int i = 0; i < count; i++)
            {
                if(max < scores[i])
                {
                    max = scores[i];
                    maxdex = i;
                }
            }
            return maxdex;
        }
    }

}
