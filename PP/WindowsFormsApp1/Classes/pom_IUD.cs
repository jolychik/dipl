using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1.Classes
{
    class pom_IUD
    {
        public int AddPom(string id_pom, string pom)
        {
            try
            {
                DB.cmd.CommandText = @"INSERT INTO `sp_pomesheniya` VALUES ('" + id_pom + "','" + pom + "')";
                if (DB.cmd.ExecuteNonQuery() >= 0)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            catch
            {
                return 2;
            }
        }
        public int UpdPom(string id_pom, string pom)
        {
            try
            {
                DB.cmd.CommandText = @"UPDATE `sp_pomesheniya` SET `pomesheniya` = '" + pom + "' WHERE `sp_pomesheniya`.`id_pom` = '" + id_pom + "'";
                if (DB.cmd.ExecuteNonQuery() >= 0)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            catch
            {
                return 2;
            }
        }
        public int DelPom(string id_pom)
        {
            try
            {
                DB.cmd.CommandText = @"DELETE FROM `sp_pomesheniya` WHERE `sp_pomesheniya`.`id_pom` = '" + id_pom + "'";
                if (DB.cmd.ExecuteNonQuery() >= 0)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            catch
            {
                return 2;
            }
        }
    }
}
