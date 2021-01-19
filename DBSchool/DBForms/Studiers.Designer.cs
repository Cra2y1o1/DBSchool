namespace DBSchool.DBForms
{
    partial class Studiers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Studiers));
            this.dBSchoolDataSet = new DBSchool.DBSchoolDataSet();
            this.getPeopleByClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getPeopleByClassTableAdapter = new DBSchool.DBSchoolDataSetTableAdapters.getPeopleByClassTableAdapter();
            this.tableAdapterManager = new DBSchool.DBSchoolDataSetTableAdapters.TableAdapterManager();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.nazvToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.ClassName_tb = new System.Windows.Forms.ToolStripTextBox();
            this.familToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.LastName_tb = new System.Windows.Forms.ToolStripTextBox();
            this.search_b = new System.Windows.Forms.ToolStripButton();
            this.getPeopleByClassDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dBSchoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPeopleByClassBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getPeopleByClassDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dBSchoolDataSet
            // 
            this.dBSchoolDataSet.DataSetName = "DBSchoolDataSet";
            this.dBSchoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getPeopleByClassBindingSource
            // 
            this.getPeopleByClassBindingSource.DataMember = "getPeopleByClass";
            this.getPeopleByClassBindingSource.DataSource = this.dBSchoolDataSet;
            // 
            // getPeopleByClassTableAdapter
            // 
            this.getPeopleByClassTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.LogInTableAdapter = null;
            this.tableAdapterManager.PersonTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DBSchool.DBSchoolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДниTableAdapter = null;
            this.tableAdapterManager.ЖурналTableAdapter = null;
            this.tableAdapterManager.КабинетыTableAdapter = null;
            this.tableAdapterManager.Классные_рук_лиTableAdapter = null;
            this.tableAdapterManager.КлассыTableAdapter = null;
            this.tableAdapterManager.ПредметыTableAdapter = null;
            this.tableAdapterManager.РасписаниеTableAdapter = null;
            this.tableAdapterManager.РодителиTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            this.tableAdapterManager.УчащийсяTableAdapter = null;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nazvToolStripLabel,
            this.ClassName_tb,
            this.familToolStripLabel,
            this.LastName_tb,
            this.search_b});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.fillToolStrip.Size = new System.Drawing.Size(525, 25);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // nazvToolStripLabel
            // 
            this.nazvToolStripLabel.Name = "nazvToolStripLabel";
            this.nazvToolStripLabel.Size = new System.Drawing.Size(42, 22);
            this.nazvToolStripLabel.Text = "Класс:";
            // 
            // ClassName_tb
            // 
            this.ClassName_tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClassName_tb.Name = "nazvToolStripTextBox";
            this.ClassName_tb.Size = new System.Drawing.Size(100, 25);
            // 
            // familToolStripLabel
            // 
            this.familToolStripLabel.Name = "familToolStripLabel";
            this.familToolStripLabel.Size = new System.Drawing.Size(61, 22);
            this.familToolStripLabel.Text = "Фамилия:";
            // 
            // LastName_tb
            // 
            this.LastName_tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LastName_tb.Name = "familToolStripTextBox";
            this.LastName_tb.Size = new System.Drawing.Size(100, 25);
            // 
            // search_b
            // 
            this.search_b.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.search_b.Name = "fillToolStripButton";
            this.search_b.Size = new System.Drawing.Size(46, 22);
            this.search_b.Text = "Поиск";
            this.search_b.Click += new System.EventHandler(this.fillToolStripButton_Click_3);
            // 
            // getPeopleByClassDataGridView
            // 
            this.getPeopleByClassDataGridView.AllowUserToAddRows = false;
            this.getPeopleByClassDataGridView.AllowUserToDeleteRows = false;
            this.getPeopleByClassDataGridView.AutoGenerateColumns = false;
            this.getPeopleByClassDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getPeopleByClassDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.getPeopleByClassDataGridView.DataSource = this.getPeopleByClassBindingSource;
            this.getPeopleByClassDataGridView.Location = new System.Drawing.Point(0, 28);
            this.getPeopleByClassDataGridView.Name = "getPeopleByClassDataGridView";
            this.getPeopleByClassDataGridView.ReadOnly = true;
            this.getPeopleByClassDataGridView.Size = new System.Drawing.Size(513, 249);
            this.getPeopleByClassDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn3.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Отчество";
            this.dataGridViewTextBoxColumn4.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Класс";
            this.dataGridViewTextBoxColumn5.HeaderText = "Класс";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Studiers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DBSchool.Properties.Resources.фон1;
            this.ClientSize = new System.Drawing.Size(525, 289);
            this.Controls.Add(this.getPeopleByClassDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Studiers";
            this.Text = "Учащиеся";
            ((System.ComponentModel.ISupportInitialize)(this.dBSchoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPeopleByClassBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getPeopleByClassDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBSchoolDataSet dBSchoolDataSet;
        private System.Windows.Forms.BindingSource getPeopleByClassBindingSource;
        private DBSchoolDataSetTableAdapters.getPeopleByClassTableAdapter getPeopleByClassTableAdapter;
        private DBSchoolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel nazvToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox ClassName_tb;
        private System.Windows.Forms.ToolStripLabel familToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox LastName_tb;
        private System.Windows.Forms.ToolStripButton search_b;
        private System.Windows.Forms.DataGridView getPeopleByClassDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}