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
    public partial class Вход_Клиент : Form
    {
        public Вход_Клиент()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputTicket = textBox1.Text.Trim();   // Поле ввода Номера билета
            string inputPassword = textBox2.Text.Trim(); // Поле ввода Пароля

            // 1. Проверяем, что поля не пустые
            if (string.IsNullOrEmpty(inputTicket) || string.IsNullOrEmpty(inputPassword))
            {
                MessageBox.Show("Пожалуйста, введите номер билета и пароль!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Проверяем, что номер билета состоит из цифр, так как в БД это число (int)
            if (!int.TryParse(inputTicket, out int ticketNumber))
            {
                MessageBox.Show("Номер билета должен состоять только из цифр!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 3. Создаем экземпляры DataSet и адаптера для таблицы читателей
                WindowsFormsApp1.БД_БиблеотекаDataSet dataSet = new WindowsFormsApp1.БД_БиблеотекаDataSet();
                var chitateliAdapter = new WindowsFormsApp1.БД_БиблеотекаDataSetTableAdapters.ChitateliTableAdapter();

                // Загружаем данные из базы в DataSet
                chitateliAdapter.Fill(dataSet.Chitateli);

                bool isAuthorized = false;

                // 4. Перебираем строки таблицы читателей
                foreach (WindowsFormsApp1.БД_БиблеотекаDataSet.ChitateliRow row in dataSet.Chitateli.Rows)
                {
                    // Сравниваем числовой номер билета и строку пароля (Пароль_хэш)
                    if (row.Номер_билета == ticketNumber && row.Пароль_хэш.ToString() == inputPassword)
                    {
                        isAuthorized = true;
                        break;
                    }
                }

                // 5. Результат проверки
                if (isAuthorized)
                {
                    MessageBox.Show("Вход выполнен успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Открываем форму для клиента (замените МенюКлиента на реальное название вашей новой формы)
                    Меню_Клиента clientMenu = new Меню_Клиента();
                    clientMenu.Show();

                    this.Hide(); // Скрываем форму входа
                }
                else
                {
                    MessageBox.Show("Неверный номер билета или пароль.", "Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при проверке данных: " + ex.Message, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
