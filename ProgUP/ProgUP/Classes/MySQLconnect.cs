using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ProgUP.classes
{
    public class MySQLconnect
    {
        static string connctionstring = @"Database = gaidatabase; DataSource = localhost; user = root; password = root; charset = utf8";
        static public MySqlConnection myconnect;
        static public MySqlCommand msCommand;
        static public MySqlDataAdapter msDataAdapter;
        /// <summary>
        /// Подключение к БД
        /// </summary>
        static public bool BDConnect() 
        {
            try
            {
                myconnect = new MySqlConnection(connctionstring);
                myconnect.Open();
                msCommand = new MySqlCommand();
                msCommand.Connection = myconnect;
                msDataAdapter = new MySqlDataAdapter(msCommand);
                return true;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ошибка при подключении к БД");
                return false;
            }
        }
        /// <summary>
        /// Отключение БД
        /// </summary>
        static public void closeBD()
        {
            myconnect.Close();
        }
    }
}
