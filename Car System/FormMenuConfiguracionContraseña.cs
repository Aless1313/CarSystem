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
    public partial class FormMenuConfiguracionContraseña : Form
    {
        public FormMenuConfiguracionContraseña()
        {
            InitializeComponent();
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtConN1.Text == txtConN2.Text )
            {
                if (MessageBox.Show("¿Esta seguro que desea cambiar la contraseña?:", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlConnection con = Conexion.Obtener_Conexion();
                    MySqlCommand com = new MySqlCommand("UPDATE `usuarios` SET `con` = '"+txtConN1.Text+"' where `id_usuario` = "+Datos_Usu.id_usu+" ", con);
                    int res = com.ExecuteNonQuery();
                    if(res > 0)
                    {
                        Datos_Usu.con = txtConN1.Text;
                        PopupNotifier popup = new PopupNotifier();
                        popupNotifier1.Image = Properties.Resources.info;
                        popupNotifier1.TitleText = "Automotriz Castillo";
                        popupNotifier1.ContentText = "Se cambio la contraseña";
                        popupNotifier1.Popup();
                        this.Close();
                    }
                    else
                    {
                        PopupNotifier popup = new PopupNotifier();
                        popupNotifier1.Image = Properties.Resources.info;
                        popupNotifier1.TitleText = "Automotriz Castillo";
                        popupNotifier1.ContentText = "No se cambio la contraseña";
                        popupNotifier1.Popup();
                    }
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
