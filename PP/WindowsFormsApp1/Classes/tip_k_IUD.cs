using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1.Classes
{
    class tip_k_IUD
    {
        public int AddTipK(string id_tip_k, string tip_k)
        {
            try
            {
                DB.cmd.CommandText = @"INSERT INTO `sp_type_kart` VALUES ('" + id_tip_k + "','" + tip_k + "')";
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
        public int UpdTipK(string id_tip_k, string tip_k)
        {
            try
            {
                DB.cmd.CommandText = @"UPDATE `sp_type_kart` SET `tip_kart` = '" + tip_k + "' WHERE `sp_type_kart`.`id_tip` = '" + id_tip_k + "'";
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
        public int DelTipK(string id_tip_k)
        {
            try
            {
                DB.cmd.CommandText = @"DELETE FROM `sp_type_kart` WHERE `sp_type_kart`.`id_tip` = '" + id_tip_k + "'";
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
