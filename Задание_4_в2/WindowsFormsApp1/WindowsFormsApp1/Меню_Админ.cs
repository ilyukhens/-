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
    public partial class Меню_Админ : Form
    {
        public Меню_Админ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Авторы Avt = new Авторы();
            Avt.Owner = this;
            Avt.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Клиенты Kli = new Клиенты();
            Kli.Owner = this;
            Kli.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Книги Kni = new Книги();
            Kni.Owner = this;
            Kni.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Выдача Vidocha = new Выдача();
            Vidocha.Owner = this;
            Vidocha.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Жанры Zjanrs = new Жанры();
            Zjanrs.Owner = this;
            Zjanrs.Show();
            this.Hide();
        }
    }
}
