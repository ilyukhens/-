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
    public partial class Регистрация_Клиент : Form
    {
        public Регистрация_Клиент()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 1. Проверяем, что все поля заполнены
            string fio = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            string phoneInput = textBox3.Text.Trim();

            if (string.IsNullOrEmpty(fio) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(phoneInput))
            {
                MessageBox.Show("Пожалуйста, заполните все поля для регистрации!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверяем, что телефон введен как число, так как в БД это тип int
            if (!int.TryParse(phoneInput, out int phone))
            {
                MessageBox.Show("Номер телефона должен состоять только из цифр!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Создаем экземпляры DataSet и адаптера
                WindowsFormsApp1.БД_БиблеотекаDataSet dataSet = new WindowsFormsApp1.БД_БиблеотекаDataSet();
                var chitateliAdapter = new WindowsFormsApp1.БД_БиблеотекаDataSetTableAdapters.ChitateliTableAdapter();

                // Загружаем текущих читателей
                chitateliAdapter.Fill(dataSet.Chitateli);

                // 3. Генерация уникального номера читательского билета
                Random rand = new Random();
                int ticketNumber; // Меняем с decimal на int
                bool isUnique;

                do
                {
                    ticketNumber = rand.Next(100000, 999999);
                    isUnique = true;

                    // Проверяем уникальность
                    foreach (WindowsFormsApp1.БД_БиблеотекаDataSet.ChitateliRow row in dataSet.Chitateli.Rows)
                    {
                        if (row.Номер_билета == ticketNumber) // Теперь оба типа int, всё сработает идеально
                        {
                            isUnique = false;
                            break;
                        }
                    }
                } while (!isUnique);

                // 4. Создаем новую строку и заполняем данными клиента
                WindowsFormsApp1.БД_БиблеотекаDataSet.ChitateliRow newRow = dataSet.Chitateli.NewChitateliRow();

                newRow.ФИО = fio;
                newRow.Пароль_хэш = password; // В вашей БД колонка называется именно Пароль_хэш
                newRow.Телефон = phone;       // Передаем сконвертированное число int
                newRow.Номер_билета = ticketNumber; // Передаем сконвертированное число decimal
                newRow.Дата_регистрации = DateTime.Now;

                // Добавляем строку в датасет и сохраняем изменения в файл Access
                dataSet.Chitateli.AddChitateliRow(newRow);
                chitateliAdapter.Update(dataSet.Chitateli);

                // 5. Успешный финал
                MessageBox.Show($"Регистрация завершена успешно!\nВаш индивидуальный номер билета: {ticketNumber}\nИспользуйте его для входа.",
                                "Регистрация успешна", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Очищаем поля
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при регистрации клиента: " + ex.Message, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Вход_Клиент VK = new Вход_Клиент();
            VK.Owner = this;
            VK.Show();
            this.Hide();
        }
    }
}
