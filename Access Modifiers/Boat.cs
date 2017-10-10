using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    class Boat
    {
        //fields- used to be modified through the program. values to be used the program. put behind properties
        public int numberOfPassengers;

        private string name;
        private double engineSize;

            public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //default constructor
        public Boat()
        {

        }
        public Boat(int numberOfPassengers, string name, double engineSize)
        {
            this.numberOfPassengers = numberOfPassengers;
            this.name = name;
            this.engineSize = engineSize;
        }

        //overloaded constructors
        public void Move()//method (can be accessed from anywhere in the program)
        {
            //code to make boat move
            Console.WriteLine(name + " moves forward.");
        }
        private double CalculateMPG()//method (can only be accessed in this part of the program)
        {
            //code to calculate MPG
            double MPG = engineSize * .45d;
            return MPG;
        }

        public void BoatInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Passengers: " + numberOfPassengers);
            Console.WriteLine("Engine size: " + engineSize);
            Console.WriteLine("MPG: " + CalculateMPG());
            Console.WriteLine("");
        }
    }
}
