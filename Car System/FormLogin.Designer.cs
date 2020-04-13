namespace Car_System
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.popupNotifier1 = new Tulpep.NotificationWindow.PopupNotifier();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.swicht = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.txtUsu = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCon = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_tipodeconexion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // popupNotifier1
            // 
            this.popupNotifier1.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.popupNotifier1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.popupNotifier1.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.popupNotifier1.ButtonHoverColor = System.Drawing.Color.Black;
            this.popupNotifier1.ContentColor = System.Drawing.Color.White;
            this.popupNotifier1.ContentFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popupNotifier1.ContentHoverColor = System.Drawing.Color.White;
            this.popupNotifier1.ContentText = null;
            this.popupNotifier1.Delay = 5000;
            this.popupNotifier1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.popupNotifier1.Image = null;
            this.popupNotifier1.IsRightToLeft = false;
            this.popupNotifier1.OptionsMenu = null;
            this.popupNotifier1.Size = new System.Drawing.Size(400, 100);
            this.popupNotifier1.TitleColor = System.Drawing.Color.White;
            this.popupNotifier1.TitleFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popupNotifier1.TitleText = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(78, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.IconSize = 25;
            this.btnCerrar.Location = new System.Drawing.Point(270, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Rotation = 0D;
            this.btnCerrar.Size = new System.Drawing.Size(30, 34);
            this.btnCerrar.TabIndex = 29;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 20;
            this.btnLogin.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(119)))));
            this.btnLogin.ActiveForecolor = System.Drawing.Color.White;
            this.btnLogin.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(119)))));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "Login";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleCornerRadius = 20;
            this.btnLogin.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(179)))));
            this.btnLogin.IdleForecolor = System.Drawing.Color.White;
            this.btnLogin.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(119)))));
            this.btnLogin.Location = new System.Drawing.Point(31, 314);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(240, 56);
            this.btnLogin.TabIndex = 30;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // swicht
            // 
            this.swicht.BackColor = System.Drawing.Color.Transparent;
            this.swicht.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("swicht.BackgroundImage")));
            this.swicht.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.swicht.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swicht.Location = new System.Drawing.Point(95, 273);
            this.swicht.Name = "swicht";
            this.swicht.OffColor = System.Drawing.Color.Gray;
            this.swicht.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(179)))));
            this.swicht.Size = new System.Drawing.Size(35, 20);
            this.swicht.TabIndex = 31;
            this.swicht.Value = true;
            this.swicht.OnValueChange += new System.EventHandler(this.swicht_OnValueChange);
            // 
            // txtUsu
            // 
            this.txtUsu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.txtUsu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsu.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsu.ForeColor = System.Drawing.Color.White;
            this.txtUsu.Location = new System.Drawing.Point(51, 143);
            this.txtUsu.MaxLength = 50;
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.ShortcutsEnabled = false;
            this.txtUsu.Size = new System.Drawing.Size(200, 24);
            this.txtUsu.TabIndex = 1;
            this.txtUsu.Text = "Usuario";
            this.txtUsu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsu.Enter += new System.EventHandler(this.txtUsu_Enter);
            this.txtUsu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Entrar_KeyPress);
            this.txtUsu.Leave += new System.EventHandler(this.txtUsu_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(179)))));
            this.panel1.Location = new System.Drawing.Point(51, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 3);
            this.panel1.TabIndex = 2;
            // 
            // txtCon
            // 
            this.txtCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.txtCon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCon.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCon.ForeColor = System.Drawing.Color.White;
            this.txtCon.Location = new System.Drawing.Point(51, 214);
            this.txtCon.MaxLength = 50;
            this.txtCon.Name = "txtCon";
            this.txtCon.ShortcutsEnabled = false;
            this.txtCon.Size = new System.Drawing.Size(200, 24);
            this.txtCon.TabIndex = 4;
            this.txtCon.Text = "Contraseña";
            this.txtCon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCon.TextChanged += new System.EventHandler(this.txtCon_TextChanged);
            this.txtCon.Enter += new System.EventHandler(this.txtCon_Enter);
            this.txtCon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Entrar_KeyPress);
            this.txtCon.Leave += new System.EventHandler(this.txtCon_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(179)))));
            this.panel3.Location = new System.Drawing.Point(51, 238);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 3);
            this.panel3.TabIndex = 5;
            // 
            // lbl_tipodeconexion
            // 
            this.lbl_tipodeconexion.AutoSize = true;
            this.lbl_tipodeconexion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipodeconexion.ForeColor = System.Drawing.Color.White;
            this.lbl_tipodeconexion.Location = new System.Drawing.Point(136, 272);
            this.lbl_tipodeconexion.Name = "lbl_tipodeconexion";
            this.lbl_tipodeconexion.Size = new System.Drawing.Size(51, 21);
            this.lbl_tipodeconexion.TabIndex = 27;
            this.lbl_tipodeconexion.Text = "Local";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(302, 384);
            this.Controls.Add(this.swicht);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lbl_tipodeconexion);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtCon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtUsu);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogin_FormClosed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Tulpep.NotificationWindow.PopupNotifier popupNotifier1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
        private Bunifu.Framework.UI.BunifuiOSSwitch swicht;
        private System.Windows.Forms.TextBox txtUsu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_tipodeconexion;
    }
}