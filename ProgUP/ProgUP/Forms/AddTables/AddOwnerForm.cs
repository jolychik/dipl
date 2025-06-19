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
    public partial class AddOwnerForm : Form
    {
        public AddOwnerForm()
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (classes.CheckStuff.EmailCorrect(mail.Text) == true)
            {
                classes.AddTable.AddCarOwner(fio.Text, fio2.Text, fio3.Text, vodPrava.Text, dateTimePicker1.Text,
                                             adres.Text, mail.Text, log.Text, pass.Text, telephone.Text);
                classes.Tables.OwnerShow();
            }
            else
                MessageBox.Show("Адрес эл. почты запленен не верно!");
        }

        private void vodPrava_KeyPress(object sender, KeyPressEventArgs e)
        {
            classes.CheckStuff.Numbers(e);
        }

        private void fio_KeyPress(object sender, KeyPressEventArgs e)
        {
            classes.CheckStuff.KirillicLatters(e);
        }

        private void fio2_KeyPress(object sender, KeyPressEventArgs e)
        {
            classes.CheckStuff.KirillicLatters(e);
        }

        private void fio3_KeyPress(object sender, KeyPressEventArgs e)
        {
            classes.CheckStuff.KirillicLatters(e);
        }

        private void mail_KeyPress(object sender, KeyPressEventArgs e)
        {
            classes.CheckStuff.LatinAndNumbers(e);
        }

        private void log_KeyPress(object sender, KeyPressEventArgs e)
        {
            classes.CheckStuff.LatinAndNumbers(e);
        }

        private void pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            classes.CheckStuff.LatinAndNumbers(e);
        }

        private void adres_KeyPress(object sender, KeyPressEventArgs e)
        {
            classes.CheckStuff.KirillicAndNumbers(e);
        }

        private void telephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            classes.CheckStuff.Numbers(e);
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            lblTitle.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void AddOwnerForm_ResizeBegin(object sender, EventArgs e)
        {
            Opacity = 0.7;
        }

        private void AddOwnerForm_ResizeEnd(object sender, EventArgs e)
        {
            Opacity = 1;
        }
    }
}
