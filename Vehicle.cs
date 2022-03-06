using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    class Vehicle
    {
        private string name;
        private string colour;

       public Vehicle(Vehicle a)
        {
            name = a.name;
            colour = a.colour;
        }
        public string detailsofVechicle
        {
            get
            {
                return "Type:" + name.ToString() +
                       "\nColour:" + colour.ToString();
            }

            public static void Main()
        {
            Vehicle v1 = new Vehicle("Car",""Black");

            Vehicle v2 = new Vehicle(v1);
            Console.WriteLine(v2.detailsofVehicle);
        }
        }

    }
}
