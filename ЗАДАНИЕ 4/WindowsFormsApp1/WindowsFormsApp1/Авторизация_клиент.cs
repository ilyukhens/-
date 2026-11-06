using System;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Авторизация_клиент : Form
    {
        // Строка подключения к твоей базе данных
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=БД_Библеотека.accdb;";

        public Авторизация_клиент()
        {
            InitializeComponent();
        }

        // Обработчик кнопки «Войти» (button1)
        private void button1_Click(object sender, EventArgs e)
        {
            string ticketInput = textBox1.Text.Trim(); // Номер билета
            string passwordInput = textBox2.Text;      // Пароль

            if (string.IsNullOrEmpty(ticketInput) || string.IsNullOrEmpty(passwordInput))
            {
                MessageBox.Show("Введите номер билета и пароль!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // 1. Ищем в базе хэш пароля для указанного номера билета
                    // (Используем твои точные названия полей: Пароль_хэш и Номер_билета)
                    string query = "SELECT Пароль_хэш FROM client WHERE Номер_билета = ?";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ticket", Convert.ToInt32(ticketInput));
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            string savedHash = result.ToString();

                            // 2. Хешируем введенный пароль с солью (номером билета) для проверки
                            string enteredPasswordHash = HashPasswordWithSalt(passwordInput, ticketInput);

                            // 3. Сравниваем хэши (админ не знает пароль, а программа проверит)
                            if (savedHash == enteredPasswordHash)
                            {
                                MessageBox.Show("Вход успешно выполнен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // ТУТ открывай главную форму библиотеки (например, каталог книг)
                                // FormMain main = new FormMain();
                                // main.Show();
                                // this.Close(); 
                            }
                            else
                            {
                                MessageBox.Show("Неверный пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Пользователь с таким номером билета не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при входе: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Встроенный метод хеширования (точно такой же, как на форме регистрации)
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
    }
}
