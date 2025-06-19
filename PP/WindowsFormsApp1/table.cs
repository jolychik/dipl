using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public partial class table : Form
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
        public table()
        {
            InitializeComponent();
        }


        private void table_Load(object sender, EventArgs e)
        {
            GetNameList();
            GetKartList();
            GetTipCBList();
            GetDevCBList();
            GetPomCBList();
            GetNameKCBList();

            this.Region = new Region(
                Program.RoundedRect(
                    new Rectangle(0, 0, this.Width, this.Height), 12));
        }
        //-----------------------------------------загрузка таблиц---------------------------------------------------------------------
        private DataTable naz_table = null;
        private DataTable kart_table = null;
        public void GetNameList()
        {
            try
            {
                MySqlDataAdapter naz_adapter = new MySqlDataAdapter("SELECT `id_naz`, `name_k`, `color`, `tip_kart` FROM `nazvaniya_kart`, `sp_type_kart` WHERE nazvaniya_kart.id_tip = sp_type_kart.id_tip", DB.connectionstring);
                naz_table = new DataTable();
                naz_adapter.Fill(naz_table);
                naz_dgv.DataSource = naz_table;
            }
            catch
            {
                MessageBox.Show("Не получилось загрузить модели картриджей");
            }
        }
        public void GetKartList()
        {
            try
            {
                MySqlDataAdapter kart_adapter = new MySqlDataAdapter("SELECT `id`, `developer`, `pomesheniya`, `kolvo`, `data_dobav`, nazvaniya_kart.name_k, `klass` FROM `karty`, `sp_dev`, `sp_pomesheniya`, `nazvaniya_kart` WHERE karty.id_dev = sp_dev.id_dev AND karty.id_pom = sp_pomesheniya.id_pom AND karty.id_naz = nazvaniya_kart.id_naz", DB.connectionstring);
                kart_table = new DataTable();
                kart_adapter.Fill(kart_table);
                kart_dgv.DataSource = kart_table;
            }
            catch
            {
                MessageBox.Show("Не получилось загрузить модели картриджей");
            }
        }
        //-----------------------------------------загрузка таблиц---------------------------------------------------------------------

        //-----------------------------------------загрузка комбо боксов---------------------------------------------------------------------
        public void GetTipCBList()
        {
                MySqlDataAdapter tip_k_adapter = new MySqlDataAdapter("SELECT * FROM `sp_type_kart`", DB.connectionstring);
                DataTable tip_k_table = new DataTable();
                tip_k_adapter.Fill(tip_k_table);

                tip_k_cb.DataSource = tip_k_table;
                tip_k_cb.DisplayMember = "tip_kart";
                tip_k_cb.ValueMember = "id_tip";
                tip_k_cb.SelectedIndex = -1;
        }

        public void GetDevCBList()
        {
            MySqlDataAdapter dev_adapter = new MySqlDataAdapter("SELECT * FROM `sp_dev`", DB.connectionstring);
            DataTable dev_table = new DataTable();
            dev_adapter.Fill(dev_table);

            dev_cb.DataSource = dev_table;
            dev_cb.DisplayMember = "developer";
            dev_cb.ValueMember = "id_dev";
            dev_cb.SelectedIndex = -1;
        }
        public void GetPomCBList()
        {
            MySqlDataAdapter pom_adaper = new MySqlDataAdapter("SELECT * FROM `sp_pomesheniya`", DB.connectionstring);
            DataTable pom_table = new DataTable();
            pom_adaper.Fill(pom_table);

            pom_cb.DataSource = pom_table;
            pom_cb.DisplayMember = "pomesheniya";
            pom_cb.ValueMember = "id_pom";
            pom_cb.SelectedIndex = -1;
        }
        public void GetNameKCBList()
        {
            MySqlDataAdapter name_k_adapter = new MySqlDataAdapter("SELECT * FROM `nazvaniya_kart`", DB.connectionstring);
            DataTable name_k_table = new DataTable();
            name_k_adapter.Fill(name_k_table);

            name_k_cb.DataSource = name_k_table;
            name_k_cb.DisplayMember = "name_k";
            name_k_cb.ValueMember = "id_naz";
            name_k_cb.SelectedIndex = -1;
        } 
        //-----------------------------------------загрузка комбо боксов---------------------------------------------------------------------

        //-----------------------------------------import to excel--------------------------------------------------------------------
        private void моделиКартриджейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            Excel.Worksheet exSheet = new Excel.Worksheet();

            exApp.Workbooks.Add();
            exSheet = (Excel.Worksheet)exApp.Sheets[1];
            exSheet.Name = "Модели картриджей";

            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            int i, j;
            for (i = 0; i <= naz_dgv.RowCount - 2; i++)
            {

                for (j = 0; j <= naz_dgv.ColumnCount - 1; j++)
                {
                    wsh.Cells[1, j + 1] = naz_dgv.Columns[j].HeaderText.ToString();
                    wsh.Cells[i + 2, j + 1] = naz_dgv[j, i].Value.ToString();
                }
            }
            exApp.Visible = true;
        }

        private void всёОКартриджахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            Excel.Worksheet exSheet = new Excel.Worksheet();

            exApp.Workbooks.Add();
            exSheet = (Excel.Worksheet)exApp.Sheets[1];
            exSheet.Name = "Всё о картриджах";

            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            int i, j;
            for (i = 0; i <= kart_dgv.RowCount - 2; i++)
            {

                for (j = 0; j <= kart_dgv.ColumnCount - 1; j++)
                {
                    wsh.Cells[1, j + 1] = kart_dgv.Columns[j].HeaderText.ToString();
                    wsh.Cells[i + 2, j + 1] = kart_dgv[j, i].Value.ToString();
                }
            }
            exApp.Visible = true;
        }
        //-----------------------------------------import to excel--------------------------------------------------------------------

        //-----------------------------------------всякая шняга--------------------------------------------------------------------
        private void открытьСправочникиВНовомОкнеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<SP>().Count() >= 1)
            {

            }
            else
            {
                SP sp = new SP();
                sp.Show();
            }
        }

        private void перейтиКСправочникамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            SP sp = new SP();
            sp.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
               if (Application.OpenForms.OfType<SP>().Count() == 1)
               {
                   this.Close();
               }
               else
               {
                   Application.Exit();
               } 
        }

        private void min_b_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label11_MouseDown(object sender, MouseEventArgs e)
        {
            label11.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void table_ResizeBegin(object sender, EventArgs e)
        {
            Opacity = 0.9;
        }

        private void table_ResizeEnd(object sender, EventArgs e)
        {
            Opacity = 1;
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            menuStrip1.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        //-----------------------------------------всякая шняга--------------------------------------------------------------------

        //-----------------------------------------названия картриджей--------------------------------------------------------------------
        naz_IUD niud = new naz_IUD();
        private void naz_add_Click(object sender, EventArgs e)
        {
            niud.AddNaz(id_naz_f.Text, name_k_f.Text, color_f.Text, tip_k_cb.Text);

            GetNameList();

            id_naz_f.Text = "";
            name_k_f.Text = "";
            color_f.Text = "";
            tip_k_cb.Text = "";
        }

        private void naz_upd_Click(object sender, EventArgs e)
        {
            niud.UpdNaz(id_naz_f.Text, name_k_f.Text, color_f.Text, tip_k_cb.Text);

            GetNameList();

            id_naz_f.Text = "";
            name_k_f.Text = "";
            color_f.Text = "";
            tip_k_cb.Text = "";
        }

        private void naz_del_Click(object sender, EventArgs e)
        {
            niud.DelNaz(id_naz_f.Text);

            GetNameList();

            id_naz_f.Text = "";
            name_k_f.Text = "";
            color_f.Text = "";
            tip_k_cb.Text = "";
        }
        //-----------------------------------------названия картриджей--------------------------------------------------------------------

        //-----------------------------------------всё о картриджах--------------------------------------------------------------------
        kart_IUD kiud = new kart_IUD();
        private void kart_add_Click(object sender, EventArgs e)
        {
            kiud.AddKart(id_f.Text, dev_cb.Text, pom_cb.Text, kolvo_f.Text, data_f.Text, name_k_cb.Text, klass_f.Text);

            GetKartList();

            id_f.Text = "";
            dev_cb.Text = "";
            pom_cb.Text = "";
            kolvo_f.Text = "";
            data_f.Text = "";
            name_k_cb.Text = "";
            klass_f.Text = "";
        }
        private void kart_upd_Click(object sender, EventArgs e)
        {
            kiud.UpdKart(id_f.Text, dev_cb.Text, pom_cb.Text, kolvo_f.Text, data_f.Text, name_k_cb.Text, klass_f.Text);

            GetKartList();

            id_f.Text = "";
            dev_cb.Text = "";
            pom_cb.Text = "";
            kolvo_f.Text = "";
            data_f.Text = "";
            name_k_cb.Text = "";
            klass_f.Text = "";
        }
        private void kart_del_Click(object sender, EventArgs e)
        {
            kiud.DelKart(id_f.Text);

            GetKartList();

            id_f.Text = "";
            dev_cb.Text = "";
            pom_cb.Text = "";
            kolvo_f.Text = "";
            data_f.Text = "";
            name_k_cb.Text = "";
            klass_f.Text = "";
        }

        private void close_b_MouseEnter(object sender, EventArgs e)
        {
            close_b.Image = Properties.Resources.close_hover;
        }

        private void close_b_MouseLeave(object sender, EventArgs e)
        {
            close_b.Image = Properties.Resources.close;
        }

        private void min_b_MouseEnter(object sender, EventArgs e)
        {
            min_b.Image = Properties.Resources.minimize_hover;
        }

        private void min_b_MouseLeave(object sender, EventArgs e)
        {
            min_b.Image = Properties.Resources.minimize;
        }

       
    }
}
