using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using MySql.Data.MySqlClient;

namespace Car_System
{
    public partial class FormMenuClientesAgregar : Form
    {
        public FormMenuClientesAgregar()
        {
            InitializeComponent();
        }
        //Funciones de los botones
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtNom.Text.Trim() == "" || txtAp.Text.Trim() == "" || txtAm.Text.Trim() == "" || txtTel.Text.Trim() == "")
            {
                PopupNotifier popup = new PopupNotifier();
                popupNotifier1.Image = Properties.Resources.info;
                popupNotifier1.TitleText = "Automotriz Castillo";
                popupNotifier1.ContentText = "Llenar los campos";
                popupNotifier1.Popup();

                asterisco1.Visible = true;
                asterisco2.Visible = true;
                asterisco3.Visible = true;
                asterisco4.Visible = true;
                return;
            }
            MySqlConnection con = Conexion.Obtener_Conexion();
            MySqlCommand com = new MySqlCommand("INSERT INTO `clientes` (`id_cliente`, `nom`, `ap`, `am`, `tel`, `correo`, `rfc`) VALUES (NULL, '"+txtNom.Text+ "', '"+txtAp.Text+ "', '"+txtAm.Text+ "', '"+txtTel.Text+ "', '"+txtCorreo.Text+ "', '"+txtRFC.Text+"');", con);
            int res = com.ExecuteNonQuery();
            if(res>0)
            {
                PopupNotifier popup = new PopupNotifier();
                popupNotifier1.Image = Properties.Resources.info;
                popupNotifier1.TitleText = "Automotriz Castillo";
                popupNotifier1.ContentText = "Se agrego al cliente";
                popupNotifier1.Popup();

                txtNom.Clear();
                txtAp.Clear();
                txtAm.Clear();
                txtTel.Clear();
                txtCorreo.Clear();
                txtRFC.Clear();
                asterisco1.Visible = false;
                asterisco2.Visible = false;
                asterisco3.Visible = false;
                asterisco4.Visible = false;
            }
            else
            {
                PopupNotifier popup = new PopupNotifier();
                popupNotifier1.Image = Properties.Resources.info;
                popupNotifier1.TitleText = "Automotriz Castillo";
                popupNotifier1.ContentText = "No agrego al cliente";
                popupNotifier1.Popup();
            }

        }
        //Eventos para solo un tipo de dato en los textbox
        private void Solo_letras_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Solo_numeros_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Solo_numeros_y_letras_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                PopupNotifier popup = new PopupNotifier();
                popupNotifier1.Image = Properties.Resources.info;
                popupNotifier1.TitleText = "Automotriz Castillo";
                popupNotifier1.ContentText = "No esta permitido el uso de comandos";
                popupNotifier1.Popup();
            }
        }
    }
}
