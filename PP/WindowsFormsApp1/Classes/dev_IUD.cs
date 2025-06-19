using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1.Classes
{
    class dev_IUD
    {
        public int AddDev(string id_dev, string dev)
        {
            try
            {
                DB.cmd.CommandText = @"INSERT INTO `sp_dev` VALUES ('" + id_dev + "','" + dev + "')";
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
        public int UpdDev(string id_dev, string dev)
        {
            try
            {
                DB.cmd.CommandText = @"UPDATE `sp_dev` SET `developer` = '"+ dev +"' WHERE `sp_dev`.`id_dev` = '"+ id_dev +"'";
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
        public int DelDev(string id_dev)
        {
            try
            {
                DB.cmd.CommandText = @"DELETE FROM `sp_dev` WHERE `sp_dev`.`id_dev` = '"+ id_dev +"'";
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
