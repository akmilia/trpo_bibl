using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace trpo_bibl 
{   
    
    public partial class UserAdd : Form
    {   
        private TrpoContext _context;
        public UserAdd()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _context = new TrpoContext();
            textBoxF.MaxLength = 20; // Максимальное количество символов для фамилии
            textBoxN.MaxLength = 20; // Максимальное количество символов для имени
            textBoxO.MaxLength = 20; // Максимальное количество символов для отчества
            textBoxEmail.MaxLength = 100; // Максимальное количество символов для email
            textBox5.MaxLength = 11; // Максимальное количество символов для номера телефона
            textBox6.MaxLength = 30; // Максимальное количество символов для пароля

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxF.Text) || string.IsNullOrEmpty(textBoxN.Text) || string.IsNullOrEmpty(textBoxO.Text)
            || string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrEmpty(textBox5.Text)
               || string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Проверка валидности email
            if (!IsValidEmail(textBoxEmail.Text.Trim()))
            {
                MessageBox.Show("Пожалуйста, введите корректный адрес электронной почты.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка валидности номера телефона
            if (!IsValidPhoneNumber(textBox5.Text.Trim()))
            {
                MessageBox.Show("Пожалуйста, введите корректный номер телефона (11 цифр).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка валидности пароля
            if (!IsValidPassword(textBox6.Text.Trim()))
            {
                MessageBox.Show("Пароль должен содержать как минимум 8 символов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var user = new Пользователи
                {
                    Email = textBoxEmail.Text.Trim(),
                    Телефон = textBox5.Text.Trim(),
                    Имя = textBoxN.Text.Trim(),
                    Фамилия = textBoxF.Text.Trim(),
                    Отчество = textBoxO.Text.Trim(),
                    Пароль = textBox6.Text.Trim(),
                    Статус = "Читатель"

                };
                _context.Пользователиs.Add(user);
                _context.SaveChanges();



                Users profile = new Users();
                this.Close();
                profile.Show();

            }
            catch
            {
                MessageBox.Show("Mistake, not found");
            }
        }

        

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Length != 11)
            {
                return false;
            }
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$");
        }
        private bool IsValidPassword(string password)
        {
            // Проверка минимальной длины пароля
            if (password.Length < 8)
            {
                return false;
            }
    
            return true;
        }

        private void UserAdd_Load(object sender, EventArgs e)
        {

        }

        private void textBoxF_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(textBoxF);
        }

        private void textBoxN_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(textBoxN);
        }

        private void textBoxO_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(textBoxO);
        }
        private void ValidateInput(System.Windows.Forms.TextBox textBox)
        {
            string pattern = @"^[a-zA-Zа-яА-ЯёЁ0-9-]{1,20}$"; // Регулярное выражение для проверки имени

            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, pattern))
            {
                MessageBox.Show("Пожалуйста, введите корректное значение (не более 20 символов, допустимы только буквы, цифры и дефис).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Text = string.Empty;
            }
        }
    }
}
