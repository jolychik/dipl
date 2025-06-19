using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    internal class kart_IUD
    {
        public int AddKart(string id, string developer, string pomesheniya, string kolvo, string data, string name_k, string klass)
        {
            try
            {
                DB.cmd.CommandText = @"SELECT id_dev FROM sp_dev WHERE developer = '" + developer + "'";
                DB.cmd.CommandText = @"SELECT id_pom FROM sp_pomesheniya WHERE pomesheniya = '" + pomesheniya + "'";
                DB.cmd.CommandText = @"SELECT id_naz FROM nazvaniya_kart WHERE name_k = '" + name_k + "'";
                int nomer_dev = (Int32)DB.cmd.ExecuteScalar();
                int nomer_pom = (Int32)DB.cmd.ExecuteScalar();
                int nomer_name_k = (Int32)DB.cmd.ExecuteScalar();
                DB.cmd.CommandText = @"INSERT INTO `karty` VALUES ('" + id + "' ,'" + nomer_dev + "','" + nomer_pom + "','" + kolvo + "', '" + data + "', '" + nomer_name_k + "', '" + klass + "')";
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
        public int UpdKart(string id, string developer, string pomesheniya, string kolvo, string data, string name_k, string klass)
        {
            try
            {
                DB.cmd.CommandText = @"SELECT id_dev FROM sp_dev WHERE developer = '" + developer + "'";
                DB.cmd.CommandText = @"SELECT id_pom FROM sp_pomesheniya WHERE pomesheniya = '" + pomesheniya + "'";
                DB.cmd.CommandText = @"SELECT id_naz FROM nazvaniya_kart WHERE name_k = '" + name_k + "'";
                int nomer_dev = (Int32)DB.cmd.ExecuteScalar();
                int nomer_pom = (Int32)DB.cmd.ExecuteScalar();
                int nomer_name_k = (Int32)DB.cmd.ExecuteScalar();
                DB.cmd.CommandText = @"UPDATE `kart`.`karty` SET `id_dev` = '"+ nomer_dev +"', `id_pom` = '"+ nomer_pom +"', `kolvo` = '"+ kolvo +"', `data_dobav` = '"+ data +"', `id_naz` = '"+ nomer_name_k +"', `klass` = '"+ klass +"' WHERE (`id` = '"+ id +"')";

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
        public int DelKart(string id)
        {
            try
            {
                DB.cmd.CommandText = @"DELETE FROM `karty` WHERE `karty`.`id` = '" + id + "'";
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
