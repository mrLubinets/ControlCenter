using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    class Directory
    {
        public void  RenameDirectory(string path)
        { 
            DirectoryInfo dirInfo = new DirectoryInfo(path);

            // Если данная ссылка существует.
            if (!dirInfo.Exists(path))
            {
                Console.WriteLine(dirPath + " does not exist.");
                Console.Read();

                return;
            }

            Console.WriteLine(dirPath + " exist");


            Console.WriteLine("Please enter a new name for this directory:");

            // String который вводит пользователь.
            // Например: C:/test2/Java
            string newDirname = Console.ReadLine();

            if (newDirname == String.Empty)
            {
                Console.WriteLine("You not enter new directory name. Cancel rename.");
                Console.Read();

                return;
            }

            // Если ссылка, которую вводит пользователь существует.
            if (Directory.Exists(newDirname))
            {
                Console.WriteLine("Cannot rename directory. New directory already exist.");
                Console.Read();

                return;
            }

            // Родительская папка.
            DirectoryInfo parentInfo = Directory.GetParent(newDirname);

            // Создать родительскую папку папки введенной пользователем.
            Directory.CreateDirectory(parentInfo.FullName);

            // Вы можете поменять ссылку (path) папки.
            // но нужно удостовериться, что родительская ссылка новой ссылки существует.
            // (Если нет, исключение DirectoryNotFoundException будет выброшено).
            Directory.Move(dirPath, newDirname);

            if (Directory.Exists(newDirname))
            {
                Console.WriteLine("The directory was renamed to " + newDirname);
            }


            Console.ReadLine();
        
    }
}
