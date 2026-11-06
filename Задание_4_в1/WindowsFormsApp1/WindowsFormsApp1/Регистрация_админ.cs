using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Регистрация_админ : Form
    {
        public Регистрация_админ()
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

        private void button2_Click(object sender, EventArgs e)
        {
            string inputName = textBox1.Text.Trim();
            string inputPassword = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(inputName) || string.IsNullOrEmpty(inputPassword))
            {
                MessageBox.Show("Пожалуйста, введите имя и пароль!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 1. Создаем экземпляр DataSet библиотеки
                WindowsFormsApp1.БД_БиблеотекаDataSet dataSet = new WindowsFormsApp1.БД_БиблеотекаDataSet();

                // 2. Создаем адаптер именно для таблицы Kod_Vhod
                var adapter = new WindowsFormsApp1.БД_БиблеотекаDataSetTableAdapters.Kod_VhodTableAdapter();

                // 3. Заполняем таблицу данными из базы
                adapter.Fill(dataSet.Kod_Vhod);

                bool isAuthorized = false;

                // 4. Перебираем строки таблицы авторизации
                foreach (WindowsFormsApp1.БД_БиблеотекаDataSet.Kod_VhodRow row in dataSet.Kod_Vhod.Rows)
                {
                    // Проверяем логин и пароль по точным названиям столбцов из вашей БД_Библиотека
                    if (row.Имя_администратора.ToString() == inputName && row.Код_входа.ToString() == inputPassword)
                    {
                        isAuthorized = true;
                        break;
                    }
                }

                if (isAuthorized)
                {
                    MessageBox.Show("Авторизация успешна!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Открываем вашу форму меню (убедитесь, что класс формы называется именно МенюАдмина или скорректируйте название)
                    Меню_Админ adminMenu = new Меню_Админ();
                    adminMenu.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неверное имя пользователя или пароль.", "Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при работе с DataSet: " + ex.Message, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
