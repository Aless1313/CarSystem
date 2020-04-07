namespace Car_System
{
    partial class FormMenuAutosAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuAutosAgregar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMat = new System.Windows.Forms.MaskedTextBox();
            this.asterisco1 = new FontAwesome.Sharp.IconPictureBox();
            this.asterisco3 = new FontAwesome.Sharp.IconPictureBox();
            this.asterisco2 = new FontAwesome.Sharp.IconPictureBox();
            this.txtVIN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCol = new System.Windows.Forms.TextBox();
            this.txtMod = new System.Windows.Forms.TextBox();
            this.txtMar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPropietario = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.popupNotifier1 = new Tulpep.NotificationWindow.PopupNotifier();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asterisco1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asterisco3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asterisco2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.txtMat);
            this.panel1.Controls.Add(this.asterisco1);
            this.panel1.Controls.Add(this.asterisco3);
            this.panel1.Controls.Add(this.asterisco2);
            this.panel1.Controls.Add(this.txtVIN);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtCol);
            this.panel1.Controls.Add(this.txtMod);
            this.panel1.Controls.Add(this.txtMar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblPropietario);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 417);
            this.panel1.TabIndex = 29;
            // 
            // txtMat
            // 
            this.txtMat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMat.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtMat.Location = new System.Drawing.Point(210, 294);
            this.txtMat.Mask = "AAA-AAA-AAA";
            this.txtMat.Name = "txtMat";
            this.txtMat.ShortcutsEnabled = false;
            this.txtMat.Size = new System.Drawing.Size(252, 24);
            this.txtMat.TabIndex = 47;
            this.txtMat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Solo_numeros_y_letras_txt_KeyPress);
            // 
            // asterisco1
            // 
            this.asterisco1.BackColor = System.Drawing.Color.LightGray;
            this.asterisco1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(179)))));
            this.asterisco1.IconChar = FontAwesome.Sharp.IconChar.Asterisk;
            this.asterisco1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(179)))));
            this.asterisco1.IconSize = 24;
            this.asterisco1.Location = new System.Drawing.Point(468, 114);
            this.asterisco1.Name = "asterisco1";
            this.asterisco1.Size = new System.Drawing.Size(24, 24);
            this.asterisco1.TabIndex = 46;
            this.asterisco1.TabStop = false;
            this.asterisco1.Visible = false;
            // 
            // asterisco3
            // 
            this.asterisco3.BackColor = System.Drawing.Color.LightGray;
            this.asterisco3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(179)))));
            this.asterisco3.IconChar = FontAwesome.Sharp.IconChar.Asterisk;
            this.asterisco3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(179)))));
            this.asterisco3.IconSize = 24;
            this.asterisco3.Location = new System.Drawing.Point(468, 294);
            this.asterisco3.Name = "asterisco3";
            this.asterisco3.Size = new System.Drawing.Size(24, 24);
            this.asterisco3.TabIndex = 44;
            this.asterisco3.TabStop = false;
            this.asterisco3.Visible = false;
            // 
            // asterisco2
            // 
            this.asterisco2.BackColor = System.Drawing.Color.LightGray;
            this.asterisco2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(179)))));
            this.asterisco2.IconChar = FontAwesome.Sharp.IconChar.Asterisk;
            this.asterisco2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(179)))));
            this.asterisco2.IconSize = 24;
            this.asterisco2.Location = new System.Drawing.Point(468, 174);
            this.asterisco2.Name = "asterisco2";
            this.asterisco2.Size = new System.Drawing.Size(24, 24);
            this.asterisco2.TabIndex = 43;
            this.asterisco2.TabStop = false;
            this.asterisco2.Visible = false;
            // 
            // txtVIN
            // 
            this.txtVIN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVIN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVIN.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVIN.Location = new System.Drawing.Point(210, 354);
            this.txtVIN.MaxLength = 17;
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.ShortcutsEnabled = false;
            this.txtVIN.Size = new System.Drawing.Size(252, 24);
            this.txtVIN.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(61, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 21);
            this.label7.TabIndex = 40;
            this.label7.Text = "VIN:";
            // 
            // txtCol
            // 
            this.txtCol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCol.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCol.Location = new System.Drawing.Point(210, 234);
            this.txtCol.MaxLength = 30;
            this.txtCol.Name = "txtCol";
            this.txtCol.ShortcutsEnabled = false;
            this.txtCol.Size = new System.Drawing.Size(252, 24);
            this.txtCol.TabIndex = 3;
            this.txtCol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Solo_letras_txt_KeyPress);
            // 
            // txtMod
            // 
            this.txtMod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMod.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMod.Location = new System.Drawing.Point(210, 174);
            this.txtMod.MaxLength = 40;
            this.txtMod.Name = "txtMod";
            this.txtMod.ShortcutsEnabled = false;
            this.txtMod.Size = new System.Drawing.Size(252, 24);
            this.txtMod.TabIndex = 2;
            this.txtMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Solo_numeros_y_letras_txt_KeyPress);
            // 
            // txtMar
            // 
            this.txtMar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMar.Location = new System.Drawing.Point(210, 114);
            this.txtMar.MaxLength = 40;
            this.txtMar.Name = "txtMar";
            this.txtMar.ShortcutsEnabled = false;
            this.txtMar.Size = new System.Drawing.Size(252, 24);
            this.txtMar.TabIndex = 1;
            this.txtMar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Solo_letras_txt_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(61, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 21);
            this.label6.TabIndex = 34;
            this.label6.Text = "Color:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(61, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 21);
            this.label5.TabIndex = 33;
            this.label5.Text = "Matricula:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(61, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 32;
            this.label4.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(62, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = "Marca:";
            // 
            // lblPropietario
            // 
            this.lblPropietario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPropietario.AutoSize = true;
            this.lblPropietario.BackColor = System.Drawing.Color.Transparent;
            this.lblPropietario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropietario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPropietario.Location = new System.Drawing.Point(201, 60);
            this.lblPropietario.Name = "lblPropietario";
            this.lblPropietario.Size = new System.Drawing.Size(98, 21);
            this.lblPropietario.TabIndex = 30;
            this.lblPropietario.Text = "Propietario:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(179)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 39);
            this.panel2.TabIndex = 28;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(158, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Agregar automovil";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.IconSize = 25;
            this.btnCerrar.Location = new System.Drawing.Point(452, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Rotation = 0D;
            this.btnCerrar.Size = new System.Drawing.Size(38, 38);
            this.btnCerrar.TabIndex = 26;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.ActiveBorderThickness = 1;
            this.btnAgregar.ActiveCornerRadius = 20;
            this.btnAgregar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(72)))), ((int)(((byte)(57)))));
            this.btnAgregar.ActiveForecolor = System.Drawing.Color.White;
            this.btnAgregar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(72)))), ((int)(((byte)(57)))));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.ButtonText = "Agregar";
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAgregar.IdleBorderThickness = 1;
            this.btnAgregar.IdleCornerRadius = 20;
            this.btnAgregar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(109)))), ((int)(((byte)(86)))));
            this.btnAgregar.IdleForecolor = System.Drawing.Color.White;
            this.btnAgregar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(72)))), ((int)(((byte)(57)))));
            this.btnAgregar.Location = new System.Drawing.Point(56, 431);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(388, 52);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            // FormMenuAutosAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(500, 488);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenuAutosAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuAutosAgregar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asterisco1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asterisco3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asterisco2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox asterisco3;
        private FontAwesome.Sharp.IconPictureBox asterisco2;
        private System.Windows.Forms.TextBox txtVIN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCol;
        private System.Windows.Forms.TextBox txtMod;
        private System.Windows.Forms.TextBox txtMar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPropietario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAgregar;
        private FontAwesome.Sharp.IconPictureBox asterisco1;
        private System.Windows.Forms.MaskedTextBox txtMat;
        private Tulpep.NotificationWindow.PopupNotifier popupNotifier1;
    }
}