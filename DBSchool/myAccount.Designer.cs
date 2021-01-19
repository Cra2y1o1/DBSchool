namespace DBSchool
{
    partial class myAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myAccount));
            this.label1 = new System.Windows.Forms.Label();
            this.login_l = new System.Windows.Forms.Label();
            this.id_l = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lvl_l = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PhoneNumber_tb = new System.Windows.Forms.MaskedTextBox();
            this.Birthday_dtp = new System.Windows.Forms.DateTimePicker();
            this.sex_l = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.status_l = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.save_b = new System.Windows.Forms.Button();
            this.full_posit_l = new System.Windows.Forms.Label();
            this.secretWord_ctb = new customTextBox();
            this.email_ctm = new customTextBox();
            this.patr_tb = new customTextBox();
            this.Name_tb = new customTextBox();
            this.LastName_tb = new customTextBox();
            this.repeat_pass_tb = new customTextBox();
            this.new_pass_ctb = new customTextBox();
            this.old_pass_ctb = new customTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // login_l
            // 
            this.login_l.AutoSize = true;
            this.login_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_l.Location = new System.Drawing.Point(124, 31);
            this.login_l.Name = "login_l";
            this.login_l.Size = new System.Drawing.Size(48, 20);
            this.login_l.TabIndex = 1;
            this.login_l.Text = "Login";
            this.login_l.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // id_l
            // 
            this.id_l.AutoSize = true;
            this.id_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_l.Location = new System.Drawing.Point(154, 9);
            this.id_l.Name = "id_l";
            this.id_l.Size = new System.Drawing.Size(18, 20);
            this.id_l.TabIndex = 3;
            this.id_l.Text = "0";
            this.id_l.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ваш id";
            // 
            // lvl_l
            // 
            this.lvl_l.AutoSize = true;
            this.lvl_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvl_l.Location = new System.Drawing.Point(154, 54);
            this.lvl_l.Name = "lvl_l";
            this.lvl_l.Size = new System.Drawing.Size(18, 20);
            this.lvl_l.TabIndex = 12;
            this.lvl_l.Text = "0";
            this.lvl_l.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ур. доступа";
            // 
            // PhoneNumber_tb
            // 
            this.PhoneNumber_tb.Font = new System.Drawing.Font("Open Sans Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumber_tb.ForeColor = System.Drawing.Color.DimGray;
            this.PhoneNumber_tb.Location = new System.Drawing.Point(203, 116);
            this.PhoneNumber_tb.Mask = "+375(00)000-00-00";
            this.PhoneNumber_tb.Name = "PhoneNumber_tb";
            this.PhoneNumber_tb.Size = new System.Drawing.Size(156, 33);
            this.PhoneNumber_tb.TabIndex = 19;
            // 
            // Birthday_dtp
            // 
            this.Birthday_dtp.Font = new System.Drawing.Font("Open Sans Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Birthday_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Birthday_dtp.Location = new System.Drawing.Point(203, 155);
            this.Birthday_dtp.Name = "Birthday_dtp";
            this.Birthday_dtp.Size = new System.Drawing.Size(156, 33);
            this.Birthday_dtp.TabIndex = 20;
            this.Birthday_dtp.Value = new System.DateTime(2020, 9, 20, 22, 52, 13, 0);
            // 
            // sex_l
            // 
            this.sex_l.AutoSize = true;
            this.sex_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sex_l.Location = new System.Drawing.Point(483, 9);
            this.sex_l.Name = "sex_l";
            this.sex_l.Size = new System.Drawing.Size(74, 20);
            this.sex_l.TabIndex = 24;
            this.sex_l.Text = "Мужской";
            this.sex_l.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(381, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Пол";
            // 
            // status_l
            // 
            this.status_l.AutoSize = true;
            this.status_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status_l.Location = new System.Drawing.Point(472, 31);
            this.status_l.Name = "status_l";
            this.status_l.Size = new System.Drawing.Size(85, 20);
            this.status_l.TabIndex = 22;
            this.status_l.Text = "Учащийся";
            this.status_l.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(381, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Статус";
            // 
            // save_b
            // 
            this.save_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_b.Location = new System.Drawing.Point(372, 206);
            this.save_b.Name = "save_b";
            this.save_b.Size = new System.Drawing.Size(185, 38);
            this.save_b.TabIndex = 27;
            this.save_b.Text = "Сохранить изменения";
            this.save_b.UseVisualStyleBackColor = true;
            this.save_b.Click += new System.EventHandler(this.save_b_Click);
            // 
            // full_posit_l
            // 
            this.full_posit_l.AutoSize = true;
            this.full_posit_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.full_posit_l.Location = new System.Drawing.Point(21, 215);
            this.full_posit_l.Name = "full_posit_l";
            this.full_posit_l.Size = new System.Drawing.Size(95, 20);
            this.full_posit_l.TabIndex = 28;
            this.full_posit_l.Text = "Должность";
            // 
            // secretWord_ctb
            // 
            this.secretWord_ctb.Cue = "Секретное слово";
            this.secretWord_ctb.Font = new System.Drawing.Font("Open Sans Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secretWord_ctb.ForeColor = System.Drawing.Color.DimGray;
            this.secretWord_ctb.Location = new System.Drawing.Point(385, 130);
            this.secretWord_ctb.Name = "secretWord_ctb";
            this.secretWord_ctb.Size = new System.Drawing.Size(172, 33);
            this.secretWord_ctb.TabIndex = 26;
            // 
            // email_ctm
            // 
            this.email_ctm.Cue = "E-mail";
            this.email_ctm.Font = new System.Drawing.Font("Open Sans Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email_ctm.ForeColor = System.Drawing.Color.DimGray;
            this.email_ctm.Location = new System.Drawing.Point(385, 77);
            this.email_ctm.Name = "email_ctm";
            this.email_ctm.Size = new System.Drawing.Size(172, 33);
            this.email_ctm.TabIndex = 25;
            // 
            // patr_tb
            // 
            this.patr_tb.Cue = "Отчество";
            this.patr_tb.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patr_tb.ForeColor = System.Drawing.Color.DimGray;
            this.patr_tb.Location = new System.Drawing.Point(203, 75);
            this.patr_tb.Name = "patr_tb";
            this.patr_tb.Size = new System.Drawing.Size(156, 29);
            this.patr_tb.TabIndex = 15;
            // 
            // Name_tb
            // 
            this.Name_tb.Cue = "Имя";
            this.Name_tb.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_tb.ForeColor = System.Drawing.Color.DimGray;
            this.Name_tb.Location = new System.Drawing.Point(203, 40);
            this.Name_tb.Name = "Name_tb";
            this.Name_tb.Size = new System.Drawing.Size(156, 29);
            this.Name_tb.TabIndex = 14;
            // 
            // LastName_tb
            // 
            this.LastName_tb.Cue = "Фамилия";
            this.LastName_tb.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastName_tb.ForeColor = System.Drawing.Color.DimGray;
            this.LastName_tb.Location = new System.Drawing.Point(203, 5);
            this.LastName_tb.Name = "LastName_tb";
            this.LastName_tb.Size = new System.Drawing.Size(156, 29);
            this.LastName_tb.TabIndex = 13;
            // 
            // repeat_pass_tb
            // 
            this.repeat_pass_tb.Cue = "Повтор пароля";
            this.repeat_pass_tb.Font = new System.Drawing.Font("Open Sans Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repeat_pass_tb.ForeColor = System.Drawing.Color.DimGray;
            this.repeat_pass_tb.Location = new System.Drawing.Point(16, 155);
            this.repeat_pass_tb.Name = "repeat_pass_tb";
            this.repeat_pass_tb.Size = new System.Drawing.Size(156, 33);
            this.repeat_pass_tb.TabIndex = 10;
            // 
            // new_pass_ctb
            // 
            this.new_pass_ctb.Cue = "Новый пароль";
            this.new_pass_ctb.Font = new System.Drawing.Font("Open Sans Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.new_pass_ctb.ForeColor = System.Drawing.Color.DimGray;
            this.new_pass_ctb.Location = new System.Drawing.Point(16, 116);
            this.new_pass_ctb.Name = "new_pass_ctb";
            this.new_pass_ctb.Size = new System.Drawing.Size(156, 33);
            this.new_pass_ctb.TabIndex = 9;
            // 
            // old_pass_ctb
            // 
            this.old_pass_ctb.Cue = "Старый пароль";
            this.old_pass_ctb.Font = new System.Drawing.Font("Open Sans Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.old_pass_ctb.ForeColor = System.Drawing.Color.DimGray;
            this.old_pass_ctb.Location = new System.Drawing.Point(16, 77);
            this.old_pass_ctb.Name = "old_pass_ctb";
            this.old_pass_ctb.Size = new System.Drawing.Size(156, 33);
            this.old_pass_ctb.TabIndex = 8;
            // 
            // myAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(589, 256);
            this.Controls.Add(this.full_posit_l);
            this.Controls.Add(this.save_b);
            this.Controls.Add(this.secretWord_ctb);
            this.Controls.Add(this.email_ctm);
            this.Controls.Add(this.sex_l);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.status_l);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Birthday_dtp);
            this.Controls.Add(this.PhoneNumber_tb);
            this.Controls.Add(this.patr_tb);
            this.Controls.Add(this.Name_tb);
            this.Controls.Add(this.LastName_tb);
            this.Controls.Add(this.lvl_l);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.repeat_pass_tb);
            this.Controls.Add(this.new_pass_ctb);
            this.Controls.Add(this.old_pass_ctb);
            this.Controls.Add(this.id_l);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.login_l);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "myAccount";
            this.Text = "Мой аккаунт";
            this.Load += new System.EventHandler(this.myAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label login_l;
        private System.Windows.Forms.Label id_l;
        private System.Windows.Forms.Label label4;
        private customTextBox old_pass_ctb;
        private customTextBox new_pass_ctb;
        private customTextBox repeat_pass_tb;
        private System.Windows.Forms.Label lvl_l;
        private System.Windows.Forms.Label label6;
        private customTextBox LastName_tb;
        private customTextBox Name_tb;
        private customTextBox patr_tb;
        private System.Windows.Forms.MaskedTextBox PhoneNumber_tb;
        private System.Windows.Forms.DateTimePicker Birthday_dtp;
        private System.Windows.Forms.Label sex_l;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label status_l;
        private System.Windows.Forms.Label label12;
        private customTextBox email_ctm;
        private customTextBox secretWord_ctb;
        private System.Windows.Forms.Button save_b;
        private System.Windows.Forms.Label full_posit_l;
    }
}