using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_Downcasting_Enum__Exception.Task1
{
    public class Hotel
    {
        public string Name { get; }

        private List<Room> Rooms { get; } = new List<Room>();
        public Hotel(string name)
        {
            Name = name;
        }

        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }
        public void MakeReservation(int? roomId)
        {
            if(roomId == null)
            {
                throw new NullReferenceException("Room id cannot be null");
            }
            Room room = null;

            foreach(var r in Rooms)
            {
                if(r.Id == roomId.Value)
                {
                    room = r;
                    break;
                }
            }
            if(room == null)
            {
                throw new ArgumentException("Room with given ID does not exits");
            }
            if (!room.IsAvailable)
            {
                throw new NotAvailableException();
            }

            room.Reverse();

        }
    }
}
