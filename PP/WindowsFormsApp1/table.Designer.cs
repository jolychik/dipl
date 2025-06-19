
namespace WindowsFormsApp1
{
    partial class table
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.kart_dgv = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.developer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_pom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_dobav = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_k_k = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naz_dgv = new System.Windows.Forms.DataGridView();
            this.id_naz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_k = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьСправочникиВНовомОкнеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перейтиКСправочникамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вывестиВExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.моделиКартриджейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всёОКартриджахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.min_b = new System.Windows.Forms.PictureBox();
            this.close_b = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.id_naz_f = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tip_k_cb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name_k_f = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.color_f = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.data_f = new System.Windows.Forms.DateTimePicker();
            this.name_k_cb = new System.Windows.Forms.ComboBox();
            this.pom_cb = new System.Windows.Forms.ComboBox();
            this.dev_cb = new System.Windows.Forms.ComboBox();
            this.klass_f = new System.Windows.Forms.TextBox();
            this.kolvo_f = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.id_f = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.kart_del = new System.Windows.Forms.Button();
            this.kart_upd = new System.Windows.Forms.Button();
            this.kart_add = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.naz_del = new System.Windows.Forms.Button();
            this.naz_upd = new System.Windows.Forms.Button();
            this.naz_add = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.вывестиВWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.моделиКартриджейToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.всёОКартриджахToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kart_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naz_dgv)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.min_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_b)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.kart_dgv, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.naz_dgv, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 54);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1430, 270);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // kart_dgv
            // 
            this.kart_dgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.kart_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kart_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.developer,
            this.id_pom,
            this.kolvo,
            this.data_dobav,
            this.name_k_k,
            this.klass});
            this.kart_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kart_dgv.Location = new System.Drawing.Point(503, 3);
            this.kart_dgv.Name = "kart_dgv";
            this.kart_dgv.Size = new System.Drawing.Size(924, 264);
            this.kart_dgv.TabIndex = 1;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // developer
            // 
            this.developer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.developer.DataPropertyName = "developer";
            this.developer.HeaderText = "Название производителя";
            this.developer.Name = "developer";
            // 
            // id_pom
            // 
            this.id_pom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_pom.DataPropertyName = "pomesheniya";
            this.id_pom.HeaderText = "Название помещения";
            this.id_pom.Name = "id_pom";
            // 
            // kolvo
            // 
            this.kolvo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kolvo.DataPropertyName = "kolvo";
            this.kolvo.HeaderText = "Количество";
            this.kolvo.Name = "kolvo";
            // 
            // data_dobav
            // 
            this.data_dobav.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.data_dobav.DataPropertyName = "data_dobav";
            this.data_dobav.HeaderText = "Дата добавления";
            this.data_dobav.Name = "data_dobav";
            // 
            // name_k_k
            // 
            this.name_k_k.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name_k_k.DataPropertyName = "name_k";
            this.name_k_k.HeaderText = "Модель картриджа";
            this.name_k_k.Name = "name_k_k";
            // 
            // klass
            // 
            this.klass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.klass.DataPropertyName = "klass";
            this.klass.HeaderText = "Класс";
            this.klass.Name = "klass";
            // 
            // naz_dgv
            // 
            this.naz_dgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.naz_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.naz_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_naz,
            this.name_k,
            this.color,
            this.id_tip});
            this.naz_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.naz_dgv.Location = new System.Drawing.Point(3, 3);
            this.naz_dgv.Name = "naz_dgv";
            this.naz_dgv.Size = new System.Drawing.Size(494, 264);
            this.naz_dgv.TabIndex = 0;
            // 
            // id_naz
            // 
            this.id_naz.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_naz.DataPropertyName = "id_naz";
            this.id_naz.HeaderText = "ID";
            this.id_naz.Name = "id_naz";
            // 
            // name_k
            // 
            this.name_k.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name_k.DataPropertyName = "name_k";
            this.name_k.HeaderText = "Модель картриджа";
            this.name_k.Name = "name_k";
            // 
            // color
            // 
            this.color.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.color.DataPropertyName = "color";
            this.color.HeaderText = "Цвет картриджа";
            this.color.Name = "color";
            // 
            // id_tip
            // 
            this.id_tip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_tip.DataPropertyName = "tip_kart";
            this.id_tip.HeaderText = "Тип картриджа";
            this.id_tip.Name = "id_tip";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.вывестиВExcelToolStripMenuItem,
            this.вывестиВWordToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 30);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1430, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьСправочникиВНовомОкнеToolStripMenuItem,
            this.перейтиКСправочникамToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // открытьСправочникиВНовомОкнеToolStripMenuItem
            // 
            this.открытьСправочникиВНовомОкнеToolStripMenuItem.Name = "открытьСправочникиВНовомОкнеToolStripMenuItem";
            this.открытьСправочникиВНовомОкнеToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.открытьСправочникиВНовомОкнеToolStripMenuItem.Text = "Открыть справочники в новом окне";
            this.открытьСправочникиВНовомОкнеToolStripMenuItem.Click += new System.EventHandler(this.открытьСправочникиВНовомОкнеToolStripMenuItem_Click);
            // 
            // перейтиКСправочникамToolStripMenuItem
            // 
            this.перейтиКСправочникамToolStripMenuItem.Name = "перейтиКСправочникамToolStripMenuItem";
            this.перейтиКСправочникамToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.перейтиКСправочникамToolStripMenuItem.Text = "Перейти к справочникам";
            this.перейтиКСправочникамToolStripMenuItem.Click += new System.EventHandler(this.перейтиКСправочникамToolStripMenuItem_Click);
            // 
            // вывестиВExcelToolStripMenuItem
            // 
            this.вывестиВExcelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.моделиКартриджейToolStripMenuItem,
            this.всёОКартриджахToolStripMenuItem});
            this.вывестиВExcelToolStripMenuItem.Name = "вывестиВExcelToolStripMenuItem";
            this.вывестиВExcelToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.вывестиВExcelToolStripMenuItem.Text = "Вывести в Excel";
            // 
            // моделиКартриджейToolStripMenuItem
            // 
            this.моделиКартриджейToolStripMenuItem.Name = "моделиКартриджейToolStripMenuItem";
            this.моделиКартриджейToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.моделиКартриджейToolStripMenuItem.Text = "Модели картриджей";
            this.моделиКартриджейToolStripMenuItem.Click += new System.EventHandler(this.моделиКартриджейToolStripMenuItem_Click);
            // 
            // всёОКартриджахToolStripMenuItem
            // 
            this.всёОКартриджахToolStripMenuItem.Name = "всёОКартриджахToolStripMenuItem";
            this.всёОКартриджахToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.всёОКартриджахToolStripMenuItem.Text = "Всё о картриджах";
            this.всёОКартриджахToolStripMenuItem.Click += new System.EventHandler(this.всёОКартриджахToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.min_b);
            this.panel1.Controls.Add(this.close_b);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1430, 30);
            this.panel1.TabIndex = 2;
            // 
            // min_b
            // 
            this.min_b.BackColor = System.Drawing.Color.LightGray;
            this.min_b.Image = global::WindowsFormsApp1.Properties.Resources.minimize;
            this.min_b.Location = new System.Drawing.Point(1374, 6);
            this.min_b.Name = "min_b";
            this.min_b.Size = new System.Drawing.Size(20, 20);
            this.min_b.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.min_b.TabIndex = 11;
            this.min_b.TabStop = false;
            this.min_b.Click += new System.EventHandler(this.min_b_Click);
            this.min_b.MouseEnter += new System.EventHandler(this.min_b_MouseEnter);
            this.min_b.MouseLeave += new System.EventHandler(this.min_b_MouseLeave);
            // 
            // close_b
            // 
            this.close_b.BackColor = System.Drawing.Color.LightGray;
            this.close_b.Image = global::WindowsFormsApp1.Properties.Resources.close;
            this.close_b.Location = new System.Drawing.Point(1400, 6);
            this.close_b.Name = "close_b";
            this.close_b.Size = new System.Drawing.Size(20, 20);
            this.close_b.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_b.TabIndex = 10;
            this.close_b.TabStop = false;
            this.close_b.Click += new System.EventHandler(this.pictureBox1_Click);
            this.close_b.MouseEnter += new System.EventHandler(this.close_b_MouseEnter);
            this.close_b.MouseLeave += new System.EventHandler(this.close_b_MouseLeave);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.LightGray;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1430, 30);
            this.label11.TabIndex = 0;
            this.label11.Text = "Таблицы";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label11_MouseDown);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 327);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(502, 140);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.id_naz_f, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tip_k_cb, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.name_k_f, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.color_f, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(496, 134);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // id_naz_f
            // 
            this.id_naz_f.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.id_naz_f.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_naz_f.Location = new System.Drawing.Point(251, 3);
            this.id_naz_f.Name = "id_naz_f";
            this.id_naz_f.Size = new System.Drawing.Size(242, 26);
            this.id_naz_f.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(3, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(242, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "ID модели";
            // 
            // tip_k_cb
            // 
            this.tip_k_cb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tip_k_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tip_k_cb.FormattingEnabled = true;
            this.tip_k_cb.Location = new System.Drawing.Point(251, 102);
            this.tip_k_cb.Name = "tip_k_cb";
            this.tip_k_cb.Size = new System.Drawing.Size(242, 28);
            this.tip_k_cb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Тип картриджа";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Модель картриджа";
            // 
            // name_k_f
            // 
            this.name_k_f.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.name_k_f.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_k_f.Location = new System.Drawing.Point(251, 36);
            this.name_k_f.Name = "name_k_f";
            this.name_k_f.Size = new System.Drawing.Size(242, 26);
            this.name_k_f.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Цвет картриджа";
            // 
            // color_f
            // 
            this.color_f.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.color_f.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.color_f.Location = new System.Drawing.Point(251, 69);
            this.color_f.Name = "color_f";
            this.color_f.Size = new System.Drawing.Size(242, 26);
            this.color_f.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.data_f);
            this.panel2.Controls.Add(this.name_k_cb);
            this.panel2.Controls.Add(this.pom_cb);
            this.panel2.Controls.Add(this.dev_cb);
            this.panel2.Controls.Add(this.klass_f);
            this.panel2.Controls.Add(this.kolvo_f);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.id_f);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(502, 327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 140);
            this.panel2.TabIndex = 4;
            // 
            // data_f
            // 
            this.data_f.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.data_f.CustomFormat = "yyyy-MM-dd";
            this.data_f.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.data_f.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data_f.Location = new System.Drawing.Point(698, 37);
            this.data_f.Name = "data_f";
            this.data_f.Size = new System.Drawing.Size(169, 29);
            this.data_f.TabIndex = 18;
            this.data_f.Value = new System.DateTime(2022, 1, 13, 0, 0, 0, 0);
            // 
            // name_k_cb
            // 
            this.name_k_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_k_cb.FormattingEnabled = true;
            this.name_k_cb.Location = new System.Drawing.Point(698, 73);
            this.name_k_cb.Name = "name_k_cb";
            this.name_k_cb.Size = new System.Drawing.Size(169, 28);
            this.name_k_cb.TabIndex = 17;
            // 
            // pom_cb
            // 
            this.pom_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pom_cb.FormattingEnabled = true;
            this.pom_cb.Location = new System.Drawing.Point(255, 102);
            this.pom_cb.Name = "pom_cb";
            this.pom_cb.Size = new System.Drawing.Size(169, 28);
            this.pom_cb.TabIndex = 16;
            // 
            // dev_cb
            // 
            this.dev_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dev_cb.FormattingEnabled = true;
            this.dev_cb.Location = new System.Drawing.Point(255, 56);
            this.dev_cb.Name = "dev_cb";
            this.dev_cb.Size = new System.Drawing.Size(169, 28);
            this.dev_cb.TabIndex = 15;
            // 
            // klass_f
            // 
            this.klass_f.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.klass_f.Location = new System.Drawing.Point(698, 107);
            this.klass_f.Name = "klass_f";
            this.klass_f.Size = new System.Drawing.Size(169, 26);
            this.klass_f.TabIndex = 14;
            // 
            // kolvo_f
            // 
            this.kolvo_f.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kolvo_f.Location = new System.Drawing.Point(698, 6);
            this.kolvo_f.Name = "kolvo_f";
            this.kolvo_f.Size = new System.Drawing.Size(169, 26);
            this.kolvo_f.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(480, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Класс";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Название производителя";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(480, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Модель картриджа";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(480, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Дата добавления";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(480, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Количество";
            // 
            // id_f
            // 
            this.id_f.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_f.Location = new System.Drawing.Point(255, 9);
            this.id_f.Name = "id_f";
            this.id_f.Size = new System.Drawing.Size(169, 26);
            this.id_f.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Названия помещения";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "ID";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 465);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1430, 75);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Controls.Add(this.kart_del, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.kart_upd, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.kart_add, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(503, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(924, 69);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // kart_del
            // 
            this.kart_del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.kart_del.Location = new System.Drawing.Point(699, 5);
            this.kart_del.Name = "kart_del";
            this.kart_del.Size = new System.Drawing.Size(139, 59);
            this.kart_del.TabIndex = 3;
            this.kart_del.Text = "Удалить";
            this.kart_del.UseVisualStyleBackColor = true;
            this.kart_del.Click += new System.EventHandler(this.kart_del_Click);
            // 
            // kart_upd
            // 
            this.kart_upd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.kart_upd.Location = new System.Drawing.Point(392, 5);
            this.kart_upd.Name = "kart_upd";
            this.kart_upd.Size = new System.Drawing.Size(139, 59);
            this.kart_upd.TabIndex = 2;
            this.kart_upd.Text = "Изменить";
            this.kart_upd.UseVisualStyleBackColor = true;
            this.kart_upd.Click += new System.EventHandler(this.kart_upd_Click);
            // 
            // kart_add
            // 
            this.kart_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.kart_add.Location = new System.Drawing.Point(85, 5);
            this.kart_add.Name = "kart_add";
            this.kart_add.Size = new System.Drawing.Size(139, 59);
            this.kart_add.TabIndex = 1;
            this.kart_add.Text = "Добавить";
            this.kart_add.UseVisualStyleBackColor = true;
            this.kart_add.Click += new System.EventHandler(this.kart_add_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.naz_del, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.naz_upd, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.naz_add, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(494, 69);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // naz_del
            // 
            this.naz_del.Dock = System.Windows.Forms.DockStyle.Fill;
            this.naz_del.Location = new System.Drawing.Point(333, 5);
            this.naz_del.Name = "naz_del";
            this.naz_del.Size = new System.Drawing.Size(156, 59);
            this.naz_del.TabIndex = 2;
            this.naz_del.Text = "Удалить";
            this.naz_del.UseVisualStyleBackColor = true;
            this.naz_del.Click += new System.EventHandler(this.naz_del_Click);
            // 
            // naz_upd
            // 
            this.naz_upd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.naz_upd.Location = new System.Drawing.Point(169, 5);
            this.naz_upd.Name = "naz_upd";
            this.naz_upd.Size = new System.Drawing.Size(156, 59);
            this.naz_upd.TabIndex = 1;
            this.naz_upd.Text = "Изменить";
            this.naz_upd.UseVisualStyleBackColor = true;
            this.naz_upd.Click += new System.EventHandler(this.naz_upd_Click);
            // 
            // naz_add
            // 
            this.naz_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.naz_add.Location = new System.Drawing.Point(5, 5);
            this.naz_add.Name = "naz_add";
            this.naz_add.Size = new System.Drawing.Size(156, 59);
            this.naz_add.TabIndex = 0;
            this.naz_add.Text = "Добавить";
            this.naz_add.UseVisualStyleBackColor = true;
            this.naz_add.Click += new System.EventHandler(this.naz_add_Click);
            // 
            // вывестиВWordToolStripMenuItem
            // 
            this.вывестиВWordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.моделиКартриджейToolStripMenuItem1,
            this.всёОКартриджахToolStripMenuItem1});
            this.вывестиВWordToolStripMenuItem.Name = "вывестиВWordToolStripMenuItem";
            this.вывестиВWordToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.вывестиВWordToolStripMenuItem.Text = "Вывести в Word";
            // 
            // моделиКартриджейToolStripMenuItem1
            // 
            this.моделиКартриджейToolStripMenuItem1.Name = "моделиКартриджейToolStripMenuItem1";
            this.моделиКартриджейToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.моделиКартриджейToolStripMenuItem1.Text = "Модели картриджей";
            // 
            // всёОКартриджахToolStripMenuItem1
            // 
            this.всёОКартриджахToolStripMenuItem1.Name = "всёОКартриджахToolStripMenuItem1";
            this.всёОКартриджахToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.всёОКартриджахToolStripMenuItem1.Text = "Всё о картриджах";
            // 
            // table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1430, 557);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "table";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "table";
            this.Load += new System.EventHandler(this.table_Load);
            this.ResizeBegin += new System.EventHandler(this.table_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.table_ResizeEnd);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kart_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naz_dgv)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.min_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_b)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem вывестиВExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem моделиКартриджейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всёОКартриджахToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView kart_dgv;
        private System.Windows.Forms.DataGridView naz_dgv;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox color_f;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_k_f;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox name_k_cb;
        private System.Windows.Forms.ComboBox pom_cb;
        private System.Windows.Forms.ComboBox dev_cb;
        private System.Windows.Forms.TextBox klass_f;
        private System.Windows.Forms.TextBox kolvo_f;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox id_f;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button kart_del;
        private System.Windows.Forms.Button kart_upd;
        private System.Windows.Forms.Button kart_add;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button naz_del;
        private System.Windows.Forms.Button naz_upd;
        private System.Windows.Forms.Button naz_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn developer;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pom;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvo;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_dobav;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_k_k;
        private System.Windows.Forms.DataGridViewTextBoxColumn klass;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox min_b;
        private System.Windows.Forms.PictureBox close_b;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьСправочникиВНовомОкнеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перейтиКСправочникамToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_naz;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_k;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tip_k_cb;
        private System.Windows.Forms.TextBox id_naz_f;
        private System.Windows.Forms.Label label12;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker data_f;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ToolStripMenuItem вывестиВWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem моделиКартриджейToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem всёОКартриджахToolStripMenuItem1;
    }
}