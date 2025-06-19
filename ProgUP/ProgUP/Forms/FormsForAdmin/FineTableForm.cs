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
    public partial class FineTableForm : System.Windows.Forms.Form
    {
        public FineTableForm()
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

        private void FineTableForm_Load(object sender, EventArgs e)
        {
            classes.Tables.FineShow();
            dataGridView1.DataSource = classes.Tables.FineTable;
        }

        private void CarAddButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = !groupBox1.Visible;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pudge = textBox7.Text + comboBox5.Text;

            classes.AddTable.AddFine(textBox5.Text, textBox1.Text, textBox2.Text, comboBox1.Text, comboBox2.Text, pudge);
            classes.Tables.FineShow();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            string pudge = textBox8.Text + comboBox6.Text;

            classes.EditTable.FineEdit(textBox6.Text, textBox3.Text, textBox4.Text, comboBox3.Text, comboBox4.Text, pudge);
            classes.Tables.FineShow();
        }

        private void carDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтвердите действие", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    classes.DeleteTable.DeleteReport(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    classes.Tables.FineShow();
                }
                else if (dialogResult == DialogResult.No)
                    return;
            }
            catch
            { MessageBox.Show("В таблице нет записей"); }
        }

        private void carEditButton_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = !groupBox2.Visible;

            textBox6.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void FtextBox_TextChanged(object sender, EventArgs e)
        {
            classes.Sort.FindFine(FtextBox.Text);
            dataGridView1.DataSource = classes.Sort.FindFin;
        }

        private void FtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            classes.CheckStuff.KirillicLatters(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            classes.CheckStuff.Numbers(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            classes.CheckStuff.KirillicLatters(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            classes.CheckStuff.KirillicLatters(e);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Да")
            {
                textBox7.Enabled = true;
                comboBox5.Enabled = true;
            }
            else
            {
                textBox7.Enabled = false;
                comboBox5.Enabled = false;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "Да")
            {
                textBox7.Enabled = true;
                comboBox5.Enabled = true;
            }
            else
            {
                textBox7.Enabled = false;
                comboBox5.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            classes.Filters.FineFilterAtention(comboBox7.Text);
            dataGridView1.DataSource = classes.Filters.FineAtSortTable;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            classes.Filters.FineFilterDepeort(comboBox8.Text);
            dataGridView1.DataSource = classes.Filters.FineDepSortTable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            classes.Tables.FineShow();
            dataGridView1.DataSource = classes.Tables.FineTable;
        }
    }
}
