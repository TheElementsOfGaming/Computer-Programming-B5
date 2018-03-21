using System;

namespace ArrayPractice
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Array Practice");
            Console.Title = "Array Practice © Kyler Draper";

            const int MAX = 100;
            double Large = 0;

            //1.declare an array of MAX double numbers named dubs
            double[] dubs = new double[MAX];

            //2.declare and instantiate a random number generator named randy
            Random randy = new Random();
            //3.write a for loop to go from 0 to MAX
            for (int i = 0; i < MAX; i++)
            {
                //4.assign a random number between 0 and 200 to 
                //each element in the array (fill up each dixie cup)
                dubs[i] = randy.Next(0, 201);
            }
            //end of for loop

            //5.write a foreach loop that will print out each number 
            //on a separate line
            foreach (double num in dubs)
            {
                if (num > Large)
                    Large = num;
                Console.WriteLine(num);
            }
            //end of foreach loop
            Console.WriteLine("The highest number in the array is {0}",Large);
        }
    }
}