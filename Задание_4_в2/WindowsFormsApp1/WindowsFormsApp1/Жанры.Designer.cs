namespace WindowsFormsApp1
{
    partial class Жанры
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
            this.iDЖанраDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиежанраDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zhanriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД_БиблеотекаDataSet = new WindowsFormsApp1.БД_БиблеотекаDataSet();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.zhanriTableAdapter = new WindowsFormsApp1.БД_БиблеотекаDataSetTableAdapters.ZhanriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhanriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_БиблеотекаDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDЖанраDataGridViewTextBoxColumn,
            this.названиежанраDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zhanriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(424, 140);
            this.dataGridView1.TabIndex = 9;
            // 
            // iDЖанраDataGridViewTextBoxColumn
            // 
            this.iDЖанраDataGridViewTextBoxColumn.DataPropertyName = "ID_Жанра";
            this.iDЖанраDataGridViewTextBoxColumn.HeaderText = "ID_Жанра";
            this.iDЖанраDataGridViewTextBoxColumn.Name = "iDЖанраDataGridViewTextBoxColumn";
            // 
            // названиежанраDataGridViewTextBoxColumn
            // 
            this.названиежанраDataGridViewTextBoxColumn.DataPropertyName = "Название_жанра";
            this.названиежанраDataGridViewTextBoxColumn.HeaderText = "Название_жанра";
            this.названиежанраDataGridViewTextBoxColumn.Name = "названиежанраDataGridViewTextBoxColumn";
            // 
            // zhanriBindingSource
            // 
            this.zhanriBindingSource.DataMember = "Zhanri";
            this.zhanriBindingSource.DataSource = this.бД_БиблеотекаDataSet;
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
            // zhanriTableAdapter
            // 
            this.zhanriTableAdapter.ClearBeforeFill = true;
            // 
            // Жанры
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Жанры";
            this.Text = "Жанры";
            this.Load += new System.EventHandler(this.Жанры_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhanriBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource zhanriBindingSource;
        private БД_БиблеотекаDataSetTableAdapters.ZhanriTableAdapter zhanriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDЖанраDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиежанраDataGridViewTextBoxColumn;
    }
}