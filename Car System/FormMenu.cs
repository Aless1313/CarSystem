﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Car_System
{
    public partial class FormMenu : Form
    {
        

        public FormMenu()
        {
            Form login = new FormLogin();
            login.ShowDialog();

            //Form splash = new FormSplash();
            //splash.ShowDialog();


            InitializeComponent();
            panelBotones.Width = 53;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            timerHora_Fecha.Start();
            lblNombre.Text = Datos_Usu.nomusu;
            lblRango.Text = Datos_Usu.rangoSTG;
        }
        //Botones
        //Botones del panel superior
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }

        private void btnContraer_Click(object sender, EventArgs e)
        {
           
            if (panelBotones.Width == 220)
            {
                
                panelBotones.Width = 53;
            }
            else
            {
                panelBotones.Width = 220;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }




        //Eventos
        //Botones del Menu
        //Boton Cliente
        private void btnCliente_MouseEnter(object sender, EventArgs e)
        {
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.BackColor = Color.FromArgb(0, 110, 179);
        }
        private void btnCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.BackColor = Color.Transparent;
        }
        //Boton Inventario
        private void btnInventario_MouseEnter(object sender, EventArgs e)
        {
            btnInventario.UseVisualStyleBackColor = false;
            btnInventario.BackColor = Color.FromArgb(0, 110, 179);
        }
        private void btnInventario_MouseLeave(object sender, EventArgs e)
        {
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.BackColor = Color.Transparent;
        }
        //Boton Servicios
        private void btnServicios_MouseEnter(object sender, EventArgs e)
        {
            btnServicios.UseVisualStyleBackColor = false;
            btnServicios.BackColor = Color.FromArgb(0, 110, 179);
        }
        private void btnServicios_MouseLeave(object sender, EventArgs e)
        {
            btnServicios.UseVisualStyleBackColor = true;
            btnServicios.BackColor = Color.Transparent;

        }
      
      
        //BotonAjustes
        private void btnAjustes_MouseEnter(object sender, EventArgs e)
        {
            btnAjustes.UseVisualStyleBackColor = false;
            btnAjustes.BackColor = Color.FromArgb(0, 110, 179);
        }
        private void btnAjustes_MouseLeave(object sender, EventArgs e)
        {
            btnAjustes.UseVisualStyleBackColor = true;
            btnAjustes.BackColor = Color.Transparent;
        }
        //BotonAuto
        private void btnAuto_MouseEnter(object sender, EventArgs e)
        {
            btnAuto.UseVisualStyleBackColor = false;
            btnAuto.BackColor = Color.FromArgb(0, 110, 179);
        }

        private void btnAuto_MouseLeave(object sender, EventArgs e)
        {
            btnAuto.UseVisualStyleBackColor = true;
            btnAuto.BackColor = Color.Transparent;
        }
        //BotonPersonal
        private void btn_personal_MouseEnter(object sender, EventArgs e)
        {
            btn_personal.UseVisualStyleBackColor = false;
            btn_personal.BackColor = Color.FromArgb(0, 110, 179);
        }

        private void btn_personal_MouseLeave(object sender, EventArgs e)
        {
            btn_personal.UseVisualStyleBackColor = true;
            btn_personal.BackColor = Color.Transparent;
        }

        private void timerHora_Fecha_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }


        //Como abrir los froms
        private void MostrarFormLogo()
        { 
            OpenForms(new FormPrincipal());
        }
        private void OpenForms(object formHijo)
        {
            if (this.panelForms.Controls.Count > 0)
                this.panelForms.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelForms.Controls.Add(fh);
            this.panelForms.Tag = fh;
            fh.Show();
        }
        

        private void MostrarFormLogoAlCerrarForms(object sender, FormClosedEventArgs e)
        {
            MostrarFormLogo();
        }

        //Tareas de cada boton
        private void btnCliente_Click(object sender, EventArgs e)
        {
            FormMenuClientes fm = new FormMenuClientes();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            OpenForms(fm);
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            MostrarFormLogo();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            FormMenuInventario fmi = new FormMenuInventario();
            fmi.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            OpenForms(fmi);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormPrincipal fm = new FormPrincipal();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            OpenForms(fm);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormPrincipal fm = new FormPrincipal();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            OpenForms(fm);
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            FormMenuServicios fmi = new FormMenuServicios();
            fmi.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            OpenForms(fmi);
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            FormMenuAutos fmi = new FormMenuAutos();
            fmi.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            OpenForms(fmi);
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            FormMenuConfiguracion fmi = new FormMenuConfiguracion();
            fmi.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            OpenForms(fmi);
        }

        private void panelBotones_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void panelBotones_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void btn_personal_Click(object sender, EventArgs e)
        {
            FormMenuPersonal fmp = new FormMenuPersonal();
            fmp.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            OpenForms(fmp);
        }

    }
}
