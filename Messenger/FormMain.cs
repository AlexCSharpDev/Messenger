using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Messenger.Settings;

namespace Messenger
{
    public partial class FormMain : Form
    {

        private FormUsers formUsers; // Переменная для хранения экземпляра FormUsers
        private Form activeForm = null;
        bool activeFormUsers = false;
        public static Image PhotoProfile = null;
        public FormMain()
        {
            InitializeComponent();
            this.FormClosing += FormMain_FormClosing;
            formUsers = new FormUsers(); // Создаем экземпляр FormUsers
        }

        // Конструктор с параметрами
        
        private void openForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Hide();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelFill.Controls.Add(childForm);
            PanelFill.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void BtnMessagers_Click(object sender, EventArgs e)
        {          
            // Открываем форму FormUsers
            openForm(formUsers);
            activeFormUsers = true;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (activeFormUsers && formUsers != null && !formUsers.IsDisposed)
            {
                formUsers.Close(); // Закрываем форму FormUsers при закрытии главной формы
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {        
            BtnMessagers_Click(sender, e);
            FormUsers.cellDgvUserTcpEndPoint = "";
            FormUsers.selectedUserId = "";
            FormUsers.selectedUserFIO = "";

        }

        private void BtnSetings_Click(object sender, EventArgs e)
        {
            openForm(new Settings());
        }

        private void BtnProf_Click(object sender, EventArgs e)
        {
            openForm(new Settings());
        }
      

    }
}
