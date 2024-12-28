using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static Messenger.FormUsers;

namespace Messenger
{
    public partial class FormUsers : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private Thread receiveThread;
        private readonly object locker = new object(); // Объект для блокировки доступа к общим ресурсам
        private volatile bool receivingMessages = true; // Флаг для контроля выполнения потока приема сообщений
        private bool isClientConnected = false; // Флаг, указывающий на состояние подключения
        public List<string> lstUsersOnline = new List<string>();

        public class CurrentUser
        {
            public CurrentUser()
            {
            }

            public CurrentUser(string phoneNumber, DateTime dateOfBirth, string id, string login, string password, string name, string surname, string patronymic, string email, int gender, int status, string tcpEndpoint, Image photo)
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
            public Image Photo {  get; set; }

        }

        public static CurrentUser currentUser;
        public static FormUsers Instance { get; private set; }

        public FormUsers()
        {
            InitializeComponent();
            Instance = this;
        }
        public static string sqlConnectionString = $@"";
        public static string Sender = "";
        public void ReceiveMessages() // принятие сообщения от сервера
        {
            try
            {
                while (receivingMessages)
                {
                    byte[] sizeBuffer = new byte[4];
                    int bytesRead = stream.Read(sizeBuffer, 0, sizeBuffer.Length);

                    if (bytesRead == 0)
                    {
                        break;
                    }

                    int messageSize = BitConverter.ToInt32(sizeBuffer, 0);

                    byte[] messageBuffer = new byte[messageSize];
                    bytesRead = stream.Read(messageBuffer, 0, messageBuffer.Length);

                    if (bytesRead == 0)
                    {
                        break;
                    }

                    string message = Encoding.UTF8.GetString(messageBuffer);
                    // получение данных о текущем пользователе 
                    if (message.StartsWith("#GetIdUserFromDB"))
                    {
                        currentUser = new CurrentUser();
                        // Отрезаем начальную часть сообщения, чтобы получить только список пользователей
                        string userIdMessage = message.Substring("#GetIdUserFromDB ".Length);
                        string[] massiveUserDate = userIdMessage.Split(' ');

                        currentUser.Id = massiveUserDate[0];
                        currentUser.TcpEndpoint = massiveUserDate[1];
                        currentUser.Login = massiveUserDate[2];
                        currentUser.Password = massiveUserDate[3];
                        currentUser.Name = massiveUserDate[4];
                        currentUser.Surname = massiveUserDate[5];
                        currentUser.Patronymic = massiveUserDate[6];
                        currentUser.dateOfBirth = DateTime.Parse(massiveUserDate[7]);
                        currentUser.PhoneNumber = massiveUserDate[8];
                        currentUser.Email = massiveUserDate[9];
                        currentUser.Gender = int.Parse(massiveUserDate[10]);
                        currentUser.Status = int.Parse(massiveUserDate[11]);

                        FormMain frm = (FormMain)Application.OpenForms["FormMain"];
                        if (frm != null)
                        {
                            using (var connection = new SqlConnection(sqlConnectionString))
                            {
                                connection.Open();
                                using (var command = new SqlCommand($@"SELECT Photo FROM Users WHERE Id_User = @UserId", connection))
                                {
                                    command.Parameters.AddWithValue("@UserId", currentUser.Id);
                                    using (var reader = command.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            if (!reader.IsDBNull(0)) // Проверяем, есть ли значение в столбце Photo
                                            {
                                                byte[] photoData = (byte[])reader["Photo"]; // Получаем бинарные данные изображения
                                                using (MemoryStream ms = new MemoryStream(photoData))
                                                {
                                                    Image photo = Image.FromStream(ms); // Преобразуем бинарные данные в изображение
                                                    currentUser.Photo = photo;
                                                    frm.PbxPhoto.Image = photo;
                                                }
                                            }
                                            else
                                            {
                                                // Если в базе данных нет фотографии, вы можете отобразить какое-то стандартное изображение или пустое место
                                                frm.PbxPhoto.Image = frm.PbxPhoto.Image;
                                            }
                                        }
                                    }
                                }
                            }
                            // Важно обновить UI
                            frm.Invoke(new Action(() => frm.PbxPhoto.Refresh()));
                        }
                        else
                        {
                            MessageBox.Show("FormMain не открыт.");
                        }


                    }
                    // получение списка пользователи "онлайн"
                    if (message.StartsWith("#OnlineUsers"))
                    {
                        ClearDataGridView();

                        // Отрезаем начальную часть сообщения, чтобы получить только список пользователей
                        string userListMessage = message.Substring("#OnlineUsers ".Length);

                        // Разделяем список пользователей по запятым
                        string[] onlineUsers = userListMessage.Split(',');

                        List<string> lstUserNames = new List<string>(); // Список для имен пользователей
                        List<string> lstUserId = new List<string>(); // Список для Id пользователей
                        List<string> lstTcpEndPoint = new List<string>(); // список для TcpEndPoint пользователей

                        foreach (string user in onlineUsers)
                        {
                            int indexOfColon = user.IndexOf("-");
                            int indexOfDouble = user.IndexOf(';');
                            if (indexOfColon != -1 && indexOfDouble != -1) // Проверяем, что найден символ "-"
                            {
                                string userName = user.Substring(0, indexOfColon); // Имя пользователя
                                string userId = user.Substring(indexOfColon + 1, indexOfDouble - indexOfColon - 1); // Id пользователя
                                string userTcpEndPoint = user.Substring(indexOfDouble + 1);

                                lstUserNames.Add(userName); // Добавляем имя пользователя в список
                                lstUserId.Add(userId); // Добавляем Id пользователя в список
                                lstTcpEndPoint.Add(userTcpEndPoint);
                            }
                        }


                        // Добавляем каждого пользователя в список
                        for (int i = 0; i < lstUserId.Count; i++)
                        {
                            if (lstUserId[i] != currentUser.Id)
                                AddUserToDataGridView(lstUserNames[i], lstUserId[i], lstTcpEndPoint[i]);
                        }

                        //return;
                        //message = "";
                    }
                    
                    if (message.StartsWith("#GetUserSender"))
                    {
                        string readyMessage = message.Substring("#GetUserSender ".Length);
                        Sender = readyMessage;
                    }
                    // получение сообщения от другого пользователя
                    if (message.StartsWith("#SendFromUser"))
                    {
                        string readyMessage = message.Substring("#SendFromUser ".Length);
                        if (selectedUserId != "" && selectedUserId == Sender)
                        {
                            DisplayMessage(readyMessage);
                        }
                        
                    }
                    // получение имени и фамилили пользователя, который отправил сообщение 
                    if (message.StartsWith("#NameAndSurname"))
                    {
                        
                        string messageReady = message.Substring("#NameAndSurname ".Length);
                        string[] Mas = messageReady.Split(' ');

                        if (selectedUserId != Mas[3])
                        {
                            ShowToastMessage($@"{Mas[0]} {Mas[1]}");              
                        }                    
                    }
                    // получение истории сообщений
                    if (message.StartsWith("#GetFullMessageText"))
                    {
                        string messageReady = message.Substring($@"#GetFullMessageText ".Length);
                        string[] mas = messageReady.Split(new string[] { "#message#" }, StringSplitOptions.None);
                        foreach (string s in mas)
                        {
                            string currentFio = currentUser.Name + ' ' + currentUser.Surname + ":";
                            if (s.Contains(currentFio))
                            {
                                // Замена имени и фамилии на "Вы"
                                string replacedMessage = s.Replace(currentFio, "Вы:");
                                DisplayMessage(replacedMessage);
                            }
                            else
                            {
                                DisplayMessage(s);
                            }
                        }
                    }

                    if (message.StartsWith("#ConnectionString"))
                    {
                        sqlConnectionString = message.Substring("#ConnectionString ".Length);
                    }

                    if (!message.StartsWith("#"))
                        DisplayMessage(message);
                }
            }
            catch (IOException ex) when (ex.InnerException is SocketException socketException && socketException.SocketErrorCode == SocketError.Interrupted)
            {
                // Это ожидаемая ошибка, когда сокет закрыт, исключение может быть проигнорировано
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при чтении сообщения: " + ex.Message);
                FormMain frmMain = (FormMain)Application.OpenForms["FormMain"];
                frmMain.Invoke(new Action(() => frmMain.Close()));
            }
        }
        private void ShowToastMessage(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(ShowToastMessage), message);
                return;
            }

            // Создаем новый экземпляр формы FormToast
            FormToast toast = new FormToast();

            // Обновляем текст сообщения
            toast.LblToastMessage.Text = message;

            // Отображаем форму
            toast.Show();
        }
        private void ClearDataGridView()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(ClearDataGridView));
                return;
            }

            DgvUsers.Rows.Clear();
        }
        private void AddUserToDataGridView(string userName, string userId, string userTcpEndPoint)
        {

            if (InvokeRequired)
            {
                Invoke(new Action<string, string, string>(AddUserToDataGridView), userName, userId, userTcpEndPoint);
                return;
            }

            DgvUsers.Rows.Add(userName, userId, userTcpEndPoint);
            DgvUsers.CurrentCell = null;
        }
        private void DisplayMessage(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => DisplayMessage(message)));
            }
            else
            {
                ListMessages.AppendText(message + Environment.NewLine);
            }
        }
        public void SendMessage(string message) // отправка сообщений серверу
        {
            try
            {

                if (client == null || !client.Connected)
                {
                    if (client == null || !client.Connected)
                    {
                        MessageBox.Show("Не удалось подключиться к серверу. Пожалуйста, попробуйте еще раз.");
                        return;
                    }
                }


                if (string.IsNullOrWhiteSpace(message) || client == null || !client.Connected || stream == null || !stream.CanWrite)
                {
                    MessageBox.Show("Соединение с сервером разорвано. Невозможно отправить сообщение.");

                    return;
                }

                byte[] messageBytes = Encoding.UTF8.GetBytes(message);
                byte[] sizeBytes = BitConverter.GetBytes(messageBytes.Length);

                stream.Write(sizeBytes, 0, sizeBytes.Length);
                stream.Write(messageBytes, 0, messageBytes.Length);
                stream.Flush();

                TbxMessageText.Clear();
                if (message.StartsWith("#"))
                {
                    return;
                }
                ListMessages.AppendText($"{message}\n");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при отправке сообщения: " + ex.Message);
            }
        }
        private readonly object closingLock = new object(); // Объект для блокировки доступа при закрытии соединения и формы
        public void CloseConnection()
        {
            try
            {
                // Отправляем сообщение на сервер о закрытии соединения перед фактическим закрытием клиентского соединения
                SendMessage($"#CloseConnection {currentUser.TcpEndpoint}");

                // Закрываем клиентский сокет
                if (client != null)
                {
                    client.Client.Shutdown(SocketShutdown.Both);
                    client.Close();
                    client = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при закрытии соединения: " + ex.Message);
            }
        }
        public void FormUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            receivingMessages = false; // Устанавливаем флаг завершения потока приема сообщений           

            CloseConnection();
          
        }
        private void FormUsers_Load(object sender, EventArgs e)
        {
            try
            {
                if (!isClientConnected) // Проверяем, было ли уже установлено подключение
                {
                    ConnectToServer();
                    stream = client.GetStream();
                    receiveThread = new Thread(ReceiveMessages);
                    receiveThread.Start();

                    if (stream.CanWrite)
                    {                      
                        isClientConnected = true; // Устанавливаем флаг, что подключение установлено

                        SendMessage($@"#UpdateTcpEndPoint {LoginForm.Login} {LoginForm.Password} {client.Client.RemoteEndPoint.ToString()}");
                        SendMessage("#GetSqlStringConnection_9221005");
                        SendMessage($@"#GetIdUserFromDB {LoginForm.Login} {LoginForm.Password}");
                        SendMessage("#LoadFromDBUsersInOnline");
                        
                        DgvUsers.CurrentCell = null;
                    }
                    else
                    {
                        ListMessages.AppendText("Соединение потеряно..." + '\n');
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при инициализации потока: " + ex.Message);
            }
        }
        private void BtnSendMessage_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TbxMessageText.Text) && DgvUsers.CurrentCell != null)
            {
                DisplayMessage($@"({DateTime.Now.ToString("HH:mm")}) Вы: {TbxMessageText.Text}");
                string sendMessage = $@"#SendMessageToUser ({DateTime.Now.ToString("HH:mm")}) {currentUser.Name} {currentUser.Surname}: {TbxMessageText.Text};{selectedUserId} {currentUser.Id}";
                SendMessage(sendMessage);                
            }
        }
        private void BtnSendFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileInfo file = new FileInfo(openFileDialog1.FileName);
                    SendMessage(file.Name + " (см. во вложениях)\n");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при отправке файла: " + ex.Message);
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
        private void ListMessages_TextChanged(object sender, EventArgs e)
        {

        }

        public static string cellDgvUserTcpEndPoint; // хранится адрес выбранного пользователя
        public static string selectedUserId; // хранится Id выбранного пользователя
        public static string selectedUserFIO = "";
        private void DgvUsers_CellClick(object sender, DataGridViewCellEventArgs e) // выбор пользователя из DgvUsers
        {

            cellDgvUserTcpEndPoint = "";
            selectedUserId = "";
            selectedUserFIO = "";

            if (e.RowIndex >= 0)
            {
                ListMessages.Clear();
                DataGridViewRow row = DgvUsers.Rows[e.RowIndex];

                selectedUserId = row.Cells["Id"].Value.ToString().ToString(); // запоминаем его Id
                selectedUserFIO = row.Cells["ColumUserName"].Value.ToString();
                
                if (int.Parse(selectedUserId) > 0)
                {
                    cellDgvUserTcpEndPoint = row.Cells["TcpEndPoint"].Value.ToString();
                    SendMessage($@"#GetFullMessageText {selectedUserId} {currentUser.Id} {currentUser.TcpEndpoint}");
                    //SendMessage($@"#ZM0d_765212 {currentUser.Id} {selectedUserId}");
                }
                else
                {
                    MessageBox.Show("Ошибка при выборе пользователя. Повторите попытку позже.");
                }
            }

        }
        private void DgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DgvUsers.CurrentCell = null;
            ListMessages.Clear();
        }
    }
}
