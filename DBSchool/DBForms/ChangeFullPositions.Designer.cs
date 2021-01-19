
namespace DBSchool.DBForms
{
    partial class ChangeFullPositions
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
            this.fullPosition = new customTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reason = new customTextBox();
            this.sumbit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fullPosition
            // 
            this.fullPosition.Cue = "Полная должность";
            this.fullPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullPosition.Location = new System.Drawing.Point(12, 12);
            this.fullPosition.Name = "fullPosition";
            this.fullPosition.Size = new System.Drawing.Size(250, 23);
            this.fullPosition.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "В связи с:";
            // 
            // reason
            // 
            this.reason.Cue = "Полная должность";
            this.reason.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reason.Location = new System.Drawing.Point(12, 60);
            this.reason.Multiline = true;
            this.reason.Name = "reason";
            this.reason.Size = new System.Drawing.Size(250, 68);
            this.reason.TabIndex = 2;
            // 
            // sumbit
            // 
            this.sumbit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumbit.Location = new System.Drawing.Point(15, 134);
            this.sumbit.Name = "sumbit";
            this.sumbit.Size = new System.Drawing.Size(247, 32);
            this.sumbit.TabIndex = 3;
            this.sumbit.Text = "Составить заявление";
            this.sumbit.UseVisualStyleBackColor = true;
            this.sumbit.Click += new System.EventHandler(this.sumbit_Click);
            // 
            // ChangeFullPositions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 185);
            this.Controls.Add(this.sumbit);
            this.Controls.Add(this.reason);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fullPosition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChangeFullPositions";
            this.Text = "Изменение привелегий";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private customTextBox fullPosition;
        private System.Windows.Forms.Label label1;
        private customTextBox reason;
        private System.Windows.Forms.Button sumbit;
    }
}