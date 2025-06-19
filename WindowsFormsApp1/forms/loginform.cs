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
using WindowsFormsApp1.classes;

namespace WindowsFormsApp1.forms
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            DataTable auto = new DataTable();

            DB.cmd.CommandText = ("SELECT * FROM dpilom2.employye WHERE `login` = @user AND `password` = @pass;");
            DB.cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = username;
            DB.cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            DB.sqlAdapter.SelectCommand = DB.cmd;
            DB.sqlAdapter.Fill(auto);

            if (auto.Rows.Count > 0)
            {   
                this.Hide();
                Form1 frm = new Form1();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Логин или пароль введены неверно");
        }

        private void loginform_Load(object sender, EventArgs e)
        {
            DB.bdconn();
        }
    }
}
