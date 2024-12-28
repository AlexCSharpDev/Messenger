namespace Messenger
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.PanelLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.PbxPhoto = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.PanelUp2 = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnMessagers = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSetings = new Guna.UI2.WinForms.Guna2Button();
            this.BtnProf = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.PanelFill = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.BtnMinim = new Guna.UI2.WinForms.Guna2ControlBox();
            this.PanelUp = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.PanelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPhoto)).BeginInit();
            this.PanelUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(244)))));
            this.PanelLeft.Controls.Add(this.PbxPhoto);
            this.PanelLeft.Controls.Add(this.PanelUp2);
            this.PanelLeft.Controls.Add(this.BtnMessagers);
            this.PanelLeft.Controls.Add(this.BtnSetings);
            this.PanelLeft.Controls.Add(this.BtnProf);
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.Location = new System.Drawing.Point(0, 0);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(187, 568);
            this.PanelLeft.TabIndex = 3;
            // 
            // PbxPhoto
            // 
            this.PbxPhoto.BackColor = System.Drawing.Color.Transparent;
            this.PbxPhoto.Image = ((System.Drawing.Image)(resources.GetObject("PbxPhoto.Image")));
            this.PbxPhoto.ImageRotate = 0F;
            this.PbxPhoto.Location = new System.Drawing.Point(23, 53);
            this.PbxPhoto.Name = "PbxPhoto";
            this.PbxPhoto.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PbxPhoto.Size = new System.Drawing.Size(139, 135);
            this.PbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxPhoto.TabIndex = 5;
            this.PbxPhoto.TabStop = false;
            this.PbxPhoto.UseTransparentBackground = true;
            // 
            // PanelUp2
            // 
            this.PanelUp2.BorderColor = System.Drawing.Color.Black;
            this.PanelUp2.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelUp2.Location = new System.Drawing.Point(0, 0);
            this.PanelUp2.Name = "PanelUp2";
            this.PanelUp2.Size = new System.Drawing.Size(187, 33);
            this.PanelUp2.TabIndex = 4;
            // 
            // BtnMessagers
            // 
            this.BtnMessagers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMessagers.Animated = true;
            this.BtnMessagers.BackColor = System.Drawing.Color.Transparent;
            this.BtnMessagers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnMessagers.Checked = true;
            this.BtnMessagers.CheckedState.ForeColor = System.Drawing.Color.White;
            this.BtnMessagers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnMessagers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnMessagers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnMessagers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnMessagers.FillColor = System.Drawing.Color.Transparent;
            this.BtnMessagers.FocusedColor = System.Drawing.Color.White;
            this.BtnMessagers.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.BtnMessagers.ForeColor = System.Drawing.Color.Black;
            this.BtnMessagers.Image = ((System.Drawing.Image)(resources.GetObject("BtnMessagers.Image")));
            this.BtnMessagers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnMessagers.ImageOffset = new System.Drawing.Point(15, 0);
            this.BtnMessagers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnMessagers.Location = new System.Drawing.Point(0, 194);
            this.BtnMessagers.Name = "BtnMessagers";
            this.BtnMessagers.Size = new System.Drawing.Size(187, 44);
            this.BtnMessagers.TabIndex = 3;
            this.BtnMessagers.Text = "Сообщения";
            this.BtnMessagers.UseTransparentBackground = true;
            this.BtnMessagers.Click += new System.EventHandler(this.BtnMessagers_Click);
            // 
            // BtnSetings
            // 
            this.BtnSetings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSetings.Animated = true;
            this.BtnSetings.BackColor = System.Drawing.Color.Transparent;
            this.BtnSetings.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnSetings.CheckedState.ForeColor = System.Drawing.Color.White;
            this.BtnSetings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSetings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSetings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSetings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSetings.FillColor = System.Drawing.Color.Transparent;
            this.BtnSetings.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.BtnSetings.ForeColor = System.Drawing.Color.Black;
            this.BtnSetings.Image = ((System.Drawing.Image)(resources.GetObject("BtnSetings.Image")));
            this.BtnSetings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnSetings.ImageOffset = new System.Drawing.Point(15, 0);
            this.BtnSetings.Location = new System.Drawing.Point(0, 325);
            this.BtnSetings.Name = "BtnSetings";
            this.BtnSetings.Size = new System.Drawing.Size(187, 45);
            this.BtnSetings.TabIndex = 2;
            this.BtnSetings.Text = "Настройки";
            this.BtnSetings.Visible = false;
            this.BtnSetings.Click += new System.EventHandler(this.BtnSetings_Click);
            // 
            // BtnProf
            // 
            this.BtnProf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnProf.Animated = true;
            this.BtnProf.BackColor = System.Drawing.Color.Transparent;
            this.BtnProf.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnProf.CheckedState.ForeColor = System.Drawing.Color.White;
            this.BtnProf.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnProf.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnProf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnProf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnProf.FillColor = System.Drawing.Color.Transparent;
            this.BtnProf.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.BtnProf.ForeColor = System.Drawing.Color.Black;
            this.BtnProf.Image = ((System.Drawing.Image)(resources.GetObject("BtnProf.Image")));
            this.BtnProf.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnProf.ImageOffset = new System.Drawing.Point(12, 0);
            this.BtnProf.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnProf.Location = new System.Drawing.Point(0, 261);
            this.BtnProf.Name = "BtnProf";
            this.BtnProf.Size = new System.Drawing.Size(187, 45);
            this.BtnProf.TabIndex = 1;
            this.BtnProf.Text = "Личный кабинет";
            this.BtnProf.TextOffset = new System.Drawing.Point(15, 0);
            this.BtnProf.Click += new System.EventHandler(this.BtnProf_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 5;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // PanelFill
            // 
            this.PanelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFill.Location = new System.Drawing.Point(187, 33);
            this.PanelFill.Name = "PanelFill";
            this.PanelFill.Size = new System.Drawing.Size(1015, 535);
            this.PanelFill.TabIndex = 5;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.Animated = true;
            this.BtnClose.FillColor = System.Drawing.Color.Transparent;
            this.BtnClose.IconColor = System.Drawing.Color.Black;
            this.BtnClose.Location = new System.Drawing.Point(964, 2);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(45, 29);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.Animated = true;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(833, 2);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 4;
            this.guna2ControlBox2.Visible = false;
            // 
            // BtnMinim
            // 
            this.BtnMinim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinim.Animated = true;
            this.BtnMinim.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.BtnMinim.FillColor = System.Drawing.Color.Transparent;
            this.BtnMinim.IconColor = System.Drawing.Color.Black;
            this.BtnMinim.Location = new System.Drawing.Point(918, 2);
            this.BtnMinim.Name = "BtnMinim";
            this.BtnMinim.Size = new System.Drawing.Size(45, 29);
            this.BtnMinim.TabIndex = 5;
            // 
            // PanelUp
            // 
            this.PanelUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.PanelUp.Controls.Add(this.BtnMinim);
            this.PanelUp.Controls.Add(this.guna2ControlBox2);
            this.PanelUp.Controls.Add(this.BtnClose);
            this.PanelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelUp.Location = new System.Drawing.Point(187, 0);
            this.PanelUp.Name = "PanelUp";
            this.PanelUp.Size = new System.Drawing.Size(1015, 33);
            this.PanelUp.TabIndex = 4;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.PanelUp;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.PanelUp2;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1202, 568);
            this.Controls.Add(this.PanelFill);
            this.Controls.Add(this.PanelUp);
            this.Controls.Add(this.PanelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.PanelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxPhoto)).EndInit();
            this.PanelUp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelLeft;
        private Guna.UI2.WinForms.Guna2Panel PanelUp2;
        private Guna.UI2.WinForms.Guna2Button BtnMessagers;
        private Guna.UI2.WinForms.Guna2Button BtnSetings;
        private Guna.UI2.WinForms.Guna2Button BtnProf;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel PanelFill;
        private Guna.UI2.WinForms.Guna2Panel PanelUp;
        private Guna.UI2.WinForms.Guna2ControlBox BtnMinim;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox BtnClose;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        public Guna.UI2.WinForms.Guna2CirclePictureBox PbxPhoto;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
    }
}