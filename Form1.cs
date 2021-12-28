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
    public partial class InitialParametersForm : Form
    {
        int roomsi;
        uint chanceai;
        uint chancepi;

        public InitialParametersForm()
        {
            InitializeComponent();
        }

        // Экстренный выход при некорректных данных
        private void ErrorExit()
        {
            MessageBox.Show("Введены некорректные данные", "Ошибка");
            Application.Exit();
        }

        private void checkBox_input_CheckedChanged(object sender, EventArgs e)
        {
            string rooms = textBox_rooms.Text;
            string chancea = textBox_fireChance.Text;
            string chancep = textBox_thiefChance.Text;

            // Если пустые поля
            if (rooms.Length == 0 || chancea.Length == 0 || chancep.Length == 0)
            {
                ErrorExit();
                return;
            }

            // Если комнаты некорректно введены
            foreach (char a in rooms)
            {
                int ai = Convert.ToInt32(a);
                if (ai > 57 || ai < 48)
                {
                    ErrorExit();
                    return;
                }
            }

            // Если процент возгорания некорректно указан
            foreach (char a in chancea)
            {
                int ai = Convert.ToInt32(a);
                if (ai > 57 || ai < 48)
                {
                    ErrorExit();
                    return;
                }
            }

            // Если процент нападения некорректно указан
            foreach (char a in chancep)
            {
                int ai = Convert.ToInt32(a);
                if (ai > 57 || ai < 48)
                {
                    ErrorExit();
                    return;
                }
            }

            roomsi = Convert.ToInt32(rooms);
            chanceai = Convert.ToUInt32(chancea);
            chancepi = Convert.ToUInt32(chancep);

            if (roomsi < 1 || chanceai < 0 || chanceai > 100 || chancepi < 0 || chancepi > 100)
            {
                ErrorExit();
                return;
            }

            if (roomsi > 100)
            {
                MessageBox.Show("Введено слишком много комнат", "Ошибка");
                Application.Exit();
            }

            checkBox_input.Enabled = false;
            button_start.Enabled = true;
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            ApplicationForm form = new ApplicationForm(this.roomsi, this.chanceai, this.chancepi);

            this.Hide();
            form.ShowDialog();

            Application.Exit();
        }

        private void InitialParametersForm_Load(object sender, EventArgs e)
        {

        }
    }
}
