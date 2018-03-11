using System;

namespace RaceCars
{
    class Car
    {
        //properties
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
            Location = 0;
            Fuel = 22;
            Speed = 210;
            Make = "ZR1";
            Model = "Corvette";
            Color = "Electic Blue";
            Year = 2019;
            PixelsPerGallon = 50;
        }
        public Car(float _location, float _speed, float _fuel, string _make, string _model, 
                   int _year, float _ppg, string _color)
        {
            Location = _location;
            PixelsPerGallon = _ppg;
            Speed = _speed;
            Fuel = _fuel;
            Make = _make;
            Model = _model;
            Year = _year;
            Color = _color;
        }
    
        public void Drive() {
            if(Fuel > 0)
            {
                Location += Speed;
                Fuel -= Speed / PixelsPerGallon;
                Console.WriteLine("Your car is {0} pixels from the start!", Location);
                Console.WriteLine("Yoou  have {0} gallons of fuel remaining!", Fuel);
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
            Car Luke = new Car(0, 200, 21, "Dodge", "Viper", 2017, 50, "Sebring Orange");

            while(Luke.Location < RACE_LENGTH && Luke.Fuel > 0)
            {
                Luke.Drive();
            }

        }
    }
}
