using System;

namespace InheritanceProject
{
    class Vehicle
    {

        public Vehicle(String name, string color)
        {

            Console.WriteLine(name + " " + color);
        }
        public Vehicle(String name, String color, int weight)
        {


            Console.WriteLine(name + " " + color + " " + weight);

        }


        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Vehicle("bike", "blue");
            Vehicle vehicle2 = new Vehicle("Suzuki", "green", 300);

        }
    }
}
