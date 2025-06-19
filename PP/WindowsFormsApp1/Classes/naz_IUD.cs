using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1.Classes
{
    internal class naz_IUD
    {

        public int AddNaz(string id_naz, string name_k, string color, string tip_kart)
        {
            try
            {
                DB.cmd.CommandText = @"SELECT id_tip FROM sp_type_kart WHERE tip_kart = '" + tip_kart + "'";
                int nomer_tip = (Int32)DB.cmd.ExecuteScalar();
                DB.cmd.CommandText = @"INSERT INTO `nazvaniya_kart` VALUES ('" + id_naz + "' ,'" + name_k + "','" + color + "','" + nomer_tip + "')";
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

        public int UpdNaz(string id_naz, string name_k, string color, string tip_kart)
        {
            try
            {
                DB.cmd.CommandText = @"SELECT id_tip FROM sp_type_kart WHERE tip_kart = '" + tip_kart + "'";
                int nomer_tip = (Int32)DB.cmd.ExecuteScalar();
                DB.cmd.CommandText = @"UPDATE `nazvaniya_kart` SET `name_k` = '"+ name_k +"', `color` = '" + color + "', `id_tip` = '" + nomer_tip + "' WHERE `nazvaniya_kart`.`id_naz` = '" + id_naz + "'";
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

        public int DelNaz(string id_naz)
        {
            try
            {
                DB.cmd.CommandText = @"DELETE FROM `nazvaniya_kart` WHERE `nazvaniya_kart`.`id_naz` = '" + id_naz + "'";
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
