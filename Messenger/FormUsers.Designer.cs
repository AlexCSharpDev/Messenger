namespace Messenger
{
    partial class FormUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsers));
            this.TbxMessenger = new Guna.UI2.WinForms.Guna2TextBox();
            this.DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.GunaElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.PanelUsers = new Guna.UI2.WinForms.Guna2Panel();
            this.DgvUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ColumUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TcpEndPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnSendMessage = new Guna.UI2.WinForms.Guna2ImageButton();
            this.TbxMessageText = new Guna.UI2.WinForms.Guna2TextBox();
            this.ListMessages = new System.Windows.Forms.RichTextBox();
            this.BtnSendFile = new Guna.UI2.WinForms.Guna2ImageButton();
            this.PanelMessages = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).BeginInit();
            this.PanelMessages.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbxMessenger
            // 
            this.TbxMessenger.Animated = true;
            this.TbxMessenger.BorderRadius = 10;
            this.TbxMessenger.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbxMessenger.DefaultText = "";
            this.TbxMessenger.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbxMessenger.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbxMessenger.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxMessenger.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxMessenger.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxMessenger.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.TbxMessenger.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxMessenger.Location = new System.Drawing.Point(6, 476);
            this.TbxMessenger.Name = "TbxMessenger";
            this.TbxMessenger.PasswordChar = '\0';
            this.TbxMessenger.PlaceholderText = "Введите сообщение";
            this.TbxMessenger.SelectedText = "";
            this.TbxMessenger.Size = new System.Drawing.Size(562, 38);
            this.TbxMessenger.TabIndex = 0;
            // 
            // DragControl2
            // 
            this.DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl2.UseTransparentDrag = true;
            // 
            // DragControl
            // 
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.UseTransparentDrag = true;
            // 
            // GunaElipse
            // 
            this.GunaElipse.TargetControl = this;
            // 
            // PanelUsers
            // 
            this.PanelUsers.Controls.Add(this.DgvUsers);
            this.PanelUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelUsers.Location = new System.Drawing.Point(0, 0);
            this.PanelUsers.Name = "PanelUsers";
            this.PanelUsers.Size = new System.Drawing.Size(213, 607);
            this.PanelUsers.TabIndex = 3;
            // 
            // DgvUsers
            // 
            this.DgvUsers.AllowUserToAddRows = false;
            this.DgvUsers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.DgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.DgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.DgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumUserName,
            this.Id,
            this.TcpEndPoint});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvUsers.DefaultCellStyle = dataGridViewCellStyle16;
            this.DgvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvUsers.Location = new System.Drawing.Point(3, 0);
            this.DgvUsers.MultiSelect = false;
            this.DgvUsers.Name = "DgvUsers";
            this.DgvUsers.ReadOnly = true;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Verdana", 9.75F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.DgvUsers.RowHeadersVisible = false;
            this.DgvUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DgvUsers.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.DgvUsers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvUsers.Size = new System.Drawing.Size(210, 602);
            this.DgvUsers.TabIndex = 0;
            this.DgvUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvUsers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvUsers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DgvUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.DgvUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvUsers.ThemeStyle.HeaderStyle.Height = 23;
            this.DgvUsers.ThemeStyle.ReadOnly = true;
            this.DgvUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.DgvUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgvUsers.ThemeStyle.RowsStyle.Height = 22;
            this.DgvUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsers_CellClick);
            this.DgvUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsers_CellDoubleClick);
            // 
            // ColumUserName
            // 
            this.ColumUserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.ColumUserName.DefaultCellStyle = dataGridViewCellStyle15;
            this.ColumUserName.FillWeight = 105.5838F;
            this.ColumUserName.HeaderText = "Пользователи онлайн";
            this.ColumUserName.Name = "ColumUserName";
            this.ColumUserName.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // TcpEndPoint
            // 
            this.TcpEndPoint.HeaderText = "TcpEndPoint";
            this.TcpEndPoint.Name = "TcpEndPoint";
            this.TcpEndPoint.ReadOnly = true;
            this.TcpEndPoint.Visible = false;
            // 
            // BtnSendMessage
            // 
            this.BtnSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSendMessage.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.BtnSendMessage.CheckedState.ImageSize = new System.Drawing.Size(32, 32);
            this.BtnSendMessage.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.BtnSendMessage.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.BtnSendMessage.Image = ((System.Drawing.Image)(resources.GetObject("BtnSendMessage.Image")));
            this.BtnSendMessage.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnSendMessage.ImageRotate = 0F;
            this.BtnSendMessage.ImageSize = new System.Drawing.Size(32, 32);
            this.BtnSendMessage.Location = new System.Drawing.Point(923, 536);
            this.BtnSendMessage.Name = "BtnSendMessage";
            this.BtnSendMessage.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.BtnSendMessage.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.BtnSendMessage.Size = new System.Drawing.Size(64, 54);
            this.BtnSendMessage.TabIndex = 0;
            this.BtnSendMessage.Click += new System.EventHandler(this.BtnSendMessage_Click);
            // 
            // TbxMessageText
            // 
            this.TbxMessageText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxMessageText.Animated = true;
            this.TbxMessageText.BorderRadius = 5;
            this.TbxMessageText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbxMessageText.DefaultText = "";
            this.TbxMessageText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbxMessageText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbxMessageText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxMessageText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxMessageText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxMessageText.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.TbxMessageText.ForeColor = System.Drawing.Color.Black;
            this.TbxMessageText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxMessageText.Location = new System.Drawing.Point(12, 545);
            this.TbxMessageText.Name = "TbxMessageText";
            this.TbxMessageText.PasswordChar = '\0';
            this.TbxMessageText.PlaceholderText = "Введите сообщение";
            this.TbxMessageText.SelectedText = "";
            this.TbxMessageText.Size = new System.Drawing.Size(907, 38);
            this.TbxMessageText.TabIndex = 1;
            // 
            // ListMessages
            // 
            this.ListMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListMessages.BackColor = System.Drawing.Color.White;
            this.ListMessages.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ListMessages.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListMessages.Location = new System.Drawing.Point(3, 0);
            this.ListMessages.Name = "ListMessages";
            this.ListMessages.ReadOnly = true;
            this.ListMessages.Size = new System.Drawing.Size(914, 539);
            this.ListMessages.TabIndex = 2;
            this.ListMessages.Text = "";
            this.ListMessages.TextChanged += new System.EventHandler(this.ListMessages_TextChanged);
            // 
            // BtnSendFile
            // 
            this.BtnSendFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSendFile.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnSendFile.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.BtnSendFile.Image = ((System.Drawing.Image)(resources.GetObject("BtnSendFile.Image")));
            this.BtnSendFile.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnSendFile.ImageRotate = 0F;
            this.BtnSendFile.ImageSize = new System.Drawing.Size(32, 32);
            this.BtnSendFile.Location = new System.Drawing.Point(923, 460);
            this.BtnSendFile.Name = "BtnSendFile";
            this.BtnSendFile.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.BtnSendFile.Size = new System.Drawing.Size(64, 54);
            this.BtnSendFile.TabIndex = 3;
            this.BtnSendFile.Visible = false;
            this.BtnSendFile.Click += new System.EventHandler(this.BtnSendFile_Click);
            // 
            // PanelMessages
            // 
            this.PanelMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelMessages.Controls.Add(this.BtnSendFile);
            this.PanelMessages.Controls.Add(this.ListMessages);
            this.PanelMessages.Controls.Add(this.TbxMessageText);
            this.PanelMessages.Controls.Add(this.BtnSendMessage);
            this.PanelMessages.Location = new System.Drawing.Point(219, 12);
            this.PanelMessages.Name = "PanelMessages";
            this.PanelMessages.Size = new System.Drawing.Size(999, 595);
            this.PanelMessages.TabIndex = 4;
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1218, 607);
            this.Controls.Add(this.PanelMessages);
            this.Controls.Add(this.PanelUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUsers_FormClosing);
            this.Load += new System.EventHandler(this.FormUsers_Load);
            this.PanelUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).EndInit();
            this.PanelMessages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox TbxMessenger;
        private Guna.UI2.WinForms.Guna2DragControl DragControl2;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2Elipse GunaElipse;
        private Guna.UI2.WinForms.Guna2Panel PanelUsers;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2Panel PanelMessages;
        private Guna.UI2.WinForms.Guna2ImageButton BtnSendFile;
        private System.Windows.Forms.RichTextBox ListMessages;
        private Guna.UI2.WinForms.Guna2TextBox TbxMessageText;
        private Guna.UI2.WinForms.Guna2ImageButton BtnSendMessage;
        public Guna.UI2.WinForms.Guna2DataGridView DgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TcpEndPoint;
    }
}