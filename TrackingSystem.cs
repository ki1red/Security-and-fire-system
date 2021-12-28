using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace security_and_fire_system
{

    public class TrackingSystem : IWorkWithList
    {
        private List<SmokeDetector> SmDet;
        private List<MotionSensor> MotSen;

        public TrackingSystem(List<Room> _rooms)
        {
            SmDet = new List<SmokeDetector>();
            MotSen = new List<MotionSensor>();

            foreach (Room i in _rooms)
            {
                SmDet.Add(i.smokeDetector);
                MotSen.Add(i.motionSensor);
            }
        }

        public void AddRoom(Room newRoom)
        {
            SmDet.Add(newRoom.smokeDetector);
            MotSen.Add(newRoom.motionSensor);
        }

        public void AddRooms(List<Room> newRooms)
        {
            foreach (Room i in newRooms)
            {
                SmDet.Add(i.smokeDetector);
                MotSen.Add(i.motionSensor);
            }
        }

        public bool GetValueSmokeDetector(int index)
        {
            return SmDet[index].CollectInformation();
        }

        public bool GetValueMotionSensor(int index)
        {
            return MotSen[index].CollectInformation();
        }

        // Проверить датчики дыма
        public List<bool> CheckSmokeDetector()
        {
            List<bool> res = new List<bool>();
            foreach(SmokeDetector i in SmDet)
            {
                res.Add(i.CollectInformation());
            }
            return res;
        }

        // Проверить датчики движения
        public List<bool> CheckMotionSensor()
        {
            List<bool> res = new List<bool>();
            foreach (MotionSensor i in MotSen)
            {
                res.Add(i.CollectInformation());
            }
            return res;
        }

        // Включить пожарную защиту в комнате
        public void TurnOnTheAlarmAtTheSmokeDetector(int numberRoom)
        {
            SmDet[numberRoom].EnableProtection();
        }

        // Включить охранную защиту в комнате
        public void TurnOnTheAlarmAtTheMotionSensor(int numberRoom)
        {
            MotSen[numberRoom].EnableProtection();
        }
    }

}
