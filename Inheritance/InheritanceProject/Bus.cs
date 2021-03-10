using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceProject
{
    class Bus : Vehicle
    {
        public Bus(string name, string color) : base(name, color)
        {

        }
        public Bus(string name, string color, int weight) : base(name, color, weight)
        {

        }
        static void Main()
        {
            Bus bus1 = new Bus("Bus: TATA", "Red");
            Bus bus2 = new Bus("Bus: suzuki", "green", 20);
        }
    }
}
