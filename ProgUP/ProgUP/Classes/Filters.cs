using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProgUP.classes
{
    public class Filters
    {
        
        static public DataTable oplataSortTable = new DataTable();
        static public DataTable inspSortTable = new DataTable();
        static public DataTable regionSortTable = new DataTable();
        static public DataTable fineSortTable = new DataTable();
        static public DataTable ownerSortTable = new DataTable();
        static public DataTable dateSostSortTable = new DataTable();
        
        static public DataTable marlSortTable = new DataTable();
        static public DataTable colorSortTable = new DataTable();
        static public DataTable idOwnSortTable = new DataTable();
        
        static public DataTable dolgNullSortTable = new DataTable();
        static public DataTable dolgPlusSortTable = new DataTable();
        static public DataTable regdateSortTable = new DataTable();

        static public DataTable FineAtSortTable = new DataTable();
        static public DataTable FineDepSortTable = new DataTable();

        #region Filters

        #region Reports

        /// <summary>
        /// Фильтрация рапортов по статусу оплаты
        /// </summary>
        /// <returns></returns>
        static public void RepOlataFilter(string stat)
        {
            MySQLconnect.msCommand.CommandText =
               $@"SELECT reports.idReport, inspectors.fio, reports.incidTime, reports.incidDate, town_region.region, 
                         concat(car_owner.secondName,' ',car_owner.firstName,' ',car_owner.patronymic) as driverinfo, fine_category.describeFine,
                         reports.sum, reports.planedPayment, reports.factPayment, reports.payed
                  FROM reports, inspectors, town_region, car_owner, fine_category
                  WHERE inspectors.idBadge = reports.idBadge and town_region.idRegion = reports.idRegion and car_owner.idOwner = reports.idOwner
                        and reports.idFine = fine_category.idFine and reports.payed = '{stat}'";

            oplataSortTable.Clear();
            MySQLconnect.msDataAdapter.Fill(oplataSortTable);
        }
        /// <summary>
        /// Фильтрация рапортов по инспекторам
        /// </summary>
        /// <returns></returns>
        static public void RepInspectorFilter(string stat)
        {
            MySQLconnect.msCommand.CommandText =
               $@"SELECT reports.idReport, inspectors.fio, reports.incidTime, reports.incidDate, town_region.region, 
                         concat(car_owner.secondName,' ',car_owner.firstName,' ',car_owner.patronymic) as driverinfo, fine_category.describeFine,
                         reports.sum, reports.planedPayment, reports.factPayment, reports.payed
                  FROM reports, inspectors, town_region, car_owner, fine_category
                  WHERE inspectors.idBadge = reports.idBadge and town_region.idRegion = reports.idRegion and car_owner.idOwner = reports.idOwner
                        and reports.idFine = fine_category.idFine and reports.idBadge = '{stat}'";

            inspSortTable.Clear();
            MySQLconnect.msDataAdapter.Fill(inspSortTable);
        }
        /// <summary>
        /// Фильтрация рапортов по региону
        /// </summary>
        /// <returns></returns>
        static public void RepRegionFilter(string stat)
        {
            MySQLconnect.msCommand.CommandText =
               $@"SELECT reports.idReport, inspectors.fio, reports.incidTime, reports.incidDate, town_region.region, 
                         concat(car_owner.secondName,' ',car_owner.firstName,' ',car_owner.patronymic) as driverinfo, fine_category.describeFine,
                         reports.sum, reports.planedPayment, reports.factPayment, reports.payed
                  FROM reports, inspectors, town_region, car_owner, fine_category
                  WHERE inspectors.idBadge = reports.idBadge and town_region.idRegion = reports.idRegion and car_owner.idOwner = reports.idOwner
                         and reports.idFine = fine_category.idFine and reports.idRegion = '{stat}'";

            regionSortTable.Clear();
            MySQLconnect.msDataAdapter.Fill(regionSortTable);
        }
        /// <summary>
        /// Фильтрация рапортов по виду штрафа
        /// </summary>
        /// <returns></returns>
        static public void RepFineFilter(string stat)
        {
            MySQLconnect.msCommand.CommandText =
               $@"SELECT reports.idReport, inspectors.fio, reports.incidTime, reports.incidDate, town_region.region, 
                         concat(car_owner.secondName,' ',car_owner.firstName,' ',car_owner.patronymic) as driverinfo, fine_category.describeFine,
                         reports.sum, reports.planedPayment, reports.factPayment, reports.payed
                  FROM reports, inspectors, town_region, car_owner, fine_category
                  WHERE inspectors.idBadge = reports.idBadge and town_region.idRegion = reports.idRegion and car_owner.idOwner = reports.idOwner
                        and reports.idFine = fine_category.idFine and reports.idFine = '{stat}'";

            fineSortTable.Clear();
            MySQLconnect.msDataAdapter.Fill(fineSortTable);
        }
        /// <summary>
        /// Фильтрация рапортов по владельцу
        /// </summary>
        /// <returns></returns>
        static public void RepOwnerFilter(string stat)
        {
            MySQLconnect.msCommand.CommandText =
               $@"SELECT reports.idReport, inspectors.fio, reports.incidTime, reports.incidDate, town_region.region, 
                         concat(car_owner.secondName,' ',car_owner.firstName,' ',car_owner.patronymic) as driverinfo, fine_category.describeFine,
                         reports.sum, reports.planedPayment, reports.factPayment, reports.payed
                  FROM reports, inspectors, town_region, car_owner, fine_category
                  WHERE inspectors.idBadge = reports.idBadge and town_region.idRegion = reports.idRegion and car_owner.idOwner = reports.idOwner
                        and reports.idFine = fine_category.idFine and reports.idOwner = '{stat}'";

            ownerSortTable.Clear();
            MySQLconnect.msDataAdapter.Fill(ownerSortTable);
        }
        /// <summary>
        /// Фильтрация рапортов по дате составления
        /// </summary>
        /// <param name="date"></param>
        static public void RepDateSostFilter(string date)
        {
            DateTime sDate = Convert.ToDateTime(date);

            MySQLconnect.msCommand.CommandText =
               $@"SELECT reports.idReport, inspectors.fio, reports.incidTime, reports.incidDate, town_region.region, 
                         concat(car_owner.secondName,' ',car_owner.firstName,' ',car_owner.patronymic) as driverinfo, fine_category.describeFine,
                         reports.sum, reports.planedPayment, reports.factPayment, reports.payed
                  FROM reports, inspectors, town_region, car_owner, fine_category
                  WHERE inspectors.idBadge = reports.idBadge and town_region.idRegion = reports.idRegion and car_owner.idOwner = reports.idOwner
                        and reports.idFine = fine_category.idFine and reports.incidDate = '{sDate.ToString("yyyy-MM-dd")}'";

            dateSostSortTable.Clear();
            MySQLconnect.msDataAdapter.Fill(dateSostSortTable);
        }

        #endregion

        #region Cars

        /// <summary>
        /// Фильтрация машин по марке
        /// </summary>
        /// <param name="stat"></param>
        static public void MarkFilter(string stat)
        {
            MySQLconnect.msCommand.CommandText =
                $@"SELECT cars.PTSnum, car_marks.Mark, car_color.Color, car_owner.secondName, cars.model, cars.reliseDate, cars.gosNum , cars.regDate
                   FROM cars, car_marks, car_color, car_owner
                   WHERE cars.idColor = car_color.idColor and cars.idMark = car_marks.idMark and cars.idOwner = car_owner.idOwner and
                        cars.idMark = '{stat}'";

            marlSortTable.Clear();
            MySQLconnect.msDataAdapter.Fill(marlSortTable);
        }
        /// <summary>
        /// Фильтрация машин по цвету
        /// </summary>
        /// <param name="stat"></param>
        static public void ColorFilter(string stat)
        {
            MySQLconnect.msCommand.CommandText =
                $@"SELECT cars.PTSnum, car_marks.Mark, car_color.Color, car_owner.secondName, cars.model, cars.reliseDate, cars.gosNum , cars.regDate
                      FROM cars, car_marks, car_color, car_owner
                      WHERE cars.idColor = car_color.idColor and cars.idMark = car_marks.idMark and cars.idOwner = car_owner.idOwner and
                            cars.idColor = '{stat}'";

            colorSortTable.Clear();
            MySQLconnect.msDataAdapter.Fill(colorSortTable);
        }
        /// <summary>
        /// Фильтрация машин по владельцу
        /// </summary>
        /// <param name="stat"></param>
        static public void OwnFilter(string stat)
        {
            MySQLconnect.msCommand.CommandText =
                $@"SELECT cars.PTSnum, car_marks.Mark, car_color.Color, car_owner.secondName, cars.model, cars.reliseDate, cars.gosNum , cars.regDate
                   FROM cars, car_marks, car_color, car_owner
                   WHERE cars.idColor = car_color.idColor and cars.idMark = car_marks.idMark and cars.idOwner = car_owner.idOwner and
                         cars.idOwner = '{stat}'";

            idOwnSortTable.Clear();
            MySQLconnect.msDataAdapter.Fill(idOwnSortTable);
        }

        #endregion

        #region Owners

        /// <summary>
        /// Фильтрация пользователей по долгу(нет)
        /// </summary>
        static public void DolgNullFilter()
        {
            MySQLconnect.msCommand.CommandText = "SELECT * FROM car_owner WHERE sumDolg = 0";

            dolgNullSortTable.Clear();
            MySQLconnect.msDataAdapter.Fill(dolgNullSortTable);
        }
        /// <summary>
        /// Фильтрация пользователей по долгу(есть)
        /// </summary>
        static public void DolgNotNullFilter()
        {
            MySQLconnect.msCommand.CommandText = "SELECT * FROM car_owner WHERE sumDolg > 0";

            dolgPlusSortTable.Clear();
            MySQLconnect.msDataAdapter.Fill(dolgPlusSortTable);
        }
        /// <summary>
        /// Фильтрация пользователей по дате регистрации
        /// </summary>
        static public void RegDateFilter(string stat)
        {
            DateTime sDate = Convert.ToDateTime(stat);

            MySQLconnect.msCommand.CommandText = $"SELECT * FROM car_owner WHERE ownerRegDate = '{sDate.ToString("yyyy-MM-dd")}'";

            regdateSortTable.Clear();
            MySQLconnect.msDataAdapter.Fill(regdateSortTable);
        }

        #endregion

        static public void FineFilterAtention(string stat)
        {
            MySQLconnect.msCommand.CommandText = $"SELECT * FROM fine_category WHERE atention = '{stat}'";

            FineAtSortTable.Clear();
            MySQLconnect.msDataAdapter.Fill(FineAtSortTable);
        }

        static public void FineFilterDepeort(string stat)
        {
            MySQLconnect.msCommand.CommandText = $"SELECT * FROM fine_category WHERE rightDep = '{stat}'";

            FineDepSortTable.Clear();
            MySQLconnect.msDataAdapter.Fill(FineDepSortTable);
        }

        #endregion

        #region Idnividual filters

        #region Reports

        /// <summary>
        /// Фильтрация рапортов по статусу оплаты
        /// </summary>
        /// <returns></returns>
        static public void IndOplataFilter(string stat, string dude)
        {
            MySQLconnect.msCommand.CommandText =
               $@"SELECT reports.idReport, inspectors.fio, reports.incidTime, reports.incidDate, town_region.region, car_owner.secondName, fine_category.describeFine,
                         reports.sum, reports.planedPayment, reports.factPayment, reports.payed
                  FROM reports, inspectors, town_region, car_owner, fine_category
                  WHERE inspectors.idBadge = reports.idBadge and town_region.idRegion = reports.idRegion and car_owner.idOwner = reports.idOwner
                        and reports.idFine = fine_category.idFine and reports.payed = '{stat}' and reports.idowner = '{dude}'";

            oplataSortTable.Clear();
            MySQLconnect.msDataAdapter.Fill(oplataSortTable);
        }
        /// <summary>
        /// Фильтрация рапортов по инспекторам
        /// </summary>
        /// <returns></returns>
        static public void IndInspectorFilter(string stat, string dude)
        {
            MySQLconnect.msCommand.CommandText =
               $@"SELECT reports.idReport, inspectors.fio, reports.incidTime, reports.incidDate, town_region.region, car_owner.secondName, fine_category.describeFine,
                         reports.sum, reports.planedPayment, reports.factPayment, reports.payed
                  FROM reports, inspectors, town_region, car_owner, fine_category
                  WHERE inspectors.idBadge = reports.idBadge and town_region.idRegion = reports.idRegion and car_owner.idOwner = reports.idOwner
                        and reports.idFine = fine_category.idFine and reports.idBadge = '{stat}' and reports.idowner = '{dude}'";

            inspSortTable.Clear();
            MySQLconnect.msDataAdapter.Fill(inspSortTable);
        }
        /// <summary>
        /// Фильтрация рапортов по региону
        /// </summary>
        /// <returns></returns>
        static public void IndRegionFilter(string stat, string dude)
        {
            MySQLconnect.msCommand.CommandText =
               $@"SELECT reports.idReport, inspectors.fio, reports.incidTime, reports.incidDate, town_region.region, car_owner.secondName, fine_category.describeFine,
                         reports.sum, reports.planedPayment, reports.factPayment, reports.payed
                  FROM reports, inspectors, town_region, car_owner, fine_category
                  WHERE inspectors.idBadge = reports.idBadge and town_region.idRegion = reports.idRegion and car_owner.idOwner = reports.idOwner
                        and reports.idFine = fine_category.idFine and reports.idRegion = '{stat}' and reports.idowner = '{dude}'";

            regionSortTable.Clear();
            MySQLconnect.msDataAdapter.Fill(regionSortTable);
        }
        /// <summary>
        /// Фильтрация рапортов по виду штрафа
        /// </summary>
        /// <returns></returns>
        static public void IndFineFilter(string stat, string dude)
        {
            MySQLconnect.msCommand.CommandText =
               $@"SELECT reports.idReport, inspectors.fio, reports.incidTime, reports.incidDate, town_region.region, car_owner.secondName, fine_category.describeFine,
                         reports.sum, reports.planedPayment, reports.factPayment, reports.payed
                  FROM reports, inspectors, town_region, car_owner, fine_category
                  WHERE inspectors.idBadge = reports.idBadge and town_region.idRegion = reports.idRegion and car_owner.idOwner = reports.idOwner
                        and reports.idFine = fine_category.idFine and reports.idFine = '{stat}' and reports.idowner = '{dude}'";

            fineSortTable.Clear();
            MySQLconnect.msDataAdapter.Fill(fineSortTable);
        }
        /// <summary>
        /// Фильтрация рапортов по дате составления
        /// </summary>
        /// <param name="date"></param>
        static public void IndDateSostFilter(string date, string dude)
        {
            DateTime sDate = Convert.ToDateTime(date);

            MySQLconnect.msCommand.CommandText =
               $@"SELECT reports.idReport, inspectors.fio, reports.incidTime, reports.incidDate, town_region.region, car_owner.secondName, fine_category.describeFine,
                         reports.sum, reports.planedPayment, reports.factPayment, reports.payed
                  FROM reports, inspectors, town_region, car_owner, fine_category
                  WHERE inspectors.idBadge = reports.idBadge and town_region.idRegion = reports.idRegion and car_owner.idOwner = reports.idOwner
                        and reports.idFine = fine_category.idFine and reports.incidDate = '{sDate.ToString("yyyy-MM-dd")}' and reports.idowner = '{dude}'";

            dateSostSortTable.Clear();
            MySQLconnect.msDataAdapter.Fill(dateSostSortTable);
        }

        #endregion

        #region Cars

        /// <summary>
        /// Фильтрация машин по марке
        /// </summary>
        /// <param name="stat"></param>
        static public void IndMarkFilter(string stat, string dude)
        {
            MySQLconnect.msCommand.CommandText =
                $@"SELECT cars.PTSnum, car_marks.Mark, car_color.Color, car_owner.secondName, cars.model, cars.reliseDate, cars.gosNum , cars.regDate
                   FROM cars, car_marks, car_color, car_owner
                   WHERE cars.idColor = car_color.idColor and cars.idMark = car_marks.idMark and cars.idOwner = car_owner.idOwner and
                        cars.idMark = '{stat}' and cars.idowner = '{dude}'";

            marlSortTable.Clear();
            MySQLconnect.msDataAdapter.Fill(marlSortTable);
        }
        /// <summary>
        /// Фильтрация машин по цвету
        /// </summary>
        /// <param name="stat"></param>
        static public void IndColorFilter(string stat, string dude)
        {
            MySQLconnect.msCommand.CommandText =
                $@"SELECT cars.PTSnum, car_marks.Mark, car_color.Color, car_owner.secondName, cars.model, cars.reliseDate, cars.gosNum , cars.regDate
                      FROM cars, car_marks, car_color, car_owner
                      WHERE cars.idColor = car_color.idColor and cars.idMark = car_marks.idMark and cars.idOwner = car_owner.idOwner and
                            cars.idColor = '{stat}' and cars.idowner = '{dude}'";

            colorSortTable.Clear();
            MySQLconnect.msDataAdapter.Fill(colorSortTable);
        }

        #endregion

        #endregion
    }
}