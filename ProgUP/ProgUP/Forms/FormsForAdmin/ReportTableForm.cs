using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgUP.FormsForAdmin
{
    public partial class ReportTableForm : System.Windows.Forms.Form
    {
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

        public ReportTableForm()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(lblTitle_MouseDown);
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            lblTitle.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ReportTableForm_Load(object sender, EventArgs e)
        {
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

            sortOplataCombo.Text = "Не выбрано";
        }

        private void reportAddButton_Click(object sender, EventArgs e)
        {
            forms.AddReportForm repFrm = new forms.AddReportForm();
            repFrm.ShowDialog();
        }

        private void reportsEditButton_Click(object sender, EventArgs e)
        {
            forms.OperatorForm.tabIdReport = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            forms.OperatorForm.tabIdInspector = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            forms.OperatorForm.tabIdTime = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            forms.OperatorForm.tabIncidDate = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            forms.OperatorForm.tabIdRegion = dataGridView3.CurrentRow.Cells[4].Value.ToString();
            forms.OperatorForm.tabIdOwner = dataGridView3.CurrentRow.Cells[5].Value.ToString();
            forms.OperatorForm.tabIdFine = dataGridView3.CurrentRow.Cells[6].Value.ToString();
            forms.OperatorForm.tabSum = dataGridView3.CurrentRow.Cells[7].Value.ToString();
            forms.OperatorForm.tabPlanedPayment = dataGridView3.CurrentRow.Cells[8].Value.ToString();
            forms.OperatorForm.tabFactPay = dataGridView3.CurrentRow.Cells[9].Value.ToString();
            forms.OperatorForm.taboplata = dataGridView3.CurrentRow.Cells[10].Value.ToString();

            forms.EditReportForm eReportFrm = new forms.EditReportForm();
            eReportFrm.ShowDialog();
        }

        private void reportDelete_Click(object sender, EventArgs e)
        {
            string idReport = dataGridView3.CurrentRow.Cells[0].Value.ToString();

            try
            {
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

        private void FtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            classes.CheckStuff.KirillicLatters(e);
        }

        private void InsptextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            classes.CheckStuff.KirillicLatters(e);
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            classes.Filters.RepDateSostFilter(dateTimePicker1.Text);
            dataGridView3.DataSource = classes.Filters.dateSostSortTable;
        }

        private void InspButtFilt_Click(object sender, EventArgs e)
        {
            classes.Filters.RepInspectorFilter(inspectorcombo.SelectedValue.ToString());
            dataGridView3.DataSource = classes.Filters.inspSortTable;
        }

        private void ReionFilterButton_Click(object sender, EventArgs e)
        {
            classes.Filters.RepRegionFilter(regioncombo.SelectedValue.ToString());
            dataGridView3.DataSource = classes.Filters.regionSortTable;
        }

        private void FineFilterButton_Click(object sender, EventArgs e)
        {
            classes.Filters.RepFineFilter(finecombo.SelectedValue.ToString());
            dataGridView3.DataSource = classes.Filters.fineSortTable;
        }

        private void OwnFilterButton_Click(object sender, EventArgs e)
        {
            classes.Filters.RepOwnerFilter(ownercombo.SelectedValue.ToString());
            dataGridView3.DataSource = classes.Filters.ownerSortTable;
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            classes.Tables.ReportsShow();
            dataGridView3.DataSource = classes.Tables.ReportTable;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
