
namespace ProgUP.FormsForAdmin
{
    partial class CarTableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarTableForm));
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.btnMinimaze = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.markcombo = new System.Windows.Forms.ComboBox();
            this.marbutton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ownbutton = new System.Windows.Forms.Button();
            this.colorcombo = new System.Windows.Forms.ComboBox();
            this.ownercmb = new System.Windows.Forms.ComboBox();
            this.colorbutton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ModeltextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.PTStextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.GostextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.carEditButton = new System.Windows.Forms.Button();
            this.CarAddButton = new System.Windows.Forms.Button();
            this.carDelete = new System.Windows.Forms.Button();
            this.pnlBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.lblTitle.Text = "Владельцы";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20});
            this.dataGridView2.Location = new System.Drawing.Point(12, 43);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1229, 450);
            this.dataGridView2.TabIndex = 11;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "PTSnum";
            this.Column13.HeaderText = "ПТС номер";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 82;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "mark";
            this.Column14.HeaderText = "Марка";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 65;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "color";
            this.Column15.HeaderText = "Цвет";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 57;
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "secondname";
            this.Column16.HeaderText = "Владелец";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Width = 81;
            // 
            // Column17
            // 
            this.Column17.DataPropertyName = "model";
            this.Column17.HeaderText = "Модель";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Width = 71;
            // 
            // Column18
            // 
            this.Column18.DataPropertyName = "reliseDate";
            this.Column18.HeaderText = "Дата выпуска";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            this.Column18.Width = 96;
            // 
            // Column19
            // 
            this.Column19.DataPropertyName = "gosNum";
            this.Column19.HeaderText = "Гос. номер";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            this.Column19.Width = 81;
            // 
            // Column20
            // 
            this.Column20.DataPropertyName = "regDate";
            this.Column20.HeaderText = "Дата регистрации";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            this.Column20.Width = 115;
            // 
            // groupBox4
            // 
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.panel4);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(1247, 36);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(353, 305);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Фильтрация";
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.markcombo);
            this.panel4.Controls.Add(this.marbutton);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.ownbutton);
            this.panel4.Controls.Add(this.colorcombo);
            this.panel4.Controls.Add(this.ownercmb);
            this.panel4.Controls.Add(this.colorbutton);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(6, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(341, 262);
            this.panel4.TabIndex = 79;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(0, 232);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(341, 30);
            this.button7.TabIndex = 78;
            this.button7.Text = "Отмена";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 66;
            this.label10.Text = "Марка";
            // 
            // markcombo
            // 
            this.markcombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.markcombo.FormattingEnabled = true;
            this.markcombo.Location = new System.Drawing.Point(0, 16);
            this.markcombo.Name = "markcombo";
            this.markcombo.Size = new System.Drawing.Size(280, 23);
            this.markcombo.TabIndex = 67;
            // 
            // marbutton
            // 
            this.marbutton.BackColor = System.Drawing.Color.White;
            this.marbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.marbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.marbutton.ForeColor = System.Drawing.Color.Black;
            this.marbutton.Location = new System.Drawing.Point(286, 16);
            this.marbutton.Name = "marbutton";
            this.marbutton.Size = new System.Drawing.Size(55, 23);
            this.marbutton.TabIndex = 68;
            this.marbutton.Text = "Фильт.";
            this.marbutton.UseVisualStyleBackColor = false;
            this.marbutton.Click += new System.EventHandler(this.marbutton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(0, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 69;
            this.label9.Text = "Цвет";
            // 
            // ownbutton
            // 
            this.ownbutton.BackColor = System.Drawing.Color.White;
            this.ownbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ownbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ownbutton.ForeColor = System.Drawing.Color.Black;
            this.ownbutton.Location = new System.Drawing.Point(286, 100);
            this.ownbutton.Name = "ownbutton";
            this.ownbutton.Size = new System.Drawing.Size(55, 23);
            this.ownbutton.TabIndex = 74;
            this.ownbutton.Text = "Фильт.";
            this.ownbutton.UseVisualStyleBackColor = false;
            this.ownbutton.Click += new System.EventHandler(this.ownbutton_Click);
            // 
            // colorcombo
            // 
            this.colorcombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.colorcombo.FormattingEnabled = true;
            this.colorcombo.Location = new System.Drawing.Point(0, 58);
            this.colorcombo.Name = "colorcombo";
            this.colorcombo.Size = new System.Drawing.Size(280, 23);
            this.colorcombo.TabIndex = 70;
            // 
            // ownercmb
            // 
            this.ownercmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ownercmb.FormattingEnabled = true;
            this.ownercmb.Location = new System.Drawing.Point(0, 100);
            this.ownercmb.Name = "ownercmb";
            this.ownercmb.Size = new System.Drawing.Size(280, 23);
            this.ownercmb.TabIndex = 73;
            // 
            // colorbutton
            // 
            this.colorbutton.BackColor = System.Drawing.Color.White;
            this.colorbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.colorbutton.ForeColor = System.Drawing.Color.Black;
            this.colorbutton.Location = new System.Drawing.Point(286, 58);
            this.colorbutton.Name = "colorbutton";
            this.colorbutton.Size = new System.Drawing.Size(55, 23);
            this.colorbutton.TabIndex = 71;
            this.colorbutton.Text = "Фильт.";
            this.colorbutton.UseVisualStyleBackColor = false;
            this.colorbutton.Click += new System.EventHandler(this.colorbutton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 72;
            this.label8.Text = "Владелец";
            // 
            // ModeltextBox
            // 
            this.ModeltextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModeltextBox.Location = new System.Drawing.Point(1431, 417);
            this.ModeltextBox.Name = "ModeltextBox";
            this.ModeltextBox.Size = new System.Drawing.Size(100, 22);
            this.ModeltextBox.TabIndex = 94;
            this.ModeltextBox.TextChanged += new System.EventHandler(this.ModeltextBox_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(1329, 419);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 17);
            this.label16.TabIndex = 93;
            this.label16.Text = "🔎Модель";
            // 
            // PTStextBox
            // 
            this.PTStextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PTStextBox.Location = new System.Drawing.Point(1431, 389);
            this.PTStextBox.Name = "PTStextBox";
            this.PTStextBox.Size = new System.Drawing.Size(100, 22);
            this.PTStextBox.TabIndex = 92;
            this.PTStextBox.TextChanged += new System.EventHandler(this.PTStextBox_TextChanged);
            this.PTStextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PTStextBox_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(1329, 391);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 17);
            this.label15.TabIndex = 91;
            this.label15.Text = "🔎ПТС";
            // 
            // GostextBox
            // 
            this.GostextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GostextBox.Location = new System.Drawing.Point(1431, 362);
            this.GostextBox.Name = "GostextBox";
            this.GostextBox.Size = new System.Drawing.Size(100, 22);
            this.GostextBox.TabIndex = 90;
            this.GostextBox.TextChanged += new System.EventHandler(this.GostextBox_TextChanged);
            this.GostextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GostextBox_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(1329, 364);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 17);
            this.label14.TabIndex = 89;
            this.label14.Text = "🔎Гос. номер";
            // 
            // carEditButton
            // 
            this.carEditButton.BackColor = System.Drawing.Color.White;
            this.carEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carEditButton.ForeColor = System.Drawing.Color.Black;
            this.carEditButton.Location = new System.Drawing.Point(1387, 463);
            this.carEditButton.Name = "carEditButton";
            this.carEditButton.Size = new System.Drawing.Size(102, 30);
            this.carEditButton.TabIndex = 7;
            this.carEditButton.Text = "Изменить";
            this.carEditButton.UseVisualStyleBackColor = false;
            this.carEditButton.Click += new System.EventHandler(this.carEditButton_Click);
            // 
            // CarAddButton
            // 
            this.CarAddButton.BackColor = System.Drawing.Color.White;
            this.CarAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CarAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarAddButton.ForeColor = System.Drawing.Color.Black;
            this.CarAddButton.Location = new System.Drawing.Point(1272, 463);
            this.CarAddButton.Name = "CarAddButton";
            this.CarAddButton.Size = new System.Drawing.Size(109, 30);
            this.CarAddButton.TabIndex = 6;
            this.CarAddButton.Text = "Добавить";
            this.CarAddButton.UseVisualStyleBackColor = false;
            this.CarAddButton.Click += new System.EventHandler(this.CarAddButton_Click);
            // 
            // carDelete
            // 
            this.carDelete.BackColor = System.Drawing.Color.White;
            this.carDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carDelete.ForeColor = System.Drawing.Color.Black;
            this.carDelete.Location = new System.Drawing.Point(1495, 463);
            this.carDelete.Name = "carDelete";
            this.carDelete.Size = new System.Drawing.Size(93, 30);
            this.carDelete.TabIndex = 7;
            this.carDelete.Text = "Удалить";
            this.carDelete.UseVisualStyleBackColor = false;
            this.carDelete.Click += new System.EventHandler(this.carDelete_Click);
            // 
            // CarTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1613, 512);
            this.Controls.Add(this.carDelete);
            this.Controls.Add(this.ModeltextBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.PTStextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.GostextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.carEditButton);
            this.Controls.Add(this.CarAddButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.pnlBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarTableForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CarTableForm_Load);
            this.pnlBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Button btnMinimaze;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox markcombo;
        private System.Windows.Forms.Button marbutton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ownbutton;
        private System.Windows.Forms.ComboBox colorcombo;
        private System.Windows.Forms.ComboBox ownercmb;
        private System.Windows.Forms.Button colorbutton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ModeltextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox PTStextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox GostextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button carEditButton;
        private System.Windows.Forms.Button CarAddButton;
        private System.Windows.Forms.Button carDelete;
    }
}