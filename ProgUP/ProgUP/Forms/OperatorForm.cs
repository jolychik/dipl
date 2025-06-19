using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProgUP.forms
{
    public partial class OperatorForm : Form
    {

        public static string tabidOwner, tabfirstName, tabsecondName, tabpatronomyc, tabidDriverRights,
                             tabownerRegDate, tabadres, tabemail, tablogin, tabpassword, tabtelephone;

        public static string tabPTS, tabidMark, tabidcolor, tabIdCarOwner,
                             tabModel, tabreliseDate, tabGosNum, tabRegDate;

        public static string tabIdReport, tabIdInspector, tabIdTime, tabIncidDate, tabIdRegion,
                             tabIdOwner, tabIdFine, tabSum, tabPlanedPayment, tabFactPay, taboplata;

        public OperatorForm()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(lblTitle_MouseDown);
        }

        #region LoadStuff

        private void OperatorForm_Load(object sender, EventArgs e)
        {
            classes.Tables.OwnerShow();
            dataGridView1.DataSource = classes.Tables.OwnerTable;

            classes.Tables.CarShow();
            dataGridView2.DataSource = classes.Tables.CarTable;

            classes.Tables.ReportsShow();
            dataGridView3.DataSource = classes.Tables.ReportTable;

            classes.Tables.Inspectors();
            inspectorcombo.DataSource = classes.Tables.inspectorTable;
            inspectorcombo.DisplayMember = "fio";
            inspectorcombo.ValueMember = "idBadge";

            classes.Tables.Region();
            regioncombo.DataSource = classes.Tables.TownRegTable;
            regioncombo.DisplayMember = "region";
            regioncombo.ValueMember = "idRegion";

            classes.Tables.Drivers();
            ownercombo.DataSource = classes.Tables.DriversTable;
            ownercombo.DisplayMember = "info";
            ownercombo.ValueMember = "idOwner";

            classes.Tables.Fine();
            finecombo.DataSource = classes.Tables.fineTable;
            finecombo.DisplayMember = "describeFine";
            finecombo.ValueMember = "idFine";

            classes.Tables.SMark();
            markcombo.DataSource = classes.Tables.MarkSTable;
            markcombo.DisplayMember = "Mark";
            markcombo.ValueMember = "idMark";

            classes.Tables.SColor();
            colorcombo.DataSource = classes.Tables.ColorSTable;
            colorcombo.DisplayMember = "Color";
            colorcombo.ValueMember = "idColor";

            classes.Tables.Drivers();
            ownercmb.DataSource = classes.Tables.DriversTable;
            ownercmb.DisplayMember = "info1";
            ownercmb.ValueMember = "idOwner";

            sortOplataCombo.Text = "Не выбрано";
        }

        #endregion

        #region FormButtons

        private void button5_Click(object sender, EventArgs e)
        {

            forms.AutorisationForm autFrm = new forms.AutorisationForm();
            autFrm.Show();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region AddButtons

        private void button1_Click(object sender, EventArgs e)
        {
            forms.AddOwnerForm ownFrm = new forms.AddOwnerForm();
            ownFrm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            forms.AddCarsForm carFrm = new forms.AddCarsForm();
            carFrm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            forms.AddReportForm repFrm = new forms.AddReportForm();
            repFrm.ShowDialog();
        }

        #endregion

        #region EditButtons

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                tabidOwner = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                tabfirstName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                tabsecondName = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                tabpatronomyc = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                tabidDriverRights = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                tabownerRegDate = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                tabadres = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                tabemail = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                tablogin = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                tabpassword = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                tabtelephone = dataGridView1.CurrentRow.Cells[10].Value.ToString();

                forms.EditOwnerForm eOwnerFrm = new forms.EditOwnerForm();
                eOwnerFrm.ShowDialog();
            }
            catch
            { MessageBox.Show("В таблице нет записей"); }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void carEditButton_Click(object sender, EventArgs e)
        {
            try
            {
                tabPTS = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                tabidMark = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                tabidcolor = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                tabIdCarOwner = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                tabModel = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                tabreliseDate = dataGridView2.CurrentRow.Cells[5].Value.ToString();
                tabGosNum = dataGridView2.CurrentRow.Cells[6].Value.ToString();
                tabRegDate = dataGridView2.CurrentRow.Cells[7].Value.ToString();

                forms.EditCarsForm eCarsFrm = new forms.EditCarsForm();
                eCarsFrm.ShowDialog();
            }
            catch
            { MessageBox.Show("В таблице нет записей"); }
        }

        private void reportsEditButton_Click(object sender, EventArgs e)
        {
            tabIdReport = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            tabIdInspector = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            tabIdTime = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            tabIncidDate = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            tabIdRegion = dataGridView3.CurrentRow.Cells[4].Value.ToString();
            tabIdOwner = dataGridView3.CurrentRow.Cells[5].Value.ToString();
            tabIdFine = dataGridView3.CurrentRow.Cells[6].Value.ToString();
            tabSum = dataGridView3.CurrentRow.Cells[7].Value.ToString();
            tabPlanedPayment = dataGridView3.CurrentRow.Cells[8].Value.ToString();
            tabFactPay = dataGridView3.CurrentRow.Cells[9].Value.ToString();
            taboplata = dataGridView3.CurrentRow.Cells[10].Value.ToString();

            forms.EditReportForm eReportFrm = new forms.EditReportForm();
            eReportFrm.ShowDialog();
        }

        #endregion

        #region DeleteButtons

        private void reportDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string idReport = dataGridView3.CurrentRow.Cells[0].Value.ToString();

                DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить запись: " + idReport + "?", "Подтвердите действие", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    classes.DeleteTable.DeleteReport(idReport);
                    classes.Tables.ReportsShow();
                }
                else if (dialogResult == DialogResult.No)
                    return;
            }
            catch
            { MessageBox.Show("В таблице нет записей"); }
        }

        private void ownerDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string idOwner = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить запись: " + idOwner + "?", "Подтвердите действие", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    classes.DeleteTable.DeleteOwner(idOwner);
                    classes.Tables.OwnerShow();
                }
                else if (dialogResult == DialogResult.No)
                    return;
            }
            catch
            { MessageBox.Show("В таблице нет записей"); }
        }

        private void carDelete_Click(object sender, EventArgs e)
        {
            string PTS = dataGridView2.CurrentRow.Cells[0].Value.ToString();

            try
            {
                DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить\nмашину с номером ПТС: " + PTS + "?", "Подтвердите действие", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    classes.DeleteTable.DeleteCar(PTS);
                    classes.Tables.CarShow();
                }
                else if (dialogResult == DialogResult.No)
                    return;
            }
            catch
            { MessageBox.Show("В таблице нет записей"); }
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            lblTitle.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        #endregion

        #region OtherButtons

        private void FilterButton_Click(object sender, EventArgs e)
        {
            if (sortOplataCombo.Text == "Не выбрано")
            {
                classes.Tables.ReportsShow();
                dataGridView3.DataSource = classes.Tables.ReportTable;
            }
            else
            {
                classes.Filters.RepOlataFilter(sortOplataCombo.Text);
                dataGridView3.DataSource = classes.Filters.oplataSortTable;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            classes.Tables.ReportsShow();
            dataGridView3.DataSource = classes.Tables.ReportTable;
        }

        private void InspButtFilt_Click(object sender, EventArgs e)
        {
            classes.Filters.RepInspectorFilter(inspectorcombo.SelectedValue.ToString());
            dataGridView3.DataSource = classes.Filters.inspSortTable;
        }

        private void reionFilterButton_Click(object sender, EventArgs e)
        {
            classes.Filters.RepRegionFilter(regioncombo.SelectedValue.ToString());
            dataGridView3.DataSource = classes.Filters.regionSortTable;
        }

        private void OwnFilterButton_Click(object sender, EventArgs e)
        {
            classes.Filters.RepOwnerFilter(ownercombo.SelectedValue.ToString());
            dataGridView3.DataSource = classes.Filters.ownerSortTable;
        }

        private void FineFilterButton_Click(object sender, EventArgs e)
        {
            classes.Filters.RepFineFilter(finecombo.SelectedValue.ToString());
            dataGridView3.DataSource = classes.Filters.fineSortTable;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            classes.Filters.RepDateSostFilter(dateTimePicker1.Text);
            dataGridView3.DataSource = classes.Filters.dateSostSortTable;
        }

        private void marbutton_Click(object sender, EventArgs e)
        {
            classes.Filters.MarkFilter(markcombo.SelectedValue.ToString());
            dataGridView2.DataSource = classes.Filters.marlSortTable;
        }

        private void ownbutton_Click(object sender, EventArgs e)
        {
            classes.Filters.OwnFilter(ownercmb.SelectedValue.ToString());
            dataGridView2.DataSource = classes.Filters.idOwnSortTable;
        }

        private void colorbutton_Click(object sender, EventArgs e)
        {
            classes.Filters.ColorFilter(colorcombo.SelectedValue.ToString());
            dataGridView2.DataSource = classes.Filters.colorSortTable;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            classes.Tables.CarShow();
            dataGridView2.DataSource = classes.Tables.CarTable;
        }

        private void DateRegbutton_Click(object sender, EventArgs e)
        {
            classes.Filters.RegDateFilter(dateTimePicker2.Text);
            dataGridView1.DataSource = classes.Filters.regdateSortTable;
        }

        private void Dolgbutton_Click(object sender, EventArgs e)
        {
            switch (DolgBox.Text)
            {
                case "Не выбрано":

                    classes.Tables.OwnerShow();
                    dataGridView1.DataSource = classes.Tables.OwnerTable;

                    break;

                case "Есть":

                    classes.Filters.DolgNotNullFilter();
                    dataGridView1.DataSource = classes.Filters.dolgPlusSortTable;

                    break;

                case "Отсутствует":

                    classes.Filters.DolgNullFilter();
                    dataGridView1.DataSource = classes.Filters.dolgNullSortTable;

                    break;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            classes.Tables.OwnerShow();
            dataGridView1.DataSource = classes.Tables.OwnerTable;
        }

        #endregion

        #region FindTextBoxes

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            classes.Sort.FindSecName(FIOtextBox.Text);
            dataGridView1.DataSource = classes.Sort.FindSecNmTab;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            classes.Sort.FindEmail(EMAILtextBox.Text);
            dataGridView1.DataSource = classes.Sort.FindEmailTab;
        }

        private void GostextBox_TextChanged(object sender, EventArgs e)
        {
            classes.Sort.FindGosNum(GostextBox.Text);
            dataGridView2.DataSource = classes.Sort.FindGosTab;
        }

        private void PTStextBox_TextChanged(object sender, EventArgs e)
        {
            classes.Sort.FindPTS(PTStextBox.Text);
            dataGridView2.DataSource = classes.Sort.FindPTSTab;
        }

        private void ModeltextBox_TextChanged(object sender, EventArgs e)
        {
            classes.Sort.FindModel(ModeltextBox.Text);
            dataGridView2.DataSource = classes.Sort.FindModelTab;
        }

        private void FtextBox_TextChanged(object sender, EventArgs e)
        {
            classes.Sort.FindFIO(FtextBox.Text);
            dataGridView3.DataSource = classes.Sort.FindInspTab;
        }

        private void InsptextBox_TextChanged(object sender, EventArgs e)
        {
            classes.Sort.FindInspector(InsptextBox.Text);
            dataGridView3.DataSource = classes.Sort.FindFIOTab;
        }

        #endregion

    }
}