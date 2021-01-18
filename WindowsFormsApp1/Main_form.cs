using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();
            label1.Text = Properties.Settings.Default.name;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string subpath = @"J:\OneDrive\Actual\job\0_2021\_Test"; //+ {Properties.Settings.Default.number_project}
            DirectoryInfo dirInfo = new DirectoryInfo(subpath);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            dirInfo.CreateSubdirectory(subpath);
            
            MessageBox.Show("Проект успешно создан");
        }

        private void button4_Click(object sender, EventArgs e)
        {    //как удалить подкаталог?
            string dirName = @"C:\SomeDir";
            //что такое трай и катч
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(dirName);
                dirInfo.Delete(true);

                // почему не просто месседж бокс?
                // Console.WriteLine("Проект удален");

                MessageBox.Show("Проект удален");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Путь до папки 
            string path = @"C:\SomeDir";
            // Получаем список всех файлов
            String[] files = System.IO.Directory.GetFiles(path);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Открытие окна регистрации
            Registration registrationForm = new Registration();
            registrationForm.Show();

        }

        
    }
}
