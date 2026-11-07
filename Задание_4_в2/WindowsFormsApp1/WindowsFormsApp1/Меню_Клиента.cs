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
    public partial class Меню_Клиента : Form
    {
        public Меню_Клиента()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Меню_Клиента_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_БиблеотекаDataSet.Knigi". При необходимости она может быть перемещена или удалена.
            this.knigiTableAdapter.Fill(this.бД_БиблеотекаDataSet.Knigi);

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            knigiBindingSource.Filter = $"Название LIKE '%{((TextBox)sender).Text}%'";
        }

        private void btnTakeBook_Click(object sender, EventArgs e)
        {
            if (knigiBindingSource.Current != null)
            {
                try
                {
                    // 1. Получаем ID выбранной клиентом книги
                    DataRowView currentBook = (DataRowView)knigiBindingSource.Current;
                    int bookId = Convert.ToInt32(currentBook["ID_Книги"]);

                    // ID Читателя (пока фиксированный)
                    int readerId = 1;

                    // 2. Инициализируем адаптер и таблицу
                    var vidachaAdapter = new WindowsFormsApp1.БД_БиблеотекаDataSetTableAdapters.VidachaTableAdapter();
                    var vidachaTable = new WindowsFormsApp1.БД_БиблеотекаDataSet.VidachaDataTable();

                    // 3. Создаем пустую строку через NewVidachaRow
                    var newRow = vidachaTable.NewVidachaRow();

                    // 4. Заполняем поля напрямую через свойства по их именам (это обойдет ошибки с типами)
                    newRow.ID_Книги = bookId;
                    newRow.ID_Читателя = readerId;
                    newRow.Дата_выдачи = DateTime.Now;
                    newRow.Плановая_дата_возврата = DateTime.Now.AddDays(14);

                    // Задаем пустое значение для фактической даты возврата через специальный сгенерированный метод
                    newRow.SetФактическая_дата_возвратаNull();

                    // 5. Добавляем заполненную строку в таблицу и сохраняем в БД
                    vidachaTable.AddVidachaRow(newRow);
                    vidachaAdapter.Update(vidachaTable);

                    MessageBox.Show("Книга успешно оформлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при оформлении выдачи: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Сначала выберите книгу из таблицы!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
