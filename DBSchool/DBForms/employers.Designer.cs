namespace DBSchool.DBForms
{
    partial class employers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employers));
            this.dBSchoolDataSet = new DBSchool.DBSchoolDataSet();
            this.getEmployersByPosFamilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getEmployersByPosFamilTableAdapter = new DBSchool.DBSchoolDataSetTableAdapters.getEmployersByPosFamilTableAdapter();
            this.tableAdapterManager = new DBSchool.DBSchoolDataSetTableAdapters.TableAdapterManager();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.posToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.Position_tb = new System.Windows.Forms.ToolStripTextBox();
            this.familToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.Familiya_tb = new System.Windows.Forms.ToolStripTextBox();
            this.Search_b = new System.Windows.Forms.ToolStripButton();
            this.getEmployersByPosFamilDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dBSchoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEmployersByPosFamilBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getEmployersByPosFamilDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dBSchoolDataSet
            // 
            this.dBSchoolDataSet.DataSetName = "DBSchoolDataSet";
            this.dBSchoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getEmployersByPosFamilBindingSource
            // 
            this.getEmployersByPosFamilBindingSource.DataMember = "getEmployersByPosFamil";
            this.getEmployersByPosFamilBindingSource.DataSource = this.dBSchoolDataSet;
            // 
            // getEmployersByPosFamilTableAdapter
            // 
            this.getEmployersByPosFamilTableAdapter.ClearBeforeFill = true;
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
            this.fillToolStrip.BackColor = System.Drawing.Color.Transparent;
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.posToolStripLabel,
            this.Position_tb,
            this.familToolStripLabel,
            this.Familiya_tb,
            this.Search_b});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(769, 25);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // posToolStripLabel
            // 
            this.posToolStripLabel.Name = "posToolStripLabel";
            this.posToolStripLabel.Size = new System.Drawing.Size(75, 22);
            this.posToolStripLabel.Text = "Должность: ";
            // 
            // Position_tb
            // 
            this.Position_tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Position_tb.Name = "Position_tb";
            this.Position_tb.Size = new System.Drawing.Size(100, 25);
            // 
            // familToolStripLabel
            // 
            this.familToolStripLabel.Name = "familToolStripLabel";
            this.familToolStripLabel.Size = new System.Drawing.Size(58, 22);
            this.familToolStripLabel.Text = "Фамилия";
            // 
            // Familiya_tb
            // 
            this.Familiya_tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Familiya_tb.Name = "Familiya_tb";
            this.Familiya_tb.Size = new System.Drawing.Size(100, 25);
            // 
            // Search_b
            // 
            this.Search_b.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Search_b.Name = "Search_b";
            this.Search_b.Size = new System.Drawing.Size(46, 22);
            this.Search_b.Text = "Поиск";
            this.Search_b.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // getEmployersByPosFamilDataGridView
            // 
            this.getEmployersByPosFamilDataGridView.AllowUserToAddRows = false;
            this.getEmployersByPosFamilDataGridView.AllowUserToDeleteRows = false;
            this.getEmployersByPosFamilDataGridView.AutoGenerateColumns = false;
            this.getEmployersByPosFamilDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getEmployersByPosFamilDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.getEmployersByPosFamilDataGridView.DataSource = this.getEmployersByPosFamilBindingSource;
            this.getEmployersByPosFamilDataGridView.Location = new System.Drawing.Point(0, 28);
            this.getEmployersByPosFamilDataGridView.Name = "getEmployersByPosFamilDataGridView";
            this.getEmployersByPosFamilDataGridView.ReadOnly = true;
            this.getEmployersByPosFamilDataGridView.Size = new System.Drawing.Size(747, 243);
            this.getEmployersByPosFamilDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn1.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn2.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Отчество";
            this.dataGridViewTextBoxColumn3.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "День рождения";
            this.dataGridViewTextBoxColumn4.HeaderText = "День рождения";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Мобильный";
            this.dataGridViewTextBoxColumn5.HeaderText = "Мобильный";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "E-mail";
            this.dataGridViewTextBoxColumn6.HeaderText = "E-mail";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Должность";
            this.dataGridViewTextBoxColumn7.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // employers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DBSchool.Properties.Resources.фон;
            this.ClientSize = new System.Drawing.Size(769, 286);
            this.Controls.Add(this.getEmployersByPosFamilDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "employers";
            this.Text = "Сотрудники";
            ((System.ComponentModel.ISupportInitialize)(this.dBSchoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEmployersByPosFamilBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getEmployersByPosFamilDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBSchoolDataSet dBSchoolDataSet;
        private System.Windows.Forms.BindingSource getEmployersByPosFamilBindingSource;
        private DBSchoolDataSetTableAdapters.getEmployersByPosFamilTableAdapter getEmployersByPosFamilTableAdapter;
        private DBSchoolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel posToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox Position_tb;
        private System.Windows.Forms.ToolStripLabel familToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox Familiya_tb;
        private System.Windows.Forms.ToolStripButton Search_b;
        private System.Windows.Forms.DataGridView getEmployersByPosFamilDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}