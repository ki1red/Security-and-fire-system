using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace security_and_fire_system
{
    interface ISensorOperation
    {
        // Собрать информацию по комнате
        bool CollectInformation();

        // Включить защиту
        void EnableProtection();

    }
}
