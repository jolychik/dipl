using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgUP.Forms
{
    public partial class ImportForm : Form
    {
        public ImportForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = !comboBox1.Visible;
            button6.Visible = !button6.Visible;
            button8.Visible = !button8.Visible;
        }

        private void ImportForm_Load(object sender, EventArgs e)
        {
            classes.Tables.Drivers();
            comboBox1.DataSource = classes.Tables.DriversTable;
            comboBox1.DisplayMember = "info1";
            comboBox1.ValueMember = "idOwner";

            classes.Tables.Region();
            comboBox3.DataSource = classes.Tables.TownRegTable;
            comboBox3.DisplayMember = "region";
            comboBox3.ValueMember = "idRegion";

            comboBox2.DataSource = classes.Tables.DriversTable;
            comboBox2.DisplayMember = "info1";
            comboBox2.ValueMember = "idOwner";

            comboBox4.DataSource = classes.Tables.DriversTable;
            comboBox4.DisplayMember = "info1";
            comboBox4.ValueMember = "idOwner";

            classes.Tables.Inspectors();
            comboBox5.DataSource = classes.Tables.inspectorTable;
            comboBox5.DisplayMember = "fio";
            comboBox5.ValueMember = "idBadge";

            classes.Tables.Fine();
            comboBox6.DataSource = classes.Tables.fineTable;
            comboBox6.DisplayMember = "describeFine";
            comboBox6.ValueMember = "idFine";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите выбрать регион " + comboBox1.Text + "?", "Подтвердите действие", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Classes.ExcelStuff.AdmExcelOC(comboBox1.SelectedValue.ToString(), comboBox1.SelectedValue.ToString());

                comboBox1.Visible = !comboBox1.Visible;
                button6.Visible = !button6.Visible;
                button8.Visible = !button8.Visible;
            }
            else if (dialogResult == DialogResult.No)
                return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Width = 627;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Classes.ExcelStuff.AdmExcelDTD(comboBox2.SelectedValue.ToString(), dateTimePicker1.Text, dateTimePicker2.Text, comboBox2.Text);

            this.Width = 212;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Width = 627;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Classes.ExcelStuff.AdmExcelRgDTD(comboBox3.SelectedValue.ToString(), dateTimePicker3.Text, dateTimePicker4.Text);

            this.Width = 212;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            comboBox4.Visible = !comboBox4.Visible;
            button9.Visible = !button9.Visible;
            button7.Visible = !button7.Visible;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите выбрать " + comboBox4.Text + "?", "Подтвердите действие", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Classes.ExcelStuff.AdmExcelOw(comboBox1.SelectedValue.ToString(), comboBox1.SelectedValue.ToString());

                comboBox4.Visible = !comboBox4.Visible;
                button9.Visible = !button9.Visible;
                button7.Visible = !button7.Visible;
            }
            else if (dialogResult == DialogResult.No)
                return;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox5.Visible = !comboBox5.Visible;
            button5.Visible = !button5.Visible;
            button10.Visible = !button10.Visible;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите выбрать " + comboBox5.Text + "?", "Подтвердите действие", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Classes.ExcelStuff.AdmExcelIns(comboBox5.SelectedValue.ToString());

                comboBox5.Visible = !comboBox5.Visible;
                button5.Visible = !button5.Visible;
                button10.Visible = !button10.Visible;
            }
            else if (dialogResult == DialogResult.No)
                return;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            comboBox6.Visible = !comboBox6.Visible;
            button12.Visible = !button12.Visible;
            button11.Visible = !button11.Visible;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите выбрать " + comboBox6.Text + "?", "Подтвердите действие", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Classes.ExcelStuff.AdmExcelMark(comboBox6.SelectedValue.ToString());

                comboBox6.Visible = !comboBox6.Visible;
                button12.Visible = !button12.Visible;
                button11.Visible = !button11.Visible;
            }
            else if (dialogResult == DialogResult.No)
                return;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Width = 627;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Classes.ExcelStuff.AdmExcelNP(dateTimePicker5.Text, dateTimePicker6.Text);

            this.Width = 212;
        }
    }
}
