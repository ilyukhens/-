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
    public partial class Выдача : Form
    {
        public Выдача()
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

        private void Выдача_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_БиблеотекаDataSet.Vidacha". При необходимости она может быть перемещена или удалена.
            this.vidachaTableAdapter.Fill(this.бД_БиблеотекаDataSet.Vidacha);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            vidachaBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (vidachaBindingSource.Current != null)
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    vidachaBindingSource.RemoveCurrent();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.vidachaTableAdapter.Update(this.бД_БиблеотекаDataSet.Vidacha);
        }
    }
}
