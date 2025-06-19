using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgUP.classes
{
    public class DeleteTable
    {
        /// <summary>
        /// Удаление владельца машины
        /// </summary>
        /// <param name="idOwner">Номер владельца</param>
        /// <returns></returns>
        static public bool DeleteOwner(string idOwner)
        {
            try
            {
                classes.MySQLconnect.msCommand.CommandText = $"DELETE FROM car_owner WHERE idOwner = '{idOwner}';";
                if (classes.MySQLconnect.msCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Запись уже используется!");
                return false;
            }
        }
        /// <summary>
        /// Удаление машины
        /// </summary>
        /// <param name="PTSnum">Номер ПТС</param>
        /// <returns></returns>
        static public bool DeleteCar(string PTSnum)
        {
            try
            {
                classes.MySQLconnect.msCommand.CommandText = $"DELETE FROM cars WHERE PTSnum = '{PTSnum }';";
                if (classes.MySQLconnect.msCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Запись уже используется!");
                return false;
            }
        }
        /// <summary>
        /// Удаление рапорта
        /// </summary>
        /// <param name="idReport">Номер рапорта</param>
        /// <returns></returns>
        static public bool DeleteReport(string idReport)
        {
            try
            {
                classes.MySQLconnect.msCommand.CommandText = $"DELETE FROM reports WHERE idReport = '{idReport}';";
                if (classes.MySQLconnect.msCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Запись уже используется!");
                return false;
            }
        }

        static public bool DeleteColor(string id)
        {
            try
            {
                classes.MySQLconnect.msCommand.CommandText = $"DELETE FROM car_color WHERE idColor = '{id}';";
                if (classes.MySQLconnect.msCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Запись уже используется!");
                return false;
            }
        }

        static public bool MarksDelete(string id)
        {
            try
            {
                classes.MySQLconnect.msCommand.CommandText = $"DELETE FROM car_marks WHERE idmark = '{id}';";
                if (classes.MySQLconnect.msCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Запись уже используется!");
                return false;
            }
        }

        static public bool RegionDelete(string id)
        {
            try
            {
                classes.MySQLconnect.msCommand.CommandText = $"DELETE FROM town_region WHERE idregion = '{id}';";
                if (classes.MySQLconnect.msCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Запись уже используется!");
                return false;
            }
        }

        static public bool FineDelete(string id)
        {
            try
            {
                classes.MySQLconnect.msCommand.CommandText = $"DELETE FROM fine_category WHERE idFine = '{id}';";
                if (classes.MySQLconnect.msCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Запись уже используется!");
                return false;
            }
        }

        static public bool InspectorDelete(string id)
        {
            try
            {
                classes.MySQLconnect.msCommand.CommandText = $"DELETE FROM inspectors WHERE idBadge = '{id}';";
                if (classes.MySQLconnect.msCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Запись уже используется!");
                return false;
            }
        }

        static public bool OperatorsDelete(string id)
        {
            try
            {
                classes.MySQLconnect.msCommand.CommandText = $"DELETE FROM inspectors WHERE idBadge = '{id}';";
                if (classes.MySQLconnect.msCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Запись уже используется!");
                return false;
            }
        }
    }
}