using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace security_and_fire_system
{
    public partial class ApplicationForm : Form
    {
        int roomsi;
        int chancei;
        public ApplicationForm(int roomCounts, int chanceFire)
        {
            InitializeComponent();
            this.roomsi = roomCounts;
            this.chancei = chanceFire;
        }

        private void ApplicationForm_Load(object sender, EventArgs e)
        {
            status_rooms.Text = Convert.ToString(roomsi);
            status_firePercent.Text = Convert.ToString(chancei) + " %";
        }
    }
}
