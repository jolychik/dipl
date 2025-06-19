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

namespace ProgUP.FormsForAdmin
{
    public partial class CarTableForm : System.Windows.Forms.Form
    {
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

        private void CarTableForm_Load(object sender, EventArgs e)
        {
            classes.Tables.CarShow();
            dataGridView2.DataSource = classes.Tables.CarTable;

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
        }

        private void CarAddButton_Click(object sender, EventArgs e)
        {
            forms.AddCarsForm carFrm = new forms.AddCarsForm();
            carFrm.ShowDialog();
        }

        public CarTableForm()
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

        private void carDelete_Click(object sender, EventArgs e)
        {
            string PTS = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            
            try
            {
                DialogResult dialogResult = MessageBox.Show($"Вы действительно хотите удалить\nмашину с номером ПТС: {PTS}?", "Подтвердите действие", MessageBoxButtons.YesNo);
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

        private void carEditButton_Click(object sender, EventArgs e)
        {
            try
            {
                forms.OperatorForm.tabPTS = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                forms.OperatorForm.tabidMark = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                forms.OperatorForm.tabidcolor = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                forms.OperatorForm.tabIdCarOwner = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                forms.OperatorForm.tabModel = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                forms.OperatorForm.tabreliseDate = dataGridView2.CurrentRow.Cells[5].Value.ToString();
                forms.OperatorForm.tabGosNum = dataGridView2.CurrentRow.Cells[6].Value.ToString();
                forms.OperatorForm.tabRegDate = dataGridView2.CurrentRow.Cells[7].Value.ToString();

                forms.EditCarsForm eCarsFrm = new forms.EditCarsForm();
                eCarsFrm.Show();
            }
            catch
            { MessageBox.Show("В таблице нет записей"); }
        }

        private void GostextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            classes.CheckStuff.KirillicAndNumbers(e);
        }

        private void PTStextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            classes.CheckStuff.Numbers(e);
        }
    }
}
