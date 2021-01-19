namespace DBSchool
{
    partial class Parents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parents));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.getParetsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getParetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBSchoolDataSet = new DBSchool.DBSchoolDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.familToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.familToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.getPeopleByFamilDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getPeopleByFamilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getParetsTableAdapter = new DBSchool.DBSchoolDataSetTableAdapters.getParetsTableAdapter();
            this.tableAdapterManager = new DBSchool.DBSchoolDataSetTableAdapters.TableAdapterManager();
            this.getPeopleByFamilTableAdapter = new DBSchool.DBSchoolDataSetTableAdapters.getPeopleByFamilTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.unite_b = new System.Windows.Forms.Button();
            this.idPeople_tb = new customTextBox();
            this.idParent_tb = new customTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.divide_b = new System.Windows.Forms.Button();
            this.idParetn_del_tb = new customTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getParetsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getParetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSchoolDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getPeopleByFamilDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPeopleByFamilBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.getParetsDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 248);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация: Родитель - Ученик";
            // 
            // getParetsDataGridView
            // 
            this.getParetsDataGridView.AllowUserToAddRows = false;
            this.getParetsDataGridView.AllowUserToDeleteRows = false;
            this.getParetsDataGridView.AutoGenerateColumns = false;
            this.getParetsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getParetsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.getParetsDataGridView.DataSource = this.getParetsBindingSource;
            this.getParetsDataGridView.Location = new System.Drawing.Point(6, 19);
            this.getParetsDataGridView.Name = "getParetsDataGridView";
            this.getParetsDataGridView.ReadOnly = true;
            this.getParetsDataGridView.Size = new System.Drawing.Size(765, 220);
            this.getParetsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn2.HeaderText = "id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn3.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn4.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Отчество";
            this.dataGridViewTextBoxColumn6.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Имя ребенка";
            this.dataGridViewTextBoxColumn7.HeaderText = "Имя ребенка";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Фамилия ребенка";
            this.dataGridViewTextBoxColumn8.HeaderText = "Фамилия ребенка";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Отчество ребенка";
            this.dataGridViewTextBoxColumn9.HeaderText = "Отчество ребенка";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // getParetsBindingSource
            // 
            this.getParetsBindingSource.DataMember = "getParets";
            this.getParetsBindingSource.DataSource = this.dBSchoolDataSet;
            // 
            // dBSchoolDataSet
            // 
            this.dBSchoolDataSet.DataSetName = "DBSchoolDataSet";
            this.dBSchoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.fillToolStrip);
            this.groupBox2.Controls.Add(this.getPeopleByFamilDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(18, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(581, 249);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "поиск учеников по фамилии";
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.familToolStripLabel,
            this.familToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(12, 22);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(221, 25);
            this.fillToolStrip.TabIndex = 5;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // familToolStripLabel
            // 
            this.familToolStripLabel.Name = "familToolStripLabel";
            this.familToolStripLabel.Size = new System.Drawing.Size(61, 22);
            this.familToolStripLabel.Text = "Фамилия:";
            // 
            // familToolStripTextBox
            // 
            this.familToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.familToolStripTextBox.Name = "familToolStripTextBox";
            this.familToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.fillToolStripButton.Text = "Поиск";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click_1);
            // 
            // getPeopleByFamilDataGridView
            // 
            this.getPeopleByFamilDataGridView.AllowUserToAddRows = false;
            this.getPeopleByFamilDataGridView.AllowUserToDeleteRows = false;
            this.getPeopleByFamilDataGridView.AutoGenerateColumns = false;
            this.getPeopleByFamilDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getPeopleByFamilDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.getPeopleByFamilDataGridView.DataSource = this.getPeopleByFamilBindingSource;
            this.getPeopleByFamilDataGridView.Location = new System.Drawing.Point(6, 64);
            this.getPeopleByFamilDataGridView.Name = "getPeopleByFamilDataGridView";
            this.getPeopleByFamilDataGridView.ReadOnly = true;
            this.getPeopleByFamilDataGridView.Size = new System.Drawing.Size(559, 179);
            this.getPeopleByFamilDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn10.HeaderText = "id";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn11.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn12.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Отчество";
            this.dataGridViewTextBoxColumn13.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Класс";
            this.dataGridViewTextBoxColumn14.HeaderText = "Класс";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // getPeopleByFamilBindingSource
            // 
            this.getPeopleByFamilBindingSource.DataMember = "getPeopleByFamil";
            this.getPeopleByFamilBindingSource.DataSource = this.dBSchoolDataSet;
            // 
            // getParetsTableAdapter
            // 
            this.getParetsTableAdapter.ClearBeforeFill = true;
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
            // getPeopleByFamilTableAdapter
            // 
            this.getPeopleByFamilTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.unite_b);
            this.groupBox3.Controls.Add(this.idPeople_tb);
            this.groupBox3.Controls.Add(this.idParent_tb);
            this.groupBox3.Location = new System.Drawing.Point(615, 266);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(182, 134);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Добавление";
            // 
            // unite_b
            // 
            this.unite_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unite_b.Location = new System.Drawing.Point(6, 97);
            this.unite_b.Name = "unite_b";
            this.unite_b.Size = new System.Drawing.Size(162, 27);
            this.unite_b.TabIndex = 10;
            this.unite_b.Text = "Связать";
            this.unite_b.UseVisualStyleBackColor = true;
            this.unite_b.Click += new System.EventHandler(this.unite_b_Click);
            // 
            // idPeople_tb
            // 
            this.idPeople_tb.Cue = "id ученика";
            this.idPeople_tb.Font = new System.Drawing.Font("Open Sans Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idPeople_tb.ForeColor = System.Drawing.Color.DimGray;
            this.idPeople_tb.Location = new System.Drawing.Point(6, 58);
            this.idPeople_tb.Name = "idPeople_tb";
            this.idPeople_tb.Size = new System.Drawing.Size(162, 33);
            this.idPeople_tb.TabIndex = 9;
            // 
            // idParent_tb
            // 
            this.idParent_tb.Cue = "id Родителя";
            this.idParent_tb.Font = new System.Drawing.Font("Open Sans Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idParent_tb.ForeColor = System.Drawing.Color.DimGray;
            this.idParent_tb.Location = new System.Drawing.Point(6, 19);
            this.idParent_tb.Name = "idParent_tb";
            this.idParent_tb.Size = new System.Drawing.Size(162, 33);
            this.idParent_tb.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.divide_b);
            this.groupBox4.Controls.Add(this.idParetn_del_tb);
            this.groupBox4.Location = new System.Drawing.Point(615, 406);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(182, 109);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Удаление";
            // 
            // divide_b
            // 
            this.divide_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divide_b.Location = new System.Drawing.Point(6, 58);
            this.divide_b.Name = "divide_b";
            this.divide_b.Size = new System.Drawing.Size(162, 45);
            this.divide_b.TabIndex = 11;
            this.divide_b.Text = "Отвязать ребенка";
            this.divide_b.UseVisualStyleBackColor = true;
            this.divide_b.Click += new System.EventHandler(this.divide_b_Click);
            // 
            // idParetn_del_tb
            // 
            this.idParetn_del_tb.Cue = "id Родителя";
            this.idParetn_del_tb.Font = new System.Drawing.Font("Open Sans Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idParetn_del_tb.ForeColor = System.Drawing.Color.DimGray;
            this.idParetn_del_tb.Location = new System.Drawing.Point(6, 19);
            this.idParetn_del_tb.Name = "idParetn_del_tb";
            this.idParetn_del_tb.Size = new System.Drawing.Size(162, 33);
            this.idParetn_del_tb.TabIndex = 9;
            // 
            // Parents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DBSchool.Properties.Resources.фон;
            this.ClientSize = new System.Drawing.Size(808, 523);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Parents";
            this.Text = "Родители";
            this.Load += new System.EventHandler(this.Parents_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.getParetsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getParetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSchoolDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getPeopleByFamilDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPeopleByFamilBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DBSchoolDataSet dBSchoolDataSet;
        private System.Windows.Forms.BindingSource getParetsBindingSource;
        private DBSchoolDataSetTableAdapters.getParetsTableAdapter getParetsTableAdapter;
        private DBSchoolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView getParetsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.BindingSource getPeopleByFamilBindingSource;
        private DBSchoolDataSetTableAdapters.getPeopleByFamilTableAdapter getPeopleByFamilTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel familToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox familToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView getPeopleByFamilDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button unite_b;
        private customTextBox idPeople_tb;
        private customTextBox idParent_tb;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button divide_b;
        private customTextBox idParetn_del_tb;
    }
}