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
    public partial class AdminForm : Form
    {
        public AdminForm()
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

        private void button4_Click(object sender, EventArgs e)
        {
            FormsForAdmin.CarTableForm carFrm = new FormsForAdmin.CarTableForm();
            carFrm.ShowDialog();
        }

        private void ownerAddButton_Click(object sender, EventArgs e)
        {
            FormsForAdmin.ColorTableForm colFrm = new FormsForAdmin.ColorTableForm();
            colFrm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            FormsForAdmin.RegionTableForm regiFrm = new FormsForAdmin.RegionTableForm();
            regiFrm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormsForAdmin.MarkTableForm marFrm = new FormsForAdmin.MarkTableForm();
            marFrm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormsForAdmin.FineTableForm fnFrm = new FormsForAdmin.FineTableForm();
            fnFrm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormsForAdmin.OwnerTableForm owFrm = new FormsForAdmin.OwnerTableForm();
            owFrm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormsForAdmin.InspecTableForm insFrm = new FormsForAdmin.InspecTableForm();
            insFrm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormsForAdmin.OperatorTableForm opFrm = new FormsForAdmin.OperatorTableForm();
            opFrm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormsForAdmin.ReportTableForm repFrm = new FormsForAdmin.ReportTableForm();
            repFrm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Forms.ImportForm a = new Forms.ImportForm();
            a.ShowDialog();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void imgLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
