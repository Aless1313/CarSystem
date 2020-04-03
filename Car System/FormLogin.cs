using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Tulpep.NotificationWindow;

namespace Car_System
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            if (swicht.Value == true)
            {
                lbl_tipodeconexion.Text = "Local";

            }
            else
            {
                lbl_tipodeconexion.Text = "Red";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(swicht.Value == true)
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
                MySqlCommand com = new MySqlCommand("SELECT `id_usuario`, `rang` FROM `usuarios` WHERE `usu` = '"+txtUsu.Text+"' and `con` = '"+txtCon.Text+"'", con);
                MySqlDataReader dr = com.ExecuteReader();
            
                dr.Read();
                if (dr.GetInt32(0) > 0 && dr.GetString(1) != "")
                {
                    PopupNotifier popup = new PopupNotifier();
                    popupNotifier1.Image = Properties.Resources.info;
                    popupNotifier1.TitleText = "Automotriz Castillo";
                    popupNotifier1.ContentText = "Bienvenido";
                    popupNotifier1.Popup();
                    con.Close();
                    this.Close();
                    
                }
                else
                {
                    PopupNotifier popup = new PopupNotifier();
                    popupNotifier1.Image = Properties.Resources.info;
                    popupNotifier1.TitleText = "Automotriz Castillo";
                    popupNotifier1.ContentText = "Error en Usuario o Contraseña";
                    popupNotifier1.Popup();
                    return;
                }
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
