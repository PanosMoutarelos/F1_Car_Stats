using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Car_Stats
{
    internal class Stats
    {
        private string _teamName = "";
        private int _horsePower = 0;
        private double _weight = 0;
        private int _year = 0;
        private string _constructor = "";
        private string _engineType = "";

        public string TeamName { get => _teamName; set => _teamName = value; }
        public int HorsePower
        {
            get => _horsePower;

            set
            {
                if (value <= 0)
                {

                    Console.WriteLine("Need a number bigger than that");

                }

                else
                {
                    _horsePower = value;
                }
            }
        }

        public double Weight
        {
            get => _weight;


            set
            {

                if (value <= 0)
                {
                    Console.WriteLine("Weight must be a positive number");
                }
                else

                {
                    _weight = value;
                }

            }
        }

        public int Year { get => _year; set => _year = value; }
        public string Constructor { get => _constructor; set => _constructor = value; }
        public string EngineType { get => _engineType; set => _engineType = value; }

        public Stats(string teamName, int horsePower, double weight, int year, string constructor, string engineType)
        {
            TeamName = teamName;
            HorsePower = horsePower;
            Weight = weight;
            Year = year;
            Constructor = constructor;
            EngineType = engineType;
        }

        public double PowerToWeight()
        {
            double PTW = HorsePower / Weight;
            return PTW;
        }


        public void ComparePowerToWeight(Stats otherCar)
        {

            if (this.PowerToWeight() > otherCar.PowerToWeight())

            {
                Console.WriteLine("\n" + this.TeamName + " has bigger power to weight ratio: " + this.PowerToWeight().ToString("F3"));

            }
            else if (this.PowerToWeight() < otherCar.PowerToWeight())
            {
                Console.WriteLine("\n" + otherCar.TeamName + " has bigger power to weight ratio: " + otherCar.PowerToWeight().ToString("F3"));
            }
            else if ((this.PowerToWeight() == otherCar.PowerToWeight()))
            {
                Console.WriteLine("\nBoth cars have the same power to weight ratio");
            }
        }
        public void StatsSummary()
        {
            Console.WriteLine("Team Name: " + this.TeamName);
            Console.WriteLine("HorsePower " + this.HorsePower + " hP");
            Console.WriteLine("Weight: " + this.Weight + "Kg" );
            Console.WriteLine("Year of creation: " + this.Year);
            Console.WriteLine("Location:  " + this.Constructor);
            Console.WriteLine("Engine Type: " + this.EngineType);
            Console.WriteLine($"Power to Weight ratio: {this.PowerToWeight().ToString("F3")} hP/kg\n");
            
        }
    }
}
