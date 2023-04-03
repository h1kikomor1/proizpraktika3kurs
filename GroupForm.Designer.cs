
namespace WindowsFormsApp1
{
    partial class GroupForm
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
            this.form_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.иДпосетителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерТелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.данныеПаспортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.логинDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.парольDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.назначениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.группаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иДтиппосDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Button = new System.Windows.Forms.DataGridViewButtonColumn();
            this.СтатусЗаявки = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.типЗаявкиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDataSet4 = new WindowsFormsApp1.employeeDataSet4();
            this.ИД_тип_заяв = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ИД_тип_ЧС = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.посетителиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDataSet5 = new WindowsFormsApp1.employeeDataSet5();
            this.посетителиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDataSet1 = new WindowsFormsApp1.employeeDataSet1();
            this.employeeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDataSet = new WindowsFormsApp1.employeeDataSet();
            this.посетителиTableAdapter = new WindowsFormsApp1.employeeDataSet1TableAdapters.ПосетителиTableAdapter();
            this.employeeDataSet2 = new WindowsFormsApp1.employeeDataSet2();
            this.типПосещенийBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.типПосещенийTableAdapter = new WindowsFormsApp1.employeeDataSet2TableAdapters.ТипПосещенийTableAdapter();
            this.типПосещенийTableAdapter1 = new WindowsFormsApp1.employeeDataSet2TableAdapters.ТипПосещенийTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.employeeDataSet3 = new WindowsFormsApp1.employeeDataSet3();
            this.типЗаявкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.типЗаявкиTableAdapter = new WindowsFormsApp1.employeeDataSet3TableAdapters.ТипЗаявкиTableAdapter();
            this.типЗаявкиTableAdapter1 = new WindowsFormsApp1.employeeDataSet4TableAdapters.ТипЗаявкиTableAdapter();
            this.посетителиTableAdapter1 = new WindowsFormsApp1.employeeDataSet5TableAdapters.ПосетителиTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.типЧерногоСпискаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDataSet6 = new WindowsFormsApp1.employeeDataSet6();
            this.типЧерногоСпискаTableAdapter = new WindowsFormsApp1.employeeDataSet6TableAdapters.ТипЧерногоСпискаTableAdapter();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.back_button = new System.Windows.Forms.Button();
            this.appexit_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типЗаявкиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.посетителиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.посетителиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типПосещенийBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типЗаявкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типЧерногоСпискаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // form_label
            // 
            this.form_label.AutoSize = true;
            this.form_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.form_label.Location = new System.Drawing.Point(488, 40);
            this.form_label.Name = "form_label";
            this.form_label.Size = new System.Drawing.Size(354, 29);
            this.form_label.TabIndex = 71;
            this.form_label.Text = "Форма записи на посещение";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.иДпосетителяDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.номерТелефонаDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.датаРожденияDataGridViewTextBoxColumn,
            this.данныеПаспортаDataGridViewTextBoxColumn,
            this.логинDataGridViewTextBoxColumn,
            this.парольDataGridViewTextBoxColumn,
            this.назначениеDataGridViewTextBoxColumn,
            this.группаDataGridViewTextBoxColumn,
            this.иДтиппосDataGridViewTextBoxColumn,
            this.Button,
            this.СтатусЗаявки,
            this.ИД_тип_заяв,
            this.ИД_тип_ЧС});
            this.dataGridView1.DataSource = this.посетителиBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1902, 336);
            this.dataGridView1.TabIndex = 84;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // иДпосетителяDataGridViewTextBoxColumn
            // 
            this.иДпосетителяDataGridViewTextBoxColumn.DataPropertyName = "ИД_посетителя";
            this.иДпосетителяDataGridViewTextBoxColumn.HeaderText = "ИД_посетителя";
            this.иДпосетителяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.иДпосетителяDataGridViewTextBoxColumn.Name = "иДпосетителяDataGridViewTextBoxColumn";
            this.иДпосетителяDataGridViewTextBoxColumn.Width = 125;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.Width = 125;
            // 
            // номерТелефонаDataGridViewTextBoxColumn
            // 
            this.номерТелефонаDataGridViewTextBoxColumn.DataPropertyName = "Номер телефона";
            this.номерТелефонаDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            this.номерТелефонаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерТелефонаDataGridViewTextBoxColumn.Name = "номерТелефонаDataGridViewTextBoxColumn";
            this.номерТелефонаDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "E-mail";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаРожденияDataGridViewTextBoxColumn
            // 
            this.датаРожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаРожденияDataGridViewTextBoxColumn.Name = "датаРожденияDataGridViewTextBoxColumn";
            this.датаРожденияDataGridViewTextBoxColumn.Width = 125;
            // 
            // данныеПаспортаDataGridViewTextBoxColumn
            // 
            this.данныеПаспортаDataGridViewTextBoxColumn.DataPropertyName = "Данные паспорта";
            this.данныеПаспортаDataGridViewTextBoxColumn.HeaderText = "Данные паспорта";
            this.данныеПаспортаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.данныеПаспортаDataGridViewTextBoxColumn.Name = "данныеПаспортаDataGridViewTextBoxColumn";
            this.данныеПаспортаDataGridViewTextBoxColumn.Width = 125;
            // 
            // логинDataGridViewTextBoxColumn
            // 
            this.логинDataGridViewTextBoxColumn.DataPropertyName = "Логин";
            this.логинDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.логинDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.логинDataGridViewTextBoxColumn.Name = "логинDataGridViewTextBoxColumn";
            this.логинDataGridViewTextBoxColumn.Width = 125;
            // 
            // парольDataGridViewTextBoxColumn
            // 
            this.парольDataGridViewTextBoxColumn.DataPropertyName = "Пароль";
            this.парольDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.парольDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.парольDataGridViewTextBoxColumn.Name = "парольDataGridViewTextBoxColumn";
            this.парольDataGridViewTextBoxColumn.Width = 125;
            // 
            // назначениеDataGridViewTextBoxColumn
            // 
            this.назначениеDataGridViewTextBoxColumn.DataPropertyName = "Назначение";
            this.назначениеDataGridViewTextBoxColumn.HeaderText = "Назначение";
            this.назначениеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.назначениеDataGridViewTextBoxColumn.Name = "назначениеDataGridViewTextBoxColumn";
            this.назначениеDataGridViewTextBoxColumn.Width = 125;
            // 
            // группаDataGridViewTextBoxColumn
            // 
            this.группаDataGridViewTextBoxColumn.DataPropertyName = "Группа";
            this.группаDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.группаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.группаDataGridViewTextBoxColumn.Name = "группаDataGridViewTextBoxColumn";
            this.группаDataGridViewTextBoxColumn.Width = 125;
            // 
            // иДтиппосDataGridViewTextBoxColumn
            // 
            this.иДтиппосDataGridViewTextBoxColumn.DataPropertyName = "ИД_тип_пос";
            this.иДтиппосDataGridViewTextBoxColumn.HeaderText = "ИД_тип_пос";
            this.иДтиппосDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.иДтиппосDataGridViewTextBoxColumn.Name = "иДтиппосDataGridViewTextBoxColumn";
            this.иДтиппосDataGridViewTextBoxColumn.Width = 125;
            // 
            // Button
            // 
            this.Button.HeaderText = "";
            this.Button.MinimumWidth = 6;
            this.Button.Name = "Button";
            this.Button.Width = 125;
            // 
            // СтатусЗаявки
            // 
            this.СтатусЗаявки.DataSource = this.типЗаявкиBindingSource1;
            this.СтатусЗаявки.DisplayMember = "ТипЗаявки";
            this.СтатусЗаявки.HeaderText = "СтатусЗаявки";
            this.СтатусЗаявки.MinimumWidth = 6;
            this.СтатусЗаявки.Name = "СтатусЗаявки";
            this.СтатусЗаявки.ValueMember = "ИД_типа";
            this.СтатусЗаявки.Width = 125;
            // 
            // типЗаявкиBindingSource1
            // 
            this.типЗаявкиBindingSource1.DataMember = "ТипЗаявки";
            this.типЗаявкиBindingSource1.DataSource = this.employeeDataSet4;
            // 
            // employeeDataSet4
            // 
            this.employeeDataSet4.DataSetName = "employeeDataSet4";
            this.employeeDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ИД_тип_заяв
            // 
            this.ИД_тип_заяв.DataPropertyName = "ИД_тип_заяв";
            this.ИД_тип_заяв.HeaderText = "ИД_тип_заяв";
            this.ИД_тип_заяв.MinimumWidth = 6;
            this.ИД_тип_заяв.Name = "ИД_тип_заяв";
            this.ИД_тип_заяв.Width = 125;
            // 
            // ИД_тип_ЧС
            // 
            this.ИД_тип_ЧС.DataPropertyName = "ИД_тип_ЧС";
            this.ИД_тип_ЧС.HeaderText = "ИД_тип_ЧС";
            this.ИД_тип_ЧС.MinimumWidth = 6;
            this.ИД_тип_ЧС.Name = "ИД_тип_ЧС";
            this.ИД_тип_ЧС.Width = 125;
            // 
            // посетителиBindingSource1
            // 
            this.посетителиBindingSource1.DataMember = "Посетители";
            this.посетителиBindingSource1.DataSource = this.employeeDataSet5;
            // 
            // employeeDataSet5
            // 
            this.employeeDataSet5.DataSetName = "employeeDataSet5";
            this.employeeDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // посетителиBindingSource
            // 
            this.посетителиBindingSource.DataMember = "Посетители";
            this.посетителиBindingSource.DataSource = this.employeeDataSet1;
            // 
            // employeeDataSet1
            // 
            this.employeeDataSet1.DataSetName = "employeeDataSet1";
            this.employeeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeDataSetBindingSource
            // 
            this.employeeDataSetBindingSource.DataSource = this.employeeDataSet;
            this.employeeDataSetBindingSource.Position = 0;
            // 
            // employeeDataSet
            // 
            this.employeeDataSet.DataSetName = "employeeDataSet";
            this.employeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // посетителиTableAdapter
            // 
            this.посетителиTableAdapter.ClearBeforeFill = true;
            // 
            // employeeDataSet2
            // 
            this.employeeDataSet2.DataSetName = "employeeDataSet2";
            this.employeeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // типПосещенийBindingSource
            // 
            this.типПосещенийBindingSource.DataMember = "ТипПосещений";
            this.типПосещенийBindingSource.DataSource = this.employeeDataSet2;
            // 
            // типПосещенийTableAdapter
            // 
            this.типПосещенийTableAdapter.ClearBeforeFill = true;
            // 
            // типПосещенийTableAdapter1
            // 
            this.типПосещенийTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.типПосещенийBindingSource;
            this.comboBox1.DisplayMember = "Название";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(165, 101);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 85;
            this.comboBox1.ValueMember = "Название";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // employeeDataSet3
            // 
            this.employeeDataSet3.DataSetName = "employeeDataSet3";
            this.employeeDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // типЗаявкиBindingSource
            // 
            this.типЗаявкиBindingSource.DataMember = "ТипЗаявки";
            this.типЗаявкиBindingSource.DataSource = this.employeeDataSet3;
            // 
            // типЗаявкиTableAdapter
            // 
            this.типЗаявкиTableAdapter.ClearBeforeFill = true;
            // 
            // типЗаявкиTableAdapter1
            // 
            this.типЗаявкиTableAdapter1.ClearBeforeFill = true;
            // 
            // посетителиTableAdapter1
            // 
            this.посетителиTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.типЗаявкиBindingSource1;
            this.comboBox2.DisplayMember = "ТипЗаявки";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(325, 101);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 86;
            this.comboBox2.ValueMember = "ТипЗаявки";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.типЧерногоСпискаBindingSource;
            this.comboBox3.DisplayMember = "Тип_ЧС";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(493, 101);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 87;
            this.comboBox3.ValueMember = "Тип_ЧС";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // типЧерногоСпискаBindingSource
            // 
            this.типЧерногоСпискаBindingSource.DataMember = "ТипЧерногоСписка";
            this.типЧерногоСпискаBindingSource.DataSource = this.employeeDataSet6;
            // 
            // employeeDataSet6
            // 
            this.employeeDataSet6.DataSetName = "employeeDataSet6";
            this.employeeDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // типЧерногоСпискаTableAdapter
            // 
            this.типЧерногоСпискаTableAdapter.ClearBeforeFill = true;
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(693, 101);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(100, 22);
            this.textBox_search.TabIndex = 88;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(24, 37);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(87, 32);
            this.back_button.TabIndex = 89;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // appexit_button
            // 
            this.appexit_button.Location = new System.Drawing.Point(131, 37);
            this.appexit_button.Name = "appexit_button";
            this.appexit_button.Size = new System.Drawing.Size(201, 32);
            this.appexit_button.TabIndex = 90;
            this.appexit_button.Text = "Выход из приложения";
            this.appexit_button.UseVisualStyleBackColor = true;
            this.appexit_button.Click += new System.EventHandler(this.appexit_button_Click);
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 579);
            this.Controls.Add(this.appexit_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.form_label);
            this.Name = "GroupForm";
            this.Text = "GroupForm";
            this.Load += new System.EventHandler(this.GroupForm_Load);
            this.Shown += new System.EventHandler(this.GroupForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типЗаявкиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.посетителиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.посетителиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типПосещенийBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типЗаявкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типЧерногоСпискаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label form_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource employeeDataSetBindingSource;
        private employeeDataSet employeeDataSet;
        private employeeDataSet1 employeeDataSet1;
        private System.Windows.Forms.BindingSource посетителиBindingSource;
        private employeeDataSet1TableAdapters.ПосетителиTableAdapter посетителиTableAdapter;
        private employeeDataSet2 employeeDataSet2;
        private System.Windows.Forms.BindingSource типПосещенийBindingSource;
        private employeeDataSet2TableAdapters.ТипПосещенийTableAdapter типПосещенийTableAdapter;
        private employeeDataSet2TableAdapters.ТипПосещенийTableAdapter типПосещенийTableAdapter1;
        private System.Windows.Forms.ComboBox comboBox1;
        private employeeDataSet3 employeeDataSet3;
        private System.Windows.Forms.BindingSource типЗаявкиBindingSource;
        private employeeDataSet3TableAdapters.ТипЗаявкиTableAdapter типЗаявкиTableAdapter;
        private employeeDataSet4 employeeDataSet4;
        private System.Windows.Forms.BindingSource типЗаявкиBindingSource1;
        private employeeDataSet4TableAdapters.ТипЗаявкиTableAdapter типЗаявкиTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДпосетителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерТелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn данныеПаспортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn логинDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn парольDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn назначениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn группаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДтиппосDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Button;
        private System.Windows.Forms.DataGridViewComboBoxColumn СтатусЗаявки;
        private employeeDataSet5 employeeDataSet5;
        private System.Windows.Forms.BindingSource посетителиBindingSource1;
        private employeeDataSet5TableAdapters.ПосетителиTableAdapter посетителиTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ИД_тип_заяв;
        private System.Windows.Forms.DataGridViewTextBoxColumn ИД_тип_ЧС;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private employeeDataSet6 employeeDataSet6;
        private System.Windows.Forms.BindingSource типЧерногоСпискаBindingSource;
        private employeeDataSet6TableAdapters.ТипЧерногоСпискаTableAdapter типЧерногоСпискаTableAdapter;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button appexit_button;
    }
}