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
    public partial class Menu2 : UserControl
    {   
   
        public Menu2()
        {
            InitializeComponent();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void книгиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile books = new Profile(TrpoContext.CurrentUser);
            this.Hide(); 
            books.Show(); 
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orders books = new Orders(TrpoContext.CurrentUser);
            this.Hide();
            books.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Startt books = new Startt();
            this.Hide(); 
            books.Show(); 
        }
    }
}
