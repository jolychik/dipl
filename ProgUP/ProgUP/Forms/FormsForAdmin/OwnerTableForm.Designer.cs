
namespace ProgUP.FormsForAdmin
{
    partial class OwnerTableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerTableForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.btnMinimaze = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.DateRegbutton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.DolgBox = new System.Windows.Forms.ComboBox();
            this.Dolgbutton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.reportsEditButton = new System.Windows.Forms.Button();
            this.reportAddButton = new System.Windows.Forms.Button();
            this.reportDelete = new System.Windows.Forms.Button();
            this.EMAILtextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.FIOtextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel6.SuspendLayout();
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
            this.pnlBorder.Size = new System.Drawing.Size(1609, 30);
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
            this.lblTitle.Size = new System.Drawing.Size(1519, 30);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Владельцы";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnMinimaze.Location = new System.Drawing.Point(1549, 0);
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
            this.btnClose.Location = new System.Drawing.Point(1579, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column12,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1227, 450);
            this.dataGridView1.TabIndex = 11;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "idOwner";
            this.Column12.HeaderText = "Номер владельца";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 113;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "firstname";
            this.Column1.HeaderText = "Имя";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 54;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "secondname";
            this.Column2.HeaderText = "Фамилия";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 81;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "patronymic";
            this.Column3.HeaderText = "Отчество";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 79;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "idDriverRights";
            this.Column4.HeaderText = "Номер водит. прав";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 96;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ownerRegDate";
            this.Column5.HeaderText = "Дата регистрации";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 115;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "adres";
            this.Column6.HeaderText = "Адрес проживания";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 117;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "email";
            this.Column7.HeaderText = "Эл. почта";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 73;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "login";
            this.Column8.HeaderText = "Логин";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 63;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "password";
            this.Column9.HeaderText = "Пароль";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 70;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "telephone";
            this.Column10.HeaderText = "Телефон";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 77;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "sumDolg";
            this.Column11.HeaderText = "Долг";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 58;
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
            // panel6
            // 
            this.panel6.Controls.Add(this.dateTimePicker2);
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.DateRegbutton);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.DolgBox);
            this.panel6.Controls.Add(this.Dolgbutton);
            this.panel6.Location = new System.Drawing.Point(6, 34);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(341, 243);
            this.panel6.TabIndex = 80;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker2.Location = new System.Drawing.Point(0, 16);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(152, 23);
            this.dateTimePicker2.TabIndex = 79;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(0, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(341, 30);
            this.button2.TabIndex = 78;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "Дата регистрации";
            // 
            // DateRegbutton
            // 
            this.DateRegbutton.BackColor = System.Drawing.Color.White;
            this.DateRegbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DateRegbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.DateRegbutton.ForeColor = System.Drawing.Color.Black;
            this.DateRegbutton.Location = new System.Drawing.Point(158, 16);
            this.DateRegbutton.Name = "DateRegbutton";
            this.DateRegbutton.Size = new System.Drawing.Size(55, 23);
            this.DateRegbutton.TabIndex = 68;
            this.DateRegbutton.Text = "Фильт.";
            this.DateRegbutton.UseVisualStyleBackColor = false;
            this.DateRegbutton.Click += new System.EventHandler(this.DateRegbutton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(0, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 69;
            this.label11.Text = "Долг";
            // 
            // DolgBox
            // 
            this.DolgBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DolgBox.FormattingEnabled = true;
            this.DolgBox.Items.AddRange(new object[] {
            "Не выбрано",
            "Есть",
            "Отсутствует"});
            this.DolgBox.Location = new System.Drawing.Point(0, 58);
            this.DolgBox.Name = "DolgBox";
            this.DolgBox.Size = new System.Drawing.Size(152, 23);
            this.DolgBox.TabIndex = 70;
            // 
            // Dolgbutton
            // 
            this.Dolgbutton.BackColor = System.Drawing.Color.White;
            this.Dolgbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dolgbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Dolgbutton.ForeColor = System.Drawing.Color.Black;
            this.Dolgbutton.Location = new System.Drawing.Point(158, 58);
            this.Dolgbutton.Name = "Dolgbutton";
            this.Dolgbutton.Size = new System.Drawing.Size(55, 23);
            this.Dolgbutton.TabIndex = 71;
            this.Dolgbutton.Text = "Фильт.";
            this.Dolgbutton.UseVisualStyleBackColor = false;
            this.Dolgbutton.Click += new System.EventHandler(this.Dolgbutton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox4.Controls.Add(this.panel6);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(1245, 44);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(353, 284);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Фильтрация";
            // 
            // reportsEditButton
            // 
            this.reportsEditButton.BackColor = System.Drawing.Color.White;
            this.reportsEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportsEditButton.ForeColor = System.Drawing.Color.Black;
            this.reportsEditButton.Location = new System.Drawing.Point(1380, 464);
            this.reportsEditButton.Name = "reportsEditButton";
            this.reportsEditButton.Size = new System.Drawing.Size(102, 30);
            this.reportsEditButton.TabIndex = 88;
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
            this.reportAddButton.Location = new System.Drawing.Point(1265, 464);
            this.reportAddButton.Name = "reportAddButton";
            this.reportAddButton.Size = new System.Drawing.Size(109, 30);
            this.reportAddButton.TabIndex = 89;
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
            this.reportDelete.Location = new System.Drawing.Point(1488, 464);
            this.reportDelete.Name = "reportDelete";
            this.reportDelete.Size = new System.Drawing.Size(93, 30);
            this.reportDelete.TabIndex = 90;
            this.reportDelete.Text = "Удалить";
            this.reportDelete.UseVisualStyleBackColor = false;
            this.reportDelete.Click += new System.EventHandler(this.reportDelete_Click);
            // 
            // EMAILtextBox
            // 
            this.EMAILtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EMAILtextBox.Location = new System.Drawing.Point(1422, 397);
            this.EMAILtextBox.Name = "EMAILtextBox";
            this.EMAILtextBox.Size = new System.Drawing.Size(100, 22);
            this.EMAILtextBox.TabIndex = 94;
            this.EMAILtextBox.TextChanged += new System.EventHandler(this.EMAILtextBox_TextChanged);
            this.EMAILtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EMAILtextBox_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(1330, 399);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 17);
            this.label13.TabIndex = 93;
            this.label13.Text = "🔎Эл. почта";
            // 
            // FIOtextBox
            // 
            this.FIOtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOtextBox.Location = new System.Drawing.Point(1422, 369);
            this.FIOtextBox.Name = "FIOtextBox";
            this.FIOtextBox.Size = new System.Drawing.Size(100, 22);
            this.FIOtextBox.TabIndex = 92;
            this.FIOtextBox.TextChanged += new System.EventHandler(this.FIOtextBox_TextChanged);
            this.FIOtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FIOtextBox_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(1330, 372);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 17);
            this.label12.TabIndex = 91;
            this.label12.Text = "🔎Фамилия";
            // 
            // OwnerTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1609, 514);
            this.Controls.Add(this.EMAILtextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.FIOtextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.reportsEditButton);
            this.Controls.Add(this.reportAddButton);
            this.Controls.Add(this.reportDelete);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnlBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OwnerTableForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OwnerTableForm_Load);
            this.pnlBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Button btnMinimaze;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DateRegbutton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox DolgBox;
        private System.Windows.Forms.Button Dolgbutton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button reportsEditButton;
        private System.Windows.Forms.Button reportAddButton;
        private System.Windows.Forms.Button reportDelete;
        private System.Windows.Forms.TextBox EMAILtextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox FIOtextBox;
        private System.Windows.Forms.Label label12;
    }
}