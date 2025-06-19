
namespace ProgUP.FormsForAdmin
{
    partial class ReportTableForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportTableForm));
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.btnMinimaze = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.OwnFilterButton = new System.Windows.Forms.Button();
            this.ownercombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FineFilterButton = new System.Windows.Forms.Button();
            this.finecombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ReionFilterButton = new System.Windows.Forms.Button();
            this.regioncombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.InspButtFilt = new System.Windows.Forms.Button();
            this.inspectorcombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FilterButton = new System.Windows.Forms.Button();
            this.sortOplataCombo = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.InsptextBox = new System.Windows.Forms.TextBox();
            this.FtextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.reportsEditButton = new System.Windows.Forms.Button();
            this.reportAddButton = new System.Windows.Forms.Button();
            this.reportDelete = new System.Windows.Forms.Button();
            this.pnlBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBorder
            // 
            this.pnlBorder.BackColor = System.Drawing.Color.Teal;
            this.pnlBorder.Controls.Add(this.lblTitle);
            this.pnlBorder.Controls.Add(this.imgLogo);
            this.pnlBorder.Controls.Add(this.btnMinimaze);
            this.pnlBorder.Controls.Add(this.btnClose);
            this.pnlBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(1613, 30);
            this.pnlBorder.TabIndex = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Gray;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1523, 30);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Рапорты";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.Gray;
            this.imgLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(0, 0);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(30, 30);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 2;
            this.imgLogo.TabStop = false;
            // 
            // btnMinimaze
            // 
            this.btnMinimaze.BackColor = System.Drawing.Color.Gray;
            this.btnMinimaze.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimaze.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinimaze.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinimaze.ForeColor = System.Drawing.Color.White;
            this.btnMinimaze.Location = new System.Drawing.Point(1553, 0);
            this.btnMinimaze.Name = "btnMinimaze";
            this.btnMinimaze.Size = new System.Drawing.Size(30, 30);
            this.btnMinimaze.TabIndex = 1;
            this.btnMinimaze.Text = "-";
            this.btnMinimaze.UseVisualStyleBackColor = false;
            this.btnMinimaze.Click += new System.EventHandler(this.btnMinimaze_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1583, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column21,
            this.Column22,
            this.Column23,
            this.Column24,
            this.Column25,
            this.Column26,
            this.Column27,
            this.Column28,
            this.Column29,
            this.Column30,
            this.Column31});
            this.dataGridView3.Location = new System.Drawing.Point(12, 43);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(1229, 450);
            this.dataGridView3.TabIndex = 11;
            // 
            // Column21
            // 
            this.Column21.DataPropertyName = "idReport";
            this.Column21.HeaderText = "Номер рапорта";
            this.Column21.Name = "Column21";
            this.Column21.ReadOnly = true;
            // 
            // Column22
            // 
            this.Column22.DataPropertyName = "fio";
            this.Column22.HeaderText = "ФИО";
            this.Column22.Name = "Column22";
            this.Column22.ReadOnly = true;
            // 
            // Column23
            // 
            this.Column23.DataPropertyName = "incidTime";
            this.Column23.HeaderText = "Время составления";
            this.Column23.Name = "Column23";
            this.Column23.ReadOnly = true;
            // 
            // Column24
            // 
            this.Column24.DataPropertyName = "incidDate";
            this.Column24.HeaderText = "Дата составления";
            this.Column24.Name = "Column24";
            this.Column24.ReadOnly = true;
            // 
            // Column25
            // 
            this.Column25.DataPropertyName = "region";
            this.Column25.HeaderText = "Регион";
            this.Column25.Name = "Column25";
            this.Column25.ReadOnly = true;
            // 
            // Column26
            // 
            this.Column26.DataPropertyName = "driverinfo";
            this.Column26.HeaderText = "Владелец";
            this.Column26.Name = "Column26";
            this.Column26.ReadOnly = true;
            // 
            // Column27
            // 
            this.Column27.DataPropertyName = "describeFine";
            this.Column27.HeaderText = "Штраф";
            this.Column27.Name = "Column27";
            this.Column27.ReadOnly = true;
            // 
            // Column28
            // 
            this.Column28.DataPropertyName = "sum";
            this.Column28.HeaderText = "Сумма штрафа";
            this.Column28.Name = "Column28";
            this.Column28.ReadOnly = true;
            // 
            // Column29
            // 
            this.Column29.DataPropertyName = "planedPayment";
            this.Column29.HeaderText = "Назнач. дата оплаты";
            this.Column29.Name = "Column29";
            this.Column29.ReadOnly = true;
            // 
            // Column30
            // 
            this.Column30.DataPropertyName = "factPayment";
            this.Column30.HeaderText = "Факт. дата оплаты";
            this.Column30.Name = "Column30";
            this.Column30.ReadOnly = true;
            // 
            // Column31
            // 
            this.Column31.DataPropertyName = "payed";
            this.Column31.HeaderText = "Статус";
            this.Column31.Name = "Column31";
            this.Column31.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.OwnFilterButton);
            this.groupBox4.Controls.Add(this.ownercombo);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.FineFilterButton);
            this.groupBox4.Controls.Add(this.finecombo);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.ReionFilterButton);
            this.groupBox4.Controls.Add(this.regioncombo);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.cancelbutton);
            this.groupBox4.Controls.Add(this.InspButtFilt);
            this.groupBox4.Controls.Add(this.inspectorcombo);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.FilterButton);
            this.groupBox4.Controls.Add(this.sortOplataCombo);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.panel5);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(1247, 36);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(353, 299);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Фильтрация";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(152, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "По дате составления";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(292, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 64;
            this.button1.Text = "Фильт.";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker1.Location = new System.Drawing.Point(152, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(134, 23);
            this.dateTimePicker1.TabIndex = 63;
            // 
            // OwnFilterButton
            // 
            this.OwnFilterButton.BackColor = System.Drawing.Color.White;
            this.OwnFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OwnFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.OwnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.OwnFilterButton.Location = new System.Drawing.Point(292, 218);
            this.OwnFilterButton.Name = "OwnFilterButton";
            this.OwnFilterButton.Size = new System.Drawing.Size(55, 23);
            this.OwnFilterButton.TabIndex = 62;
            this.OwnFilterButton.Text = "Фильт.";
            this.OwnFilterButton.UseVisualStyleBackColor = false;
            this.OwnFilterButton.Click += new System.EventHandler(this.OwnFilterButton_Click);
            // 
            // ownercombo
            // 
            this.ownercombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ownercombo.FormattingEnabled = true;
            this.ownercombo.Location = new System.Drawing.Point(6, 218);
            this.ownercombo.Name = "ownercombo";
            this.ownercombo.Size = new System.Drawing.Size(280, 23);
            this.ownercombo.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Владелец";
            // 
            // FineFilterButton
            // 
            this.FineFilterButton.BackColor = System.Drawing.Color.White;
            this.FineFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FineFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.FineFilterButton.ForeColor = System.Drawing.Color.Black;
            this.FineFilterButton.Location = new System.Drawing.Point(292, 176);
            this.FineFilterButton.Name = "FineFilterButton";
            this.FineFilterButton.Size = new System.Drawing.Size(55, 23);
            this.FineFilterButton.TabIndex = 59;
            this.FineFilterButton.Text = "Фильт.";
            this.FineFilterButton.UseVisualStyleBackColor = false;
            this.FineFilterButton.Click += new System.EventHandler(this.FineFilterButton_Click);
            // 
            // finecombo
            // 
            this.finecombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.finecombo.FormattingEnabled = true;
            this.finecombo.Location = new System.Drawing.Point(6, 176);
            this.finecombo.Name = "finecombo";
            this.finecombo.Size = new System.Drawing.Size(280, 23);
            this.finecombo.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Штраф";
            // 
            // ReionFilterButton
            // 
            this.ReionFilterButton.BackColor = System.Drawing.Color.White;
            this.ReionFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReionFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ReionFilterButton.ForeColor = System.Drawing.Color.Black;
            this.ReionFilterButton.Location = new System.Drawing.Point(292, 134);
            this.ReionFilterButton.Name = "ReionFilterButton";
            this.ReionFilterButton.Size = new System.Drawing.Size(55, 23);
            this.ReionFilterButton.TabIndex = 56;
            this.ReionFilterButton.Text = "Фильт.";
            this.ReionFilterButton.UseVisualStyleBackColor = false;
            this.ReionFilterButton.Click += new System.EventHandler(this.ReionFilterButton_Click);
            // 
            // regioncombo
            // 
            this.regioncombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.regioncombo.FormattingEnabled = true;
            this.regioncombo.Location = new System.Drawing.Point(6, 134);
            this.regioncombo.Name = "regioncombo";
            this.regioncombo.Size = new System.Drawing.Size(280, 23);
            this.regioncombo.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Регион";
            // 
            // cancelbutton
            // 
            this.cancelbutton.BackColor = System.Drawing.Color.White;
            this.cancelbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cancelbutton.ForeColor = System.Drawing.Color.Black;
            this.cancelbutton.Location = new System.Drawing.Point(6, 259);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(341, 30);
            this.cancelbutton.TabIndex = 53;
            this.cancelbutton.Text = "Отмена";
            this.cancelbutton.UseVisualStyleBackColor = false;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // InspButtFilt
            // 
            this.InspButtFilt.BackColor = System.Drawing.Color.White;
            this.InspButtFilt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InspButtFilt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.InspButtFilt.ForeColor = System.Drawing.Color.Black;
            this.InspButtFilt.Location = new System.Drawing.Point(292, 92);
            this.InspButtFilt.Name = "InspButtFilt";
            this.InspButtFilt.Size = new System.Drawing.Size(55, 23);
            this.InspButtFilt.TabIndex = 52;
            this.InspButtFilt.Text = "Фильт.";
            this.InspButtFilt.UseVisualStyleBackColor = false;
            this.InspButtFilt.Click += new System.EventHandler(this.InspButtFilt_Click);
            // 
            // inspectorcombo
            // 
            this.inspectorcombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.inspectorcombo.FormattingEnabled = true;
            this.inspectorcombo.Location = new System.Drawing.Point(6, 92);
            this.inspectorcombo.Name = "inspectorcombo";
            this.inspectorcombo.Size = new System.Drawing.Size(280, 23);
            this.inspectorcombo.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Инспектор";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Статус";
            // 
            // FilterButton
            // 
            this.FilterButton.BackColor = System.Drawing.Color.White;
            this.FilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.FilterButton.ForeColor = System.Drawing.Color.Black;
            this.FilterButton.Location = new System.Drawing.Point(123, 50);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(23, 23);
            this.FilterButton.TabIndex = 13;
            this.FilterButton.Text = "Ф";
            this.FilterButton.UseVisualStyleBackColor = false;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // sortOplataCombo
            // 
            this.sortOplataCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.sortOplataCombo.FormattingEnabled = true;
            this.sortOplataCombo.Items.AddRange(new object[] {
            "Не выбрано",
            "Оплачено",
            "Не оплачено"});
            this.sortOplataCombo.Location = new System.Drawing.Point(6, 50);
            this.sortOplataCombo.Name = "sortOplataCombo";
            this.sortOplataCombo.Size = new System.Drawing.Size(111, 23);
            this.sortOplataCombo.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(1142, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 30);
            this.button3.TabIndex = 8;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(6, 34);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(341, 251);
            this.panel5.TabIndex = 80;
            // 
            // InsptextBox
            // 
            this.InsptextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.InsptextBox.Location = new System.Drawing.Point(1428, 400);
            this.InsptextBox.Name = "InsptextBox";
            this.InsptextBox.Size = new System.Drawing.Size(100, 22);
            this.InsptextBox.TabIndex = 101;
            this.InsptextBox.TextChanged += new System.EventHandler(this.InsptextBox_TextChanged);
            this.InsptextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InsptextBox_KeyPress);
            // 
            // FtextBox
            // 
            this.FtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.FtextBox.Location = new System.Drawing.Point(1428, 363);
            this.FtextBox.Name = "FtextBox";
            this.FtextBox.Size = new System.Drawing.Size(100, 22);
            this.FtextBox.TabIndex = 100;
            this.FtextBox.TextChanged += new System.EventHandler(this.FtextBox_TextChanged);
            this.FtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FtextBox_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(1327, 402);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 17);
            this.label18.TabIndex = 99;
            this.label18.Text = "🔎Владелец";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(1327, 365);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 17);
            this.label17.TabIndex = 98;
            this.label17.Text = "🔎Инспектор";
            // 
            // reportsEditButton
            // 
            this.reportsEditButton.BackColor = System.Drawing.Color.White;
            this.reportsEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportsEditButton.ForeColor = System.Drawing.Color.Black;
            this.reportsEditButton.Location = new System.Drawing.Point(1383, 463);
            this.reportsEditButton.Name = "reportsEditButton";
            this.reportsEditButton.Size = new System.Drawing.Size(102, 30);
            this.reportsEditButton.TabIndex = 95;
            this.reportsEditButton.Text = "Изменить";
            this.reportsEditButton.UseVisualStyleBackColor = false;
            this.reportsEditButton.Click += new System.EventHandler(this.reportsEditButton_Click);
            // 
            // reportAddButton
            // 
            this.reportAddButton.BackColor = System.Drawing.Color.White;
            this.reportAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportAddButton.ForeColor = System.Drawing.Color.Black;
            this.reportAddButton.Location = new System.Drawing.Point(1268, 463);
            this.reportAddButton.Name = "reportAddButton";
            this.reportAddButton.Size = new System.Drawing.Size(109, 30);
            this.reportAddButton.TabIndex = 96;
            this.reportAddButton.Text = "Добавить";
            this.reportAddButton.UseVisualStyleBackColor = false;
            this.reportAddButton.Click += new System.EventHandler(this.reportAddButton_Click);
            // 
            // reportDelete
            // 
            this.reportDelete.BackColor = System.Drawing.Color.White;
            this.reportDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportDelete.ForeColor = System.Drawing.Color.Black;
            this.reportDelete.Location = new System.Drawing.Point(1491, 463);
            this.reportDelete.Name = "reportDelete";
            this.reportDelete.Size = new System.Drawing.Size(93, 30);
            this.reportDelete.TabIndex = 97;
            this.reportDelete.Text = "Удалить";
            this.reportDelete.UseVisualStyleBackColor = false;
            this.reportDelete.Click += new System.EventHandler(this.reportDelete_Click);
            // 
            // ReportTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1613, 513);
            this.Controls.Add(this.InsptextBox);
            this.Controls.Add(this.FtextBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.reportsEditButton);
            this.Controls.Add(this.reportAddButton);
            this.Controls.Add(this.reportDelete);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.pnlBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportTableForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ReportTableForm_Load);
            this.pnlBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Button btnMinimaze;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button OwnFilterButton;
        private System.Windows.Forms.ComboBox ownercombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button FineFilterButton;
        private System.Windows.Forms.ComboBox finecombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ReionFilterButton;
        private System.Windows.Forms.ComboBox regioncombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button InspButtFilt;
        private System.Windows.Forms.ComboBox inspectorcombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.ComboBox sortOplataCombo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox InsptextBox;
        private System.Windows.Forms.TextBox FtextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button reportsEditButton;
        private System.Windows.Forms.Button reportAddButton;
        private System.Windows.Forms.Button reportDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column24;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column25;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column26;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column27;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column28;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column29;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column30;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column31;
    }
}