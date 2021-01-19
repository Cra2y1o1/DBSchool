namespace DBSchool.DBForms
{
    partial class marks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(marks));
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.familSTToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.lastName_st_tb = new System.Windows.Forms.ToolStripTextBox();
            this.nameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.NameObject_tb = new System.Windows.Forms.ToolStripTextBox();
            this.familTCToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.LastName_tc_tb = new System.Windows.Forms.ToolStripTextBox();
            this.idMarkToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.idMark_tb = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.getMarkDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getMarkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBSchoolDataSet = new DBSchool.DBSchoolDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mark = new customTextBox();
            this.idPeople = new customTextBox();
            this.getObjectsComboBox = new System.Windows.Forms.ComboBox();
            this.getObjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getMarkTableAdapter = new DBSchool.DBSchoolDataSetTableAdapters.getMarkTableAdapter();
            this.tableAdapterManager = new DBSchool.DBSchoolDataSetTableAdapters.TableAdapterManager();
            this.getObjectsTableAdapter = new DBSchool.DBSchoolDataSetTableAdapters.getObjectsTableAdapter();
            this.toChangeMark = new System.Windows.Forms.Button();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getMarkDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getMarkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSchoolDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getObjectsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.fillToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.familSTToolStripLabel,
            this.lastName_st_tb,
            this.nameToolStripLabel,
            this.NameObject_tb,
            this.familTCToolStripLabel,
            this.LastName_tc_tb,
            this.idMarkToolStripLabel,
            this.idMark_tb,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(3, 16);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.fillToolStrip.Size = new System.Drawing.Size(147, 193);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // familSTToolStripLabel
            // 
            this.familSTToolStripLabel.Name = "familSTToolStripLabel";
            this.familSTToolStripLabel.Size = new System.Drawing.Size(144, 15);
            this.familSTToolStripLabel.Text = "Фамилия ученика:";
            // 
            // lastName_st_tb
            // 
            this.lastName_st_tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lastName_st_tb.Name = "lastName_st_tb";
            this.lastName_st_tb.Size = new System.Drawing.Size(142, 23);
            // 
            // nameToolStripLabel
            // 
            this.nameToolStripLabel.Name = "nameToolStripLabel";
            this.nameToolStripLabel.Size = new System.Drawing.Size(144, 15);
            this.nameToolStripLabel.Text = "Название предмета:";
            // 
            // NameObject_tb
            // 
            this.NameObject_tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NameObject_tb.Name = "NameObject_tb";
            this.NameObject_tb.Size = new System.Drawing.Size(142, 23);
            // 
            // familTCToolStripLabel
            // 
            this.familTCToolStripLabel.Name = "familTCToolStripLabel";
            this.familTCToolStripLabel.Size = new System.Drawing.Size(144, 15);
            this.familTCToolStripLabel.Text = "Фамилия преподавателя:";
            // 
            // LastName_tc_tb
            // 
            this.LastName_tc_tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LastName_tc_tb.Name = "LastName_tc_tb";
            this.LastName_tc_tb.Size = new System.Drawing.Size(142, 23);
            // 
            // idMarkToolStripLabel
            // 
            this.idMarkToolStripLabel.Name = "idMarkToolStripLabel";
            this.idMarkToolStripLabel.Size = new System.Drawing.Size(144, 15);
            this.idMarkToolStripLabel.Text = "id оценки:";
            // 
            // idMark_tb
            // 
            this.idMark_tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.idMark_tb.Name = "idMark_tb";
            this.idMark_tb.Size = new System.Drawing.Size(142, 23);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(144, 19);
            this.fillToolStripButton.Text = "Поиск";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // getMarkDataGridView
            // 
            this.getMarkDataGridView.AllowUserToAddRows = false;
            this.getMarkDataGridView.AllowUserToDeleteRows = false;
            this.getMarkDataGridView.AutoGenerateColumns = false;
            this.getMarkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getMarkDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.getMarkDataGridView.DataSource = this.getMarkBindingSource;
            this.getMarkDataGridView.Location = new System.Drawing.Point(2, 0);
            this.getMarkDataGridView.Name = "getMarkDataGridView";
            this.getMarkDataGridView.ReadOnly = true;
            this.getMarkDataGridView.Size = new System.Drawing.Size(648, 423);
            this.getMarkDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код оценки";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код оценки";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "дата оценки";
            this.dataGridViewTextBoxColumn2.HeaderText = "дата оценки";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "название предмета";
            this.dataGridViewTextBoxColumn3.HeaderText = "название предмета";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Оценка";
            this.dataGridViewTextBoxColumn4.HeaderText = "Оценка";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Ученик";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ученик";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Преподаватель";
            this.dataGridViewTextBoxColumn6.HeaderText = "Преподаватель";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // getMarkBindingSource
            // 
            this.getMarkBindingSource.DataMember = "getMark";
            this.getMarkBindingSource.DataSource = this.dBSchoolDataSet;
            // 
            // dBSchoolDataSet
            // 
            this.dBSchoolDataSet.DataSetName = "DBSchoolDataSet";
            this.dBSchoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.fillToolStrip);
            this.groupBox1.Location = new System.Drawing.Point(656, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 212);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.mark);
            this.groupBox2.Controls.Add(this.idPeople);
            this.groupBox2.Controls.Add(this.getObjectsComboBox);
            this.groupBox2.Location = new System.Drawing.Point(659, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 149);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поставить оценку";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(13, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 25);
            this.button1.TabIndex = 10;
            this.button1.Text = "Выставить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mark
            // 
            this.mark.Cue = "Оценка";
            this.mark.Font = new System.Drawing.Font("Open Sans Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mark.ForeColor = System.Drawing.Color.DimGray;
            this.mark.Location = new System.Drawing.Point(13, 84);
            this.mark.Name = "mark";
            this.mark.Size = new System.Drawing.Size(128, 27);
            this.mark.TabIndex = 9;
            // 
            // idPeople
            // 
            this.idPeople.Cue = "id Ученика";
            this.idPeople.Font = new System.Drawing.Font("Open Sans Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idPeople.ForeColor = System.Drawing.Color.DimGray;
            this.idPeople.Location = new System.Drawing.Point(13, 51);
            this.idPeople.Name = "idPeople";
            this.idPeople.Size = new System.Drawing.Size(128, 27);
            this.idPeople.TabIndex = 8;
            // 
            // getObjectsComboBox
            // 
            this.getObjectsComboBox.DataSource = this.getObjectsBindingSource;
            this.getObjectsComboBox.DisplayMember = "название предмета";
            this.getObjectsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getObjectsComboBox.FormattingEnabled = true;
            this.getObjectsComboBox.Location = new System.Drawing.Point(13, 19);
            this.getObjectsComboBox.Name = "getObjectsComboBox";
            this.getObjectsComboBox.Size = new System.Drawing.Size(128, 26);
            this.getObjectsComboBox.TabIndex = 0;
            this.getObjectsComboBox.ValueMember = "название предмета";
            // 
            // getObjectsBindingSource
            // 
            this.getObjectsBindingSource.DataMember = "getObjects";
            this.getObjectsBindingSource.DataSource = this.dBSchoolDataSet;
            // 
            // getMarkTableAdapter
            // 
            this.getMarkTableAdapter.ClearBeforeFill = true;
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
            // getObjectsTableAdapter
            // 
            this.getObjectsTableAdapter.ClearBeforeFill = true;
            // 
            // toChangeMark
            // 
            this.toChangeMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toChangeMark.Location = new System.Drawing.Point(656, 373);
            this.toChangeMark.Name = "toChangeMark";
            this.toChangeMark.Size = new System.Drawing.Size(150, 50);
            this.toChangeMark.TabIndex = 5;
            this.toChangeMark.Text = "Запрос на изменение оценки";
            this.toChangeMark.UseVisualStyleBackColor = true;
            this.toChangeMark.Click += new System.EventHandler(this.toChangeMark_Click);
            // 
            // marks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DBSchool.Properties.Resources.фон_640_480;
            this.ClientSize = new System.Drawing.Size(816, 425);
            this.Controls.Add(this.toChangeMark);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.getMarkDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "marks";
            this.Text = "Успеваемость";
            this.Load += new System.EventHandler(this.marks_Load);
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getMarkDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getMarkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSchoolDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getObjectsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DBSchoolDataSet dBSchoolDataSet;
        private System.Windows.Forms.BindingSource getMarkBindingSource;
        private DBSchoolDataSetTableAdapters.getMarkTableAdapter getMarkTableAdapter;
        private DBSchoolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel familSTToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox lastName_st_tb;
        private System.Windows.Forms.ToolStripLabel nameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox NameObject_tb;
        private System.Windows.Forms.ToolStripLabel familTCToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox LastName_tc_tb;
        private System.Windows.Forms.ToolStripLabel idMarkToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox idMark_tb;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView getMarkDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource getObjectsBindingSource;
        private DBSchoolDataSetTableAdapters.getObjectsTableAdapter getObjectsTableAdapter;
        private System.Windows.Forms.ComboBox getObjectsComboBox;
        private System.Windows.Forms.Button button1;
        private customTextBox mark;
        private customTextBox idPeople;
        private System.Windows.Forms.Button toChangeMark;
    }
}