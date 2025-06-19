using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1.Classes
{
    class DB
    {
        public static string connectionstring = "server= localhost; port=3308; username=root; password=root; database=kart;";
        static MySqlConnection connection;
        static public MySqlCommand cmd;
        static public MySqlDataAdapter adapter;

        static public bool openConnection()
        {
            try
            {
                connection = new MySqlConnection(connectionstring);
                connection.Open();
                System.Windows.Forms.MessageBox.Show("-- 0xc000007b");
                cmd = new MySqlCommand();
                cmd.Connection = connection;
                adapter = new MySqlDataAdapter(cmd);
                return true;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ошибка -- 0xc000007b");
                return false;
            }
        }
        static public bool closeConnection()
        {
            try
            {
                connection = new MySqlConnection(connectionstring);
                connection.Close();
                cmd = new MySqlCommand();
                cmd.Connection = connection;
                adapter = new MySqlDataAdapter(cmd);
                return true;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ошибка -- 0xc000007b");
                return false;
            }
        }
    }
}
