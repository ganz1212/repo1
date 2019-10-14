namespace AIS_Cafe
{
    partial class postavki123
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодПоставщикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПоставкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПоставкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.весГрузаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фирмаПодрядчикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.подтверждениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postavkinormalDataSet = new AIS_Cafe.postavkinormalDataSet();
            this.tableTableAdapter = new AIS_Cafe.postavkinormalDataSetTableAdapters.TableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkinormalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодПоставщикаDataGridViewTextBoxColumn,
            this.кодПоставкиDataGridViewTextBoxColumn,
            this.датаПоставкиDataGridViewTextBoxColumn,
            this.весГрузаDataGridViewTextBoxColumn,
            this.фирмаПодрядчикDataGridViewTextBoxColumn,
            this.подтверждениеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(733, 340);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодПоставщикаDataGridViewTextBoxColumn
            // 
            this.кодПоставщикаDataGridViewTextBoxColumn.DataPropertyName = "КодПоставщика";
            this.кодПоставщикаDataGridViewTextBoxColumn.HeaderText = "КодПоставщика";
            this.кодПоставщикаDataGridViewTextBoxColumn.Name = "кодПоставщикаDataGridViewTextBoxColumn";
            this.кодПоставщикаDataGridViewTextBoxColumn.Width = 120;
            // 
            // кодПоставкиDataGridViewTextBoxColumn
            // 
            this.кодПоставкиDataGridViewTextBoxColumn.DataPropertyName = "КодПоставки";
            this.кодПоставкиDataGridViewTextBoxColumn.HeaderText = "КодПоставки";
            this.кодПоставкиDataGridViewTextBoxColumn.Name = "кодПоставкиDataGridViewTextBoxColumn";
            this.кодПоставкиDataGridViewTextBoxColumn.Width = 120;
            // 
            // датаПоставкиDataGridViewTextBoxColumn
            // 
            this.датаПоставкиDataGridViewTextBoxColumn.DataPropertyName = "ДатаПоставки";
            this.датаПоставкиDataGridViewTextBoxColumn.HeaderText = "ДатаПоставки";
            this.датаПоставкиDataGridViewTextBoxColumn.Name = "датаПоставкиDataGridViewTextBoxColumn";
            // 
            // весГрузаDataGridViewTextBoxColumn
            // 
            this.весГрузаDataGridViewTextBoxColumn.DataPropertyName = "ВесГруза";
            this.весГрузаDataGridViewTextBoxColumn.HeaderText = "ВесГруза";
            this.весГрузаDataGridViewTextBoxColumn.Name = "весГрузаDataGridViewTextBoxColumn";
            // 
            // фирмаПодрядчикDataGridViewTextBoxColumn
            // 
            this.фирмаПодрядчикDataGridViewTextBoxColumn.DataPropertyName = "ФирмаПодрядчик";
            this.фирмаПодрядчикDataGridViewTextBoxColumn.HeaderText = "ФирмаПодрядчик";
            this.фирмаПодрядчикDataGridViewTextBoxColumn.Name = "фирмаПодрядчикDataGridViewTextBoxColumn";
            // 
            // подтверждениеDataGridViewTextBoxColumn
            // 
            this.подтверждениеDataGridViewTextBoxColumn.DataPropertyName = "Подтверждение";
            this.подтверждениеDataGridViewTextBoxColumn.HeaderText = "Подтверждение";
            this.подтверждениеDataGridViewTextBoxColumn.Name = "подтверждениеDataGridViewTextBoxColumn";
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.postavkinormalDataSet;
            // 
            // postavkinormalDataSet
            // 
            this.postavkinormalDataSet.DataSetName = "postavkinormalDataSet";
            this.postavkinormalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // postavki123
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "postavki123";
            this.Size = new System.Drawing.Size(736, 383);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkinormalDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private postavkinormalDataSet postavkinormalDataSet;
        private postavkinormalDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПоставщикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПоставкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПоставкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn весГрузаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фирмаПодрядчикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn подтверждениеDataGridViewTextBoxColumn;
    }
}
