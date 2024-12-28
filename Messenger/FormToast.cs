using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messenger
{ 
    public partial class FormToast : Form
    {
        int toastX, toastY;
        public FormToast()
        {
            InitializeComponent();
        }

        private void FormToast_Load(object sender, EventArgs e)
        {
            Position();
        }

        private void tostTimer_Tick(object sender, EventArgs e)
        {
            toastY -= 10;
            this.Location = new Point(toastX, toastY);
            if (toastY <= 950)
            {
                tostTimer.Stop();
                toastTimerHide.Start();
            }
        }
        int y = 100;
        private void toastTimerHide_Tick(object sender, EventArgs e)
        {
            y--;
            if (y <= 0)
            {
                toastY += 1;
                this.Location = new Point(toastX, toastY += 10);
                if (toastY > 1000)
                {
                    y = 100;
                    this.Close();
                }
            }
        }

        private void Position()
        {
            int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            toastX = ScreenWidth - this.Width - 5;
            toastY = ScreenHeight - this.Height + 70;

            this.Location = new Point(toastX, toastY);

        }
    }
}
