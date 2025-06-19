using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ProgUP.classes
{
    public class Autorisation
    {
        static public string user; 
        static public string role;

        /// <summary>
        /// Авторизация
        /// </summary>
        /// <param name="login">Логин конечно</param>
        /// <param name="password">Соответственно пароль</param>
        static public void Autoriz(string login, string password)
        {
            try
            {
                string sql = $@"SELECT fio FROM operators WHERE login = '{login}' AND password = '{password}';";

                MySQLconnect.msCommand.CommandText = sql;

                Object result = MySQLconnect.msCommand.ExecuteScalar();

                if (result != null)
                { 
                    user = result.ToString();
                    role = "operat";
                }
                else  
                {
                    user = null;
                    try
                    {
                        string ownerSQL = $@"SELECT idOwner FROM car_owner WHERE login = '{login}' AND password = '{password}';";

                        MySQLconnect.msCommand.CommandText = ownerSQL; 

                        Object ownerResult = MySQLconnect.msCommand.ExecuteScalar(); 

                        if (ownerResult != null)
                        { 
                            user = ownerResult.ToString();
                            role = "owner";
                        }
                        else 
                        {
                            user = null;
                        }
                    }
                    catch 
                    {
                        System.Windows.Forms.MessageBox.Show("Ошибка при авторизации!");
                    }
                }
            }
            catch   
            {
                System.Windows.Forms.MessageBox.Show("Ошибка при авторизации!");
            }
        }
    }
}