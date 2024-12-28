namespace Messenger
{
    partial class FormCreateAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.PanelUp = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnMinim = new Guna.UI2.WinForms.Guna2ControlBox();
            this.BtnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.TbxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.TbxSurname = new Guna.UI2.WinForms.Guna2TextBox();
            this.TbxPatron = new Guna.UI2.WinForms.Guna2TextBox();
            this.TbxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.TbxEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.TbxDataBith = new Guna.UI2.WinForms.Guna2TextBox();
            this.PictureBoxPhoto = new Guna.UI2.WinForms.Guna2PictureBox();
            this.BtnCreateAccount = new Guna.UI2.WinForms.Guna2Button();
            this.tbxLoadPhoto = new Guna.UI2.WinForms.Guna2Button();
            this.TbxNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.SwitchGender = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.BtnDeletePhoto = new Guna.UI2.WinForms.Guna2Button();
            this.PanelUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // PanelUp
            // 
            this.PanelUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.PanelUp.Controls.Add(this.label3);
            this.PanelUp.Controls.Add(this.BtnMinim);
            this.PanelUp.Controls.Add(this.BtnClose);
            this.PanelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelUp.Location = new System.Drawing.Point(0, 0);
            this.PanelUp.Name = "PanelUp";
            this.PanelUp.Size = new System.Drawing.Size(864, 33);
            this.PanelUp.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Регистрация нового пользователя";
            // 
            // BtnMinim
            // 
            this.BtnMinim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinim.Animated = true;
            this.BtnMinim.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.BtnMinim.FillColor = System.Drawing.Color.Transparent;
            this.BtnMinim.IconColor = System.Drawing.Color.Black;
            this.BtnMinim.Location = new System.Drawing.Point(762, 2);
            this.BtnMinim.Name = "BtnMinim";
            this.BtnMinim.Size = new System.Drawing.Size(45, 29);
            this.BtnMinim.TabIndex = 5;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.Animated = true;
            this.BtnClose.FillColor = System.Drawing.Color.Transparent;
            this.BtnClose.IconColor = System.Drawing.Color.Black;
            this.BtnClose.Location = new System.Drawing.Point(813, 2);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(45, 29);
            this.BtnClose.TabIndex = 3;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.PanelUp;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // TbxName
            // 
            this.TbxName.Animated = true;
            this.TbxName.AutoRoundedCorners = true;
            this.TbxName.BorderRadius = 14;
            this.TbxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbxName.DefaultText = "";
            this.TbxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxName.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.TbxName.ForeColor = System.Drawing.Color.Black;
            this.TbxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxName.Location = new System.Drawing.Point(15, 52);
            this.TbxName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TbxName.Name = "TbxName";
            this.TbxName.PasswordChar = '\0';
            this.TbxName.PlaceholderText = "Имя";
            this.TbxName.SelectedText = "";
            this.TbxName.Size = new System.Drawing.Size(260, 31);
            this.TbxName.TabIndex = 6;
            // 
            // TbxSurname
            // 
            this.TbxSurname.Animated = true;
            this.TbxSurname.AutoRoundedCorners = true;
            this.TbxSurname.BorderRadius = 14;
            this.TbxSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbxSurname.DefaultText = "";
            this.TbxSurname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbxSurname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbxSurname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxSurname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxSurname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxSurname.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.TbxSurname.ForeColor = System.Drawing.Color.Black;
            this.TbxSurname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxSurname.Location = new System.Drawing.Point(15, 93);
            this.TbxSurname.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TbxSurname.Name = "TbxSurname";
            this.TbxSurname.PasswordChar = '\0';
            this.TbxSurname.PlaceholderText = "Фамилия";
            this.TbxSurname.SelectedText = "";
            this.TbxSurname.Size = new System.Drawing.Size(260, 31);
            this.TbxSurname.TabIndex = 7;
            // 
            // TbxPatron
            // 
            this.TbxPatron.Animated = true;
            this.TbxPatron.AutoRoundedCorners = true;
            this.TbxPatron.BorderRadius = 14;
            this.TbxPatron.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbxPatron.DefaultText = "";
            this.TbxPatron.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbxPatron.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbxPatron.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxPatron.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxPatron.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxPatron.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.TbxPatron.ForeColor = System.Drawing.Color.Black;
            this.TbxPatron.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxPatron.Location = new System.Drawing.Point(15, 134);
            this.TbxPatron.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TbxPatron.Name = "TbxPatron";
            this.TbxPatron.PasswordChar = '\0';
            this.TbxPatron.PlaceholderText = "Отчество";
            this.TbxPatron.SelectedText = "";
            this.TbxPatron.Size = new System.Drawing.Size(260, 31);
            this.TbxPatron.TabIndex = 8;
            // 
            // TbxPassword
            // 
            this.TbxPassword.Animated = true;
            this.TbxPassword.AutoRoundedCorners = true;
            this.TbxPassword.BorderRadius = 14;
            this.TbxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbxPassword.DefaultText = "";
            this.TbxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxPassword.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.TbxPassword.ForeColor = System.Drawing.Color.Black;
            this.TbxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxPassword.Location = new System.Drawing.Point(303, 93);
            this.TbxPassword.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TbxPassword.Name = "TbxPassword";
            this.TbxPassword.PasswordChar = '\0';
            this.TbxPassword.PlaceholderText = "Пароль";
            this.TbxPassword.SelectedText = "";
            this.TbxPassword.Size = new System.Drawing.Size(260, 31);
            this.TbxPassword.TabIndex = 10;
            // 
            // TbxEmail
            // 
            this.TbxEmail.Animated = true;
            this.TbxEmail.AutoRoundedCorners = true;
            this.TbxEmail.BorderRadius = 14;
            this.TbxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbxEmail.DefaultText = "";
            this.TbxEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbxEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbxEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxEmail.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.TbxEmail.ForeColor = System.Drawing.Color.Black;
            this.TbxEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxEmail.Location = new System.Drawing.Point(15, 202);
            this.TbxEmail.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TbxEmail.Name = "TbxEmail";
            this.TbxEmail.PasswordChar = '\0';
            this.TbxEmail.PlaceholderText = "Email";
            this.TbxEmail.SelectedText = "";
            this.TbxEmail.Size = new System.Drawing.Size(260, 31);
            this.TbxEmail.TabIndex = 11;
            // 
            // TbxDataBith
            // 
            this.TbxDataBith.Animated = true;
            this.TbxDataBith.AutoRoundedCorners = true;
            this.TbxDataBith.BorderRadius = 14;
            this.TbxDataBith.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbxDataBith.DefaultText = "";
            this.TbxDataBith.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbxDataBith.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbxDataBith.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxDataBith.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxDataBith.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxDataBith.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.TbxDataBith.ForeColor = System.Drawing.Color.Black;
            this.TbxDataBith.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxDataBith.Location = new System.Drawing.Point(15, 243);
            this.TbxDataBith.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TbxDataBith.Name = "TbxDataBith";
            this.TbxDataBith.PasswordChar = '\0';
            this.TbxDataBith.PlaceholderText = "Дата рождения";
            this.TbxDataBith.SelectedText = "";
            this.TbxDataBith.Size = new System.Drawing.Size(260, 31);
            this.TbxDataBith.TabIndex = 12;
            // 
            // PictureBoxPhoto
            // 
            this.PictureBoxPhoto.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBoxPhoto.FillColor = System.Drawing.Color.Transparent;
            this.PictureBoxPhoto.ImageRotate = 0F;
            this.PictureBoxPhoto.Location = new System.Drawing.Point(595, 52);
            this.PictureBoxPhoto.Name = "PictureBoxPhoto";
            this.PictureBoxPhoto.Size = new System.Drawing.Size(235, 261);
            this.PictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxPhoto.TabIndex = 13;
            this.PictureBoxPhoto.TabStop = false;
            this.PictureBoxPhoto.UseTransparentBackground = true;
            // 
            // BtnCreateAccount
            // 
            this.BtnCreateAccount.Animated = true;
            this.BtnCreateAccount.BackColor = System.Drawing.Color.Transparent;
            this.BtnCreateAccount.BorderColor = System.Drawing.Color.Transparent;
            this.BtnCreateAccount.BorderRadius = 20;
            this.BtnCreateAccount.DefaultAutoSize = true;
            this.BtnCreateAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCreateAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCreateAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCreateAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCreateAccount.FillColor = System.Drawing.Color.Transparent;
            this.BtnCreateAccount.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnCreateAccount.ForeColor = System.Drawing.Color.Black;
            this.BtnCreateAccount.Location = new System.Drawing.Point(344, 378);
            this.BtnCreateAccount.Name = "BtnCreateAccount";
            this.BtnCreateAccount.Size = new System.Drawing.Size(177, 30);
            this.BtnCreateAccount.TabIndex = 14;
            this.BtnCreateAccount.Text = "Создать аккаунт";
            this.BtnCreateAccount.UseTransparentBackground = true;
            this.BtnCreateAccount.Click += new System.EventHandler(this.BtnCreateAccount_Click);
            // 
            // tbxLoadPhoto
            // 
            this.tbxLoadPhoto.Animated = true;
            this.tbxLoadPhoto.BackColor = System.Drawing.Color.Transparent;
            this.tbxLoadPhoto.BorderColor = System.Drawing.Color.Transparent;
            this.tbxLoadPhoto.BorderRadius = 20;
            this.tbxLoadPhoto.DefaultAutoSize = true;
            this.tbxLoadPhoto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tbxLoadPhoto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tbxLoadPhoto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tbxLoadPhoto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tbxLoadPhoto.FillColor = System.Drawing.Color.Transparent;
            this.tbxLoadPhoto.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbxLoadPhoto.ForeColor = System.Drawing.Color.Black;
            this.tbxLoadPhoto.Location = new System.Drawing.Point(629, 319);
            this.tbxLoadPhoto.Name = "tbxLoadPhoto";
            this.tbxLoadPhoto.Size = new System.Drawing.Size(169, 30);
            this.tbxLoadPhoto.TabIndex = 15;
            this.tbxLoadPhoto.Text = "Загрузить фото";
            this.tbxLoadPhoto.UseTransparentBackground = true;
            this.tbxLoadPhoto.Click += new System.EventHandler(this.tbxLoadPhoto_Click);
            // 
            // TbxNumber
            // 
            this.TbxNumber.Animated = true;
            this.TbxNumber.AutoRoundedCorners = true;
            this.TbxNumber.BorderRadius = 14;
            this.TbxNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbxNumber.DefaultText = "";
            this.TbxNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbxNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbxNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxNumber.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.TbxNumber.ForeColor = System.Drawing.Color.Black;
            this.TbxNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxNumber.Location = new System.Drawing.Point(15, 284);
            this.TbxNumber.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TbxNumber.Name = "TbxNumber";
            this.TbxNumber.PasswordChar = '\0';
            this.TbxNumber.PlaceholderText = "Номер телефона";
            this.TbxNumber.SelectedText = "";
            this.TbxNumber.Size = new System.Drawing.Size(260, 31);
            this.TbxNumber.TabIndex = 16;
            // 
            // SwitchGender
            // 
            this.SwitchGender.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SwitchGender.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SwitchGender.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.SwitchGender.CheckedState.InnerColor = System.Drawing.Color.White;
            this.SwitchGender.Location = new System.Drawing.Point(73, 174);
            this.SwitchGender.Name = "SwitchGender";
            this.SwitchGender.Size = new System.Drawing.Size(49, 20);
            this.SwitchGender.TabIndex = 17;
            this.SwitchGender.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.SwitchGender.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.SwitchGender.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.SwitchGender.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(19, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "муж.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(128, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "жен.";
            // 
            // TbxLogin
            // 
            this.TbxLogin.Animated = true;
            this.TbxLogin.AutoRoundedCorners = true;
            this.TbxLogin.BorderRadius = 14;
            this.TbxLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbxLogin.DefaultText = "";
            this.TbxLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbxLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbxLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxLogin.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.TbxLogin.ForeColor = System.Drawing.Color.Black;
            this.TbxLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxLogin.Location = new System.Drawing.Point(303, 52);
            this.TbxLogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TbxLogin.Name = "TbxLogin";
            this.TbxLogin.PasswordChar = '\0';
            this.TbxLogin.PlaceholderText = "Логин";
            this.TbxLogin.SelectedText = "";
            this.TbxLogin.Size = new System.Drawing.Size(260, 31);
            this.TbxLogin.TabIndex = 20;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.label3;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // BtnDeletePhoto
            // 
            this.BtnDeletePhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeletePhoto.Animated = true;
            this.BtnDeletePhoto.BackColor = System.Drawing.Color.Transparent;
            this.BtnDeletePhoto.BorderColor = System.Drawing.Color.Transparent;
            this.BtnDeletePhoto.BorderRadius = 20;
            this.BtnDeletePhoto.DefaultAutoSize = true;
            this.BtnDeletePhoto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDeletePhoto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDeletePhoto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDeletePhoto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDeletePhoto.FillColor = System.Drawing.Color.Transparent;
            this.BtnDeletePhoto.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnDeletePhoto.ForeColor = System.Drawing.Color.Black;
            this.BtnDeletePhoto.Location = new System.Drawing.Point(640, 348);
            this.BtnDeletePhoto.Name = "BtnDeletePhoto";
            this.BtnDeletePhoto.Size = new System.Drawing.Size(153, 30);
            this.BtnDeletePhoto.TabIndex = 36;
            this.BtnDeletePhoto.Text = "Удалить фото";
            this.BtnDeletePhoto.UseTransparentBackground = true;
            this.BtnDeletePhoto.Click += new System.EventHandler(this.BtnDeletePhoto_Click);
            // 
            // FormCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 420);
            this.Controls.Add(this.BtnDeletePhoto);
            this.Controls.Add(this.TbxLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SwitchGender);
            this.Controls.Add(this.TbxNumber);
            this.Controls.Add(this.tbxLoadPhoto);
            this.Controls.Add(this.BtnCreateAccount);
            this.Controls.Add(this.PictureBoxPhoto);
            this.Controls.Add(this.TbxDataBith);
            this.Controls.Add(this.TbxEmail);
            this.Controls.Add(this.TbxPassword);
            this.Controls.Add(this.TbxPatron);
            this.Controls.Add(this.TbxSurname);
            this.Controls.Add(this.TbxName);
            this.Controls.Add(this.PanelUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCreateAccount";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCreateAccount_FormClosing);
            this.PanelUp.ResumeLayout(false);
            this.PanelUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel PanelUp;
        private Guna.UI2.WinForms.Guna2ControlBox BtnMinim;
        private Guna.UI2.WinForms.Guna2ControlBox BtnClose;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2TextBox TbxPatron;
        private Guna.UI2.WinForms.Guna2TextBox TbxSurname;
        private Guna.UI2.WinForms.Guna2TextBox TbxName;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxPhoto;
        private Guna.UI2.WinForms.Guna2TextBox TbxDataBith;
        private Guna.UI2.WinForms.Guna2TextBox TbxEmail;
        private Guna.UI2.WinForms.Guna2TextBox TbxPassword;
        private Guna.UI2.WinForms.Guna2TextBox TbxNumber;
        private Guna.UI2.WinForms.Guna2Button tbxLoadPhoto;
        private Guna.UI2.WinForms.Guna2Button BtnCreateAccount;
        private Guna.UI2.WinForms.Guna2ToggleSwitch SwitchGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TbxLogin;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2Button BtnDeletePhoto;
    }
}