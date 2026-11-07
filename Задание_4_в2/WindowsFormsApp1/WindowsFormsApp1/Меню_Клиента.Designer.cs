namespace WindowsFormsApp1
{
    partial class Меню_Клиента
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvKnigi = new System.Windows.Forms.DataGridView();
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
            this.knigiTableAdapter = new WindowsFormsApp1.БД_БиблеотекаDataSetTableAdapters.KnigiTableAdapter();
            this.btnTakeBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnigi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knigiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_БиблеотекаDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(50, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поиск по названию :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(228, 255);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(160, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvKnigi
            // 
            this.dgvKnigi.AutoGenerateColumns = false;
            this.dgvKnigi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKnigi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDКнигиDataGridViewTextBoxColumn,
            this.iDАвтораDataGridViewTextBoxColumn,
            this.iDЖанраDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.годизданияDataGridViewTextBoxColumn,
            this.международныйномерDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.остотокнаскладеDataGridViewTextBoxColumn,
            this.аннотацияDataGridViewTextBoxColumn});
            this.dgvKnigi.DataSource = this.knigiBindingSource;
            this.dgvKnigi.Location = new System.Drawing.Point(12, 22);
            this.dgvKnigi.Name = "dgvKnigi";
            this.dgvKnigi.Size = new System.Drawing.Size(1019, 174);
            this.dgvKnigi.TabIndex = 3;
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
            // knigiTableAdapter
            // 
            this.knigiTableAdapter.ClearBeforeFill = true;
            // 
            // btnTakeBook
            // 
            this.btnTakeBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTakeBook.Location = new System.Drawing.Point(482, 255);
            this.btnTakeBook.Name = "btnTakeBook";
            this.btnTakeBook.Size = new System.Drawing.Size(183, 70);
            this.btnTakeBook.TabIndex = 4;
            this.btnTakeBook.Text = "Взять выбранную книгу";
            this.btnTakeBook.UseVisualStyleBackColor = true;
            this.btnTakeBook.Click += new System.EventHandler(this.btnTakeBook_Click);
            // 
            // Меню_Клиента
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 450);
            this.Controls.Add(this.btnTakeBook);
            this.Controls.Add(this.dgvKnigi);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Меню_Клиента";
            this.Text = "Меню_Клиента";
            this.Load += new System.EventHandler(this.Меню_Клиента_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnigi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knigiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_БиблеотекаDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvKnigi;
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
        private System.Windows.Forms.Button btnTakeBook;
    }
}