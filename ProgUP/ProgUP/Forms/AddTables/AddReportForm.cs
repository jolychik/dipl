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
    public partial class AddReportForm : Form
    {
        public AddReportForm()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(lblTitle_MouseDown);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Для комбобоксов
        private void AddReportForm_Load(object sender, EventArgs e)
        {
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
        }

        private void adddButton_Click(object sender, EventArgs e)
        {
            classes.AddTable.AddReport(inspectorcombo.SelectedValue.ToString(), dateTimePicker3.Text, dateTimePicker1.Text, regioncombo.SelectedValue.ToString(),
                                       ownercombo.SelectedValue.ToString(), finecombo.SelectedValue.ToString(), shtrafSum.Text, dateTimePicker2.Text, "Не оплачено");
            classes.Tables.ReportsShow();

            classes.AddTable.UpdateShtrafSum(ownercombo.SelectedValue.ToString());

            classes.Tables.OwnerShow();
            classes.Tables.ReportsShow();

        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            lblTitle.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void AddReportForm_ResizeBegin(object sender, EventArgs e)
        {
            Opacity = 0.7;
        }

        private void AddReportForm_ResizeEnd(object sender, EventArgs e)
        {
            Opacity = 1;
        }
    }
}
