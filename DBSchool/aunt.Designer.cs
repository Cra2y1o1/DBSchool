namespace DBSchool
{
    partial class aunt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aunt));
            this.CreateAcc_L = new System.Windows.Forms.Label();
            this.Log_in_b = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.showPass_cb = new System.Windows.Forms.CheckBox();
            this.dontRemember_l = new System.Windows.Forms.Label();
            this.badLogIn_l = new System.Windows.Forms.Label();
            this.password_tb = new customTextBox();
            this.username_tb = new customTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateAcc_L
            // 
            this.CreateAcc_L.AutoSize = true;
            this.CreateAcc_L.BackColor = System.Drawing.Color.Transparent;
            this.CreateAcc_L.Font = new System.Drawing.Font("Open Sans Semibold", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateAcc_L.ForeColor = System.Drawing.Color.Black;
            this.CreateAcc_L.Location = new System.Drawing.Point(252, 406);
            this.CreateAcc_L.Name = "CreateAcc_L";
            this.CreateAcc_L.Size = new System.Drawing.Size(129, 19);
            this.CreateAcc_L.TabIndex = 0;
            this.CreateAcc_L.Text = "Создать аккаунт";
            this.CreateAcc_L.Click += new System.EventHandler(this.CreateAcc_L_Click);
            this.CreateAcc_L.MouseEnter += new System.EventHandler(this.CreateAcc_L_MouseEnter);
            this.CreateAcc_L.MouseLeave += new System.EventHandler(this.CreateAcc_L_MouseLeave);
            // 
            // Log_in_b
            // 
            this.Log_in_b.BackColor = System.Drawing.Color.DarkMagenta;
            this.Log_in_b.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Log_in_b.ForeColor = System.Drawing.Color.Gainsboro;
            this.Log_in_b.Location = new System.Drawing.Point(151, 327);
            this.Log_in_b.Name = "Log_in_b";
            this.Log_in_b.Size = new System.Drawing.Size(321, 51);
            this.Log_in_b.TabIndex = 1;
            this.Log_in_b.Text = "войти";
            this.Log_in_b.UseVisualStyleBackColor = false;
            this.Log_in_b.Click += new System.EventHandler(this.Log_in_b_Click);
            this.Log_in_b.MouseEnter += new System.EventHandler(this.Log_in_b_MouseEnter);
            this.Log_in_b.MouseLeave += new System.EventHandler(this.Log_in_b_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DBSchool.Properties.Resources.icons8_управление_клиентами_50;
            this.pictureBox1.Location = new System.Drawing.Point(151, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DBSchool.Properties.Resources.icons8_щит_50;
            this.pictureBox2.Location = new System.Drawing.Point(151, 247);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // showPass_cb
            // 
            this.showPass_cb.AutoSize = true;
            this.showPass_cb.BackColor = System.Drawing.Color.Transparent;
            this.showPass_cb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.showPass_cb.Font = new System.Drawing.Font("Open Sans Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showPass_cb.ForeColor = System.Drawing.Color.Maroon;
            this.showPass_cb.Location = new System.Drawing.Point(151, 380);
            this.showPass_cb.Name = "showPass_cb";
            this.showPass_cb.Size = new System.Drawing.Size(149, 23);
            this.showPass_cb.TabIndex = 6;
            this.showPass_cb.Text = "Показать пароль";
            this.showPass_cb.UseVisualStyleBackColor = false;
            this.showPass_cb.CheckedChanged += new System.EventHandler(this.showPass_cb_CheckedChanged);
            // 
            // dontRemember_l
            // 
            this.dontRemember_l.AutoSize = true;
            this.dontRemember_l.BackColor = System.Drawing.Color.Transparent;
            this.dontRemember_l.Font = new System.Drawing.Font("Open Sans Semibold", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dontRemember_l.ForeColor = System.Drawing.Color.Black;
            this.dontRemember_l.Location = new System.Drawing.Point(354, 380);
            this.dontRemember_l.Name = "dontRemember_l";
            this.dontRemember_l.Size = new System.Drawing.Size(118, 19);
            this.dontRemember_l.TabIndex = 9;
            this.dontRemember_l.Text = "Забыли пароль?";
            this.dontRemember_l.Click += new System.EventHandler(this.dontRemember_l_Click);
            this.dontRemember_l.MouseEnter += new System.EventHandler(this.dontRemember_l_MouseEnter);
            this.dontRemember_l.MouseLeave += new System.EventHandler(this.dontRemember_l_MouseLeave);
            // 
            // badLogIn_l
            // 
            this.badLogIn_l.AutoSize = true;
            this.badLogIn_l.BackColor = System.Drawing.Color.Transparent;
            this.badLogIn_l.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.badLogIn_l.ForeColor = System.Drawing.Color.DarkRed;
            this.badLogIn_l.Location = new System.Drawing.Point(222, 302);
            this.badLogIn_l.Name = "badLogIn_l";
            this.badLogIn_l.Size = new System.Drawing.Size(207, 22);
            this.badLogIn_l.TabIndex = 10;
            this.badLogIn_l.Text = "Совпадения не найдены";
            this.badLogIn_l.Visible = false;
            // 
            // password_tb
            // 
            this.password_tb.Cue = "Password";
            this.password_tb.Font = new System.Drawing.Font("Open Sans Semibold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_tb.ForeColor = System.Drawing.Color.DimGray;
            this.password_tb.Location = new System.Drawing.Point(207, 247);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(265, 51);
            this.password_tb.TabIndex = 8;
            this.password_tb.UseSystemPasswordChar = true;
            this.password_tb.TextChanged += new System.EventHandler(this.password_tb_TextChanged);
            // 
            // username_tb
            // 
            this.username_tb.Cue = "Username";
            this.username_tb.Font = new System.Drawing.Font("Open Sans Semibold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.username_tb.ForeColor = System.Drawing.Color.DimGray;
            this.username_tb.Location = new System.Drawing.Point(207, 165);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(265, 51);
            this.username_tb.TabIndex = 7;
            this.username_tb.TextChanged += new System.EventHandler(this.username_tb_TextChanged);
            // 
            // aunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DBSchool.Properties.Resources.фон_640_480_2;
            this.ClientSize = new System.Drawing.Size(618, 479);
            this.Controls.Add(this.badLogIn_l);
            this.Controls.Add(this.dontRemember_l);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.username_tb);
            this.Controls.Add(this.showPass_cb);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Log_in_b);
            this.Controls.Add(this.CreateAcc_L);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "aunt";
            this.Text = "Авторизация ";
            this.Load += new System.EventHandler(this.aunt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreateAcc_L;
        private System.Windows.Forms.Button Log_in_b;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox showPass_cb;
        private customTextBox username_tb;
        private customTextBox password_tb;
        private System.Windows.Forms.Label dontRemember_l;
        private System.Windows.Forms.Label badLogIn_l;
    }
}

