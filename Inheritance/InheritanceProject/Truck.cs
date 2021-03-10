using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceProject
{
    class Truck : Vehicle
    {
        public Truck(string name, string color) : base(name, color)
        {

        }
        public Truck(string name, string color, int weight) : base(name, color, weight)
        {

        }
        static void Main()
        {
            Truck truck1 = new Truck("truck", "black");
            Truck truck2 = new Truck("truck2", "gray", 800);
        }
    }
}
