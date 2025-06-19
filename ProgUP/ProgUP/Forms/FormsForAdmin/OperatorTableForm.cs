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
    public partial class OperatorTableForm : System.Windows.Forms.Form
    {
        public OperatorTableForm()
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

        private void OperatorTableForm_Load(object sender, EventArgs e)
        {
            classes.Tables.OperatorShow();
            dataGridView1.DataSource = classes.Tables.OperotorTable;
        }

        private void FtextBox_TextChanged(object sender, EventArgs e)
        {
            classes.Sort.FindOperator(FtextBox.Text);
            dataGridView1.DataSource = classes.Sort.FindOperat;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            classes.Sort.FindOperatorLog(textBox7.Text);
            dataGridView1.DataSource = classes.Sort.FindOperatLog;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            //classes.CheckStuff.LatinAndNumbers(e);
        }

        private void FtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //classes.CheckStuff.KirillicLatters(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //classes.CheckStuff.LatinAndNumbers(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //classes.CheckStuff.LatinAndNumbers(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            //classes.CheckStuff.KirillicLatters(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //classes.CheckStuff.LatinAndNumbers(e);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            //classes.CheckStuff.LatinAndNumbers(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            classes.AddTable.AddOperator(textBox2.Text, textBox4.Text, textBox5.Text);
            classes.Tables.OperatorShow();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            classes.EditTable.OperatorEdit(dataGridView1.CurrentRow.Cells[0].Value.ToString(), textBox1.Text, textBox6.Text, textBox3.Text);
            classes.Tables.OperatorShow();
        }

        private void carDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтвердите действие", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    classes.DeleteTable.OperatorsDelete(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    classes.Tables.OperatorShow();
                }
                else if (dialogResult == DialogResult.No)
                    return;
            }
            catch
            { MessageBox.Show("В таблице нет записей"); }
        }

        private void CarAddButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = !groupBox1.Visible;
        }

        private void carEditButton_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = !groupBox2.Visible;

            label2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString(); ;
            textBox6.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString(); ;
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString(); ;
        }
    }
}
