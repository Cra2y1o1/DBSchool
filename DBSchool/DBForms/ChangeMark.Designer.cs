
namespace DBSchool.DBForms
{
    partial class ChangeMark
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
            this.reason = new customTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IdMark = new customTextBox();
            this.newMark = new customTextBox();
            this.SuspendLayout();
            // 
            // sumbit
            // 
            this.sumbit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumbit.Location = new System.Drawing.Point(12, 134);
            this.sumbit.Name = "sumbit";
            this.sumbit.Size = new System.Drawing.Size(236, 32);
            this.sumbit.TabIndex = 7;
            this.sumbit.Text = "Составить заявление";
            this.sumbit.UseVisualStyleBackColor = true;
            this.sumbit.Click += new System.EventHandler(this.sumbit_Click);
            // 
            // reason
            // 
            this.reason.Cue = "Полная должность";
            this.reason.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reason.Location = new System.Drawing.Point(12, 60);
            this.reason.Multiline = true;
            this.reason.Name = "reason";
            this.reason.Size = new System.Drawing.Size(236, 68);
            this.reason.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "В связи с:";
            // 
            // IdMark
            // 
            this.IdMark.Cue = "Код оценки";
            this.IdMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdMark.Location = new System.Drawing.Point(12, 12);
            this.IdMark.Name = "IdMark";
            this.IdMark.Size = new System.Drawing.Size(103, 23);
            this.IdMark.TabIndex = 4;
            // 
            // newMark
            // 
            this.newMark.Cue = "Новая оценка";
            this.newMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newMark.Location = new System.Drawing.Point(145, 12);
            this.newMark.Name = "newMark";
            this.newMark.Size = new System.Drawing.Size(103, 23);
            this.newMark.TabIndex = 8;
            // 
            // ChangeMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 180);
            this.Controls.Add(this.newMark);
            this.Controls.Add(this.sumbit);
            this.Controls.Add(this.reason);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdMark);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChangeMark";
            this.Text = "ChangeMark";
            this.Load += new System.EventHandler(this.ChangeMark_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sumbit;
        private customTextBox reason;
        private System.Windows.Forms.Label label1;
        private customTextBox IdMark;
        private customTextBox newMark;
    }
}