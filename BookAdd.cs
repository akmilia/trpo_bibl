using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace trpo_bibl
{
    public partial class BookAdd : Form
    {
        private TrpoContext _context;

        public BookAdd()
        {
            InitializeComponent();
            textBoxName.MaxLength = 40; // Максимальное количество символов для фамилии
            textBoxAuthor.MaxLength = 30; // Максимальное количество символов для имени
            textBoxJanre.MaxLength = 20; // Максимальное количество символов для отчества
            textBoxYear.MaxLength = 4; // Максимальное количество символов для email
            textBoxNumber.MaxLength = 10; // Максимальное количество символов для номера телефона
            
            this.StartPosition = FormStartPosition.CenterScreen;


            _context = new TrpoContext();
          
        }

        private void BookAdd_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxAuthor.Text) || string.IsNullOrEmpty(textBoxJanre.Text)
                || string.IsNullOrEmpty(textBoxYear.Text) || string.IsNullOrEmpty(textBoxNumber.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Convert.ToInt32(textBoxNumber.Text) < 1)
            {
                MessageBox.Show("Ошибка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Создание новой книги
            Книги newBook = new Книги
            {
                Название = textBoxName.Text,
                Автор = textBoxAuthor.Text,
                Жанр = textBoxJanre.Text,
                ГодИздания = textBoxYear.Text,
                Статус = "Наличие",
                КолВо = Convert.ToInt32(textBoxNumber.Text)
            };

            // Добавление новой книги в контекст данных
            _context.Книгиs.Add(newBook);
            _context.SaveChanges(); // Сохранение изменений в базе данных

            MessageBox.Show("Книга успешно добавлена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Books books = new Books();
            this.Close(); // Скрываем Form1
            books.Show(); // Показываем ur
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            this.Close(); // Скрываем Form1
            books.Show(); // Показываем ur
        }

    }
}
