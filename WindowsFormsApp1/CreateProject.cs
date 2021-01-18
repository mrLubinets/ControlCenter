using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class CreateProject
    {
        

        // создание директорий проекта
        public  void create_project(string path, string subpath)
        {

            string path_dir = path;
            string subpath_dir = subpath;
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path_dir);

            if (!dir.Exists)
            {
                dir.Create();
            }
            dir.CreateSubdirectory(subpath);

        }

        // метод для запроса информации по проекту
        public void info_dir_propject(System.IO.DirectoryInfo dir)
        {
            Console.WriteLine($"Название каталога: {dir.Name}");
            Console.WriteLine($"Полное название каталога: {dir.FullName}");
            Console.WriteLine($"Время создания каталога: {dir.CreationTime}");
            Console.WriteLine($"Корневой каталог: {dir.Root}");
        }

        // метод для удаления проекта
        public void delete(System.IO.DirectoryInfo dir)
        {
            try
            {
                dir.Delete(true);
                Console.WriteLine("Каталог удален");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
