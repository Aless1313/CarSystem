namespace Car_System
{
    partial class FormReporteInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteInventario));
            this.rptinventario = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rptinventario
            // 
            this.rptinventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rptinventario.DocumentMapWidth = 50;
            this.rptinventario.Location = new System.Drawing.Point(12, 108);
            this.rptinventario.Name = "rptinventario";
            this.rptinventario.ServerReport.BearerToken = null;
            this.rptinventario.ShowBackButton = false;
            this.rptinventario.ShowFindControls = false;
            this.rptinventario.ShowStopButton = false;
            this.rptinventario.Size = new System.Drawing.Size(1142, 538);
            this.rptinventario.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1166, 100);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
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
            this.btnCerrar.TabIndex = 40;
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
            this.label1.Size = new System.Drawing.Size(613, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reporte Inventario";
            // 
            // FormReporteInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1166, 658);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rptinventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReporteInventario";
            this.Text = "FormReporteInventario";
            this.Load += new System.EventHandler(this.FormReporteInventario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer rptinventario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnCerrar;
    }
}