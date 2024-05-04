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
    public partial class Orders : Form
    {
        private TrpoContext _context;
        public Пользователи user1;
        public Orders(Пользователи user)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _context = new TrpoContext();
            user1 = user;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Книга", "Книга");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void Orders_Load(object sender, EventArgs e)
        {
            //var orders = _context.Заказыs.Where(u=> u.ПользователиIdПользователя == user1.IdПользователя).ToList();
            //dataGridView1.DataSource = orders; 
            using (_context)
            {
                var orders = _context.Заказыs.Where(u => u.ПользователиIdПользователя == user1.IdПользователя).ToList(); 
                

                dataGridView1.Rows.Clear();

                foreach (var user in orders)
                {
                    var book = _context.Книгиs.FirstOrDefault(u => u.IdКнига == user.КнигиIdКнига);
                    int rowIndex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowIndex].Cells["Id"].Value = user.IdЗаказы;
                    dataGridView1.Rows[rowIndex].Cells["Книга"].Value = book.Название;


                }
            }
        } 
    }
}
