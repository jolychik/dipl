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

namespace ProgUP.HelpForms
{
    public partial class DateToDateForm : System.Windows.Forms.Form
    {
        public DateToDateForm()
        {
            InitializeComponent();
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Stream myStream;
            //SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            //saveFileDialog1.Filter = "Excel (*.xlsx)|*.xlsx";
            //saveFileDialog1.FilterIndex = 2;
            //saveFileDialog1.RestoreDirectory = true;

            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    if ((myStream = saveFileDialog1.OpenFile()) != null)
            //    {
            //        Classes.ExcelStuff.SqlToExcelsFDTD(classes.Autorisation.user, dateTimePicker1.Text, dateTimePicker2.Text);

            //        myStream.Close();
            //    }
            //}

            Classes.ExcelStuff.SqlToExcelsFDTD(classes.Autorisation.user, dateTimePicker1.Text, dateTimePicker2.Text);
            this.Close();
        }

        private void DateToDateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
