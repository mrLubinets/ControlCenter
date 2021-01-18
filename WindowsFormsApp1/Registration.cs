using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //сохранение данных пользователя для работы
            Properties.Settings.Default.surname = textBox1.Text;
            Properties.Settings.Default.name = textBox2.Text;
            Properties.Settings.Default.patronymic = textBox3.Text;
            Properties.Settings.Default.department = textBox4.Text;
            Properties.Settings.Default.position = textBox5.Text;
            Properties.Settings.Default.email = textBox6.Text;
            Properties.Settings.Default.email_password = textBox7.Text;
            //сохранение значений
            Properties.Settings.Default.Save();
        }
    }
}
