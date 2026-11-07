using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Жанры : Form
    {
        public Жанры()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {

                this.Owner.Show();
            }


            this.Close();
        }

        private void Жанры_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_БиблеотекаDataSet.Zhanri". При необходимости она может быть перемещена или удалена.
            this.zhanriTableAdapter.Fill(this.бД_БиблеотекаDataSet.Zhanri);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            zhanriBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (zhanriBindingSource.Current != null)
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    zhanriBindingSource.RemoveCurrent();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.zhanriTableAdapter.Update(this.бД_БиблеотекаDataSet.Zhanri);
        }
    }
}
