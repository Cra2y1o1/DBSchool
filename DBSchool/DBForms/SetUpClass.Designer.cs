
namespace DBSchool.DBForms
{
    partial class SetUpClass
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
            this.sumbit = new System.Windows.Forms.Button();
            this.year_tb = new customTextBox();
            this.name_tb = new customTextBox();
            this.SuspendLayout();
            // 
            // sumbit
            // 
            this.sumbit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumbit.Location = new System.Drawing.Point(8, 39);
            this.sumbit.Name = "sumbit";
            this.sumbit.Size = new System.Drawing.Size(247, 34);
            this.sumbit.TabIndex = 7;
            this.sumbit.Text = "Составить заявление";
            this.sumbit.UseVisualStyleBackColor = true;
            this.sumbit.Click += new System.EventHandler(this.sumbit_Click);
            // 
            // year_tb
            // 
            this.year_tb.Cue = "Класс";
            this.year_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year_tb.Location = new System.Drawing.Point(8, 12);
            this.year_tb.Name = "year_tb";
            this.year_tb.Size = new System.Drawing.Size(121, 23);
            this.year_tb.TabIndex = 8;
            // 
            // name_tb
            // 
            this.name_tb.Cue = "Буква";
            this.name_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_tb.Location = new System.Drawing.Point(135, 12);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(120, 23);
            this.name_tb.TabIndex = 9;
            // 
            // SetUpClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 80);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.year_tb);
            this.Controls.Add(this.sumbit);
            this.Name = "SetUpClass";
            this.Text = "Привязка к классу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sumbit;
        private customTextBox year_tb;
        private customTextBox name_tb;
    }
}