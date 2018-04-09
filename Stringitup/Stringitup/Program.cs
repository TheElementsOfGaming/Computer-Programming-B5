using System;

namespace Stringitup
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           
            Console.WriteLine("Hello World! String it up!");
            Console.Title = "StringitUp © Kyler Draper";

            string response = "y";

            while (response == "y")
            {
                Console.WriteLine("Please enter a long word (string):");
                string word = Console.ReadLine();
                Console.WriteLine("_____________________");
                //print out each character in the word on a separate line 


                //stringitup
                //print out 
                    for (int j = 0; j < 3; j++)
                    {
                    Console.Write(word);
                    for (int i = 0; i < 2; i++)
                    {
                        Console.Write(" {0}", word.Substring(word.Length - 2, 2));
                    }
                    Console.WriteLine();
                }
                    Console.WriteLine("I'm on Fire!");
                Console.WriteLine("Again? (y/n)");
                response = Console.ReadLine().ToLower();
            }

            string theWord = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine(" {0}", theWord.Substring(theWord.Length -34, 9));
        }
       /* public static void Backwards(string word) {
            for (int i = word.Length-1; i >= 0; i--)
            {
                Console.WriteLine(word[i]);
            }
        }

        public static void printUptoDown(string word){
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(word[i]);
            } */
        }
    }
