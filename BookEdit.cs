using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace trpo_bibl
{
    public partial class BookEdit : Form
    {
        private TrpoContext _context;
        Книги книга = new Книги();
        public BookEdit(Книги книга)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;


            _context = new TrpoContext();
            this.книга = книга;

            if (книга != null)
            {
                label6.Text = $"ID = {книга.IdКнига} ";
                textBoxName.Text = книга.Название;
                textBoxAuthor.Text = книга.Автор;
                textBoxJanre.Text = книга.Жанр;
                textBoxYear.Text = книга.ГодИздания; 
                textBoxNumber.Text = Convert.ToString( книга.КолВо);
            }
        }

        private void BookEdit_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {  
            try
            {
                Upd(книга);

                MessageBox.Show("Информация успешно обновлена");

                Books books = new Books();
                this.Close(); // Скрываем Form1
                books.Show(); // Показываем ur 
            } 
            catch
            {
                MessageBox.Show("Введены неверные данные. Попробуйте еще раз ");
            }
            
        } 

        public void Upd(Книги книга)
        {
            if (книга != null)
            {
                книга.Название = textBoxName.Text;
                книга.Автор = textBoxAuthor.Text;
                книга.Жанр = textBoxJanre.Text;
                книга.ГодИздания = textBoxYear.Text;
                книга.КолВо = int.Parse(textBoxNumber.Text);
                _context.Книгиs.Update(книга);
                _context.SaveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Del(книга);

            Books books = new Books();
            this.Close(); 
            books.Show(); 
        }

        public void Del(Книги книга)
        {

            if (книга != null)
            {
                _context.Книгиs.Remove(книга);
                _context.SaveChanges(); // Сохранение изменений в базе данных
            }

        }
    }
    }

