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
    public partial class FormMenuConfiguracionNombre : Form
    {
        public FormMenuConfiguracionNombre()
        {
            InitializeComponent();
            txtNom.Text = Datos_Usu.nomusu;
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            if(txtCon.Text == Datos_Usu.con)
            {
                ck2.Checked = true;
                xuiFlatTab1.SelectTab(1);
            }
            else
            {
                PopupNotifier popup = new PopupNotifier();
                popupNotifier1.Image = Properties.Resources.info;
                popupNotifier1.TitleText = "Automotriz Castillo";
                popupNotifier1.ContentText = "Contraseña Incorrecta";
                popupNotifier1.Popup();
            }
        }

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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea cambiar el nombre?:", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MySqlConnection con = Conexion.Obtener_Conexion();
                MySqlCommand com = new MySqlCommand("UPDATE `usuarios` SET `nom_usu` = '" + txtNom.Text + "' where `id_usuario` = " + Datos_Usu.id_usu + " ", con);
                int res = com.ExecuteNonQuery();
                if (res > 0)
                {
                    Datos_Usu.nomusu = txtNom.Text;
                    PopupNotifier popup = new PopupNotifier();
                    popupNotifier1.Image = Properties.Resources.info;
                    popupNotifier1.TitleText = "Automotriz Castillo";
                    popupNotifier1.ContentText = "Se cambio el nombre";
                    popupNotifier1.Popup();
                    this.Close();
                }
                else
                {
                    PopupNotifier popup = new PopupNotifier();
                    popupNotifier1.Image = Properties.Resources.info;
                    popupNotifier1.TitleText = "Automotriz Castillo";
                    popupNotifier1.ContentText = "No se cambio la usuario";
                    popupNotifier1.Popup();
                }
            }
        }

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
