using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgUP.classes
{
    public class AddTable
    {
        /// <summary>
        /// Добавление в таблицу владельцев автотранспорта
        /// </summary>
        /// <param name="firstName">Имя</param>
        /// <param name="secondName">Фамилия</param>
        /// <param name="patronomyc">Отчество</param>
        /// <param name="idDriverRights">Номерв водительских прав</param>
        /// <param name="ownerRegDate">Дата регистрации владельца</param>
        /// <param name="adres">Адрес проживания</param>
        /// <param name="email">Эл. почта</param>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        /// <param name="telephone">Телефон</param>
        /// <returns></returns>
        static public bool AddCarOwner(string firstName, string secondName, string patronomyc, string idDriverRights, string ownerRegDate,
                                       string adres, string email, string login, string password, string telephone)
        {
            try
            {
                DateTime selectedData = Convert.ToDateTime(ownerRegDate);

                MySQLconnect.msCommand.CommandText = $@"INSERT INTO car_owner VALUES(NULL,'{firstName}','{secondName}','{patronomyc}'," +
                                                     $"'{idDriverRights}','{selectedData.ToString("yyyy-MM-dd")}','{adres}','{email}','{login}','{password}'," +
                                                     $"'{telephone}','{0}')";

                if (classes.MySQLconnect.msCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ошибка при добавлении владельца!");
                return false;
            }
        }
        /// <summary>
        /// Добавление нового автотранспорта
        /// </summary>
        /// <param name="pts">ПТС номер</param>
        /// <param name="idmark">Номер марки</param>
        /// <param name="idcolor">Номер цвета</param>
        /// <param name="idowner">Номер владельца</param>
        /// <param name="model">Модель машины</param>
        /// <param name="reliseDate">Дата выпуска</param>
        /// <param name="gosNum">Государственный номер машины</param>
        /// <param name="regDate">Дата регистрации машины</param>
        /// <returns></returns>
        static public bool AddCar(string pts, string idmark, string idcolor, string idowner,
                                  string model, string reliseDate, string gosNum, string regDate)
        {
            try
            {
                DateTime selectedData = Convert.ToDateTime(reliseDate);
                DateTime selectedData1 = Convert.ToDateTime(regDate);

                MySQLconnect.msCommand.CommandText = $@"INSERT INTO cars VALUES('{pts}','{idmark}','{idcolor}'," +
                                                                              $"'{idowner}','{model}','{selectedData.ToString("yyyy-MM-dd")}'," +
                                                                              $"'{gosNum}','{selectedData1.ToString("yyyy-MM-dd")}')";
                if (classes.MySQLconnect.msCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ошибка при добавлении нового ведра!");
                return false;
            }
        }
        /// <summary>
        /// Добавление рапортов
        /// </summary>
        /// <param name="idBadge">Номер значка инспектора</param>
        /// <param name="imcTime">Время совершения инцидента</param>
        /// <param name="datesost">Дата составления рапорта</param>
        /// <param name="idReg">Номер региона</param>
        /// <param name="idowner">Номер владельца машины</param>
        /// <param name="idFine">Номер штрафа</param>
        /// <param name="sum">Сумма штрафа</param>
        /// <param name="plandate">Назначеная дата оплаты</param>
        /// <param name="oplata">Статус оплаты</param>
        /// <returns></returns>
        static public bool AddReport(string idBadge, string imcTime, string datesost, string idReg, string idowner,
                                  string idFine, string sum, string plandate, string oplata)
        {
            try
            {
                DateTime selectedData = Convert.ToDateTime(datesost);
                DateTime selectedData1 = Convert.ToDateTime(plandate);

                MySQLconnect.msCommand.CommandText = $@"INSERT INTO reports VALUES(NULL,'{idBadge}','{imcTime}','{selectedData.ToString("yyyy-MM-dd")}'," +
                                                                                 $"'{idReg}','{idowner}','{idFine}','{sum}'," +
                                                                                 $"'{selectedData1.ToString("yyyy-MM-dd")}', NULL,'{oplata}')";
                if (classes.MySQLconnect.msCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ошибка при добавлении нового отчёта!");
                return false;
            }
        }
        /// <summary>
        /// Для обновления информации о задолжности в таблице владельца
        /// </summary>
        /// <returns></returns>
        static public bool UpdateShtrafSum(string idOwner)
        {
            MySQLconnect.msCommand.CommandText = $@"SELECT sum(sum) FROM reports WHERE idOwner = '{idOwner}' and payed = 'Не оплачено'";

            Object SummaShtraf = MySQLconnect.msCommand.ExecuteScalar();

            MySQLconnect.msCommand.CommandText = $@"UPDATE car_owner SET sumDolg = '{SummaShtraf}' WHERE idOwner = '{idOwner}'";

            if (classes.MySQLconnect.msCommand.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Добавление цветов
        /// </summary>
        /// <param name="color">цвет</param>
        /// <returns></returns>
        public static bool AddColors(string color)
        {
            try
            {
                MySQLconnect.msCommand.CommandText = $@"INSERT INTO car_color VALUES (NULL, '{color}')";

                if (classes.MySQLconnect.msCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ошибка при добавлении нового цвета!");
                return false;
            }
        }
        /// <summary>
        /// Добавление региона
        /// </summary>
        /// <param name="region">регион</param>
        /// <returns></returns>
        public static bool AddRegion(string region)
        {
            try
            {
                MySQLconnect.msCommand.CommandText = $@"INSERT INTO town_region VALUES (NULL, '{region}');";

                if (classes.MySQLconnect.msCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ошибка при добавлении нового региона!");
                return false;
            }
        }
        /// <summary>
        /// Добавление марки
        /// </summary>
        /// <param name="mark">марка</param>
        /// <returns></returns>
        public static bool AddMark(string mark)
        {
            try
            {
                MySQLconnect.msCommand.CommandText = $@"INSERT INTO car_marks VALUES(NULL, {mark});";

                if (classes.MySQLconnect.msCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ошибка при добавлении нового марки!");
                return false;
            }
        }
        /// <summary>
        /// Добавление инспектора
        /// </summary>
        /// <param name="fio">Имя, фамилия, отчество</param>
        /// <param name="adres">Адрес проживания</param>
        /// <param name="telephone">Телефон</param>
        /// <param name="birtDate">Дата рождения</param>
        /// <returns></returns>
        public static bool AddInpector(string fio, string adres, string telephone, string birtDate)
        {
            DateTime selectedData = Convert.ToDateTime(birtDate);

            MySQLconnect.msCommand.CommandText = $@"INSERT INTO inspectors VALUES (NULL, '{fio}', '{adres}', '{telephone}', '{selectedData.ToString("yyyy-MM-dd")}')";

            if (classes.MySQLconnect.msCommand.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Добавление штрафа
        /// </summary>
        /// <param name="describeFine">В чём накасячил водила</param>
        /// <param name="type">тип</param>
        /// <param name="atention">предупреждение на лишение прав</param>
        /// <param name="rightDep">лишаем прав?</param>
        /// <returns></returns>
        public static bool AddFine(string id, string describeFine, string type, string atention, string rightDep, string srok)
        {
            MySQLconnect.msCommand.CommandText = $@"INSERT INTO fine_category VALUES ({id}, '{describeFine}', '{type}', '{atention}', '{rightDep}', '{srok}')";

            if (classes.MySQLconnect.msCommand.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Добавление оператора
        /// </summary>
        /// <param name="fio">Имя, фамилия, отчество</param>
        /// <param name="login">логин</param>
        /// <param name="password">пароль</param>
        /// <returns></returns>
        public static bool AddOperator(string fio, string login, string password)
        {
            try
            {
                MySQLconnect.msCommand.CommandText = $@"INSERT INTO operators (`fio`, `login`, `password`) VALUES ('{fio}', '{login}', '{password}')";

                if (classes.MySQLconnect.msCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ошибка при добавлении нового оператора!");
                return false;
            }
        }
    }
}
