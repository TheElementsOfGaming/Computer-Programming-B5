using System;
using System.Threading;

namespace PixieDust
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();


            Random rng = new Random();
            for (int i = 0; i < 10000000; i++)
            {

                Console.Write(i%2);
                Console.Write((char)rng.Next(175, 256));
                Thread.Sleep(7);

                switch (rng.Next(3))
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Red;


                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;

                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
               
                switch (rng.Next(1,7))
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red;
						if (rng.Next(54 )% 13 == 11)
							Console.Write("Furnace");
                        
                        break;
					case 2:
						Console.ForegroundColor = ConsoleColor.Green;
                        if(rng.Next(123)% 13 == 9)
                            Console.Write("Homecoming");
						break;
					case 3:
						Console.ForegroundColor = ConsoleColor.White;
						if (rng.Next(123 )% 13 == 11)
							Console.Write("Nine");
						break;
					case 4:
						Console.ForegroundColor = ConsoleColor.DarkRed;
						if (rng.Next(123 )% 15 == 9)
							Console.Write("Daybreak");
						break;
					case 5:
						Console.ForegroundColor = ConsoleColor.DarkGreen;
						if (rng.Next(123 % 13) == 11)
							Console.Write("Longing");
						break;
					case 6:
						Console.ForegroundColor = ConsoleColor.Red;
						break;
                    default:
                        break;

                }

            }
        }
    }
}
