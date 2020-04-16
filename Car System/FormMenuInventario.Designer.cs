namespace Car_System
{
    partial class FormMenuInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuInventario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnEliminarpieza = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEditarpieza = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAgregarpieza = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_imprimirinv = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.popupNotifier1 = new Tulpep.NotificationWindow.PopupNotifier();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1166, 100);
            this.panel1.TabIndex = 0;
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
            this.label1.Size = new System.Drawing.Size(346, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // btnEliminarpieza
            // 
            this.btnEliminarpieza.ActiveBorderThickness = 1;
            this.btnEliminarpieza.ActiveCornerRadius = 20;
            this.btnEliminarpieza.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(72)))), ((int)(((byte)(57)))));
            this.btnEliminarpieza.ActiveForecolor = System.Drawing.Color.White;
            this.btnEliminarpieza.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(72)))), ((int)(((byte)(57)))));
            this.btnEliminarpieza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarpieza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.btnEliminarpieza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarpieza.BackgroundImage")));
            this.btnEliminarpieza.ButtonText = "Eliminar Pieza";
            this.btnEliminarpieza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarpieza.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarpieza.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnEliminarpieza.IdleBorderThickness = 1;
            this.btnEliminarpieza.IdleCornerRadius = 20;
            this.btnEliminarpieza.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(109)))), ((int)(((byte)(86)))));
            this.btnEliminarpieza.IdleForecolor = System.Drawing.Color.White;
            this.btnEliminarpieza.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(72)))), ((int)(((byte)(57)))));
            this.btnEliminarpieza.Location = new System.Drawing.Point(912, 254);
            this.btnEliminarpieza.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnEliminarpieza.Name = "btnEliminarpieza";
            this.btnEliminarpieza.Size = new System.Drawing.Size(228, 56);
            this.btnEliminarpieza.TabIndex = 37;
            this.btnEliminarpieza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminarpieza.Click += new System.EventHandler(this.btnEliminarpieza_Click);
            // 
            // btnEditarpieza
            // 
            this.btnEditarpieza.ActiveBorderThickness = 1;
            this.btnEditarpieza.ActiveCornerRadius = 20;
            this.btnEditarpieza.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(72)))), ((int)(((byte)(57)))));
            this.btnEditarpieza.ActiveForecolor = System.Drawing.Color.White;
            this.btnEditarpieza.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(72)))), ((int)(((byte)(57)))));
            this.btnEditarpieza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarpieza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.btnEditarpieza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditarpieza.BackgroundImage")));
            this.btnEditarpieza.ButtonText = "Editar Pieza";
            this.btnEditarpieza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarpieza.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarpieza.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnEditarpieza.IdleBorderThickness = 1;
            this.btnEditarpieza.IdleCornerRadius = 20;
            this.btnEditarpieza.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(109)))), ((int)(((byte)(86)))));
            this.btnEditarpieza.IdleForecolor = System.Drawing.Color.White;
            this.btnEditarpieza.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(72)))), ((int)(((byte)(57)))));
            this.btnEditarpieza.Location = new System.Drawing.Point(912, 188);
            this.btnEditarpieza.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnEditarpieza.Name = "btnEditarpieza";
            this.btnEditarpieza.Size = new System.Drawing.Size(228, 56);
            this.btnEditarpieza.TabIndex = 36;
            this.btnEditarpieza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditarpieza.Click += new System.EventHandler(this.btnEditarpieza_Click);
            // 
            // btnAgregarpieza
            // 
            this.btnAgregarpieza.ActiveBorderThickness = 1;
            this.btnAgregarpieza.ActiveCornerRadius = 20;
            this.btnAgregarpieza.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(72)))), ((int)(((byte)(57)))));
            this.btnAgregarpieza.ActiveForecolor = System.Drawing.Color.White;
            this.btnAgregarpieza.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(72)))), ((int)(((byte)(57)))));
            this.btnAgregarpieza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarpieza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.btnAgregarpieza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarpieza.BackgroundImage")));
            this.btnAgregarpieza.ButtonText = "Agregar Pieza";
            this.btnAgregarpieza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarpieza.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarpieza.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAgregarpieza.IdleBorderThickness = 1;
            this.btnAgregarpieza.IdleCornerRadius = 20;
            this.btnAgregarpieza.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(109)))), ((int)(((byte)(86)))));
            this.btnAgregarpieza.IdleForecolor = System.Drawing.Color.White;
            this.btnAgregarpieza.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(72)))), ((int)(((byte)(57)))));
            this.btnAgregarpieza.Location = new System.Drawing.Point(912, 125);
            this.btnAgregarpieza.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregarpieza.Name = "btnAgregarpieza";
            this.btnAgregarpieza.Size = new System.Drawing.Size(228, 56);
            this.btnAgregarpieza.TabIndex = 35;
            this.btnAgregarpieza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarpieza.Click += new System.EventHandler(this.btnAgregarpieza_Click);
            // 
            // btn_imprimirinv
            // 
            this.btn_imprimirinv.ActiveBorderThickness = 1;
            this.btn_imprimirinv.ActiveCornerRadius = 20;
            this.btn_imprimirinv.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(72)))), ((int)(((byte)(57)))));
            this.btn_imprimirinv.ActiveForecolor = System.Drawing.Color.White;
            this.btn_imprimirinv.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(72)))), ((int)(((byte)(57)))));
            this.btn_imprimirinv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_imprimirinv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.btn_imprimirinv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_imprimirinv.BackgroundImage")));
            this.btn_imprimirinv.ButtonText = "Imprimir Inventario";
            this.btn_imprimirinv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_imprimirinv.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimirinv.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_imprimirinv.IdleBorderThickness = 1;
            this.btn_imprimirinv.IdleCornerRadius = 20;
            this.btn_imprimirinv.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(109)))), ((int)(((byte)(86)))));
            this.btn_imprimirinv.IdleForecolor = System.Drawing.Color.White;
            this.btn_imprimirinv.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(72)))), ((int)(((byte)(57)))));
            this.btn_imprimirinv.Location = new System.Drawing.Point(912, 463);
            this.btn_imprimirinv.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_imprimirinv.Name = "btn_imprimirinv";
            this.btn_imprimirinv.Size = new System.Drawing.Size(228, 56);
            this.btn_imprimirinv.TabIndex = 38;
            this.btn_imprimirinv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_imprimirinv.Click += new System.EventHandler(this.btn_imprimirinv_Click);
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
            this.btnCerrar.TabIndex = 39;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToDeleteRows = false;
            this.dgvInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInventario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(99)))));
            this.dgvInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvInventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventario.ColumnHeadersHeight = 35;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventario.EnableHeadersVisualStyles = false;
            this.dgvInventario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(99)))));
            this.dgvInventario.Location = new System.Drawing.Point(12, 144);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInventario.RowHeadersVisible = false;
            this.dgvInventario.RowHeadersWidth = 50;
            this.dgvInventario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.Size = new System.Drawing.Size(880, 441);
            this.dgvInventario.TabIndex = 40;
            this.dgvInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellContentClick);
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
            // FormMenuInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1166, 658);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btn_imprimirinv);
            this.Controls.Add(this.btnEliminarpieza);
            this.Controls.Add(this.btnEditarpieza);
            this.Controls.Add(this.btnAgregarpieza);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenuInventario";
            this.Text = "FormMenuInventario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEliminarpieza;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEditarpieza;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAgregarpieza;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_imprimirinv;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.DataGridView dgvInventario;
        private Tulpep.NotificationWindow.PopupNotifier popupNotifier1;
    }
}