using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace security_and_fire_system
{
    public partial class ApplicationForm : Form
    {
        int roomsi;
        uint chanceai;
        uint chancepi;
        System.Timers.Timer timer;

        public ApplicationForm(int roomCounts, uint chanceFire, uint chanceOfPenetration)
        {
            InitializeComponent();
            this.roomsi = roomCounts;
            this.chanceai = chanceFire;
            this.chancepi = chanceOfPenetration;
        }

        public void Expectation(object sender, ElapsedEventArgs e)
        {
            pyro.SetFireToTheRooms();
            thief.InfiltrateTheRooms();
            RefreshTable();
        }

        private void ApplicationForm_Load(object sender, EventArgs e)
        {
            status_rooms.Text = Convert.ToString(roomsi);
            status_firePercent.Text = Convert.ToString(chanceai) + " %";
            status_thiefPercent.Text = Convert.ToString(chancepi) + " %";


            GeneralListRooms = new List<Room>();

            CreateRooms();

            pyro = new Pyro(GeneralListRooms);
            pyro.SetChanceOfArson(chanceai);
            thief = new Thief(GeneralListRooms);
            thief.SetChanceOfPenetration(chancepi);

            timer = new System.Timers.Timer(10 * 1000);
            timer.Elapsed += Expectation;
            timer.AutoReset = true;
            timer.Enabled = true;

            
        }

        // Выбор строки в таблице
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int selectedRowCount = dataGridView.CurrentCell.RowIndex;

            if (trackingSystem.GetValueMotionSensor(selectedRowCount))
                button_kickAway.Enabled = true;
            else
                button_kickAway.Enabled = false;

            if (trackingSystem.GetValueSmokeDetector(selectedRowCount))
                button_putOut.Enabled = true;
            else
                button_putOut.Enabled = false;
        }

        private void button_putOut_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dataGridView.CurrentCell.RowIndex;

            trackingSystem.TurnOnTheAlarmAtTheSmokeDetector(selectedRowCount);
            button_putOut.Enabled = false;
            RefreshTable();
        }

        private void button_kickAway_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dataGridView.CurrentCell.RowIndex;

            trackingSystem.TurnOnTheAlarmAtTheMotionSensor(selectedRowCount);
            button_kickAway.Enabled = false;
            RefreshTable();
        }
    }
}