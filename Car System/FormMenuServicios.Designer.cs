namespace Car_System
{
    partial class FormMenuServicios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuServicios));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnEliminarServicio = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEditarServicio = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnNuevoServicio = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_cot = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1166, 100);
            this.panel2.TabIndex = 21;
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
            this.btnCerrar.Location = new System.Drawing.Point(1128, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Rotation = 0D;
            this.btnCerrar.Size = new System.Drawing.Size(38, 38);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(311, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servicios";
            // 
            // dgvServicios
            // 
            this.dgvServicios.AllowUserToAddRows = false;
            this.dgvServicios.AllowUserToDeleteRows = false;
            this.dgvServicios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvServicios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvServicios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(99)))));
            this.dgvServicios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvServicios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvServicios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvServicios.ColumnHeadersHeight = 35;
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServicios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvServicios.EnableHeadersVisualStyles = false;
            this.dgvServicios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(99)))));
            this.dgvServicios.Location = new System.Drawing.Point(12, 144);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.ReadOnly = true;
            this.dgvServicios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServicios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvServicios.RowHeadersVisible = false;
            this.dgvServicios.RowHeadersWidth = 50;
            this.dgvServicios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServicios.Size = new System.Drawing.Size(880, 441);
            this.dgvServicios.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(94, 106);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.ShortcutsEnabled = false;
            this.txtBuscar.Size = new System.Drawing.Size(798, 31);
            this.txtBuscar.TabIndex = 30;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnEliminarServicio
            // 
            this.btnEliminarServicio.ActiveBorderThickness = 1;
            this.btnEliminarServicio.ActiveCornerRadius = 20;
            this.btnEliminarServicio.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(72)))), ((int)(((byte)(57)))));
            this.btnEliminarServicio.ActiveForecolor = System.Drawing.Color.White;
            this.btnEliminarServicio.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(72)))), ((int)(((byte)(57)))));
            this.btnEliminarServicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.btnEliminarServicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarServicio.BackgroundImage")));
            this.btnEliminarServicio.ButtonText = "Eliminar Servicio";
            this.btnEliminarServicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarServicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarServicio.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnEliminarServicio.IdleBorderThickness = 1;
            this.btnEliminarServicio.IdleCornerRadius = 20;
            this.btnEliminarServicio.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(109)))), ((int)(((byte)(86)))));
            this.btnEliminarServicio.IdleForecolor = System.Drawing.Color.White;
            this.btnEliminarServicio.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(72)))), ((int)(((byte)(57)))));
            this.btnEliminarServicio.Location = new System.Drawing.Point(912, 257);
            this.btnEliminarServicio.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnEliminarServicio.Name = "btnEliminarServicio";
            this.btnEliminarServicio.Size = new System.Drawing.Size(228, 56);
            this.btnEliminarServicio.TabIndex = 36;
            this.btnEliminarServicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEditarServicio
            // 
            this.btnEditarServicio.ActiveBorderThickness = 1;
            this.btnEditarServicio.ActiveCornerRadius = 20;
            this.btnEditarServicio.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(72)))), ((int)(((byte)(57)))));
            this.btnEditarServicio.ActiveForecolor = System.Drawing.Color.White;
            this.btnEditarServicio.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(72)))), ((int)(((byte)(57)))));
            this.btnEditarServicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.btnEditarServicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditarServicio.BackgroundImage")));
            this.btnEditarServicio.ButtonText = " Editar Servicio";
            this.btnEditarServicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarServicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarServicio.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnEditarServicio.IdleBorderThickness = 1;
            this.btnEditarServicio.IdleCornerRadius = 20;
            this.btnEditarServicio.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(109)))), ((int)(((byte)(86)))));
            this.btnEditarServicio.IdleForecolor = System.Drawing.Color.White;
            this.btnEditarServicio.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(72)))), ((int)(((byte)(57)))));
            this.btnEditarServicio.Location = new System.Drawing.Point(912, 191);
            this.btnEditarServicio.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnEditarServicio.Name = "btnEditarServicio";
            this.btnEditarServicio.Size = new System.Drawing.Size(228, 56);
            this.btnEditarServicio.TabIndex = 35;
            this.btnEditarServicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNuevoServicio
            // 
            this.btnNuevoServicio.ActiveBorderThickness = 1;
            this.btnNuevoServicio.ActiveCornerRadius = 20;
            this.btnNuevoServicio.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(72)))), ((int)(((byte)(57)))));
            this.btnNuevoServicio.ActiveForecolor = System.Drawing.Color.White;
            this.btnNuevoServicio.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(72)))), ((int)(((byte)(57)))));
            this.btnNuevoServicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.btnNuevoServicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevoServicio.BackgroundImage")));
            this.btnNuevoServicio.ButtonText = "Nuevo Servicio";
            this.btnNuevoServicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoServicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoServicio.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnNuevoServicio.IdleBorderThickness = 1;
            this.btnNuevoServicio.IdleCornerRadius = 20;
            this.btnNuevoServicio.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(109)))), ((int)(((byte)(86)))));
            this.btnNuevoServicio.IdleForecolor = System.Drawing.Color.White;
            this.btnNuevoServicio.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(72)))), ((int)(((byte)(57)))));
            this.btnNuevoServicio.Location = new System.Drawing.Point(912, 125);
            this.btnNuevoServicio.Margin = new System.Windows.Forms.Padding(5);
            this.btnNuevoServicio.Name = "btnNuevoServicio";
            this.btnNuevoServicio.Size = new System.Drawing.Size(228, 56);
            this.btnNuevoServicio.TabIndex = 34;
            this.btnNuevoServicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_cot
            // 
            this.btn_cot.ActiveBorderThickness = 1;
            this.btn_cot.ActiveCornerRadius = 20;
            this.btn_cot.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(72)))), ((int)(((byte)(57)))));
            this.btn_cot.ActiveForecolor = System.Drawing.Color.White;
            this.btn_cot.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(72)))), ((int)(((byte)(57)))));
            this.btn_cot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.btn_cot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cot.BackgroundImage")));
            this.btn_cot.ButtonText = "Cotización";
            this.btn_cot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cot.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cot.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_cot.IdleBorderThickness = 1;
            this.btn_cot.IdleCornerRadius = 20;
            this.btn_cot.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(109)))), ((int)(((byte)(86)))));
            this.btn_cot.IdleForecolor = System.Drawing.Color.White;
            this.btn_cot.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(72)))), ((int)(((byte)(57)))));
            this.btn_cot.Location = new System.Drawing.Point(912, 520);
            this.btn_cot.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_cot.Name = "btn_cot";
            this.btn_cot.Size = new System.Drawing.Size(228, 56);
            this.btn_cot.TabIndex = 37;
            this.btn_cot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMenuServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1166, 658);
            this.Controls.Add(this.btn_cot);
            this.Controls.Add(this.btnEliminarServicio);
            this.Controls.Add(this.btnEditarServicio);
            this.Controls.Add(this.btnNuevoServicio);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvServicios);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenuServicios";
            this.Text = "FormMenuServicios";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEliminarServicio;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEditarServicio;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNuevoServicio;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_cot;
    }
}