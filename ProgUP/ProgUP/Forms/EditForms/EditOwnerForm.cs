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
    public partial class EditOwnerForm : Form
    {
        public EditOwnerForm()
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

        private void EditOwnerForm_Load(object sender, EventArgs e)
        {
            label9.Text = forms.OperatorForm.tabidOwner;
            fio.Text = forms.OperatorForm.tabfirstName;
            fio2.Text = forms.OperatorForm.tabsecondName;
            fio3.Text = forms.OperatorForm.tabpatronomyc;
            vodPrava.Text = forms.OperatorForm.tabidDriverRights;
            dateTimePicker1.Text = forms.OperatorForm.tabownerRegDate;
            mail.Text = forms.OperatorForm.tablogin;
            log.Text = forms.OperatorForm.tabemail; 
            pass.Text = forms.OperatorForm.tabpassword;
            adres.Text = forms.OperatorForm.tabadres;
            telephone.Text = forms.OperatorForm.tabtelephone;
        }

        private void adddButton_Click(object sender, EventArgs e)
        {
            classes.EditTable.OwnerEdit(label9.Text, fio.Text, fio2.Text, fio3.Text, vodPrava.Text,
                                        dateTimePicker1.Text, adres.Text, mail.Text, log.Text, pass.Text, telephone.Text);
            classes.Tables.OwnerShow();
        }

        private void btnMinimaze_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            lblTitle.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void EditOwnerForm_ResizeBegin(object sender, EventArgs e)
        {
            Opacity = 0.7;
        }
       
        private void EditOwnerForm_ResizeEnd(object sender, EventArgs e)
        {
            Opacity = 1;
        }
    }
}
