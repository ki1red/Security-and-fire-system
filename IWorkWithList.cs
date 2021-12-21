using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace security_and_fire_system
{
    interface IWorkWithList
    {
        void AddRoom(Room newRoom);
        void AddRooms(List<Room> newRooms);
        List<Room> GetList();

    }
}
