using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace security_and_fire_system
{
    public partial class ApplicationForm : Form
    {
        List<Room> GeneralListRooms;
        Pyro pyro;
        Thief thief;
        TrackingSystem trackingSystem;

        public void CreateRooms()
        {

            string[] names = new string[3] { "Комната", "Корпус", "Дом" };

            Random r = new Random();
            for(int i=0;i<roomsi;i++)
            {
                string name = names[r.Next() % 3] + " " + r.Next(15,299);
                Room room = new Room(name);
                GeneralListRooms.Add(room);
                string[] row = new string[3] { room.name, "Дыма нет", "Передвижений нет" };
                dataGridView.Rows.Add(row);
            }

            trackingSystem = new TrackingSystem(GeneralListRooms);

        }

        public void RefreshTable()
        {
            List<bool> smoke = trackingSystem.CheckSmokeDetector();
            List<bool> motions = trackingSystem.CheckMotionSensor();
            int length_T = dataGridView.Rows.Count-1;
            for (int i=0;i< length_T; i++)
            {
                string name = GeneralListRooms[i].name;

                string sm;
                if (smoke[i])
                    sm = "Обнаружен дым";
                else
                    sm = "Дыма нет";

                string mo;
                if (motions[i])
                    mo = "Замечены передвижения";
                else
                    mo = "Передвижений нет";

                if (smoke[i] || motions[i])
                    dataGridView.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                else
                    dataGridView.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.White;

                string[] row = new string[3] { name, sm, mo };
                dataGridView.Rows[i].SetValues(row);
            }
        }


    }
}
