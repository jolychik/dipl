using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        private const int CS_DROPSHADOW = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DB.openConnection();

            this.Region = new Region(
                Program.RoundedRect(
                    new Rectangle(0, 0, this.Width, this.Height), 12));
        }


        private void signin_b_Click(object sender, EventArgs e)
        {
            string username = login_f.Text;
            string password = password_f.Text;

            DataTable table = new DataTable();

            

            DB.cmd.CommandText = ("SELECT * FROM `users` WHERE `login` = @user AND `password` = @pass");
            DB.cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = username;
            DB.cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            DB.adapter.SelectCommand = DB.cmd;
            DB.adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                SP frm = new SP();
                frm.Show();
            }
            else
                MessageBox.Show("Логин или пароль введены неверно");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            login_f.Text = "L";
            password_f.Text = "asd";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            label4.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void Login_ResizeBegin(object sender, EventArgs e)
        {
            Opacity = 0.9;
        }

        private void Login_ResizeEnd(object sender, EventArgs e)
        {
            Opacity = 1;
        }

        private void min_b_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void min_b_MouseEnter(object sender, EventArgs e)
        {
            min_b.Image = Properties.Resources.minimize_hover;
        }

        private void min_b_MouseLeave(object sender, EventArgs e)
        {
            min_b.Image = Properties.Resources.minimize;
        }

        private void close_b_MouseEnter(object sender, EventArgs e)
        {
            close_b.Image = Properties.Resources.close_hover;
        }

        private void close_b_MouseLeave(object sender, EventArgs e)
        {
            close_b.Image = Properties.Resources.close;
        }
    }
}
