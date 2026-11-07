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
    public partial class Книги : Form
    {
        public Книги()
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

        private void Книги_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_БиблеотекаDataSet.Knigi". При необходимости она может быть перемещена или удалена.
            this.knigiTableAdapter.Fill(this.бД_БиблеотекаDataSet.Knigi);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            knigiBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (knigiBindingSource.Current != null)
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    knigiBindingSource.RemoveCurrent();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.knigiTableAdapter.Update(this.бД_БиблеотекаDataSet.Knigi);
        }
    }
}
