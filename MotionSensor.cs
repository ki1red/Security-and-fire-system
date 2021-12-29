using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace security_and_fire_system
{
    public class MotionSensor : DefaultSensor
    {
        private bool unauthorizedAccess;
        SayValue ValueForMotionSensor;
        SayValueForRoom ValueFromMotionSensor;

        public MotionSensor(bool _unauthorizedAccess, SayValue ValueForMotionSensor, SayValueForRoom ValueFromMotionSensor)
        {
            unauthorizedAccess = _unauthorizedAccess;
            this.ValueForMotionSensor = ValueForMotionSensor;
            this.ValueFromMotionSensor = ValueFromMotionSensor;
        }

        public void SetNewMotionSensor(bool newUnauthorizedAccess)
        {
            this.unauthorizedAccess = newUnauthorizedAccess;
        }

        public override bool CollectInformation()
        {
            ValueForMotionSensor();
            return unauthorizedAccess;
        }

        public override void EnableProtection()
        {
            unauthorizedAccess = false;
            ValueFromMotionSensor(unauthorizedAccess);
        }
    }
}
