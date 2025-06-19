
namespace WindowsFormsApp1
{
    partial class Login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.signin_b = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_f = new System.Windows.Forms.TextBox();
            this.password_f = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.min_b = new System.Windows.Forms.PictureBox();
            this.close_b = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.min_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_b)).BeginInit();
            this.SuspendLayout();
            // 
            // signin_b
            // 
            this.signin_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signin_b.Location = new System.Drawing.Point(129, 163);
            this.signin_b.Name = "signin_b";
            this.signin_b.Size = new System.Drawing.Size(153, 38);
            this.signin_b.TabIndex = 0;
            this.signin_b.Text = "Sign In";
            this.signin_b.UseVisualStyleBackColor = true;
            this.signin_b.Click += new System.EventHandler(this.signin_b_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(54, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(54, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // login_f
            // 
            this.login_f.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_f.Location = new System.Drawing.Point(205, 64);
            this.login_f.Name = "login_f";
            this.login_f.Size = new System.Drawing.Size(168, 29);
            this.login_f.TabIndex = 5;
            this.login_f.Text = "L";
            // 
            // password_f
            // 
            this.password_f.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_f.Location = new System.Drawing.Point(205, 103);
            this.password_f.Name = "password_f";
            this.password_f.Size = new System.Drawing.Size(168, 29);
            this.password_f.TabIndex = 6;
            this.password_f.Text = "asd";
            this.password_f.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.min_b);
            this.panel1.Controls.Add(this.close_b);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 30);
            this.panel1.TabIndex = 7;
            // 
            // min_b
            // 
            this.min_b.BackColor = System.Drawing.Color.LightGray;
            this.min_b.Image = global::WindowsFormsApp1.Properties.Resources.minimize;
            this.min_b.Location = new System.Drawing.Point(357, 6);
            this.min_b.Name = "min_b";
            this.min_b.Size = new System.Drawing.Size(20, 20);
            this.min_b.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.min_b.TabIndex = 9;
            this.min_b.TabStop = false;
            this.min_b.Click += new System.EventHandler(this.min_b_Click);
            this.min_b.MouseEnter += new System.EventHandler(this.min_b_MouseEnter);
            this.min_b.MouseLeave += new System.EventHandler(this.min_b_MouseLeave);
            // 
            // close_b
            // 
            this.close_b.BackColor = System.Drawing.Color.LightGray;
            this.close_b.Image = global::WindowsFormsApp1.Properties.Resources.close;
            this.close_b.Location = new System.Drawing.Point(383, 6);
            this.close_b.Name = "close_b";
            this.close_b.Size = new System.Drawing.Size(20, 20);
            this.close_b.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_b.TabIndex = 8;
            this.close_b.TabStop = false;
            this.close_b.Click += new System.EventHandler(this.pictureBox1_Click);
            this.close_b.MouseEnter += new System.EventHandler(this.close_b_MouseEnter);
            this.close_b.MouseLeave += new System.EventHandler(this.close_b_MouseLeave);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(410, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Login";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label4_MouseDown);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(410, 244);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.password_f);
            this.Controls.Add(this.login_f);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.signin_b);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeBegin += new System.EventHandler(this.Login_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.Login_ResizeEnd);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.min_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_b)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signin_b;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login_f;
        private System.Windows.Forms.TextBox password_f;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox close_b;
        private System.Windows.Forms.PictureBox min_b;
    }
}

