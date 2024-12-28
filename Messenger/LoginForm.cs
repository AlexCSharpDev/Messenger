using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Messenger
{
    public partial class LoginForm : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private Thread receiveThread;
        private bool authenticationResultReceived;
        private bool isAuthenticated;
        private bool isRunning;
        public static string Login = "";
        public static string Password = "";
        public LoginForm()
        {
            InitializeComponent();           
        }

        private void SendMessage(string message) // отправка сообщений серверу
        {
            try
            {
                if (string.IsNullOrWhiteSpace(message))
                    return;

                byte[] messageBytes = Encoding.UTF8.GetBytes(message);
                byte[] sizeBytes = BitConverter.GetBytes(messageBytes.Length);

                stream.Write(sizeBytes, 0, sizeBytes.Length);
                stream.Write(messageBytes, 0, messageBytes.Length);
                stream.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при отправке сообщения: " + ex.Message);
                return;
            }
        }
        private void ReceiveMessages() // принятие сообщения от сервера
        {
            try
            {
                while (isRunning && !authenticationResultReceived)
                {
                    if (stream.DataAvailable)
                    {
                        byte[] sizeBuffer = new byte[4];
                        stream.Read(sizeBuffer, 0, sizeBuffer.Length);
                        int messageSize = BitConverter.ToInt32(sizeBuffer, 0);

                        byte[] messageBuffer = new byte[messageSize];
                        stream.Read(messageBuffer, 0, messageBuffer.Length);
                        string message = Encoding.UTF8.GetString(messageBuffer);

                        if (message.StartsWith("#CheckAccount"))
                        {
                            string[] checkAcc = message.Split(' ');

                            if (checkAcc.Length >= 2)
                            {
                                isAuthenticated = checkAcc[1] == "1";
                                authenticationResultReceived = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (isRunning)
                {
                    MessageBox.Show("Ошибка при чтении сообщения: " + ex.Message);
                }
            }
        }
        private void ConnectToServer() // подключение к серверу
        {
            try
            {
                client = new TcpClient("127.0.0.1", 8888);
                stream = client.GetStream();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при подключении к серверу: " + ex.Message);
            }
        }

        private void BtnInput_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbxLogin.Text) || string.IsNullOrWhiteSpace(TbxPassword.Text))
            {
                MessageBox.Show("Введите логин и пароль!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Password = TbxPassword.Text.Trim();
            Login = TbxLogin.Text.Trim();

            ConnectToServer();

            authenticationResultReceived = false; // сбрасываем флаг перед новой попыткой авторизации
            isAuthenticated = false; // сбрасываем статус авторизации
            isRunning = true;
            receiveThread = new Thread(ReceiveMessages);
            receiveThread.Start();

            SendMessage($"#CheckAccount {Login} {Password}");

            // Ждем результат аутентификации или превышения времени ожидания
            DateTime startTime = DateTime.Now;
            while (!authenticationResultReceived && (DateTime.Now - startTime).TotalSeconds < 10)
            {
                Application.DoEvents();
            }

            isRunning = false;
            receiveThread.Join();

            if (!isAuthenticated)
            {
                MessageBox.Show("Ошибка аутентификации: неверный логин или пароль!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                // Открытие второй формы
                FormMain formMain = new FormMain();
                this.Hide();
                formMain.ShowDialog();
                this.Show();
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Закрытие первого подключения
            isRunning = false;
            if (receiveThread != null && receiveThread.IsAlive)
            {
                receiveThread.Join();
            }

            if (client != null && client.Connected)
            {
                stream.Close();
                client.Close();
            }
        }

        private void BtnCreateAccount_Click(object sender, EventArgs e)
        {
            FormCreateAccount frmCreate = new FormCreateAccount();
            this.Hide();
            frmCreate.ShowDialog();
            this.Show();
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
    }
}
