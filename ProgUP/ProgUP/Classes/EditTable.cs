using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgUP.classes
{
    public class EditTable
    {
        /// <summary>
        /// Метод редактирования владельцев автомобилей
        /// </summary>
        /// <param name="idOwner">номер записи/номер владельца</param>
        /// <param name="firstName">Имя</param>
        /// <param name="secondName">Фамилия</param>
        /// <param name="patronomyc">Отчество</param>
        /// <param name="idDriverRights">Номер водительских прав</param>
        /// <param name="ownerRegDate">Дата регистрации владельца</param>
        /// <param name="adres">Адрес проживания</param>
        /// <param name="email">Электронная почта</param>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        /// <param name="telephone">Контактный телефон</param>
        /// <param name="sumDolg">Сумма долгов</param>
        /// <returns></returns>
        static public bool OwnerEdit(string idOwner, string firstName, string secondName, string patronomyc, string idDriverRights, string ownerRegDate,
                                        string adres, string email, string login, string password, string telephone)
        {
            try
            {
                DateTime selectedDate = Convert.ToDateTime(ownerRegDate);

                classes.MySQLconnect.msCommand.CommandText = $@"UPDATE car_owner SET firstName = '{firstName}', secondName = '{secondName}', patronymic = '{patronomyc}'," +
                                                             $"idDriverRights = '{idDriverRights}', ownerRegDate = '{selectedDate.ToString("yyyy-MM-dd")}', adres = '{adres}'" +
                                                             $", email = '{email}', login = '{login}', password = '{password}'" +
                                                             $", telephone = '{telephone}'" +
                                                             $"WHERE idOwner = '{idOwner}';";

                if (classes.MySQLconnect.msCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ошибка при редактировании!");
                return false;
            }
        }
        /// <summary>
        /// Редактирование данных о машинах
        /// </summary>
        /// <param name="PTSnum">Номер ПТС</param>
        /// <param name="idMark">Номер марки</param>
        /// <param name="idColor">Номер цвета</param>
        /// <param name="idowner">Номер владельца</param>
        /// <param name="model">Модель</param>
        /// <param name="reliseDate">Дата выпуска</param>
        /// <param name="gosNum">Гос номер</param>
        /// <param name="regDate">Дата регистрации</param>
        /// <returns></returns>
        static public bool CarEdit(string PTSnum, string idMark, string idColor, string idowner, string model,
                                   string reliseDate, string gosNum, string regDate)
        {
            try
            {
                DateTime selectedDate = Convert.ToDateTime(reliseDate);
                DateTime selectedDate1 = Convert.ToDateTime(regDate);

                classes.MySQLconnect.msCommand.CommandText = $@"UPDATE cars SET idMark = '{idMark}', idColor = '{idColor}', idOwner = '{idowner}'," +
                                                                                        $"model = '{model}', reliseDate = '{selectedDate.ToString("yyyy-MM-dd")}'," +
                                                                                        $"gosNum = '{gosNum}', regDate = '{selectedDate1.ToString("yyyy-MM-dd")}'" +
                                                                                        $"WHERE PTSnum = '{PTSnum }';";

                if (classes.MySQLconnect.msCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ошибка при редактировании!");
                return false;
            }
        }
        
        /// <summary>
        /// Редактирование репорта
        /// </summary>
        /// <param name="idReport"></param>
        /// <param name="idBadge"></param>
        /// <param name="imcTime"></param>
        /// <param name="datesost"></param>
        /// <param name="idReg"></param>
        /// <param name="idowner"></param>
        /// <param name="idFine"></param>
        /// <param name="sum"></param>
        /// <param name="plandate"></param>
        /// <param name="factdate"></param>
        /// <param name="oplat"></param>
        /// <returns></returns>
        static public bool ReportEdit(string idReport, string idBadge, string imcTime, string datesost, string idReg, string idowner,
                                      string idFine, string sum, string plandate, string factdate, string oplat)
        {
            try
            {
                DateTime selectedDate1 = Convert.ToDateTime(datesost);
                DateTime selectedDate2 = Convert.ToDateTime(plandate);
                DateTime selectedDate3 = Convert.ToDateTime(factdate);

                classes.MySQLconnect.msCommand.CommandText =
                    $@"UPDATE reports SET idBadge = '{idBadge}', incidTime = '{imcTime}', incidDate = '{selectedDate1.ToString("yyyy-MM-dd")}'," +
                                                   $"idRegion = '{idReg}', idOwner = '{idowner}'," +
                                                   $"idFine = '{idFine}', sum = '{sum}', planedPayment = '{selectedDate2.ToString("yyyy-MM-dd")}'," +
                                                   $"factPayment = '{selectedDate3.ToString("yyyy-MM-dd")}', payed = '{oplat}'" +
                     $"WHERE idReport = '{idReport}';";

                if (classes.MySQLconnect.msCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ошибка при редактировании!");
                return false;
            }
        }
        /// <summary>
        /// Изменение суммы долга пользователя
        /// </summary>
        /// <param name="own"></param>
        /// <param name="rep"></param>
        /// <returns></returns>
        static public bool DolgEdit(string own, string rep)
        {
            classes.MySQLconnect.msCommand.CommandText = $@"SELECT (car_owner.sumDolg - reports.sum) as razn
                                                           FROM car_owner, reports
                                                           WHERE car_owner.idOwner = '{own}' and reports.idReport = '{rep}'";

            object newDolg = classes.MySQLconnect.msCommand.ExecuteScalar();

            classes.MySQLconnect.msCommand.CommandText = $@"UPDATE car_owner SET sumDolg = '{newDolg}' WHERE idOwner = '{own}'";

            if (classes.MySQLconnect.msCommand.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Редактирование цветов
        /// </summary>
        /// <param name="id"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        static public bool ColorEdit(string id, string color)
        {
            try
            {
                classes.MySQLconnect.msCommand.CommandText =
                    $@"UPDATE car_color SET Color = '{color}' WHERE idColor = '{id}'";

                if (classes.MySQLconnect.msCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ошибка при редактировании!");
                return false;
            }
        }
        /// <summary>
        /// Редактирование регион
        /// </summary>
        /// <param name="id"></param>
        /// <param name="region"></param>
        /// <returns></returns>
        static public bool RegionEdit(string id, string region)
        {
            try
            {
                classes.MySQLconnect.msCommand.CommandText =
                    $@"UPDATE town_region SET region = '{region}' WHERE idRegion = '{id}'";

                if (classes.MySQLconnect.msCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ошибка при редактировании!");
                return false;
            }
        }
        /// <summary>
        /// Редактирование марки
        /// </summary>
        /// <param name="id"></param>
        /// <param name="mark"></param>
        /// <returns></returns>
        static public bool MarkEdit(string id, string mark)
        {
            try
            {
                classes.MySQLconnect.msCommand.CommandText =
                    $@"UPDATE car_marks SET Mark = '{mark}' WHERE idMark = '{id}'";

                if (classes.MySQLconnect.msCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ошибка при редактировании!");
                return false;
            }
        }
        /// <summary>
        /// Редактирование инспекторов
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fio"></param>
        /// <param name="adres"></param>
        /// <param name="telephone"></param>
        /// <param name="birtDate"></param>
        /// <returns></returns>
        static public bool InspectorEdit(string id, string fio, string adres, string telephone, string birtDate)
        {
            try
            {
                DateTime selectedData = Convert.ToDateTime(birtDate);

                classes.MySQLconnect.msCommand.CommandText =
                    $@"UPDATE inspectors SET fio = '{fio}', adres = '{adres}', telephone = '{telephone}', birtDate = '{selectedData.ToString("yyyy-MM-dd")}' WHERE idBadge = '{id}'";

                if (classes.MySQLconnect.msCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ошибка при редактировании!");
                return false;
            }
        }
        /// <summary>
        /// Редактирование штрафов
        /// </summary>
        /// <param name="id"></param>
        /// <param name="describeFine"></param>
        /// <param name="type"></param>
        /// <param name="atention"></param>
        /// <param name="rightDep"></param>
        /// <param name="srok"></param>
        /// <returns></returns>
        static public bool FineEdit(string id, string describeFine, string type, string atention, string rightDep, string srok)
        {
            try
            {
                classes.MySQLconnect.msCommand.CommandText = 
                    $@"UPDATE fine_category SET describeFine = '{describeFine}', type = '{type}', atention = '{atention}', rightDep = '{rightDep}', rightDepActual = '{srok}' WHERE idFine = '{id}'";

                if (classes.MySQLconnect.msCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ошибка при редактировании!");
                return false;
            }
        }
        /// <summary>
        /// Редактирование операторов
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fio"></param>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        static public bool OperatorEdit(string id, string fio, string login, string password)
        {
            try
            {
                classes.MySQLconnect.msCommand.CommandText =
                    $@"UPDATE operators SET fio = '{fio}', login = '{login}', password = '{password}' WHERE idOperator = '{id}'";

                if (classes.MySQLconnect.msCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ошибка при редактировании!");
                return false;
            }
        }
    }
}