using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace security_and_fire_system
{
    public class Fire
    {
        private bool burn;

        public Fire()
        {
            this.burn = false;
        }

        // Зажечь
        public bool LightTheFire()
        {
            if (this.burn == true)
                return false;
            else
            {
                this.burn = true;
                return true;
            }
        }

        // Потушить
        public bool PutOutTheFire()
        {
            if (this.burn == false)
                return false;
            else
            {
                this.burn = false;
                return true;
            }
        }

        public bool Check()
        {
            return burn;
        }
    }
}
