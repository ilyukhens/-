namespace WindowsFormsApp1
{
    partial class Книги
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDКнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDАвтораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDЖанраDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годизданияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.международныйномерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.остотокнаскладеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.аннотацияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knigiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД_БиблеотекаDataSet = new WindowsFormsApp1.БД_БиблеотекаDataSet();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.knigiTableAdapter = new WindowsFormsApp1.БД_БиблеотекаDataSetTableAdapters.KnigiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knigiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_БиблеотекаDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDКнигиDataGridViewTextBoxColumn,
            this.iDАвтораDataGridViewTextBoxColumn,
            this.iDЖанраDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.годизданияDataGridViewTextBoxColumn,
            this.международныйномерDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.остотокнаскладеDataGridViewTextBoxColumn,
            this.аннотацияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.knigiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(962, 140);
            this.dataGridView1.TabIndex = 9;
            // 
            // iDКнигиDataGridViewTextBoxColumn
            // 
            this.iDКнигиDataGridViewTextBoxColumn.DataPropertyName = "ID_Книги";
            this.iDКнигиDataGridViewTextBoxColumn.HeaderText = "ID_Книги";
            this.iDКнигиDataGridViewTextBoxColumn.Name = "iDКнигиDataGridViewTextBoxColumn";
            // 
            // iDАвтораDataGridViewTextBoxColumn
            // 
            this.iDАвтораDataGridViewTextBoxColumn.DataPropertyName = "ID_Автора";
            this.iDАвтораDataGridViewTextBoxColumn.HeaderText = "ID_Автора";
            this.iDАвтораDataGridViewTextBoxColumn.Name = "iDАвтораDataGridViewTextBoxColumn";
            // 
            // iDЖанраDataGridViewTextBoxColumn
            // 
            this.iDЖанраDataGridViewTextBoxColumn.DataPropertyName = "ID_Жанра";
            this.iDЖанраDataGridViewTextBoxColumn.HeaderText = "ID_Жанра";
            this.iDЖанраDataGridViewTextBoxColumn.Name = "iDЖанраDataGridViewTextBoxColumn";
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // годизданияDataGridViewTextBoxColumn
            // 
            this.годизданияDataGridViewTextBoxColumn.DataPropertyName = "Год_издания";
            this.годизданияDataGridViewTextBoxColumn.HeaderText = "Год_издания";
            this.годизданияDataGridViewTextBoxColumn.Name = "годизданияDataGridViewTextBoxColumn";
            // 
            // международныйномерDataGridViewTextBoxColumn
            // 
            this.международныйномерDataGridViewTextBoxColumn.DataPropertyName = "Международный_номер";
            this.международныйномерDataGridViewTextBoxColumn.HeaderText = "Международный_номер";
            this.международныйномерDataGridViewTextBoxColumn.Name = "международныйномерDataGridViewTextBoxColumn";
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            // 
            // остотокнаскладеDataGridViewTextBoxColumn
            // 
            this.остотокнаскладеDataGridViewTextBoxColumn.DataPropertyName = "Остоток_на_складе";
            this.остотокнаскладеDataGridViewTextBoxColumn.HeaderText = "Остоток_на_складе";
            this.остотокнаскладеDataGridViewTextBoxColumn.Name = "остотокнаскладеDataGridViewTextBoxColumn";
            // 
            // аннотацияDataGridViewTextBoxColumn
            // 
            this.аннотацияDataGridViewTextBoxColumn.DataPropertyName = "Аннотация";
            this.аннотацияDataGridViewTextBoxColumn.HeaderText = "Аннотация";
            this.аннотацияDataGridViewTextBoxColumn.Name = "аннотацияDataGridViewTextBoxColumn";
            // 
            // knigiBindingSource
            // 
            this.knigiBindingSource.DataMember = "Knigi";
            this.knigiBindingSource.DataSource = this.бД_БиблеотекаDataSet;
            // 
            // бД_БиблеотекаDataSet
            // 
            this.бД_БиблеотекаDataSet.DataSetName = "БД_БиблеотекаDataSet";
            this.бД_БиблеотекаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(423, 334);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 45);
            this.button4.TabIndex = 8;
            this.button4.Text = "Сахронить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(289, 334);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 45);
            this.button3.TabIndex = 7;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 45);
            this.button2.TabIndex = 6;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // knigiTableAdapter
            // 
            this.knigiTableAdapter.ClearBeforeFill = true;
            // 
            // Книги
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Книги";
            this.Text = "Книги";
            this.Load += new System.EventHandler(this.Книги_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knigiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_БиблеотекаDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private БД_БиблеотекаDataSet бД_БиблеотекаDataSet;
        private System.Windows.Forms.BindingSource knigiBindingSource;
        private БД_БиблеотекаDataSetTableAdapters.KnigiTableAdapter knigiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDАвтораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDЖанраDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годизданияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn международныйномерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn остотокнаскладеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn аннотацияDataGridViewTextBoxColumn;
    }
}