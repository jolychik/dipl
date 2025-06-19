using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WindowsFormsApp1.Classes;
using Excel = Microsoft.Office.Interop.Excel;


namespace WindowsFormsApp1
{
    public partial class SP : Form
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
        public SP()
        {
            InitializeComponent();
        }

        private DataTable dev_table = null;
        private DataTable pom_table = null;
        private DataTable tip_k_table = null;

        private void SP_Load(object sender, EventArgs e)
        {
            GetDevList();
            GetPomList();
            GetTipList();

            this.Region = new Region(
            Program.RoundedRect(    
            new Rectangle(0, 0, this.Width, this.Height),12));
        }
        public void GetDevList()
        {
            try
            {
                MySqlDataAdapter dev_adapter = new MySqlDataAdapter("SELECT * FROM `sp_dev`", DB.connectionstring);
                dev_table = new DataTable();
                dev_adapter.Fill(dev_table);
                dev_dgv.DataSource = dev_table;
            }
            catch
            {
                MessageBox.Show("Не получилось загрузить производителей");
            }
        }
        public void GetPomList()
        {
            try
            {
                MySqlDataAdapter pom_adapter = new MySqlDataAdapter("SELECT * FROM `sp_pomesheniya`", DB.connectionstring);
                pom_table = new DataTable();
                pom_adapter.Fill(pom_table);
                pom_dgv.DataSource = pom_table;
            }
            catch
            {
                MessageBox.Show("Не получилось загрузить помещения");
            }
        }
        public void GetTipList()
        {
            try
            {
                MySqlDataAdapter tip_k_adapter = new MySqlDataAdapter("SELECT * FROM `sp_type_kart`", DB.connectionstring);
                tip_k_table = new DataTable();
                tip_k_adapter.Fill(tip_k_table);
                tip_k_dgv.DataSource = tip_k_table;
            }
            catch
            {
                MessageBox.Show("Не получилось загрузить типы картриджей");
            }
        }
        //-----------------------------------------ПРОИЗВОДИТЕЛИ--------------------------------------------------------------------

        dev_IUD diud = new dev_IUD();
        private void dev_add_Click(object sender, EventArgs e)
        {
            diud.AddDev(id_dev_f.Text, dev_f.Text);

            GetDevList();

            id_dev_f.Text = "";
            dev_f.Text = "";
        }

        private void dev_upd_Click(object sender, EventArgs e)
        {
            diud.UpdDev(id_dev_f.Text, dev_f.Text);

            GetDevList();

            id_dev_f.Text = "";
            dev_f.Text = "";
        }

        private void dev_del_Click(object sender, EventArgs e)
        {
            diud.DelDev(id_dev_f.Text);

            GetDevList();

            id_dev_f.Text = "";
            dev_f.Text = "";
        }
        //-----------------------------------------ПРОИЗВОДИТЕЛИ--------------------------------------------------------------------

        //-----------------------------------------ПОМЕЩЕНИЯ--------------------------------------------------------------------
        pom_IUD piud = new pom_IUD();
        private void pom_add_Click(object sender, EventArgs e)
        {
            piud.AddPom(id_pom_f.Text, pom_f.Text);

            GetPomList();

            id_pom_f.Text = "";
            pom_f.Text = "";
        }

        private void pom_upd_Click(object sender, EventArgs e)
        {
            piud.UpdPom(id_pom_f.Text, pom_f.Text);

            GetPomList();

            id_pom_f.Text = "";
            pom_f.Text = "";
        }

        private void pom_del_Click(object sender, EventArgs e)
        {
            piud.DelPom(id_pom_f.Text);

            GetPomList();

            id_pom_f.Text = "";
            pom_f.Text = "";
        }
        //-----------------------------------------ПОМЕЩЕНИЯ--------------------------------------------------------------------

        //-----------------------------------------ТИПЫ КАРТРИДЖЕЙ--------------------------------------------------------------------
        tip_k_IUD tipkiud = new tip_k_IUD();
        private void tip_add_Click(object sender, EventArgs e)
        {
            tipkiud.AddTipK(id_tip_f.Text, tip_f.Text);

            GetTipList();

            id_tip_f.Text = "";
            tip_f.Text = "";
        }

        private void tip_upd_Click(object sender, EventArgs e)
        {
            tipkiud.UpdTipK(id_tip_f.Text, tip_f.Text);

            GetTipList();

            id_tip_f.Text = "";
            tip_f.Text = "";
        }

        private void tip_del_Click(object sender, EventArgs e)
        {
            tipkiud.DelTipK(id_tip_f.Text);

            GetTipList();

            id_tip_f.Text = "";
            tip_f.Text = "";
        }
        //-----------------------------------------ТИПЫ КАРТРИДЖЕЙ--------------------------------------------------------------------

        //-----------------------------------------import to excel--------------------------------------------------------------------
        private void производителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            Excel.Worksheet exSheet = new Excel.Worksheet();

            exApp.Workbooks.Add();
            exSheet = (Excel.Worksheet)exApp.Sheets[1];
            exSheet.Name = "Производитель картриджей";

            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            int i, j;
            for (i = 0; i <= dev_dgv.RowCount - 2; i++)
            {

                for (j = 0; j <= dev_dgv.ColumnCount - 1; j++)
                {
                    wsh.Cells[1, j + 1] = dev_dgv.Columns[j].HeaderText.ToString();
                    wsh.Cells[i + 2, j + 1] = dev_dgv[j, i].Value.ToString();
                }
            }
            exApp.Visible = true;
        }

        private void помещенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            Excel.Worksheet exSheet = new Excel.Worksheet();

            exApp.Workbooks.Add();
            exSheet = (Excel.Worksheet)exApp.Sheets[1];
            exSheet.Name = "Помещения";

            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            int i, j;
            for (i = 0; i <= pom_dgv.RowCount - 2; i++)
            {

                for (j = 0; j <= pom_dgv.ColumnCount - 1; j++)
                {
                    wsh.Cells[1, j + 1] = pom_dgv.Columns[j].HeaderText.ToString();
                    wsh.Cells[i + 2, j + 1] = pom_dgv[j, i].Value.ToString();
                }
            }
            exApp.Visible = true;
        }

        private void типыКартриджейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            Excel.Worksheet exSheet = new Excel.Worksheet();

            exApp.Workbooks.Add();
            exSheet = (Excel.Worksheet)exApp.Sheets[1];
            exSheet.Name = "Типы картриджей";

            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            int i, j;
            for (i = 0; i <= tip_k_dgv.RowCount - 2; i++)
            {

                for (j = 0; j <= tip_k_dgv.ColumnCount - 1; j++)
                {
                    wsh.Cells[1, j + 1] = tip_k_dgv.Columns[j].HeaderText.ToString();
                    wsh.Cells[i + 2, j + 1] = tip_k_dgv[j, i].Value.ToString();
                }
            }
            exApp.Visible = true;
        }
        //-----------------------------------------import to excel--------------------------------------------------------------------

        //-----------------------------------------всякая шняга--------------------------------------------------------------------

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Visible = false;
            }

            base.OnFormClosing(e);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<table>().Count() == 1)
            { 
                this.Close();
            }
            else 
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label7_MouseDown(object sender, MouseEventArgs e)
        {
            label7.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            menuStrip1.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void открытьТаблицыВНовомОкнеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<table>().Count() == 1)
            {

            }
            else
            {
                table table = new table();
                table.Show();
            }
        }

        private void перейтиКТаблицамToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            table table = new table();
            table.Show();
        }

        private void SP_ResizeBegin(object sender, EventArgs e)
        {
            Opacity = 0.9;
        }

        private void SP_ResizeEnd(object sender, EventArgs e)
        {
            Opacity = 1;
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
        //-----------------------------------------всякая шняга--------------------------------------------------------------------

    }
}
