namespace WindowsFormsApp1
{
    partial class Form1
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
            this.add_b = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mat_t = new System.Windows.Forms.TextBox();
            this.type_t = new System.Windows.Forms.TextBox();
            this.price_t = new System.Windows.Forms.TextBox();
            this.amount_t = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.supp_cb = new System.Windows.Forms.ComboBox();
            this.del_b = new System.Windows.Forms.Button();
            this.edit_b = new System.Windows.Forms.Button();
            this.id_t = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.suppid_t = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // add_b
            // 
            this.add_b.Location = new System.Drawing.Point(200, 877);
            this.add_b.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.add_b.Name = "add_b";
            this.add_b.Size = new System.Drawing.Size(138, 39);
            this.add_b.TabIndex = 0;
            this.add_b.Text = "добавить";
            this.add_b.UseVisualStyleBackColor = true;
            this.add_b.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(200, 78);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(948, 477);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mat_t
            // 
            this.mat_t.Location = new System.Drawing.Point(200, 616);
            this.mat_t.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.mat_t.Name = "mat_t";
            this.mat_t.Size = new System.Drawing.Size(382, 27);
            this.mat_t.TabIndex = 2;
            // 
            // type_t
            // 
            this.type_t.Location = new System.Drawing.Point(200, 658);
            this.type_t.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.type_t.Name = "type_t";
            this.type_t.Size = new System.Drawing.Size(382, 27);
            this.type_t.TabIndex = 3;
            // 
            // price_t
            // 
            this.price_t.Location = new System.Drawing.Point(200, 748);
            this.price_t.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.price_t.Name = "price_t";
            this.price_t.Size = new System.Drawing.Size(382, 27);
            this.price_t.TabIndex = 5;
            // 
            // amount_t
            // 
            this.amount_t.Location = new System.Drawing.Point(200, 792);
            this.amount_t.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.amount_t.Name = "amount_t";
            this.amount_t.Size = new System.Drawing.Size(382, 27);
            this.amount_t.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(649, 621);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "материал";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(649, 665);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Тип";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(649, 709);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "поставщик";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(649, 753);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(649, 797);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "количество";
            // 
            // supp_cb
            // 
            this.supp_cb.FormattingEnabled = true;
            this.supp_cb.Location = new System.Drawing.Point(200, 702);
            this.supp_cb.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.supp_cb.Name = "supp_cb";
            this.supp_cb.Size = new System.Drawing.Size(382, 30);
            this.supp_cb.TabIndex = 12;
            // 
            // del_b
            // 
            this.del_b.Location = new System.Drawing.Point(497, 877);
            this.del_b.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.del_b.Name = "del_b";
            this.del_b.Size = new System.Drawing.Size(138, 39);
            this.del_b.TabIndex = 13;
            this.del_b.Text = "удалить";
            this.del_b.UseVisualStyleBackColor = true;
            this.del_b.Click += new System.EventHandler(this.del_b_Click);
            // 
            // edit_b
            // 
            this.edit_b.Location = new System.Drawing.Point(348, 877);
            this.edit_b.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.edit_b.Name = "edit_b";
            this.edit_b.Size = new System.Drawing.Size(138, 39);
            this.edit_b.TabIndex = 14;
            this.edit_b.Text = "изменить";
            this.edit_b.UseVisualStyleBackColor = true;
            this.edit_b.Click += new System.EventHandler(this.edit_b_Click);
            // 
            // id_t
            // 
            this.id_t.Location = new System.Drawing.Point(200, 572);
            this.id_t.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.id_t.Name = "id_t";
            this.id_t.Size = new System.Drawing.Size(382, 27);
            this.id_t.TabIndex = 15;
            this.id_t.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_t_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(649, 577);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "id";
            // 
            // suppid_t
            // 
            this.suppid_t.Location = new System.Drawing.Point(776, 704);
            this.suppid_t.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.suppid_t.Name = "suppid_t";
            this.suppid_t.Size = new System.Drawing.Size(382, 27);
            this.suppid_t.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1342, 233);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 27);
            this.textBox1.TabIndex = 18;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1342, 279);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 39);
            this.button1.TabIndex = 19;
            this.button1.Text = "добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1905, 1171);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.suppid_t);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.id_t);
            this.Controls.Add(this.edit_b);
            this.Controls.Add(this.del_b);
            this.Controls.Add(this.supp_cb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amount_t);
            this.Controls.Add(this.price_t);
            this.Controls.Add(this.type_t);
            this.Controls.Add(this.mat_t);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.add_b);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_b;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox mat_t;
        private System.Windows.Forms.TextBox type_t;
        private System.Windows.Forms.TextBox price_t;
        private System.Windows.Forms.TextBox amount_t;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox supp_cb;
        private System.Windows.Forms.Button del_b;
        private System.Windows.Forms.Button edit_b;
        private System.Windows.Forms.TextBox id_t;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox suppid_t;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

