using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace trpo_bibl
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        public void Menu_Load(object sender, EventArgs e)
        {

        }
        private void книгиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            this.Hide();
            books.Show();
        }

        private void читателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users ur = new Users();
            this.Hide(); // Скрываем Form1
            ur.Show(); // Показываем ur
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Startt books = new Startt();
            this.Hide(); // Скрываем Form1
            books.Show(); // Показываем ur
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderAdd orderAdd = new OrderAdd();
            orderAdd.Show();

        }
    }
}
