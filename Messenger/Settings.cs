using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Messenger.Settings;

namespace Messenger
{
    public partial class Settings : Form
    {

        public class UserNewProfile
        {
            public UserNewProfile()
            {
            }

            public UserNewProfile(string phoneNumber, DateTime dateOfBirth, string id, string login, string password, string name, string surname, string patronymic, string email, int gender, int status, string tcpEndpoint, Image photo)
            {
                PhoneNumber = phoneNumber;
                this.dateOfBirth = dateOfBirth;
                Id = id;
                Login = login;
                Password = password;
                Name = name;
                Surname = surname;
                Patronymic = patronymic;
                Email = email;
                Gender = gender;
                Status = status;
                TcpEndpoint = tcpEndpoint;
                Photo = photo;
            }

            public string PhoneNumber { get; set; }
            public DateTime dateOfBirth { get; set; }
            public string Id { get; set; }
            public string Login { get; set; }
            public string Password { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Patronymic { get; set; }
            public string Email { get; set; }
            public int Gender { get; set; }
            public int Status { get; set; }
            public string TcpEndpoint { get; set; }
            public Image Photo { get; set; }

        }

        

        public Settings()
        {
            InitializeComponent();
            
        }
        public static UserNewProfile userNewProfile;
        private void Settings_Load(object sender, EventArgs e)
        {
            TbxName.Text = FormUsers.currentUser.Name;
            TbxSurname.Text = FormUsers.currentUser.Surname;
            TbxPatron.Text = FormUsers.currentUser.Patronymic;
            TbxEmail.Text = FormUsers.currentUser.Email;
            TbxDataBith.Text = FormUsers.currentUser.dateOfBirth.ToString("dd.MM.yyyy");
            TbxLogin.Text = FormUsers.currentUser.Login;
            TbxPassword.Text = FormUsers.currentUser.Password;
            TbxNumber.Text = FormUsers.currentUser.PhoneNumber;
            int gender = FormUsers.currentUser.Gender;
            switch (gender)
            {
                case 1:
                    SwitchGender.Checked = false; break;
                case 0:
                    SwitchGender.Checked = true; break;
            }
            PictureBoxPhoto.Image = FormUsers.currentUser.Photo;
        }

        private void CbxPasswordView_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxPasswordView.Checked)
            {
                TbxPassword.UseSystemPasswordChar = false; // Отключаем скрытие символов
                TbxPassword.PasswordChar = '\0';
            }
            else
            {
                TbxPassword.UseSystemPasswordChar = true; // Включаем скрытие символов
            }
        }

        private void BtnDeletePhoto_Click(object sender, EventArgs e)
        {
            PictureBoxPhoto.Image = null;
        }
        private bool ValidatePassword(string password)
        {
            if (password.Length < 8)
                return false;

            bool hasUpperCase = false;
            bool hasLowerCase = false;
            bool hasDigit = false;
            bool hasSpecialChar = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpperCase = true;
                else if (char.IsLower(c)) hasLowerCase = true;
                else if (char.IsDigit(c)) hasDigit = true;
                else if (!char.IsLetterOrDigit(c)) hasSpecialChar = true;
            }

            return hasUpperCase && hasLowerCase && hasDigit && hasSpecialChar;
        }
        // проверка Email
        private bool ValidateEmail(string email)
        {
            // Регулярное выражение для проверки правильности email
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }
        private bool ValidateDate(string date)
        {
            // Регулярное выражение для проверки формата даты "день.месяц.год"
            string pattern = @"^(0[1-9]|[12][0-9]|3[01])\.(0[1-9]|1[0-2])\.(19|20)\d\d$";

            // Проверка, соответствует ли введенная строка формату
            if (!Regex.IsMatch(date, pattern))
            {
                return false;
            }

            // Проверка, является ли дата допустимой (например, 31 февраля не существует)
            DateTime parsedDate;
            if (!DateTime.TryParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
            {
                return false;
            }

            return true;
        }
        private bool ValidatePhoneNumber(string phoneNumber)
        {
            // Регулярное выражение для проверки номера телефона в формате +7 123 456 7890
            string pattern = @"^\+7\s?\d{3}\s?\d{3}\s?\d{4}$";

            // Проверка, соответствует ли введенная строка формату
            return Regex.IsMatch(phoneNumber, pattern);
        }
        private bool ValidateLogin(string login)
        {
            // Регулярное выражение для проверки логина
            string pattern = @"^[a-zA-Z0-9_]{3,20}$";

            // Проверка, соответствует ли введенная строка формату
            return Regex.IsMatch(login, pattern);
        }
        private bool ValidateName(string name)
        {
            // Регулярное выражение для проверки имени, фамилии и отчества
            string pattern = @"^[a-zA-Zа-яА-ЯёЁ]{2,50}$";

            // Проверка, соответствует ли введенная строка формату
            return Regex.IsMatch(name, pattern);
        }

        public event Action<UserNewProfile> UserProfileUpdated;
        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Проверка, что все текстовые поля заполнены
            if (string.IsNullOrWhiteSpace(TbxName.Text) ||
                string.IsNullOrWhiteSpace(TbxSurname.Text) ||
                string.IsNullOrWhiteSpace(TbxPatron.Text) ||
                string.IsNullOrWhiteSpace(TbxLogin.Text) ||
                string.IsNullOrWhiteSpace(TbxPassword.Text) ||
                string.IsNullOrWhiteSpace(TbxEmail.Text) ||
                string.IsNullOrWhiteSpace(TbxDataBith.Text) ||
                string.IsNullOrWhiteSpace(TbxNumber.Text))
            {
                MessageBox.Show("Заполните все поля для ввода!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Проверка корректности имени
            if (!ValidateName(TbxName.Text.Trim()))
            {
                MessageBox.Show("Неверный формат имени. Имя может содержать только буквы и быть длиной от 2 до 50 символов.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка корректности фамилии
            if (!ValidateName(TbxSurname.Text.Trim()))
            {
                MessageBox.Show("Неверный формат фамилии. Фамилия может содержать только буквы и быть длиной от 2 до 50 символов.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка корректности отчества
            if (!ValidateName(TbxPatron.Text.Trim()))
            {
                MessageBox.Show("Неверный формат отчества. Отчество может содержать только буквы и быть длиной от 2 до 50 символов.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка корректности email
            if (!ValidateEmail(TbxEmail.Text.Trim()))
            {
                MessageBox.Show("Некорректный формат email!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка корректности даты рождения
            if (!ValidateDate(TbxDataBith.Text.Trim()))
            {
                MessageBox.Show("Неверный формат даты. Пожалуйста, введите дату в формате день.месяц.год.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка корректности номера телефона
            if (!ValidatePhoneNumber(TbxNumber.Text.Trim()))
            {
                MessageBox.Show("Неверный формат номера телефона. Пожалуйста, введите номер в формате +7 123 456 7890.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка корректности логина
            if (!ValidateLogin(TbxLogin.Text.Trim()))
            {
                MessageBox.Show("Неверный формат логина. Логин может содержать только буквы, цифры, нижнее подчеркивание и быть длиной от 3 до 20 символов.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка корректности пароля
            if (!ValidatePassword(TbxPassword.Text.Trim()))
            {
                MessageBox.Show("Пароль должен содержать минимум 8 символов, включая заглавные и строчные буквы, цифры и специальные символы!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Определение пола
            string gender = SwitchGender.Checked ? "0" : "1";


            // Обновление текущего профиля пользователя
            userNewProfile = new UserNewProfile
            {
                Name = TbxName.Text.Trim(),
                Surname = TbxSurname.Text.Trim(),
                Patronymic = TbxPatron.Text.Trim(),
                Email = TbxEmail.Text.Trim(),
                dateOfBirth = DateTime.Parse(TbxDataBith.Text.Trim()),
                Login = TbxLogin.Text.Trim(),
                Password = TbxPassword.Text.Trim(),
                PhoneNumber = TbxNumber.Text.Trim(),
                Gender = int.Parse(gender),

            };

            string imagePath = Path.Combine(Application.StartupPath, "account.png");
            if (PictureBoxPhoto.Image == null)
            {
                if (File.Exists(imagePath))
                {
                    userNewProfile.Photo = Image.FromFile(imagePath);
                    PictureBoxPhoto.Image = Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show("Изображение не найдено в папке с программой.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Обновление данных пользователя в базе данных
            using (var connection = new SqlConnection(FormUsers.sqlConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand($@"
            UPDATE Users SET 
                Login = @Login,
                Password = @Password,
                Name = @Name,
                Surname = @Surname,
                Patronymic = @Patronymic,
                DateOfBirth = @DateOfBirth,
                PhoneNumber = @PhoneNumber,
                Email = @Email,
                Gender = @Gender,
                Photo = @Photo
            WHERE Id_User = @Id_User", connection))
                {
                    command.Parameters.AddWithValue("@Login", TbxLogin.Text.Trim());
                    command.Parameters.AddWithValue("@Password", TbxPassword.Text.Trim());
                    command.Parameters.AddWithValue("@Name", TbxName.Text.Trim());
                    command.Parameters.AddWithValue("@Surname", TbxSurname.Text.Trim());
                    command.Parameters.AddWithValue("@Patronymic", TbxPatron.Text.Trim());
                    command.Parameters.AddWithValue("@DateOfBirth", DateTime.Parse(TbxDataBith.Text.Trim()));
                    command.Parameters.AddWithValue("@PhoneNumber", TbxNumber.Text.Trim());
                    command.Parameters.AddWithValue("@Email", TbxEmail.Text.Trim());
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@Id_User", FormUsers.currentUser.Id);

                    if (PictureBoxPhoto.Image != null)
                    {
                        command.Parameters.Add("@Photo", SqlDbType.VarBinary).Value = ImageToByteArray(PictureBoxPhoto.Image);
                    }
                    else
                    {
                        command.Parameters.Add("@Photo", SqlDbType.VarBinary).Value = DBNull.Value;
                    }

                    command.ExecuteNonQuery();
                }
            }      
            
            FormUsers.currentUser.Name = userNewProfile.Name;
            FormUsers.currentUser.Surname = userNewProfile.Surname;
            FormUsers.currentUser.Patronymic = userNewProfile.Patronymic;
            FormUsers.currentUser.Email = userNewProfile.Email;
            FormUsers.currentUser.PhoneNumber = userNewProfile.PhoneNumber;
            FormUsers.currentUser.Password = userNewProfile.Password;
            FormUsers.currentUser.Login = userNewProfile.Login;
            FormUsers.currentUser.Photo = PictureBoxPhoto.Image;
            FormUsers.currentUser.dateOfBirth = DateTime.Parse(TbxDataBith.Text);

            // Обновление изображения на главной форме
            // Важно обновить UI
            FormMain frm = (FormMain)Application.OpenForms["FormMain"];
            FormUsers frmUsers = (FormUsers)Application.OpenForms["FormUsers"];
            frm.PbxPhoto.Image = PictureBoxPhoto.Image;
            frm.Invoke(new Action(() => frm.PbxPhoto.Refresh()));
            frmUsers.Invoke(new Action(() => frmUsers.SendMessage($@"#GetIdUserFromDB {FormUsers.currentUser.Login} {FormUsers.currentUser.Password}")));
            frmUsers.Invoke(new Action(() => frmUsers.SendMessage("#LoadFromDBUsersInOnline")));
            MessageBox.Show("Данные успешно обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            
        }
        private byte[] ImageToByteArray(Image image)
        {
            if (image == null)
            {
                return null;
            }

            using (var ms = new MemoryStream())
            {
                try
                {
                    // Создаем копию изображения, чтобы избежать проблем с заблокированным потоком
                    using (var tempImage = new Bitmap(image))
                    {
                        tempImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // Используйте стандартный формат изображения
                    }
                    return ms.ToArray();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при преобразовании изображения: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        private void tbxLoadPhoto_Click(object sender, EventArgs e)
        {
            // Настройка OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
            openFileDialog.Title = "Выберите изображение";

            // Открытие диалогового окна для выбора файла
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Отображение выбранного изображения в PictureBox
                    PictureBoxPhoto.Image = Image.FromFile(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке изображения: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
