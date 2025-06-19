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
    public partial class AutorisationForm : Form
    {
        static public string stuff;

        public AutorisationForm()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(lblTitle_MouseDown);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            switch (loginbox.Text)
            {
                case "":
                    classes.CheckStuff.LogAndPasEmpty(loginbox.Text, passwordbox.Text);
                    break;

                case "admin":
                    if ((loginbox.Text == "admin") || (passwordbox.Text == "admin") == true)
                    {
                        forms.AdminForm admFrm = new forms.AdminForm();
                        admFrm.Show();
                        this.Hide();
                    }
                    break;

                default:

                    classes.Autorisation.Autoriz(loginbox.Text, passwordbox.Text);
                    switch (classes.Autorisation.role)
                    {
                        case null:
                            MessageBox.Show("Не верные данные!");
                            break;

                        case "operat":

                            forms.OperatorForm operFrm = new forms.OperatorForm();
                            operFrm.Show();

                            this.Hide();

                            classes.Autorisation.role = null;
                            break;

                        case "owner":

                            classes.MySQLconnect.msCommand.CommandText = @"SELECT concat(secondName,' ',firstName,' ',patronymic) as info FROM car_owner WHERE login = '" + loginbox.Text
                                                                + "' AND password = '" + passwordbox.Text + "';";

                            Object info = classes.MySQLconnect.msCommand.ExecuteScalar();

                            forms.OwnerForm ownFrm = new forms.OwnerForm();
                            ownFrm.Show();

                            this.Hide();

                            classes.Autorisation.role = null;
                            break;
                    }
                    break;
            }
        }

        private void Autorisation_Load(object sender, EventArgs e)
        {
            classes.MySQLconnect.BDConnect();
            coolEye.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (showpas.Checked == true)
            {
                passwordbox.PasswordChar = '\0';
                coolEye.Visible = true;
            }
            else
            {
                passwordbox.PasswordChar = '*';
                coolEye.Visible = false;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            lblTitle.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            loginbox.Text = "root";
            passwordbox.Text = "root";
        }

        private void coolEye_Click(object sender, EventArgs e)
        {
            loginbox.Text = "admin";
            passwordbox.Text = "admin";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            loginbox.Text = "owner1";
            passwordbox.Text = "qwerty";
        }
    }
}
