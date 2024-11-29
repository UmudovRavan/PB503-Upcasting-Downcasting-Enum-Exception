using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_Downcasting_Enum__Exception.Task2
{
    public class Car
    {
        private static int _id = 1;
        public int Id { get; }

        public string Brand { get; set; }
        public string Model { get; set; }

        public CarType Type { get; set; }

        public Car(string brand,string model,CarType type)
        {
            Id = _id++;
            Brand = brand;
            Model = model;
            Type = type;

        }

        public override string ToString()
        {
            return $"Car ID: {Id},Brand: {Brand},Model: {Model},Type: {Type}.";
        }
    }
}
