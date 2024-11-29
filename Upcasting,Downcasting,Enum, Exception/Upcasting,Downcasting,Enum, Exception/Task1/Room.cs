using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_Downcasting_Enum__Exception.Task1
{
    public class Room
    {
        private int _nextId = 1;
        public int Id { get; }

        public string Name { get; }
        public double Price { get; }
        public byte PersonCapacity { get; }

        public bool IsAvailable { get; set; } = false;

        public Room(string name,double price, byte personCapacity)
        {
           Name = name;
            if(price < 0)
            {
                throw new NotAvailableException();
            }
            else
            {
                Price = price;
            }

            PersonCapacity = personCapacity;
            Id = _nextId++;
            
        }

        public void Reverse()
        {
            if(!IsAvailable)
                throw new NotAvailableException();
            IsAvailable = false;
        }

        public void Reserve()
        {
            IsAvailable = true;
        }

        public string ShowInfo()
        {
            return $"Room ID: {Id},Name: {Name},Price: {Price},Person Capacity: {PersonCapacity}, Is Available: {IsAvailable} ";
        }
        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
