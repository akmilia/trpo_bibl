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
    public partial class Users : Form
    {
        private TrpoContext _context;
        public Users()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            _context = new TrpoContext();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("IdПользователя", "IdПользователя");
            dataGridView1.Columns.Add("ФИО", "ФИО");
            dataGridView1.Columns.Add("Телефон", "Телефон");
            dataGridView1.Columns.Add("Email", "Email");
            dataGridView1.Columns.Add("Статус", "Статус");
           
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Устанавливаем автоматическое изменение размеров столбцов

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserAdd profile = new UserAdd();
            this.Hide();
            profile.Show();
        }
        private void Users_Load(object sender, EventArgs e)
        {

            using (_context)
            {
                var users = _context.Пользователиs.Where(u => u.Статус != "Библиотекарь").ToList();

                dataGridView1.Rows.Clear();

                foreach (var user in users)
                {
                    int rowIndex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowIndex].Cells["IdПользователя"].Value = user.IdПользователя;
                    dataGridView1.Rows[rowIndex].Cells["ФИО"].Value = user.Имя + " " + user.Фамилия + " " + user.Отчество;
                    dataGridView1.Rows[rowIndex].Cells["Телефон"].Value = user.Телефон;
                    dataGridView1.Rows[rowIndex].Cells["Email"].Value = user.Email;
                    dataGridView1.Rows[rowIndex].Cells["Статус"].Value = user.Статус;

                }
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Startt books = new Startt();
            this.Hide(); 
            books.Show(); 
        }

        private void menu1_Load(object sender, EventArgs e)
        {

        }
    }
}
