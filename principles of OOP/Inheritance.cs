using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace principles_of_OOP
{
    internal class Inheritance
    {
        public class Vehicle
        {
            public string Make { get; set; }
            public string Model { get; set; }

            public Vehicle(string make, string model)
            {
                Make = make;
                Model = model;
            }

            public virtual void DisplayInfo()
            {
                Console.WriteLine($"Транспортное средство: {Make} {Model}");
            }
        }

        public class Car : Vehicle
        {
            public int NumberOfDoors { get; set; }

            public Car(string make, string model, int numberOfDoors) : base(make, model)
            {
                NumberOfDoors = numberOfDoors;
            }

            public override void DisplayInfo()
            {
                Console.WriteLine($"Автомобиль: {Make} {Model}, количество дверей: {NumberOfDoors}");
            }
        }

        public class Bicycle : Vehicle
        {
            public bool HasBell { get; set; }

            public Bicycle(string make, string model, bool hasBell) : base(make, model)
            {
                HasBell = hasBell;
            }

            public override void DisplayInfo()
            {
                Console.WriteLine($"Велосипед: {Make} {Model}, имеет ли звонок: {HasBell}");
            }
        }
    }
}
