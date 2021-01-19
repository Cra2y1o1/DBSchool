
namespace DBSchool.DBForms
{
    partial class SetUpChild
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
            this.name_tb = new customTextBox();
            this.year_tb = new customTextBox();
            this.sumbit = new System.Windows.Forms.Button();
            this.fio_tb = new customTextBox();
            this.SuspendLayout();
            // 
            // name_tb
            // 
            this.name_tb.Cue = "Буква";
            this.name_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_tb.Location = new System.Drawing.Point(130, 41);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(120, 23);
            this.name_tb.TabIndex = 13;
            // 
            // year_tb
            // 
            this.year_tb.Cue = "Класс";
            this.year_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year_tb.Location = new System.Drawing.Point(3, 41);
            this.year_tb.Name = "year_tb";
            this.year_tb.Size = new System.Drawing.Size(121, 23);
            this.year_tb.TabIndex = 12;
            // 
            // sumbit
            // 
            this.sumbit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumbit.Location = new System.Drawing.Point(3, 70);
            this.sumbit.Name = "sumbit";
            this.sumbit.Size = new System.Drawing.Size(247, 32);
            this.sumbit.TabIndex = 11;
            this.sumbit.Text = "Составить заявление";
            this.sumbit.UseVisualStyleBackColor = true;
            this.sumbit.Click += new System.EventHandler(this.sumbit_Click);
            // 
            // fio_tb
            // 
            this.fio_tb.Cue = "ФИО ребенка";
            this.fio_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio_tb.Location = new System.Drawing.Point(3, 12);
            this.fio_tb.Name = "fio_tb";
            this.fio_tb.Size = new System.Drawing.Size(247, 23);
            this.fio_tb.TabIndex = 10;
            // 
            // SetUpChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 115);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.year_tb);
            this.Controls.Add(this.sumbit);
            this.Controls.Add(this.fio_tb);
            this.Name = "SetUpChild";
            this.Text = "Привязка ребенка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private customTextBox name_tb;
        private customTextBox year_tb;
        private System.Windows.Forms.Button sumbit;
        private customTextBox fio_tb;
    }
}