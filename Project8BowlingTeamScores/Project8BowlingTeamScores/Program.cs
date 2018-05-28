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
			//the input should be the name followed by 
			//a space and the the score
			do
            {
                Console.Write("Enter a name and a score:");
                line = Console.ReadLine();
                if(line.Length > 0) 
                {
					//Split the user input into name and a score ans store 
					//each in a names and scores array
					string[] values = line.Split();
					names[count] = values[0];

                    int.TryParse(values[1], out scores[count]);
					count++;
                }
				//Run the do loop as long as the user entry is not an 
				//empty line and (&&) the count is less than or equal to 
				//ten
			} while (line != string.Empty && count < MAX_PLAYERS);


            Console.WriteLine("------------INPUT COMPLETE-------------");

            //Print out each player's name and score
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("{0} scored {1} points", names[i], scores[i]);
            }
            //Determine and print out the player with the lowest score 
            //Call the lowScore function
            Console.WriteLine("");
            Console.WriteLine("Congratulations {0} your score of {1} was the highest.",
                             names[HighScore(scores,count)],scores[HighScore(scores, count)]);
            //Determine and print out the average score
            //Call the averageScore function
            Console.WriteLine("");
            Console.WriteLine("{0}, your score of {1} was the lowest, better get some practice.", 
                              names[MinScore(scores,count)], scores[MinScore(scores,count)]);
            //Determine and print out the player with the highest score 
            //Call the HighScore Function
            Console.WriteLine("");
            Console.WriteLine("The average score for this game was {0}",
                              AverageScore(scores, count));
		Console.ReadLine();
        }
 

		public static int HighScore(int[] scores, int count)
        {
            int max = -1;
            int maxdex = -1;
            //loop through the array indexes
            //check to see if ant of the scores
            //are greater than the max
            for (int i = 0; i < count; i++)
            {
                if(max < scores[i])
                {
                    //if the score in the array is larger than 
                    //max then set max = to scores[i[
                    max = scores[i];
                    //set the maxdex to i
                    maxdex = i;
                }
            }
            //send the maxdex back to the main to be used. 
            return maxdex;

        }
        //Returns the minium score index in the scores array
        public static int MinScore(int[] scores, int count)  
        {
            int low = 300;
            int lowdex = 300;
            for (int i = 0; i < count; i++)
            {
                if(low > scores[i])
                {
                    low = scores[i];
                    lowdex = i;
                }
            }
            return lowdex;
        }
        //Returns the average of the bowling scores recorded
        //today
        public static int AverageScore(int[] scores, int count)
        {
            int total = 0;
            int average = 0;
            for (int i = 0; i < count; i++)
            {
                total += scores[i];
            }
            average = total / count;
            return average;
        }

    }


}
