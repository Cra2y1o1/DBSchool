namespace DBSchool
{
    partial class singIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(singIn));
            this.NextStep_b = new System.Windows.Forms.Button();
            this.back_l = new System.Windows.Forms.Label();
            this.stage_l = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Sex_cb = new System.Windows.Forms.ComboBox();
            this.Bithday_dtp = new System.Windows.Forms.DateTimePicker();
            this.PhoneNumber_tb = new System.Windows.Forms.MaskedTextBox();
            this.tb_3 = new customTextBox();
            this.tb_2 = new customTextBox();
            this.tb_1 = new customTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // NextStep_b
            // 
            this.NextStep_b.BackColor = System.Drawing.Color.DarkMagenta;
            this.NextStep_b.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextStep_b.ForeColor = System.Drawing.Color.Gainsboro;
            this.NextStep_b.Location = new System.Drawing.Point(156, 312);
            this.NextStep_b.Name = "NextStep_b";
            this.NextStep_b.Size = new System.Drawing.Size(321, 51);
            this.NextStep_b.TabIndex = 11;
            this.NextStep_b.Text = "ДАЛЕЕ";
            this.NextStep_b.UseVisualStyleBackColor = false;
            this.NextStep_b.Click += new System.EventHandler(this.NextStep_b_Click);
            this.NextStep_b.MouseEnter += new System.EventHandler(this.NextStep_b_MouseEnter);
            this.NextStep_b.MouseLeave += new System.EventHandler(this.NextStep_b_MouseLeave);
            // 
            // back_l
            // 
            this.back_l.AutoSize = true;
            this.back_l.BackColor = System.Drawing.Color.Transparent;
            this.back_l.Font = new System.Drawing.Font("Open Sans Semibold", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_l.ForeColor = System.Drawing.Color.Black;
            this.back_l.Location = new System.Drawing.Point(152, 366);
            this.back_l.Name = "back_l";
            this.back_l.Size = new System.Drawing.Size(83, 19);
            this.back_l.TabIndex = 12;
            this.back_l.Text = "Вернуться";
            this.back_l.Click += new System.EventHandler(this.back_l_Click);
            this.back_l.MouseEnter += new System.EventHandler(this.back_l_MouseEnter);
            this.back_l.MouseLeave += new System.EventHandler(this.back_l_MouseLeave);
            // 
            // stage_l
            // 
            this.stage_l.AutoSize = true;
            this.stage_l.BackColor = System.Drawing.Color.Transparent;
            this.stage_l.Font = new System.Drawing.Font("Open Sans Semibold", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stage_l.ForeColor = System.Drawing.Color.Black;
            this.stage_l.Location = new System.Drawing.Point(314, 366);
            this.stage_l.Name = "stage_l";
            this.stage_l.Size = new System.Drawing.Size(163, 19);
            this.stage_l.TabIndex = 13;
            this.stage_l.Text = "Этап регистрации 1/4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DBSchool.Properties.Resources.a_;
            this.pictureBox1.Location = new System.Drawing.Point(-5, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DBSchool.Properties.Resources.icons8_book_64;
            this.pictureBox2.Location = new System.Drawing.Point(487, 229);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // Sex_cb
            // 
            this.Sex_cb.Font = new System.Drawing.Font("Open Sans Semibold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sex_cb.ForeColor = System.Drawing.Color.DimGray;
            this.Sex_cb.FormattingEnabled = true;
            this.Sex_cb.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.Sex_cb.Location = new System.Drawing.Point(188, 88);
            this.Sex_cb.Name = "Sex_cb";
            this.Sex_cb.Size = new System.Drawing.Size(265, 51);
            this.Sex_cb.TabIndex = 16;
            this.Sex_cb.Text = "Пол";
            this.Sex_cb.Visible = false;
            // 
            // Bithday_dtp
            // 
            this.Bithday_dtp.Font = new System.Drawing.Font("Open Sans Semibold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bithday_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Bithday_dtp.Location = new System.Drawing.Point(188, 158);
            this.Bithday_dtp.Name = "Bithday_dtp";
            this.Bithday_dtp.Size = new System.Drawing.Size(265, 51);
            this.Bithday_dtp.TabIndex = 17;
            this.Bithday_dtp.Value = new System.DateTime(2020, 9, 20, 22, 52, 13, 0);
            this.Bithday_dtp.Visible = false;
            // 
            // PhoneNumber_tb
            // 
            this.PhoneNumber_tb.Font = new System.Drawing.Font("Open Sans Semibold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumber_tb.ForeColor = System.Drawing.Color.DimGray;
            this.PhoneNumber_tb.Location = new System.Drawing.Point(188, 229);
            this.PhoneNumber_tb.Mask = "+375(00)000-00-00";
            this.PhoneNumber_tb.Name = "PhoneNumber_tb";
            this.PhoneNumber_tb.Size = new System.Drawing.Size(265, 51);
            this.PhoneNumber_tb.TabIndex = 18;
            this.PhoneNumber_tb.Visible = false;
            // 
            // tb_3
            // 
            this.tb_3.Cue = "Отчество";
            this.tb_3.Font = new System.Drawing.Font("Open Sans Semibold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_3.ForeColor = System.Drawing.Color.DimGray;
            this.tb_3.Location = new System.Drawing.Point(188, 229);
            this.tb_3.Name = "tb_3";
            this.tb_3.Size = new System.Drawing.Size(265, 51);
            this.tb_3.TabIndex = 10;
            // 
            // tb_2
            // 
            this.tb_2.Cue = "Имя";
            this.tb_2.Font = new System.Drawing.Font("Open Sans Semibold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_2.ForeColor = System.Drawing.Color.DimGray;
            this.tb_2.Location = new System.Drawing.Point(188, 158);
            this.tb_2.Name = "tb_2";
            this.tb_2.Size = new System.Drawing.Size(265, 51);
            this.tb_2.TabIndex = 9;
            // 
            // tb_1
            // 
            this.tb_1.Cue = "Фамилия";
            this.tb_1.Font = new System.Drawing.Font("Open Sans Semibold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_1.ForeColor = System.Drawing.Color.DimGray;
            this.tb_1.Location = new System.Drawing.Point(188, 88);
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(265, 51);
            this.tb_1.TabIndex = 8;
            // 
            // singIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DBSchool.Properties.Resources.фон_640_4801;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.PhoneNumber_tb);
            this.Controls.Add(this.Bithday_dtp);
            this.Controls.Add(this.Sex_cb);
            this.Controls.Add(this.tb_3);
            this.Controls.Add(this.tb_2);
            this.Controls.Add(this.tb_1);
            this.Controls.Add(this.stage_l);
            this.Controls.Add(this.back_l);
            this.Controls.Add(this.NextStep_b);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "singIn";
            this.Text = "Регистрация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private customTextBox tb_1;
        private customTextBox tb_2;
        private customTextBox tb_3;
        private System.Windows.Forms.Button NextStep_b;
        private System.Windows.Forms.Label back_l;
        private System.Windows.Forms.Label stage_l;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox Sex_cb;
        private System.Windows.Forms.DateTimePicker Bithday_dtp;
        private System.Windows.Forms.MaskedTextBox PhoneNumber_tb;
    }
}