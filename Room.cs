using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace security_and_fire_system
{
    public class Room
    {
        public string name { get; }

        public Fire fire { get; }

        public Room(string _name)
        {
            if (_name == null)
            {
                Random r = new Random();
                this.name = "Room " + r.Next() % 100;
            }
            else
                this.name = _name;

            fire = new Fire();
        }

        // Поджечь комнату
        public bool SetFire()
        {
            if (fire.Check())
                return false;

            fire.LightTheFire();
            return true;
        }

        // Включить встроенную систему тушения
        public bool EnableAutomaticExtinguishing()
        {
            if (!fire.Check())
                return false;

            fire.PutOutTheFire();
            return true;
        }

        // Проверить на наличие пожара
        public bool LookForFire()
        {
            return fire.Check();
        }
    }
}
