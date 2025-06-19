using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.classes;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private MySqlConnection sqlConnection = null;   
        private MySqlDataAdapter adapter = null;
        private DataTable dt = null;
        public Form1()
        {
            InitializeComponent();
        }
        mat_IUD miud = new mat_IUD();
        private void button1_Click(object sender, EventArgs e)
        {
            miud.AddMat(mat_t.Text, type_t.Text, supp_cb.Text, price_t.Text, amount_t.Text);
            id_t.Text = "";
            mat_t.Text = "";
            type_t.Text = "";
            supp_cb.Text = "";
            price_t.Text = "";
            amount_t.Text = "";
            GetTabelList();
            GetSuppCBList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void GetTabelList()
        {
            GetSuppCBList();         
            try
            {
                MySqlDataAdapter dev_adapter = new MySqlDataAdapter("SELECT * FROM dpilom2.materials;", DB.connctionstring);
                dt = new DataTable();
                dev_adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("бля");
            }
        }
        public void GetSuppCBList()
        {
            MySqlDataAdapter dev_adapter = new MySqlDataAdapter("SELECT * FROM `dpilom2`.`suppliers`", DB.connctionstring);
            DataTable supptable = new DataTable();
            dev_adapter.Fill(supptable);

            supp_cb.DataSource = supptable;
            supp_cb.DisplayMember = "namesupp";
            supp_cb.ValueMember = "idsupp";
            supp_cb.SelectedIndex = -1;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetSuppCBList();
            GetTabelList();
          

        }

        private void edit_b_Click(object sender, EventArgs e)
        {
            miud.UpdMat(id_t.Text, mat_t.Text, type_t.Text, supp_cb.Text, price_t.Text, amount_t.Text);
            id_t.Text = "";
            mat_t.Text = "";
            type_t.Text = "";
            supp_cb.Text = "";
            price_t.Text = "";
            amount_t.Text = "";
            GetTabelList();
            GetSuppCBList();
        }

        private void del_b_Click(object sender, EventArgs e)
        {
            string idid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            miud.DelMat(idid);
            GetTabelList();
            GetSuppCBList();
        }

        private void id_t_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MySqlDataAdapter dev_adapter = new MySqlDataAdapter("SELECT * FROM dpilom2.materials WHERE `idmat` = '"+textBox1.Text+"'", DB.connctionstring);
            dt = new DataTable();
            dev_adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем ввод цифр, Backspace и Delete
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true; // Отменяем ввод символа
            }

            /* char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            } */
        }

        /*
                static public bool AddCarOwner(string firstName, string secondName, string patronomyc, string idDriverRights, string ownerRegDate,
                                       string adres, string email, string login, string password, string telephone)
        {
            try
            {
                DateTime selectedData = Convert.ToDateTime(ownerRegDate);

                MySQLconnect.msCommand.CommandText = $@"INSERT INTO car_owner VALUES(NULL,'{firstName}','{secondName}','{patronomyc}'," +
                                                     $"'{idDriverRights}','{selectedData.ToString("yyyy-MM-dd")}','{adres}','{email}','{login}','{password}'," +
                                                     $"'{telephone}','{0}')";

                if (classes.MySQLconnect.msCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ошибка при добавлении владельца!");
                return false;
            }
        }
         */
    }
}
