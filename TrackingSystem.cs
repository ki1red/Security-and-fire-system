using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace security_and_fire_system
{
    
        public class TrackingSystem: IWorkWithList
        {
            private List<Room> rooms;

            public TrackingSystem()
                {
                    this.rooms = new List<Room>();
                }

            public void AddRoom(Room newRoom)
                {
                    rooms.Add(newRoom);
                }

            public void AddRooms(List<Room> newRooms)
            {
                rooms.AddRange(newRooms);
            }

            public List<Room> CheckRooms()
                {
                    return rooms;
                }

            // Включить пожарную защиту в комнате
            public bool ExtinguishTheFire(int numberRoom)
                {
                    rooms[numberRoom].EnableAutomaticExtinguishing();
                    return !(rooms[numberRoom].fire.Check());
                }

            public List<Room> GetList()
            {
                return rooms;
            }
        }

}
