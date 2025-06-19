using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Diagnostics;


namespace ProgUP.Classes
{
    public class ExcelStuff
    {
        //Екземпляр приложения Excel
        static public Excel.Application xlApp;
        //Лист
        static public Excel.Worksheet xlSheet;
        //Выделеная область
        static public Excel.Range xlSheetRange;

        #region Выходные документы владельца

        #region Штрафы

        static public void SqlToExcelsF(string Area)//отчет список заявок
        {
            xlApp = new Excel.Application();
            try
            {
                int collInd = 0;
                int rowInd = 9;
                string data = "";
                xlApp.Workbooks.Add(Type.Missing);
                xlApp.Interactive = false;
                xlApp.EnableEvents = false;
                xlSheet = (Excel.Worksheet)xlApp.Sheets[1];
                xlSheet.Name = "Штрафы";

                Excel.Range excelCells1 = xlSheet.Range[xlSheet.Cells[1, 1], xlSheet.Cells[1, 5]];
                xlSheet.Cells[1, 5] = @"Информация о неоплаченных штрафах";

                Excel.Range excelCells2 = xlSheet.Range[xlSheet.Cells[1, 6], xlSheet.Cells[1, 6]];
                xlSheet.Cells[1, 6] = @"Дата формирования";

                Excel.Range excelCells3 = xlSheet.Range[xlSheet.Cells[1, 7], xlSheet.Cells[1, 7]];
                xlSheet.Cells[1, 7] = DateTime.Now.ToString("dd/MM/yyyy");



                xlSheet.Cells.get_Range("A2", "Z2").ColumnWidth = 50;

                excelCells1.Merge(Type.Missing);
                excelCells1.Cells.Font.Bold = true;
                excelCells1.Cells.Font.Size = 20;
                excelCells1.Font.Color = ColorTranslator.ToOle(Color.MidnightBlue);
                excelCells2.Font.Italic = true;
                excelCells3.Cells.Font.Bold = true;

                DataTable dt = FinesExcel(Area);

                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    data = dt.Columns[i].ColumnName.ToString();
                    xlSheet.Cells[3, i + 1] = data;

                    xlSheetRange = xlSheet.get_Range("A3:Z3", Type.Missing);
                    xlSheetRange.Font.Color = ColorTranslator.ToOle(Color.Blue);
                    xlSheetRange.Font.Size = 12;
                    xlSheetRange.Font.Bold = true;
                    xlSheetRange.WrapText = true;
                    xlSheetRange.Font.Bold = true;
                }

                for (rowInd = 0; rowInd < dt.Rows.Count; rowInd++)
                {
                    for (collInd = 0; collInd < dt.Columns.Count; collInd++)
                    {
                        data = dt.Rows[rowInd].ItemArray[collInd].ToString();
                        xlSheet.Cells[rowInd + 4, collInd + 1] = data;
                    }
                }

                xlSheetRange = xlSheet.UsedRange;
                xlSheetRange.Columns.AutoFit();
                xlSheetRange.Rows.AutoFit();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ошибка");
            }
            finally
            {
                xlSheet.SaveAs("Ваши не оплаченные штрафы  " + ".xlsx");
                xlApp.Interactive = true;
                xlApp.ScreenUpdating = true;
                xlApp.UserControl = true;
                xlApp.Workbooks.Close();
                xlApp.Quit();
                Process[] ps2 = System.Diagnostics.Process.GetProcessesByName("EXCEL");
                foreach (Process p2 in ps2)
                {
                    p2.Kill();
                }
            }
        }

        private static DataTable FinesExcel(string area)//запрос для вывода в эксель
        {
            string connString = @"Database = gaidatabase; DataSource = localhost; user = root; password = root; charset = utf8";
            MySqlConnection con = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                string query = $@"SELECT inspectors.fio AS 'Инспектор', reports.incidTime AS 'Время нарушения', reports.incidDate AS 'Дата нарушения', town_region.region AS 'Место нарушения', fine_category.describeFine AS 'Нарушение',
                                        reports.sum AS 'Сумма штрафа', reports.planedPayment AS 'Запланированая дата оплаты'
                                 FROM reports, inspectors, town_region, car_owner, fine_category
                                 WHERE inspectors.idBadge = reports.idBadge and town_region.idRegion = reports.idRegion and car_owner.idOwner = reports.idOwner and
                                       reports.idFine = fine_category.idFine
                                       and car_owner.idOwner = {area} and payed = 'Оплачено'";
                MySqlCommand comm = new MySqlCommand(query, con);
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(comm);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dt = ds.Tables[0];
            }
            catch
            {
                //MessageBox.Show("error");
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return dt;
        }

        #endregion

        #region штрафы по дате от и до

        static public void SqlToExcelsFDTD(string Area, string date1, string date2)//отчет список заявок
        {
            xlApp = new Excel.Application();
            try
            {
                int collInd = 0;
                int rowInd = 9;
                string data = "";
                xlApp.Workbooks.Add(Type.Missing);
                xlApp.Interactive = false;
                xlApp.EnableEvents = false;
                xlSheet = (Excel.Worksheet)xlApp.Sheets[1];
                xlSheet.Name = "Штрафы за период";

                Excel.Range excelCells1 = xlSheet.Range[xlSheet.Cells[1, 1], xlSheet.Cells[1, 5]];
                xlSheet.Cells[1, 5] = @"Информация о неоплаченных штрафах за период";

                Excel.Range excelCells2 = xlSheet.Range[xlSheet.Cells[1, 6], xlSheet.Cells[1, 6]];
                xlSheet.Cells[1, 6] = @"Дата формирования";

                Excel.Range excelCells3 = xlSheet.Range[xlSheet.Cells[1, 7], xlSheet.Cells[1, 7]];
                xlSheet.Cells[1, 7] = DateTime.Now.ToString("dd/MM/yyyy");



                xlSheet.Cells.get_Range("A2", "Z2").ColumnWidth = 50;

                excelCells1.Merge(Type.Missing);
                excelCells1.Cells.Font.Bold = true;
                excelCells1.Cells.Font.Size = 20;
                excelCells1.Font.Color = ColorTranslator.ToOle(Color.MidnightBlue);
                excelCells2.Font.Italic = true;
                excelCells3.Cells.Font.Bold = true;

                DataTable dt = FineDateToDate(Area, date1, date2);

                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    data = dt.Columns[i].ColumnName.ToString();
                    xlSheet.Cells[3, i + 1] = data;

                    xlSheetRange = xlSheet.get_Range("A3:Z3", Type.Missing);
                    xlSheetRange.Font.Color = ColorTranslator.ToOle(Color.Blue);
                    xlSheetRange.Font.Size = 12;
                    xlSheetRange.Font.Bold = true;
                    xlSheetRange.WrapText = true;
                    xlSheetRange.Font.Bold = true;
                }

                for (rowInd = 0; rowInd < dt.Rows.Count; rowInd++)
                {
                    for (collInd = 0; collInd < dt.Columns.Count; collInd++)
                    {
                        data = dt.Rows[rowInd].ItemArray[collInd].ToString();
                        xlSheet.Cells[rowInd + 4, collInd + 1] = data;
                    }
                }

                xlSheetRange = xlSheet.UsedRange;
                xlSheetRange.Columns.AutoFit();
                xlSheetRange.Rows.AutoFit();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ошибка");
            }
            finally
            {
                xlSheet.SaveAs("Ваши штрафы " + classes.Tables.SeconNameExcel(classes.Autorisation.user) + "(за врем. промежуток).xlsx");
                xlApp.Interactive = true;
                xlApp.ScreenUpdating = true;
                xlApp.UserControl = true;
                xlApp.Workbooks.Close();
                xlApp.Quit();
                Process[] ps2 = System.Diagnostics.Process.GetProcessesByName("EXCEL");
                foreach (Process p2 in ps2)
                {
                    p2.Kill();
                }
            }
        }

        private static DataTable FineDateToDate(string area, string date1,string date2)//штрафы за определённое время
        {
            string connString = @"Database = gaidatabase; DataSource = localhost; user = root; password = root; charset = utf8";
            MySqlConnection con = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                DateTime selectedData1 = Convert.ToDateTime(date1);
                DateTime selectedData2 = Convert.ToDateTime(date2);

                string query = $@"SELECT inspectors.fio AS 'Инспектор', reports.incidTime AS 'Время нарушения', reports.incidDate AS 'Дата нарушения',
                                         town_region.region AS 'Место нарушения', fine_category.describeFine AS 'Нарушение',
                                         reports.sum AS 'Сумма штрафа', reports.planedPayment AS 'Запланированая дата оплаты'
                                 FROM  reports, inspectors, town_region, car_owner, fine_category
                                 WHERE inspectors.idBadge = reports.idBadge and town_region.idRegion = reports.idRegion and car_owner.idOwner = reports.idOwner and
                                       reports.idFine = fine_category.idFine
                                       and car_owner.idOwner = {area} and planedPayment >= '{selectedData1.ToString("yyyy-MM-dd")}'
                                       and planedPayment <= '{selectedData2.ToString("yyyy-MM-dd")}'";
                MySqlCommand comm = new MySqlCommand(query, con);
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(comm);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dt = ds.Tables[0];
            }
            catch
            {
                //MessageBox.Show("error");
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return dt;
        }

        #endregion

        #region Штрафы по региону

        static public void SqlToExcelsR(string Area, string region) //отчет список заявок
        {
            xlApp = new Excel.Application();
            try
            {
                int collInd = 0;
                int rowInd = 9;
                string data = "";
                xlApp.Workbooks.Add(Type.Missing);
                xlApp.Interactive = false;
                xlApp.EnableEvents = false;
                xlSheet = (Excel.Worksheet)xlApp.Sheets[1];
                xlSheet.Name = "Штрафы за период";

                Excel.Range excelCells1 = xlSheet.Range[xlSheet.Cells[1, 1], xlSheet.Cells[1, 5]];
                xlSheet.Cells[1, 5] = @"Информация о неоплаченных штрафах за период";

                Excel.Range excelCells2 = xlSheet.Range[xlSheet.Cells[1, 6], xlSheet.Cells[1, 6]];
                xlSheet.Cells[1, 6] = @"Дата формирования";

                Excel.Range excelCells3 = xlSheet.Range[xlSheet.Cells[1, 7], xlSheet.Cells[1, 7]];
                xlSheet.Cells[1, 7] = DateTime.Now.ToString("dd/MM/yyyy");



                xlSheet.Cells.get_Range("A2", "Z2").ColumnWidth = 50;

                excelCells1.Merge(Type.Missing);
                excelCells1.Cells.Font.Bold = true;
                excelCells1.Cells.Font.Size = 20;
                excelCells1.Font.Color = ColorTranslator.ToOle(Color.MidnightBlue);
                excelCells2.Font.Italic = true;
                excelCells3.Cells.Font.Bold = true;

                DataTable dt = FineRegion(Area, region);

                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    data = dt.Columns[i].ColumnName.ToString();
                    xlSheet.Cells[3, i + 1] = data;

                    xlSheetRange = xlSheet.get_Range("A3:Z3", Type.Missing);
                    xlSheetRange.Font.Color = ColorTranslator.ToOle(Color.Blue);
                    xlSheetRange.Font.Size = 12;
                    xlSheetRange.Font.Bold = true;
                    xlSheetRange.WrapText = true;
                    xlSheetRange.Font.Bold = true;
                }

                for (rowInd = 0; rowInd < dt.Rows.Count; rowInd++)
                {
                    for (collInd = 0; collInd < dt.Columns.Count; collInd++)
                    {
                        data = dt.Rows[rowInd].ItemArray[collInd].ToString();
                        xlSheet.Cells[rowInd + 4, collInd + 1] = data;
                    }
                }

                xlSheetRange = xlSheet.UsedRange;
                xlSheetRange.Columns.AutoFit();
                xlSheetRange.Rows.AutoFit();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ошибка");
            }
            finally
            {
                xlSheet.SaveAs("Ваши штрафы " + classes.Tables.SeconNameExcel(classes.Autorisation.user) + "(регионы).xlsx");
                xlApp.Interactive = true;
                xlApp.ScreenUpdating = true;
                xlApp.UserControl = true;
                xlApp.Workbooks.Close();
                xlApp.Quit();
                Process[] ps2 = System.Diagnostics.Process.GetProcessesByName("EXCEL");
                foreach (Process p2 in ps2)
                {
                    p2.Kill();
                }
            }
        }

        private static DataTable FineRegion(string area, string region)//штрафы за определённое время
        {
            string connString = @"Database = gaidatabase; DataSource = localhost; user = root; password = root; charset = utf8";
            MySqlConnection con = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                string query = $@"SELECT inspectors.fio AS 'Инспектор', reports.incidTime AS 'Время нарушения', reports.incidDate AS 'Дата нарушения',
                                         town_region.region AS 'Место нарушения', fine_category.describeFine AS 'Нарушение',
                                         reports.sum AS 'Сумма штрафа', reports.planedPayment AS 'Запланированая дата оплаты'
                                 FROM  reports, inspectors, town_region, car_owner, fine_category
                                 WHERE inspectors.idBadge = reports.idBadge and town_region.idRegion = reports.idRegion and car_owner.idOwner = reports.idOwner and
                                       reports.idFine = fine_category.idFine
                                       and car_owner.idOwner = {area} and reports.idRegion = '{region}'";
                MySqlCommand comm = new MySqlCommand(query, con);
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(comm);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dt = ds.Tables[0];
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ошибка при создании документа");
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return dt;
        }

        #endregion

        #region Оплаченые штрафы

        static public void SqlToExcelsSP(string Area)//отчет список заявок
        {
            xlApp = new Excel.Application();
            try
            {
                int collInd = 0;
                int rowInd = 9;
                string data = "";
                xlApp.Workbooks.Add(Type.Missing);
                xlApp.Interactive = false;
                xlApp.EnableEvents = false;
                xlSheet = (Excel.Worksheet)xlApp.Sheets[1];
                xlSheet.Name = "Штрафы";

                Excel.Range excelCells1 = xlSheet.Range[xlSheet.Cells[1, 1], xlSheet.Cells[1, 1]];
                xlSheet.Cells[1, 1] = @"Информация об оплаченных штрафах";

                Excel.Range excelCells2 = xlSheet.Range[xlSheet.Cells[1, 2], xlSheet.Cells[1, 2]];
                xlSheet.Cells[1, 2] = @"Дата формирования";

                Excel.Range excelCells3 = xlSheet.Range[xlSheet.Cells[1, 3], xlSheet.Cells[1, 3]];
                xlSheet.Cells[1, 3] = DateTime.Now.ToString("dd/MM/yyyy");



                xlSheet.Cells.get_Range("A2", "Z2").ColumnWidth = 50;

                excelCells1.Merge(Type.Missing);
                excelCells1.Cells.Font.Bold = true;
                excelCells1.Cells.Font.Size = 20;
                excelCells1.Font.Color = ColorTranslator.ToOle(Color.MidnightBlue);
                excelCells2.Font.Italic = true;
                excelCells3.Cells.Font.Bold = true;

                DataTable dt = FinesExcelSP(Area);

                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    data = dt.Columns[i].ColumnName.ToString();
                    xlSheet.Cells[3, i + 1] = data;

                    xlSheetRange = xlSheet.get_Range("A3:Z3", Type.Missing);
                    xlSheetRange.Font.Color = ColorTranslator.ToOle(Color.Blue);
                    xlSheetRange.Font.Size = 12;
                    xlSheetRange.Font.Bold = true;
                    xlSheetRange.WrapText = true;
                    xlSheetRange.Font.Bold = true;
                }

                for (rowInd = 0; rowInd < dt.Rows.Count; rowInd++)
                {
                    for (collInd = 0; collInd < dt.Columns.Count; collInd++)
                    {
                        data = dt.Rows[rowInd].ItemArray[collInd].ToString();
                        xlSheet.Cells[rowInd + 4, collInd + 1] = data;
                    }
                }

                xlSheetRange = xlSheet.UsedRange;
                xlSheetRange.Columns.AutoFit();
                xlSheetRange.Rows.AutoFit();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ошибка");
            }
            finally
            {
                xlSheet.SaveAs("Ваши оплаченные штрафы " + classes.Tables.SeconNameExcel(classes.Autorisation.user) + ".xlsx");
                xlApp.Interactive = true;
                xlApp.ScreenUpdating = true;
                xlApp.UserControl = true;
                xlApp.Workbooks.Close();
                xlApp.Quit();
                Process[] ps2 = System.Diagnostics.Process.GetProcessesByName("EXCEL");
                foreach (Process p2 in ps2)
                {
                    p2.Kill();
                }
            }
        }

        private static DataTable FinesExcelSP(string area)//запрос для вывода в эксель
        {
            string connString = @"Database = gaidatabase; DataSource = localhost; user = root; password = root; charset = utf8";
            MySqlConnection con = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                string query = $@"SELECT inspectors.fio AS 'Инспектор', reports.incidTime AS 'Время нарушения', reports.incidDate AS 'Дата нарушения', town_region.region AS 'Место нарушения', fine_category.describeFine AS 'Нарушение',
                                        reports.sum AS 'Сумма штрафа', reports.planedPayment AS 'Запланированая дата оплаты'
                                 FROM reports, inspectors, town_region, car_owner, fine_category
                                 WHERE inspectors.idBadge = reports.idBadge and town_region.idRegion = reports.idRegion and car_owner.idOwner = reports.idOwner and
                                       reports.idFine = fine_category.idFine
                                       and car_owner.idOwner = {area} and payed = 'Оплачено'";
                MySqlCommand comm = new MySqlCommand(query, con);
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(comm);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dt = ds.Tables[0];
            }
            catch
            {
                //MessageBox.Show("error");
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return dt;
        }

        #endregion

        #endregion

        #region Выходные документы Одмэна

        #region Инфо о водиле

        static public void AdmExcelOC(string Area, string Area1)//отчет список заявок
        {
            xlApp = new Excel.Application();
            try
            {
                int collInd = 0;
                int rowInd = 9;
                string data = "";
                xlApp.Workbooks.Add(Type.Missing);
                xlApp.Interactive = false;
                xlApp.EnableEvents = false;
                xlSheet = (Excel.Worksheet)xlApp.Sheets[1];
                xlSheet.Name = "Информация о владельце";

                Excel.Range excelCells1 = xlSheet.Range[xlSheet.Cells[1, 1], xlSheet.Cells[1, 5]];
                xlSheet.Cells[1, 5] = @"Информация о владельце";

                Excel.Range excelCells2 = xlSheet.Range[xlSheet.Cells[1, 6], xlSheet.Cells[1, 6]];
                xlSheet.Cells[1, 6] = @"Дата формирования";

                Excel.Range excelCells3 = xlSheet.Range[xlSheet.Cells[1, 7], xlSheet.Cells[1, 7]];
                xlSheet.Cells[1, 7] = DateTime.Now.ToString("dd/MM/yyyy");

                xlSheet.Cells.get_Range("A2", "Z2").ColumnWidth = 50;

                excelCells1.Merge(Type.Missing);
                excelCells1.Cells.Font.Bold = true;
                excelCells1.Cells.Font.Size = 20;
                excelCells1.Font.Color = ColorTranslator.ToOle(Color.MidnightBlue);
                excelCells2.Font.Italic = true;
                excelCells3.Cells.Font.Bold = true;

                DataTable dt = OwnersCars(Area, Area1);

                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    data = dt.Columns[i].ColumnName.ToString();
                    xlSheet.Cells[3, i + 1] = data;

                    xlSheetRange = xlSheet.get_Range("A3:Z3", Type.Missing);
                    xlSheetRange.Font.Color = ColorTranslator.ToOle(Color.Blue);
                    xlSheetRange.Font.Size = 12;
                    xlSheetRange.Font.Bold = true;
                    xlSheetRange.WrapText = true;
                    xlSheetRange.Font.Bold = true;
                }

                for (rowInd = 0; rowInd < dt.Rows.Count; rowInd++)
                {
                    for (collInd = 0; collInd < dt.Columns.Count; collInd++)
                    {
                        data = dt.Rows[rowInd].ItemArray[collInd].ToString();
                        xlSheet.Cells[rowInd + 4, collInd + 1] = data;
                    }
                }

                xlSheetRange = xlSheet.UsedRange;
                xlSheetRange.Columns.AutoFit();
                xlSheetRange.Rows.AutoFit();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ошибка");
            }
            finally
            {
                xlSheet.SaveAs("Информация о водителе.xlsx");
                xlApp.Interactive = true;
                xlApp.ScreenUpdating = true;
                xlApp.UserControl = true;
                xlApp.Workbooks.Close();
                xlApp.Quit();
                Process[] ps2 = System.Diagnostics.Process.GetProcessesByName("EXCEL");
                foreach (Process p2 in ps2)
                {
                    p2.Kill();
                }
            }
        }

        private static DataTable OwnersCars(string area, string area1)//запрос для вывода в эксель
        {
            string connString = @"Database = gaidatabase; DataSource = localhost; user = root; password = root; charset = utf8";
            MySqlConnection con = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                string query = $@"SELECT car_owner.idDriverRights as 'Номер вод. прав', concat(car_owner.secondName,' ',car_owner.firstName,' ',car_owner.patronymic) as 'ФИО',
                                         car_owner.adres as 'Адрес проживания', car_owner.email as 'Адрес эл. почты', car_owner.telephone as 'Контактный телефон',
	                                     cars.gosNum as 'Гос. номер тс', cars.idMark as 'Марка', cars.model as 'Модель', cars.idColor as 'Цвет', cars.PTSnum as 'ПТС', cars.regDate as 'Дата регистрации'
                                  FROM car_owner, cars, car_marks, car_color
                                  WHERE cars.idMark = car_marks.idMark and cars.idColor = car_color.idColor and car_owner.idOwner = '{area}' and cars.idOwner = '{area1}'";
                MySqlCommand comm = new MySqlCommand(query, con);
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(comm);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dt = ds.Tables[0];
            }
            catch
            {
                //MessageBox.Show("error");
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return dt;
        }

        #endregion

        #region штрафы по времени

        static public void AdmExcelDTD(string Area, string Area1, string Area2, string info)//отчет список заявок
        {
            xlApp = new Excel.Application();
            try
            {
                int collInd = 0;
                int rowInd = 9;
                string data = "";
                xlApp.Workbooks.Add(Type.Missing);
                xlApp.Interactive = false;
                xlApp.EnableEvents = false;
                xlSheet = (Excel.Worksheet)xlApp.Sheets[1];
                xlSheet.Name = "Штрафы за период времени";

                Excel.Range excelCells1 = xlSheet.Range[xlSheet.Cells[1, 1], xlSheet.Cells[1, 5]];
                xlSheet.Cells[1, 5] = @"Штрафы за период времени";

                Excel.Range excelCells2 = xlSheet.Range[xlSheet.Cells[1, 6], xlSheet.Cells[1, 6]];
                xlSheet.Cells[1, 6] = @"Дата формирования";

                Excel.Range excelCells3 = xlSheet.Range[xlSheet.Cells[1, 7], xlSheet.Cells[1, 7]];
                xlSheet.Cells[1, 7] = DateTime.Now.ToString("dd/MM/yyyy");

                xlSheet.Cells.get_Range("A2", "Z2").ColumnWidth = 50;

                excelCells1.Merge(Type.Missing);
                excelCells1.Cells.Font.Bold = true;
                excelCells1.Cells.Font.Size = 20;
                excelCells1.Font.Color = ColorTranslator.ToOle(Color.MidnightBlue);
                excelCells2.Font.Italic = true;
                excelCells3.Cells.Font.Bold = true;

                DataTable dt = ReportsDateToDate(Area, Area1, Area2);

                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    data = dt.Columns[i].ColumnName.ToString();
                    xlSheet.Cells[3, i + 1] = data;

                    xlSheetRange = xlSheet.get_Range("A3:Z3", Type.Missing);
                    xlSheetRange.Font.Color = ColorTranslator.ToOle(Color.Blue);
                    xlSheetRange.Font.Size = 12;
                    xlSheetRange.Font.Bold = true;
                    xlSheetRange.WrapText = true;
                    xlSheetRange.Font.Bold = true;
                }

                for (rowInd = 0; rowInd < dt.Rows.Count; rowInd++)
                {
                    for (collInd = 0; collInd < dt.Columns.Count; collInd++)
                    {
                        data = dt.Rows[rowInd].ItemArray[collInd].ToString();
                        xlSheet.Cells[rowInd + 4, collInd + 1] = data;
                    }
                }

                xlSheetRange = xlSheet.UsedRange;
                xlSheetRange.Columns.AutoFit();
                xlSheetRange.Rows.AutoFit();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ошибка");
            }
            finally
            {
                xlSheet.SaveAs("Штрафы за период времени " + info + ".xlsx");
                xlApp.Interactive = true;
                xlApp.ScreenUpdating = true;
                xlApp.UserControl = true;
                xlApp.Workbooks.Close();
                xlApp.Quit();
                Process[] ps2 = System.Diagnostics.Process.GetProcessesByName("EXCEL");
                foreach (Process p2 in ps2)
                {
                    p2.Kill();
                }
            }
        }

        private static DataTable ReportsDateToDate(string area, string date1, string date2)//запрос для вывода в эксель
        {
            string connString = @"Database = gaidatabase; DataSource = localhost; user = root; password = root; charset = utf8";
            MySqlConnection con = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                DateTime selectedData1 = Convert.ToDateTime(date1);
                DateTime selectedData2 = Convert.ToDateTime(date2);

                string query = $@"SELECT inspectors.fio AS 'Инспектор', reports.incidTime AS 'Время нарушения', reports.incidDate AS 'Дата нарушения',
                                         town_region.region AS 'Место нарушения', fine_category.describeFine AS 'Нарушение',
                                         reports.sum AS 'Сумма штрафа', reports.planedPayment AS 'Запланированая дата оплаты'
                                  FROM  reports, inspectors, town_region, car_owner, fine_category
                                  WHERE inspectors.idBadge = reports.idBadge and town_region.idRegion = reports.idRegion and car_owner.idOwner = reports.idOwner and
                                       reports.idFine = fine_category.idFine
                                       and car_owner.idOwner = {area} and planedPayment >= '{selectedData1.ToString("yyyy-MM-dd")}'
                                       and planedPayment <= '{selectedData2.ToString("yyyy-MM-dd")}'";
                MySqlCommand comm = new MySqlCommand(query, con);
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(comm);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dt = ds.Tables[0];
            }
            catch
            {
                //MessageBox.Show("error");
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return dt;
        }

        #endregion

        #region штрафы по региону и времени

        static public void AdmExcelRgDTD(string area, string date1, string date2)//отчет список заявок
        {
            xlApp = new Excel.Application();
            
                int collInd = 0;
                int rowInd = 9;
                string data = "";
                xlApp.Workbooks.Add(Type.Missing);
                xlApp.Interactive = false;
                xlApp.EnableEvents = false;
                xlSheet = (Excel.Worksheet)xlApp.Sheets[1];
                xlSheet.Name = "Штрафы";

                Excel.Range excelCells1 = xlSheet.Range[xlSheet.Cells[1, 1], xlSheet.Cells[1, 5]];
                xlSheet.Cells[1, 5] = @"Штрафы";

                Excel.Range excelCells2 = xlSheet.Range[xlSheet.Cells[1, 6], xlSheet.Cells[1, 6]];
                xlSheet.Cells[1, 6] = @"Дата формирования";

                Excel.Range excelCells3 = xlSheet.Range[xlSheet.Cells[1, 7], xlSheet.Cells[1, 7]];
                xlSheet.Cells[1, 7] = DateTime.Now.ToString("dd/MM/yyyy");

                xlSheet.Cells.get_Range("A2", "Z2").ColumnWidth = 50;

                excelCells1.Merge(Type.Missing);
                excelCells1.Cells.Font.Bold = true;
                excelCells1.Cells.Font.Size = 20;
                excelCells1.Font.Color = ColorTranslator.ToOle(Color.MidnightBlue);
                excelCells2.Font.Italic = true;
                excelCells3.Cells.Font.Bold = true;

                DataTable dt = ReportsDateToDateReg(area, date1, date2);

                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    data = dt.Columns[i].ColumnName.ToString();
                    xlSheet.Cells[3, i + 1] = data;

                    xlSheetRange = xlSheet.get_Range("A3:Z3", Type.Missing);
                    xlSheetRange.Font.Color = ColorTranslator.ToOle(Color.Blue);
                    xlSheetRange.Font.Size = 12;
                    xlSheetRange.Font.Bold = true;
                    xlSheetRange.WrapText = true;
                    xlSheetRange.Font.Bold = true;
                }

                for (rowInd = 0; rowInd < dt.Rows.Count; rowInd++)
                {
                    for (collInd = 0; collInd < dt.Columns.Count; collInd++)
                    {
                        data = dt.Rows[rowInd].ItemArray[collInd].ToString();
                        xlSheet.Cells[rowInd + 4, collInd + 1] = data;
                    }
                }

                xlSheetRange = xlSheet.UsedRange;
                xlSheetRange.Columns.AutoFit();
                xlSheetRange.Rows.AutoFit();
           
                xlSheet.SaveAs("Штрафы за период времени и региону.xlsx");
                xlApp.Interactive = true;
                xlApp.ScreenUpdating = true;
                xlApp.UserControl = true;
                xlApp.Workbooks.Close();
                xlApp.Quit();
                Process[] ps2 = System.Diagnostics.Process.GetProcessesByName("EXCEL");
                foreach (Process p2 in ps2)
                {
                    p2.Kill();
                }
            
        }

        private static DataTable ReportsDateToDateReg(string area, string date1, string date2)//запрос для вывода в эксель
        {
            string connString = @"Database = gaidatabase; DataSource = localhost; user = root; password = root; charset = utf8";
            MySqlConnection con = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                DateTime selectedData1 = Convert.ToDateTime(date1);
                DateTime selectedData2 = Convert.ToDateTime(date2);

                string query = $@"SELECT inspectors.fio AS 'Инспектор', reports.incidTime AS 'Время нарушения', reports.incidDate AS 'Дата нарушения',
                                         town_region.region AS 'Место нарушения', fine_category.describeFine AS 'Нарушение',
                                         reports.sum AS 'Сумма штрафа', reports.planedPayment AS 'Запланированая дата оплаты'
                                  FROM  reports, inspectors, town_region, car_owner, fine_category
                                  WHERE inspectors.idBadge = reports.idBadge and town_region.idRegion = reports.idRegion and car_owner.idOwner = reports.idOwner and
                                        reports.idFine = fine_category.idFine
                                        and reports.idRegion = '{area}' and reports.planedPayment >= '{selectedData1.ToString("yyyy-MM-dd")}'
                                        and reports.planedPayment <= '{selectedData2.ToString("yyyy-MM-dd")}'";
                MySqlCommand comm = new MySqlCommand(query, con);
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(comm);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dt = ds.Tables[0];
            }
            catch
            {
                //MessageBox.Show("error");
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return dt;
        }

        #endregion

        #region Штрафы по водиле

        static public void AdmExcelOw(string area, string area1)//отчет список заявок
        {
            xlApp = new Excel.Application();

            int collInd = 0;
            int rowInd = 9;
            string data = "";
            xlApp.Workbooks.Add(Type.Missing);
            xlApp.Interactive = false;
            xlApp.EnableEvents = false;
            xlSheet = (Excel.Worksheet)xlApp.Sheets[1];
            xlSheet.Name = "Штрафы владельца";

            Excel.Range excelCells1 = xlSheet.Range[xlSheet.Cells[1, 1], xlSheet.Cells[1, 5]];
            xlSheet.Cells[1, 5] = @"Штрафы владельца";

            Excel.Range excelCells2 = xlSheet.Range[xlSheet.Cells[1, 6], xlSheet.Cells[1, 6]];
            xlSheet.Cells[1, 6] = @"Дата формирования";

            Excel.Range excelCells3 = xlSheet.Range[xlSheet.Cells[1, 7], xlSheet.Cells[1, 7]];
            xlSheet.Cells[1, 7] = DateTime.Now.ToString("dd/MM/yyyy");

            xlSheet.Cells.get_Range("A2", "Z2").ColumnWidth = 50;

            excelCells1.Merge(Type.Missing);
            excelCells1.Cells.Font.Bold = true;
            excelCells1.Cells.Font.Size = 20;
            excelCells1.Font.Color = ColorTranslator.ToOle(Color.MidnightBlue);
            excelCells2.Font.Italic = true;
            excelCells3.Cells.Font.Bold = true;

            DataTable dt = ReportsOwn(area, area1);

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                data = dt.Columns[i].ColumnName.ToString();
                xlSheet.Cells[3, i + 1] = data;

                xlSheetRange = xlSheet.get_Range("A3:Z3", Type.Missing);
                xlSheetRange.Font.Color = ColorTranslator.ToOle(Color.Blue);
                xlSheetRange.Font.Size = 12;
                xlSheetRange.Font.Bold = true;
                xlSheetRange.WrapText = true;
                xlSheetRange.Font.Bold = true;
            }

            for (rowInd = 0; rowInd < dt.Rows.Count; rowInd++)
            {
                for (collInd = 0; collInd < dt.Columns.Count; collInd++)
                {
                    data = dt.Rows[rowInd].ItemArray[collInd].ToString();
                    xlSheet.Cells[rowInd + 4, collInd + 1] = data;
                }
            }

            xlSheetRange = xlSheet.UsedRange;
            xlSheetRange.Columns.AutoFit();
            xlSheetRange.Rows.AutoFit();

            xlSheet.SaveAs("Штрафы владельца.xlsx");
            xlApp.Interactive = true;
            xlApp.ScreenUpdating = true;
            xlApp.UserControl = true;
            xlApp.Workbooks.Close();
            xlApp.Quit();
            Process[] ps2 = System.Diagnostics.Process.GetProcessesByName("EXCEL");
            foreach (Process p2 in ps2)
            {
                p2.Kill();
            }

        }

        private static DataTable ReportsOwn(string area, string area1)//запрос для вывода в эксель
        {
            string connString = @"Database = gaidatabase; DataSource = localhost; user = root; password = root; charset = utf8";
            MySqlConnection con = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {

                string query = $@"SELECT inspectors.fio AS 'Инспектор', reports.incidTime AS 'Время нарушения', reports.incidDate AS 'Дата нарушения', town_region.region AS 'Место нарушения', fine_category.describeFine AS 'Нарушение',
                                        reports.sum AS 'Сумма штрафа', reports.planedPayment AS 'Запланированая дата оплаты'
                                 FROM reports, inspectors, town_region, car_owner, fine_category, cars
                                 WHERE inspectors.idBadge = reports.idBadge and town_region.idRegion = reports.idRegion and car_owner.idOwner = reports.idOwner and
                                       reports.idFine = fine_category.idFine and car_owner.idOwner = '{area}' and cars.idOwner = '{area1}'";
                MySqlCommand comm = new MySqlCommand(query, con);
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(comm);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dt = ds.Tables[0];
            }
            catch
            {
                //MessageBox.Show("error");
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return dt;
        }

        #endregion

        #region Штрафы по инспекторычу

        static public void AdmExcelIns(string area)//отчет список заявок
        {
            xlApp = new Excel.Application();

            int collInd = 0;
            int rowInd = 9;
            string data = "";
            xlApp.Workbooks.Add(Type.Missing);
            xlApp.Interactive = false;
            xlApp.EnableEvents = false;
            xlSheet = (Excel.Worksheet)xlApp.Sheets[1];
            xlSheet.Name = "Штрафы по инспектору";

            Excel.Range excelCells1 = xlSheet.Range[xlSheet.Cells[1, 1], xlSheet.Cells[1, 5]];
            xlSheet.Cells[1, 5] = @"Штрафы";

            Excel.Range excelCells2 = xlSheet.Range[xlSheet.Cells[1, 6], xlSheet.Cells[1, 6]];
            xlSheet.Cells[1, 6] = @"Дата формирования";

            Excel.Range excelCells3 = xlSheet.Range[xlSheet.Cells[1, 7], xlSheet.Cells[1, 7]];
            xlSheet.Cells[1, 7] = DateTime.Now.ToString("dd/MM/yyyy");

            xlSheet.Cells.get_Range("A2", "Z2").ColumnWidth = 50;

            excelCells1.Merge(Type.Missing);
            excelCells1.Cells.Font.Bold = true;
            excelCells1.Cells.Font.Size = 20;
            excelCells1.Font.Color = ColorTranslator.ToOle(Color.MidnightBlue);
            excelCells2.Font.Italic = true;
            excelCells3.Cells.Font.Bold = true;

            DataTable dt = ReportsInsp(area);

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                data = dt.Columns[i].ColumnName.ToString();
                xlSheet.Cells[3, i + 1] = data;

                xlSheetRange = xlSheet.get_Range("A3:Z3", Type.Missing);
                xlSheetRange.Font.Color = ColorTranslator.ToOle(Color.Blue);
                xlSheetRange.Font.Size = 12;
                xlSheetRange.Font.Bold = true;
                xlSheetRange.WrapText = true;
                xlSheetRange.Font.Bold = true;
            }

            for (rowInd = 0; rowInd < dt.Rows.Count; rowInd++)
            {
                for (collInd = 0; collInd < dt.Columns.Count; collInd++)
                {
                    data = dt.Rows[rowInd].ItemArray[collInd].ToString();
                    xlSheet.Cells[rowInd + 4, collInd + 1] = data;
                }
            }

            xlSheetRange = xlSheet.UsedRange;
            xlSheetRange.Columns.AutoFit();
            xlSheetRange.Rows.AutoFit();

            xlSheet.SaveAs("Штрафы по инспекторам.xlsx");
            xlApp.Interactive = true;
            xlApp.ScreenUpdating = true;
            xlApp.UserControl = true;
            xlApp.Workbooks.Close();
            xlApp.Quit();
            Process[] ps2 = System.Diagnostics.Process.GetProcessesByName("EXCEL");
            foreach (Process p2 in ps2)
            {
                p2.Kill();
            }

        }

        private static DataTable ReportsInsp(string area)//запрос для вывода в эксель
        {
            string connString = @"Database = gaidatabase; DataSource = localhost; user = root; password = root; charset = utf8";
            MySqlConnection con = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {

                string query = $@"SELECT inspectors.fio AS 'Инспектор', reports.incidTime AS 'Время нарушения', reports.incidDate AS 'Дата нарушения', town_region.region AS 'Место нарушения', fine_category.describeFine AS 'Нарушение',
                                        reports.sum AS 'Сумма штрафа', reports.planedPayment AS 'Запланированая дата оплаты'
                                 FROM reports, inspectors, town_region, car_owner, fine_category
                                 WHERE inspectors.idBadge = reports.idBadge and town_region.idRegion = reports.idRegion and car_owner.idOwner = reports.idOwner and
                                       reports.idFine = fine_category.idFine and reports.idBadge = '{area}'";
                MySqlCommand comm = new MySqlCommand(query, con);
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(comm);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dt = ds.Tables[0];
            }
            catch
            {
                //MessageBox.Show("error");
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return dt;
        }

        #endregion

        #region Штрафы по маркам

        static public void AdmExcelMark(string area)//отчет список заявок
        {
            xlApp = new Excel.Application();

            int collInd = 0;
            int rowInd = 9;
            string data = "";
            xlApp.Workbooks.Add(Type.Missing);
            xlApp.Interactive = false;
            xlApp.EnableEvents = false;
            xlSheet = (Excel.Worksheet)xlApp.Sheets[1];
            xlSheet.Name = "Штрафы по марке";

            Excel.Range excelCells1 = xlSheet.Range[xlSheet.Cells[1, 1], xlSheet.Cells[1, 5]];
            xlSheet.Cells[1, 5] = @"Штрафы";

            Excel.Range excelCells2 = xlSheet.Range[xlSheet.Cells[1, 6], xlSheet.Cells[1, 6]];
            xlSheet.Cells[1, 6] = @"Дата формирования";

            Excel.Range excelCells3 = xlSheet.Range[xlSheet.Cells[1, 7], xlSheet.Cells[1, 7]];
            xlSheet.Cells[1, 7] = DateTime.Now.ToString("dd/MM/yyyy");

            xlSheet.Cells.get_Range("A2", "Z2").ColumnWidth = 50;

            excelCells1.Merge(Type.Missing);
            excelCells1.Cells.Font.Bold = true;
            excelCells1.Cells.Font.Size = 20;
            excelCells1.Font.Color = ColorTranslator.ToOle(Color.MidnightBlue);
            excelCells2.Font.Italic = true;
            excelCells3.Cells.Font.Bold = true;

            DataTable dt = ReportsMrk(area);

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                data = dt.Columns[i].ColumnName.ToString();
                xlSheet.Cells[3, i + 1] = data;

                xlSheetRange = xlSheet.get_Range("A3:Z3", Type.Missing);
                xlSheetRange.Font.Color = ColorTranslator.ToOle(Color.Blue);
                xlSheetRange.Font.Size = 12;
                xlSheetRange.Font.Bold = true;
                xlSheetRange.WrapText = true;
                xlSheetRange.Font.Bold = true;
            }

            for (rowInd = 0; rowInd < dt.Rows.Count; rowInd++)
            {
                for (collInd = 0; collInd < dt.Columns.Count; collInd++)
                {
                    data = dt.Rows[rowInd].ItemArray[collInd].ToString();
                    xlSheet.Cells[rowInd + 4, collInd + 1] = data;
                }
            }

            xlSheetRange = xlSheet.UsedRange;
            xlSheetRange.Columns.AutoFit();
            xlSheetRange.Rows.AutoFit();

            xlSheet.SaveAs("Штрафы по описанию.xlsx");
            xlApp.Interactive = true;
            xlApp.ScreenUpdating = true;
            xlApp.UserControl = true;
            xlApp.Workbooks.Close();
            xlApp.Quit();
            Process[] ps2 = System.Diagnostics.Process.GetProcessesByName("EXCEL");
            foreach (Process p2 in ps2)
            {
                p2.Kill();
            }

        }

        private static DataTable ReportsMrk(string area)//запрос для вывода в эксель
        {
            string connString = @"Database = gaidatabase; DataSource = localhost; user = root; password = root; charset = utf8";
            MySqlConnection con = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {

                string query = $@"SELECT inspectors.fio AS 'Инспектор', reports.incidTime AS 'Время нарушения', reports.incidDate AS 'Дата нарушения', town_region.region AS 'Место нарушения', fine_category.describeFine AS 'Нарушение',
                                        reports.sum AS 'Сумма штрафа', reports.planedPayment AS 'Запланированая дата оплаты'
                                 FROM reports, inspectors, town_region, car_owner, fine_category
                                 WHERE inspectors.idBadge = reports.idBadge and town_region.idRegion = reports.idRegion and car_owner.idOwner = reports.idOwner and
                                       reports.idFine = fine_category.idFine and reports.idFine = '{area}'";
                MySqlCommand comm = new MySqlCommand(query, con);
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(comm);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dt = ds.Tables[0];
            }
            catch
            {
                //MessageBox.Show("error");
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return dt;
        }

        #endregion

        #region Оплаченые штрафы по времени

        static public void AdmExcelNP(string area, string area2)//отчет список заявок
        {
            xlApp = new Excel.Application();

            int collInd = 0;
            int rowInd = 9;
            string data = "";
            xlApp.Workbooks.Add(Type.Missing);
            xlApp.Interactive = false;
            xlApp.EnableEvents = false;
            xlSheet = (Excel.Worksheet)xlApp.Sheets[1];
            xlSheet.Name = "Оплаченные штрафы";

            Excel.Range excelCells1 = xlSheet.Range[xlSheet.Cells[1, 1], xlSheet.Cells[1, 2]];
            xlSheet.Cells[1, 2] = @"Штрафы";

            Excel.Range excelCells2 = xlSheet.Range[xlSheet.Cells[1, 3], xlSheet.Cells[1, 3]];
            xlSheet.Cells[1, 6] = @"Дата формирования";

            Excel.Range excelCells3 = xlSheet.Range[xlSheet.Cells[1, 4], xlSheet.Cells[1, 4]];
            xlSheet.Cells[1, 7] = DateTime.Now.ToString("dd/MM/yyyy");

            xlSheet.Cells.get_Range("A2", "Z2").ColumnWidth = 50;

            excelCells1.Merge(Type.Missing);
            excelCells1.Cells.Font.Bold = true;
            excelCells1.Cells.Font.Size = 20;
            excelCells1.Font.Color = ColorTranslator.ToOle(Color.MidnightBlue);
            excelCells2.Font.Italic = true;
            excelCells3.Cells.Font.Bold = true;

            DataTable dt = ReportsNonPay(area, area2);

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                data = dt.Columns[i].ColumnName.ToString();
                xlSheet.Cells[3, i + 1] = data;

                xlSheetRange = xlSheet.get_Range("A3:Z3", Type.Missing);
                xlSheetRange.Font.Color = ColorTranslator.ToOle(Color.Blue);
                xlSheetRange.Font.Size = 12;
                xlSheetRange.Font.Bold = true;
                xlSheetRange.WrapText = true;
                xlSheetRange.Font.Bold = true;
            }

            for (rowInd = 0; rowInd < dt.Rows.Count; rowInd++)
            {
                for (collInd = 0; collInd < dt.Columns.Count; collInd++)
                {
                    data = dt.Rows[rowInd].ItemArray[collInd].ToString();
                    xlSheet.Cells[rowInd + 4, collInd + 1] = data;
                }
            }

            xlSheetRange = xlSheet.UsedRange;
            xlSheetRange.Columns.AutoFit();
            xlSheetRange.Rows.AutoFit();

            xlSheet.SaveAs("Оплаченые штрафы по промежутку.xlsx");
            xlApp.Interactive = true;
            xlApp.ScreenUpdating = true;
            xlApp.UserControl = true;
            xlApp.Workbooks.Close();
            xlApp.Quit();
            Process[] ps2 = System.Diagnostics.Process.GetProcessesByName("EXCEL");
            foreach (Process p2 in ps2)
            {
                p2.Kill();
            }

        }

        private static DataTable ReportsNonPay(string area, string area2)//запрос для вывода в эксель
        {
            string connString = @"Database = gaidatabase; DataSource = localhost; user = root; password = root; charset = utf8";
            MySqlConnection con = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                DateTime selectedData1 = Convert.ToDateTime(area);
                DateTime selectedData2 = Convert.ToDateTime(area2);

                string query = $@"SELECT inspectors.fio AS 'Инспектор', reports.incidTime AS 'Время нарушения', reports.incidDate AS 'Дата нарушения',
                                         town_region.region AS 'Место нарушения', fine_category.describeFine AS 'Нарушение',
                                         reports.sum AS 'Сумма штрафа', reports.planedPayment AS 'Запланированая дата оплаты'
                                  FROM  reports, inspectors, town_region, car_owner, fine_category
                                  WHERE inspectors.idBadge = reports.idBadge and town_region.idRegion = reports.idRegion and car_owner.idOwner = reports.idOwner and
                                        reports.idFine = fine_category.idFine
                                        and reports.payed = 'Оплачено' and reports.planedPayment >= '{selectedData1.ToString("yyyy-MM-dd")}'
                                        and reports.planedPayment <= '{selectedData2.ToString("yyyy-MM-dd")}'";

                MySqlCommand comm = new MySqlCommand(query, con);
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(comm);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dt = ds.Tables[0];
            }
            catch
            {
                //MessageBox.Show("error");
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return dt;
        }

        #endregion

        #endregion
    }
}