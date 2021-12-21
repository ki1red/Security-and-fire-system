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
        int chancei;

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
            string chance = textBox_fireChance.Text;

            // Если пустые поля
            if (rooms.Length == 0 || chance.Length == 0)
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

            // Если прцоент некорректно указан
            foreach (char a in chance)
            {
                int ai = Convert.ToInt32(a);
                if (ai > 57 || ai < 48)
                {
                    ErrorExit();
                    return;
                }
            }

            roomsi = Convert.ToInt32(rooms);
            chancei = Convert.ToInt32(chance);

            if (roomsi < 1 || chancei < 0 || chancei > 100)
            {
                ErrorExit();
                return;
            }

            if (roomsi > 10)
            {
                MessageBox.Show("Введено слишком много комнат", "Ошибка");
                Application.Exit();
            }

            checkBox_input.Enabled = false;
            button_start.Enabled = true;
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            ApplicationForm form = new ApplicationForm(this.roomsi, this.chancei);
            
            form.ShowDialog();
            this.Close();
        }
    }
}
