using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("The Square © Kyler Draper");

            string response = "y";

            while (response == "y")
            {
                Console.WriteLine("Please enter a long word (string):");
                string word = Console.ReadLine();
                Console.WriteLine("____________________________");
                printNormal(word);
                Console.WriteLine("");
                //printDowntoUp(word);
                printUptoDown(word);
                printRighttoLeft(word);
                Console.WriteLine("");
                Console.WriteLine("Again? (y/n)");
                response = Console.ReadLine().ToLower();
            }
        }
        public static void printDowntoUp(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                Console.Write(word[i]);  
            }
        }
        public static void printNormal(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                Console.Write(word[i]);
                
            }
        }
        public static void printUptoDown(string word) 
        {
            for (int i = 1; i < word.Length-1; i++)
            {
                Console.WriteLine(word[i]);
            }
        }
        public static void printRighttoLeft(string word)
        {
            for (int i = word.Length-1; i > -1; i--)
            {
                Console.Write(word[i]);
            }
        }
    }
}
