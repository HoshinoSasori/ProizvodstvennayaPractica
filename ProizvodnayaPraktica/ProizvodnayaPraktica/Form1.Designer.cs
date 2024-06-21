
namespace ProizvodnayaPraktica
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеПрограммыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рекомендованноеCPUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рекомендованноеRAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рекомендованноеGPUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рекомендуемыйНакопительDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programNameDataSet = new ProizvodnayaPraktica.ProgramNameDataSet();
            this.programNameTableAdapter = new ProizvodnayaPraktica.ProgramNameDataSetTableAdapters.ProgramNameTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.programNameBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programNameDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programNameBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.названиеПрограммыDataGridViewTextBoxColumn,
            this.рекомендованноеCPUDataGridViewTextBoxColumn,
            this.рекомендованноеRAMDataGridViewTextBoxColumn,
            this.рекомендованноеGPUDataGridViewTextBoxColumn,
            this.рекомендуемыйНакопительDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.programNameBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(830, 185);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.Width = 45;
            // 
            // названиеПрограммыDataGridViewTextBoxColumn
            // 
            this.названиеПрограммыDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.названиеПрограммыDataGridViewTextBoxColumn.DataPropertyName = "Название_Программы";
            this.названиеПрограммыDataGridViewTextBoxColumn.HeaderText = "Название_Программы";
            this.названиеПрограммыDataGridViewTextBoxColumn.Name = "названиеПрограммыDataGridViewTextBoxColumn";
            this.названиеПрограммыDataGridViewTextBoxColumn.Width = 149;
            // 
            // рекомендованноеCPUDataGridViewTextBoxColumn
            // 
            this.рекомендованноеCPUDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.рекомендованноеCPUDataGridViewTextBoxColumn.DataPropertyName = "Рекомендованное CPU";
            this.рекомендованноеCPUDataGridViewTextBoxColumn.HeaderText = "Рекомендованное CPU";
            this.рекомендованноеCPUDataGridViewTextBoxColumn.Name = "рекомендованноеCPUDataGridViewTextBoxColumn";
            this.рекомендованноеCPUDataGridViewTextBoxColumn.Width = 137;
            // 
            // рекомендованноеRAMDataGridViewTextBoxColumn
            // 
            this.рекомендованноеRAMDataGridViewTextBoxColumn.DataPropertyName = "Рекомендованное RAM";
            this.рекомендованноеRAMDataGridViewTextBoxColumn.HeaderText = "Рекомендованное RAM";
            this.рекомендованноеRAMDataGridViewTextBoxColumn.Name = "рекомендованноеRAMDataGridViewTextBoxColumn";
            this.рекомендованноеRAMDataGridViewTextBoxColumn.Width = 115;
            // 
            // рекомендованноеGPUDataGridViewTextBoxColumn
            // 
            this.рекомендованноеGPUDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.рекомендованноеGPUDataGridViewTextBoxColumn.DataPropertyName = "Рекомендованное GPU";
            this.рекомендованноеGPUDataGridViewTextBoxColumn.HeaderText = "Рекомендованное GPU";
            this.рекомендованноеGPUDataGridViewTextBoxColumn.Name = "рекомендованноеGPUDataGridViewTextBoxColumn";
            this.рекомендованноеGPUDataGridViewTextBoxColumn.Width = 138;
            // 
            // рекомендуемыйНакопительDataGridViewTextBoxColumn
            // 
            this.рекомендуемыйНакопительDataGridViewTextBoxColumn.DataPropertyName = "Рекомендуемый_Накопитель";
            this.рекомендуемыйНакопительDataGridViewTextBoxColumn.HeaderText = "Рекомендуемый_Накопитель";
            this.рекомендуемыйНакопительDataGridViewTextBoxColumn.Name = "рекомендуемыйНакопительDataGridViewTextBoxColumn";
            this.рекомендуемыйНакопительDataGridViewTextBoxColumn.Width = 160;
            // 
            // programNameBindingSource
            // 
            this.programNameBindingSource.DataMember = "ProgramName";
            this.programNameBindingSource.DataSource = this.programNameDataSet;
            // 
            // programNameDataSet
            // 
            this.programNameDataSet.DataSetName = "ProgramNameDataSet";
            this.programNameDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // programNameTableAdapter
            // 
            this.programNameTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(154, 25);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(281, 25);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(149, 21);
            this.comboBox3.TabIndex = 3;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(436, 25);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 4;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(563, 25);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 5;
            // 
            // programNameBindingSource1
            // 
            this.programNameBindingSource1.DataMember = "ProgramName";
            this.programNameBindingSource1.DataSource = this.programNameDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "CPU:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "RAM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "GPU:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "HDD:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(560, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "SDD:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(644, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Автор: Гнедич Даниил Денисович 28-Б";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 304);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "модуль программного обеспечения «Соответствие технических средств требования прил" +
    "ожений или ПО»";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programNameDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programNameBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ProgramNameDataSet programNameDataSet;
        private System.Windows.Forms.BindingSource programNameBindingSource;
        private ProgramNameDataSetTableAdapters.ProgramNameTableAdapter programNameTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеПрограммыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рекомендованноеCPUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рекомендованноеRAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рекомендованноеGPUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рекомендуемыйНакопительDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.BindingSource programNameBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

