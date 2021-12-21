using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace security_and_fire_system
{
    public class Pyro: IWorkWithList
    {
        private List<Room> rooms;
        private uint chanceOfArson;

        public Pyro()
        {
            this.rooms = new List<Room>();
            chanceOfArson = 0;
        }

        public void AddRoom(Room newRoom)
        {
            rooms.Add(newRoom);
        }

        public void AddRooms(List<Room> newRooms)
        {
            rooms.AddRange(newRooms);
        }

        public void SetFireToTheRooms()
        {
            Random r = new Random();
            uint chance;
            foreach (Room room in rooms)
            {
                if (room.fire.Check()) continue;

                chance = Convert.ToUInt32(Math.Abs(r.Next()) % 101);
                if (chance <= chanceOfArson)
                    room.SetFire();
            }
        }

        public void SetChanceOfArson(uint percentage)
        {
            this.chanceOfArson = percentage;
            if (chanceOfArson > 100) chanceOfArson = 100;
        }

        public List<Room> GetList()
        {
            return rooms;
        }
    }
}
