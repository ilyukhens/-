namespace WindowsFormsApp1
{
    partial class Выдача
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
            this.iDВыдачиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDКнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDЧитателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датавыдачиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.плановаядатавозвратаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фактическаядатавозвратаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vidachaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД_БиблеотекаDataSet = new WindowsFormsApp1.БД_БиблеотекаDataSet();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.vidachaTableAdapter = new WindowsFormsApp1.БД_БиблеотекаDataSetTableAdapters.VidachaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidachaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_БиблеотекаDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDВыдачиDataGridViewTextBoxColumn,
            this.iDКнигиDataGridViewTextBoxColumn,
            this.iDЧитателяDataGridViewTextBoxColumn,
            this.датавыдачиDataGridViewTextBoxColumn,
            this.плановаядатавозвратаDataGridViewTextBoxColumn,
            this.фактическаядатавозвратаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vidachaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(668, 140);
            this.dataGridView1.TabIndex = 9;
            // 
            // iDВыдачиDataGridViewTextBoxColumn
            // 
            this.iDВыдачиDataGridViewTextBoxColumn.DataPropertyName = "ID_Выдачи";
            this.iDВыдачиDataGridViewTextBoxColumn.HeaderText = "ID_Выдачи";
            this.iDВыдачиDataGridViewTextBoxColumn.Name = "iDВыдачиDataGridViewTextBoxColumn";
            // 
            // iDКнигиDataGridViewTextBoxColumn
            // 
            this.iDКнигиDataGridViewTextBoxColumn.DataPropertyName = "ID_Книги";
            this.iDКнигиDataGridViewTextBoxColumn.HeaderText = "ID_Книги";
            this.iDКнигиDataGridViewTextBoxColumn.Name = "iDКнигиDataGridViewTextBoxColumn";
            // 
            // iDЧитателяDataGridViewTextBoxColumn
            // 
            this.iDЧитателяDataGridViewTextBoxColumn.DataPropertyName = "ID_Читателя";
            this.iDЧитателяDataGridViewTextBoxColumn.HeaderText = "ID_Читателя";
            this.iDЧитателяDataGridViewTextBoxColumn.Name = "iDЧитателяDataGridViewTextBoxColumn";
            // 
            // датавыдачиDataGridViewTextBoxColumn
            // 
            this.датавыдачиDataGridViewTextBoxColumn.DataPropertyName = "Дата_выдачи";
            this.датавыдачиDataGridViewTextBoxColumn.HeaderText = "Дата_выдачи";
            this.датавыдачиDataGridViewTextBoxColumn.Name = "датавыдачиDataGridViewTextBoxColumn";
            // 
            // плановаядатавозвратаDataGridViewTextBoxColumn
            // 
            this.плановаядатавозвратаDataGridViewTextBoxColumn.DataPropertyName = "Плановая_дата_возврата";
            this.плановаядатавозвратаDataGridViewTextBoxColumn.HeaderText = "Плановая_дата_возврата";
            this.плановаядатавозвратаDataGridViewTextBoxColumn.Name = "плановаядатавозвратаDataGridViewTextBoxColumn";
            // 
            // фактическаядатавозвратаDataGridViewTextBoxColumn
            // 
            this.фактическаядатавозвратаDataGridViewTextBoxColumn.DataPropertyName = "Фактическая_дата_возврата";
            this.фактическаядатавозвратаDataGridViewTextBoxColumn.HeaderText = "Фактическая_дата_возврата";
            this.фактическаядатавозвратаDataGridViewTextBoxColumn.Name = "фактическаядатавозвратаDataGridViewTextBoxColumn";
            // 
            // vidachaBindingSource
            // 
            this.vidachaBindingSource.DataMember = "Vidacha";
            this.vidachaBindingSource.DataSource = this.бД_БиблеотекаDataSet;
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
            // vidachaTableAdapter
            // 
            this.vidachaTableAdapter.ClearBeforeFill = true;
            // 
            // Выдача
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Выдача";
            this.Text = "Выдача";
            this.Load += new System.EventHandler(this.Выдача_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidachaBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource vidachaBindingSource;
        private БД_БиблеотекаDataSetTableAdapters.VidachaTableAdapter vidachaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDВыдачиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDЧитателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датавыдачиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn плановаядатавозвратаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фактическаядатавозвратаDataGridViewTextBoxColumn;
    }
}