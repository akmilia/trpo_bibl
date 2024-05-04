using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace trpo_bibl
{
    public partial class Books : Form
    {
        private TrpoContext _context;
        public int numb;
        public Books()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;


            _context = new TrpoContext(); // Создание экземпляра контекста EF Core
        }

        public void Books_Load(object sender, EventArgs e)
        {
            var книги = _context.Книгиs.Select(п => new { п.IdКнига, п.Название, п.Автор, п.Жанр, п.ГодИздания, п.КолВо, п.Статус }).ToList();
            dataGridView1.DataSource = книги;
            numb = dataGridView1.RowCount;
            // Установка AutoSizeColumnsMode для dataGridView1
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idКнига"].Value);
                Книги selectedBook = _context.Книгиs.FirstOrDefault(book => book.IdКнига == id);

                if (selectedBook != null)
                {
                    BookEdit bookEditForm = new BookEdit(selectedBook); // Передача выбранной книги в конструктор формы BookEdit
                    this.Close();
                    bookEditForm.Show();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookAdd book = new BookAdd();
            this.Close(); // Скрываем Form1
            book.Show(); // Показываем ur
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.Trim();

            var книги = _context.Книгиs
                                .Where(п => п.Название.Contains(searchText) || п.Автор.Contains(searchText) || п.Жанр.Contains(searchText))
                                .Select(п => new { п.IdКнига, п.Название, п.Автор, п.Жанр, п.ГодИздания, п.КолВо, п.Статус })
                                .ToList();

            dataGridView1.DataSource = книги;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button2.Click += button2_Click;
        }
    }
}
