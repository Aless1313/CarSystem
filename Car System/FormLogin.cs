using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Tulpep.NotificationWindow;

namespace Car_System
{
    public partial class FormLogin : Form
    {
        int variable_com_cierre_correcto = 0;
        public FormLogin()
        {
            InitializeComponent();
        }

        public void login()
        {
            if (swicht.Value == true)
            {
                Tipo_de_conexion.ti_con = 1;
            }
            else
            {
                Tipo_de_conexion.ti_con = 0;
            }

            try
            {
                MySqlConnection con = Conexion.Obtener_Conexion();
                MySqlCommand com = new MySqlCommand("SELECT * FROM `usuarios` WHERE `usu` = '" + txtUsu.Text + "' and `con` = '" + txtCon.Text + "'", con);
                MySqlDataReader dr = com.ExecuteReader();
                dr.Read();
                
                if (dr.GetInt32(0) > 0 && dr.GetInt32(4) > 0)
                {
                    Datos_Usu.id_usu = dr.GetInt32(0);
                    Datos_Usu.nomusu = dr.GetString(1);
                    Datos_Usu.usu = dr.GetString(2);
                    Datos_Usu.con = dr.GetString(3);
                    Datos_Usu.rango = dr.GetInt32(4);
                    Datos_Usu.correo = dr.GetString(5);
                    Datos_Usu.tel = dr.GetString(6);

                    switch(Datos_Usu.rango)
                    {
                        case 1:
                            Datos_Usu.rangoSTG = "Colaborador";
                            break;
                        case 2:
                            Datos_Usu.rangoSTG = "Gerente";
                            break;
                        case 3:
                            Datos_Usu.rangoSTG = "Dueño";
                            break;
                        case 4:
                            Datos_Usu.rangoSTG = "Administrador";
                            break;
                    }


                    con.Close();
                    variable_com_cierre_correcto = 1;
                    this.Close();
                }
                else
                {
                    con.Close();
                    PopupNotifier popup = new PopupNotifier();
                    popupNotifier1.Image = Properties.Resources.info;
                    popupNotifier1.TitleText = "Automotriz Castillo";
                    popupNotifier1.ContentText = "Error en Usuario o Contraseña";
                    popupNotifier1.Popup();
                    return;
                }
                this.Close();

            }
            catch
            {
                PopupNotifier popup = new PopupNotifier();
                popupNotifier1.Image = Properties.Resources.info;
                popupNotifier1.TitleText = "Automotriz Castillo";
                popupNotifier1.ContentText = "Error en Usuario o Contraseña";
                popupNotifier1.Popup();
                return;
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }


        private void txtUsu_Enter(object sender, EventArgs e)
        {
            if (txtUsu.Text == "Usuario")
            {
                txtUsu.Text = "";
            }
        }

        private void txtUsu_Leave(object sender, EventArgs e)
        {
            if (txtUsu.Text == "")
            {
                txtUsu.Text = "Usuario";
            }
        }

        private void txtCon_Enter(object sender, EventArgs e)
        {
            if (txtCon.Text == "Contraseña")
            {
                txtCon.Text = "";
                txtCon.UseSystemPasswordChar = true;
            }
        }

        private void txtCon_Leave(object sender, EventArgs e)
        {
            if (txtCon.Text == "")
            {
                txtCon.UseSystemPasswordChar = false;
                txtCon.Text = "Contraseña";
            }
        }

        private void swicht_OnValueChange(object sender, EventArgs e)
        {
            if (swicht.Value == true)
            {
                lbl_tipodeconexion.Text = "Local";

            }
            else
            {
                lbl_tipodeconexion.Text = "Red";
            }
        }


        //Librerias para mover el panel con el mouse
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lparam);

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(variable_com_cierre_correcto == 1)
            {
                this.Close();
            }
            else
            {
                Application.Exit();
            }
        }

        private void Entrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                login();
            }
        }

        private void txtCon_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
