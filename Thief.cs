using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace security_and_fire_system
{
    public class Thief : IWorkWithList
    {
        private List<Room> rooms;
        private uint chanceOfPenetration;

        public Thief(List<Room> _rooms)
        {
            this.rooms = _rooms;
            chanceOfPenetration = 0;
        }

        public void AddRoom(Room newRoom)
        {
            rooms.Add(newRoom);
        }

        public void AddRooms(List<Room> newRooms)
        {
            rooms.AddRange(newRooms);
        }

        // Проникновение в комнаты
        public void InfiltrateTheRooms()
        {
            Random r = new Random();
            uint chance;
            foreach (Room room in rooms)
            {

                chance = Convert.ToUInt32(Math.Abs(r.Next()) % 101);
                if (chance <= chanceOfPenetration)
                    room.EnterTheRoom();
            }
        }

        public void SetChanceOfPenetration(uint percentage)
        {
            this.chanceOfPenetration = percentage;
            if (chanceOfPenetration > 100) chanceOfPenetration = 100;
        }
    }
}
