using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace security_and_fire_system
{
    public class DefaultSensor
    {
        virtual public bool CollectInformation()
        {
            return true;
        }
        virtual public void EnableProtection()
        {
            return;
        }
    }
}
