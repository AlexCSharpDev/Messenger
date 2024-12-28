using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messenger
{
    public partial class FormCreateAccount : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private Thread receiveThread;
        private bool isRunning;
        public FormCreateAccount()
        {
            InitializeComponent();
        }
        public static string flag = "";
        private void SendMessage(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
                return;

            try
            {
                byte[] messageBytes = Encoding.UTF8.GetBytes(message);
                byte[] sizeBytes = BitConverter.GetBytes(messageBytes.Length);

                stream.Write(sizeBytes, 0, sizeBytes.Length);
                stream.Write(messageBytes, 0, messageBytes.Length);
                stream.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при отправке сообщения: {ex.Message}");
            }
        }
        private void ReceiveMessages()
        {
            try
            {
                while (isRunning)
                {
                    if (stream.DataAvailable)
                    {
                        byte[] sizeBuffer = new byte[4];
                        stream.Read(sizeBuffer, 0, sizeBuffer.Length);
                        int messageSize = BitConverter.ToInt32(sizeBuffer, 0);

                        byte[] messageBuffer = new byte[messageSize];
                        stream.Read(messageBuffer, 0, messageBuffer.Length);
                        string message = Encoding.UTF8.GetString(messageBuffer);

                        ProcessServerMessage(message);
                    }
                }
            }
            catch (Exception ex)
            {
                if (isRunning)
                {
                    MessageBox.Show($"Ошибка при чтении сообщения: {ex.Message}");
                }
            }
        }

        private void ProcessServerMessage(string message)
        {
            if (message.StartsWith("#completereg"))
            {
                string newMessage = message.Substring("#completereg ".Length);

                switch (newMessage)
                {
                    case "1":
                        MessageBox.Show("Аккаунт создан!", "Внимание!");
                        break;
                    case "2":
                        MessageBox.Show("Аккаунт с таким логином уже существует!", "Внимание!");
                        break;
                    case "0":
                        MessageBox.Show("Произошла ошибка при создании аккаунта, попробуйте позже!", "Внимание!");
                        break;
                }
            }
        }

        private void ConnectToServer()
        {
            try
            {
                client = new TcpClient("127.0.0.1", 8888);
                stream = client.GetStream();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при подключении к серверу: {ex.Message}");
            }
        }
        // проверка пароля 
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
        private async Task WaitForResponseAsync()
        {
            await Task.Delay(10000);
        }
        private async void BtnCreateAccount_Click(object sender, EventArgs e)
        {

            // Проверка заполнения всех полей
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

            //if (!ValidateName(TbxName.Text.Trim()))
            //{
            //    MessageBox.Show("Неверный формат имени. Имя может содержать только буквы и быть длиной от 2 до 50 символов.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //if (!ValidateName(TbxSurname.Text.Trim()))
            //{
            //    MessageBox.Show("Неверный формат фамилии. Фамилия может содержать только буквы и быть длиной от 2 до 50 символов.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //if (!ValidateName(TbxPatron.Text.Trim()))
            //{
            //    MessageBox.Show("Неверный формат отчества. Отчество может содержать только буквы и быть длиной от 2 до 50 символов.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //if (!ValidateEmail(TbxEmail.Text.Trim()))
            //{
            //    MessageBox.Show("Некорректный формат email!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //if (!ValidateDate(TbxDataBith.Text.Trim()))
            //{
            //    MessageBox.Show("Неверный формат даты. Пожалуйста, введите дату в формате день.месяц.год.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //if (!ValidatePhoneNumber(TbxNumber.Text.Trim()))
            //{
            //    MessageBox.Show("Неверный формат номера телефона. Пожалуйста, введите номер в формате +7 123 456 7890.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //if (!ValidateLogin(TbxLogin.Text))
            //{
            //    MessageBox.Show("Неверный формат логина. Логин может содержать только буквы, цифры, нижнее подчеркивание и быть длиной от 3 до 20 символов.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //if (!ValidatePassword(TbxPassword.Text))
            //{
            //    MessageBox.Show("Пароль должен содержать минимум 8 символов, включая заглавные и строчные буквы, цифры и специальные символы!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            ConnectToServer();
            isRunning = true;
            receiveThread = new Thread(ReceiveMessages) { IsBackground = true };
            receiveThread.Start();

            string gender = SwitchGender.Checked ? "0" : "1";

            SendMessage($@"#RegistrationAccount {TbxName.Text.Trim()} {TbxSurname.Text.Trim()} 
{TbxPatron.Text.Trim()} {TbxLogin.Text.Trim()} {TbxPassword.Text.Trim()} {TbxDataBith.Text.Trim()} {TbxNumber.Text.Trim()} {TbxEmail.Text} {gender}");

            if (PictureBoxPhoto.Image != null)
            {
                string photoBase64 = Convert.ToBase64String(GetImageBytes(PictureBoxPhoto.Image));
                SendMessage($@"#SavePhotoUsers {TbxLogin.Text} {TbxPassword.Text} {photoBase64}");
            }

            await WaitForResponseAsync();

            isRunning = false;
            receiveThread.Join();
        }
        private byte[] GetImageBytes(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
        private void FormCreateAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            isRunning = false;
            if (receiveThread != null && receiveThread.IsAlive)
            {
                receiveThread.Join();
            }

            stream?.Close();
            client?.Close();
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

        private void BtnDeletePhoto_Click(object sender, EventArgs e)
        {
            PictureBoxPhoto.Image = null;
        }
    }
}
