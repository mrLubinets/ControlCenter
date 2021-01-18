using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_form());

            string cs = @"server=OGCS666;userid=app_test;password=12909043Ee;database=project";
            //using var con = new MySqlConnection(cs); нужна 8 версия или более компилятора C#
            MySqlConnection con = new MySqlConnection(cs);
            con.Open();
            Console.WriteLine($"MySQL version : {con.ServerVersion}");

            string sql = "SELECT * FROM project_info";
            var cmd = new MySqlCommand(sql, con);

            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine($"{0}", rdr.GetInt16(0), rdr.GetDateTime(1),
                        rdr.GetDateTime(3));
            }
        }
    }
}
