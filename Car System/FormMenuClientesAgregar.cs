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
using System.Runtime.InteropServices;

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
            if (txtNom.Text.Trim() == "" || txtAp.Text.Trim() == "" || txtAm.Text.Trim() == "" || txtTel.Text.Trim() == "")
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
            con.Close();
            if (res > 0)
            {
                PopupNotifier popup = new PopupNotifier();
                popupNotifier1.Image = Properties.Resources.info;
                popupNotifier1.TitleText = "Automotriz Castillo";
                popupNotifier1.ContentText = "Se agrego al cliente";
                popupNotifier1.Popup();
                txtNom.Text = "";
                txtAp.Text = "";
                txtAm.Text = "";
                txtCorreo.Text = "";
                txtTel.Text = "";
                txtRFC.Text = "";

            }
            else
            {
                PopupNotifier popup = new PopupNotifier();
                popupNotifier1.Image = Properties.Resources.info;
                popupNotifier1.TitleText = "Automotriz Castillo";
                popupNotifier1.ContentText = "No pudo agregar al cliente";
                popupNotifier1.Popup();
            }
            con.Close();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        //Librerias para mover el panel con el mouse
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lparam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
