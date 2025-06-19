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
    public partial class MarkTableForm : System.Windows.Forms.Form
    {
        public MarkTableForm()
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

        private void CarAddButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = !groupBox1.Visible;
        }

        private void carEditButton_Click(object sender, EventArgs e)
        {
            string mark;

            mark = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            textBox2.Text = mark;
            label2.Text = mark;

            groupBox2.Visible = !groupBox2.Visible;
        }

        private void carDelete_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтвердите действие", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                classes.DeleteTable.MarksDelete(id);
                classes.Tables.MarkShow();
            }
            else if (dialogResult == DialogResult.No)
                return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            classes.AddTable.AddMark(textBox1.Text);
            classes.Tables.MarkShow();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            classes.EditTable.MarkEdit(id, textBox2.Text);
            classes.Tables.MarkShow();
        }

        private void MarkTableForm_Load(object sender, EventArgs e)
        {
            classes.Tables.MarkShow();
            dataGridView1.DataSource = classes.Tables.MarkTable;
        }

        private void FtextBox_TextChanged(object sender, EventArgs e)
        {
            classes.Sort.FindMark(FtextBox.Text);
            dataGridView1.DataSource = classes.Sort.FindMar;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            classes.CheckStuff.KirillicLatters(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            classes.CheckStuff.KirillicLatters(e);
        }
    }
}
