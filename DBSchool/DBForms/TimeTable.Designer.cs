
namespace DBSchool.DBForms
{
    partial class TimeTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeTable));
            this.dBSchoolDataSet = new DBSchool.DBSchoolDataSet();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.dayToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.day_tb = new System.Windows.Forms.ToolStripTextBox();
            this._classToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.class_tb = new System.Windows.Forms.ToolStripTextBox();
            this._objectToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.object_tb = new System.Windows.Forms.ToolStripTextBox();
            this.cabinetToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.cabinet_tb = new System.Windows.Forms.ToolStripTextBox();
            this.teacherToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.teacher_tb = new System.Windows.Forms.ToolStripTextBox();
            this.search_b = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.getDaysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getDaysTableAdapter = new DBSchool.DBSchoolDataSetTableAdapters.getDaysTableAdapter();
            this.getClassesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getClassesTableAdapter = new DBSchool.DBSchoolDataSetTableAdapters.getClassesTableAdapter();
            this.getDaysBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.getDaysBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.getDaysComboBox = new System.Windows.Forms.ComboBox();
            this.getClassesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.getClassesComboBox = new System.Windows.Forms.ComboBox();
            this.getObjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getObjectsTableAdapter = new DBSchool.DBSchoolDataSetTableAdapters.getObjectsTableAdapter();
            this.getObjectsComboBox = new System.Windows.Forms.ComboBox();
            this.getCabinetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getCabinetTableAdapter = new DBSchool.DBSchoolDataSetTableAdapters.getCabinetTableAdapter();
            this.getCabinetComboBox = new System.Windows.Forms.ComboBox();
            this.getTeacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getTeacherTableAdapter = new DBSchool.DBSchoolDataSetTableAdapters.getTeacherTableAdapter();
            this.getTeacherComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.id_ctb = new customTextBox();
            this.add_tt_b = new System.Windows.Forms.Button();
            this.getTimeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getTimeTableTableAdapter = new DBSchool.DBSchoolDataSetTableAdapters.getTimeTableTableAdapter();
            this.tableAdapterManager = new DBSchool.DBSchoolDataSetTableAdapters.TableAdapterManager();
            this.getTimeTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.delete = new System.Windows.Forms.Button();
            this.idForDelete_ctb = new customTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dBSchoolDataSet)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getDaysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClassesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDaysBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDaysBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClassesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getObjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCabinetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getTeacherBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getTimeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getTimeTableDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dBSchoolDataSet
            // 
            this.dBSchoolDataSet.DataSetName = "DBSchoolDataSet";
            this.dBSchoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.fillToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dayToolStripLabel,
            this.day_tb,
            this._classToolStripLabel,
            this.class_tb,
            this._objectToolStripLabel,
            this.object_tb,
            this.cabinetToolStripLabel,
            this.cabinet_tb,
            this.teacherToolStripLabel,
            this.teacher_tb,
            this.search_b});
            this.fillToolStrip.Location = new System.Drawing.Point(3, 16);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.fillToolStrip.Size = new System.Drawing.Size(77, 233);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // dayToolStripLabel
            // 
            this.dayToolStripLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dayToolStripLabel.Name = "dayToolStripLabel";
            this.dayToolStripLabel.Size = new System.Drawing.Size(74, 15);
            this.dayToolStripLabel.Text = "День";
            this.dayToolStripLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // day_tb
            // 
            this.day_tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.day_tb.Name = "day_tb";
            this.day_tb.Size = new System.Drawing.Size(72, 23);
            // 
            // _classToolStripLabel
            // 
            this._classToolStripLabel.Name = "_classToolStripLabel";
            this._classToolStripLabel.Size = new System.Drawing.Size(74, 15);
            this._classToolStripLabel.Text = "Класс";
            // 
            // class_tb
            // 
            this.class_tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.class_tb.Name = "class_tb";
            this.class_tb.Size = new System.Drawing.Size(72, 23);
            // 
            // _objectToolStripLabel
            // 
            this._objectToolStripLabel.Name = "_objectToolStripLabel";
            this._objectToolStripLabel.Size = new System.Drawing.Size(74, 15);
            this._objectToolStripLabel.Text = "Предмет";
            // 
            // object_tb
            // 
            this.object_tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.object_tb.Name = "object_tb";
            this.object_tb.Size = new System.Drawing.Size(72, 23);
            // 
            // cabinetToolStripLabel
            // 
            this.cabinetToolStripLabel.Name = "cabinetToolStripLabel";
            this.cabinetToolStripLabel.Size = new System.Drawing.Size(74, 15);
            this.cabinetToolStripLabel.Text = "Кабинет";
            // 
            // cabinet_tb
            // 
            this.cabinet_tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cabinet_tb.Name = "cabinet_tb";
            this.cabinet_tb.Size = new System.Drawing.Size(72, 23);
            // 
            // teacherToolStripLabel
            // 
            this.teacherToolStripLabel.Name = "teacherToolStripLabel";
            this.teacherToolStripLabel.Size = new System.Drawing.Size(74, 15);
            this.teacherToolStripLabel.Text = "Учитель";
            // 
            // teacher_tb
            // 
            this.teacher_tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.teacher_tb.Name = "teacher_tb";
            this.teacher_tb.Size = new System.Drawing.Size(72, 23);
            // 
            // search_b
            // 
            this.search_b.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.search_b.Name = "search_b";
            this.search_b.Size = new System.Drawing.Size(46, 19);
            this.search_b.Text = "Поиск";
            this.search_b.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.fillToolStrip);
            this.groupBox1.Location = new System.Drawing.Point(556, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 252);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // getDaysBindingSource
            // 
            this.getDaysBindingSource.DataSource = this.dBSchoolDataSet;
            this.getDaysBindingSource.Position = 0;
            // 
            // getDaysTableAdapter
            // 
            this.getDaysTableAdapter.ClearBeforeFill = true;
            // 
            // getClassesBindingSource
            // 
            this.getClassesBindingSource.DataMember = "getClasses";
            this.getClassesBindingSource.DataSource = this.dBSchoolDataSet;
            // 
            // getClassesTableAdapter
            // 
            this.getClassesTableAdapter.ClearBeforeFill = true;
            // 
            // getDaysBindingSource1
            // 
            this.getDaysBindingSource1.DataMember = "getDays";
            this.getDaysBindingSource1.DataSource = this.dBSchoolDataSet;
            // 
            // getDaysBindingSource2
            // 
            this.getDaysBindingSource2.DataMember = "getDays";
            this.getDaysBindingSource2.DataSource = this.dBSchoolDataSet;
            // 
            // getDaysComboBox
            // 
            this.getDaysComboBox.DataSource = this.getDaysBindingSource2;
            this.getDaysComboBox.DisplayMember = "название";
            this.getDaysComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.getDaysComboBox.FormattingEnabled = true;
            this.getDaysComboBox.Location = new System.Drawing.Point(6, 49);
            this.getDaysComboBox.Name = "getDaysComboBox";
            this.getDaysComboBox.Size = new System.Drawing.Size(100, 26);
            this.getDaysComboBox.TabIndex = 3;
            this.getDaysComboBox.ValueMember = "название";
            // 
            // getClassesBindingSource1
            // 
            this.getClassesBindingSource1.DataMember = "getClasses";
            this.getClassesBindingSource1.DataSource = this.dBSchoolDataSet;
            // 
            // getClassesComboBox
            // 
            this.getClassesComboBox.DataSource = this.getClassesBindingSource1;
            this.getClassesComboBox.DisplayMember = "Название";
            this.getClassesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.getClassesComboBox.FormattingEnabled = true;
            this.getClassesComboBox.Location = new System.Drawing.Point(6, 81);
            this.getClassesComboBox.Name = "getClassesComboBox";
            this.getClassesComboBox.Size = new System.Drawing.Size(100, 26);
            this.getClassesComboBox.TabIndex = 3;
            this.getClassesComboBox.ValueMember = "Название";
            // 
            // getObjectsBindingSource
            // 
            this.getObjectsBindingSource.DataMember = "getObjects";
            this.getObjectsBindingSource.DataSource = this.dBSchoolDataSet;
            // 
            // getObjectsTableAdapter
            // 
            this.getObjectsTableAdapter.ClearBeforeFill = true;
            // 
            // getObjectsComboBox
            // 
            this.getObjectsComboBox.DataSource = this.getObjectsBindingSource;
            this.getObjectsComboBox.DisplayMember = "название предмета";
            this.getObjectsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.getObjectsComboBox.FormattingEnabled = true;
            this.getObjectsComboBox.Location = new System.Drawing.Point(6, 113);
            this.getObjectsComboBox.Name = "getObjectsComboBox";
            this.getObjectsComboBox.Size = new System.Drawing.Size(100, 26);
            this.getObjectsComboBox.TabIndex = 4;
            this.getObjectsComboBox.ValueMember = "название предмета";
            // 
            // getCabinetBindingSource
            // 
            this.getCabinetBindingSource.DataMember = "getCabinet";
            this.getCabinetBindingSource.DataSource = this.dBSchoolDataSet;
            // 
            // getCabinetTableAdapter
            // 
            this.getCabinetTableAdapter.ClearBeforeFill = true;
            // 
            // getCabinetComboBox
            // 
            this.getCabinetComboBox.DataSource = this.getCabinetBindingSource;
            this.getCabinetComboBox.DisplayMember = "Номер";
            this.getCabinetComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.getCabinetComboBox.FormattingEnabled = true;
            this.getCabinetComboBox.Location = new System.Drawing.Point(6, 145);
            this.getCabinetComboBox.Name = "getCabinetComboBox";
            this.getCabinetComboBox.Size = new System.Drawing.Size(100, 26);
            this.getCabinetComboBox.TabIndex = 5;
            this.getCabinetComboBox.ValueMember = "Номер";
            // 
            // getTeacherBindingSource
            // 
            this.getTeacherBindingSource.DataMember = "getTeacher";
            this.getTeacherBindingSource.DataSource = this.dBSchoolDataSet;
            // 
            // getTeacherTableAdapter
            // 
            this.getTeacherTableAdapter.ClearBeforeFill = true;
            // 
            // getTeacherComboBox
            // 
            this.getTeacherComboBox.DataSource = this.getTeacherBindingSource;
            this.getTeacherComboBox.DisplayMember = "Фамилия";
            this.getTeacherComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.getTeacherComboBox.FormattingEnabled = true;
            this.getTeacherComboBox.Location = new System.Drawing.Point(6, 177);
            this.getTeacherComboBox.Name = "getTeacherComboBox";
            this.getTeacherComboBox.Size = new System.Drawing.Size(100, 26);
            this.getTeacherComboBox.TabIndex = 6;
            this.getTeacherComboBox.ValueMember = "Фамилия";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.id_ctb);
            this.groupBox2.Controls.Add(this.add_tt_b);
            this.groupBox2.Controls.Add(this.getDaysComboBox);
            this.groupBox2.Controls.Add(this.getTeacherComboBox);
            this.groupBox2.Controls.Add(this.getClassesComboBox);
            this.groupBox2.Controls.Add(this.getCabinetComboBox);
            this.groupBox2.Controls.Add(this.getObjectsComboBox);
            this.groupBox2.Location = new System.Drawing.Point(682, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 253);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавить день";
            // 
            // id_ctb
            // 
            this.id_ctb.Cue = "Id";
            this.id_ctb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_ctb.Location = new System.Drawing.Point(6, 19);
            this.id_ctb.Name = "id_ctb";
            this.id_ctb.Size = new System.Drawing.Size(100, 24);
            this.id_ctb.TabIndex = 8;
            this.id_ctb.TextChanged += new System.EventHandler(this.id_ctb_TextChanged);
            // 
            // add_tt_b
            // 
            this.add_tt_b.Location = new System.Drawing.Point(6, 212);
            this.add_tt_b.Name = "add_tt_b";
            this.add_tt_b.Size = new System.Drawing.Size(100, 23);
            this.add_tt_b.TabIndex = 7;
            this.add_tt_b.Text = "Добавить";
            this.add_tt_b.UseVisualStyleBackColor = true;
            this.add_tt_b.Click += new System.EventHandler(this.add_tt_b_Click);
            // 
            // getTimeTableBindingSource
            // 
            this.getTimeTableBindingSource.DataMember = "getTimeTable";
            this.getTimeTableBindingSource.DataSource = this.dBSchoolDataSet;
            // 
            // getTimeTableTableAdapter
            // 
            this.getTimeTableTableAdapter.ClearBeforeFill = true;
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
            // getTimeTableDataGridView
            // 
            this.getTimeTableDataGridView.AllowUserToAddRows = false;
            this.getTimeTableDataGridView.AllowUserToDeleteRows = false;
            this.getTimeTableDataGridView.AutoGenerateColumns = false;
            this.getTimeTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getTimeTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.getTimeTableDataGridView.DataSource = this.getTimeTableBindingSource;
            this.getTimeTableDataGridView.Location = new System.Drawing.Point(1, 0);
            this.getTimeTableDataGridView.Name = "getTimeTableDataGridView";
            this.getTimeTableDataGridView.ReadOnly = true;
            this.getTimeTableDataGridView.Size = new System.Drawing.Size(549, 318);
            this.getTimeTableDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код расписания";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код расписания";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "День";
            this.dataGridViewTextBoxColumn2.HeaderText = "День";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Класс";
            this.dataGridViewTextBoxColumn3.HeaderText = "Класс";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Предмет";
            this.dataGridViewTextBoxColumn4.HeaderText = "Предмет";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Кабинет";
            this.dataGridViewTextBoxColumn5.HeaderText = "Кабинет";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Учитель";
            this.dataGridViewTextBoxColumn6.HeaderText = "Учитель";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.delete);
            this.groupBox3.Controls.Add(this.idForDelete_ctb);
            this.groupBox3.Location = new System.Drawing.Point(559, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 59);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Удаление";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(129, 20);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(100, 23);
            this.delete.TabIndex = 9;
            this.delete.Text = "Удаление";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // idForDelete_ctb
            // 
            this.idForDelete_ctb.Cue = "Id";
            this.idForDelete_ctb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idForDelete_ctb.Location = new System.Drawing.Point(6, 19);
            this.idForDelete_ctb.Name = "idForDelete_ctb";
            this.idForDelete_ctb.Size = new System.Drawing.Size(100, 24);
            this.idForDelete_ctb.TabIndex = 9;
            // 
            // TimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DBSchool.Properties.Resources.фон_640_480;
            this.ClientSize = new System.Drawing.Size(813, 328);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.getTimeTableDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimeTable";
            this.Text = "Расписание";
            this.Load += new System.EventHandler(this.TimeTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBSchoolDataSet)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getDaysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClassesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDaysBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDaysBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClassesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getObjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCabinetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getTeacherBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getTimeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getTimeTableDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DBSchoolDataSet dBSchoolDataSet;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel dayToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox day_tb;
        private System.Windows.Forms.ToolStripLabel _classToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox class_tb;
        private System.Windows.Forms.ToolStripLabel _objectToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox object_tb;
        private System.Windows.Forms.ToolStripLabel cabinetToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox cabinet_tb;
        private System.Windows.Forms.ToolStripLabel teacherToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox teacher_tb;
        private System.Windows.Forms.ToolStripButton search_b;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource getDaysBindingSource;
        private DBSchoolDataSetTableAdapters.getDaysTableAdapter getDaysTableAdapter;
        private System.Windows.Forms.BindingSource getClassesBindingSource;
        private DBSchoolDataSetTableAdapters.getClassesTableAdapter getClassesTableAdapter;
        private System.Windows.Forms.BindingSource getDaysBindingSource1;
        private System.Windows.Forms.BindingSource getDaysBindingSource2;
        private System.Windows.Forms.ComboBox getDaysComboBox;
        private System.Windows.Forms.BindingSource getClassesBindingSource1;
        private System.Windows.Forms.ComboBox getClassesComboBox;
        private System.Windows.Forms.BindingSource getObjectsBindingSource;
        private DBSchoolDataSetTableAdapters.getObjectsTableAdapter getObjectsTableAdapter;
        private System.Windows.Forms.ComboBox getObjectsComboBox;
        private System.Windows.Forms.BindingSource getCabinetBindingSource;
        private DBSchoolDataSetTableAdapters.getCabinetTableAdapter getCabinetTableAdapter;
        private System.Windows.Forms.ComboBox getCabinetComboBox;
        private System.Windows.Forms.BindingSource getTeacherBindingSource;
        private DBSchoolDataSetTableAdapters.getTeacherTableAdapter getTeacherTableAdapter;
        private System.Windows.Forms.ComboBox getTeacherComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button add_tt_b;
        private customTextBox id_ctb;
        private System.Windows.Forms.BindingSource getTimeTableBindingSource;
        private DBSchoolDataSetTableAdapters.getTimeTableTableAdapter getTimeTableTableAdapter;
        private DBSchoolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView getTimeTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button delete;
        private customTextBox idForDelete_ctb;
    }
}