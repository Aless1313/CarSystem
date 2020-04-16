namespace Car_System
{
    partial class FormMenuPersonalEditarPrivilegios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPersonalEditarPrivilegios));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.ck1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ck2 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label2 = new System.Windows.Forms.Label();
            this.xuiFlatTab1 = new XanderUI.XUIFlatTab();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSig = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtCon = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ckbTel = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.xuiFlatTab1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(179)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 39);
            this.panel2.TabIndex = 125;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(138, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Editar Privilegios";
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
            this.btnCerrar.Location = new System.Drawing.Point(375, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Rotation = 0D;
            this.btnCerrar.Size = new System.Drawing.Size(38, 38);
            this.btnCerrar.TabIndex = 26;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // ck1
            // 
            this.ck1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(109)))), ((int)(((byte)(86)))));
            this.ck1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ck1.Checked = true;
            this.ck1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(109)))), ((int)(((byte)(86)))));
            this.ck1.Enabled = false;
            this.ck1.ForeColor = System.Drawing.Color.White;
            this.ck1.Location = new System.Drawing.Point(50, 77);
            this.ck1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ck1.Name = "ck1";
            this.ck1.Size = new System.Drawing.Size(20, 20);
            this.ck1.TabIndex = 128;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(64, 59);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(135, 57);
            this.label17.TabIndex = 130;
            this.label17.Text = "Comprobar\r\ncontraseña \r\nde Administrador";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(182, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 2);
            this.panel1.TabIndex = 132;
            // 
            // ck2
            // 
            this.ck2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ck2.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ck2.Checked = false;
            this.ck2.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(109)))), ((int)(((byte)(86)))));
            this.ck2.Enabled = false;
            this.ck2.ForeColor = System.Drawing.Color.White;
            this.ck2.Location = new System.Drawing.Point(245, 77);
            this.ck2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ck2.Name = "ck2";
            this.ck2.Size = new System.Drawing.Size(20, 20);
            this.ck2.TabIndex = 129;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(271, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 38);
            this.label2.TabIndex = 133;
            this.label2.Text = "Cambio de\rprivilegios";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xuiFlatTab1
            // 
            this.xuiFlatTab1.ActiveHeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(179)))));
            this.xuiFlatTab1.ActiveTextColor = System.Drawing.Color.White;
            this.xuiFlatTab1.BorderColor = System.Drawing.Color.Transparent;
            this.xuiFlatTab1.Controls.Add(this.tabPage1);
            this.xuiFlatTab1.Controls.Add(this.tabPage2);
            this.xuiFlatTab1.HeaderBackgroundColor = System.Drawing.Color.LightGray;
            this.xuiFlatTab1.InActiveHeaderColor = System.Drawing.Color.DimGray;
            this.xuiFlatTab1.InActiveTextColor = System.Drawing.Color.White;
            this.xuiFlatTab1.ItemSize = new System.Drawing.Size(240, 16);
            this.xuiFlatTab1.Location = new System.Drawing.Point(0, 129);
            this.xuiFlatTab1.Name = "xuiFlatTab1";
            this.xuiFlatTab1.PageColor = System.Drawing.Color.LightGray;
            this.xuiFlatTab1.SelectedIndex = 0;
            this.xuiFlatTab1.ShowBorder = true;
            this.xuiFlatTab1.Size = new System.Drawing.Size(423, 205);
            this.xuiFlatTab1.TabIndex = 134;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.btnSig);
            this.tabPage1.Controls.Add(this.txtCon);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 20);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(415, 181);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(107, -23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 25);
            this.panel4.TabIndex = 134;
            // 
            // btnSig
            // 
            this.btnSig.ActiveBorderThickness = 1;
            this.btnSig.ActiveCornerRadius = 20;
            this.btnSig.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(72)))), ((int)(((byte)(57)))));
            this.btnSig.ActiveForecolor = System.Drawing.Color.White;
            this.btnSig.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(72)))), ((int)(((byte)(57)))));
            this.btnSig.BackColor = System.Drawing.Color.LightGray;
            this.btnSig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSig.BackgroundImage")));
            this.btnSig.ButtonText = "Siguiente";
            this.btnSig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSig.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSig.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSig.IdleBorderThickness = 1;
            this.btnSig.IdleCornerRadius = 20;
            this.btnSig.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(109)))), ((int)(((byte)(86)))));
            this.btnSig.IdleForecolor = System.Drawing.Color.White;
            this.btnSig.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(72)))), ((int)(((byte)(57)))));
            this.btnSig.Location = new System.Drawing.Point(64, 117);
            this.btnSig.Margin = new System.Windows.Forms.Padding(5);
            this.btnSig.Name = "btnSig";
            this.btnSig.Size = new System.Drawing.Size(294, 52);
            this.btnSig.TabIndex = 34;
            this.btnSig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSig.Click += new System.EventHandler(this.btnSig_Click);
            // 
            // txtCon
            // 
            this.txtCon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCon.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCon.Location = new System.Drawing.Point(85, 80);
            this.txtCon.MaxLength = 50;
            this.txtCon.Name = "txtCon";
            this.txtCon.ShortcutsEnabled = false;
            this.txtCon.Size = new System.Drawing.Size(252, 24);
            this.txtCon.TabIndex = 32;
            this.txtCon.UseSystemPasswordChar = true;
            this.txtCon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCon_KeyDown);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(3, -28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 25);
            this.panel3.TabIndex = 127;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(90, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 21);
            this.label3.TabIndex = 33;
            this.label3.Text = "Contraseña de Administrador";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.checkBox5);
            this.tabPage2.Controls.Add(this.checkBox3);
            this.tabPage2.Controls.Add(this.checkBox2);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.ckbTel);
            this.tabPage2.Controls.Add(this.btnGuardar);
            this.tabPage2.Location = new System.Drawing.Point(4, 20);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(415, 181);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(155, 30);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(140, 25);
            this.checkBox5.TabIndex = 45;
            this.checkBox5.Text = "Configuración";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(155, 6);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(110, 25);
            this.checkBox3.TabIndex = 43;
            this.checkBox3.Text = "Inventario";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(8, 68);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(94, 25);
            this.checkBox2.TabIndex = 42;
            this.checkBox2.Text = "Servicios";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(8, 37);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 25);
            this.checkBox1.TabIndex = 41;
            this.checkBox1.Text = "Autos";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ckbTel
            // 
            this.ckbTel.AutoSize = true;
            this.ckbTel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTel.Location = new System.Drawing.Point(8, 6);
            this.ckbTel.Name = "ckbTel";
            this.ckbTel.Size = new System.Drawing.Size(91, 25);
            this.ckbTel.TabIndex = 40;
            this.ckbTel.Text = "Clientes";
            this.ckbTel.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.ActiveBorderThickness = 1;
            this.btnGuardar.ActiveCornerRadius = 20;
            this.btnGuardar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(72)))), ((int)(((byte)(57)))));
            this.btnGuardar.ActiveForecolor = System.Drawing.Color.White;
            this.btnGuardar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(72)))), ((int)(((byte)(57)))));
            this.btnGuardar.BackColor = System.Drawing.Color.LightGray;
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
            this.btnGuardar.Location = new System.Drawing.Point(64, 117);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(294, 52);
            this.btnGuardar.TabIndex = 37;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(-6, 126);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 25);
            this.panel5.TabIndex = 135;
            // 
            // FormMenuPersonalEditarPrivilegios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(423, 335);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.xuiFlatTab1);
            this.Controls.Add(this.ck1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ck2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenuPersonalEditarPrivilegios";
            this.Text = "FormMenuPersonalEditarPrivilegios";
            this.Load += new System.EventHandler(this.FormMenuPersonalEditarPrivilegios_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.xuiFlatTab1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private Bunifu.Framework.UI.BunifuCheckbox ck1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCheckbox ck2;
        private System.Windows.Forms.Label label2;
        private XanderUI.XUIFlatTab xuiFlatTab1;
        private System.Windows.Forms.TabPage tabPage1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSig;
        private System.Windows.Forms.TextBox txtCon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox ckbTel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGuardar;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}