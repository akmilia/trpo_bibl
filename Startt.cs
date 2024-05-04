using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trpo_bibl
{
    public partial class Startt : Form
    {
        private TrpoContext _context;

        public Startt()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            _context = new TrpoContext();
        }

        private void Startt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checkBox1.Checked)
            {
                TrpoContext.CurrentUser = _context.Пользователиs.SingleOrDefault(u => u.Email == textBox1.Text && u.Пароль == textBox2.Text && u.Статус == "Библиотекарь");
                if (TrpoContext.CurrentUser == null)
                {
                    MessageBox.Show("Mistake, not found");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                else
                {
                    AdminProfile profile = new AdminProfile();
                    this.Hide();
                    profile.Show();
                }
            }
            else
            {
                TrpoContext.CurrentUser = _context.Пользователиs.SingleOrDefault(u => u.Email == textBox1.Text && u.Пароль == textBox2.Text && u.Статус == "читатель");
                if (TrpoContext.CurrentUser == null)
                {
                    TrpoContext.CurrentUser = _context.Пользователиs.SingleOrDefault(u => u.Email == textBox1.Text && u.Пароль == textBox2.Text && u.Статус == "Заблокированный");
                    if (TrpoContext.CurrentUser != null)
                    {
                        MessageBox.Show("Sorry, u are blocked");
                    }
                    else
                    {
                        MessageBox.Show("Mistake, not found");
                        textBox1.Text = "";
                        textBox2.Text = "";
                    }

                }
                else
                {
                    Profile profile = new Profile(TrpoContext.CurrentUser);
                    this.Hide();
                    profile.Show();
                }
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration profile = new Registration();
            this.Hide();
            profile.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }
    }
}
