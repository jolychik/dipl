using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProgUP.classes
{
    public class Tables
    {
        static public DataTable OwnerTable = new DataTable();
        static public DataTable CarTable = new DataTable();
        static public DataTable ReportTable = new DataTable();
        static public DataTable ColorTable = new DataTable();
        static public DataTable MarkTable = new DataTable();
        static public DataTable RegionTable = new DataTable();
        static public DataTable FineTable = new DataTable();
        static public DataTable InspectorTable = new DataTable();
        static public DataTable OperotorTable = new DataTable();

        static public DataTable indOwnerTable = new DataTable();
        static public DataTable CarOwnFrmTable = new DataTable();
        static public DataTable ReportOwnerTable = new DataTable();

        static public DataTable MarkSTable = new DataTable();
        static public DataTable ColorSTable = new DataTable();
        static public DataTable TownRegTable = new DataTable();
        static public DataTable DriversTable = new DataTable();
        static public DataTable inspectorTable = new DataTable();
        static public DataTable fineTable = new DataTable();
        static public DataTable secNameXML = new DataTable();

        #region Tables

        /// <summary>
        /// Отображение владельцев машин
        /// </summary>
        static public void OwnerShow()
        {
            try
            {
                MySQLconnect.msCommand.CommandText = "SELECT * FROM car_owner ";
                OwnerTable.Clear();
                MySQLconnect.msDataAdapter.Fill(OwnerTable);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Водилы накрылись!");
            }
        }

        /// <summary>
        /// Отображение машин
        /// </summary>
        static public void CarShow()
        {
            try
            {
                MySQLconnect.msCommand.CommandText = 
                    @"SELECT cars.PTSnum, car_marks.Mark, car_color.Color, car_owner.secondName, cars.model, cars.reliseDate, cars.gosNum , cars.regDate
                      FROM cars, car_marks, car_color, car_owner
                      WHERE cars.idColor = car_color.idColor and cars.idMark = car_marks.idMark and cars.idOwner = car_owner.idOwner";
                CarTable.Clear();
                MySQLconnect.msDataAdapter.Fill(CarTable);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Машинки накрылись!");
            }
        }

        /// <summary>
        /// Отображение рапортов
        /// </summary>
        static public void ReportsShow()
        {
            try
            {
                MySQLconnect.msCommand.CommandText =
                    @"SELECT reports.idReport, inspectors.fio, reports.incidTime, reports.incidDate, 
                             town_region.region, concat(car_owner.secondName,' ',car_owner.firstName,' ',car_owner.patronymic) as driverinfo, fine_category.describeFine,
                             reports.sum, reports.planedPayment, reports.factPayment, reports.payed
                      FROM reports, inspectors, town_region, car_owner, fine_category
                      WHERE inspectors.idBadge = reports.idBadge and town_region.idRegion = reports.idRegion and car_owner.idOwner = reports.idOwner and reports.idFine = fine_category.idFine";
                ReportTable.Clear();
                MySQLconnect.msDataAdapter.Fill(ReportTable);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Рапорты накрылись!");
            }
        }
        /// <summary>
        /// Отображение цветов
        /// </summary>
        static public void ColorShow()
        {
            try
            {
                MySQLconnect.msCommand.CommandText = @"SELECT * FROM car_color";
                ColorTable.Clear();
                MySQLconnect.msDataAdapter.Fill(ColorTable);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Накрылось!");
            }
        }
        /// <summary>
        /// Отображение марок
        /// </summary>
        static public void MarkShow()
        {
            try
            {
                MySQLconnect.msCommand.CommandText = @"SELECT * FROM car_marks";
                MarkTable.Clear();
                MySQLconnect.msDataAdapter.Fill(MarkTable);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Накрылось!");
            }
        }
        /// <summary>
        /// Отображение регионов
        /// </summary>
        static public void RegionShow()
        {
            try
            {
                MySQLconnect.msCommand.CommandText = @"SELECT * FROM town_region";
                RegionTable.Clear();
                MySQLconnect.msDataAdapter.Fill(RegionTable);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Накрылось!");
            }
        }
        /// <summary>
        /// Отображение штрафов
        /// </summary>
        static public void FineShow()
        {
            try
            {
                MySQLconnect.msCommand.CommandText = @"SELECT * FROM fine_category";
                FineTable.Clear();
                MySQLconnect.msDataAdapter.Fill(FineTable);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Накрылось!");
            }
        }
        /// <summary>
        /// Отображение инспекторов
        /// </summary>
        static public void InspectorShow()
        {
            try
            {
                MySQLconnect.msCommand.CommandText = @"SELECT * FROM inspectors";
                InspectorTable.Clear();
                MySQLconnect.msDataAdapter.Fill(InspectorTable);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Накрылось!");
            }
        }
        /// <summary>
        /// Отображение операторов
        /// </summary>
        static public void OperatorShow()
        {
            try
            {
                MySQLconnect.msCommand.CommandText = @"SELECT * FROM operators ";
                OperotorTable.Clear();
                MySQLconnect.msDataAdapter.Fill(OperotorTable);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Накрылось!");
            }
        }

        #endregion

        #region TablesForOwners

        /// <summary>
        /// Отображение владельцев машин только для определённого пользователя
        /// </summary>
        static public void IndOwnerShow(string idOwner)
        {
            try
            {
                MySQLconnect.msCommand.CommandText = "SELECT * FROM car_owner WHERE idOwner = '" + idOwner + "'";
                indOwnerTable.Clear();
                MySQLconnect.msDataAdapter.Fill(indOwnerTable);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Водилы накрылись!");
            }
        }

        static public void CarOwnFormShow(string idOwner)
        {
            try
            {
                MySQLconnect.msCommand.CommandText = $@"SELECT cars.PTSnum, car_marks.Mark, car_color.Color, car_owner.secondName, cars.model, cars.reliseDate, cars.gosNum , cars.regDate
                                                       FROM cars, car_marks, car_color, car_owner
                                                       WHERE cars.idColor = car_color.idColor and cars.idMark = car_marks.idMark and cars.idOwner = car_owner.idOwner
                                                       and car_owner.idOwner = '{idOwner}'";
                CarOwnFrmTable.Clear();
                MySQLconnect.msDataAdapter.Fill(CarOwnFrmTable);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Машинки накрылись!");
            }
        }
        /// <summary>
        /// Отбражение рапортов для владельцев
        /// </summary>
        static public void ReportsOwnerShow(string idOwner)
        {
            try
            {
                MySQLconnect.msCommand.CommandText =
                   $@"SELECT reports.idReport, inspectors.fio, reports.incidTime, reports.incidDate, town_region.region, car_owner.secondName, fine_category.describeFine,
                             reports.sum, reports.planedPayment, reports.factPayment, reports.payed
                      FROM reports, inspectors, town_region, car_owner, fine_category
                      WHERE inspectors.idBadge = reports.idBadge and town_region.idRegion = reports.idRegion and car_owner.idOwner = reports.idOwner and reports.idFine = fine_category.idFine
                      and car_owner.idOwner = '{idOwner}'";
                ReportOwnerTable.Clear();
                MySQLconnect.msDataAdapter.Fill(ReportOwnerTable);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Рапорты для пользователей накрылись!");
            }
        }

        #endregion

        #region OteherTables

        /// <summary>
        /// Марки (справочник)
        /// </summary>
        static public void SMark()
        {
            try
            {
                MySQLconnect.msCommand.CommandText = @"SELECT *
                                                       FROM car_marks";
                MarkSTable.Clear();
                MySQLconnect.msDataAdapter.Fill(MarkSTable);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Накрылось!");
            }
        }
        /// <summary>
        /// Цвета машин (справочник)
        /// </summary>
        static public void SColor()
        {
            try
            {
                MySQLconnect.msCommand.CommandText = @"SELECT *
                                                       FROM car_color";
                ColorSTable.Clear();
                MySQLconnect.msDataAdapter.Fill(ColorSTable);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Накрылось!");
            }
        }
        /// <summary>
        /// Региона города
        /// </summary>
        static public void Region()
        {
            try
            {
                MySQLconnect.msCommand.CommandText = @"SELECT *
                                                       FROM town_region";
                TownRegTable.Clear();
                MySQLconnect.msDataAdapter.Fill(TownRegTable);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Накрылось!");
            }
        }
        /// <summary>
        /// Виртуальная таблица для комбобоксов
        /// </summary>
        static public void Drivers()
        {
            try
            {
                MySQLconnect.msCommand.CommandText = @"SELECT idOwner, concat(secondName,' ',firstName,' ',patronymic) as info,
                                                       concat(idDriverRights,' ',secondName,' ',firstName,' ',patronymic) as info1
                                                       FROM car_owner";
                DriversTable.Clear();
                MySQLconnect.msDataAdapter.Fill(DriversTable);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Накрылось!");
            }
        }
        /// <summary>
        /// Виртуальная таблица для комбобоксов
        /// </summary>
        static public void Inspectors()
        {
            try
            {
                MySQLconnect.msCommand.CommandText = @"SELECT *
                                                       FROM inspectors";
                inspectorTable.Clear();
                MySQLconnect.msDataAdapter.Fill(inspectorTable);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Накрылось!");
            }
        }
        /// <summary>
        /// Виртуальная таблица для комбобоксов
        /// </summary>
        static public void Fine()
        {
            try
            {
                MySQLconnect.msCommand.CommandText = @"SELECT *
                                                       FROM fine_category";
                fineTable.Clear();
                MySQLconnect.msDataAdapter.Fill(fineTable);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Накрылось!");
            }
        }
        /// <summary>
        /// Для имени на экзель файле
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static public object SeconNameExcel(string id)
        {
            object result;
                MySQLconnect.msCommand.CommandText = $@"SELECT secondname
                                                       FROM car_owner
                                                       WHERE idOwner = '{id}'";
                secNameXML.Clear();
                MySQLconnect.msDataAdapter.Fill(secNameXML);

                result = MySQLconnect.msCommand.ExecuteScalar();

            return result;
        }

        #endregion
    }
}