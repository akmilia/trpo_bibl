using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace trpo_bibl
{
    public partial class Profile : Form
    {
        private TrpoContext _context;

        public Profile(Пользователи user)
        { 
            InitializeComponent();
            _context = new TrpoContext();
            this.StartPosition = FormStartPosition.CenterScreen;

            TrpoContext.CurrentUser = user;

            Menu2 us1 = new Menu2();
        
            label1.Text += user.Фамилия;
            label2.Text += user.Имя;
            label3.Text += user.Отчество;
            label4.Text += user.Email;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            var книги = _context.Книгиs.Select(п => new { п.IdКнига, п.Название, п.Автор, п.Жанр, п.ГодИздания, п.КолВо, п.Статус }).ToList();
            dataGridView1.DataSource = книги;
            // Установка AutoSizeColumnsMode для dataGridView1
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //тут можно систему позаамороченее сделать, но зачем? правильно
            //но на всякий случай пусть останется
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idКнига"].Value);
                Книги selectedBook = _context.Книгиs.FirstOrDefault(book => book.IdКнига == id);

                if (selectedBook != null)
                {
                    DialogResult result = MessageBox.Show("Вы уверены, что хотите создать новую запись в таблице Orders?", "Подтверждение", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        // Создание новой записи в таблице Orders с использованием данных из DataGridView
                        using (_context)
                        {
                            Заказы newOrder = new Заказы
                            {
                                ПользователиIdПользователя = TrpoContext.CurrentUser.IdПользователя,
                                КнигиIdКнига = id,
                                Срок = DateTime.Now
                            };

                            _context.Заказыs.Add(newOrder);
                            _context.SaveChanges();
                        }
                    }

                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            button2.Click += button2_Click;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string searchText = textBox3.Text.Trim();

            var книги = _context.Книгиs
                                .Where(п => п.Название.Contains(searchText) || п.Автор.Contains(searchText) || п.Жанр.Contains(searchText))
                                .Select(п => new { п.IdКнига, п.Название, п.Автор, п.Жанр, п.ГодИздания, п.КолВо, п.Статус })
                                .ToList();

            dataGridView1.DataSource = книги;

            //string searchKeyword = textBox3.Text.Trim();

            //// Фильтрация данных в DataGridView по введенному названию книги
            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //    if (row.Cells["Название"].Value.ToString().Contains(searchKeyword))
            //    {
            //        row.Visible = true;
            //    }
            //    else
            //    {
            //        row.Visible = false;
            //    }
            //}
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
