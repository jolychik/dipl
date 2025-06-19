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
    public partial class OwnerTableForm : System.Windows.Forms.Form
    {
        private void OwnerTableForm_Load(object sender, EventArgs e)
        {
            classes.Tables.OwnerShow();
            dataGridView1.DataSource = classes.Tables.OwnerTable;
        }

        private void EMAILtextBox_TextChanged(object sender, EventArgs e)
        {
                classes.Sort.FindSecName(FIOtextBox.Text);
                dataGridView1.DataSource = classes.Sort.FindSecNmTab;
        }

        private void FIOtextBox_TextChanged(object sender, EventArgs e)
        {
            classes.Sort.FindEmail(EMAILtextBox.Text);
            dataGridView1.DataSource = classes.Sort.FindEmailTab;
        }

        public OwnerTableForm()
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

        private void reportAddButton_Click(object sender, EventArgs e)
        {
            forms.AddOwnerForm ownFrm = new forms.AddOwnerForm();
            ownFrm.ShowDialog();
        }

        private void reportsEditButton_Click(object sender, EventArgs e)
        {
            try
            {
                forms.OperatorForm.tabidOwner = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                forms.OperatorForm.tabfirstName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                forms.OperatorForm.tabsecondName = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                forms.OperatorForm.tabpatronomyc = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                forms.OperatorForm.tabidDriverRights = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                forms.OperatorForm.tabownerRegDate = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                forms.OperatorForm.tabadres = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                forms.OperatorForm.tabemail = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                forms.OperatorForm.tablogin = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                forms.OperatorForm.tabpassword = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                forms.OperatorForm.tabtelephone = dataGridView1.CurrentRow.Cells[10].Value.ToString();

                forms.EditOwnerForm eOwnerFrm = new forms.EditOwnerForm();
                eOwnerFrm.ShowDialog();
            }
            catch
            { MessageBox.Show("В таблице нет записей"); }
        }

        private void reportDelete_Click(object sender, EventArgs e)
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

        private void EMAILtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            classes.CheckStuff.LatinAndNumbers(e);
        }

        private void FIOtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            classes.CheckStuff.KirillicLatters(e);
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

        private void button2_Click(object sender, EventArgs e)
        {
            classes.Tables.OwnerShow();
            dataGridView1.DataSource = classes.Tables.OwnerTable;
        }
    }
}
