using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace security_and_fire_system
{

    public delegate void SayValue();
    public delegate void SayValueForRoom(bool value);

    public class Room
    {
        public string name { get; }

        private bool burn;
        private bool unauthorizedAccess;
        public event SayValue ValueForSmokeDetector;
        public event SayValue ValueForMotionSensor;
        public event SayValueForRoom ValueFromSmokeDetector;
        public event SayValueForRoom ValueFromMotionSensor;

        public SmokeDetector smokeDetector { get; }
        public MotionSensor motionSensor { get; }

        public Room(string _name)
        {
            if (_name == null)
            {
                Random r = new Random();
                this.name = "Room " + r.Next() % 100;
            }
            else
                this.name = _name;

            burn = false;
            unauthorizedAccess = false;

            ValueForSmokeDetector += SayValueSmokeDetector;
            ValueForMotionSensor += SayValueMotionSensor;
            ValueFromSmokeDetector += SetBurn;
            ValueFromMotionSensor += SetUnauthorizedAccess;


            smokeDetector = new SmokeDetector(burn, ValueForSmokeDetector, ValueFromSmokeDetector);
            motionSensor = new MotionSensor(unauthorizedAccess, ValueForMotionSensor, ValueFromMotionSensor);

        }

        private void SetBurn(bool burn)
        {
            this.burn = burn;
        }

        private void SetUnauthorizedAccess(bool unauthorizedAccess)
        {
            this.unauthorizedAccess = unauthorizedAccess;
        }

        private void SayValueSmokeDetector()
        {
            smokeDetector.SetNewValueBurn(burn);
        }

        private void SayValueMotionSensor()
        {
            motionSensor.SetNewMotionSensor(unauthorizedAccess);
        }

        // Поджечь комнату
        public bool SetFire()
        {
            if (burn)
                return false;

            burn = true;
            return true;
        }

        // Проникнуть в комнату
        public bool EnterTheRoom()
        {
            if (unauthorizedAccess)
                return false;

            unauthorizedAccess = true;
            return true;
        }

    }
}
