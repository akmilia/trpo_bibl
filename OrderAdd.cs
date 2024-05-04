using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace trpo_bibl
{
    public partial class OrderAdd : Form
    {
        private TrpoContext _context;
       
        public OrderAdd()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _context = new TrpoContext();

            var books = _context.Книгиs
          .Where(b => b.Статус == "Наличие")
          .ToList();

            var users = _context.Пользователиs
          .Where(b => b.Статус != "Библиотекарь")
          .ToList();

            comboBox1.DataSource = books;
            comboBox1.DisplayMember = "Название";
            comboBox1.ValueMember = "IdКнига";

            comboBox2.DataSource = users;
            comboBox2.DisplayMember = "Email";
            comboBox2.ValueMember = "IdПользователя";
        }

        private void OrderAdd_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Получить выбранный идентификатор книги из combobox1
            int bookId = (int)comboBox1.SelectedValue;

            // Получить выбранный идентификатор пользователя из combobox2
            int userId = (int)comboBox2.SelectedValue;

            var order = new Заказы
            {
                ПользователиIdПользователя = userId,

                Срок = DateTime.Now,

                КнигиIdКнига = bookId
            };

            _context.Заказыs.Add(order);
            _context.SaveChanges(); // Сохранение изменений в базе данных
            this.Close();
        }
    }
}
