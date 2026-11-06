using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Регистрация_клиент : Form
    {
        // Строка подключения к твоей базе данных
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=БД_Библеотека.accdb;";

        public Регистрация_клиент()
        {
            InitializeComponent();
        }

        // Обработчик кнопки регистрации (button2)
        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim(); // ФИО из первого текстового поля
            string phoneInput = textBox2.Text.Trim(); // Телефон из второго текстового поля
            string plainPassword = textBox3.Text;   // Пароль из третьего текстового поля

            // Проверяем заполнение всех полей
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(phoneInput) || string.IsNullOrEmpty(plainPassword))
            {
                MessageBox.Show("Заполните все поля (ФИО, Телефон, Пароль)!");
                return;
            }

            // Очищаем телефон от знака '+' и пробелов, так как в Access это Числовое поле
            string cleanPhone = phoneInput.Replace("+", "").Replace(" ", "");

            if (!long.TryParse(cleanPhone, out long phoneAsNumber))
            {
                MessageBox.Show("Номер телефона должен состоять только из цифр!");
                return;
            }

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // 1. Генерируем уникальное числовое значение для билета
                    int ticketNumber = GenerateUniqueTicket(connection);

                    // 2. Хешируем пароль, используя номер билета как "соль"
                    string hashedPassword = HashPasswordWithSalt(plainPassword, ticketNumber.ToString());

                    // 3. Записываем в MS Access (используем ТВОИ точные имена полей)
                    // Внимание: если твоя таблица называется в Access иначе (например, Клиенты), замени слово client ниже
                    string query = "INSERT INTO client (ФИО, Номер_билета, Телефон, Пароль_хэш) VALUES (?, ?, ?, ?)";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Параметры для Access привязываются строго ПО ПОРЯДКУ знаков '?' в запросе!
                        command.Parameters.AddWithValue("@ФИО", username);
                        command.Parameters.AddWithValue("@Номер_билета", ticketNumber);
                        command.Parameters.AddWithValue("@Телефон", phoneAsNumber); // Передаем как число long
                        command.Parameters.AddWithValue("@Пароль_хэш", hashedPassword);

                        command.ExecuteNonQuery();

                        // 4. Показываем всплывающее уведомление клиенту
                        MessageBox.Show($"Регистрация успешна!\n\nВаш номер читательского билета: {ticketNumber}\nИспользуйте его для входа.",
                                        "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка регистрации: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Встроенный метод хеширования SHA-256 + Соль (без сторонних NuGet)
        private string HashPasswordWithSalt(string password, string salt)
        {
            string saltedPassword = password + salt;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(saltedPassword);
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }

        // Метод генерации уникального случайного числа для билета
        private int GenerateUniqueTicket(OleDbConnection connection)
        {
            Random random = new Random();
            int ticket = 0;
            bool isUnique = false;

            while (!isUnique)
            {
                // Генерируем случайное 6-значное число от 100000 до 999999
                ticket = random.Next(100000, 1000000);

                // Проверяем, свободен ли данный номер в базе данных
                // Внимание: если таблица в БД называется иначе, замени client на имя таблицы
                string checkQuery = "SELECT COUNT(*) FROM client WHERE Номер_билета = ?";
                using (OleDbCommand checkCommand = new OleDbCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@ticket", ticket);
                    int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (count == 0)
                    {
                        isUnique = true; // Выходим из цикла, если совпадений в базе нет
                    }
                }
            }
            return ticket;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр формы входа
            Авторизация_клиент loginForm = new Авторизация_клиент();

            // Показываем её пользователю
            loginForm.Show();

            // Скрываем текущую форму регистрации (чтобы не мешала)
            this.Hide();
        }
    }
}
