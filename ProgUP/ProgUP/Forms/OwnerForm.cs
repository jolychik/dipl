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
using MSExcel = Microsoft.Office.Interop.Excel;
using ProgUP.Classes;

namespace ProgUP.forms
{
    public partial class OwnerForm : Form
    {
        public OwnerForm()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(lblTitle_MouseDown);
        }

        private void OwnerForm_Load(object sender, EventArgs e)
        {
            classes.Tables.IndOwnerShow(classes.Autorisation.user);
            dataGridView1.DataSource = classes.Tables.indOwnerTable;

            classes.Tables.CarOwnFormShow(classes.Autorisation.user);
            dataGridView2.DataSource = classes.Tables.CarOwnFrmTable;

            classes.Tables.ReportsOwnerShow(classes.Autorisation.user);
            dataGridView3.DataSource = classes.Tables.ReportOwnerTable;

            classes.Tables.Inspectors();
            inspectorcombo.DataSource = classes.Tables.inspectorTable;
            inspectorcombo.DisplayMember = "fio";
            inspectorcombo.ValueMember = "idBadge";

            classes.Tables.Region();
            regioncombo.DataSource = classes.Tables.TownRegTable;
            regioncombo.DisplayMember = "region";
            regioncombo.ValueMember = "idRegion";

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

            comboBox1.Visible = false;
            button6.Visible = false;

            string bruh = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            if (Convert.ToInt32(bruh) > 0)
            {
                MessageBox.Show("Здраствуйте гражданин!\nУ вас есть не оплаченная сумма долга:\n" + bruh + "руб.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            lblTitle.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            forms.AutorisationForm autFrm = new forms.AutorisationForm();
            autFrm.Show();
            this.Close();
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            if (sortOplataCombo.Text == "Не выбрано")
            {
                classes.Tables.ReportsOwnerShow(classes.Autorisation.user);
                dataGridView3.DataSource = classes.Tables.ReportOwnerTable;
            }
            else
            {
                classes.Filters.IndOplataFilter(sortOplataCombo.Text, classes.Autorisation.user);
                dataGridView3.DataSource = classes.Filters.oplataSortTable;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            classes.Filters.IndDateSostFilter(dateTimePicker1.Text, classes.Autorisation.user);
            dataGridView3.DataSource = classes.Filters.dateSostSortTable;
        }

        private void InspButtFilt_Click(object sender, EventArgs e)
        {
            classes.Filters.IndInspectorFilter(inspectorcombo.SelectedValue.ToString(), classes.Autorisation.user);
            dataGridView3.DataSource = classes.Filters.inspSortTable;
        }

        private void ReionFilterButton_Click(object sender, EventArgs e)
        {
            classes.Filters.IndRegionFilter(regioncombo.SelectedValue.ToString(), classes.Autorisation.user);
            dataGridView3.DataSource = classes.Filters.regionSortTable;
        }

        private void FineFilterButton_Click(object sender, EventArgs e)
        {
            classes.Filters.IndFineFilter(finecombo.SelectedValue.ToString(), classes.Autorisation.user);
            dataGridView3.DataSource = classes.Filters.fineSortTable;
        }


        private void marbutton_Click(object sender, EventArgs e)
        {
            classes.Filters.IndMarkFilter(markcombo.SelectedValue.ToString(), classes.Autorisation.user);
            dataGridView2.DataSource = classes.Filters.marlSortTable;
        }

        private void colorbutton_Click(object sender, EventArgs e)
        {
            classes.Filters.IndColorFilter(colorcombo.SelectedValue.ToString(), classes.Autorisation.user);
            dataGridView2.DataSource = classes.Filters.colorSortTable;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            classes.Tables.CarOwnFormShow(classes.Autorisation.user);
            dataGridView2.DataSource = classes.Tables.CarOwnFrmTable;
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            classes.Tables.ReportsOwnerShow(classes.Autorisation.user);
            dataGridView3.DataSource = classes.Tables.ReportOwnerTable;
        }

        private void GostextBox_TextChanged(object sender, EventArgs e)
        {
            classes.Sort.IndFindGosNum(GostextBox.Text, classes.Autorisation.user);
            dataGridView2.DataSource = classes.Sort.FindGosTab;
        }

        private void PTStextBox_TextChanged(object sender, EventArgs e)
        {
            classes.Sort.IndFindPTS(PTStextBox.Text, classes.Autorisation.user);
            dataGridView2.DataSource = classes.Sort.FindPTSTab;
        }

        private void ModeltextBox_TextChanged(object sender, EventArgs e)
        {
            classes.Sort.IndFindModel(ModeltextBox.Text, classes.Autorisation.user);
            dataGridView2.DataSource = classes.Sort.FindModelTab;
        }

        private void FtextBox_TextChanged(object sender, EventArgs e)
        {
            classes.Sort.IndFindFIO(FtextBox.Text, classes.Autorisation.user);
            dataGridView3.DataSource = classes.Sort.FindInspTab;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Classes.ExcelStuff.SqlToExcelsF(classes.Autorisation.user);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HelpForms.DateToDateForm hlpFrm = new HelpForms.DateToDateForm();
            hlpFrm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.DataSource = classes.Tables.TownRegTable;
            comboBox1.DisplayMember = "region";
            comboBox1.ValueMember = "idRegion";

            comboBox1.Visible = !comboBox1.Visible;
            button6.Visible = !button6.Visible;

            button5.Visible = !button5.Visible;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите выбрать регион " + comboBox1.Text + "?", "Подтвердите действие", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Classes.ExcelStuff.SqlToExcelsR(comboBox1.SelectedValue.ToString(), classes.Autorisation.user);

                comboBox1.Visible = !comboBox1.Visible;
                button6.Visible = !button6.Visible;
                button5.Visible = !button5.Visible;
            }
            else if (dialogResult == DialogResult.No)
                return;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //MSExcel.Application excel = new MSExcel.Application();

            //excel.Workbooks.Add();
            //MSExcel.Worksheet wsh = excel.ActiveSheet;

            //int i, j;
            //for (i = 0;i<)

            //excel.Visible = true;
            Classes.ExcelStuff.SqlToExcelsSP(classes.Autorisation.user);
        }


        private void imgLogo_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
