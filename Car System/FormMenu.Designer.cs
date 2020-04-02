namespace Car_System
{
    partial class FormMenu
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
            this.panelForms = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnContraer = new FontAwesome.Sharp.IconButton();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAjustes = new FontAwesome.Sharp.IconButton();
            this.btnProveedores = new FontAwesome.Sharp.IconButton();
            this.btnServicios = new FontAwesome.Sharp.IconButton();
            this.btnInventario = new FontAwesome.Sharp.IconButton();
            this.btnCliente = new FontAwesome.Sharp.IconButton();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblRango = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.timerHora_Fecha = new System.Windows.Forms.Timer(this.components);
            this.panelForms.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.panelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelForms
            // 
            this.panelForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.panelForms.Controls.Add(this.label1);
            this.panelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForms.Location = new System.Drawing.Point(220, 40);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(1166, 658);
            this.panelForms.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(1064, 755);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Car system";
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(179)))));
            this.panelSuperior.Controls.Add(this.label2);
            this.panelSuperior.Controls.Add(this.btnContraer);
            this.panelSuperior.Controls.Add(this.btnMinimizar);
            this.panelSuperior.Controls.Add(this.btnCerrar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(220, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1166, 40);
            this.panelSuperior.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mike mlp";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnContraer
            // 
            this.btnContraer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnContraer.FlatAppearance.BorderSize = 0;
            this.btnContraer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContraer.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnContraer.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btnContraer.IconColor = System.Drawing.Color.White;
            this.btnContraer.IconSize = 25;
            this.btnContraer.Location = new System.Drawing.Point(3, 2);
            this.btnContraer.Name = "btnContraer";
            this.btnContraer.Rotation = 0D;
            this.btnContraer.Size = new System.Drawing.Size(38, 38);
            this.btnContraer.TabIndex = 2;
            this.btnContraer.UseVisualStyleBackColor = true;
            this.btnContraer.Click += new System.EventHandler(this.btnContraer_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.Color.White;
            this.btnMinimizar.IconSize = 25;
            this.btnMinimizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimizar.Location = new System.Drawing.Point(1078, -1);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Rotation = 0D;
            this.btnMinimizar.Size = new System.Drawing.Size(35, 40);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
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
            this.btnCerrar.Location = new System.Drawing.Point(1119, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Rotation = 0D;
            this.btnCerrar.Size = new System.Drawing.Size(38, 38);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 788);
            this.panel1.TabIndex = 5;
            // 
            // btnAjustes
            // 
            this.btnAjustes.BackColor = System.Drawing.Color.Transparent;
            this.btnAjustes.FlatAppearance.BorderSize = 0;
            this.btnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjustes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAjustes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjustes.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnAjustes.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.btnAjustes.IconColor = System.Drawing.Color.White;
            this.btnAjustes.IconSize = 45;
            this.btnAjustes.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAjustes.Location = new System.Drawing.Point(0, 370);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Rotation = 0D;
            this.btnAjustes.Size = new System.Drawing.Size(220, 50);
            this.btnAjustes.TabIndex = 11;
            this.btnAjustes.Text = "     Ajustes";
            this.btnAjustes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjustes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjustes.UseVisualStyleBackColor = false;
            this.btnAjustes.MouseEnter += new System.EventHandler(this.btnAjustes_MouseEnter);
            this.btnAjustes.MouseLeave += new System.EventHandler(this.btnAjustes_MouseLeave);
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.Transparent;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnProveedores.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnProveedores.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnProveedores.IconColor = System.Drawing.Color.White;
            this.btnProveedores.IconSize = 45;
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnProveedores.Location = new System.Drawing.Point(0, 310);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Rotation = 0D;
            this.btnProveedores.Size = new System.Drawing.Size(220, 50);
            this.btnProveedores.TabIndex = 10;
            this.btnProveedores.Text = "     Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProveedores.UseVisualStyleBackColor = false;
            this.btnProveedores.MouseEnter += new System.EventHandler(this.btnProveedores_MouseEnter);
            this.btnProveedores.MouseLeave += new System.EventHandler(this.btnProveedores_MouseLeave);
            // 
            // btnServicios
            // 
            this.btnServicios.BackColor = System.Drawing.Color.Transparent;
            this.btnServicios.FlatAppearance.BorderSize = 0;
            this.btnServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicios.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnServicios.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicios.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnServicios.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.btnServicios.IconColor = System.Drawing.Color.White;
            this.btnServicios.IconSize = 45;
            this.btnServicios.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnServicios.Location = new System.Drawing.Point(0, 250);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Rotation = 0D;
            this.btnServicios.Size = new System.Drawing.Size(220, 50);
            this.btnServicios.TabIndex = 9;
            this.btnServicios.Text = "     Servicios";
            this.btnServicios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnServicios.UseVisualStyleBackColor = false;
            this.btnServicios.MouseEnter += new System.EventHandler(this.btnServicios_MouseEnter);
            this.btnServicios.MouseLeave += new System.EventHandler(this.btnServicios_MouseLeave);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.Transparent;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnInventario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnInventario.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.btnInventario.IconColor = System.Drawing.Color.White;
            this.btnInventario.IconSize = 45;
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnInventario.Location = new System.Drawing.Point(0, 190);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Rotation = 0D;
            this.btnInventario.Size = new System.Drawing.Size(220, 50);
            this.btnInventario.TabIndex = 8;
            this.btnInventario.Text = "     Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.MouseEnter += new System.EventHandler(this.btnInventario_MouseEnter);
            this.btnInventario.MouseLeave += new System.EventHandler(this.btnInventario_MouseLeave);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCliente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnCliente.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnCliente.IconColor = System.Drawing.Color.White;
            this.btnCliente.IconSize = 45;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(0, 130);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Rotation = 0D;
            this.btnCliente.Size = new System.Drawing.Size(220, 50);
            this.btnCliente.TabIndex = 7;
            this.btnCliente.Text = "     Clientes";
            this.btnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            this.btnCliente.MouseEnter += new System.EventHandler(this.btnCliente_MouseEnter);
            this.btnCliente.MouseLeave += new System.EventHandler(this.btnCliente_MouseLeave);
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.panelBotones.Controls.Add(this.btnAjustes);
            this.panelBotones.Controls.Add(this.btnCliente);
            this.panelBotones.Controls.Add(this.btnProveedores);
            this.panelBotones.Controls.Add(this.btnInventario);
            this.panelBotones.Controls.Add(this.btnServicios);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBotones.Location = new System.Drawing.Point(0, 0);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(220, 788);
            this.panelBotones.TabIndex = 7;
            // 
            // panelDatos
            // 
            this.panelDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.panelDatos.Controls.Add(this.lblFecha);
            this.panelDatos.Controls.Add(this.lblHora);
            this.panelDatos.Controls.Add(this.lblRango);
            this.panelDatos.Controls.Add(this.lblUsuario);
            this.panelDatos.Controls.Add(this.iconPictureBox1);
            this.panelDatos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDatos.Location = new System.Drawing.Point(220, 698);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(1166, 90);
            this.panelDatos.TabIndex = 8;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(834, 47);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(280, 22);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Lunes, 26 de septiembre 2018";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(891, 3);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(166, 44);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "21:49:45";
            // 
            // lblRango
            // 
            this.lblRango.AutoSize = true;
            this.lblRango.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRango.ForeColor = System.Drawing.Color.White;
            this.lblRango.Location = new System.Drawing.Point(91, 54);
            this.lblRango.Name = "lblRango";
            this.lblRango.Size = new System.Drawing.Size(57, 20);
            this.lblRango.TabIndex = 2;
            this.lblRango.Text = "Rango";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(91, 27);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(63, 20);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconSize = 64;
            this.iconPictureBox1.Location = new System.Drawing.Point(6, 16);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(79, 64);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // timerHora_Fecha
            // 
            this.timerHora_Fecha.Tick += new System.EventHandler(this.timerHora_Fecha_Tick);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.panelForms);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panelForms.ResumeLayout(false);
            this.panelForms.PerformLayout();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelForms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnAjustes;
        private FontAwesome.Sharp.IconButton btnProveedores;
        private FontAwesome.Sharp.IconButton btnServicios;
        private FontAwesome.Sharp.IconButton btnInventario;
        private FontAwesome.Sharp.IconButton btnCliente;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Panel panelSuperior;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnContraer;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblRango;
        private System.Windows.Forms.Label lblUsuario;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Timer timerHora_Fecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label2;
    }
}