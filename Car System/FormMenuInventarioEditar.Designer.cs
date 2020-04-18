namespace Car_System
{
    partial class FormMenuInventarioEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuInventarioEditar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCant = new System.Windows.Forms.NumericUpDown();
            this.asterisco4 = new FontAwesome.Sharp.IconPictureBox();
            this.asterisco3 = new FontAwesome.Sharp.IconPictureBox();
            this.asterisco2 = new FontAwesome.Sharp.IconPictureBox();
            this.asterisco1 = new FontAwesome.Sharp.IconPictureBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.popupNotifier1 = new Tulpep.NotificationWindow.PopupNotifier();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asterisco4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asterisco3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asterisco2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asterisco1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.txtCant);
            this.panel1.Controls.Add(this.asterisco4);
            this.panel1.Controls.Add(this.asterisco3);
            this.panel1.Controls.Add(this.asterisco2);
            this.panel1.Controls.Add(this.asterisco1);
            this.panel1.Controls.Add(this.txtCost);
            this.panel1.Controls.Add(this.txtMarca);
            this.panel1.Controls.Add(this.txtNom);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 300);
            this.panel1.TabIndex = 35;
            // 
            // txtCant
            // 
            this.txtCant.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCant.Location = new System.Drawing.Point(203, 185);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(216, 31);
            this.txtCant.TabIndex = 62;
            this.txtCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Solo_numeros_txt_KeyPress);
            // 
            // asterisco4
            // 
            this.asterisco4.BackColor = System.Drawing.Color.LightGray;
            this.asterisco4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(179)))));
            this.asterisco4.IconChar = FontAwesome.Sharp.IconChar.Asterisk;
            this.asterisco4.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(179)))));
            this.asterisco4.IconSize = 24;
            this.asterisco4.Location = new System.Drawing.Point(425, 248);
            this.asterisco4.Name = "asterisco4";
            this.asterisco4.Size = new System.Drawing.Size(24, 24);
            this.asterisco4.TabIndex = 61;
            this.asterisco4.TabStop = false;
            this.asterisco4.Visible = false;
            // 
            // asterisco3
            // 
            this.asterisco3.BackColor = System.Drawing.Color.LightGray;
            this.asterisco3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(179)))));
            this.asterisco3.IconChar = FontAwesome.Sharp.IconChar.Asterisk;
            this.asterisco3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(179)))));
            this.asterisco3.IconSize = 24;
            this.asterisco3.Location = new System.Drawing.Point(425, 188);
            this.asterisco3.Name = "asterisco3";
            this.asterisco3.Size = new System.Drawing.Size(24, 24);
            this.asterisco3.TabIndex = 60;
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
            this.asterisco2.Location = new System.Drawing.Point(425, 128);
            this.asterisco2.Name = "asterisco2";
            this.asterisco2.Size = new System.Drawing.Size(24, 24);
            this.asterisco2.TabIndex = 59;
            this.asterisco2.TabStop = false;
            this.asterisco2.Visible = false;
            // 
            // asterisco1
            // 
            this.asterisco1.BackColor = System.Drawing.Color.LightGray;
            this.asterisco1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(179)))));
            this.asterisco1.IconChar = FontAwesome.Sharp.IconChar.Asterisk;
            this.asterisco1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(179)))));
            this.asterisco1.IconSize = 24;
            this.asterisco1.Location = new System.Drawing.Point(425, 68);
            this.asterisco1.Name = "asterisco1";
            this.asterisco1.Size = new System.Drawing.Size(24, 24);
            this.asterisco1.TabIndex = 58;
            this.asterisco1.TabStop = false;
            this.asterisco1.Visible = false;
            // 
            // txtCost
            // 
            this.txtCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCost.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(203, 248);
            this.txtCost.MaxLength = 10;
            this.txtCost.Name = "txtCost";
            this.txtCost.ShortcutsEnabled = false;
            this.txtCost.Size = new System.Drawing.Size(216, 24);
            this.txtCost.TabIndex = 57;
            this.txtCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Solo_precios_txt_KeyPress);
            // 
            // txtMarca
            // 
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMarca.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(203, 128);
            this.txtMarca.MaxLength = 30;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ShortcutsEnabled = false;
            this.txtMarca.Size = new System.Drawing.Size(216, 24);
            this.txtMarca.TabIndex = 56;
            this.txtMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Solo_letras_txt_KeyPress);
            // 
            // txtNom
            // 
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNom.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(203, 68);
            this.txtNom.MaxLength = 35;
            this.txtNom.Name = "txtNom";
            this.txtNom.ShortcutsEnabled = false;
            this.txtNom.Size = new System.Drawing.Size(216, 24);
            this.txtNom.TabIndex = 55;
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Solo_letras_txt_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(50, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 21);
            this.label6.TabIndex = 54;
            this.label6.Text = "Costo unitario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(50, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 53;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(50, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 52;
            this.label3.Text = "Marca:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(50, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 51;
            this.label2.Text = "Nombre:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(179)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 39);
            this.panel2.TabIndex = 28;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(177, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Editar Pieza";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
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
            this.btnCerrar.Location = new System.Drawing.Point(430, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Rotation = 0D;
            this.btnCerrar.Size = new System.Drawing.Size(38, 38);
            this.btnCerrar.TabIndex = 26;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ActiveBorderThickness = 1;
            this.btnGuardar.ActiveCornerRadius = 20;
            this.btnGuardar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(72)))), ((int)(((byte)(57)))));
            this.btnGuardar.ActiveForecolor = System.Drawing.Color.White;
            this.btnGuardar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(72)))), ((int)(((byte)(57)))));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.ButtonText = "Guardar Cambios";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.IdleBorderThickness = 1;
            this.btnGuardar.IdleCornerRadius = 20;
            this.btnGuardar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(109)))), ((int)(((byte)(86)))));
            this.btnGuardar.IdleForecolor = System.Drawing.Color.White;
            this.btnGuardar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(72)))), ((int)(((byte)(57)))));
            this.btnGuardar.Location = new System.Drawing.Point(65, 319);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(337, 52);
            this.btnGuardar.TabIndex = 36;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            // FormMenuInventarioEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(468, 383);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenuInventarioEditar";
            this.Text = "FormMenuInventarioEditar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asterisco4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asterisco3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asterisco2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asterisco1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGuardar;
        private System.Windows.Forms.NumericUpDown txtCant;
        private FontAwesome.Sharp.IconPictureBox asterisco4;
        private FontAwesome.Sharp.IconPictureBox asterisco3;
        private FontAwesome.Sharp.IconPictureBox asterisco2;
        private FontAwesome.Sharp.IconPictureBox asterisco1;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Tulpep.NotificationWindow.PopupNotifier popupNotifier1;
    }
}