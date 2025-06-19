using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProgUP.classes
{
    public class Sort
    {
        static public DataTable FindSecNmTab = new DataTable();
        static public DataTable FindEmailTab = new DataTable();

        static public DataTable FindGosTab = new DataTable();
        static public DataTable FindPTSTab = new DataTable();
        static public DataTable FindModelTab = new DataTable();

        static public DataTable FindFIOTab = new DataTable();
        static public DataTable FindInspTab = new DataTable();

        static public DataTable FindCol = new DataTable();
        static public DataTable FindMar = new DataTable();
        static public DataTable FindReg = new DataTable();

        static public DataTable FindFin = new DataTable();

        static public DataTable FindInpec = new DataTable();
        static public DataTable FindInpecAdres = new DataTable();
        static public DataTable FindInpecTelep = new DataTable();

        static public DataTable FindOperat = new DataTable();
        static public DataTable FindOperatLog = new DataTable();


        #region Sort

        #region FindForOwner

        static public void FindSecName(string stat)
        {
            classes.MySQLconnect.msCommand.CommandText = "SELECT * FROM car_owner WHERE secondName Rlike '^" + stat + "'";

            FindSecNmTab.Clear();
            MySQLconnect.msDataAdapter.Fill(FindSecNmTab);
        }

        static public void FindEmail(string stat)
        {
            classes.MySQLconnect.msCommand.CommandText = "SELECT * FROM car_owner WHERE Email Rlike '^" + stat + "'";

            FindEmailTab.Clear();
            MySQLconnect.msDataAdapter.Fill(FindEmailTab);
        }

        #endregion

        #region FindForCars

        static public void FindGosNum(string stat)
        {
            classes.MySQLconnect.msCommand.CommandText = $@"SELECT cars.PTSnum, car_marks.Mark, car_color.Color, car_owner.secondName, cars.model, cars.reliseDate, cars.gosNum , cars.regDate
                                                           FROM cars, car_marks, car_color, car_owner
                                                           WHERE cars.idColor = car_color.idColor and cars.idMark = car_marks.idMark and cars.idOwner = car_owner.idOwner
                                                                 and gosNum Rlike '^{stat}'";

            FindGosTab.Clear();
            MySQLconnect.msDataAdapter.Fill(FindGosTab);
        }

        static public void FindPTS(string stat)
        {
            classes.MySQLconnect.msCommand.CommandText = $@"SELECT cars.PTSnum, car_marks.Mark, car_color.Color, car_owner.secondName, cars.model, cars.reliseDate, cars.gosNum , cars.regDate
                                                            FROM cars, car_marks, car_color, car_owner
                                                            WHERE cars.idColor = car_color.idColor and cars.idMark = car_marks.idMark and cars.idOwner = car_owner.idOwner
                                                                  and PTSnum Rlike '^{stat}'";

            FindPTSTab.Clear();
            MySQLconnect.msDataAdapter.Fill(FindPTSTab);
        }

        static public void FindModel(string stat)
        {
            classes.MySQLconnect.msCommand.CommandText = $@"SELECT cars.PTSnum, car_marks.Mark, car_color.Color, car_owner.secondName, cars.model, cars.reliseDate, cars.gosNum , cars.regDate
                                                            FROM cars, car_marks, car_color, car_owner
                                                            WHERE cars.idColor = car_color.idColor and cars.idMark = car_marks.idMark and cars.idOwner = car_owner.idOwner
                                                                  and model Rlike '^{stat}'";

            FindModelTab.Clear();
            MySQLconnect.msDataAdapter.Fill(FindModelTab);
        }

        #endregion

        #region FindForReports

        static public void FindFIO(string stat)
        {
            classes.MySQLconnect.msCommand.CommandText =
                   $@"SELECT reports.idReport, inspectors.fio, reports.incidTime, reports.incidDate, town_region.region, 
                             town_region.region, concat(car_owner.secondName,' ',car_owner.firstName,' ',car_owner.patronymic) as driverinfo, fine_category.describeFine,
                             reports.sum, reports.planedPayment, reports.factPayment, reports.payed
                      FROM reports, inspectors, town_region, car_owner, fine_category
                      WHERE inspectors.idBadge = reports.idBadge and town_region.idRegion = reports.idRegion and car_owner.idOwner = reports.idOwner and reports.idFine = fine_category.idFine 
                            and fio Rlike '^{stat}'";

            FindInspTab.Clear();
            MySQLconnect.msDataAdapter.Fill(FindInspTab);
        }

        static public void FindInspector(string stat)
        {
            classes.MySQLconnect.msCommand.CommandText =
                   $@"SELECT reports.idReport, inspectors.fio, reports.incidTime, reports.incidDate, town_region.region, 
                             town_region.region, concat(car_owner.secondName,' ',car_owner.firstName,' ',car_owner.patronymic) as driverinfo, fine_category.describeFine,
                             reports.sum, reports.planedPayment, reports.factPayment, reports.payed
                      FROM reports, inspectors, town_region, car_owner, fine_category
                      WHERE inspectors.idBadge = reports.idBadge and town_region.idRegion = reports.idRegion and car_owner.idOwner = reports.idOwner and reports.idFine = fine_category.idFine 
                            and secondName Rlike '^{stat}'";

            FindFIOTab.Clear();
            MySQLconnect.msDataAdapter.Fill(FindFIOTab);
        }



        #endregion

        static public void FindColor(string stat)
        {
            classes.MySQLconnect.msCommand.CommandText = $@"SELECT * FROM car_color WHERE color Rlike '^{stat}'";

            FindCol.Clear();
            MySQLconnect.msDataAdapter.Fill(FindCol);
        }

        static public void FindMark(string stat)
        {
            classes.MySQLconnect.msCommand.CommandText = $@"SELECT * FROM car_mark WHERE mark Rlike '^{stat}'";

            FindMar.Clear();
            MySQLconnect.msDataAdapter.Fill(FindMar);
        }

        static public void FindRegion(string stat)
        {
            classes.MySQLconnect.msCommand.CommandText = $@"SELECT * FROM town_region WHERE region Rlike '^{stat}'";

            FindReg.Clear();
            MySQLconnect.msDataAdapter.Fill(FindReg);
        }

        static public void FindFine(string stat)
        {
            classes.MySQLconnect.msCommand.CommandText = $@"SELECT * FROM fine_category WHERE describeFine Rlike '^{stat}'";

            FindFin.Clear();
            MySQLconnect.msDataAdapter.Fill(FindFin);
        }

        static public void FindOperator(string stat)
        {
            classes.MySQLconnect.msCommand.CommandText = $@"SELECT * FROM operators WHERE fio Rlike '^{stat}'";

            FindOperat.Clear();
            MySQLconnect.msDataAdapter.Fill(FindOperat);
        }

        static public void FindOperatorLog(string stat)
        {
            classes.MySQLconnect.msCommand.CommandText = $@"SELECT * FROM operators WHERE login Rlike '^{stat}'";

            FindOperatLog.Clear();
            MySQLconnect.msDataAdapter.Fill(FindOperatLog);
        }

        static public void FindInspectorAdm(string stat)
        {
            classes.MySQLconnect.msCommand.CommandText = $@"SELECT * FROM inspectors WHERE fio Rlike '^{stat}'";

            FindInpec.Clear();
            MySQLconnect.msDataAdapter.Fill(FindInpec);
        }

        static public void FindInspectorAdres(string stat)
        {
            classes.MySQLconnect.msCommand.CommandText = $@"SELECT * FROM inspectors WHERE adres Rlike '^{stat}'";

            FindInpecAdres.Clear();
            MySQLconnect.msDataAdapter.Fill(FindInpecAdres);
        }

        static public void FindInspectorTelphone(string stat)
        {
            classes.MySQLconnect.msCommand.CommandText = $@"SELECT * FROM inspectors WHERE telephone Rlike '^{stat}'";

            FindInpecTelep.Clear();
            MySQLconnect.msDataAdapter.Fill(FindInpecTelep);
        }

        #endregion

        #region Individual sort

        #region FindForOwner

        static public void IndFindSecName(string stat, string dude)
        {
            classes.MySQLconnect.msCommand.CommandText = $"SELECT * FROM car_owner WHERE secondName Rlike '^{stat}' and car_owner.idOwner = '{dude}'";

            FindSecNmTab.Clear();
            MySQLconnect.msDataAdapter.Fill(FindSecNmTab);
        }

        static public void IndFindEmail(string stat, string dude)
        {
            classes.MySQLconnect.msCommand.CommandText = $"SELECT * FROM car_owner WHERE Email Rlike '^{stat}' and car_owner.idOwner = '{dude}'";

            FindEmailTab.Clear();
            MySQLconnect.msDataAdapter.Fill(FindEmailTab);
        }

        #endregion

        #region FindForCars

        static public void IndFindGosNum(string stat, string dude)
        {
            classes.MySQLconnect.msCommand.CommandText = $@"SELECT cars.PTSnum, car_marks.Mark, car_color.Color, car_owner.secondName, cars.model, cars.reliseDate, cars.gosNum , cars.regDate
                                                           FROM cars, car_marks, car_color, car_owner
                                                           WHERE cars.idColor = car_color.idColor and cars.idMark = car_marks.idMark and cars.idOwner = car_owner.idOwner
                                                                 and gosNum Rlike '^{stat}' and cars.idOwner = '{dude}'";

            FindGosTab.Clear();
            MySQLconnect.msDataAdapter.Fill(FindGosTab);
        }

        static public void IndFindPTS(string stat, string dude)
        {
            classes.MySQLconnect.msCommand.CommandText = $@"SELECT cars.PTSnum, car_marks.Mark, car_color.Color, car_owner.secondName, cars.model, cars.reliseDate, cars.gosNum , cars.regDate
                                                            FROM cars, car_marks, car_color, car_owner
                                                            WHERE cars.idColor = car_color.idColor and cars.idMark = car_marks.idMark and cars.idOwner = car_owner.idOwner
                                                                  and PTSnum Rlike '^{stat}' and cars.idOwner = '{dude}'";

            FindPTSTab.Clear();
            MySQLconnect.msDataAdapter.Fill(FindPTSTab);
        }

        static public void IndFindModel(string stat, string dude)
        {
            classes.MySQLconnect.msCommand.CommandText = $@"SELECT cars.PTSnum, car_marks.Mark, car_color.Color, car_owner.secondName, cars.model, cars.reliseDate, cars.gosNum , cars.regDate
                                                            FROM cars, car_marks, car_color, car_owner
                                                            WHERE cars.idColor = car_color.idColor and cars.idMark = car_marks.idMark and cars.idOwner = car_owner.idOwner
                                                                  and model Rlike '^{stat}' and cars.idOwner = '{dude}'";

            FindModelTab.Clear();
            MySQLconnect.msDataAdapter.Fill(FindModelTab);
        }

        #endregion

        #region FindForReports

        static public void IndFindFIO(string stat, string dude)
        {
            classes.MySQLconnect.msCommand.CommandText =
                   $@"SELECT reports.idReport, inspectors.fio, reports.incidTime, reports.incidDate, town_region.region, car_owner.secondName, fine_category.describeFine,
                             reports.sum, reports.planedPayment, reports.factPayment, reports.payed
                      FROM reports, inspectors, town_region, car_owner, fine_category
                      WHERE inspectors.idBadge = reports.idBadge and town_region.idRegion = reports.idRegion and car_owner.idOwner = reports.idOwner and reports.idFine = fine_category.idFine 
                            and fio Rlike '^{stat}' and reports.idOwner = '{dude}'";

            FindInspTab.Clear();
            MySQLconnect.msDataAdapter.Fill(FindInspTab);
        }

        static public void IndFindInspector(string stat, string dude)
        {
            classes.MySQLconnect.msCommand.CommandText =
                   $@"SELECT reports.idReport, inspectors.fio, reports.incidTime, reports.incidDate, town_region.region, car_owner.secondName, fine_category.describeFine,
                             reports.sum, reports.planedPayment, reports.factPayment, reports.payed
                      FROM reports, inspectors, town_region, car_owner, fine_category
                      WHERE inspectors.idBadge = reports.idBadge and town_region.idRegion = reports.idRegion and car_owner.idOwner = reports.idOwner and reports.idFine = fine_category.idFine 
                            and secondName Rlike '^{stat}' and reports.idOwner = '{dude}'";

            FindFIOTab.Clear();
            MySQLconnect.msDataAdapter.Fill(FindFIOTab);
        }

        #endregion

        #endregion
    }
}
