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
    public partial class AddProject : Form
    {
        public AddProject()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Создаю объект для вызова метода создания структуры папок проекта
            CreateProject project = new CreateProject();
           
            //Вызов метода для создания структуры проекта
            project.create_project(
                Properties.Settings.Default.main_dir_project,
                Properties.Settings.Default.dir_project
                );

            //закрытие окна добавления проекта
            this.Close();

            /*
            string subpath = @"J:\OneDrive\Actual\job\0_2021\_Test"; //+ {Properties.Settings.Default.number_project}
            DirectoryInfo dirInfo = new DirectoryInfo(subpath);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            dirInfo.CreateSubdirectory(subpath);
            
            MessageBox.Show("Проект успешно создан");
            */
        }

        private void textBox1_name_project_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.dir_project = textBox1_name_project.Text;
        }
    }
}
