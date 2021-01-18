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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //сохранение данных настроек
            Properties.Settings.Default.main_dir_project = textBox1_main_dir.Text;
            //сохранение значений
            Properties.Settings.Default.Save();

            //закрытие формы с настройками
            this.Close();

        }
    }
}
