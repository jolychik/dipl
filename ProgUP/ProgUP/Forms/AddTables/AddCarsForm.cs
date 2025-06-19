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
    public partial class AddCarsForm : Form
    {
        public AddCarsForm()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(lblTitle_MouseDown);
        }

        private void btnMinimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void CarsAddForm_Load(object sender, EventArgs e)
        {
            //Комбо сатаны
            classes.Tables.SMark();
            markcombo.DataSource = classes.Tables.MarkSTable;
            markcombo.DisplayMember = "Mark";
            markcombo.ValueMember = "idMark";

            classes.Tables.SColor();
            colorcombo.DataSource = classes.Tables.ColorSTable;
            colorcombo.DisplayMember = "Color";
            colorcombo.ValueMember = "idColor";
            
            classes.Tables.Drivers();
            ownercombo.DataSource = classes.Tables.DriversTable;
            ownercombo.DisplayMember = "info1";
            ownercombo.ValueMember = "idOwner";
        }

        private void adddButton_Click(object sender, EventArgs e)
        {
            classes.AddTable.AddCar(ptsbox.Text, markcombo.SelectedValue.ToString(), colorcombo.SelectedValue.ToString(), ownercombo.SelectedValue.ToString(), modelbox.Text,
                                    dateTimePicker1.Text, gosbox.Text, dateTimePicker2.Text);
            classes.Tables.CarShow();
        }

        private void ptsbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            classes.CheckStuff.Numbers(e);
        }

        private void gosbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            classes.CheckStuff.KirillicAndNumbers(e);
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            lblTitle.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void AddCarsForm_ResizeBegin(object sender, EventArgs e)
        {
            Opacity = 0.7;
        }

        private void AddCarsForm_ResizeEnd(object sender, EventArgs e)
        {
            Opacity = 1;
        }
    }
}
