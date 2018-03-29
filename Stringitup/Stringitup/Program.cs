using System;

namespace Stringitup
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           
            Console.WriteLine("Hello World! String it up!");
            Console.Title = "String it up © Kyler Draper";

            string response = "y";

            while (response == "y")
            {
                Console.WriteLine("Please enter a long word (string)c:");
                string word = Console.ReadLine();
                Console.WriteLine("_____________________");
                //print out each character in the word on a separate line 


                //stringitup
                //print out 
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(word);
                    for (int j = 0; j < 2; j++)
                    {
                        Console.Write(" ");
                        Console.Write(word.Substring(word.Length-2, 2));
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Again? (y/n)");
            response = Console.ReadLine().ToLower();
        }
        public static void Backwards(string word) {
            for (int i = word.Length-1; i >= 0; i--)
            {
                Console.WriteLine(word[i]);
            }
        }

        public static void printUptoDown(string word){
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(word[i]);
            }
        }
    }

}