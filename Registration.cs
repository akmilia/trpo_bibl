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
    public partial class Registration : Form
    {
        private TrpoContext _context;
        public Registration()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _context = new TrpoContext();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxF.Text) || string.IsNullOrEmpty(textBoxImya.Text) || string.IsNullOrEmpty(textBoxO.Text)
                || string.IsNullOrEmpty(textBoxE.Text) || string.IsNullOrEmpty(textBoxT.Text)
                || string.IsNullOrEmpty(textBoxPas.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Проверка валидности email
            if (!IsValidEmail(textBoxE.Text.Trim()))
            {
                MessageBox.Show("Пожалуйста, введите корректный адрес электронной почты.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка валидности номера телефона
            if (!IsValidPhoneNumber(textBoxT.Text.Trim()))
            {
                MessageBox.Show("Пожалуйста, введите корректный номер телефона (11 цифр).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка валидности пароля
            if (!IsValidPassword(textBoxPas.Text.Trim()))
            {
                MessageBox.Show("Пароль должен содержать как минимум 8 символов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {
                var user = new Пользователи
                {
                    Email = textBoxE.Text.Trim(),
                    Телефон = textBoxT.Text.Trim(),
                    Имя = textBoxImya.Text.Trim(),
                    Фамилия = textBoxF.Text.Trim(),
                    Отчество = textBoxO.Text.Trim(),
                    Пароль = textBoxPas.Text.Trim(),
                    Статус = "Читатель"

                };
                _context.Пользователиs.Add(user);
                _context.SaveChanges();



                Profile profile = new Profile(user);
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

        // Метод для проверки корректности номера телефона
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Length != 11)
            {
                return false;
            }
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$");
        }

        // Метод для проверки корректности пароля
        private bool IsValidPassword(string password)
        {
            return password.Length >= 8;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxF_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(textBoxF);
        }

        private void textBoxImya_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(textBoxImya);
        }

        private void textBoxO_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(textBoxO);
        }
        // Метод для валидации имени, фамилии и отчества
        private void ValidateInput(TextBox textBox)
        {
            string pattern = @"^[a-zA-Zа-яА-ЯёЁ0-9-]{1,20}$"; // Регулярное выражение для проверки имени

            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, pattern))
            {
                MessageBox.Show("Пожалуйста, введите корректное значение (не более 20 символов, допустимы только буквы, цифры и дефис).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Text = string.Empty;
            }
        }
        private void textBoxE_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxT_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPas_TextChanged(object sender, EventArgs e)
        {
            textBoxPas.UseSystemPasswordChar = true;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

}
