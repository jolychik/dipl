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
    public partial class EditReportForm : Form
    {
        public EditReportForm()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(lblTitle_MouseDown);
        }


        private void adddButton_Click(object sender, EventArgs e)
        {
            classes.EditTable.ReportEdit(label10.Text, inspectorcombo.SelectedValue.ToString(), dateTimePicker3.Text,
                                         dateTimePicker1.Text, regioncombo.SelectedValue.ToString(), ownercombo.SelectedValue.ToString(),
                                         finecombo.SelectedValue.ToString(), shtrafSum.Text, dateTimePicker2.Text, dateTimePicker4.Text, oplataBox.Text);

            if (oplataBox.Text == "Оплачено")
            { classes.EditTable.DolgEdit(ownercombo.SelectedValue.ToString(), label10.Text); }
            else
            { classes.AddTable.UpdateShtrafSum(ownercombo.SelectedValue.ToString()); }

            classes.Tables.ReportsShow();
            classes.Tables.OwnerShow();
        }

        private void EditReportForm_Load(object sender, EventArgs e)
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

            label10.Text = forms.OperatorForm.tabIdReport;
            inspectorcombo.Text = forms.OperatorForm.tabIdInspector;
            dateTimePicker3.Text = forms.OperatorForm.tabIdTime;
            dateTimePicker1.Text = forms.OperatorForm.tabIncidDate;
            regioncombo.Text = forms.OperatorForm.tabIdRegion;
            ownercombo.Text = forms.OperatorForm.tabIdOwner;
            finecombo.Text = forms.OperatorForm.tabIdFine;
            shtrafSum.Text = forms.OperatorForm.tabSum;
            dateTimePicker2.Text = forms.OperatorForm.tabPlanedPayment;
            dateTimePicker4.Text = forms.OperatorForm.tabFactPay;
            oplataBox.Text = forms.OperatorForm.taboplata;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimaze_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            lblTitle.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void EditReportForm_ResizeBegin(object sender, EventArgs e)
        {
            Opacity = 0.7;
        }

        private void EditReportForm_ResizeEnd(object sender, EventArgs e)
        {
            Opacity = 1;
        }
    }
}