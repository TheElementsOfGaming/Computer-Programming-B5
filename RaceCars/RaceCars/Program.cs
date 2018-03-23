using System;

namespace RaceCars
{
    public class Car
    {
        //properties
        public string Name { get; set;  }
        public float Speed { get; set; }
        public float Fuel { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public float Location { get; set; }
        public float PixelsPerGallon { get; set; }

        //constructor
        public Car()
        {
            Name = "Finn";
            Location = 0;
            Fuel = 22;
            Speed = 105;
            Make = "Chevy";
            Model = "Corvette ZR1";
            Color = "Electic Blue";
            Year = 2019;
            PixelsPerGallon = 50;
        }
        public Car(float _location, float _speed, float _fuel, string _make, string _model, 
                   int _year, float _ppg, string _color, string _name)
        {
            Name = _name;
            Location = _location;
            PixelsPerGallon = _ppg;
            Speed = _speed;
            Fuel = _fuel;
            Make = _make;
            Model = _model;
            Year = _year;
            Color = _color;
        }
    
        public void Drive(int hazard) {
            if(Fuel > 0)
            {
                switch (hazard)
                {
                    case 1:
                        Console.WriteLine("You hit a pothole. Lose 1 turn!");

                        break;
                    case 2:
                        Console.WriteLine("A bird hit your windshield, slow down");
                        Location += Speed / 2;
                        break;
                    default:
                        Location += Speed;
                        break;

                }
                Location += Speed;
                Fuel -= Speed / PixelsPerGallon;
                Console.WriteLine("{0} is {1} pixels from the start!", Name, Location);
                Console.WriteLine("{0} has {1} gallons of fuel remaining!", Name, Fuel);
            }
            else 
            {
                Console.WriteLine("You are out of fuel... So sad :(");
            }
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello America! Welcome to Race Day!");

            const int RACE_LENGTH = 500;

            Car Phil = new Car();
            Car Luke = new Car(0, 100, 21, "Dodge", "Viper", 2017, 50, "Miami Blue", "Mickey");
            Car Luigi = new Car(0, 75, 25, "Ford", "GT", 1981, 40, "Green", "Melody");
            Car Mario = new Car(0, 65, 21, "Dodge", "Challenger", 2015, 20, "Red", "Marilyn");
            //create an array of cars
            Car[] cars = new Car[4];
            //Add cars to the array
            cars[0] = Phil;
            cars[1] = Luke;
            cars[2] = Luigi;
            cars[3] = Mario;

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine("Make:{0} Model:{1}", cars[i].Make, cars[i].Model);
            }
            //create a random number generator
            Random randy = new Random();
            bool isWinner = false;

            while (!isWinner)
            {
                //race each car
                foreach (Car theCar in cars)
                {
                    if (theCar.Location < RACE_LENGTH && theCar.Fuel > 0)
                    {
                        theCar.Drive(randy.Next(0, 50));

                    }
                    if (theCar.Location >= RACE_LENGTH) {
                        isWinner = true;
                    }
                }
            }
        }
     }
}
